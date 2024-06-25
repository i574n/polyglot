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

export function US9__get_IsUS9_0(this$: FSharpRef<US9_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US9__get_IsUS9_1(this$: FSharpRef<US9_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US10__get_IsUS10_0(this$: FSharpRef<US10_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US10__get_IsUS10_1(this$: FSharpRef<US10_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US11__get_IsUS11_0(this$: FSharpRef<US11_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US11__get_IsUS11_1(this$: FSharpRef<US11_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US12__get_IsUS12_0(this$: FSharpRef<US12_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US12__get_IsUS12_1(this$: FSharpRef<US12_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US13__get_IsUS13_0(this$: FSharpRef<US13_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US13__get_IsUS13_1(this$: FSharpRef<US13_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US14__get_IsUS14_0(this$: FSharpRef<US14_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US14__get_IsUS14_1(this$: FSharpRef<US14_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function UH2__get_IsUH2_0(this$: UH2_$union, unitArg: void): boolean {
    if ((this$ as any)['tag'] === /* UH2_0 */ 0) {
        return true;
    }
    else {
        return false;
    }
}

export function UH2__get_IsUH2_1(this$: UH2_$union, unitArg: void): boolean {
    if ((this$ as any)['tag'] === /* UH2_1 */ 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US15__get_IsUS15_0(this$: FSharpRef<US15_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US15__get_IsUS15_1(this$: FSharpRef<US15_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function UH3__get_IsUH3_0(this$: UH3_$union, unitArg: void): boolean {
    if ((this$ as any)['tag'] === /* UH3_0 */ 0) {
        return true;
    }
    else {
        return false;
    }
}

export function UH3__get_IsUH3_1(this$: UH3_$union, unitArg: void): boolean {
    if ((this$ as any)['tag'] === /* UH3_1 */ 1) {
        return true;
    }
    else {
        return false;
    }
}

export function method0(): string {
    return "TRACE_LEVEL";
}

export function method2(): string {
    return "";
}

export function method1(v0_1: string): string {
    let _v1: Option<string> = undefined;
    const x: string = process.env[v0_1] ?? "";
    _v1 = x;
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        return value_12(_v1);
    }
}

export function method3(): string {
    return "AUTOMATION";
}

export function closure1(unitVar: void, v0_1: string): void {
}

export function closure0(unitVar: void, v0_1: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] {
    let v84: US1_$union, v92: US1_$union, v100: US1_$union, v108: US1_$union;
    let _v1: Option<[US1_$union, US2_$union]> = undefined;
    const v70: string = method1(method0());
    const v76: US1_$union = ("Verbose" === v70) ? US1_US1_0(US0_US0_0()) : US1_US1_1();
    const x = [(v76.tag === /* US1_0 */ 0) ? US1_US1_0(v76.fields[0]) : ((v84 = (("Debug" === v70) ? US1_US1_0(US0_US0_1()) : US1_US1_1()), (v84.tag === /* US1_0 */ 0) ? US1_US1_0(v84.fields[0]) : ((v92 = (("Info" === v70) ? US1_US1_0(US0_US0_2()) : US1_US1_1()), (v92.tag === /* US1_0 */ 0) ? US1_US1_0(v92.fields[0]) : ((v100 = (("Warning" === v70) ? US1_US1_0(US0_US0_3()) : US1_US1_1()), (v100.tag === /* US1_0 */ 0) ? US1_US1_0(v100.fields[0]) : ((v108 = (("Critical" === v70) ? US1_US1_0(US0_US0_4()) : US1_US1_1()), (v108.tag === /* US1_0 */ 0) ? US1_US1_0(v108.fields[0]) : US1_US1_1())))))))), (method1(method3()) === "True") ? US2_US2_0(getTicks(now())) : US2_US2_1()] as [US1_$union, US2_$union];
    _v1 = x;
    let patternInput: [US1_$union, US2_$union];
    if (_v1 == null) {
        throw new Error("base.run_target / _v1=None");
    }
    else {
        patternInput = value_12(_v1);
    }
    const v259: US2_$union = patternInput[1];
    const v258: US1_$union = patternInput[0];
    return [new Mut0(0n), new Mut1((v: string): void => {
        closure1(undefined, v);
    }), new Mut2(true), new Mut3((v258.tag === /* US1_0 */ 0) ? v258.fields[0] : v0_1), (v259.tag === /* US2_0 */ 0) ? v259.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Option<int64>];
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

export function method9(v0_1: Mut4): void {
}

export function closure6(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => void), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_12(State_trace_state());
    const v9: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_12(v9);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method7());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value_12(_v10);
    }
    const v159: US3_$union = (v0_1.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v208: US3_$union;
    if (v159.tag === /* US3_0 */ 0) {
        v208 = US3_US3_0(v159.fields[0]);
    }
    else {
        const v168: US3_$union = (v0_1.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v168.tag === /* US3_0 */ 0) {
            v208 = US3_US3_0(v168.fields[0]);
        }
        else {
            const v177: US3_$union = (v0_1.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v177.tag === /* US3_0 */ 0) {
                v208 = US3_US3_0(v177.fields[0]);
            }
            else {
                const v186: US3_$union = (v0_1.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v186.tag === /* US3_0 */ 0) {
                    v208 = US3_US3_0(v186.fields[0]);
                }
                else {
                    const v195: US3_$union = (v0_1.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v208 = ((v195.tag === /* US3_0 */ 0) ? US3_US3_0(v195.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v212: string;
    if (v208.tag === /* US3_0 */ 0) {
        v212 = v208.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v215: string = padLeft(v212.toLocaleLowerCase(), 7, " ");
    let _v216: Option<string> = undefined;
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method8();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value_12(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    v2_1();
    const v331: Mut4 = new Mut4("");
    method9(v331);
    const v332: string = v331.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v332}`, ...[]), ...[" ", "/"]);
}

export function method10(v0_1: US0_$union, v1_1: (() => string)): void {
    const v2_1 = (v: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] => closure0(undefined, v);
    if (State_trace_state() == null) {
        State_trace_state(v2_1(US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_12(State_trace_state());
    const v4_1: Mut0 = patternInput[0];
    if (State_trace_state() == null) {
        State_trace_state(v2_1(US0_US0_0()));
    }
    const patternInput_1: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_12(State_trace_state());
    const v15: US0_$union = patternInput_1[3].l0;
    if ((patternInput_1[2].l0 === false) ? false : (find<US0_$union, int32>(v0_1, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })) >= find<US0_$union, int32>(v15, ofSeq([[US0_US0_0(), 0] as [US0_$union, int32], [US0_US0_1(), 1] as [US0_$union, int32], [US0_US0_2(), 2] as [US0_$union, int32], [US0_US0_3(), 3] as [US0_$union, int32], [US0_US0_4(), 4] as [US0_$union, int32]], {
        Compare: compare,
    })))) {
        const v23: int64 = toInt64(op_Addition(v4_1.l0, 1n));
        v4_1.l0 = v23;
        const v24 = `${v1_1()}`;
        let _v25: Option<void> = undefined;
        console.log(v24);
        _v25 = some(undefined);
        if (_v25 == null) {
            throw new Error("base.run_target / _v25=None");
        }
        else {
            value_12(_v25);
        }
        patternInput[1].l0(v24);
    }
}

export function method4(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => void)): void {
    method10(v0_1, (): string => closure6(v0_1, v1_1, v2_1, undefined));
}

export function closure7(unitVar: void, unitVar_1: void): string {
    return "runtime.current_process_kill / exiting... 2";
}

export function closure8(unitVar: void, unitVar_1: void): string {
    return "runtime.current_process_kill / exiting... 1";
}

export function closure3(unitVar: void, unitVar_1: void): void {
    let _v0: Option<void> = undefined;
    defaultOf();
    _v0 = some(undefined);
    if (_v0 == null) {
        throw new Error("base.run_target / _v0=None");
    }
    else {
        value_12(_v0);
    }
}

export function closure2(unitVar: void, unitVar_1: void): void {
    let _v0: Option<void> = undefined;
    defaultOf();
    _v0 = some(undefined);
    if (_v0 == null) {
        throw new Error("base.run_target / _v0=None");
    }
    else {
        value_12(_v0);
    }
}

export function method13(v0_1: int32, v1_1: Mut5): boolean {
    return v1_1.l0 < v0_1;
}

export function closure12(v0_1: string, v1_1: UH0_$union): UH0_$union {
    return UH0_UH0_1(v0_1, v1_1);
}

export function closure11(unitVar: void, v0_1: string): ((arg0: UH0_$union) => UH0_$union) {
    return (v: UH0_$union): UH0_$union => closure12(v0_1, v);
}

export function method14(): ((arg0: string) => ((arg0: UH0_$union) => UH0_$union)) {
    return (v: string): ((arg0: UH0_$union) => UH0_$union) => closure11(undefined, v);
}

export function method15(v0_1_mut: UH0_$union, v1_1_mut: any, v2_1_mut: int32, v3_1_mut: int32): [any, int32, int32] {
    let v12: any, v16: any;
    method15:
    while (true) {
        const v0_1: UH0_$union = v0_1_mut, v1_1: any = v1_1_mut, v2_1: int32 = v2_1_mut, v3_1: int32 = v3_1_mut;
        if (v0_1.tag === /* UH0_0 */ 0) {
            return [v1_1, v2_1, v3_1] as [any, int32, int32];
        }
        else {
            const v4_1: string = v0_1.fields[0];
            const v6_1: boolean = "\n" === v4_1;
            const patternInput: [int32, int32] = v6_1 ? ([v2_1 + 1, 1] as [int32, int32]) : ([v2_1, v3_1 + 1] as [int32, int32]);
            v0_1_mut = v0_1.fields[1];
            v1_1_mut = (v6_1 ? ((v12 = StringBuilder__Clear(v1_1), v1_1)) : ((v16 = StringBuilder__Append_Z721C83C5(v1_1, v4_1), v1_1)));
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
    const v1_1: any = _arg[1];
    const v0_1: string = _arg[0];
    if ("" === v0_1) {
        return US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v1_1, v2_1, v3_1] as [any, int32, int32]])));
    }
    else {
        const v7: string = v0_1[0];
        if (v7 === "\"") {
            const v12 = 1;
            const v14: int32 = v0_1.length | 0;
            const v15: string = v0_1.slice(v12, v14 + 1);
            const v17: string = v7;
            const v18: int32 = v17.length | 0;
            const v19: string[] = fill(new Array(v18), 0, v18, "");
            const v20: Mut5 = new Mut5(0);
            while (method13(v18, v20)) {
                const v22: int32 = v20.l0 | 0;
                const v23: string = v17[v22];
                setItem(v19, v22, v23);
                const v24: int32 = (v22 + 1) | 0;
                v20.l0 = (v24 | 0);
            }
            const v26: FSharpList<string> = ofArray<string>(v19);
            const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v26, UH0_UH0_0()), v1_1, v2_1, v3_1);
            return US5_US5_0(v7, v15, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v38: int32 = v0_1.length | 0;
            const v41: int32 = (v0_1.indexOf("\n") - 1) | 0;
            const v45 = 0;
            const v47: int32 = ((-2 === v41) ? v38 : v41) | 0;
            return US5_US5_1(`${`parsing.p_char / expected: '${"\""}' / line: ${v2_1} / col: ${v3_1}
${v1_1}${v0_1.slice(v45, v47 + 1)}`}
${replicate(v3_1 - 1, " ") + "^"}
`);
        }
    }
}

export function closure13(unitVar: void, _arg: [string, any, int32, int32]): US5_$union {
    const v3_1: int32 = _arg[3] | 0;
    const v2_1: int32 = _arg[2] | 0;
    const v1_1: any = _arg[1];
    const v0_1: string = _arg[0];
    if ("" === v0_1) {
        return US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v1_1, v2_1, v3_1] as [any, int32, int32]])));
    }
    else {
        const v7: string = v0_1[0];
        if (v7 === "\'") {
            const v12 = 1;
            const v14: int32 = v0_1.length | 0;
            const v15: string = v0_1.slice(v12, v14 + 1);
            const v17: string = v7;
            const v18: int32 = v17.length | 0;
            const v19: string[] = fill(new Array(v18), 0, v18, "");
            const v20: Mut5 = new Mut5(0);
            while (method13(v18, v20)) {
                const v22: int32 = v20.l0 | 0;
                const v23: string = v17[v22];
                setItem(v19, v22, v23);
                const v24: int32 = (v22 + 1) | 0;
                v20.l0 = (v24 | 0);
            }
            const v26: FSharpList<string> = ofArray<string>(v19);
            const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v26, UH0_UH0_0()), v1_1, v2_1, v3_1);
            return US5_US5_0(v7, v15, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v38: int32 = v0_1.length | 0;
            const v41: int32 = (v0_1.indexOf("\n") - 1) | 0;
            const v45 = 0;
            const v47: int32 = ((-2 === v41) ? v38 : v41) | 0;
            return US5_US5_1(`${`parsing.p_char / expected: '${"\'"}' / line: ${v2_1} / col: ${v3_1}
${v1_1}${v0_1.slice(v45, v47 + 1)}`}
${replicate(v3_1 - 1, " ") + "^"}
`);
        }
    }
}

export function method16(v0_1_mut: string, v1_1_mut: any, v2_1_mut: UH1_$union): US5_$union {
    method16:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: any = v1_1_mut, v2_1: UH1_$union = v2_1_mut;
        if (v2_1.tag === /* UH1_0 */ 0) {
            return US5_US5_1("choice / no parsers succeeded");
        }
        else {
            const v6_1: UH1_$union = v2_1.fields[1];
            const v7: US5_$union = v2_1.fields[0]([v0_1, v1_1, 1, 1] as [string, any, int32, int32]);
            if (v7.tag === /* US5_0 */ 0) {
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
                v2_1_mut = v6_1;
                continue method16;
            }
        }
        break;
    }
}

export function method17(v0_1_mut: string, v1_1_mut: int64): boolean {
    method17:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int64 = v1_1_mut;
        if (compare_1(v1_1, 2n) >= 0) {
            return false;
        }
        else {
            let v11: US7_$union;
            if (equals(v1_1, 0n)) {
                v11 = US7_US7_0("\"");
            }
            else {
                const v5_1: int64 = toInt64(op_Subtraction(v1_1, 1n));
                if (equals(v5_1, 0n)) {
                    v11 = US7_US7_0("\'");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5_1, 1n));
                    v11 = US7_US7_1();
                }
            }
            if (v0_1 === ((v11.tag === /* US7_0 */ 0) ? v11.fields[0] : (() => {
                throw new Error("Option does not have a value.");
            })())) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = toInt64(op_Addition(v1_1, 1n));
                continue method17;
            }
        }
        break;
    }
}

export function method18(v0_1_mut: string, v1_1_mut: string, v2_1_mut: any, v3_1_mut: int32, v4_1_mut: int32): US6_$union {
    method18:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3_1: int32 = v3_1_mut, v4_1: int32 = v4_1_mut;
        let v53: US5_$union;
        if ("" === v1_1) {
            v53 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'"], [v2_1, v3_1, v4_1] as [any, int32, int32]])));
        }
        else {
            const v13: string = v1_1[0];
            const v17 = 1;
            const v19: int32 = v1_1.length | 0;
            const v20: string = v1_1.slice(v17, v19 + 1);
            if (method17(v13, 0n) === false) {
                const v25: string = v13;
                const v26: int32 = v25.length | 0;
                const v27: string[] = fill(new Array(v26), 0, v26, "");
                const v28: Mut5 = new Mut5(0);
                while (method13(v26, v28)) {
                    const v30: int32 = v28.l0 | 0;
                    const v31: string = v25[v30];
                    setItem(v27, v30, v31);
                    const v32: int32 = (v30 + 1) | 0;
                    v28.l0 = (v32 | 0);
                }
                const v34: FSharpList<string> = ofArray<string>(v27);
                const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v34, UH0_UH0_0()), v2_1, v3_1, v4_1);
                v53 = US5_US5_0(v13, v20, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v53 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v13, ["\"", "\'"], [v2_1, v3_1, v4_1] as [any, int32, int32]])));
            }
        }
        let v65: US5_$union;
        if (v53.tag === /* US5_0 */ 0) {
            const v54: string = v53.fields[0];
            v65 = US5_US5_0(("\\" === v54) ? "/" : v54, v53.fields[1], v53.fields[2], v53.fields[3], v53.fields[4]);
        }
        else {
            v65 = US5_US5_1(v53.fields[0]);
        }
        if (v65.tag === /* US5_0 */ 0) {
            v0_1_mut = (v0_1 + v65.fields[0]);
            v1_1_mut = v65.fields[1];
            v2_1_mut = v65.fields[2];
            v3_1_mut = v65.fields[3];
            v4_1_mut = v65.fields[4];
            continue method18;
        }
        else {
            const v75: string = v65.fields[0];
            return US6_US6_0(v0_1, v1_1, v2_1, v3_1, v4_1);
        }
        break;
    }
}

export function method19(v0_1_mut: string, v1_1_mut: any, v2_1_mut: int32, v3_1_mut: int32, v4_1_mut: UH1_$union): US5_$union {
    method19:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: any = v1_1_mut, v2_1: int32 = v2_1_mut, v3_1: int32 = v3_1_mut, v4_1: UH1_$union = v4_1_mut;
        if (v4_1.tag === /* UH1_0 */ 0) {
            return US5_US5_1("choice / no parsers succeeded");
        }
        else {
            const v8: UH1_$union = v4_1.fields[1];
            const v9: US5_$union = v4_1.fields[0]([v0_1, v1_1, v2_1, v3_1] as [string, any, int32, int32]);
            if (v9.tag === /* US5_0 */ 0) {
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
                v3_1_mut = v3_1;
                v4_1_mut = v8;
                continue method19;
            }
        }
        break;
    }
}

export function method20(v0_1_mut: string, v1_1_mut: int64): boolean {
    method20:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int64 = v1_1_mut;
        if (compare_1(v1_1, 3n) >= 0) {
            return false;
        }
        else {
            let v15: US7_$union;
            if (equals(v1_1, 0n)) {
                v15 = US7_US7_0("\"");
            }
            else {
                const v5_1: int64 = toInt64(op_Subtraction(v1_1, 1n));
                if (equals(v5_1, 0n)) {
                    v15 = US7_US7_0("\'");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5_1, 1n));
                    if (equals(v8, 0n)) {
                        v15 = US7_US7_0(" ");
                    }
                    else {
                        const v11: int64 = toInt64(op_Subtraction(v8, 1n));
                        v15 = US7_US7_1();
                    }
                }
            }
            if (v0_1 === ((v15.tag === /* US7_0 */ 0) ? v15.fields[0] : (() => {
                throw new Error("Option does not have a value.");
            })())) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = toInt64(op_Addition(v1_1, 1n));
                continue method20;
            }
        }
        break;
    }
}

export function method21(v0_1_mut: string, v1_1_mut: string, v2_1_mut: any, v3_1_mut: int32, v4_1_mut: int32): US6_$union {
    method21:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3_1: int32 = v3_1_mut, v4_1: int32 = v4_1_mut;
        let v55: US5_$union;
        if ("" === v1_1) {
            v55 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'", " "], [v2_1, v3_1, v4_1] as [any, int32, int32]])));
        }
        else {
            const v14: string = v1_1[0];
            const v18 = 1;
            const v20: int32 = v1_1.length | 0;
            const v21: string = v1_1.slice(v18, v20 + 1);
            if (method20(v14, 0n) === false) {
                const v26: string = v14;
                const v27: int32 = v26.length | 0;
                const v28: string[] = fill(new Array(v27), 0, v27, "");
                const v29: Mut5 = new Mut5(0);
                while (method13(v27, v29)) {
                    const v31: int32 = v29.l0 | 0;
                    const v32: string = v26[v31];
                    setItem(v28, v31, v32);
                    const v33: int32 = (v31 + 1) | 0;
                    v29.l0 = (v33 | 0);
                }
                const v35: FSharpList<string> = ofArray<string>(v28);
                const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v35, UH0_UH0_0()), v2_1, v3_1, v4_1);
                v55 = US5_US5_0(v14, v21, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v55 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v14, ["\"", "\'", " "], [v2_1, v3_1, v4_1] as [any, int32, int32]])));
            }
        }
        let v67: US5_$union;
        if (v55.tag === /* US5_0 */ 0) {
            const v56: string = v55.fields[0];
            v67 = US5_US5_0(("\\" === v56) ? "/" : v56, v55.fields[1], v55.fields[2], v55.fields[3], v55.fields[4]);
        }
        else {
            v67 = US5_US5_1(v55.fields[0]);
        }
        if (v67.tag === /* US5_0 */ 0) {
            v0_1_mut = (v0_1 + v67.fields[0]);
            v1_1_mut = v67.fields[1];
            v2_1_mut = v67.fields[2];
            v3_1_mut = v67.fields[3];
            v4_1_mut = v67.fields[4];
            continue method21;
        }
        else {
            const v77: string = v67.fields[0];
            return US6_US6_0(v0_1, v1_1, v2_1, v3_1, v4_1);
        }
        break;
    }
}

export function method22(v0_1_mut: string, v1_1_mut: int32): int32 {
    method22:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v1_1 >= v0_1.length) {
            return v1_1 | 0;
        }
        else if (v0_1[v1_1] === " ") {
            v0_1_mut = v0_1;
            v1_1_mut = (v1_1 + 1);
            continue method22;
        }
        else {
            return v1_1 | 0;
        }
        break;
    }
}

export function method23(v0_1_mut: string, v1_1_mut: string, v2_1_mut: any, v3_1_mut: int32, v4_1_mut: int32): US6_$union {
    method23:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3_1: int32 = v3_1_mut, v4_1: int32 = v4_1_mut;
        let v37: US5_$union;
        if ("" === v1_1) {
            v37 = US5_US5_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v2_1, v3_1, v4_1] as [any, int32, int32]])));
        }
        else {
            const v8: string = v1_1[0];
            const v12 = 1;
            const v14: int32 = v1_1.length | 0;
            const v15: string = v1_1.slice(v12, v14 + 1);
            const v17: string = v8;
            const v18: int32 = v17.length | 0;
            const v19: string[] = fill(new Array(v18), 0, v18, "");
            const v20: Mut5 = new Mut5(0);
            while (method13(v18, v20)) {
                const v22: int32 = v20.l0 | 0;
                const v23: string = v17[v22];
                setItem(v19, v22, v23);
                const v24: int32 = (v22 + 1) | 0;
                v20.l0 = (v24 | 0);
            }
            const v26: FSharpList<string> = ofArray<string>(v19);
            const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v26, UH0_UH0_0()), v2_1, v3_1, v4_1);
            v37 = US5_US5_0(v8, v15, patternInput[0], patternInput[1], patternInput[2]);
        }
        if (v37.tag === /* US5_0 */ 0) {
            v0_1_mut = (v0_1 + v37.fields[0]);
            v1_1_mut = v37.fields[1];
            v2_1_mut = v37.fields[2];
            v3_1_mut = v37.fields[3];
            v4_1_mut = v37.fields[4];
            continue method23;
        }
        else {
            const v47: string = v37.fields[0];
            return US6_US6_0(v0_1, v1_1, v2_1, v3_1, v4_1);
        }
        break;
    }
}

export function method12(v0_1: string): US4_$union {
    let _v0: Option<Option<string>> = undefined;
    _v0 = some(v0_1);
    const v5_1: string = defaultArg((_v0 == null) ? (() => {
        throw new Error("optionm\'.of_obj / _v0=None");
    })() : value_12(_v0), "");
    const v7: any = StringBuilder_$ctor_Z721C83C5("");
    const v8 = (arg10$0040: [string, any, int32, int32]): US5_$union => closure10(undefined, arg10$0040);
    const v9 = (arg10$0040_1: [string, any, int32, int32]): US5_$union => closure13(undefined, arg10$0040_1);
    const v13: US5_$union = method16(v5_1, v7, UH1_UH1_1(v8, UH1_UH1_1(v9, UH1_UH1_0())));
    let v130: US6_$union;
    if (v13.tag === /* US5_0 */ 0) {
        const v18: int32 = v13.fields[4] | 0;
        const v17: int32 = v13.fields[3] | 0;
        const v16: any = v13.fields[2];
        const v15: string = v13.fields[1];
        const v14: string = v13.fields[0];
        let v67: US5_$union;
        if ("" === v15) {
            v67 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'"], [v16, v17, v18] as [any, int32, int32]])));
        }
        else {
            const v27: string = v15[0];
            const v31 = 1;
            const v33: int32 = v15.length | 0;
            const v34: string = v15.slice(v31, v33 + 1);
            if (method17(v27, 0n) === false) {
                const v39: string = v27;
                const v40: int32 = v39.length | 0;
                const v41: string[] = fill(new Array(v40), 0, v40, "");
                const v42: Mut5 = new Mut5(0);
                while (method13(v40, v42)) {
                    const v44: int32 = v42.l0 | 0;
                    const v45: string = v39[v44];
                    setItem(v41, v44, v45);
                    const v46: int32 = (v44 + 1) | 0;
                    v42.l0 = (v46 | 0);
                }
                const v48: FSharpList<string> = ofArray<string>(v41);
                const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v48, UH0_UH0_0()), v16, v17, v18);
                v67 = US5_US5_0(v27, v34, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v67 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v27, ["\"", "\'"], [v16, v17, v18] as [any, int32, int32]])));
            }
        }
        let v79: US5_$union;
        if (v67.tag === /* US5_0 */ 0) {
            const v68: string = v67.fields[0];
            v79 = US5_US5_0(("\\" === v68) ? "/" : v68, v67.fields[1], v67.fields[2], v67.fields[3], v67.fields[4]);
        }
        else {
            v79 = US5_US5_1(v67.fields[0]);
        }
        const v91: US6_$union = (v79.tag === /* US5_0 */ 0) ? method18(v79.fields[0], v79.fields[1], v79.fields[2], v79.fields[3], v79.fields[4]) : US6_US6_1(v79.fields[0]);
        let v101: US6_$union;
        if (v91.tag === /* US6_0 */ 0) {
            v101 = US6_US6_0(v91.fields[0], v91.fields[1], v91.fields[2], v91.fields[3], v91.fields[4]);
        }
        else {
            const v98: string = v91.fields[0];
            v101 = US6_US6_0("", v15, v16, v17, v18);
        }
        if (v101.tag === /* US6_0 */ 0) {
            const v106: int32 = v101.fields[4] | 0;
            const v105: int32 = v101.fields[3] | 0;
            const v104: any = v101.fields[2];
            const v103: string = v101.fields[1];
            const v102: string = v101.fields[0];
            const v110: US5_$union = method19(v103, v104, v105, v106, UH1_UH1_1(v8, UH1_UH1_1(v9, UH1_UH1_0())));
            if (v110.tag === /* US5_0 */ 0) {
                const v111: string = v110.fields[0];
                v130 = US6_US6_0(v102, v110.fields[1], v110.fields[2], v110.fields[3], v110.fields[4]);
            }
            else {
                v130 = US6_US6_1(toText(interpolate("between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v110.fields[0], [v5_1, v7, 1, 1] as [string, any, int32, int32], [v15, v16, v17, v18] as [string, any, int32, int32], [v103, v104, v105, v106] as [string, any, int32, int32]])));
            }
        }
        else {
            const v122: string = v101.fields[0];
            v130 = US6_US6_1("between / expected content");
        }
    }
    else {
        v130 = US6_US6_1(v13.fields[0]);
    }
    let v257: US6_$union;
    if (v130.tag === /* US6_0 */ 0) {
        const v135: int32 = v130.fields[4] | 0;
        const v134: int32 = v130.fields[3] | 0;
        const v133: any = v130.fields[2];
        const v132: string = v130.fields[1];
        const v131: string = v130.fields[0];
        v257 = v130;
    }
    else {
        const v136: string = v130.fields[0];
        let v189: US5_$union;
        if ("" === v5_1) {
            v189 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'", " "], [v7, 1, 1] as [any, int32, int32]])));
        }
        else {
            const v146: string = v5_1[0];
            const v150 = 1;
            const v152: int32 = v5_1.length | 0;
            const v153: string = v5_1.slice(v150, v152 + 1);
            if (method20(v146, 0n) === false) {
                const v158: string = v146;
                const v159: int32 = v158.length | 0;
                const v160: string[] = fill(new Array(v159), 0, v159, "");
                const v161: Mut5 = new Mut5(0);
                while (method13(v159, v161)) {
                    const v163: int32 = v161.l0 | 0;
                    const v164: string = v158[v163];
                    setItem(v160, v163, v164);
                    const v165: int32 = (v163 + 1) | 0;
                    v161.l0 = (v165 | 0);
                }
                const v167: FSharpList<string> = ofArray<string>(v160);
                const patternInput_1: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v167, UH0_UH0_0()), v7, 1, 1);
                v189 = US5_US5_0(v146, v153, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
            }
            else {
                v189 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v146, ["\"", "\'", " "], [v7, 1, 1] as [any, int32, int32]])));
            }
        }
        let v201: US5_$union;
        if (v189.tag === /* US5_0 */ 0) {
            const v190: string = v189.fields[0];
            v201 = US5_US5_0(("\\" === v190) ? "/" : v190, v189.fields[1], v189.fields[2], v189.fields[3], v189.fields[4]);
        }
        else {
            v201 = US5_US5_1(v189.fields[0]);
        }
        const v213: US6_$union = (v201.tag === /* US5_0 */ 0) ? method21(v201.fields[0], v201.fields[1], v201.fields[2], v201.fields[3], v201.fields[4]) : US6_US6_1(v201.fields[0]);
        if (v213.tag === /* US6_0 */ 0) {
            const v218: int32 = v213.fields[4] | 0;
            const v217: int32 = v213.fields[3] | 0;
            const v216: any = v213.fields[2];
            const v215: string = v213.fields[1];
            const v214: string = v213.fields[0];
            v257 = v213;
        }
        else {
            const v219: string = v213.fields[0];
            const v225: US8_$union = (v5_1.length === 0) ? US8_US8_0(v5_1, v7, 1, 1) : US8_US8_1(toText(interpolate("parsing.eof / expected end of input / input: %A%P()", [v5_1])));
            const v234: US6_$union = (v225.tag === /* US8_0 */ 0) ? US6_US6_0("", v225.fields[0], v225.fields[1], v225.fields[2], v225.fields[3]) : US6_US6_1(v225.fields[0]);
            if (v234.tag === /* US6_0 */ 0) {
                const v239: int32 = v234.fields[4] | 0;
                const v238: int32 = v234.fields[3] | 0;
                const v237: any = v234.fields[2];
                const v236: string = v234.fields[1];
                const v235: string = v234.fields[0];
                const v245: int32 = method22(v236, 0) | 0;
                const v247: int32 = v236.length | 0;
                v257 = US6_US6_0(v235, v236.slice(v245, v247 + 1), v237, v238, v239);
            }
            else {
                v257 = US6_US6_1(v234.fields[0]);
            }
        }
    }
    let v411: US9_$union;
    if (v257.tag === /* US6_0 */ 0) {
        const v262: int32 = v257.fields[4] | 0;
        const v261: int32 = v257.fields[3] | 0;
        const v260: any = v257.fields[2];
        const v259: string = v257.fields[1];
        const v258: string = v257.fields[0];
        let v319: US5_$union;
        if ("" === v259) {
            v319 = US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v260, v261, v262] as [any, int32, int32]])));
        }
        else {
            const v266: string = v259[0];
            if (v266 === " ") {
                const v271 = 1;
                const v273: int32 = v259.length | 0;
                const v274: string = v259.slice(v271, v273 + 1);
                const v276: string = v266;
                const v277: int32 = v276.length | 0;
                const v278: string[] = fill(new Array(v277), 0, v277, "");
                const v279: Mut5 = new Mut5(0);
                while (method13(v277, v279)) {
                    const v281: int32 = v279.l0 | 0;
                    const v282: string = v276[v281];
                    setItem(v278, v281, v282);
                    const v283: int32 = (v281 + 1) | 0;
                    v279.l0 = (v283 | 0);
                }
                const v285: FSharpList<string> = ofArray<string>(v278);
                const patternInput_2: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v285, UH0_UH0_0()), v260, v261, v262);
                v319 = US5_US5_0(v266, v274, patternInput_2[0], patternInput_2[1], patternInput_2[2]);
            }
            else {
                const v297: int32 = v259.length | 0;
                const v300: int32 = (v259.indexOf("\n") - 1) | 0;
                const v304 = 0;
                const v306: int32 = ((-2 === v300) ? v297 : v300) | 0;
                v319 = US5_US5_1(`${`parsing.p_char / expected: '${" "}' / line: ${v261} / col: ${v262}
${v260}${v259.slice(v304, v306 + 1)}`}
${replicate(v262 - 1, " ") + "^"}
`);
            }
        }
        let v331: US10_$union;
        if (v319.tag === /* US5_0 */ 0) {
            v331 = US10_US10_0(US7_US7_0(v319.fields[0]), v319.fields[1], v319.fields[2], v319.fields[3], v319.fields[4]);
        }
        else {
            const v327: string = v319.fields[0];
            v331 = US10_US10_0(US7_US7_1(), v259, v260, v261, v262);
        }
        let v385: US6_$union;
        if (v331.tag === /* US10_0 */ 0) {
            const v336: int32 = v331.fields[4] | 0;
            const v335: int32 = v331.fields[3] | 0;
            const v334: any = v331.fields[2];
            const v333: string = v331.fields[1];
            const v332: US7_$union = v331.fields[0];
            let v369: US5_$union;
            if ("" === v333) {
                v369 = US5_US5_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v334, v335, v336] as [any, int32, int32]])));
            }
            else {
                const v340: string = v333[0];
                const v344 = 1;
                const v346: int32 = v333.length | 0;
                const v347: string = v333.slice(v344, v346 + 1);
                const v349: string = v340;
                const v350: int32 = v349.length | 0;
                const v351: string[] = fill(new Array(v350), 0, v350, "");
                const v352: Mut5 = new Mut5(0);
                while (method13(v350, v352)) {
                    const v354: int32 = v352.l0 | 0;
                    const v355: string = v349[v354];
                    setItem(v351, v354, v355);
                    const v356: int32 = (v354 + 1) | 0;
                    v352.l0 = (v356 | 0);
                }
                const v358: FSharpList<string> = ofArray<string>(v351);
                const patternInput_3: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v358, UH0_UH0_0()), v334, v335, v336);
                v369 = US5_US5_0(v340, v347, patternInput_3[0], patternInput_3[1], patternInput_3[2]);
            }
            v385 = ((v369.tag === /* US5_0 */ 0) ? method23(v369.fields[0], v369.fields[1], v369.fields[2], v369.fields[3], v369.fields[4]) : US6_US6_1(v369.fields[0]));
        }
        else {
            v385 = US6_US6_1(v331.fields[0]);
        }
        let v397: US11_$union;
        if (v385.tag === /* US6_0 */ 0) {
            v397 = US11_US11_0(US3_US3_0(v385.fields[0]), v385.fields[1], v385.fields[2], v385.fields[3], v385.fields[4]);
        }
        else {
            const v393: string = v385.fields[0];
            v397 = US11_US11_0(US3_US3_1(), v259, v260, v261, v262);
        }
        v411 = ((v397.tag === /* US11_0 */ 0) ? US9_US9_0(v258, v397.fields[0], v397.fields[1], v397.fields[2], v397.fields[3], v397.fields[4]) : US9_US9_1(v397.fields[0]));
    }
    else {
        v411 = US9_US9_1(v257.fields[0]);
    }
    if (v411.tag === /* US9_0 */ 0) {
        const v417: int32 = v411.fields[5] | 0;
        const v416: int32 = v411.fields[4] | 0;
        const v415: any = v411.fields[3];
        const v414: string = v411.fields[2];
        return US4_US4_0(v411.fields[0], v411.fields[1]);
    }
    else {
        return US4_US4_1(v411.fields[0]);
    }
}

export function closure14(unitVar: void, unitVar_1: void): string {
    return "runtime.execute_with_options_async";
}

export function closure15(v0_1: string, v1_1: Option<any>, v2_1: [string, string][], v3_1: Option<((arg0: [int32, string, boolean]) => any)>, v4_1: Option<((arg0: any) => void)>, v5_1: boolean, v6_1: Option<string>, unitVar: void): [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>] {
    return [v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1] as [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>];
}

export function method26(v0_1: Mut4, v1_1: string): void {
    const v2_1 = `${v1_1}`;
    const v4_1: string = v0_1.l0 + v2_1;
    v0_1.l0 = v4_1;
}

export function method28(v0_1: Mut4, v1_1: Option<any>): void {
    method26(v0_1, toText(interpolate("%A%P()", [v1_1])));
}

export function method29(v0_1: Mut4, v1_1: [string, string][]): void {
    method26(v0_1, toText(interpolate("%A%P()", [v1_1])));
}

export function method30(v0_1: Mut4, v1_1: Option<((arg0: [int32, string, boolean]) => any)>): void {
    method26(v0_1, toText(interpolate("%A%P()", [v1_1])));
}

export function method31(v0_1: Mut4, v1_1: Option<((arg0: any) => void)>): void {
    method26(v0_1, toText(interpolate("%A%P()", [v1_1])));
}

export function method32(v0_1: Mut4, v1_1: boolean): void {
    const v5_1 = `${v1_1 ? "true" : "false"}`;
    const v7: string = v0_1.l0 + v5_1;
    v0_1.l0 = v7;
}

export function method33(v0_1: Mut4, v1_1: Option<string>): void {
    method26(v0_1, toText(interpolate("%A%P()", [v1_1])));
}

export function method27(v0_1: Mut4, v1_1: string, v2_1: Option<any>, v3_1: [string, string][], v4_1: Option<((arg0: [int32, string, boolean]) => any)>, v5_1: Option<((arg0: any) => void)>, v6_1: boolean, v7: Option<string>): void {
    method26(v0_1, "{ ");
    method9(v0_1);
    method26(v0_1, "command");
    method26(v0_1, " = ");
    method26(v0_1, v1_1);
    method26(v0_1, "; ");
    method26(v0_1, "cancellation_token");
    method26(v0_1, " = ");
    method28(v0_1, v2_1);
    method26(v0_1, "; ");
    method26(v0_1, "environment_variables");
    method26(v0_1, " = ");
    method29(v0_1, v3_1);
    method26(v0_1, "; ");
    method26(v0_1, "on_line");
    method26(v0_1, " = ");
    method30(v0_1, v4_1);
    method26(v0_1, "; ");
    method26(v0_1, "stdin");
    method26(v0_1, " = ");
    method31(v0_1, v5_1);
    method26(v0_1, "; ");
    method26(v0_1, "trace");
    method26(v0_1, " = ");
    method32(v0_1, v6_1);
    method26(v0_1, "; ");
    method26(v0_1, "working_directory");
    method26(v0_1, " = ");
    method33(v0_1, v7);
    method26(v0_1, " }");
}

export function method25(v0_1: Mut4, v1_1: string, v2_1: Option<any>, v3_1: [string, string][], v4_1: Option<((arg0: [int32, string, boolean]) => any)>, v5_1: Option<((arg0: any) => void)>, v6_1: boolean, v7: Option<string>): void {
    method26(v0_1, "{ ");
    method9(v0_1);
    method26(v0_1, "options");
    method26(v0_1, " = ");
    method27(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7);
    method26(v0_1, " }");
}

export function closure16(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>]), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_12(State_trace_state());
    const v9: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_12(v9);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method7());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value_12(_v10);
    }
    const v159: US3_$union = (v0_1.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v208: US3_$union;
    if (v159.tag === /* US3_0 */ 0) {
        v208 = US3_US3_0(v159.fields[0]);
    }
    else {
        const v168: US3_$union = (v0_1.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v168.tag === /* US3_0 */ 0) {
            v208 = US3_US3_0(v168.fields[0]);
        }
        else {
            const v177: US3_$union = (v0_1.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v177.tag === /* US3_0 */ 0) {
                v208 = US3_US3_0(v177.fields[0]);
            }
            else {
                const v186: US3_$union = (v0_1.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v186.tag === /* US3_0 */ 0) {
                    v208 = US3_US3_0(v186.fields[0]);
                }
                else {
                    const v195: US3_$union = (v0_1.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v208 = ((v195.tag === /* US3_0 */ 0) ? US3_US3_0(v195.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v212: string;
    if (v208.tag === /* US3_0 */ 0) {
        v212 = v208.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v215: string = padLeft(v212.toLocaleLowerCase(), 7, " ");
    let _v216: Option<string> = undefined;
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method8();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value_12(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    const patternInput_1: [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>] = v2_1();
    const v338: Mut4 = new Mut4("");
    method25(v338, patternInput_1[0], patternInput_1[1], patternInput_1[2], patternInput_1[3], patternInput_1[4], patternInput_1[5], patternInput_1[6]);
    const v339: string = v338.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v339}`, ...[]), ...[" ", "/"]);
}

export function method24(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>])): void {
    method10(v0_1, (): string => closure16(v0_1, v1_1, v2_1, undefined));
}

export function closure18(v0_1: string, unitVar: void): string {
    return v0_1;
}

export function closure17(v0_1: string, v1_1: Option<any>, v2_1: [string, string][], v3_1: Option<((arg0: [int32, string, boolean]) => any)>, v4_1: Option<((arg0: any) => void)>, v5_1: boolean, v6_1: Option<string>, v7: void, v8: any, v9: void): void {
    let _v10: Option<any> = undefined;
    const x: any = defaultOf();
    _v10 = x;
    let v39: any;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v39 = value_12(_v10);
    }
    let _v40: Option<void> = undefined;
    defaultOf();
    _v40 = some(undefined);
    if (_v40 == null) {
        throw new Error("base.run_target / _v40=None");
    }
    else {
        value_12(_v40);
    }
}

export function closure19(v0_1: string, v1_1: Option<any>, v2_1: [string, string][], v3_1: Option<((arg0: [int32, string, boolean]) => any)>, v4_1: Option<((arg0: any) => void)>, v5_1: boolean, v6_1: Option<string>, v7: void, v8: any, v9: void): void {
    let _v10: Option<any> = undefined;
    const x: any = defaultOf();
    _v10 = x;
    let v40: any;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v40 = value_12(_v10);
    }
    let _v41: Option<void> = undefined;
    defaultOf();
    _v41 = some(undefined);
    if (_v41 == null) {
        throw new Error("base.run_target / _v41=None");
    }
    else {
        value_12(_v41);
    }
}

export function closure20(v0_1: void, unitVar: void): void {
    let _v1: Option<boolean> = undefined;
    const x: boolean = defaultOf();
    _v1 = x;
    if (((_v1 == null) ? (() => {
        throw new Error("base.run_target / _v1=None");
    })() : value_12(_v1)) === false) {
        let _v10: Option<void> = undefined;
        defaultOf();
        _v10 = some(undefined);
        if (_v10 == null) {
            throw new Error("base.run_target / _v10=None");
        }
        else {
            value_12(_v10);
        }
    }
}

export function closure21(unitVar: void, unitVar_1: void): string {
    return "runtime.execute_with_options_async / WaitForExitAsync";
}

export function closure22(v0_1: any, unitVar: void): any {
    return v0_1;
}

export function method36(v0_1: Mut4, v1_1: any): void {
    method26(v0_1, toText(interpolate("%A%P()", [v1_1])));
}

export function method35(v0_1: Mut4, v1_1: any): void {
    method26(v0_1, "{ ");
    method9(v0_1);
    method26(v0_1, "ex");
    method26(v0_1, " = ");
    method36(v0_1, v1_1);
    method26(v0_1, " }");
}

export function closure23(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => any), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_12(State_trace_state());
    const v9: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_12(v9);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method7());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value_12(_v10);
    }
    const v159: US3_$union = (v0_1.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v208: US3_$union;
    if (v159.tag === /* US3_0 */ 0) {
        v208 = US3_US3_0(v159.fields[0]);
    }
    else {
        const v168: US3_$union = (v0_1.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v168.tag === /* US3_0 */ 0) {
            v208 = US3_US3_0(v168.fields[0]);
        }
        else {
            const v177: US3_$union = (v0_1.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v177.tag === /* US3_0 */ 0) {
                v208 = US3_US3_0(v177.fields[0]);
            }
            else {
                const v186: US3_$union = (v0_1.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v186.tag === /* US3_0 */ 0) {
                    v208 = US3_US3_0(v186.fields[0]);
                }
                else {
                    const v195: US3_$union = (v0_1.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v208 = ((v195.tag === /* US3_0 */ 0) ? US3_US3_0(v195.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v212: string;
    if (v208.tag === /* US3_0 */ 0) {
        v212 = v208.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v215: string = padLeft(v212.toLocaleLowerCase(), 7, " ");
    let _v216: Option<string> = undefined;
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method8();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value_12(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    const v332: Mut4 = new Mut4("");
    method35(v332, v2_1());
    const v333: string = v332.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v333}`, ...[]), ...[" ", "/"]);
}

export function method34(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => any)): void {
    method10(v0_1, (): string => closure23(v0_1, v1_1, v2_1, undefined));
}

export function closure24(unitVar: void, unitVar_1: void): string {
    return "runtime.execute_with_options_async";
}

export function closure25(v0_1: int32, v1_1: string, unitVar: void): [int32, int32] {
    return [v0_1, v1_1.length] as [int32, int32];
}

export function method39(v0_1: Mut4, v1_1: int32): void {
    const v2_1 = `${v1_1}`;
    const v4_1: string = v0_1.l0 + v2_1;
    v0_1.l0 = v4_1;
}

export function method38(v0_1: Mut4, v1_1: int32, v2_1: int32): void {
    method26(v0_1, "{ ");
    method9(v0_1);
    method26(v0_1, "exit_code");
    method26(v0_1, " = ");
    method39(v0_1, v1_1);
    method26(v0_1, "; ");
    method26(v0_1, "output_length");
    method26(v0_1, " = ");
    method39(v0_1, v2_1);
    method26(v0_1, " }");
}

export function closure26(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [int32, int32]), unitVar: void): string {
    let v74: int64, v80: number;
    if (State_trace_state() == null) {
        State_trace_state(closure0(undefined, US0_US0_0()));
    }
    const patternInput: [Mut0, Mut1, Mut2, Mut3, Option<int64>] = value_12(State_trace_state());
    const v9: Option<int64> = patternInput[4];
    let _v10: Option<string> = undefined;
    const _v68: FSharpRef<Option<US2_$union>> = new FSharpRef<Option<US2_$union>>(undefined);
    let x_2: Option<US2_$union>;
    if (v9 == null) {
        x_2 = undefined;
    }
    else {
        const x: int64 = value_12(v9);
        x_2 = ((): US2_$union => US2_US2_0(x))();
    }
    _v68.contents = x_2;
    const v73: US2_$union = defaultArg(_v68.contents, US2_US2_1());
    const x_3: string = toString((v73.tag === /* US2_0 */ 0) ? ((v74 = v73.fields[0], (v80 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v74))), create(1, 1, 1, hours(v80), minutes(v80), seconds(v80), milliseconds(v80))))) : now(), method7());
    _v10 = x_3;
    let v152: string;
    if (_v10 == null) {
        throw new Error("base.run_target / _v10=None");
    }
    else {
        v152 = value_12(_v10);
    }
    const v159: US3_$union = (v0_1.tag === /* US0_0 */ 0) ? US3_US3_0("Verbose") : US3_US3_1();
    let v208: US3_$union;
    if (v159.tag === /* US3_0 */ 0) {
        v208 = US3_US3_0(v159.fields[0]);
    }
    else {
        const v168: US3_$union = (v0_1.tag === /* US0_1 */ 1) ? US3_US3_0("Debug") : US3_US3_1();
        if (v168.tag === /* US3_0 */ 0) {
            v208 = US3_US3_0(v168.fields[0]);
        }
        else {
            const v177: US3_$union = (v0_1.tag === /* US0_2 */ 2) ? US3_US3_0("Info") : US3_US3_1();
            if (v177.tag === /* US3_0 */ 0) {
                v208 = US3_US3_0(v177.fields[0]);
            }
            else {
                const v186: US3_$union = (v0_1.tag === /* US0_3 */ 3) ? US3_US3_0("Warning") : US3_US3_1();
                if (v186.tag === /* US3_0 */ 0) {
                    v208 = US3_US3_0(v186.fields[0]);
                }
                else {
                    const v195: US3_$union = (v0_1.tag === /* US0_4 */ 4) ? US3_US3_0("Critical") : US3_US3_1();
                    v208 = ((v195.tag === /* US3_0 */ 0) ? US3_US3_0(v195.fields[0]) : US3_US3_1());
                }
            }
        }
    }
    let v212: string;
    if (v208.tag === /* US3_0 */ 0) {
        v212 = v208.fields[0];
    }
    else {
        throw new Error("Option does not have a value.");
    }
    const v215: string = padLeft(v212.toLocaleLowerCase(), 7, " ");
    let _v216: Option<string> = undefined;
    const x_5: string = (((v0_1.tag === /* US0_1 */ 1) ? "\u001b[94m" : ((v0_1.tag === /* US0_2 */ 2) ? "\u001b[92m" : ((v0_1.tag === /* US0_0 */ 0) ? "\u001b[90m" : ((v0_1.tag === /* US0_3 */ 3) ? "\u001b[93m" : "\u001b[91m")))) + v215) + method8();
    _v216 = x_5;
    let v328: string;
    if (_v216 == null) {
        throw new Error("base.run_target / _v216=None");
    }
    else {
        v328 = value_12(_v216);
    }
    const v329: int64 = patternInput[0].l0;
    const patternInput_1: [int32, int32] = v2_1();
    const v333: Mut4 = new Mut4("");
    method38(v333, patternInput_1[0], patternInput_1[1]);
    const v334: string = v333.l0;
    return trimEnd(trimStart(`${v152} ${v328} #${v329} ${v1_1()} / ${v334}`, ...[]), ...[" ", "/"]);
}

export function method37(v0_1: US0_$union, v1_1: (() => string), v2_1: (() => [int32, int32])): void {
    method10(v0_1, (): string => closure26(v0_1, v1_1, v2_1, undefined));
}

export function method11(v0_1: string, v1_1: Option<any>, v2_1: [string, string][], v3_1: Option<((arg0: [int32, string, boolean]) => any)>, v4_1: Option<((arg0: any) => void)>, v5_1: boolean, v6_1: Option<string>): any {
    let _v7: Option<any> = undefined;
    const x: any = defaultOf();
    _v7 = x;
    if (_v7 == null) {
        throw new Error("base.run_target / _v7=None");
    }
    else {
        return value_12(_v7);
    }
}

export function closure9(unitVar: void, v0_1: string): any {
    return method11(v0_1, undefined, [], undefined, undefined, true, undefined);
}

export function closure27(unitVar: void, _arg: [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>]): any {
    return method11(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6]);
}

export function closure28(unitVar: void, v0_1: ((arg0: Heap0) => Heap0)): [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>] {
    const v8: Heap0 = v0_1(new Heap0("", undefined, [], undefined, undefined, true, undefined));
    return [v8.l0, v8.l1, v8.l2, v8.l3, v8.l4, v8.l5, v8.l6] as [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>];
}

export function method42(v0_1_mut: string, v1_1_mut: int64): boolean {
    method42:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int64 = v1_1_mut;
        if (compare_1(v1_1, 4n) >= 0) {
            return false;
        }
        else {
            let v19: US7_$union;
            if (equals(v1_1, 0n)) {
                v19 = US7_US7_0("\\");
            }
            else {
                const v5_1: int64 = toInt64(op_Subtraction(v1_1, 1n));
                if (equals(v5_1, 0n)) {
                    v19 = US7_US7_0("`");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5_1, 1n));
                    if (equals(v8, 0n)) {
                        v19 = US7_US7_0("\"");
                    }
                    else {
                        const v11: int64 = toInt64(op_Subtraction(v8, 1n));
                        if (equals(v11, 0n)) {
                            v19 = US7_US7_0(" ");
                        }
                        else {
                            const v14: int64 = toInt64(op_Subtraction(v11, 1n));
                            v19 = US7_US7_1();
                        }
                    }
                }
            }
            if (v0_1 === ((v19.tag === /* US7_0 */ 0) ? v19.fields[0] : (() => {
                throw new Error("Option does not have a value.");
            })())) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = toInt64(op_Addition(v1_1, 1n));
                continue method42;
            }
        }
        break;
    }
}

export function method43(v0_1_mut: string, v1_1_mut: string, v2_1_mut: any, v3_1_mut: int32, v4_1_mut: int32): US6_$union {
    method43:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3_1: int32 = v3_1_mut, v4_1: int32 = v4_1_mut;
        let v57: US5_$union;
        if ("" === v1_1) {
            v57 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\"", " "], [v2_1, v3_1, v4_1] as [any, int32, int32]])));
        }
        else {
            const v15: string = v1_1[0];
            const v19 = 1;
            const v21: int32 = v1_1.length | 0;
            const v22: string = v1_1.slice(v19, v21 + 1);
            if (method42(v15, 0n) === false) {
                const v27: string = v15;
                const v28: int32 = v27.length | 0;
                const v29: string[] = fill(new Array(v28), 0, v28, "");
                const v30: Mut5 = new Mut5(0);
                while (method13(v28, v30)) {
                    const v32: int32 = v30.l0 | 0;
                    const v33: string = v27[v32];
                    setItem(v29, v32, v33);
                    const v34: int32 = (v32 + 1) | 0;
                    v30.l0 = (v34 | 0);
                }
                const v36: FSharpList<string> = ofArray<string>(v29);
                const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v36, UH0_UH0_0()), v2_1, v3_1, v4_1);
                v57 = US5_US5_0(v15, v22, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v57 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v15, ["\\", "`", "\"", " "], [v2_1, v3_1, v4_1] as [any, int32, int32]])));
            }
        }
        if (v57.tag === /* US5_0 */ 0) {
            v0_1_mut = (v0_1 + v57.fields[0]);
            v1_1_mut = v57.fields[1];
            v2_1_mut = v57.fields[2];
            v3_1_mut = v57.fields[3];
            v4_1_mut = v57.fields[4];
            continue method43;
        }
        else {
            const v67: string = v57.fields[0];
            return US6_US6_0(v0_1, v1_1, v2_1, v3_1, v4_1);
        }
        break;
    }
}

export function method45(v0_1_mut: string, v1_1_mut: int64): boolean {
    method45:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int64 = v1_1_mut;
        if (compare_1(v1_1, 3n) >= 0) {
            return false;
        }
        else {
            let v15: US7_$union;
            if (equals(v1_1, 0n)) {
                v15 = US7_US7_0("\\");
            }
            else {
                const v5_1: int64 = toInt64(op_Subtraction(v1_1, 1n));
                if (equals(v5_1, 0n)) {
                    v15 = US7_US7_0("`");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5_1, 1n));
                    if (equals(v8, 0n)) {
                        v15 = US7_US7_0("\"");
                    }
                    else {
                        const v11: int64 = toInt64(op_Subtraction(v8, 1n));
                        v15 = US7_US7_1();
                    }
                }
            }
            if (v0_1 === ((v15.tag === /* US7_0 */ 0) ? v15.fields[0] : (() => {
                throw new Error("Option does not have a value.");
            })())) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = toInt64(op_Addition(v1_1, 1n));
                continue method45;
            }
        }
        break;
    }
}

export function closure30(unitVar: void, _arg: [string, any, int32, int32]): US6_$union {
    const v3_1: int32 = _arg[3] | 0;
    const v2_1: int32 = _arg[2] | 0;
    const v1_1: any = _arg[1];
    const v0_1: string = _arg[0];
    let v60: US5_$union;
    if ("" === v0_1) {
        v60 = US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v1_1, v2_1, v3_1] as [any, int32, int32]])));
    }
    else {
        const v7: string = v0_1[0];
        if (v7 === "\\") {
            const v12 = 1;
            const v14: int32 = v0_1.length | 0;
            const v15: string = v0_1.slice(v12, v14 + 1);
            const v17: string = v7;
            const v18: int32 = v17.length | 0;
            const v19: string[] = fill(new Array(v18), 0, v18, "");
            const v20: Mut5 = new Mut5(0);
            while (method13(v18, v20)) {
                const v22: int32 = v20.l0 | 0;
                const v23: string = v17[v22];
                setItem(v19, v22, v23);
                const v24: int32 = (v22 + 1) | 0;
                v20.l0 = (v24 | 0);
            }
            const v26: FSharpList<string> = ofArray<string>(v19);
            const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v26, UH0_UH0_0()), v1_1, v2_1, v3_1);
            v60 = US5_US5_0(v7, v15, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v38: int32 = v0_1.length | 0;
            const v41: int32 = (v0_1.indexOf("\n") - 1) | 0;
            const v45 = 0;
            const v47: int32 = ((-2 === v41) ? v38 : v41) | 0;
            v60 = US5_US5_1(`${`parsing.p_char / expected: '${"\\"}' / line: ${v2_1} / col: ${v3_1}
${v1_1}${v0_1.slice(v45, v47 + 1)}`}
${replicate(v3_1 - 1, " ") + "^"}
`);
        }
    }
    let v102: US5_$union;
    if (v60.tag === /* US5_0 */ 0) {
        const v65: int32 = v60.fields[4] | 0;
        const v64: int32 = v60.fields[3] | 0;
        const v63: any = v60.fields[2];
        const v62: string = v60.fields[1];
        const v61: string = v60.fields[0];
        if ("" === v62) {
            v102 = US5_US5_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v63, v64, v65] as [any, int32, int32]])));
        }
        else {
            const v69: string = v62[0];
            const v73 = 1;
            const v75: int32 = v62.length | 0;
            const v76: string = v62.slice(v73, v75 + 1);
            const v78: string = v69;
            const v79: int32 = v78.length | 0;
            const v80: string[] = fill(new Array(v79), 0, v79, "");
            const v81: Mut5 = new Mut5(0);
            while (method13(v79, v81)) {
                const v83: int32 = v81.l0 | 0;
                const v84: string = v78[v83];
                setItem(v80, v83, v84);
                const v85: int32 = (v83 + 1) | 0;
                v81.l0 = (v85 | 0);
            }
            const v87: FSharpList<string> = ofArray<string>(v80);
            const patternInput_1: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v87, UH0_UH0_0()), v63, v64, v65);
            v102 = US5_US5_0(v69, v76, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
        }
    }
    else {
        v102 = US5_US5_1(v60.fields[0]);
    }
    if (v102.tag === /* US5_0 */ 0) {
        return US6_US6_0(`${"\\"}${v102.fields[0]}`, v102.fields[1], v102.fields[2], v102.fields[3], v102.fields[4]);
    }
    else {
        return US6_US6_1(v102.fields[0]);
    }
}

