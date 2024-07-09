import { defaultOf, IDisposable } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { union_type, class_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { value as value_1, some, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";

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

export function closure1(v0: any, unitVar: void): void {
    let _v3: Option<void> = undefined;
    defaultOf();
    _v3 = some(undefined);
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        value_1(_v3);
    }
}

export function method0(v0: any): (() => void) {
    return (): void => {
        closure1(v0, undefined);
    };
}

export function method1(v0: any): (() => void) {
    return (): void => {
        closure1(v0, undefined);
    };
}

export function closure0(unitVar: void, v0: Option<any>): [any, IDisposable] {
    let _v3: Option<[any, IDisposable]> = undefined;
    const patternInput: [any, IDisposable] = defaultOf();
    _v3 = ([patternInput[0], patternInput[1]] as [any, IDisposable]);
    let patternInput_1: [any, IDisposable];
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        patternInput_1 = value_1(_v3);
    }
    return [patternInput_1[0], patternInput_1[1]] as [any, IDisposable];
}

export const v6 = (v: Option<any>): [any, IDisposable] => closure0(undefined, v);

export function new_disposable_token(x: Option<any>): [any, IDisposable] {
    return v6(x);
}


