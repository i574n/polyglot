import { FSharpRef, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { some, value as value_1, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { defaultOf, IDisposable } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";

export type US0_$union = 
    | US0<0>
    | US0<1>

export type US0_$cases = {
    0: ["US0_0", []],
    1: ["US0_1", []]
}

export function US0_US0_0() {
    return new US0<0>(0, []);
}

export function US0_US0_1() {
    return new US0<1>(1, []);
}

export class US0<Tag extends keyof US0_$cases> extends Union<Tag, US0_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US0_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US0_0", "US0_1"];
    }
}

export function US0_$reflection(): TypeInfo {
    return union_type("Common.US0", [], US0, () => [[], []]);
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
    return union_type("Common.US1", [], US1, () => [[["f0_0", US0_$reflection()]], []]);
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

export function closure0(unitVar: void, v0_1: (() => void)): IDisposable {
    let _v1: Option<IDisposable> = void 0;
    const x: IDisposable = defaultOf();
    _v1 = x;
    return value_1(_v1);
}

export function closure3(v0_1: int32, v1_1: (() => void), v2: int32, unitVar: void): US0_$union {
    if (v2 < v0_1) {
        v1_1();
        return US0_US0_0();
    }
    else {
        return US0_US0_1();
    }
}

export function closure4(unitVar: void, v0_1: US0_$union): US1_$union {
    return US1_US1_0(v0_1);
}

export function closure5(v0_1: int32, v1_1: Error): US1_$union {
    let _v2: Option<void> = void 0;
    _v2 = some(void 0);
    value_1(_v2);
    return US1_US1_1();
}

export function method0(v0_1_mut: int32, v1_1_mut: (() => void), v2_mut: int32): US0_$union {
    method0:
    while (true) {
        const v0_1: int32 = v0_1_mut, v1_1: (() => void) = v1_1_mut, v2: int32 = v2_mut;
        let v6: US1_$union;
        try {
            v6 = closure4(void 0, closure3(v0_1, v1_1, v2, void 0));
        }
        catch (ex: any) {
            v6 = closure5(v2, ex);
        }
        if (v6.tag === /* US1_0 */ 0) {
            return v6.fields[0];
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
    const v3: US0_$union = method0(v0_1, v1_1, 0);
    if (v3.tag === /* US0_0 */ 0) {
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