export function closure31(unitVar: void, _arg: [string, any, int32, int32]): US6_$union {
    const v3_1: int32 = _arg[3] | 0;
    const v2_1: int32 = _arg[2] | 0;
    const v1_1: any = _arg[1];
    const v0_1: string = _arg[0];
    let v60: US5_$union;
    if ("" === v0_1) {
        v60 = US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v1_1, v2_1, v3_1] as [any, int32, int32]])));
    }
    else {
        const v7: string = v0_1[0];
        if (v7 === "`") {
            const v12 = 1;
            const v14: int32 = v0_1.length | 0;
            const v15: string = v0_1.slice(v12, v14 + 1);
            const v17: string = v7;
            const v18: int32 = v17.length | 0;
            const v19: string[] = fill(new Array(v18), 0, v18, "");
            const v20: Mut5 = new Mut5(0);
            while (method13(v18, v20)) {
                const v22: int32 = v20.l0 | 0;
                const v23: string = v17[v22];
                setItem(v19, v22, v23);
                const v24: int32 = (v22 + 1) | 0;
                v20.l0 = (v24 | 0);
            }
            const v26: FSharpList<string> = ofArray<string>(v19);
            const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v26, UH0_UH0_0()), v1_1, v2_1, v3_1);
            v60 = US5_US5_0(v7, v15, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v38: int32 = v0_1.length | 0;
            const v41: int32 = (v0_1.indexOf("\n") - 1) | 0;
            const v45 = 0;
            const v47: int32 = ((-2 === v41) ? v38 : v41) | 0;
            v60 = US5_US5_1(`${`parsing.p_char / expected: '${"`"}' / line: ${v2_1} / col: ${v3_1}
${v1_1}${v0_1.slice(v45, v47 + 1)}`}
${replicate(v3_1 - 1, " ") + "^"}
`);
        }
    }
    let v102: US5_$union;
    if (v60.tag === /* US5_0 */ 0) {
        const v65: int32 = v60.fields[4] | 0;
        const v64: int32 = v60.fields[3] | 0;
        const v63: any = v60.fields[2];
        const v62: string = v60.fields[1];
        const v61: string = v60.fields[0];
        if ("" === v62) {
            v102 = US5_US5_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v63, v64, v65] as [any, int32, int32]])));
        }
        else {
            const v69: string = v62[0];
            const v73 = 1;
            const v75: int32 = v62.length | 0;
            const v76: string = v62.slice(v73, v75 + 1);
            const v78: string = v69;
            const v79: int32 = v78.length | 0;
            const v80: string[] = fill(new Array(v79), 0, v79, "");
            const v81: Mut5 = new Mut5(0);
            while (method13(v79, v81)) {
                const v83: int32 = v81.l0 | 0;
                const v84: string = v78[v83];
                setItem(v80, v83, v84);
                const v85: int32 = (v83 + 1) | 0;
                v81.l0 = (v85 | 0);
            }
            const v87: FSharpList<string> = ofArray<string>(v80);
            const patternInput_1: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v87, UH0_UH0_0()), v63, v64, v65);
            v102 = US5_US5_0(v69, v76, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
        }
    }
    else {
        v102 = US5_US5_1(v60.fields[0]);
    }
    if (v102.tag === /* US5_0 */ 0) {
        return US6_US6_0(`${"`"}${v102.fields[0]}`, v102.fields[1], v102.fields[2], v102.fields[3], v102.fields[4]);
    }
    else {
        return US6_US6_1(v102.fields[0]);
    }
}

