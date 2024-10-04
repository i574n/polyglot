import { defaultOf, uncurry2, compare, IComparable, IEquatable, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { some, map, defaultArg, value as value_12, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { equals, compare as compare_1, op_Addition, op_Subtraction, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
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
    return union_type("Runtime.US1", [], US1, () => [[["f0_0", string_type]], []]);
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
    return union_type("Runtime.US2", [], US2, () => [[["f0_0", US0_$reflection()]], []]);
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
    return union_type("Runtime.US3", [], US3, () => [[["f0_0", int64_type]], []]);
}

export type US4_$union = 
    | US4<0>
    | US4<1>

export type US4_$cases = {
    0: ["US4_0", [string, US1_$union]],
    1: ["US4_1", [string]]
}

export function US4_US4_0(f0_0: string, f0_1: US1_$union) {
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
    return union_type("Runtime.US4", [], US4, () => [[["f0_0", string_type], ["f0_1", US1_$reflection()]], [["f1_0", string_type]]]);
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
    0: ["US9_0", [string, US1_$union, string, any, int32, int32]],
    1: ["US9_1", [string]]
}

export function US9_US9_0(f0_0: string, f0_1: US1_$union, f0_2: string, f0_3: any, f0_4: int32, f0_5: int32) {
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
    return union_type("Runtime.US9", [], US9, () => [[["f0_0", string_type], ["f0_1", US1_$reflection()], ["f0_2", string_type], ["f0_3", class_type("System.Text.StringBuilder")], ["f0_4", int32_type], ["f0_5", int32_type]], [["f1_0", string_type]]]);
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
    0: ["US11_0", [US1_$union, string, any, int32, int32]],
    1: ["US11_1", [string]]
}

export function US11_US11_0(f0_0: US1_$union, f0_1: string, f0_2: any, f0_3: int32, f0_4: int32) {
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
    return union_type("Runtime.US11", [], US11, () => [[["f0_0", US1_$reflection()], ["f0_1", string_type], ["f0_2", class_type("System.Text.StringBuilder")], ["f0_3", int32_type], ["f0_4", int32_type]], [["f1_0", string_type]]]);
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

export function method1(): string {
    return "TRACE_LEVEL";
}

export function method3(): string {
    return "";
}

export function closure1(unitVar: void, v0_1: string): US1_$union {
    return US1_US1_0(v0_1);
}

export function method4(): ((arg0: string) => US1_$union) {
    return (v: string): US1_$union => closure1(undefined, v);
}

export function method2(v0_1: string): string {
    return process.env[v0_1] ?? "";
}

export function method5(): string {
    return "AUTOMATION";
}

export function closure2(unitVar: void, v0_1: string): void {
}

export function method0(v0_1: US0_$union): [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] {
    let v181: US2_$union, v188: US2_$union, v195: US2_$union, v202: US2_$union;
    const v169: string = method2(method1());
    const v174: US2_$union = ("Verbose" === v169) ? US2_US2_0(US0_US0_0()) : US2_US2_1();
    const _v1 = [(v174.tag === /* US2_0 */ 0) ? US2_US2_0(v174.fields[0]) : ((v181 = (("Debug" === v169) ? US2_US2_0(US0_US0_1()) : US2_US2_1()), (v181.tag === /* US2_0 */ 0) ? US2_US2_0(v181.fields[0]) : ((v188 = (("Info" === v169) ? US2_US2_0(US0_US0_2()) : US2_US2_1()), (v188.tag === /* US2_0 */ 0) ? US2_US2_0(v188.fields[0]) : ((v195 = (("Warning" === v169) ? US2_US2_0(US0_US0_3()) : US2_US2_1()), (v195.tag === /* US2_0 */ 0) ? US2_US2_0(v195.fields[0]) : ((v202 = (("Critical" === v169) ? US2_US2_0(US0_US0_4()) : US2_US2_1()), (v202.tag === /* US2_0 */ 0) ? US2_US2_0(v202.fields[0]) : US2_US2_1())))))))), (method2(method5()) === "True") ? US3_US3_0(getTicks(now())) : US3_US3_1()] as [US2_$union, US3_$union];
    const v352: US3_$union = _v1[1];
    const v351: US2_$union = _v1[0];
    return [new Mut0(1n), new Mut1((v: string): void => {
        closure2(undefined, v);
    }), new Mut2(true), new Mut3(""), new Mut4((v351.tag === /* US2_0 */ 0) ? v351.fields[0] : v0_1), (v352.tag === /* US3_0 */ 0) ? v352.fields[0] : undefined] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>];
}

export function closure0(unitVar: void, unitVar_1: void): void {
    if (TraceState_trace_state() == null) {
        const patternInput: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>] = method0(US0_US0_0());
        TraceState_trace_state([patternInput[0], patternInput[1], patternInput[2], patternInput[3], patternInput[4], patternInput[5]] as [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]);
    }
}

export function method6(v0_1: US0_$union): boolean {
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

export function closure6(unitVar: void, v0_1: int64): US3_$union {
    return US3_US3_0(v0_1);
}

export function method8(): ((arg0: int64) => US3_$union) {
    return (v: int64): US3_$union => closure6(undefined, v);
}

export function method9(): string {
    return "hh:mm:ss";
}

export function method10(): string {
    return "HH:mm:ss";
}

export function method7(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>): string {
    let v181: int64, v191: number;
    const v177: US3_$union = defaultArg(map<int64, US3_$union>(method8(), v5), US3_US3_1());
    return toString((v177.tag === /* US3_0 */ 0) ? ((v181 = v177.fields[0], (v191 = fromTicks(toInt64(op_Subtraction(getTicks(now()), v181))), create(1, 1, 1, hours(v191), minutes(v191), seconds(v191), milliseconds(v191))))) : now(), method10());
}

export function method13(): string {
    return "";
}

export function closure7(v0_1: Mut3, v1_1: string, unitVar: void): void {
    const v3: string = v0_1.l0 + v1_1;
    v0_1.l0 = v3;
}

export function method12(v0_1: string): string {
    const v2_1: Mut3 = new Mut3(method13());
    let v8: any;
    closure7(v2_1, `${v0_1}`, undefined);
    v8 = undefined;
    return v2_1.l0;
}

export function method14(): string {
    return "\u001b[0m";
}

export function method11(): string {
    const v2_1: string = "Warning".toLocaleLowerCase();
    return ("\u001b[93m" + method12(v2_1[0])) + method14();
}

export function method16(): string {
    const v1_1: Mut3 = new Mut3(method13());
    return v1_1.l0;
}

export function method17(v0_1: string): string {
    return trimEnd(trimStart(v0_1, ...[]), ...[" ", "/"]);
}

export function method15(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string): string {
    const v8: string = method16();
    return method17(`${v6} ${v7} #${v0_1.l0} ${"runtime.current_process_kill / exiting... 3"} / ${v8}`);
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

export function method18(v0_1: string): void {
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
    if (method6(US0_US0_3())) {
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
        method18(method15(v18_1, v19_1, v20_1, v21, v22, v23, method7(v18_1, v19_1, v20_1, v21, v22, v23), method11()));
    }
}

export function method19(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string): string {
    const v8: string = method16();
    return method17(`${v6} ${v7} #${v0_1.l0} ${"runtime.current_process_kill / exiting... 2"} / ${v8}`);
}

export function closure11(unitVar: void, unitVar_1: void): void {
    if (method6(US0_US0_3())) {
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
        method18(method19(v18_1, v19_1, v20_1, v21, v22, v23, method7(v18_1, v19_1, v20_1, v21, v22, v23), method11()));
    }
}

export function method20(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string): string {
    const v8: string = method16();
    return method17(`${v6} ${v7} #${v0_1.l0} ${"runtime.current_process_kill / exiting... 1"} / ${v8}`);
}

export function closure12(unitVar: void, unitVar_1: void): void {
    if (method6(US0_US0_3())) {
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
        method18(method20(v18_1, v19_1, v20_1, v21, v22, v23, method7(v18_1, v19_1, v20_1, v21, v22, v23), method11()));
    }
}

export function closure4(unitVar: void, unitVar_1: void): void {
}

export function closure3(unitVar: void, unitVar_1: void): void {
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
    let v12: any, v18_1: any;
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
            v1_1_mut = (v6 ? ((v12 = StringBuilder__Clear(v1_1), v1_1)) : ((v18_1 = StringBuilder__Append_Z721C83C5(v1_1, v4), v1_1)));
            v2_1_mut = patternInput[0];
            v3_mut = patternInput[1];
            continue method25;
        }
        break;
    }
}

export function closure14(unitVar: void, _arg: [string, any, int32, int32]): US5_$union {
    const v3: int32 = _arg[3] | 0;
    const v2_1: int32 = _arg[2] | 0;
    const v1_1: any = _arg[1];
    const v0_1: string = _arg[0];
    if ("" === v0_1) {
        return US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v1_1, v2_1, v3] as [any, int32, int32]])));
    }
    else {
        const v7: string = v0_1[0];
        if (v7 === "\"") {
            const v12 = 1;
            const v14: int32 = v0_1.length | 0;
            const v15: string = v0_1.slice(v12, v14 + 1);
            const v17_1: string = v7;
            const v20_1: int32 = v17_1.length | 0;
            const v21: string[] = fill(new Array(v20_1), 0, v20_1, "");
            const v22: Mut5 = new Mut5(0);
            while (method23(v20_1, v22)) {
                const v24: int32 = v22.l0 | 0;
                const v25: string = v17_1[v24];
                setItem(v21, v24, v25);
                const v26: int32 = (v24 + 1) | 0;
                v22.l0 = (v26 | 0);
            }
            const v27: FSharpList<string> = ofArray<string>(v21);
            const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v27, UH0_UH0_0()), v1_1, v2_1, v3);
            return US5_US5_0(v7, v15, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v43: int32 = v0_1.length | 0;
            const v46: int32 = (v0_1.indexOf("\n") - 1) | 0;
            const v50 = 0;
            const v52: int32 = ((-2 === v46) ? v43 : v46) | 0;
            return US5_US5_1(`${`parsing.p_char / expected: '${"\""}' / line: ${v2_1} / col: ${v3}
${v1_1}${v0_1.slice(v50, v52 + 1)}`}
${replicate(v3 - 1, " ") + "^"}
`);
        }
    }
}

