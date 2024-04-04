import { FSharpRef, Union } from "../../fable_modules/fable-library-ts.4.14.0/Types.js";
import { union_type, string_type, TypeInfo } from "../../fable_modules/fable-library-ts.4.14.0/Reflection.js";
import { map, defaultArg, value as value_1, Option } from "../../fable_modules/fable-library-ts.4.14.0/Option.js";
import { defaultOf } from "../../fable_modules/fable-library-ts.4.14.0/Util.js";

export type US0_$union = 
    | US0<0>
    | US0<1>

export type US0_$cases = {
    0: ["US0_0", [string]],
    1: ["US0_1", []]
}

export function US0_US0_0(f0_0: string) {
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
    return union_type("File_system.US0", [], US0, () => [[["f0_0", string_type]], []]);
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

export function method0(v0_1: string): string {
    return v0_1;
}

export function closure0(unitVar: void, unitVar_1: void): string {
    let _v0: Option<string> = void 0;
    const x: string = defaultOf();
    _v0 = x;
    return value_1(_v0);
}

export function closure3(unitVar: void, unitVar_1: void): string {
    return "";
}

export function closure2(v0_1: string, v1_1: string, unitVar: void): string {
    return `temp_folder: ${v0_1} / result: ${v1_1} ${closure3(void 0, void 0)}`;
}

export function closure1(unitVar: void, unitVar_1: void): string {
    let _v0: Option<string> = void 0;
    const x: string = defaultOf();
    _v0 = x;
    return value_1(_v0);
}

export function closure4(unitVar: void, unitVar_1: void): string {
    return "C:\\home\\git\\polyglot\\lib\\spiral";
}

export function closure8(unitVar: void, v0_1: string): boolean {
    let _v1: Option<boolean> = void 0;
    const x: boolean = defaultOf();
    _v1 = x;
    return value_1(_v1);
}

export function closure9(unitVar: void, v0_1: string): boolean {
    let _v1: Option<boolean> = void 0;
    const x: boolean = defaultOf();
    _v1 = x;
    return value_1(_v1);
}

export function closure10(unitVar: void, v0_1: string): Option<string> {
    let _v1: Option<US0_$union> = void 0;
    const x: US0_$union = defaultOf();
    _v1 = x;
    const v37: US0_$union = value_1(_v1);
    if (v37.tag === /* US0_0 */ 0) {
        return v37.fields[0];
    }
    else {
        return void 0;
    }
}

export function method2(): ((arg0: string) => Option<string>) {
    return (v: string): Option<string> => closure10(void 0, v);
}

export function closure11(unitVar: void, v0_1: string): US0_$union {
    return US0_US0_0(v0_1);
}

export function method3(): ((arg0: string) => US0_$union) {
    return (v: string): US0_$union => closure11(void 0, v);
}

export function method4(v0_1_mut: string, v1_1_mut: boolean, v2_1_mut: string, v3_1_mut: string): string {
    method4:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: boolean = v1_1_mut, v2_1: string = v2_1_mut, v3_1: string = v3_1_mut;
        let _v4: Option<string> = void 0;
        const x: string = defaultOf();
        _v4 = x;
        if ((v1_1 ? ((v: string): boolean => closure8(void 0, v)) : ((v_1: string): boolean => closure9(void 0, v_1)))(value_1(_v4))) {
            return v3_1;
        }
        else {
            const v34: Option<string> = method2()(v3_1);
            const v37: US0_$union = defaultArg(map<string, US0_$union>(method3(), v34), US0_US0_1());
            if (v37.tag === /* US0_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v37.fields[0];
                continue method4;
            }
            else {
                throw new Error(`No parent for ${v1_1 ? "file" : "dir"} '${v0_1}' at '${v2_1}'`);
            }
        }
        break;
    }
}

export function method1(v0_1: string, v1_1: boolean, v2_1: string): string {
    let _v3: Option<string> = void 0;
    const x: string = defaultOf();
    _v3 = x;
    if ((v1_1 ? ((v: string): boolean => closure8(void 0, v)) : ((v_1: string): boolean => closure9(void 0, v_1)))(value_1(_v3))) {
        return v2_1;
    }
    else {
        const v33: Option<string> = method2()(v2_1);
        const v36: US0_$union = defaultArg(map<string, US0_$union>(method3(), v33), US0_US0_1());
        if (v36.tag === /* US0_0 */ 0) {
            return method4(v0_1, v1_1, v2_1, v36.fields[0]);
        }
        else {
            throw new Error(`No parent for ${v1_1 ? "file" : "dir"} '${v0_1}' at '${v2_1}'`);
        }
    }
}

export function closure7(v0_1: string, v1_1: boolean, v2_1: string): string {
    return method1(v0_1, v1_1, v2_1);
}

export function closure6(v0_1: string, v1_1: boolean): ((arg0: string) => string) {
    return (v: string): string => closure7(v0_1, v1_1, v);
}

export function closure5(unitVar: void, v0_1: string): ((arg0: boolean) => ((arg0: string) => string)) {
    return (v: boolean): ((arg0: string) => string) => closure6(v0_1, v);
}

export function closure13(v0_1: string, v1_1: string): string {
    let _v2: Option<string> = void 0;
    const x: string = defaultOf();
    _v2 = x;
    return value_1(_v2);
}

export function closure12(unitVar: void, v0_1: string): ((arg0: string) => string) {
    return (v: string): string => closure13(v0_1, v);
}

export const v0 = (): string => closure0(void 0, void 0);

export function create_temp_directory_name(): string {
    return v0();
}

export const v1 = (): string => closure1(void 0, void 0);

export function create_temp_directory(): string {
    return v1();
}

export const v2 = (): string => closure4(void 0, void 0);

export function get_source_directory(): string {
    return v2();
}

export const v3 = (v: string): ((arg0: boolean) => ((arg0: string) => string)) => closure5(void 0, v);

export function find_parent(x: string): ((arg0: boolean) => ((arg0: string) => string)) {
    return v3(x);
}

export const v4 = (v: string): ((arg0: string) => string) => closure12(void 0, v);

export function op_LessDivideGreater(x: string): ((arg0: string) => string) {
    return v4(x);
}