export function method46(v0_1_mut: string, v1_1_mut: any, v2_1_mut: int32, v3_1_mut: int32, v4_1_mut: UH3_$union): US6_$union {
    method46:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: any = v1_1_mut, v2_1: int32 = v2_1_mut, v3_1: int32 = v3_1_mut, v4_1: UH3_$union = v4_1_mut;
        if (v4_1.tag === /* UH3_0 */ 0) {
            return US6_US6_1("choice / no parsers succeeded");
        }
        else {
            const v8: UH3_$union = v4_1.fields[1];
            const v9: US6_$union = v4_1.fields[0]([v0_1, v1_1, v2_1, v3_1] as [string, any, int32, int32]);
            if (v9.tag === /* US6_0 */ 0) {
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
                v3_1_mut = v3_1;
                v4_1_mut = v8;
                continue method46;
            }
        }
        break;
    }
}

export function method47(v0_1_mut: UH2_$union, v1_1_mut: UH2_$union): UH2_$union {
    method47:
    while (true) {
        const v0_1: UH2_$union = v0_1_mut, v1_1: UH2_$union = v1_1_mut;
        if (v0_1.tag === /* UH2_0 */ 0) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[1];
            v1_1_mut = UH2_UH2_1(v0_1.fields[0], v1_1);
            continue method47;
        }
        break;
    }
}