export function closure17(unitVar: void, _arg: [string, any, int32, int32]): US5_$union {
    const v3: int32 = _arg[3] | 0;
    const v2_1: int32 = _arg[2] | 0;
    const v1_1: any = _arg[1];
    const v0_1: string = _arg[0];
    if ("" === v0_1) {
        return US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v1_1, v2_1, v3] as [any, int32, int32]])));
    }
    else {
        const v7: string = v0_1[0];
        if (v7 === "\'") {
            const v12 = 1;
            const v14: int32 = v0_1.length | 0;
            const v15: string = v0_1.slice(v12, v14 + 1);
            const v17_1: string = v7;
            const v20_1: int32 = v17_1.length | 0;
            const v21: string[] = fill(new Array(v20_1), 0, v20_1, "");
            const v22: Mut5 = new Mut5(0);
            while (method23(v20_1, v22)) {
                const v24: int32 = v22.l0 | 0;
                const v25: string = v17_1[v24];
                setItem(v21, v24, v25);
                const v26: int32 = (v24 + 1) | 0;
                v22.l0 = (v26 | 0);
            }
            const v27: FSharpList<string> = ofArray<string>(v21);
            const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v27, UH0_UH0_0()), v1_1, v2_1, v3);
            return US5_US5_0(v7, v15, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v43: int32 = v0_1.length | 0;
            const v46: int32 = (v0_1.indexOf("\n") - 1) | 0;
            const v50 = 0;
            const v52: int32 = ((-2 === v46) ? v43 : v46) | 0;
            return US5_US5_1(`${`parsing.p_char / expected: '${"\'"}' / line: ${v2_1} / col: ${v3}
${v1_1}${v0_1.slice(v50, v52 + 1)}`}
${replicate(v3 - 1, " ") + "^"}
`);
        }
    }
}

export function method26(v0_1_mut: string, v1_1_mut: any, v2_1_mut: UH1_$union): US5_$union {
    method26:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: any = v1_1_mut, v2_1: UH1_$union = v2_1_mut;
        if (v2_1.tag === /* UH1_0 */ 0) {
            return US5_US5_1("choice / no parsers succeeded");
        }
        else {
            const v6: UH1_$union = v2_1.fields[1];
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
            let v11: US7_$union;
            if (equals(v1_1, 0n)) {
                v11 = US7_US7_0("\"");
            }
            else {
                const v5: int64 = toInt64(op_Subtraction(v1_1, 1n));
                if (equals(v5, 0n)) {
                    v11 = US7_US7_0("\'");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5, 1n));
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
                continue method27;
            }
        }
        break;
    }
}

export function method28(v0_1_mut: string, v1_1_mut: string, v2_1_mut: any, v3_mut: int32, v4_mut: int32): US6_$union {
    method28:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3: int32 = v3_mut, v4: int32 = v4_mut;
        let v70: US5_$union;
        if ("" === v1_1) {
            v70 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'"], [v2_1, v3, v4] as [any, int32, int32]])));
        }
        else {
            const v19_1: string = v1_1[0];
            const v23 = 1;
            const v25: int32 = v1_1.length | 0;
            const v26: string = v1_1.slice(v23, v25 + 1);
            if (method27(v19_1, 0n) === false) {
                const v31: string = v19_1;
                const v34: int32 = v31.length | 0;
                const v35: string[] = fill(new Array(v34), 0, v34, "");
                const v36: Mut5 = new Mut5(0);
                while (method23(v34, v36)) {
                    const v38: int32 = v36.l0 | 0;
                    const v39: string = v31[v38];
                    setItem(v35, v38, v39);
                    const v40: int32 = (v38 + 1) | 0;
                    v36.l0 = (v40 | 0);
                }
                const v41: FSharpList<string> = ofArray<string>(v35);
                const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v41, UH0_UH0_0()), v2_1, v3, v4);
                v70 = US5_US5_0(v19_1, v26, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v70 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v19_1, ["\"", "\'"], [v2_1, v3, v4] as [any, int32, int32]])));
            }
        }
        let v82: US5_$union;
        if (v70.tag === /* US5_0 */ 0) {
            const v71: string = v70.fields[0];
            v82 = US5_US5_0(("\\" === v71) ? "/" : v71, v70.fields[1], v70.fields[2], v70.fields[3], v70.fields[4]);
        }
        else {
            v82 = US5_US5_1(v70.fields[0]);
        }
        if (v82.tag === /* US5_0 */ 0) {
            v0_1_mut = (v0_1 + v82.fields[0]);
            v1_1_mut = v82.fields[1];
            v2_1_mut = v82.fields[2];
            v3_mut = v82.fields[3];
            v4_mut = v82.fields[4];
            continue method28;
        }
        else {
            const v94: string = v82.fields[0];
            return US6_US6_0(v0_1, v1_1, v2_1, v3, v4);
        }
        break;
    }
}

export function method29(v0_1_mut: string, v1_1_mut: any, v2_1_mut: int32, v3_mut: int32, v4_mut: UH1_$union): US5_$union {
    method29:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: any = v1_1_mut, v2_1: int32 = v2_1_mut, v3: int32 = v3_mut, v4: UH1_$union = v4_mut;
        if (v4.tag === /* UH1_0 */ 0) {
            return US5_US5_1("choice / no parsers succeeded");
        }
        else {
            const v8: UH1_$union = v4.fields[1];
            const v9: US5_$union = v4.fields[0]([v0_1, v1_1, v2_1, v3] as [string, any, int32, int32]);
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
            let v15: US7_$union;
            if (equals(v1_1, 0n)) {
                v15 = US7_US7_0("\"");
            }
            else {
                const v5: int64 = toInt64(op_Subtraction(v1_1, 1n));
                if (equals(v5, 0n)) {
                    v15 = US7_US7_0("\'");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5, 1n));
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
                continue method30;
            }
        }
        break;
    }
}

