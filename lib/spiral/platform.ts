import { Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";

export type US0_$union = 
    | US0<0>
    | US0<1>
    | US0<2>

export type US0_$cases = {
    0: ["US0_0", []],
    1: ["US0_1", []],
    2: ["US0_2", []]
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

export class US0<Tag extends keyof US0_$cases> extends Union<Tag, US0_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US0_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US0_0", "US0_1", "US0_2"];
    }
}

export function US0_$reflection(): TypeInfo {
    return union_type("Platform.US0", [], US0, () => [[], [], []]);
}

export type US1_$union = 
    | US1<0>
    | US1<1>
    | US1<2>
    | US1<3>
    | US1<4>

export type US1_$cases = {
    0: ["US1_0", [US0_$union]],
    1: ["US1_1", [US0_$union]],
    2: ["US1_2", [US0_$union]],
    3: ["US1_3", [US0_$union]],
    4: ["US1_4", [US0_$union]]
}

export function US1_US1_0(f0_0: US0_$union) {
    return new US1<0>(0, [f0_0]);
}

export function US1_US1_1(f1_0: US0_$union) {
    return new US1<1>(1, [f1_0]);
}

export function US1_US1_2(f2_0: US0_$union) {
    return new US1<2>(2, [f2_0]);
}

export function US1_US1_3(f3_0: US0_$union) {
    return new US1<3>(3, [f3_0]);
}

export function US1_US1_4(f4_0: US0_$union) {
    return new US1<4>(4, [f4_0]);
}

export class US1<Tag extends keyof US1_$cases> extends Union<Tag, US1_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US1_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US1_0", "US1_1", "US1_2", "US1_3", "US1_4"];
    }
}

export function US1_$reflection(): TypeInfo {
    return union_type("Platform.US1", [], US1, () => [[["f0_0", US0_$reflection()]], [["f1_0", US0_$reflection()]], [["f2_0", US0_$reflection()]], [["f3_0", US0_$reflection()]], [["f4_0", US0_$reflection()]]]);
}

export function closure0(unitVar: void, unitVar_1: void): boolean {
    throw new Error(`platform.is_windows / target: ${US1_US1_3(US0_US0_0())}`);
}

export function closure1(unitVar: void, unitVar_1: void): string {
    if ((() => {
        throw new Error(`platform.is_windows / target: ${US1_US1_3(US0_US0_0())}`);
    })()) {
        return ".exe";
    }
    else {
        return "";
    }
}

export const v0 = (): boolean => closure0(undefined, undefined);

export function is_windows(): boolean {
    return v0();
}

export const v1 = (): string => closure1(undefined, undefined);

export function get_executable_suffix(): string {
    return v1();
}


