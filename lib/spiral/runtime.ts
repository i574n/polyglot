import { value as value_1, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { defaultOf } from "../../deps/Fable/src/fable-library-ts/Util.js";

export function closure0(unitVar: void, unitVar_1: void): boolean {
    let _v0: Option<boolean> = void 0;
    const x: boolean = defaultOf();
    _v0 = x;
    return value_1(_v0);
}

export function closure1(unitVar: void, unitVar_1: void): string {
    let _v0: Option<boolean> = void 0;
    const x: boolean = defaultOf();
    _v0 = x;
    if (value_1(_v0)) {
        return ".exe";
    }
    else {
        return "";
    }
}

export const v0 = (): boolean => closure0(void 0, void 0);

export function is_windows(): boolean {
    return v0();
}

export const v1 = (): string => closure1(void 0, void 0);

export function get_executable_suffix(): string {
    return v1();
}