export function method31(v0_1_mut: string, v1_1_mut: string, v2_1_mut: any, v3_mut: int32, v4_mut: int32): US6_$union {
    method31:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3: int32 = v3_mut, v4: int32 = v4_mut;
        let v76: US5_$union;
        if ("" === v1_1) {
            v76 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'", " "], [v2_1, v3, v4] as [any, int32, int32]])));
        }
        else {
            const v22: string = v1_1[0];
            const v26 = 1;
            const v28: int32 = v1_1.length | 0;
            const v29: string = v1_1.slice(v26, v28 + 1);
            if (method30(v22, 0n) === false) {
                const v34: string = v22;
                const v37: int32 = v34.length | 0;
                const v38: string[] = fill(new Array(v37), 0, v37, "");
                const v39: Mut5 = new Mut5(0);
                while (method23(v37, v39)) {
                    const v41: int32 = v39.l0 | 0;
                    const v42: string = v34[v41];
                    setItem(v38, v41, v42);
                    const v43: int32 = (v41 + 1) | 0;
                    v39.l0 = (v43 | 0);
                }
                const v44: FSharpList<string> = ofArray<string>(v38);
                const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v44, UH0_UH0_0()), v2_1, v3, v4);
                v76 = US5_US5_0(v22, v29, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v76 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v22, ["\"", "\'", " "], [v2_1, v3, v4] as [any, int32, int32]])));
            }
        }
        let v88: US5_$union;
        if (v76.tag === /* US5_0 */ 0) {
            const v77: string = v76.fields[0];
            v88 = US5_US5_0(("\\" === v77) ? "/" : v77, v76.fields[1], v76.fields[2], v76.fields[3], v76.fields[4]);
        }
        else {
            v88 = US5_US5_1(v76.fields[0]);
        }
        if (v88.tag === /* US5_0 */ 0) {
            v0_1_mut = (v0_1 + v88.fields[0]);
            v1_1_mut = v88.fields[1];
            v2_1_mut = v88.fields[2];
            v3_mut = v88.fields[3];
            v4_mut = v88.fields[4];
            continue method31;
        }
        else {
            const v100: string = v88.fields[0];
            return US6_US6_0(v0_1, v1_1, v2_1, v3, v4);
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
        else if (v0_1[v1_1] === " ") {
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

export function method33(v0_1_mut: string, v1_1_mut: string, v2_1_mut: any, v3_mut: int32, v4_mut: int32): US6_$union {
    method33:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3: int32 = v3_mut, v4: int32 = v4_mut;
        let v42: US5_$union;
        if ("" === v1_1) {
            v42 = US5_US5_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v2_1, v3, v4] as [any, int32, int32]])));
        }
        else {
            const v8: string = v1_1[0];
            const v12 = 1;
            const v14: int32 = v1_1.length | 0;
            const v15: string = v1_1.slice(v12, v14 + 1);
            const v17_1: string = v8;
            const v20_1: int32 = v17_1.length | 0;
            const v21: string[] = fill(new Array(v20_1), 0, v20_1, "");
            const v22: Mut5 = new Mut5(0);
            while (method23(v20_1, v22)) {
                const v24: int32 = v22.l0 | 0;
                const v25: string = v17_1[v24];
                setItem(v21, v24, v25);
                const v26: int32 = (v24 + 1) | 0;
                v22.l0 = (v26 | 0);
            }
            const v27: FSharpList<string> = ofArray<string>(v21);
            const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v27, UH0_UH0_0()), v2_1, v3, v4);
            v42 = US5_US5_0(v8, v15, patternInput[0], patternInput[1], patternInput[2]);
        }
        if (v42.tag === /* US5_0 */ 0) {
            v0_1_mut = (v0_1 + v42.fields[0]);
            v1_1_mut = v42.fields[1];
            v2_1_mut = v42.fields[2];
            v3_mut = v42.fields[3];
            v4_mut = v42.fields[4];
            continue method33;
        }
        else {
            const v54: string = v42.fields[0];
            return US6_US6_0(v0_1, v1_1, v2_1, v3, v4);
        }
        break;
    }
}

export function method22(v0_1: string): US4_$union {
    let _v0: Option<Option<string>> = undefined;
    _v0 = some(v0_1);
    const v7: string = defaultArg((_v0 == null) ? (() => {
        throw new Error("optionm\'.of_obj / _v0=None");
    })() : value_12(_v0), "");
    const v11: any = StringBuilder_$ctor_Z721C83C5("");
    const v12 = (arg10$0040: [string, any, int32, int32]): US5_$union => closure14(undefined, arg10$0040);
    const v13 = (arg10$0040_1: [string, any, int32, int32]): US5_$union => closure17(undefined, arg10$0040_1);
    const v17_1: US5_$union = method26(v7, v11, UH1_UH1_1(v12, UH1_UH1_1(v13, UH1_UH1_0())));
    let v153: US6_$union;
    if (v17_1.tag === /* US5_0 */ 0) {
        const v22: int32 = v17_1.fields[4] | 0;
        const v21: int32 = v17_1.fields[3] | 0;
        const v20_1: any = v17_1.fields[2];
        const v19_1: string = v17_1.fields[1];
        const v18_1: string = v17_1.fields[0];
        let v88: US5_$union;
        if ("" === v19_1) {
            v88 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'"], [v20_1, v21, v22] as [any, int32, int32]])));
        }
        else {
            const v37: string = v19_1[0];
            const v41 = 1;
            const v43: int32 = v19_1.length | 0;
            const v44: string = v19_1.slice(v41, v43 + 1);
            if (method27(v37, 0n) === false) {
                const v49: string = v37;
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
                const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v59, UH0_UH0_0()), v20_1, v21, v22);
                v88 = US5_US5_0(v37, v44, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v88 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v37, ["\"", "\'"], [v20_1, v21, v22] as [any, int32, int32]])));
            }
        }
        let v100: US5_$union;
        if (v88.tag === /* US5_0 */ 0) {
            const v89: string = v88.fields[0];
            v100 = US5_US5_0(("\\" === v89) ? "/" : v89, v88.fields[1], v88.fields[2], v88.fields[3], v88.fields[4]);
        }
        else {
            v100 = US5_US5_1(v88.fields[0]);
        }
        const v114: US6_$union = (v100.tag === /* US5_0 */ 0) ? method28(v100.fields[0], v100.fields[1], v100.fields[2], v100.fields[3], v100.fields[4]) : US6_US6_1(v100.fields[0]);
        let v124: US6_$union;
        if (v114.tag === /* US6_0 */ 0) {
            v124 = US6_US6_0(v114.fields[0], v114.fields[1], v114.fields[2], v114.fields[3], v114.fields[4]);
        }
        else {
            const v121: string = v114.fields[0];
            v124 = US6_US6_0("", v19_1, v20_1, v21, v22);
        }
        if (v124.tag === /* US6_0 */ 0) {
            const v129: int32 = v124.fields[4] | 0;
            const v128: int32 = v124.fields[3] | 0;
            const v127: any = v124.fields[2];
            const v126: string = v124.fields[1];
            const v125: string = v124.fields[0];
            const v133: US5_$union = method29(v126, v127, v128, v129, UH1_UH1_1(v12, UH1_UH1_1(v13, UH1_UH1_0())));
            if (v133.tag === /* US5_0 */ 0) {
                const v134: string = v133.fields[0];
                v153 = US6_US6_0(v125, v133.fields[1], v133.fields[2], v133.fields[3], v133.fields[4]);
            }
            else {
                v153 = US6_US6_1(toText(interpolate("between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v133.fields[0], [v7, v11, 1, 1] as [string, any, int32, int32], [v19_1, v20_1, v21, v22] as [string, any, int32, int32], [v126, v127, v128, v129] as [string, any, int32, int32]])));
            }
        }
        else {
            const v145: string = v124.fields[0];
            v153 = US6_US6_1("between / expected content");
        }
    }
    else {
        v153 = US6_US6_1(v17_1.fields[0]);
    }
    let v303: US6_$union;
    if (v153.tag === /* US6_0 */ 0) {
        const v158: int32 = v153.fields[4] | 0;
        const v157: int32 = v153.fields[3] | 0;
        const v156: any = v153.fields[2];
        const v155: string = v153.fields[1];
        const v154: string = v153.fields[0];
        v303 = v153;
    }
    else {
        const v159: string = v153.fields[0];
        let v233: US5_$union;
        if ("" === v7) {
            v233 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\"", "\'", " "], [v11, 1, 1] as [any, int32, int32]])));
        }
        else {
            const v177: string = v7[0];
            const v181 = 1;
            const v183: int32 = v7.length | 0;
            const v184: string = v7.slice(v181, v183 + 1);
            if (method30(v177, 0n) === false) {
                const v189: string = v177;
                const v192: int32 = v189.length | 0;
                const v193: string[] = fill(new Array(v192), 0, v192, "");
                const v194: Mut5 = new Mut5(0);
                while (method23(v192, v194)) {
                    const v196: int32 = v194.l0 | 0;
                    const v197: string = v189[v196];
                    setItem(v193, v196, v197);
                    const v198: int32 = (v196 + 1) | 0;
                    v194.l0 = (v198 | 0);
                }
                const v199: FSharpList<string> = ofArray<string>(v193);
                const patternInput_1: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v199, UH0_UH0_0()), v11, 1, 1);
                v233 = US5_US5_0(v177, v184, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
            }
            else {
                v233 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v177, ["\"", "\'", " "], [v11, 1, 1] as [any, int32, int32]])));
            }
        }
        let v245: US5_$union;
        if (v233.tag === /* US5_0 */ 0) {
            const v234: string = v233.fields[0];
            v245 = US5_US5_0(("\\" === v234) ? "/" : v234, v233.fields[1], v233.fields[2], v233.fields[3], v233.fields[4]);
        }
        else {
            v245 = US5_US5_1(v233.fields[0]);
        }
        const v259: US6_$union = (v245.tag === /* US5_0 */ 0) ? method31(v245.fields[0], v245.fields[1], v245.fields[2], v245.fields[3], v245.fields[4]) : US6_US6_1(v245.fields[0]);
        if (v259.tag === /* US6_0 */ 0) {
            const v264: int32 = v259.fields[4] | 0;
            const v263: int32 = v259.fields[3] | 0;
            const v262: any = v259.fields[2];
            const v261: string = v259.fields[1];
            const v260: string = v259.fields[0];
            v303 = v259;
        }
        else {
            const v265: string = v259.fields[0];
            const v271: US8_$union = (v7.length === 0) ? US8_US8_0(v7, v11, 1, 1) : US8_US8_1(toText(interpolate("parsing.eof / expected end of input / input: %A%P()", [v7])));
            const v280: US6_$union = (v271.tag === /* US8_0 */ 0) ? US6_US6_0("", v271.fields[0], v271.fields[1], v271.fields[2], v271.fields[3]) : US6_US6_1(v271.fields[0]);
            if (v280.tag === /* US6_0 */ 0) {
                const v285: int32 = v280.fields[4] | 0;
                const v284: int32 = v280.fields[3] | 0;
                const v283: any = v280.fields[2];
                const v282: string = v280.fields[1];
                const v281: string = v280.fields[0];
                const v291: int32 = method32(v282, 0) | 0;
                const v293: int32 = v282.length | 0;
                v303 = US6_US6_0(v281, v282.slice(v291, v293 + 1), v283, v284, v285);
            }
            else {
                v303 = US6_US6_1(v280.fields[0]);
            }
        }
    }
    let v471: US9_$union;
    if (v303.tag === /* US6_0 */ 0) {
        const v308: int32 = v303.fields[4] | 0;
        const v307: int32 = v303.fields[3] | 0;
        const v306: any = v303.fields[2];
        const v305: string = v303.fields[1];
        const v304: string = v303.fields[0];
        let v372: US5_$union;
        if ("" === v305) {
            v372 = US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v306, v307, v308] as [any, int32, int32]])));
        }
        else {
            const v312: string = v305[0];
            if (v312 === " ") {
                const v317 = 1;
                const v319: int32 = v305.length | 0;
                const v320: string = v305.slice(v317, v319 + 1);
                const v322: string = v312;
                const v325: int32 = v322.length | 0;
                const v326: string[] = fill(new Array(v325), 0, v325, "");
                const v327: Mut5 = new Mut5(0);
                while (method23(v325, v327)) {
                    const v329: int32 = v327.l0 | 0;
                    const v330: string = v322[v329];
                    setItem(v326, v329, v330);
                    const v331: int32 = (v329 + 1) | 0;
                    v327.l0 = (v331 | 0);
                }
                const v332: FSharpList<string> = ofArray<string>(v326);
                const patternInput_2: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v332, UH0_UH0_0()), v306, v307, v308);
                v372 = US5_US5_0(v312, v320, patternInput_2[0], patternInput_2[1], patternInput_2[2]);
            }
            else {
                const v348: int32 = v305.length | 0;
                const v351: int32 = (v305.indexOf("\n") - 1) | 0;
                const v355 = 0;
                const v357: int32 = ((-2 === v351) ? v348 : v351) | 0;
                v372 = US5_US5_1(`${`parsing.p_char / expected: '${" "}' / line: ${v307} / col: ${v308}
${v306}${v305.slice(v355, v357 + 1)}`}
${replicate(v308 - 1, " ") + "^"}
`);
            }
        }
        let v384: US10_$union;
        if (v372.tag === /* US5_0 */ 0) {
            v384 = US10_US10_0(US7_US7_0(v372.fields[0]), v372.fields[1], v372.fields[2], v372.fields[3], v372.fields[4]);
        }
        else {
            const v380: string = v372.fields[0];
            v384 = US10_US10_0(US7_US7_1(), v305, v306, v307, v308);
        }
        let v445: US6_$union;
        if (v384.tag === /* US10_0 */ 0) {
            const v389: int32 = v384.fields[4] | 0;
            const v388: int32 = v384.fields[3] | 0;
            const v387: any = v384.fields[2];
            const v386: string = v384.fields[1];
            const v385: US7_$union = v384.fields[0];
            let v427: US5_$union;
            if ("" === v386) {
                v427 = US5_US5_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v387, v388, v389] as [any, int32, int32]])));
            }
            else {
                const v393: string = v386[0];
                const v397 = 1;
                const v399: int32 = v386.length | 0;
                const v400: string = v386.slice(v397, v399 + 1);
                const v402: string = v393;
                const v405: int32 = v402.length | 0;
                const v406: string[] = fill(new Array(v405), 0, v405, "");
                const v407: Mut5 = new Mut5(0);
                while (method23(v405, v407)) {
                    const v409: int32 = v407.l0 | 0;
                    const v410: string = v402[v409];
                    setItem(v406, v409, v410);
                    const v411: int32 = (v409 + 1) | 0;
                    v407.l0 = (v411 | 0);
                }
                const v412: FSharpList<string> = ofArray<string>(v406);
                const patternInput_3: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v412, UH0_UH0_0()), v387, v388, v389);
                v427 = US5_US5_0(v393, v400, patternInput_3[0], patternInput_3[1], patternInput_3[2]);
            }
            v445 = ((v427.tag === /* US5_0 */ 0) ? method33(v427.fields[0], v427.fields[1], v427.fields[2], v427.fields[3], v427.fields[4]) : US6_US6_1(v427.fields[0]));
        }
        else {
            v445 = US6_US6_1(v384.fields[0]);
        }
        let v457: US11_$union;
        if (v445.tag === /* US6_0 */ 0) {
            v457 = US11_US11_0(US1_US1_0(v445.fields[0]), v445.fields[1], v445.fields[2], v445.fields[3], v445.fields[4]);
        }
        else {
            const v453: string = v445.fields[0];
            v457 = US11_US11_0(US1_US1_1(), v305, v306, v307, v308);
        }
        v471 = ((v457.tag === /* US11_0 */ 0) ? US9_US9_0(v304, v457.fields[0], v457.fields[1], v457.fields[2], v457.fields[3], v457.fields[4]) : US9_US9_1(v457.fields[0]));
    }
    else {
        v471 = US9_US9_1(v303.fields[0]);
    }
    if (v471.tag === /* US9_0 */ 0) {
        const v477: int32 = v471.fields[5] | 0;
        const v476: int32 = v471.fields[4] | 0;
        const v475: any = v471.fields[3];
        const v474: string = v471.fields[2];
        return US4_US4_0(v471.fields[0], v471.fields[1]);
    }
    else {
        return US4_US4_1(v471.fields[0]);
    }
}

