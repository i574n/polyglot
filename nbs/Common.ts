import { Union } from "../fable_modules/fable-library-ts/Types.js";
import { union_type, TypeInfo } from "../fable_modules/fable-library-ts/Reflection.js";
import { compare, createAtom } from "../fable_modules/fable-library-ts/Util.js";
import { int32 } from "../fable_modules/fable-library-ts/Int32.js";
import { value, Option } from "../fable_modules/fable-library-ts/Option.js";
import { trimEnd } from "../fable_modules/fable-library-ts/String.js";
import { create, op_Subtraction, now, toString } from "../fable_modules/fable-library-ts/Date.js";
import { microseconds, milliseconds, seconds, minutes, hours } from "../fable_modules/fable-library-ts/TimeSpan.js";

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
    3: ["Warn", []],
    4: ["Error", []]
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

export function TraceLevel_Warn() {
    return new TraceLevel<3>(3, []);
}

export function TraceLevel_Error() {
    return new TraceLevel<4>(4, []);
}

export class TraceLevel<Tag extends keyof TraceLevel_$cases> extends Union<Tag, TraceLevel_$cases[Tag][0]> {
    constructor(readonly tag: Tag, readonly fields: TraceLevel_$cases[Tag][1]) {
        super();
    }
    cases() {
        return ["Verbose", "Debug", "Info", "Warn", "Error"];
    }
}

export function TraceLevel_$reflection(): TypeInfo {
    return union_type("Polyglot.Common.TraceLevel", [], TraceLevel, () => [[], [], [], [], []]);
}

export let traceEnabled = createAtom<boolean>(true);

export let traceCount = createAtom<int32>(0);

export let traceLevel = createAtom<TraceLevel_$union>(TraceLevel_Verbose());

function replStart(): Option<Date> {
    return void 0;
}

export function trace(level: TraceLevel_$union, fn: (() => string), getLocals: (() => string)): void {
    let matchValue: Option<Date>, dateTime: Date, t: number;
    if (traceEnabled() && (compare(level, traceLevel()) >= 0)) {
        traceCount(traceCount() + 1);
        let arg: string;
        const trimChars: string[] = [" ", "/"];
        arg = trimEnd(`${toString((matchValue = replStart(), (matchValue == null) ? now() : ((dateTime = value(matchValue), (t = op_Subtraction(now(), dateTime), create(1, 1, 1, hours(t), minutes(t), seconds(t), milliseconds(t), microseconds(t)))))), "HH:mm:ss")} #${traceCount()} [${level}] ${fn()} / ${getLocals()}`, ...trimChars);
        console.log(arg);
    }
}

