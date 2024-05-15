import { US0_US0_0 as US0_US0_0_3, Mut2 as Mut2_3, Mut1 as Mut1_3, Mut0 as Mut0_3, State_trace_state as State_trace_state_3, US0_$union, trace } from "../../lib/spiral/trace.fsx";
import { hash_text } from "../../lib/spiral/crypto.fsx";
import { trim_end, trim_start, trim, to_lower, substring, starts_with, split_string, split, slice, replace, format_exception, ends_with, ellipsis_end, ellipsis, contains, concat } from "../../lib/spiral/sm.fsx";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { US0_US0_0, US0_US0_4, US0_US0_3, US0_US0_2, US0_US0_1, Mut2, Mut1, Mut0, State_trace_state, create_temp_directory_name, create_temp_directory, find_parent, get_source_directory, get_workspace_root } from "../../lib/spiral/file_system.fsx";
import { equals, IDisposable } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { printf, toConsole } from "../../deps/Fable/src/fable-library-ts/String.js";
import { Option, value } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { US0_US0_0 as US0_US0_0_1, US0_US0_4 as US0_US0_4_1, US0_US0_3 as US0_US0_3_1, US0_US0_2 as US0_US0_2_1, US0_US0_1 as US0_US0_1_1, Mut2 as Mut2_1, Mut1 as Mut1_1, Mut0 as Mut0_1, State_trace_state as State_trace_state_1 } from "../../lib/spiral/networking.fsx";
import { US0_US0_0 as US0_US0_0_2, US0_US0_4 as US0_US0_4_2, US0_US0_3 as US0_US0_3_2, US0_US0_2 as US0_US0_2_2, US0_US0_1 as US0_US0_1_2, Mut2 as Mut2_2, Mut1 as Mut1_2, Mut0 as Mut0_2, State_trace_state as State_trace_state_2 } from "../../lib/spiral/runtime.fsx";

export function SpiralTrace_trace(x: US0_$union): ((arg0: (() => string)) => ((arg0: (() => string)) => void)) {
    return trace(x);
}

export function SpiralCrypto_hash_text(x: string): string {
    return hash_text(x);
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

export function SpiralFileSystem_find_parent(x: string): ((arg0: boolean) => ((arg0: string) => string)) {
    return find_parent(x);
}

export function SpiralFileSystem_create_temp_directory(): [string, IDisposable] {
    return create_temp_directory();
}

export function SpiralFileSystem_create_temp_directory_name(): string {
    return create_temp_directory_name();
}

export function set_trace_level(new_level: US0_$union): void {
    if (equals(State_trace_state(), void 0)) {
        toConsole(printf("@1"));
    }
    else {
        const patternInput: [Mut0, Mut1, Mut1, Mut2, Option<int64>] = value(State_trace_state());
        patternInput[3].l0 = ((new_level.tag === /* US0_1 */ 1) ? US0_US0_1() : ((new_level.tag === /* US0_2 */ 2) ? US0_US0_2() : ((new_level.tag === /* US0_3 */ 3) ? US0_US0_3() : ((new_level.tag === /* US0_4 */ 4) ? US0_US0_4() : US0_US0_0()))));
    }
    if (equals(State_trace_state_1(), void 0)) {
        toConsole(printf("@2"));
    }
    else {
        const patternInput_1: [Mut0_1, Mut1_1, Mut1_1, Mut2_1, Option<int64>] = value(State_trace_state_1());
        patternInput_1[3].l0 = ((new_level.tag === /* US0_1 */ 1) ? US0_US0_1_1() : ((new_level.tag === /* US0_2 */ 2) ? US0_US0_2_1() : ((new_level.tag === /* US0_3 */ 3) ? US0_US0_3_1() : ((new_level.tag === /* US0_4 */ 4) ? US0_US0_4_1() : US0_US0_0_1()))));
    }
    if (equals(State_trace_state_2(), void 0)) {
        toConsole(printf("@3"));
    }
    else {
        const patternInput_2: [Mut0_2, Mut1_2, Mut1_2, Mut2_2, Option<int64>] = value(State_trace_state_2());
        patternInput_2[3].l0 = ((new_level.tag === /* US0_1 */ 1) ? US0_US0_1_2() : ((new_level.tag === /* US0_2 */ 2) ? US0_US0_2_2() : ((new_level.tag === /* US0_3 */ 3) ? US0_US0_3_2() : ((new_level.tag === /* US0_4 */ 4) ? US0_US0_4_2() : US0_US0_0_2()))));
    }
    if (equals(State_trace_state_3(), void 0)) {
        toConsole(printf("@4"));
    }
    else {
        const patternInput_3: [Mut0_3, Mut1_3, Mut1_3, Mut2_3, Option<int64>] = value(State_trace_state_3());
        patternInput_3[3].l0 = new_level;
    }
}

export function get_trace_level(): US0_$union {
    if (equals(State_trace_state_3(), void 0)) {
        toConsole(printf("@6"));
        return US0_US0_0_3();
    }
    else {
        const patternInput: [Mut0_3, Mut1_3, Mut1_3, Mut2_3, Option<int64>] = value(State_trace_state_3());
        return patternInput[3].l0;
    }
}