export function method34(): string {
    const v2_1: string = "Debug".toLocaleLowerCase();
    return ("\u001b[94m" + method12(v2_1[0])) + method14();
}

export function method36(v0_1: string, v1_1: US1_$union, v2_1: string, v3: Option<any>, v4: [string, string][], v5: Option<((arg0: [int32, string, boolean]) => any)>, v6: Option<((arg0: any) => void)>, v7: boolean, v8: Option<string>): string {
    const v10: Mut3 = new Mut3(method13());
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
    let v198: any;
    closure7(v10, `${toText(interpolate("%A%P()", [v3]))}`, undefined);
    v198 = undefined;
    let v206: any;
    closure7(v10, `${"; "}`, undefined);
    v206 = undefined;
    let v215: any;
    closure7(v10, `${"environment_variables"}`, undefined);
    v215 = undefined;
    let v223: any;
    closure7(v10, `${" = "}`, undefined);
    v223 = undefined;
    let v234: any;
    closure7(v10, `${toText(interpolate("%A%P()", [v4]))}`, undefined);
    v234 = undefined;
    let v242: any;
    closure7(v10, `${"; "}`, undefined);
    v242 = undefined;
    let v251: any;
    closure7(v10, `${"on_line"}`, undefined);
    v251 = undefined;
    let v259: any;
    closure7(v10, `${" = "}`, undefined);
    v259 = undefined;
    let v294: any;
    closure7(v10, `${toText(interpolate("%A%P()", [v5]))}`, undefined);
    v294 = undefined;
    let v302: any;
    closure7(v10, `${"; "}`, undefined);
    v302 = undefined;
    let v311: any;
    closure7(v10, `${"stdin"}`, undefined);
    v311 = undefined;
    let v319: any;
    closure7(v10, `${" = "}`, undefined);
    v319 = undefined;
    let v354: any;
    closure7(v10, `${toText(interpolate("%A%P()", [v6]))}`, undefined);
    v354 = undefined;
    let v362: any;
    closure7(v10, `${"; "}`, undefined);
    v362 = undefined;
    let v371: any;
    closure7(v10, `${"trace"}`, undefined);
    v371 = undefined;
    let v379: any;
    closure7(v10, `${" = "}`, undefined);
    v379 = undefined;
    let v390: any;
    closure7(v10, `${v7 ? "true" : "false"}`, undefined);
    v390 = undefined;
    let v398: any;
    closure7(v10, `${"; "}`, undefined);
    v398 = undefined;
    let v407: any;
    closure7(v10, `${"working_directory"}`, undefined);
    v407 = undefined;
    let v415: any;
    closure7(v10, `${" = "}`, undefined);
    v415 = undefined;
    let v450: any;
    closure7(v10, `${toText(interpolate("%A%P()", [v8]))}`, undefined);
    v450 = undefined;
    let v459: any;
    closure7(v10, `${" }"}`, undefined);
    v459 = undefined;
    let v467: any;
    closure7(v10, `${" }"}`, undefined);
    v467 = undefined;
    return v10.l0;
}

export function method35(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: string, v9: US1_$union, v10: string, v11: Option<any>, v12: [string, string][], v13: Option<((arg0: [int32, string, boolean]) => any)>, v14: Option<((arg0: any) => void)>, v15: boolean, v16_1: Option<string>): string {
    const v17_1: string = method36(v8, v9, v10, v11, v12, v13, v14, v15, v16_1);
    return method17(`${v6} ${v7} #${v0_1.l0} ${"runtime.execute_with_options_async"} / ${v17_1}`);
}

