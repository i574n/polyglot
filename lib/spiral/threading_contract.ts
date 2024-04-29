import { defaultOf, IDisposable } from "../../../polyglot/deps/Fable/src/fable-library-ts/Util.js";
import { union_type, class_type, TypeInfo } from "../../../polyglot/deps/Fable/src/fable-library-ts/Reflection.js";
import { FSharpRef, Union } from "../../../polyglot/deps/Fable/src/fable-library-ts/Types.js";
import { value as value_1, some, Option } from "../../../polyglot/deps/Fable/src/fable-library-ts/Option.js";

export class Disposable implements IDisposable {
    readonly f: (() => void);
    constructor(f: (() => void)) {
        this.f = f;
    }
    Dispose(): void {
        const _: Disposable = this;
        _.f();
    }
}

export function Disposable_$reflection(): TypeInfo {
    return class_type("Threading.Disposable", undefined, Disposable);
}

export function Disposable_$ctor_3A5B6456(f: (() => void)): Disposable {
    return new Disposable(f);
}

export type US0_$union = 
    | US0<0>
    | US0<1>

export type US0_$cases = {
    0: ["US0_0", [any]],
    1: ["US0_1", []]
}

export function US0_US0_0(f0_0: any) {
    return new US0<0>(0, [f0_0]);
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
    return union_type("Threading.US0", [], US0, () => [[["f0_0", class_type("System.Threading.CancellationToken")]], []]);
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

export function closure1(unitVar: void, v0_1: any): US0_$union {
    return US0_US0_0(v0_1);
}

export function method0(): ((arg0: any) => US0_$union) {
    return (v: any): US0_$union => closure1(undefined, v);
}

export function closure2(v0_1: any, unitVar: void): void {
    let _v1: Option<void> = undefined;
    defaultOf();
    _v1 = some(undefined);
    value_1(_v1);
}

export function method1(v0_1: any): (() => void) {
    return (): void => {
        closure2(v0_1, undefined);
    };
}

export function closure0(unitVar: void, v0_1: Option<any>): [any, IDisposable] {
    let _v1: Option<[any, IDisposable]> = undefined;
    const patternInput: [any, IDisposable] = defaultOf();
    _v1 = ([patternInput[0], patternInput[1]] as [any, IDisposable]);
    const patternInput_1: [any, IDisposable] = value_1(_v1);
    return [patternInput_1[0], patternInput_1[1]] as [any, IDisposable];
}

export const v0 = (v: Option<any>): [any, IDisposable] => closure0(undefined, v);

export function new_disposable_token(x: Option<any>): [any, IDisposable] {
    return v0(x);
}