export function method44(v0_1_mut: UH2_$union, v1_1_mut: string, v2_1_mut: any, v3_1_mut: int32, v4_1_mut: int32): US15_$union {
    method44:
    while (true) {
        const v0_1: UH2_$union = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3_1: int32 = v3_1_mut, v4_1: int32 = v4_1_mut;
        let v55: US5_$union;
        if ("" === v1_1) {
            v55 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\""], [v2_1, v3_1, v4_1] as [any, int32, int32]])));
        }
        else {
            const v14: string = v1_1[0];
            const v18 = 1;
            const v20: int32 = v1_1.length | 0;
            const v21: string = v1_1.slice(v18, v20 + 1);
            if (method45(v14, 0n) === false) {
                const v26: string = v14;
                const v27: int32 = v26.length | 0;
                const v28: string[] = fill(new Array(v27), 0, v27, "");
                const v29: Mut5 = new Mut5(0);
                while (method13(v27, v29)) {
                    const v31: int32 = v29.l0 | 0;
                    const v32: string = v26[v31];
                    setItem(v28, v31, v32);
                    const v33: int32 = (v31 + 1) | 0;
                    v29.l0 = (v33 | 0);
                }
                const v35: FSharpList<string> = ofArray<string>(v28);
                const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v35, UH0_UH0_0()), v2_1, v3_1, v4_1);
                v55 = US5_US5_0(v14, v21, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v55 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v14, ["\\", "`", "\""], [v2_1, v3_1, v4_1] as [any, int32, int32]])));
            }
        }
        const v67: US6_$union = (v55.tag === /* US5_0 */ 0) ? US6_US6_0(v55.fields[0], v55.fields[1], v55.fields[2], v55.fields[3], v55.fields[4]) : US6_US6_1(v55.fields[0]);
        let v81: US6_$union;
        if (v67.tag === /* US6_0 */ 0) {
            const v72: int32 = v67.fields[4] | 0;
            const v71: int32 = v67.fields[3] | 0;
            const v70: any = v67.fields[2];
            const v69: string = v67.fields[1];
            const v68: string = v67.fields[0];
            v81 = v67;
        }
        else {
            const v73: string = v67.fields[0];
            v81 = method46(v1_1, v2_1, v3_1, v4_1, UH3_UH3_1((arg10$0040: [string, any, int32, int32]): US6_$union => closure30(undefined, arg10$0040), UH3_UH3_1((arg10$0040_1: [string, any, int32, int32]): US6_$union => closure31(undefined, arg10$0040_1), UH3_UH3_0())));
        }
        if (v81.tag === /* US6_0 */ 0) {
            v0_1_mut = UH2_UH2_1(v81.fields[0], v0_1);
            v1_1_mut = v81.fields[1];
            v2_1_mut = v81.fields[2];
            v3_1_mut = v81.fields[3];
            v4_1_mut = v81.fields[4];
            continue method44;
        }
        else {
            const v89: string = v81.fields[0];
            return US15_US15_0(method47(v0_1, UH2_UH2_0()), v1_1, v2_1, v3_1, v4_1);
        }
        break;
    }
}