export function closure18(v0_1: string, v1_1: Option<any>, v2_1: [string, string][], v3: Option<((arg0: [int32, string, boolean]) => any)>, v4: Option<((arg0: any) => void)>, v5: boolean, v6: Option<string>, v7: US1_$union, v8: string, unitVar: void): void {
    if (method6(US0_US0_1())) {
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
        method18(method35(v27, v28, v29, v30, v31, v32, method7(v27, v28, v29, v30, v31, v32), method34(), v8, v7, v0_1, v1_1, v2_1, v3, v4, v5, v6));
    }
}

export function closure20(unitVar: void, v0_1: ((arg0: [int32, string, boolean]) => any)): US12_$union {
    return US12_US12_0(v0_1);
}

export function method37(): ((arg0: ((arg0: [int32, string, boolean]) => any)) => US12_$union) {
    return (v: ((arg0: [int32, string, boolean]) => any)): US12_$union => closure20(undefined, v);
}

export function method38(): string {
    const v2_1: string = "Verbose".toLocaleLowerCase();
    return ("\u001b[90m" + method12(v2_1[0])) + method14();
}

export function method39(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: string): string {
    const v9: string = method16();
    return method17(`${v6} ${v7} #${v0_1.l0} ${v8} / ${v9}`);
}

export function closure21(v0_1: string, unitVar: void): void {
    if (method6(US0_US0_0())) {
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
        method18((v0_1 === "") ? "" : method39(v19_1, v20_1, v21, v22, v23, v24, method7(v19_1, v20_1, v21, v22, v23, v24), method38(), v0_1));
    }
}

export function closure19(v0_1: string, v1_1: Option<any>, v2_1: [string, string][], v3: Option<((arg0: [int32, string, boolean]) => any)>, v4: Option<((arg0: any) => void)>, v5: boolean, v6: Option<string>, v7: void, v8: any, v9: void): void {
    const v20_1: any = defaultOf();
    defaultOf();
}

export function closure22(v0_1: string, v1_1: Option<any>, v2_1: [string, string][], v3: Option<((arg0: [int32, string, boolean]) => any)>, v4: Option<((arg0: any) => void)>, v5: boolean, v6: Option<string>, v7: void, v8: any, v9: void): void {
    const v20_1: any = defaultOf();
    defaultOf();
}

export function closure23(unitVar: void, v0_1: any): US13_$union {
    return US13_US13_0(v0_1);
}

export function method40(): ((arg0: any) => US13_$union) {
    return (v: any): US13_$union => closure23(undefined, v);
}

export function closure24(v0_1: void, unitVar: void): void {
    if (defaultOf() === false) {
    }
}

export function method42(v0_1: any): string {
    const v2_1: Mut3 = new Mut3(method13());
    let v9: any;
    closure7(v2_1, `${"{ "}`, undefined);
    v9 = undefined;
    let v18_1: any;
    closure7(v2_1, `${"ex"}`, undefined);
    v18_1 = undefined;
    let v27: any;
    closure7(v2_1, `${" = "}`, undefined);
    v27 = undefined;
    let v62: any;
    closure7(v2_1, `${toText(interpolate("%A%P()", [v0_1]))}`, undefined);
    v62 = undefined;
    let v71: any;
    closure7(v2_1, `${" }"}`, undefined);
    v71 = undefined;
    return v2_1.l0;
}

export function method41(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: any): string {
    const v9: string = method42(v8);
    return method17(`${v6} ${v7} #${v0_1.l0} ${"runtime.execute_with_options_async / WaitForExitAsync"} / ${v9}`);
}

export function closure25(v0_1: any, unitVar: void): void {
    if (method6(US0_US0_3())) {
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
        method18(method41(v19_1, v20_1, v21, v22, v23, v24, method7(v19_1, v20_1, v21, v22, v23, v24), method11(), v0_1));
    }
}

export function method44(v0_1: int32, v1_1: int32): string {
    const v3: Mut3 = new Mut3(method13());
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

export function method43(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: Option<int64>, v6: string, v7: string, v8: int32, v9: int32): string {
    const v10: string = method44(v8, v9);
    return method17(`${v6} ${v7} #${v0_1.l0} ${"runtime.execute_with_options_async"} / ${v10}`);
}

export function closure26(v0_1: int32, v1_1: string, unitVar: void): void {
    if (method6(US0_US0_1())) {
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
        method18(method43(v20_1, v21, v22, v23, v24, v25, method7(v20_1, v21, v22, v23, v24, v25), method34(), v0_1, v1_1.length));
    }
}

export function method21(v0_1: string, v1_1: Option<any>, v2_1: [string, string][], v3: Option<((arg0: [int32, string, boolean]) => any)>, v4: Option<((arg0: any) => void)>, v5: boolean, v6: Option<string>): any {
    return defaultOf();
}

export function closure13(unitVar: void, v0_1: string): any {
    return method21(v0_1, undefined, [], undefined, undefined, true, undefined);
}

export function closure27(unitVar: void, _arg: [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>]): any {
    return method21(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6]);
}

export function closure28(unitVar: void, v0_1: ((arg0: Heap0) => Heap0)): [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>] {
    const v8: Heap0 = v0_1(new Heap0("", undefined, [], undefined, undefined, true, undefined));
    return [v8.l0, v8.l1, v8.l2, v8.l3, v8.l4, v8.l5, v8.l6] as [string, Option<any>, [string, string][], Option<((arg0: [int32, string, boolean]) => any)>, Option<((arg0: any) => void)>, boolean, Option<string>];
}

export function method47(v0_1_mut: string, v1_1_mut: int64): boolean {
    method47:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int64 = v1_1_mut;
        if (compare_1(v1_1, 4n) >= 0) {
            return false;
        }
        else {
            let v19_1: US7_$union;
            if (equals(v1_1, 0n)) {
                v19_1 = US7_US7_0("\\");
            }
            else {
                const v5: int64 = toInt64(op_Subtraction(v1_1, 1n));
                if (equals(v5, 0n)) {
                    v19_1 = US7_US7_0("`");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5, 1n));
                    if (equals(v8, 0n)) {
                        v19_1 = US7_US7_0("\"");
                    }
                    else {
                        const v11: int64 = toInt64(op_Subtraction(v8, 1n));
                        if (equals(v11, 0n)) {
                            v19_1 = US7_US7_0(" ");
                        }
                        else {
                            const v14: int64 = toInt64(op_Subtraction(v11, 1n));
                            v19_1 = US7_US7_1();
                        }
                    }
                }
            }
            if (v0_1 === ((v19_1.tag === /* US7_0 */ 0) ? v19_1.fields[0] : (() => {
                throw new Error("Option does not have a value.");
            })())) {
                return true;
            }
            else {
                v0_1_mut = v0_1;
                v1_1_mut = toInt64(op_Addition(v1_1, 1n));
                continue method47;
            }
        }
        break;
    }
}

export function method48(v0_1_mut: string, v1_1_mut: string, v2_1_mut: any, v3_mut: int32, v4_mut: int32): US6_$union {
    method48:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3: int32 = v3_mut, v4: int32 = v4_mut;
        let v82: US5_$union;
        if ("" === v1_1) {
            v82 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\"", " "], [v2_1, v3, v4] as [any, int32, int32]])));
        }
        else {
            const v25: string = v1_1[0];
            const v29 = 1;
            const v31: int32 = v1_1.length | 0;
            const v32: string = v1_1.slice(v29, v31 + 1);
            if (method47(v25, 0n) === false) {
                const v37: string = v25;
                const v40: int32 = v37.length | 0;
                const v41: string[] = fill(new Array(v40), 0, v40, "");
                const v42: Mut5 = new Mut5(0);
                while (method23(v40, v42)) {
                    const v44: int32 = v42.l0 | 0;
                    const v45: string = v37[v44];
                    setItem(v41, v44, v45);
                    const v46: int32 = (v44 + 1) | 0;
                    v42.l0 = (v46 | 0);
                }
                const v47: FSharpList<string> = ofArray<string>(v41);
                const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v47, UH0_UH0_0()), v2_1, v3, v4);
                v82 = US5_US5_0(v25, v32, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v82 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v25, ["\\", "`", "\"", " "], [v2_1, v3, v4] as [any, int32, int32]])));
            }
        }
        if (v82.tag === /* US5_0 */ 0) {
            v0_1_mut = (v0_1 + v82.fields[0]);
            v1_1_mut = v82.fields[1];
            v2_1_mut = v82.fields[2];
            v3_mut = v82.fields[3];
            v4_mut = v82.fields[4];
            continue method48;
        }
        else {
            const v94: string = v82.fields[0];
            return US6_US6_0(v0_1, v1_1, v2_1, v3, v4);
        }
        break;
    }
}

