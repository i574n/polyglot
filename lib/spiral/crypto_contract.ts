import { Record } from "../../deps/Fable/src/fable-library-ts/Types.js";
import { int32 } from "../../deps/Fable/src/fable-library-ts/Int32.js";
import { IComparable, IEquatable } from "../../deps/Fable/src/fable-library-ts/Util.js";
import { record_type, int32_type, TypeInfo } from "../../deps/Fable/src/fable-library-ts/Reflection.js";
import { value, Option } from "../../deps/Fable/src/fable-library-ts/Option.js";
import * as crypto from "crypto";

export interface ICryptoCreateHash {
    createHash(x: string): any
}

export class Mut0 extends Record implements IEquatable<Mut0>, IComparable<Mut0> {
    l0: int32;
    constructor(l0: int32) {
        super();
        this.l0 = (l0 | 0);
    }
}

export function Mut0_$reflection(): TypeInfo {
    return record_type("Crypto.Mut0", [], Mut0, () => [["l0", int32_type]]);
}

export function method0(v0_1: int32, v1: Mut0): boolean {
    return v1.l0 < v0_1;
}

export function method1(): string {
    return "";
}

export function closure0(unitVar: void, v0_1: string): string {
    let _v1: Option<string> = void 0;
    const v29: ICryptoCreateHash = crypto;
    const v32: any = v29.createHash("sha256");
    const v34: any = v32.update(v0_1, 'utf8');
    const x: string = v34.digest("hex");
    _v1 = x;
    return value(_v1);
}

export const v0 = (v: string): string => closure0(void 0, v);

export function hash_text(x: string): string {
    return v0(x);
}


