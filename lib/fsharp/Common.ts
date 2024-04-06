import { Union } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { union_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { compare, createAtom } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { value, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { op_Subtraction, toInt64, int64 } from "../../deps/Fable/src/fable-library-ts/BigInt.js";
import { create, getTicks, now, toString } from "../../deps/Fable/src/fable-library-ts/Date.js";
import { milliseconds, seconds, minutes, hours, fromTicks } from "../../deps/Fable/src/fable-library-ts/TimeSpan.js";
import { SpiralSm_trim_start, SpiralSm_trim_end } from "../../lib/spiral/lib.fsx";
import { interpolate, toText } from "../../deps/Fable/src/fable-library-ts/String.js";

export const nl = "\n";

export const q = "\"";

export type TraceLevel_$union = 
    | TraceLevel<0>
    | TraceLevel<1>
    | TraceLevel<2>
    | TraceLevel<3>
    | TraceLevel<4>

export type TraceLevel_$cases = {
    0: ["Verbose", []],
    1: ["Debug", []],
    2: ["Info", []],
    3: ["Warning", []],
    4: ["Critical", []]
}

export function TraceLevel_Verbose() {
    return new TraceLevel<0>(0, []);
}

export function TraceLevel_Debug() {
    return new TraceLevel<1>(1, []);
}

export function TraceLevel_Info() {
    return new TraceLevel<2>(2, []);
}

export function TraceLevel_Warning() {
    return new TraceLevel<3>(3, []);
}

export function TraceLevel_Critical() {
    return new TraceLevel<4>(4, []);
}

export class TraceLevel<Tag extends keyof TraceLevel_$cases> extends Union<Tag, TraceLevel_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: TraceLevel_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["Verbose", "Debug", "Info", "Warning", "Critical"];
    }
}

export function TraceLevel_$reflection(): TypeInfo {
    return union_type("Polyglot.Common.TraceLevel", [], TraceLevel, () => [[], [], [], [], []]);
}

export function TraceLevel__get_IsVerbose(this$: TraceLevel_$union, unitArg: void): boolean {
    if ((this$ as any)['tag'] === /* Verbose */ 0) {
        return true;
    }
    else {
        return false;
    }
}

export function TraceLevel__get_IsDebug(this$: TraceLevel_$union, unitArg: void): boolean {
    if ((this$ as any)['tag'] === /* Debug */ 1) {
        return true;
    }
    else {
        return false;
    }
}

export function TraceLevel__get_IsInfo(this$: TraceLevel_$union, unitArg: void): boolean {
    if ((this$ as any)['tag'] === /* Info */ 2) {
        return true;
    }
    else {
        return false;
    }
}

export function TraceLevel__get_IsWarning(this$: TraceLevel_$union, unitArg: void): boolean {
    if ((this$ as any)['tag'] === /* Warning */ 3) {
        return true;
    }
    else {
        return false;
    }
}

export function TraceLevel__get_IsCritical(this$: TraceLevel_$union, unitArg: void): boolean {
    if ((this$ as any)['tag'] === /* Critical */ 4) {
        return true;
    }
    else {
        return false;
    }
}

export let traceEnabled = createAtom<boolean>(true);

export let traceCount = createAtom<int32>(0);

export let traceLevel = createAtom<TraceLevel_$union>(TraceLevel_Verbose());

export let traceDump = createAtom<boolean>(false);

export function testTraceLevel(level: TraceLevel_$union): boolean {
    if (traceEnabled()) {
        return compare(level, traceLevel()) >= 0;
    }
    else {
        return false;
    }
}

/**
 * ## traceRaw
 */
export function traceRaw(level: TraceLevel_$union, fn: (() => string)): void {
    if (testTraceLevel(level)) {
        traceCount(traceCount() + 1);
        const text = `${fn()}`;
        console.log(text);
    }
}

function replStart(): Option<int64> {
    return void 0;
}

export function trace(level: TraceLevel_$union, fn: (() => string), getLocals: (() => string)): void {
    traceRaw(level, (): string => {
        let matchValue: Option<int64>, replStart_1: int64, t: number;
        const time: string = toString((matchValue = replStart(), (matchValue == null) ? now() : ((replStart_1 = value(matchValue), (t = fromTicks(toInt64(op_Subtraction(getTicks(now()), replStart_1))), create(1, 1, 1, hours(t), minutes(t), seconds(t), milliseconds(t)))))), "HH:mm:ss");
        return SpiralSm_trim_end([" ", "/"])(SpiralSm_trim_start([])(toText(interpolate("%P() #%P() [%A%P()] %s%P() / %s%P()", [time, traceCount(), level, fn(), getLocals()]))));
    });
}

