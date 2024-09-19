import { TraceState_trace_state as TraceState_trace_state_4, Mut4 as Mut4_4, Mut3 as Mut3_4, Mut2 as Mut2_4, Mut1 as Mut1_4, Mut0 as Mut0_4, US0_$union, trace } from "../../../../../polyglot/lib/spiral/trace.fsx";
import { hash_to_port, hash_text } from "../../../../../polyglot/lib/spiral/crypto.fsx";
import { int32, uint16 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { trim_end, trim_start, trim, to_lower, substring, starts_with, split_string, split, slice, replace_regex, replace, format_exception, ends_with, ellipsis_end, ellipsis, contains, concat } from "../../../../../polyglot/lib/spiral/sm.fsx";
import { int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { TraceState_trace_state as TraceState_trace_state_1, Mut4 as Mut4_1, Mut3 as Mut3_1, Mut2 as Mut2_1, Mut1 as Mut1_1, Mut0 as Mut0_1, US0_US0_0 as US0_US0_0_1, US0_US0_4 as US0_US0_4_1, US0_US0_3 as US0_US0_3_1, US0_US0_2 as US0_US0_2_1, US0_US0_1 as US0_US0_1_1, create_temp_path, create_temp_dir$0027, create_temp_dir, new_file_uri, normalize_path, get_source_directory, get_workspace_root } from "../../../../../polyglot/lib/spiral/file_system.fsx";
import { IDisposable } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { iterate } from "../../deps/Fable/src/fable-library-ts/Seq.js";
import { TraceState_trace_state, Mut4, Mut3, Mut2, Mut1, Mut0, US0_US0_0, US0_US0_4, US0_US0_3, US0_US0_2, US0_US0_1 } from "../../../../../polyglot/lib/spiral/networking.fsx";
import { map, defaultArgWith, toArray, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { TraceState_trace_state as TraceState_trace_state_2, Mut4 as Mut4_2, Mut3 as Mut3_2, Mut2 as Mut2_2, Mut1 as Mut1_2, Mut0 as Mut0_2, US0_US0_0 as US0_US0_0_2, US0_US0_4 as US0_US0_4_2, US0_US0_3 as US0_US0_3_2, US0_US0_2 as US0_US0_2_2, US0_US0_1 as US0_US0_1_2 } from "../../../../../polyglot/lib/spiral/runtime.fsx";
import { TraceState_trace_state as TraceState_trace_state_3, Mut4 as Mut4_3, Mut3 as Mut3_3, Mut2 as Mut2_3, Mut1 as Mut1_3, Mut0 as Mut0_3, US0_US0_0 as US0_US0_0_3, US0_US0_4 as US0_US0_4_3, US0_US0_3 as US0_US0_3_3, US0_US0_2 as US0_US0_2_3, US0_US0_1 as US0_US0_1_3 } from "../../../../../polyglot/lib/spiral/common.fsx";

export function SpiralTrace_trace(x: US0_$union): ((arg0: (() => string)) => ((arg0: (() => string)) => void)) {
    return trace(x);
}

export function SpiralCrypto_hash_text(x: string): string {
    return hash_text(x);
}

export function SpiralCrypto_hash_to_port(x: string): uint16 {
    return hash_to_port(x);
}

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

export function SpiralSm_replace_regex(x: string): ((arg0: string) => ((arg0: string) => string)) {
    return replace_regex(x);
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

export function SpiralFileSystem_get_workspace_root(): string {
    return get_workspace_root();
}

export function SpiralFileSystem_get_source_directory(): string {
    return get_source_directory();
}

export function SpiralFileSystem_normalize_path(x: string): string {
    return normalize_path(x);
}

export function SpiralFileSystem_new_file_uri(x: string): string {
    return new_file_uri(x);
}

export function SpiralFileSystem_create_temp_dir(): [string, IDisposable] {
    return create_temp_dir();
}

export function SpiralFileSystem_create_temp_dir$0027(x: string): [string, IDisposable] {
    return create_temp_dir$0027(x);
}

export function SpiralFileSystem_create_temp_path(): string {
    return create_temp_path();
}

export function set_trace_level(new_level: US0_$union): void {
    iterate<[Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]>((_arg: [Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]): void => {
        _arg[4].l0 = ((new_level.tag === /* US0_1 */ 1) ? US0_US0_1() : ((new_level.tag === /* US0_2 */ 2) ? US0_US0_2() : ((new_level.tag === /* US0_3 */ 3) ? US0_US0_3() : ((new_level.tag === /* US0_4 */ 4) ? US0_US0_4() : US0_US0_0()))));
    }, toArray<[Mut0, Mut1, Mut2, Mut3, Mut4, Option<int64>]>(TraceState_trace_state()));
    iterate<[Mut0_1, Mut1_1, Mut2_1, Mut3_1, Mut4_1, Option<int64>]>((_arg_1: [Mut0_1, Mut1_1, Mut2_1, Mut3_1, Mut4_1, Option<int64>]): void => {
        _arg_1[4].l0 = ((new_level.tag === /* US0_1 */ 1) ? US0_US0_1_1() : ((new_level.tag === /* US0_2 */ 2) ? US0_US0_2_1() : ((new_level.tag === /* US0_3 */ 3) ? US0_US0_3_1() : ((new_level.tag === /* US0_4 */ 4) ? US0_US0_4_1() : US0_US0_0_1()))));
    }, toArray<[Mut0_1, Mut1_1, Mut2_1, Mut3_1, Mut4_1, Option<int64>]>(TraceState_trace_state_1()));
    iterate<[Mut0_2, Mut1_2, Mut2_2, Mut3_2, Mut4_2, Option<int64>]>((_arg_2: [Mut0_2, Mut1_2, Mut2_2, Mut3_2, Mut4_2, Option<int64>]): void => {
        _arg_2[4].l0 = ((new_level.tag === /* US0_1 */ 1) ? US0_US0_1_2() : ((new_level.tag === /* US0_2 */ 2) ? US0_US0_2_2() : ((new_level.tag === /* US0_3 */ 3) ? US0_US0_3_2() : ((new_level.tag === /* US0_4 */ 4) ? US0_US0_4_2() : US0_US0_0_2()))));
    }, toArray<[Mut0_2, Mut1_2, Mut2_2, Mut3_2, Mut4_2, Option<int64>]>(TraceState_trace_state_2()));
    iterate<[Mut0_3, Mut1_3, Mut2_3, Mut3_3, Mut4_3, Option<int64>]>((_arg_3: [Mut0_3, Mut1_3, Mut2_3, Mut3_3, Mut4_3, Option<int64>]): void => {
        _arg_3[4].l0 = ((new_level.tag === /* US0_1 */ 1) ? US0_US0_1_3() : ((new_level.tag === /* US0_2 */ 2) ? US0_US0_2_3() : ((new_level.tag === /* US0_3 */ 3) ? US0_US0_3_3() : ((new_level.tag === /* US0_4 */ 4) ? US0_US0_4_3() : US0_US0_0_3()))));
    }, toArray<[Mut0_3, Mut1_3, Mut2_3, Mut3_3, Mut4_3, Option<int64>]>(TraceState_trace_state_3()));
    iterate<[Mut0_4, Mut1_4, Mut2_4, Mut3_4, Mut4_4, Option<int64>]>((_arg_4: [Mut0_4, Mut1_4, Mut2_4, Mut3_4, Mut4_4, Option<int64>]): void => {
        _arg_4[4].l0 = new_level;
    }, toArray<[Mut0_4, Mut1_4, Mut2_4, Mut3_4, Mut4_4, Option<int64>]>(TraceState_trace_state_4()));
}

export function get_trace_level(): US0_$union {
    return defaultArgWith<US0_$union>(map<[Mut0_4, Mut1_4, Mut2_4, Mut3_4, Mut4_4, Option<int64>], US0_$union>((_arg: [Mut0_4, Mut1_4, Mut2_4, Mut3_4, Mut4_4, Option<int64>]): US0_$union => _arg[4].l0, TraceState_trace_state_4()), (): US0_$union => {
        throw new Error("lib.get_trace_level / trace_state=None");
    });
}

