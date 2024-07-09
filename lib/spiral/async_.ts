import { value as value_1, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import { defaultOf } from "../../deps/Fable/src/fable-library-ts/Util.js";

export function closure0(unitVar: void, v0: any): any {
    let _v3: Option<any> = undefined;
    const x: any = defaultOf();
    _v3 = x;
    if (_v3 == null) {
        throw new Error("base.run_target / _v3=None");
    }
    else {
        return value_1(_v3);
    }
}

export const v6 = (v: any): any => closure0(undefined, v);

export function merge_cancellation_token_with_default_async(x: any): any {
    return v6(x);
}