export function method50(v0_1_mut: string, v1_1_mut: int64): boolean {
    method50:
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
                const v5: int64 = toInt64(op_Subtraction(v1_1, 1n));
                if (equals(v5, 0n)) {
                    v15 = US7_US7_0("`");
                }
                else {
                    const v8: int64 = toInt64(op_Subtraction(v5, 1n));
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
                continue method50;
            }
        }
        break;
    }
}

export function closure30(unitVar: void, _arg: [string, any, int32, int32]): US6_$union {
    const v3: int32 = _arg[3] | 0;
    const v2_1: int32 = _arg[2] | 0;
    const v1_1: any = _arg[1];
    const v0_1: string = _arg[0];
    let v67: US5_$union;
    if ("" === v0_1) {
        v67 = US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v1_1, v2_1, v3] as [any, int32, int32]])));
    }
    else {
        const v7: string = v0_1[0];
        if (v7 === "\\") {
            const v12 = 1;
            const v14: int32 = v0_1.length | 0;
            const v15: string = v0_1.slice(v12, v14 + 1);
            const v17_1: string = v7;
            const v20_1: int32 = v17_1.length | 0;
            const v21: string[] = fill(new Array(v20_1), 0, v20_1, "");
            const v22: Mut5 = new Mut5(0);
            while (method23(v20_1, v22)) {
                const v24: int32 = v22.l0 | 0;
                const v25: string = v17_1[v24];
                setItem(v21, v24, v25);
                const v26: int32 = (v24 + 1) | 0;
                v22.l0 = (v26 | 0);
            }
            const v27: FSharpList<string> = ofArray<string>(v21);
            const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v27, UH0_UH0_0()), v1_1, v2_1, v3);
            v67 = US5_US5_0(v7, v15, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v43: int32 = v0_1.length | 0;
            const v46: int32 = (v0_1.indexOf("\n") - 1) | 0;
            const v50 = 0;
            const v52: int32 = ((-2 === v46) ? v43 : v46) | 0;
            v67 = US5_US5_1(`${`parsing.p_char / expected: '${"\\"}' / line: ${v2_1} / col: ${v3}
${v1_1}${v0_1.slice(v50, v52 + 1)}`}
${replicate(v3 - 1, " ") + "^"}
`);
        }
    }
    let v114: US5_$union;
    if (v67.tag === /* US5_0 */ 0) {
        const v72: int32 = v67.fields[4] | 0;
        const v71: int32 = v67.fields[3] | 0;
        const v70: any = v67.fields[2];
        const v69: string = v67.fields[1];
        const v68: string = v67.fields[0];
        if ("" === v69) {
            v114 = US5_US5_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v70, v71, v72] as [any, int32, int32]])));
        }
        else {
            const v76: string = v69[0];
            const v80 = 1;
            const v82: int32 = v69.length | 0;
            const v83: string = v69.slice(v80, v82 + 1);
            const v85: string = v76;
            const v88: int32 = v85.length | 0;
            const v89: string[] = fill(new Array(v88), 0, v88, "");
            const v90: Mut5 = new Mut5(0);
            while (method23(v88, v90)) {
                const v92: int32 = v90.l0 | 0;
                const v93: string = v85[v92];
                setItem(v89, v92, v93);
                const v94: int32 = (v92 + 1) | 0;
                v90.l0 = (v94 | 0);
            }
            const v95: FSharpList<string> = ofArray<string>(v89);
            const patternInput_1: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v95, UH0_UH0_0()), v70, v71, v72);
            v114 = US5_US5_0(v76, v83, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
        }
    }
    else {
        v114 = US5_US5_1(v67.fields[0]);
    }
    if (v114.tag === /* US5_0 */ 0) {
        return US6_US6_0(`${"\\"}${v114.fields[0]}`, v114.fields[1], v114.fields[2], v114.fields[3], v114.fields[4]);
    }
    else {
        return US6_US6_1(v114.fields[0]);
    }
}

export function closure31(unitVar: void, _arg: [string, any, int32, int32]): US6_$union {
    const v3: int32 = _arg[3] | 0;
    const v2_1: int32 = _arg[2] | 0;
    const v1_1: any = _arg[1];
    const v0_1: string = _arg[0];
    let v67: US5_$union;
    if ("" === v0_1) {
        v67 = US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v1_1, v2_1, v3] as [any, int32, int32]])));
    }
    else {
        const v7: string = v0_1[0];
        if (v7 === "`") {
            const v12 = 1;
            const v14: int32 = v0_1.length | 0;
            const v15: string = v0_1.slice(v12, v14 + 1);
            const v17_1: string = v7;
            const v20_1: int32 = v17_1.length | 0;
            const v21: string[] = fill(new Array(v20_1), 0, v20_1, "");
            const v22: Mut5 = new Mut5(0);
            while (method23(v20_1, v22)) {
                const v24: int32 = v22.l0 | 0;
                const v25: string = v17_1[v24];
                setItem(v21, v24, v25);
                const v26: int32 = (v24 + 1) | 0;
                v22.l0 = (v26 | 0);
            }
            const v27: FSharpList<string> = ofArray<string>(v21);
            const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v27, UH0_UH0_0()), v1_1, v2_1, v3);
            v67 = US5_US5_0(v7, v15, patternInput[0], patternInput[1], patternInput[2]);
        }
        else {
            const v43: int32 = v0_1.length | 0;
            const v46: int32 = (v0_1.indexOf("\n") - 1) | 0;
            const v50 = 0;
            const v52: int32 = ((-2 === v46) ? v43 : v46) | 0;
            v67 = US5_US5_1(`${`parsing.p_char / expected: '${"`"}' / line: ${v2_1} / col: ${v3}
${v1_1}${v0_1.slice(v50, v52 + 1)}`}
${replicate(v3 - 1, " ") + "^"}
`);
        }
    }
    let v114: US5_$union;
    if (v67.tag === /* US5_0 */ 0) {
        const v72: int32 = v67.fields[4] | 0;
        const v71: int32 = v67.fields[3] | 0;
        const v70: any = v67.fields[2];
        const v69: string = v67.fields[1];
        const v68: string = v67.fields[0];
        if ("" === v69) {
            v114 = US5_US5_1(toText(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [[v70, v71, v72] as [any, int32, int32]])));
        }
        else {
            const v76: string = v69[0];
            const v80 = 1;
            const v82: int32 = v69.length | 0;
            const v83: string = v69.slice(v80, v82 + 1);
            const v85: string = v76;
            const v88: int32 = v85.length | 0;
            const v89: string[] = fill(new Array(v88), 0, v88, "");
            const v90: Mut5 = new Mut5(0);
            while (method23(v88, v90)) {
                const v92: int32 = v90.l0 | 0;
                const v93: string = v85[v92];
                setItem(v89, v92, v93);
                const v94: int32 = (v92 + 1) | 0;
                v90.l0 = (v94 | 0);
            }
            const v95: FSharpList<string> = ofArray<string>(v89);
            const patternInput_1: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v95, UH0_UH0_0()), v70, v71, v72);
            v114 = US5_US5_0(v76, v83, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
        }
    }
    else {
        v114 = US5_US5_1(v67.fields[0]);
    }
    if (v114.tag === /* US5_0 */ 0) {
        return US6_US6_0(`${"`"}${v114.fields[0]}`, v114.fields[1], v114.fields[2], v114.fields[3], v114.fields[4]);
    }
    else {
        return US6_US6_1(v114.fields[0]);
    }
}

export function method51(v0_1_mut: string, v1_1_mut: any, v2_1_mut: int32, v3_mut: int32, v4_mut: UH3_$union): US6_$union {
    method51:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: any = v1_1_mut, v2_1: int32 = v2_1_mut, v3: int32 = v3_mut, v4: UH3_$union = v4_mut;
        if (v4.tag === /* UH3_0 */ 0) {
            return US6_US6_1("choice / no parsers succeeded");
        }
        else {
            const v8: UH3_$union = v4.fields[1];
            const v9: US6_$union = v4.fields[0]([v0_1, v1_1, v2_1, v3] as [string, any, int32, int32]);
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
                v3_mut = v3;
                v4_mut = v8;
                continue method51;
            }
        }
        break;
    }
}

export function method52(v0_1_mut: UH2_$union, v1_1_mut: UH2_$union): UH2_$union {
    method52:
    while (true) {
        const v0_1: UH2_$union = v0_1_mut, v1_1: UH2_$union = v1_1_mut;
        if (v0_1.tag === /* UH2_0 */ 0) {
            return v1_1;
        }
        else {
            v0_1_mut = v0_1.fields[1];
            v1_1_mut = UH2_UH2_1(v0_1.fields[0], v1_1);
            continue method52;
        }
        break;
    }
}