export function method48(v0_1: UH2_$union, v1_1: FSharpList<string>): FSharpList<string> {
    if (v0_1.tag === /* UH2_0 */ 0) {
        return v1_1;
    }
    else {
        return cons(v0_1.fields[0], method48(v0_1.fields[1], v1_1));
    }
}

export function method49(v0_1_mut: UH2_$union, v1_1_mut: string, v2_1_mut: any, v3_1_mut: int32, v4_1_mut: int32): US15_$union {
    method49:
    while (true) {
        const v0_1: UH2_$union = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3_1: int32 = v3_1_mut, v4_1: int32 = v4_1_mut;
        let v55: US5_$union;
        if ("" === v1_1) {
            v55 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\""], [v2_1, v3_1, v4_1] as [any, int32, int32]])));
        }
        else {
            const v14: string = v1_1[0];
            const v18 = 1;
            const v20: int32 = v1_1.length | 0;
            const v21: string = v1_1.slice(v18, v20 + 1);
            if (method45(v14, 0n) === false) {
                const v26: string = v14;
                const v27: int32 = v26.length | 0;
                const v28: string[] = fill(new Array(v27), 0, v27, "");
                const v29: Mut5 = new Mut5(0);
                while (method13(v27, v29)) {
                    const v31: int32 = v29.l0 | 0;
                    const v32: string = v26[v31];
                    setItem(v28, v31, v32);
                    const v33: int32 = (v31 + 1) | 0;
                    v29.l0 = (v33 | 0);
                }
                const v35: FSharpList<string> = ofArray<string>(v28);
                const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v35, UH0_UH0_0()), v2_1, v3_1, v4_1);
                v55 = US5_US5_0(v14, v21, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v55 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v14, ["\\", "`", "\""], [v2_1, v3_1, v4_1] as [any, int32, int32]])));
            }
        }
        const v67: US6_$union = (v55.tag === /* US5_0 */ 0) ? US6_US6_0(v55.fields[0], v55.fields[1], v55.fields[2], v55.fields[3], v55.fields[4]) : US6_US6_1(v55.fields[0]);
        if (v67.tag === /* US6_0 */ 0) {
            v0_1_mut = UH2_UH2_1(v67.fields[0], v0_1);
            v1_1_mut = v67.fields[1];
            v2_1_mut = v67.fields[2];
            v3_1_mut = v67.fields[3];
            v4_1_mut = v67.fields[4];
            continue method49;
        }
        else {
            const v75: string = v67.fields[0];
            return US15_US15_0(method47(v0_1, UH2_UH2_0()), v1_1, v2_1, v3_1, v4_1);
        }
        break;
    }
}

