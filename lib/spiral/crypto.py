from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import hashlib
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.char import char_code_at
from fable_modules.fable_library.date import (ticks as ticks_1, now, to_string, create as create_1)
from fable_modules.fable_library.int32 import parse
from fable_modules.fable_library.long import (op_subtraction, op_addition)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (value as value_2, default_arg, some)
from fable_modules.fable_library.reflection import (TypeInfo, int32_type, record_type, union_type, int64_type, bool_type, string_type, unit_type, lambda_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Record, Array, Union, FSharpRef, uint16)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare)

class ICryptoCreateHash(Protocol):
    @abstractmethod
    def create_hash(self, x: str) -> Any:
        ...


class IHashlibSha256(Protocol):
    @abstractmethod
    def sha256(self) -> Any:
        ...


State_trace_state: tuple[Mut1, Mut2, Mut3, int64 | None, Mut4] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr71() -> TypeInfo:
    return record_type("Crypto.Mut0", [], Mut0, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int

Mut0_reflection = _expr71

def _expr72() -> TypeInfo:
    return union_type("Crypto.US0", [], US0, lambda: [[], [], [], [], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1", "US0_2", "US0_3", "US0_4"]


US0_reflection = _expr72

def _expr73() -> TypeInfo:
    return record_type("Crypto.Mut1", [], Mut1, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: int64

Mut1_reflection = _expr73

def _expr74() -> TypeInfo:
    return record_type("Crypto.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr74

def _expr75() -> TypeInfo:
    return record_type("Crypto.Mut3", [], Mut3, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: US0

Mut3_reflection = _expr75

def _expr76() -> TypeInfo:
    return record_type("Crypto.Mut4", [], Mut4, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: Callable[[str], None]

Mut4_reflection = _expr76

def _expr77() -> TypeInfo:
    return union_type("Crypto.US1", [], US1, lambda: [[("f0_0", int64_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr77

def _expr78() -> TypeInfo:
    return union_type("Crypto.US2", [], US2, lambda: [[("f0_0", US0_reflection())], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr78

def _expr79() -> TypeInfo:
    return union_type("Crypto.US3", [], US3, lambda: [[("f0_0", string_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr79

def US0__get_IsUS0_0(this: FSharpRef[US0], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US0__get_IsUS0_1(this: FSharpRef[US0], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US0__get_IsUS0_2(this: FSharpRef[US0], unit_arg: None) -> bool:
    if this.tag == 2:
        return True

    else: 
        return False



def US0__get_IsUS0_3(this: FSharpRef[US0], unit_arg: None) -> bool:
    if this.tag == 3:
        return True

    else: 
        return False



def US0__get_IsUS0_4(this: FSharpRef[US0], unit_arg: None) -> bool:
    if this.tag == 4:
        return True

    else: 
        return False



def US1__get_IsUS1_0(this: FSharpRef[US1], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US1__get_IsUS1_1(this: FSharpRef[US1], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US2__get_IsUS2_0(this: FSharpRef[US2], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US2__get_IsUS2_1(this: FSharpRef[US2], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US3__get_IsUS3_0(this: FSharpRef[US3], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US3__get_IsUS3_1(this: FSharpRef[US3], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def method1(v0_1: int, v1_1: Mut0) -> bool:
    return v1_1.l0 < v0_1


def method2(__unit: None=None) -> str:
    return ""


def method0(v0_1: str) -> str:
    _v1: str | None = None
    v94: IHashlibSha256 = hashlib
    v96: Any = v94.sha256()
    v99: str = v0_1.encode("utf-8")
    v96.update(v99)
    x: str = v96.hexdigest()
    _v1 = x
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def closure0(unit_var: None, v0_1: str) -> str:
    return method0(v0_1)


def closure2(unit_var: None, unit_var_1: None) -> str:
    return "crypto.hash_to_port"


def closure4(unit_var: None, unit_var_1: None) -> str:
    return ""


def closure3(v0_1: int, v1_1: str, v2: uint16, unit_var: None) -> str:
    return ((((((("first_letter_code: " + str(v0_1)) + " / hash_part: ") + v1_1) + " / combined_value: ") + str(v2)) + " / ") + closure4(None, None)) + ""


def method4(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method6(__unit: None=None) -> str:
    return ""


def method5(v0_1: str) -> str:
    _v1: str | None = None
    v50: IOsEnviron = os
    v52: Any = v50.environ
    x: str = v52.get(v0_1)
    _v1 = x
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method7(__unit: None=None) -> str:
    return "AUTOMATION"


def closure7(unit_var: None, v0_1: str) -> None:
    pass


def closure6(unit_var: None, v0_1: US0) -> tuple[Mut1, Mut2, Mut3, int64 | None, Mut4]:
    _v1: tuple[US1, US2] | None = None
    v73: str = method5(method4())
    v94: US2 = US2(0, US0(0)) if ("Verbose" == v73) else (US2(0, US0(1)) if ("Debug" == v73) else (US2(0, US0(2)) if ("Info" == v73) else (US2(0, US0(3)) if ("Warning" == v73) else (US2(0, US0(4)) if ("Critical" == v73) else US2(1)))))
    x: tuple[US1, US2] = (US1(0, ticks_1(now())) if (method5(method7()) == "True") else US1(1), v94)
    _v1 = x
    pattern_input: tuple[US1, US2]
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        pattern_input = _v1

    v139: US2 = pattern_input[1]
    v138: US1 = pattern_input[0]
    def v146(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure7(None, v)

    v147: Mut4 = Mut4(v146)
    return (Mut1(int64(0)), Mut2(True), Mut3(v139.fields[0] if (v139.tag == 0) else v0_1), v138.fields[0] if (v138.tag == 0) else None, v147)


def method8(__unit: None=None) -> str:
    return "hh:mm:ss"


def method9(__unit: None=None) -> str:
    return ""


def method10(__unit: None=None) -> str:
    return "HH:mm:ss"


def closure5(v0_1: US0, v1_1: Callable[[], str], v2: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure6(None, US0(0)))

    pattern_input: tuple[Mut1, Mut2, Mut3, int64 | None, Mut4] = value_2(State_trace_state())
    v8: int64 | None = pattern_input[3]
    _v10: str | None = None
    _v93: FSharpRef[US1 | None] = FSharpRef(None)
    x_2: US1 | None
    if v8 is None:
        x_2 = None

    else: 
        x: int64 = v8
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2: Any=v2, unit_var: Any=unit_var) -> US1:
            return US1(0, x)

        x_2 = x_1(None)

    _v93.contents = x_2
    v98: US1 = default_arg(_v93.contents, US1(1))
    def _arrow80(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2: Any=v2, unit_var: Any=unit_var) -> Any:
        v105: Any = create(op_subtraction(ticks_1(now()), v98.fields[0]))
        return create_1(1, 1, 1, hours(v105), minutes(v105), seconds(v105), milliseconds(v105))

    x_3: str = to_string(_arrow80() if (v98.tag == 0) else now(), method10())
    _v10 = x_3
    v147: str
    if _v10 is None:
        raise Exception("base.run_target / _v10=None")

    else: 
        v147 = _v10

    v157: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    _v161: str | None = None
    x_5: str = pad_left(v157.lower(), 7, " ")
    _v161 = x_5
    def _arrow81(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2: Any=v2, unit_var: Any=unit_var) -> str:
        raise Exception("base.run_target / _v161=None")

    return trim_end(trim_start(((((((((("" + v147) + " ") + (_arrow81() if (_v161 is None) else _v161)) + " #") + str(pattern_input[0].l0)) + " ") + v1_1(None)) + " / ") + v2(None)) + ""), " ", "/")


def method11(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2(v: US0, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut1, Mut2, Mut3, int64 | None, Mut4]:
        return closure6(None, v)

    if State_trace_state() is None:
        State_trace_state(v2(US0(0)))

    pattern_input: tuple[Mut1, Mut2, Mut3, int64 | None, Mut4] = value_2(State_trace_state())
    v4: Mut1 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2(US0(0)))

    pattern_input_1: tuple[Mut1, Mut2, Mut3, int64 | None, Mut4] = value_2(State_trace_state())
    v15: US0 = pattern_input_1[2].l0
    class ObjectExpr82:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr83:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr82())) >= find(v15, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr83()))):
        v23: int64 = op_addition(v4.l0, int64(1))
        v4.l0 = v23
        v24: str = ("" + v1_1(None)) + ""
        _v25: None | None = None
        print(v24)
        _v25 = some(None)
        if _v25 is None:
            raise Exception("base.run_target / _v25=None")

        else: 
            value_2(_v25)

        pattern_input[4].l0(v24)



def method3(v0_1: US0, v1_1: Callable[[], str], v2: Callable[[], str]) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2: Any=v2) -> str:
        return closure5(v0_1, v1_1, v2, None)

    method11(v0_1, v3)


def closure1(unit_var: None, v0_1: str) -> uint16:
    v3: int = char_code_at(v0_1[0], 0) or 0
    v4: str = v0_1[0:7 + 1]
    v8: uint16
    value_1: int = (parse(v4, 511, False, 32, 16) + v3) or 0
    v8 = int(value_1+0x10000 if value_1 < 0 else value_1) & 0xFFFF
    def v10(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure2(None, None)

    def v11(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure3(v3, v4, v8, None)

    method3(US0(0), v10, v11)
    return (v8 % uint16(48128)) + uint16(1024)


def _arrow84(v: str) -> str:
    return closure0(None, v)


v0: Callable[[str], str] = _arrow84

def hash_text(x: str) -> str:
    return v0(x)


def _arrow85(v: str) -> uint16:
    return closure1(None, v)


v1: Callable[[str], uint16] = _arrow85

def hash_to_port(x: str) -> uint16:
    return v1(x)