export function method49(v0_1_mut: UH2_$union, v1_1_mut: string, v2_1_mut: any, v3_mut: int32, v4_mut: int32): US15_$union {
    method49:
    while (true) {
        const v0_1: UH2_$union = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3: int32 = v3_mut, v4: int32 = v4_mut;
        let v76: US5_$union;
        if ("" === v1_1) {
            v76 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\""], [v2_1, v3, v4] as [any, int32, int32]])));
        }
        else {
            const v22: string = v1_1[0];
            const v26 = 1;
            const v28: int32 = v1_1.length | 0;
            const v29: string = v1_1.slice(v26, v28 + 1);
            if (method50(v22, 0n) === false) {
                const v34: string = v22;
                const v37: int32 = v34.length | 0;
                const v38: string[] = fill(new Array(v37), 0, v37, "");
                const v39: Mut5 = new Mut5(0);
                while (method23(v37, v39)) {
                    const v41: int32 = v39.l0 | 0;
                    const v42: string = v34[v41];
                    setItem(v38, v41, v42);
                    const v43: int32 = (v41 + 1) | 0;
                    v39.l0 = (v43 | 0);
                }
                const v44: FSharpList<string> = ofArray<string>(v38);
                const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v44, UH0_UH0_0()), v2_1, v3, v4);
                v76 = US5_US5_0(v22, v29, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v76 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v22, ["\\", "`", "\""], [v2_1, v3, v4] as [any, int32, int32]])));
            }
        }
        const v90: US6_$union = (v76.tag === /* US5_0 */ 0) ? US6_US6_0(v76.fields[0], v76.fields[1], v76.fields[2], v76.fields[3], v76.fields[4]) : US6_US6_1(v76.fields[0]);
        let v104: US6_$union;
        if (v90.tag === /* US6_0 */ 0) {
            const v95: int32 = v90.fields[4] | 0;
            const v94: int32 = v90.fields[3] | 0;
            const v93: any = v90.fields[2];
            const v92: string = v90.fields[1];
            const v91: string = v90.fields[0];
            v104 = v90;
        }
        else {
            const v96: string = v90.fields[0];
            v104 = method51(v1_1, v2_1, v3, v4, UH3_UH3_1((arg10$0040: [string, any, int32, int32]): US6_$union => closure30(undefined, arg10$0040), UH3_UH3_1((arg10$0040_1: [string, any, int32, int32]): US6_$union => closure31(undefined, arg10$0040_1), UH3_UH3_0())));
        }
        if (v104.tag === /* US6_0 */ 0) {
            v0_1_mut = UH2_UH2_1(v104.fields[0], v0_1);
            v1_1_mut = v104.fields[1];
            v2_1_mut = v104.fields[2];
            v3_mut = v104.fields[3];
            v4_mut = v104.fields[4];
            continue method49;
        }
        else {
            const v112: string = v104.fields[0];
            return US15_US15_0(method52(v0_1, UH2_UH2_0()), v1_1, v2_1, v3, v4);
        }
        break;
    }
}

export function method53(v0_1: UH2_$union, v1_1: FSharpList<string>): FSharpList<string> {
    if (v0_1.tag === /* UH2_0 */ 0) {
        return v1_1;
    }
    else {
        return cons(v0_1.fields[0], method53(v0_1.fields[1], v1_1));
    }
}

export function method54(v0_1_mut: UH2_$union, v1_1_mut: string, v2_1_mut: any, v3_mut: int32, v4_mut: int32): US15_$union {
    method54:
    while (true) {
        const v0_1: UH2_$union = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3: int32 = v3_mut, v4: int32 = v4_mut;
        let v76: US5_$union;
        if ("" === v1_1) {
            v76 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\""], [v2_1, v3, v4] as [any, int32, int32]])));
        }
        else {
            const v22: string = v1_1[0];
            const v26 = 1;
            const v28: int32 = v1_1.length | 0;
            const v29: string = v1_1.slice(v26, v28 + 1);
            if (method50(v22, 0n) === false) {
                const v34: string = v22;
                const v37: int32 = v34.length | 0;
                const v38: string[] = fill(new Array(v37), 0, v37, "");
                const v39: Mut5 = new Mut5(0);
                while (method23(v37, v39)) {
                    const v41: int32 = v39.l0 | 0;
                    const v42: string = v34[v41];
                    setItem(v38, v41, v42);
                    const v43: int32 = (v41 + 1) | 0;
                    v39.l0 = (v43 | 0);
                }
                const v44: FSharpList<string> = ofArray<string>(v38);
                const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v44, UH0_UH0_0()), v2_1, v3, v4);
                v76 = US5_US5_0(v22, v29, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v76 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v22, ["\\", "`", "\""], [v2_1, v3, v4] as [any, int32, int32]])));
            }
        }
        const v90: US6_$union = (v76.tag === /* US5_0 */ 0) ? US6_US6_0(v76.fields[0], v76.fields[1], v76.fields[2], v76.fields[3], v76.fields[4]) : US6_US6_1(v76.fields[0]);
        if (v90.tag === /* US6_0 */ 0) {
            v0_1_mut = UH2_UH2_1(v90.fields[0], v0_1);
            v1_1_mut = v90.fields[1];
            v2_1_mut = v90.fields[2];
            v3_mut = v90.fields[3];
            v4_mut = v90.fields[4];
            continue method54;
        }
        else {
            const v98: string = v90.fields[0];
            return US15_US15_0(method52(v0_1, UH2_UH2_0()), v1_1, v2_1, v3, v4);
        }
        break;
    }
}

export function method55(v0_1_mut: string, v1_1_mut: int32): int32 {
    method55:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: int32 = v1_1_mut;
        if (v1_1 >= v0_1.length) {
            return v1_1 | 0;
        }
        else if (v0_1[v1_1] === " ") {
            v0_1_mut = v0_1;
            v1_1_mut = (v1_1 + 1);
            continue method55;
        }
        else {
            return v1_1 | 0;
        }
        break;
    }
}

