import { FSharpRef, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { union_type, string_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { map, defaultArg, value as value_1, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { defaultOf } from "../../deps/Fable/src/fable-library-ts/Util.js";
import * as fs from "fs";
import * as path from "path";

export interface IPathJoin {
    join(...paths: string[]): string
}

export interface IFsExistsSync {
    existsSync(path: string): boolean
}

export interface IPathDirname {
    dirname(path: string): string
}

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

export function closure1(unitVar: void, unitVar_1: void): string {
    let _v0: Option<string> = void 0;
    const x: string = defaultOf();
    _v0 = x;
    return value_1(_v0);
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

export function closure4(unitVar: void, unitVar_1: void): string {
    return "";
}

export function closure3(v0_1: string, v1_1: string, unitVar: void): string {
    return `temp_folder: ${v0_1} / result: ${v1_1} ${closure4(void 0, void 0)}`;
}

export function closure2(unitVar: void, unitVar_1: void): string {
    let _v0: Option<string> = void 0;
    const x: string = defaultOf();
    _v0 = x;
    return value_1(_v0);
}

export function closure5(unitVar: void, unitVar_1: void): string {
    return "C:\\home\\git\\polyglot\\lib\\spiral";
}

export function closure9(unitVar: void, v0_1: string): boolean {
    let _v1: Option<boolean> = void 0;
    const v19: IFsExistsSync = fs;
    const x: boolean = v19.existsSync(v0_1);
    _v1 = x;
    return value_1(_v1);
}

export function closure10(unitVar: void, v0_1: string): boolean {
    let _v1: Option<boolean> = void 0;
    const v19: IFsExistsSync = fs;
    const x: boolean = v19.existsSync(v0_1);
    _v1 = x;
    return value_1(_v1);
}

export function closure11(unitVar: void, v0_1: string): Option<string> {
    let _v1: Option<US0_$union> = void 0;
    const v35: IPathDirname = path;
    const x: US0_$union = US0_US0_0(v35.dirname(v0_1));
    _v1 = x;
    const v39: US0_$union = value_1(_v1);
    if (v39.tag === /* US0_0 */ 0) {
        return v39.fields[0];
    }
    else {
        return void 0;
    }
}

export function method2(): ((arg0: string) => Option<string>) {
    return (v: string): Option<string> => closure11(void 0, v);
}

export function closure12(unitVar: void, v0_1: string): US0_$union {
    return US0_US0_0(v0_1);
}

export function method3(): ((arg0: string) => US0_$union) {
    return (v: string): US0_$union => closure12(void 0, v);
}

export function method4(v0_1_mut: string, v1_1_mut: boolean, v2_1_mut: string, v3_1_mut: string): string {
    method4:
    while (true) {
        const v0_1: string = v0_1_mut, v1_1: boolean = v1_1_mut, v2_1: string = v2_1_mut, v3_1: string = v3_1_mut;
        let _v4: Option<string> = void 0;
        const v27: IPathJoin = path;
        const x: string = v27.join(v3_1, v0_1);
        _v4 = x;
        if ((v1_1 ? ((v: string): boolean => closure9(void 0, v)) : ((v_1: string): boolean => closure10(void 0, v_1)))(value_1(_v4))) {
            return v3_1;
        }
        else {
            const v36: Option<string> = method2()(v3_1);
            const v39: US0_$union = defaultArg(map<string, US0_$union>(method3(), v36), US0_US0_1());
            if (v39.tag === /* US0_0 */ 0) {
                v0_1_mut = v0_1;
                v1_1_mut = v1_1;
                v2_1_mut = v2_1;
                v3_1_mut = v39.fields[0];
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
    const v26: IPathJoin = path;
    const x: string = v26.join(v2_1, v0_1);
    _v3 = x;
    if ((v1_1 ? ((v: string): boolean => closure9(void 0, v)) : ((v_1: string): boolean => closure10(void 0, v_1)))(value_1(_v3))) {
        return v2_1;
    }
    else {
        const v35: Option<string> = method2()(v2_1);
        const v38: US0_$union = defaultArg(map<string, US0_$union>(method3(), v35), US0_US0_1());
        if (v38.tag === /* US0_0 */ 0) {
            return method4(v0_1, v1_1, v2_1, v38.fields[0]);
        }
        else {
            throw new Error(`No parent for ${v1_1 ? "file" : "dir"} '${v0_1}' at '${v2_1}'`);
        }
    }
}

export function closure8(v0_1: string, v1_1: boolean, v2_1: string): string {
    return method1(v0_1, v1_1, v2_1);
}

export function closure7(v0_1: string, v1_1: boolean): ((arg0: string) => string) {
    return (v: string): string => closure8(v0_1, v1_1, v);
}

export function closure6(unitVar: void, v0_1: string): ((arg0: boolean) => ((arg0: string) => string)) {
    return (v: boolean): ((arg0: string) => string) => closure7(v0_1, v);
}

export function closure14(v0_1: string, v1_1: string): string {
    let _v2: Option<string> = void 0;
    const v25: IPathJoin = path;
    const x: string = v25.join(v0_1, v1_1);
    _v2 = x;
    return value_1(_v2);
}

export function closure13(unitVar: void, v0_1: string): ((arg0: string) => string) {
    return (v: string): string => closure14(v0_1, v);
}

export const v0 = (): string => closure0(void 0, void 0);

export function create_temp_directory_name(): string {
    return v0();
}

export const v1 = (): string => closure2(void 0, void 0);

export function create_temp_directory(): string {
    return v1();
}

export const v2 = (): string => closure5(void 0, void 0);

export function get_source_directory(): string {
    return v2();
}

export const v3 = (v: string): ((arg0: boolean) => ((arg0: string) => string)) => closure6(void 0, v);

export function find_parent(x: string): ((arg0: boolean) => ((arg0: string) => string)) {
    return v3(x);
}

export const v4 = (v: string): ((arg0: string) => string) => closure13(void 0, v);

export function op_LessDivideGreater(x: string): ((arg0: string) => string) {
    return v4(x);
}


