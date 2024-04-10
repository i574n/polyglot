import { US0_US0_4, US0_US0_3, US0_US0_2, US0_US0_1, US0_US0_0, US0_$union, trace, Mut2, Mut1, Mut0, get_trace_state } from "../../lib/spiral/trace.fsx";
import { Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { trim_end, trim_start, trim, to_lower, substring, starts_with, split_string, split, slice, replace, format_exception, ends_with, ellipsis_end, ellipsis, contains, concat } from "../../lib/spiral/sm.fsx";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { create_temp_directory_name, create_temp_directory, find_parent, get_source_directory } from "../../lib/spiral/file_system.fsx";
import { IDisposable } from "../../deps/Fable/src/fable-library-ts/Util.js";

export function SpiralTrace_get_trace_state(): [Mut0, Mut1, Mut1, Mut2, Option<int64>] {
    return get_trace_state();
}

export function SpiralTrace_trace(x: US0_$union): ((arg0: (() => string)) => ((arg0: (() => string)) => void)) {
    return trace(x);
}

export const SpiralTrace_US0_0: US0_$union = US0_US0_0();

export const SpiralTrace_US0_1: US0_$union = US0_US0_1();

export const SpiralTrace_US0_2: US0_$union = US0_US0_2();

export const SpiralTrace_US0_3: US0_$union = US0_US0_3();

export const SpiralTrace_US0_4: US0_$union = US0_US0_4();

export function SpiralSm_concat(x: string): ((arg0: Iterable<string>) => string) {
    return concat(x);
}

export function SpiralSm_contains(x: string): ((arg0: string) => boolean) {
    return contains(x);
}

export function SpiralSm_ellipsis(x: int32): ((arg0: string) => string) {
    return ellipsis(x);
}

export function SpiralSm_ellipsis_end(x: int64): ((arg0: string) => string) {
    return ellipsis_end(x);
}

export function SpiralSm_ends_with(x: string): ((arg0: string) => boolean) {
    return ends_with(x);
}

export function SpiralSm_format_exception(x: Error): string {
    return format_exception(x);
}

export function SpiralSm_replace(x: string): ((arg0: string) => ((arg0: string) => string)) {
    return replace(x);
}

export function SpiralSm_slice(x: int32): ((arg0: int32) => ((arg0: string) => string)) {
    return slice(x);
}

export function SpiralSm_split(x: string): ((arg0: string) => string[]) {
    return split(x);
}

export function SpiralSm_split_string(x: string[]): ((arg0: string) => string[]) {
    return split_string(x);
}

export function SpiralSm_starts_with(x: string): ((arg0: string) => boolean) {
    return starts_with(x);
}

export function SpiralSm_substring(x: int32): ((arg0: int32) => ((arg0: string) => string)) {
    return substring(x);
}

export function SpiralSm_to_lower(x: string): string {
    return to_lower(x);
}

export function SpiralSm_trim(x: string): string {
    return trim(x);
}

export function SpiralSm_trim_start(x: string[]): ((arg0: string) => string) {
    return trim_start(x);
}

export function SpiralSm_trim_end(x: string[]): ((arg0: string) => string) {
    return trim_end(x);
}

export function SpiralFileSystem_get_source_directory(): string {
    return get_source_directory();
}

export function SpiralFileSystem_find_parent(x: string): ((arg0: boolean) => ((arg0: string) => string)) {
    return find_parent(x);
}

export function SpiralFileSystem_create_temp_directory(): [string, IDisposable] {
    return create_temp_directory();
}

export function SpiralFileSystem_create_temp_directory_name(): string {
    return create_temp_directory_name();
}