export function method46(v0_1_mut: UH2_$union, v1_1_mut: string, v2_1_mut: any, v3_mut: int32, v4_mut: int32): US15_$union {
    method46:
    while (true) {
        const v0_1: UH2_$union = v0_1_mut, v1_1: string = v1_1_mut, v2_1: any = v2_1_mut, v3: int32 = v3_mut, v4: int32 = v4_mut;
        const v5: boolean = "" === v1_1;
        let v82: US5_$union;
        if (v5) {
            v82 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [["\\", "`", "\"", " "], [v2_1, v3, v4] as [any, int32, int32]])));
        }
        else {
            const v25: string = v1_1[0];
            const v29 = 1;
            const v31: int32 = v1_1.length | 0;
            const v32: string = v1_1.slice(v29, v31 + 1);
            if (method47(v25, 0n) === false) {
                const v37: string = v25;
                const v40: int32 = v37.length | 0;
                const v41: string[] = fill(new Array(v40), 0, v40, "");
                const v42: Mut5 = new Mut5(0);
                while (method23(v40, v42)) {
                    const v44: int32 = v42.l0 | 0;
                    const v45: string = v37[v44];
                    setItem(v41, v44, v45);
                    const v46: int32 = (v44 + 1) | 0;
                    v42.l0 = (v46 | 0);
                }
                const v47: FSharpList<string> = ofArray<string>(v41);
                const patternInput: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v47, UH0_UH0_0()), v2_1, v3, v4);
                v82 = US5_US5_0(v25, v32, patternInput[0], patternInput[1], patternInput[2]);
            }
            else {
                v82 = US5_US5_1(toText(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v25, ["\\", "`", "\"", " "], [v2_1, v3, v4] as [any, int32, int32]])));
            }
        }
        const v96: US6_$union = (v82.tag === /* US5_0 */ 0) ? method48(v82.fields[0], v82.fields[1], v82.fields[2], v82.fields[3], v82.fields[4]) : US6_US6_1(v82.fields[0]);
        let v341: US6_$union;
        if (v96.tag === /* US6_0 */ 0) {
            const v99: any = v96.fields[2];
            const v98: string = v96.fields[1];
            const v97: string = v96.fields[0];
            const v101: int32 = v96.fields[4] | 0;
            const v100: int32 = v96.fields[3] | 0;
            v341 = v96;
        }
        else {
            const v102: string = v96.fields[0];
            let v165: US5_$union;
            if (v5) {
                v165 = US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v2_1, v3, v4] as [any, int32, int32]])));
            }
            else {
                const v105: string = v1_1[0];
                if (v105 === "\"") {
                    const v110 = 1;
                    const v112: int32 = v1_1.length | 0;
                    const v113: string = v1_1.slice(v110, v112 + 1);
                    const v115: string = v105;
                    const v118: int32 = v115.length | 0;
                    const v119: string[] = fill(new Array(v118), 0, v118, "");
                    const v120: Mut5 = new Mut5(0);
                    while (method23(v118, v120)) {
                        const v122: int32 = v120.l0 | 0;
                        const v123: string = v115[v122];
                        setItem(v119, v122, v123);
                        const v124: int32 = (v122 + 1) | 0;
                        v120.l0 = (v124 | 0);
                    }
                    const v125: FSharpList<string> = ofArray<string>(v119);
                    const patternInput_1: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v125, UH0_UH0_0()), v2_1, v3, v4);
                    v165 = US5_US5_0(v105, v113, patternInput_1[0], patternInput_1[1], patternInput_1[2]);
                }
                else {
                    const v141: int32 = v1_1.length | 0;
                    const v144: int32 = (v1_1.indexOf("\n") - 1) | 0;
                    const v148 = 0;
                    const v150: int32 = ((-2 === v144) ? v141 : v144) | 0;
                    v165 = US5_US5_1(`${`parsing.p_char / expected: '${"\""}' / line: ${v3} / col: ${v4}
${v2_1}${v1_1.slice(v148, v150 + 1)}`}
${replicate(v4 - 1, " ") + "^"}
`);
                }
            }
            let v282: US6_$union;
            if (v165.tag === /* US5_0 */ 0) {
                const v170: int32 = v165.fields[4] | 0;
                const v169: int32 = v165.fields[3] | 0;
                const v168: any = v165.fields[2];
                const v167: string = v165.fields[1];
                const v166: string = v165.fields[0];
                const v172: US15_$union = method49(UH2_UH2_0(), v167, v168, v169, v170);
                let v193: US6_$union;
                if (v172.tag === /* US15_0 */ 0) {
                    const v177: int32 = v172.fields[4] | 0;
                    const v176: int32 = v172.fields[3] | 0;
                    const v175: any = v172.fields[2];
                    const v174: string = v172.fields[1];
                    const v179: FSharpList<string> = method53(v172.fields[0], empty<string>());
                    v193 = US6_US6_0(join("", delay<string>((): Iterable<string> => map_1<int32, string>((i: int32): string => item(i, v179), rangeDouble(0, 1, length(v179) - 1)))), v174, v175, v176, v177);
                }
                else {
                    v193 = US6_US6_1(v172.fields[0]);
                }
                if (v193.tag === /* US6_0 */ 0) {
                    const v198: int32 = v193.fields[4] | 0;
                    const v197: int32 = v193.fields[3] | 0;
                    const v196: any = v193.fields[2];
                    const v195: string = v193.fields[1];
                    const v194: string = v193.fields[0];
                    let v262: US5_$union;
                    if ("" === v195) {
                        v262 = US5_US5_1(toText(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [[v196, v197, v198] as [any, int32, int32]])));
                    }
                    else {
                        const v202: string = v195[0];
                        if (v202 === "\"") {
                            const v207 = 1;
                            const v209: int32 = v195.length | 0;
                            const v210: string = v195.slice(v207, v209 + 1);
                            const v212: string = v202;
                            const v215: int32 = v212.length | 0;
                            const v216: string[] = fill(new Array(v215), 0, v215, "");
                            const v217: Mut5 = new Mut5(0);
                            while (method23(v215, v217)) {
                                const v219: int32 = v217.l0 | 0;
                                const v220: string = v212[v219];
                                setItem(v216, v219, v220);
                                const v221: int32 = (v219 + 1) | 0;
                                v217.l0 = (v221 | 0);
                            }
                            const v222: FSharpList<string> = ofArray<string>(v216);
                            const patternInput_2: [any, int32, int32] = method25(foldBack<string, UH0_$union>(uncurry2(method24()), v222, UH0_UH0_0()), v196, v197, v198);
                            v262 = US5_US5_0(v202, v210, patternInput_2[0], patternInput_2[1], patternInput_2[2]);
                        }
                        else {
                            const v238: int32 = v195.length | 0;
                            const v241: int32 = (v195.indexOf("\n") - 1) | 0;
                            const v245 = 0;
                            const v247: int32 = ((-2 === v241) ? v238 : v241) | 0;
                            v262 = US5_US5_1(`${`parsing.p_char / expected: '${"\""}' / line: ${v197} / col: ${v198}
${v196}${v195.slice(v245, v247 + 1)}`}
${replicate(v198 - 1, " ") + "^"}
`);
                        }
                    }
                    if (v262.tag === /* US5_0 */ 0) {
                        const v263: string = v262.fields[0];
                        v282 = US6_US6_0(v194, v262.fields[1], v262.fields[2], v262.fields[3], v262.fields[4]);
                    }
                    else {
                        v282 = US6_US6_1(toText(interpolate("between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v262.fields[0], [v1_1, v2_1, v3, v4] as [string, any, int32, int32], [v167, v168, v169, v170] as [string, any, int32, int32], [v195, v196, v197, v198] as [string, any, int32, int32]])));
                    }
                }
                else {
                    const v274: string = v193.fields[0];
                    v282 = US6_US6_1("between / expected content");
                }
            }
            else {
                v282 = US6_US6_1(v165.fields[0]);
            }
            if (v282.tag === /* US6_0 */ 0) {
                const v287: int32 = v282.fields[4] | 0;
                const v286: int32 = v282.fields[3] | 0;
                const v285: any = v282.fields[2];
                const v284: string = v282.fields[1];
                const v283: string = v282.fields[0];
                v341 = v282;
            }
            else {
                const v288: string = v282.fields[0];
                const v294: US6_$union = method51(v1_1, v2_1, v3, v4, UH3_UH3_1((arg10$0040: [string, any, int32, int32]): US6_$union => closure30(undefined, arg10$0040), UH3_UH3_1((arg10$0040_1: [string, any, int32, int32]): US6_$union => closure31(undefined, arg10$0040_1), UH3_UH3_0())));
                let v305: US6_$union;
                if (v294.tag === /* US6_0 */ 0) {
                    const v295: string = v294.fields[0];
                    v305 = US6_US6_0("", v294.fields[1], v294.fields[2], v294.fields[3], v294.fields[4]);
                }
                else {
                    v305 = US6_US6_1(v294.fields[0]);
                }
                let v316: US15_$union;
                if (v305.tag === /* US6_0 */ 0) {
                    const v306: string = v305.fields[0];
                    v316 = method54(UH2_UH2_0(), v305.fields[1], v305.fields[2], v305.fields[3], v305.fields[4]);
                }
                else {
                    v316 = US15_US15_1(v305.fields[0]);
                }
                if (v316.tag === /* US15_0 */ 0) {
                    const v321: int32 = v316.fields[4] | 0;
                    const v320: int32 = v316.fields[3] | 0;
                    const v319: any = v316.fields[2];
                    const v318: string = v316.fields[1];
                    const v323: FSharpList<string> = method53(v316.fields[0], empty<string>());
                    v341 = US6_US6_0(join("", delay<string>((): Iterable<string> => map_1<int32, string>((i_1: int32): string => item(i_1, v323), rangeDouble(0, 1, length(v323) - 1)))), v318, v319, v320, v321);
                }
                else {
                    v341 = US6_US6_1(v316.fields[0]);
                }
            }
        }
        if (v341.tag === /* US6_0 */ 0) {
            const v350: int32 = v341.fields[4] | 0;
            const v349: int32 = v341.fields[3] | 0;
            const v348: any = v341.fields[2];
            const v347: string = v341.fields[1];
            const v346: string = v341.fields[0];
            const v352: int32 = method55(v347, 0) | 0;
            let v364: US8_$union;
            if (0 === v352) {
                v364 = US8_US8_1("spaces1 / expected at least one space");
            }
            else {
                const v359: int32 = v352 | 0;
                const v361: int32 = v347.length | 0;
                v364 = US8_US8_0(v347.slice(v359, v361 + 1), v348, v349, v350);
            }
            if (v364.tag === /* US8_0 */ 0) {
                v0_1_mut = UH2_UH2_1(v346, v0_1);
                v1_1_mut = v364.fields[0];
                v2_1_mut = v364.fields[1];
                v3_mut = v364.fields[2];
                v4_mut = v364.fields[3];
                continue method46;
            }
            else {
                const v365: string = v364.fields[0];
                return US15_US15_0(method52(v0_1, UH2_UH2_1(v346, UH2_UH2_0())), v347, v348, v349, v350);
            }
        }
        else {
            const v342: string = v341.fields[0];
            return US15_US15_0(method52(v0_1, UH2_UH2_0()), v1_1, v2_1, v3, v4);
        }
        break;
    }
}

export function method45(v0_1: string): US14_$union {
    let _v0: Option<Option<string>> = undefined;
    _v0 = some(v0_1);
    const v15: US15_$union = method46(UH2_UH2_0(), defaultArg((_v0 == null) ? (() => {
        throw new Error("optionm\'.of_obj / _v0=None");
    })() : value_12(_v0), ""), StringBuilder_$ctor_Z721C83C5(""), 1, 1);
    if (v15.tag === /* US15_0 */ 0) {
        const v20_1: int32 = v15.fields[4] | 0;
        const v19_1: int32 = v15.fields[3] | 0;
        const v18_1: any = v15.fields[2];
        const v17_1: string = v15.fields[1];
        return US14_US14_0(toArray<string>(method53(v15.fields[0], empty<string>())));
    }
    else {
        return US14_US14_1(v15.fields[0]);
    }
}

export function closure29(unitVar: void, v0_1: string): FSharpResult$2_$union<string[], string> {
    const v1_1: US14_$union = method45(v0_1);
    if (v1_1.tag === /* US14_0 */ 0) {
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