export function method50(v0_1_mut: string, v1_1_mut: int32): int32 {
    method50:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v1_1 >= v0_1.length) {
            return v1_1 | 0;
        }
        else if (v0_1[v1_1] === " ") {
            v0_1_mut = v0_1;
            v1_1_mut = (v1_1 + 1);
            continue method50;
        }
        else {
            return v1_1 | 0;
        }
        break;
    }
}

export function method41(v0_1_mut: UH2_$union, v1_1_mut: string, v2_1_mut: any, v3_1_mut: int32, v4_1_mut: int32): US15_$union {
    method41:
    while (true) {
        const v0_1: UH2_$union = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3_1: int32 = v3_1_mut, v4_1: int32 = v4_1_mut;
        const v5_1: boolean = "" === v1_1;
        let v57: US5_$union;
        if (v5_1) {
            v57 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\"", " "], [v2_1, v3_1, v4_1] as [any, int32, int32]])));
        }
        else {
            const v15: string = v1_1[0];
            const v19 = 1;
            const v21: int32 = v1_1.length | 0;
            const v22: string = v1_1.slice(v19, v21 + 1);
            if (method42(v15, 0n) === false) {
                const v27: string = v15;
                const v28: int32 = v27.length | 0;
                const v29: string[] = fill(new Array(v28), 0, v28, "");
                const v30: Mut5 = new Mut5(0);
                while (method13(v28, v30)) {
                    const v32: int32 = v30.l0 | 0;
                    const v33: string = v27[v32];
                    setItem(v29, v32, v33);
                    const v34: int32 = (v32 + 1) | 0;
                    v30.l0 = (v34 | 0);
                }
                const v36: FSharpList<string> = ofArray<string>(v29);
                const patternInput: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v36, UH0_UH0_0()), v2_1, v3_1, v4_1);
                v57 = US5_US5_0(v15, v22, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v57 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v15, ["\\", "`", "\"", " "], [v2_1, v3_1, v4_1] as [any, int32, int32]])));
            }
        }
        const v69: US6_$union = (v57.tag === /* US5_0 */ 0) ? method43(v57.fields[0], v57.fields[1], v57.fields[2], v57.fields[3], v57.fields[4]) : US6_US6_1(v57.fields[0]);
        let v292: US6_$union;
        if (v69.tag === /* US6_0 */ 0) {
            const v74: int32 = v69.fields[4] | 0;
            const v73: int32 = v69.fields[3] | 0;
            const v72: any = v69.fields[2];
            const v71: string = v69.fields[1];
            const v70: string = v69.fields[0];
            v292 = v69;
        }
        else {
            const v75: string = v69.fields[0];
            let v131: US5_$union;
            if (v5_1) {
                v131 = US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v2_1, v3_1, v4_1] as [any, int32, int32]])));
            }
            else {
                const v78: string = v1_1[0];
                if (v78 === "\"") {
                    const v83 = 1;
                    const v85: int32 = v1_1.length | 0;
                    const v86: string = v1_1.slice(v83, v85 + 1);
                    const v88: string = v78;
                    const v89: int32 = v88.length | 0;
                    const v90: string[] = fill(new Array(v89), 0, v89, "");
                    const v91: Mut5 = new Mut5(0);
                    while (method13(v89, v91)) {
                        const v93: int32 = v91.l0 | 0;
                        const v94: string = v88[v93];
                        setItem(v90, v93, v94);
                        const v95: int32 = (v93 + 1) | 0;
                        v91.l0 = (v95 | 0);
                    }
                    const v97: FSharpList<string> = ofArray<string>(v90);
                    const patternInput_1: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v97, UH0_UH0_0()), v2_1, v3_1, v4_1);
                    v131 = US5_US5_0(v78, v86, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
                }
                else {
                    const v109: int32 = v1_1.length | 0;
                    const v112: int32 = (v1_1.indexOf("\n") - 1) | 0;
                    const v116 = 0;
                    const v118: int32 = ((-2 === v112) ? v109 : v112) | 0;
                    v131 = US5_US5_1(`${`parsing.p_char / expected: '${"\""}' / line: ${v3_1} / col: ${v4_1}
${v2_1}${v1_1.slice(v116, v118 + 1)}`}
${replicate(v4_1 - 1, " ") + "^"}
`);
                }
            }
            let v237: US6_$union;
            if (v131.tag === /* US5_0 */ 0) {
                const v136: int32 = v131.fields[4] | 0;
                const v135: int32 = v131.fields[3] | 0;
                const v134: any = v131.fields[2];
                const v133: string = v131.fields[1];
                const v132: string = v131.fields[0];
                const v138: US15_$union = method44(UH2_UH2_0(), v133, v134, v135, v136);
                let v155: US6_$union;
                if (v138.tag === /* US15_0 */ 0) {
                    const v143: int32 = v138.fields[4] | 0;
                    const v142: int32 = v138.fields[3] | 0;
                    const v141: any = v138.fields[2];
                    const v140: string = v138.fields[1];
                    const v145: FSharpList<string> = method48(v138.fields[0], empty<string>());
                    v155 = US6_US6_0(join("", delay<string>((): Iterable<string> => map<int32, string>((i: int32): string => item(i, v145), rangeDouble(0, 1, length(v145) - 1)))), v140, v141, v142, v143);
                }
                else {
                    v155 = US6_US6_1(v138.fields[0]);
                }
                if (v155.tag === /* US6_0 */ 0) {
                    const v160: int32 = v155.fields[4] | 0;
                    const v159: int32 = v155.fields[3] | 0;
                    const v158: any = v155.fields[2];
                    const v157: string = v155.fields[1];
                    const v156: string = v155.fields[0];
                    let v217: US5_$union;
                    if ("" === v157) {
                        v217 = US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v158, v159, v160] as [any, int32, int32]])));
                    }
                    else {
                        const v164: string = v157[0];
                        if (v164 === "\"") {
                            const v169 = 1;
                            const v171: int32 = v157.length | 0;
                            const v172: string = v157.slice(v169, v171 + 1);
                            const v174: string = v164;
                            const v175: int32 = v174.length | 0;
                            const v176: string[] = fill(new Array(v175), 0, v175, "");
                            const v177: Mut5 = new Mut5(0);
                            while (method13(v175, v177)) {
                                const v179: int32 = v177.l0 | 0;
                                const v180: string = v174[v179];
                                setItem(v176, v179, v180);
                                const v181: int32 = (v179 + 1) | 0;
                                v177.l0 = (v181 | 0);
                            }
                            const v183: FSharpList<string> = ofArray<string>(v176);
                            const patternInput_2: [any, int32, int32] = method15(foldBack<string, UH0_$union>(uncurry2(method14()), v183, UH0_UH0_0()), v158, v159, v160);
                            v217 = US5_US5_0(v164, v172, patternInput_2[0], patternInput_2[1], patternInput_2[2]);
                        }
                        else {
                            const v195: int32 = v157.length | 0;
                            const v198: int32 = (v157.indexOf("\n") - 1) | 0;
                            const v202 = 0;
                            const v204: int32 = ((-2 === v198) ? v195 : v198) | 0;
                            v217 = US5_US5_1(`${`parsing.p_char / expected: '${"\""}' / line: ${v159} / col: ${v160}
${v158}${v157.slice(v202, v204 + 1)}`}
${replicate(v160 - 1, " ") + "^"}
`);
                        }
                    }
                    if (v217.tag === /* US5_0 */ 0) {
                        const v218: string = v217.fields[0];
                        v237 = US6_US6_0(v156, v217.fields[1], v217.fields[2], v217.fields[3], v217.fields[4]);
                    }
                    else {
                        v237 = US6_US6_1(toText(interpolate("between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v217.fields[0], [v1_1, v2_1, v3_1, v4_1] as [string, any, int32, int32], [v133, v134, v135, v136] as [string, any, int32, int32], [v157, v158, v159, v160] as [string, any, int32, int32]])));
                    }
                }
                else {
                    const v229: string = v155.fields[0];
                    v237 = US6_US6_1("between / expected content");
                }
            }
            else {
                v237 = US6_US6_1(v131.fields[0]);
            }
            if (v237.tag === /* US6_0 */ 0) {
                const v242: int32 = v237.fields[4] | 0;
                const v241: int32 = v237.fields[3] | 0;
                const v240: any = v237.fields[2];
                const v239: string = v237.fields[1];
                const v238: string = v237.fields[0];
                v292 = v237;
            }
            else {
                const v243: string = v237.fields[0];
                const v249: US6_$union = method46(v1_1, v2_1, v3_1, v4_1, UH3_UH3_1((arg10$0040: [string, any, int32, int32]): US6_$union => closure30(undefined, arg10$0040), UH3_UH3_1((arg10$0040_1: [string, any, int32, int32]): US6_$union => closure31(undefined, arg10$0040_1), UH3_UH3_0())));
                let v260: US6_$union;
                if (v249.tag === /* US6_0 */ 0) {
                    const v250: string = v249.fields[0];
                    v260 = US6_US6_0("", v249.fields[1], v249.fields[2], v249.fields[3], v249.fields[4]);
                }
                else {
                    v260 = US6_US6_1(v249.fields[0]);
                }
                let v271: US15_$union;
                if (v260.tag === /* US6_0 */ 0) {
                    const v261: string = v260.fields[0];
                    v271 = method49(UH2_UH2_0(), v260.fields[1], v260.fields[2], v260.fields[3], v260.fields[4]);
                }
                else {
                    v271 = US15_US15_1(v260.fields[0]);
                }
                if (v271.tag === /* US15_0 */ 0) {
                    const v276: int32 = v271.fields[4] | 0;
                    const v275: int32 = v271.fields[3] | 0;
                    const v274: any = v271.fields[2];
                    const v273: string = v271.fields[1];
                    const v278: FSharpList<string> = method48(v271.fields[0], empty<string>());
                    v292 = US6_US6_0(join("", delay<string>((): Iterable<string> => map<int32, string>((i_1: int32): string => item(i_1, v278), rangeDouble(0, 1, length(v278) - 1)))), v273, v274, v275, v276);
                }
                else {
                    v292 = US6_US6_1(v271.fields[0]);
                }
            }
        }
        if (v292.tag === /* US6_0 */ 0) {
            const v301: int32 = v292.fields[4] | 0;
            const v300: int32 = v292.fields[3] | 0;
            const v299: any = v292.fields[2];
            const v298: string = v292.fields[1];
            const v297: string = v292.fields[0];
            const v303: int32 = method50(v298, 0) | 0;
            let v315: US8_$union;
            if (0 === v303) {
                v315 = US8_US8_1("spaces1 / expected at least one space");
            }
            else {
                const v310: int32 = v303 | 0;
                const v312: int32 = v298.length | 0;
                v315 = US8_US8_0(v298.slice(v310, v312 + 1), v299, v300, v301);
            }
            if (v315.tag === /* US8_0 */ 0) {
                v0_1_mut = UH2_UH2_1(v297, v0_1);
                v1_1_mut = v315.fields[0];
                v2_1_mut = v315.fields[1];
                v3_1_mut = v315.fields[2];
                v4_1_mut = v315.fields[3];
                continue method41;
            }
            else {
                const v316: string = v315.fields[0];
                return US15_US15_0(method47(v0_1, UH2_UH2_1(v297, UH2_UH2_0())), v298, v299, v300, v301);
            }
        }
        else {
            const v293: string = v292.fields[0];
            return US15_US15_0(method47(v0_1, UH2_UH2_0()), v1_1, v2_1, v3_1, v4_1);
        }
        break;
    }
}

