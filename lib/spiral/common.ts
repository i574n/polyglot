import { FSharpRef, Union } from "../../fable_modules/fable-library-ts.4.14.0/Types.js";
import { union_type, TypeInfo } from "../../fable_modules/fable-library-ts.4.14.0/Reflection.js";
import { some, value, Option } from "../../fable_modules/fable-library-ts.4.14.0/Option.js";
import { IDisposable } from "../../fable_modules/fable-library-ts.4.14.0/Util.js";
import { int32 } from "../../fable_modules/fable-library-ts.4.14.0/Int32.js";

export type US0_$union = 
    | US0<0>
    | US0<1>
    | US0<2>
    | US0<3>

export type US0_$cases = {
    0: ["US0_0", []],
    1: ["US0_1", []],
    2: ["US0_2", []],
    3: ["US0_3", []]
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

export class US0<Tag extends keyof US0_$cases> extends Union<Tag, US0_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US0_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US0_0", "US0_1", "US0_2", "US0_3"];
    }
}

export function US0_$reflection(): TypeInfo {
    return union_type("Common.US0", [], US0, () => [[], [], [], []]);
}

export type US1_$union = 
    | US1<0>
    | US1<1>

export type US1_$cases = {
    0: ["US1_0", [US0_$union]],
    1: ["US1_1", [US0_$union]]
}

export function US1_US1_0(f0_0: US0_$union) {
    return new US1<0>(0, [f0_0]);
}

export function US1_US1_1(f1_0: US0_$union) {
    return new US1<1>(1, [f1_0]);
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
    return union_type("Common.US1", [], US1, () => [[["f0_0", US0_$reflection()]], [["f1_0", US0_$reflection()]]]);
}

export type US2_$union = 
    | US2<0>
    | US2<1>

export type US2_$cases = {
    0: ["US2_0", []],
    1: ["US2_1", []]
}

export function US2_US2_0() {
    return new US2<0>(0, []);
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
    return union_type("Common.US2", [], US2, () => [[], []]);
}

export type US3_$union = 
    | US3<0>
    | US3<1>

export type US3_$cases = {
    0: ["US3_0", [US2_$union]],
    1: ["US3_1", []]
}

export function US3_US3_0(f0_0: US2_$union) {
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
    return union_type("Common.US3", [], US3, () => [[["f0_0", US2_$reflection()]], []]);
}

export function US0__get_IsUS0_0(this$: FSharpRef<US0_$union>, unitArg: void): boolean {
    if (this$.tag === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US0__get_IsUS0_1(this$: FSharpRef<US0_$union>, unitArg: void): boolean {
    if (this$.tag === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US0__get_IsUS0_2(this$: FSharpRef<US0_$union>, unitArg: void): boolean {
    if (this$.tag === 2) {
        return true;
    }
    else {
        return false;
    }
}

export function US0__get_IsUS0_3(this$: FSharpRef<US0_$union>, unitArg: void): boolean {
    if (this$.tag === 3) {
        return true;
    }
    else {
        return false;
    }
}

export function US1__get_IsUS1_0(this$: FSharpRef<US1_$union>, unitArg: void): boolean {
    if (this$.tag === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US1__get_IsUS1_1(this$: FSharpRef<US1_$union>, unitArg: void): boolean {
    if (this$.tag === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US2__get_IsUS2_0(this$: FSharpRef<US2_$union>, unitArg: void): boolean {
    if (this$.tag === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US2__get_IsUS2_1(this$: FSharpRef<US2_$union>, unitArg: void): boolean {
    if (this$.tag === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function US3__get_IsUS3_0(this$: FSharpRef<US3_$union>, unitArg: void): boolean {
    if (this$.tag === 0) {
        return true;
    }
    else {
        return false;
    }
}

export function US3__get_IsUS3_1(this$: FSharpRef<US3_$union>, unitArg: void): boolean {
    if (this$.tag === 1) {
        return true;
    }
    else {
        return false;
    }
}

export function closure0(unitVar: void, v0_1: (() => void)): IDisposable {
    let _v1: Option<IDisposable> = void 0;
    const x: IDisposable = {
        Dispose(): void {
            v0_1();
        },
    };
    _v1 = x;
    return value(_v1);
}

export function closure3(v0_1: int32, v1_1: (() => void), v2: int32, unitVar: void): US2_$union {
    if (v2 < v0_1) {
        v1_1();
        return US2_US2_0();
    }
    else {
        return US2_US2_1();
    }
}

export function closure4(unitVar: void, v0_1: US2_$union): US3_$union {
    return US3_US3_0(v0_1);
}

export function closure5(unitVar: void, v0_1: Error): void {
    let _v1: Option<void> = void 0;
    _v1 = some(void 0);
    value(_v1);
}

export function method0(v0_1_mut: int32, v1_1_mut: (() => void), v2_mut: int32): US2_$union {
    method0:
    while (true) {
        const v0_1: int32 = v0_1_mut, v1_1: (() => void) = v1_1_mut, v2: int32 = v2_mut;
        let v7: US3_$union;
        try {
            v7 = closure4(void 0, closure3(v0_1, v1_1, v2, void 0));
        }
        catch (ex: any) {
            closure5(void 0, ex);
            v7 = US3_US3_1();
        }
        if (v7.tag === /* US3_0 */ 0) {
            return v7.fields[0];
        }
        else {
            v0_1_mut = v0_1;
            v1_1_mut = v1_1;
            v2_mut = (v2 + 1);
            continue method0;
        }
        break;
    }
}

export function closure2(v0_1: int32, v1_1: (() => void)): Option<void> {
    const v3: US2_$union = method0(v0_1, v1_1, 0);
    if (v3.tag === /* US2_0 */ 0) {
        return some(void 0);
    }
    else {
        return void 0;
    }
}

export function closure1(unitVar: void, v0_1: int32): ((arg0: (() => void)) => Option<void>) {
    return (v: (() => void)): Option<void> => closure2(v0_1, v);
}

export const v0 = (v: (() => void)): IDisposable => closure0(void 0, v);

export function new_disposable(x: (() => void)): IDisposable {
    return v0(x);
}

export const v1 = (v: int32): ((arg0: (() => void)) => Option<void>) => closure1(void 0, v);

export function retry_fn(x: int32): ((arg0: (() => void)) => Option<void>) {
    return v1(x);
}


