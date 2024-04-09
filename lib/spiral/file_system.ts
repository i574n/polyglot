import { FSharpRef, Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { string_type, class_type, int64_type, union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { map, defaultArg, some, value as value_3, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { createAtom, IDisposable, defaultOf } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { interpolate, toText } from "../../deps/Fable/src/fable-library-ts/String.js";
import * as fs from "fs";
import * as path from "path";

export interface IFsExistsSync {
    existsSync(path: string): boolean
}

export interface IPathJoin {
    join(...paths: string[]): string
}

export interface IPathDirname {
    dirname(path: string): string
}

export type US1_$union = 
    | US1<0>
    | US1<1>
    | US1<2>

export type US1_$cases = {
    0: ["US1_0", []],
    1: ["US1_1", []],
    2: ["US1_2", []]
}

export function US1_US1_0() {
    return new US1<0>(0, []);
}

export function US1_US1_1() {
    return new US1<1>(1, []);
}

export function US1_US1_2() {
    return new US1<2>(2, []);
}

export class US1<Tag extends keyof US1_$cases> extends Union<Tag, US1_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US1_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US1_0", "US1_1", "US1_2"];
    }
}

export function US1_$reflection(): TypeInfo {
    return union_type("File_system.US1", [], US1, () => [[], [], []]);
}

export type US2_$union = 
    | US2<0>
    | US2<1>
    | US2<2>
    | US2<3>
    | US2<4>

export type US2_$cases = {
    0: ["US2_0", []],
    1: ["US2_1", []],
    2: ["US2_2", []],
    3: ["US2_3", []],
    4: ["US2_4", []]
}

export function US2_US2_0() {
    return new US2<0>(0, []);
}

export function US2_US2_1() {
    return new US2<1>(1, []);
}

export function US2_US2_2() {
    return new US2<2>(2, []);
}

export function US2_US2_3() {
    return new US2<3>(3, []);
}

export function US2_US2_4() {
    return new US2<4>(4, []);
}

export class US2<Tag extends keyof US2_$cases> extends Union<Tag, US2_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: US2_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["US2_0", "US2_1", "US2_2", "US2_3", "US2_4"];
    }
}

export function US2_$reflection(): TypeInfo {
    return union_type("File_system.US2", [], US2, () => [[], [], [], [], []]);
}

export type US0_$union = 
    | US0<0>
    | US0<1>

export type US0_$cases = {
    0: ["US0_0", [US1_$union, US2_$union]],
    1: ["US0_1", []]
}

export function US0_US0_0(f0_0: US1_$union, f0_1: US2_$union) {
    return new US0<0>(0, [f0_0, f0_1]);
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
    return union_type("File_system.US0", [], US0, () => [[["f0_0", US1_$reflection()], ["f0_1", US2_$reflection()]], []]);
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
    return union_type("File_system.US3", [], US3, () => [[["f0_0", int64_type]], []]);
}

export type US4_$union = 
    | US4<0>
    | US4<1>

export type US4_$cases = {
    0: ["US4_0", [int64]],
    1: ["US4_1", [Error]]
}

export function US4_US4_0(f0_0: int64) {
    return new US4<0>(0, [f0_0]);
}