export function method40(v0_1: string): US14_$union {
    let _v0: Option<Option<string>> = undefined;
    _v0 = some(v0_1);
    const v11: US15_$union = method41(UH2_UH2_0(), defaultArg((_v0 == null) ? (() => {
        throw new Error("optionm\'.of_obj / _v0=None");
    })() : value_12(_v0), ""), StringBuilder_$ctor_Z721C83C5(""), 1, 1);
    if (v11.tag === /* US15_0 */ 0) {
        const v16: int32 = v11.fields[4] | 0;
        const v15: int32 = v11.fields[3] | 0;
        const v14: any = v11.fields[2];
        const v13: string = v11.fields[1];
        return US14_US14_0(toArray<string>(method48(v11.fields[0], empty<string>())));
    }
    else {
        return US14_US14_1(v11.fields[0]);
    }
}

export function closure29(unitVar: void, v0_1: string): FSharpResult$2_$union<string[], string> {
    const v1_1: US14_$union = method40(v0_1);
    if (v1_1.tag === /* US14_0 */ 0) {
        return FSharpResult$2_Ok<string[], string>(v1_1.fields[0]);
    }
    else {
        return FSharpResult$2_Error<string[], string>(v1_1.fields[0]);
    }
}

export const v0 = (v: US0_$union): [Mut0, Mut1, Mut2, Mut3, Option<int64>] => closure0(undefined, v);

export const v1: US0_$union = US0_US0_0();

if (State_trace_state() == null) {
    State_trace_state(v0(v1));
}

export const v2 = (): void => {
    closure2(undefined, undefined);
};

export function current_process_kill(): void {
    v2();
}

export const v3 = (v: string): any => closure9(undefined, v);

export function execute_async(x: string): any {
    return v3(x);
}

export const v4 = (arg10$0040: [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>]): any => closure27(undefined, arg10$0040);

export function execute_with_options_async(x: [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>]): any {
    return v4(x);
}

export const v5 = (v: ((arg0: Heap0) => Heap0)): [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>] => closure28(undefined, v);

export function execution_options(x: ((arg0: Heap0) => Heap0)): [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>] {
    return v5(x);
}

export const v6 = (v: string): FSharpResult$2_$union<string[], string> => closure29(undefined, v);

export function split_args(x: string): FSharpResult$2_$union<string[], string> {
    return v6(x);
}