export function US4_US4_1(f1_0: Error) {
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
    return union_type("File_system.US4", [], US4, () => [[["f0_0", int64_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US5_$union = 
    | US5<0>
    | US5<1>

export type US5_$cases = {
    0: ["US5_0", [int64]],
    1: ["US5_1", [Error]]
}

export function US5_US5_0(f0_0: int64) {
    return new US5<0>(0, [f0_0]);
}

export function US5_US5_1(f1_0: Error) {
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
    return union_type("File_system.US5", [], US5, () => [[["f0_0", int64_type]], [["f1_0", class_type("System.Exception")]]]);
}

export type US6_$union = 
    | US6<0>
    | US6<1>

export type US6_$cases = {
    0: ["US6_0", [string]],
    1: ["US6_1", []]
}

export function US6_US6_0(f0_0: string) {
    return new US6<0>(0, [f0_0]);
}

export function US6_US6_1() {
    return new US6<1>(1, []);
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
    return union_type("File_system.US6", [], US6, () => [[["f0_0", string_type]], []]);
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

export function US1__get_IsUS1_2(this$: FSharpRef<US1_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 2) {
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

export function US2__get_IsUS2_2(this$: FSharpRef<US2_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 2) {
        return true;
    }
    else {
        return false;
    }
}

export function US2__get_IsUS2_3(this$: FSharpRef<US2_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 3) {
        return true;
    }
    else {
        return false;
    }
}

export function US2__get_IsUS2_4(this$: FSharpRef<US2_$union>, unitArg: void): boolean {
    if ((this$ as any)['tag'] === 4) {
        return true;
    }
    else {
        return false;
    }
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

export function closure2(unitVar: void, v0_1: string): string {
    let _v1: Option<string> = void 0;
    const x: string = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function closure3(unitVar: void, unitVar_1: void): string {
    return "";
}

export function method1(v0_1: string, v1: string): string {
    return `path: ${closure2(void 0, v0_1)} / ex: ${v1} / ${closure3(void 0, void 0)}`;
}

export function closure1(v0_1: string, v1: string, unitVar: void): string {
    return method1(v0_1, v1);
}

export function method0(v0_1: string, v1: int64): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure0(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = void 0;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function method3(v0_1: string, v1: string): string {
    return `path: ${closure2(void 0, v0_1)} / ex: ${v1} / ${closure3(void 0, void 0)}`;
}

export function closure6(v0_1: string, v1: string, unitVar: void): string {
    return method3(v0_1, v1);
}

export function method2(v0_1: string, v1: US2_$union, v2: US1_$union, v3: int64): any {
    let _v4: Option<any> = void 0;
    const x: any = defaultOf();
    _v4 = x;
    return value_3(_v4);
}

export function closure5(v0_1: US0_$union, v1: string): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure4(unitVar: void, v0_1: US0_$union): ((arg0: string) => any) {
    return (v: string): any => closure5(v0_1, v);
}

export function method4(v0_1: string, v1: int64): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure7(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = void 0;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function closure8(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = void 0;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function method5(v0_1: string): string {
    return v0_1;
}

export function closure10(v0_1: string, v1: string): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure9(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure10(v0_1, v);
}

export function closure12(v0_1: string, v1: string): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure11(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure12(v0_1, v);
}

export function closure14(v0_1: string, v1: string): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure13(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure14(v0_1, v);
}

export function method6(v0_1: string, v1: int64): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure15(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = void 0;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function method8(v0_1: string, v1: string, v2: Error): string {
    let _v3: Option<string> = void 0;
    const x: string = toText(interpolate("%A%P()", [v2]));
    _v3 = x;
    const v9: string = value_3(_v3);
    const v10 = (v: string): string => closure2(void 0, v);
    return `old_path: ${v10(v1)} / new_path: ${v10(v0_1)} / ex: ${v9} / ${closure3(void 0, void 0)}`;
}

export function closure18(v0_1: string, v1: string, v2: Error, unitVar: void): string {
    return method8(v0_1, v1, v2);
}

export function method7(v0_1: string, v1: string, v2: int64): any {
    let _v3: Option<any> = void 0;
    const x: any = defaultOf();
    _v3 = x;
    return value_3(_v3);
}

export function closure17(v0_1: string, v1: string): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure16(unitVar: void, v0_1: string): ((arg0: string) => any) {
    return (v: string): any => closure17(v0_1, v);
}

export function closure20(unitVar: void, v0_1: int64): US4_$union {
    return US4_US4_0(v0_1);
}

export function closure21(unitVar: void, v0_1: Error): US4_$union {
    return US4_US4_1(v0_1);
}

export function closure22(unitVar: void, unitVar_1: void): string {
    return `timeout: ${1000} / ${closure3(void 0, void 0)}`;
}

export function method10(v0_1: int64, v1: string): string {
    return `retry: ${v0_1} / ex: ${v1} / ${closure3(void 0, void 0)}`;
}

export function closure23(v0_1: int64, v1: string, unitVar: void): string {
    return method10(v0_1, v1);
}

export function method9(v0_1: string, v1: int64): any {
    let _v2: Option<any> = void 0;
    const x: any = defaultOf();
    _v2 = x;
    return value_3(_v2);
}

export function closure19(unitVar: void, v0_1: string): any {
    let _v1: Option<any> = void 0;
    const x: any = defaultOf();
    _v1 = x;
    return value_3(_v1);
}

export function closure25(unitVar: void, unitVar_1: void): string {
    let _v0_1: Option<string> = void 0;
    const x: string = defaultOf();
    _v0_1 = x;
    return value_3(_v0_1);
}

export function closure24(unitVar: void, unitVar_1: void): string {
    let _v0_1: Option<string> = void 0;
    const x: string = defaultOf();
    _v0_1 = x;
    return value_3(_v0_1);
}

export function closure27(v0_1: string, v1: string, unitVar: void): string {
    return `temp_folder: ${v0_1} / result: ${v1} ${closure3(void 0, void 0)}`;
}

export function closure28(v0_1: string, unitVar: void): void {
    let _v1: Option<any> = void 0;
    const x: any = defaultOf();
    _v1 = x;
    const v8: any = value_3(_v1);
    let _v9: Option<any> = void 0;
    const x_1: any = defaultOf();
    _v9 = x_1;
    const v16: any = value_3(_v9);
    let _v17: Option<void> = void 0;
    defaultOf();
    _v17 = some(void 0);
    value_3(_v17);
}

export function closure26(unitVar: void, unitVar_1: void): [string, IDisposable] {
    let _v0_1: Option<[string, IDisposable]> = void 0;
    const patternInput: [string, IDisposable] = defaultOf();
    _v0_1 = ([patternInput[0], patternInput[1]] as [string, IDisposable]);
    const patternInput_1: [string, IDisposable] = value_3(_v0_1);
    return [patternInput_1[0], patternInput_1[1]] as [string, IDisposable];
}

export function closure29(unitVar: void, unitVar_1: void): string {
    return "C:\\home\\git\\polyglot\\lib\\spiral";
}

export function closure33(unitVar: void, v0_1: string): boolean {
    let _v1: Option<boolean> = void 0;
    const v19: IFsExistsSync = fs;
    const x: boolean = v19.existsSync(v0_1);
    _v1 = x;
    return value_3(_v1);
}

export function closure34(unitVar: void, v0_1: string): boolean {
    let _v1: Option<boolean> = void 0;
    const v19: IFsExistsSync = fs;
    const x: boolean = v19.existsSync(v0_1);
    _v1 = x;
    return value_3(_v1);
}

export function closure35(unitVar: void, v0_1: string): Option<string> {
    let _v1: Option<US6_$union> = void 0;
    const v35: IPathDirname = path;
    const x: US6_$union = US6_US6_0(v35.dirname(v0_1));
    _v1 = x;
    const v39: US6_$union = value_3(_v1);
    if (v39.tag === /* US6_0 */ 0) {
        return v39.fields[0];
    }
    else {
        return void 0;
    }
}

export function method12(): ((arg0: string) => Option<string>) {
    return (v: string): Option<string> => closure35(void 0, v);
}

export function closure36(unitVar: void, v0_1: string): US6_$union {
    return US6_US6_0(v0_1);
}

export function method13(): ((arg0: string) => US6_$union) {
    return (v: string): US6_$union => closure36(void 0, v);
}

export function method14(v0_1_mut: string, v1_mut: boolean, v2_mut: string, v3_mut: string): string {
    method14:
    while (true) {
        const v0_1: string = v0_1_mut, v1: boolean = v1_mut, v2: string = v2_mut, v3: string = v3_mut;
        let _v4: Option<string> = void 0;
        const v27: IPathJoin = path;
        const x: string = v27.join(v3, v0_1);
        _v4 = x;
        if ((v1 ? ((v: string): boolean => closure33(void 0, v)) : ((v_1: string): boolean => closure34(void 0, v_1)))(value_3(_v4))) {
            return v3;
        }
        else {
            const v36: Option<string> = method12()(v3);
            const v39: US6_$union = defaultArg(map<string, US6_$union>(method13(), v36), US6_US6_1());
            if (v39.tag === /* US6_0 */ 0) {
                v0_1_mut = v0_1;
                v1_mut = v1;
                v2_mut = v2;
                v3_mut = v39.fields[0];
                continue method14;
            }
            else {
                throw new Error(`No parent for ${v1 ? "file" : "dir"} '${v0_1}' at '${v2}'`);
            }
        }
        break;
    }
}

export function method11(v0_1: string, v1: boolean, v2: string): string {
    let _v3: Option<string> = void 0;
    const v26: IPathJoin = path;
    const x: string = v26.join(v2, v0_1);
    _v3 = x;
    if ((v1 ? ((v: string): boolean => closure33(void 0, v)) : ((v_1: string): boolean => closure34(void 0, v_1)))(value_3(_v3))) {
        return v2;
    }
    else {
        const v35: Option<string> = method12()(v2);
        const v38: US6_$union = defaultArg(map<string, US6_$union>(method13(), v35), US6_US6_1());
        if (v38.tag === /* US6_0 */ 0) {
            return method14(v0_1, v1, v2, v38.fields[0]);
        }
        else {
            throw new Error(`No parent for ${v1 ? "file" : "dir"} '${v0_1}' at '${v2}'`);
        }
    }
}

export function closure32(v0_1: string, v1: boolean, v2: string): string {
    return method11(v0_1, v1, v2);
}

export function closure31(v0_1: string, v1: boolean): ((arg0: string) => string) {
    return (v: string): string => closure32(v0_1, v1, v);
}

export function closure30(unitVar: void, v0_1: string): ((arg0: boolean) => ((arg0: string) => string)) {
    return (v: boolean): ((arg0: string) => string) => closure31(v0_1, v);
}

export function closure38(v0_1: string, v1: string): string {
    let _v2: Option<string> = void 0;
    const v25: IPathJoin = path;
    const x: string = v25.join(v0_1, v1);
    _v2 = x;
    return value_3(_v2);
}

export function closure37(unitVar: void, v0_1: string): ((arg0: string) => string) {
    return (v: string): string => closure38(v0_1, v);
}

export const v0: Option<void> = void 0;

export let _v0 = createAtom<Option<void>>(v0);

_v0(some(void 0));

value_3(_v0());

export const v11 = (): string => closure24(void 0, void 0);

export function create_temp_directory_name(): string {
    return v11();
}

export const v12 = (): [string, IDisposable] => closure26(void 0, void 0);

export function create_temp_directory(): [string, IDisposable] {
    return v12();
}

export const v13 = (): string => closure29(void 0, void 0);

export function get_source_directory(): string {
    return v13();
}

export const v14 = (v: string): ((arg0: boolean) => ((arg0: string) => string)) => closure30(void 0, v);

export function find_parent(x: string): ((arg0: boolean) => ((arg0: string) => string)) {
    return v14(x);
}

export const v15 = (v: string): ((arg0: string) => string) => closure37(void 0, v);

export function op_LessDivideGreater(x: string): ((arg0: string) => string) {
    return v15(x);
}


