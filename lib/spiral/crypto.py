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
from fable_modules.fable_library.list import (to_array, empty, of_array)
from fable_modules.fable_library.long import (op_subtraction, op_addition)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_2, default_arg)
from fable_modules.fable_library.reflection import (TypeInfo, int32_type, record_type, union_type, int64_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Record, Array, Union, uint16, FSharpRef)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare)

class ICryptoCreateHash(Protocol):
    @abstractmethod
    def create_hash(self, x: str) -> Any:
        ...


class IHashlibSha256(Protocol):
    @abstractmethod
    def sha256(self) -> Any:
        ...


State_trace_state: tuple[Mut1, Mut2, Mut3, Mut4, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr11() -> TypeInfo:
    return record_type("Crypto.Mut0", [], Mut0, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int

Mut0_reflection = _expr11

def _expr12() -> TypeInfo:
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


US0_reflection = _expr12

def _expr13() -> TypeInfo:
    return record_type("Crypto.Mut1", [], Mut1, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: int64

Mut1_reflection = _expr13

def _expr14() -> TypeInfo:
    return record_type("Crypto.Mut2", [], Mut2, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: Callable[[str], None]

Mut2_reflection = _expr14

def _expr15() -> TypeInfo:
    return record_type("Crypto.Mut3", [], Mut3, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: bool

Mut3_reflection = _expr15

def _expr16() -> TypeInfo:
    return record_type("Crypto.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr16

def _expr17() -> TypeInfo:
    return union_type("Crypto.US1", [], US1, lambda: [[("f0_0", US0_reflection())], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr17

def _expr18() -> TypeInfo:
    return union_type("Crypto.US2", [], US2, lambda: [[("f0_0", int64_type)], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr18

def _expr19() -> TypeInfo:
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


US3_reflection = _expr19

def _expr20() -> TypeInfo:
    return record_type("Crypto.Mut5", [], Mut5, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut5(Record):
    l0: str

Mut5_reflection = _expr20

def method1(v0_1: int, v1_1: Mut0) -> bool:
    return v1_1.l0 < v0_1


def method2(__unit: None=None) -> str:
    return ""


def method0(v0_1: str) -> str:
    _v3: str | None = None
    v178: IHashlibSha256 = hashlib
    v180: Any = v178.sha256()
    v191: str = v0_1.encode("utf-8")
    v180.update(v191)
    x: str = v180.hexdigest()
    _v3 = x
    if _v3 is None:
        raise Exception("base.run_target / _v3=None")

    else: 
        return _v3



def closure0(unit_var: None, v0_1: str) -> str:
    return method0(v0_1)


def closure2(unit_var: None, unit_var_1: None) -> str:
    return "crypto.hash_to_port"


def closure3(v0_1: int, v1_1: str, v2: uint16, unit_var: None) -> tuple[int, str, uint16]:
    return (v0_1, v1_1, v2)


def method4(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method6(__unit: None=None) -> str:
    return ""


def method5(v0_1: str) -> str:
    _v3: str | None = None
    v54: IOsEnviron = os
    v56: Any = v54.environ
    _v66: (str | None) | None = None
    x: str | None = v56.get(v0_1)
    _v66 = some(x)
    v77: str | None
    if _v66 is None:
        raise Exception("optionm\'.of_obj / _v66=None")

    else: 
        v77 = value_2(_v66)

    _v86: FSharpRef[US3 | None] = FSharpRef(None)
    x_4: US3 | None
    if v77 is None:
        x_4 = None

    else: 
        x_2: str = v77
        def x_3(__unit: None=None, v0_1: Any=v0_1) -> US3:
            return US3(0, x_2)

        x_4 = x_3(None)

    _v86.contents = x_4
    v113: US3 = default_arg(_v86.contents, US3(1))
    x_5: str = v113.fields[0] if (v113.tag == 0) else ""
    _v3 = x_5
    if _v3 is None:
        raise Exception("base.run_target / _v3=None")

    else: 
        return _v3



def method7(__unit: None=None) -> str:
    return "AUTOMATION"


def closure6(unit_var: None, v0_1: str) -> None:
    pass


def closure5(unit_var: None, v0_1: US0) -> tuple[Mut1, Mut2, Mut3, Mut4, int64 | None]:
    _v3: tuple[US1, US2] | None = None
    v246: str = method5(method4())
    v252: US1 = US1(0, US0(0)) if ("Verbose" == v246) else US1(1)
    def _arrow51(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> US1:
        v260: US1 = US1(0, US0(1)) if ("Debug" == v246) else US1(1)
        if v260.tag == 0:
            return US1(0, v260.fields[0])

        else: 
            v268: US1 = US1(0, US0(2)) if ("Info" == v246) else US1(1)
            if v268.tag == 0:
                return US1(0, v268.fields[0])

            else: 
                v276: US1 = US1(0, US0(3)) if ("Warning" == v246) else US1(1)
                if v276.tag == 0:
                    return US1(0, v276.fields[0])

                else: 
                    v284: US1 = US1(0, US0(4)) if ("Critical" == v246) else US1(1)
                    return US1(0, v284.fields[0]) if (v284.tag == 0) else US1(1)




    x: tuple[US1, US2] = (US1(0, v252.fields[0]) if (v252.tag == 0) else _arrow51(), US2(0, ticks_1(now())) if (method5(method7()) == "True") else US2(1))
    _v3 = x
    pattern_input: tuple[US1, US2]
    if _v3 is None:
        raise Exception("base.run_target / _v3=None")

    else: 
        pattern_input = _v3

    v402: US2 = pattern_input[1]
    v401: US1 = pattern_input[0]
    def v493(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure6(None, v)

    return (Mut1(int64(0)), Mut2(v493), Mut3(True), Mut4(v401.fields[0] if (v401.tag == 0) else v0_1), v402.fields[0] if (v402.tag == 0) else None)


def method8(__unit: None=None) -> str:
    return "hh:mm:ss"


def method9(__unit: None=None) -> str:
    return "HH:mm:ss"


def method10(__unit: None=None) -> str:
    return "\u001b[0m"


def method12(v0_1: Mut5, v1_1: str) -> None:
    v12: str = v0_1.l0 + (("" + v1_1) + "")
    v0_1.l0 = v12


def method13(v0_1: Mut5) -> None:
    pass


def method14(v0_1: Mut5, v1_1: int) -> None:
    v12: str = v0_1.l0 + (("" + str(v1_1)) + "")
    v0_1.l0 = v12


def method15(v0_1: Mut5, v1_1: uint16) -> None:
    v12: str = v0_1.l0 + (("" + str(v1_1)) + "")
    v0_1.l0 = v12


def method11(v0_1: Mut5, v1_1: int, v2: str, v3: uint16) -> None:
    method12(v0_1, "{ ")
    method13(v0_1)
    method12(v0_1, "first_letter_code")
    method12(v0_1, " = ")
    method14(v0_1, v1_1)
    method12(v0_1, "; ")
    method12(v0_1, "hash_part")
    method12(v0_1, " = ")
    method12(v0_1, v2)
    method12(v0_1, "; ")
    method12(v0_1, "combined_value")
    method12(v0_1, " = ")
    method15(v0_1, v3)
    method12(v0_1, " }")


def closure4(v0_1: US0, v1_1: Callable[[], str], v2: Callable[[], tuple[int, str, uint16]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure5(None, US0(0)))

    pattern_input: tuple[Mut1, Mut2, Mut3, Mut4, int64 | None] = value_2(State_trace_state())
    v18: int64 | None = pattern_input[4]
    _v35: str | None = None
    _v534: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v18 is None:
        x_2 = None

    else: 
        x: int64 = v18
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2: Any=v2, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v534.contents = x_2
    v561: US2 = default_arg(_v534.contents, US2(1))
    def _arrow57(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2: Any=v2, unit_var: Any=unit_var) -> Any:
        v593: Any = create(op_subtraction(ticks_1(now()), v561.fields[0]))
        return create_1(1, 1, 1, hours(v593), minutes(v593), seconds(v593), milliseconds(v593))

    x_3: str = to_string(_arrow57() if (v561.tag == 0) else now(), method9())
    _v35 = x_3
    v826: str
    if _v35 is None:
        raise Exception("base.run_target / _v35=None")

    else: 
        v826 = _v35

    v985: US3 = US3(0, "Verbose") if (True if (v0_1.tag == 0) else False) else US3(1)
    v1034: US3
    if v985.tag == 0:
        v1034 = US3(0, v985.fields[0])

    else: 
        v994: US3 = US3(0, "Debug") if (True if (v0_1.tag == 1) else False) else US3(1)
        if v994.tag == 0:
            v1034 = US3(0, v994.fields[0])

        else: 
            v1003: US3 = US3(0, "Info") if (True if (v0_1.tag == 2) else False) else US3(1)
            if v1003.tag == 0:
                v1034 = US3(0, v1003.fields[0])

            else: 
                v1012: US3 = US3(0, "Warning") if (True if (v0_1.tag == 3) else False) else US3(1)
                if v1012.tag == 0:
                    v1034 = US3(0, v1012.fields[0])

                else: 
                    v1021: US3 = US3(0, "Critical") if (True if (v0_1.tag == 4) else False) else US3(1)
                    v1034 = US3(0, v1021.fields[0]) if (v1021.tag == 0) else US3(1)




    v1038: str
    if v1034.tag == 0:
        v1038 = v1034.fields[0]

    else: 
        raise Exception("Option does not have a value.")

    v1051: str = pad_left(v1038.lower(), 7, " ")
    _v1083: str | None = None
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v1051) + method10()
    _v1083 = x_5
    v1195: str
    if _v1083 is None:
        raise Exception("base.run_target / _v1083=None")

    else: 
        v1195 = _v1083

    v1214: int64 = pattern_input[0].l0
    pattern_input_1: tuple[int, str, uint16] = v2(None)
    v1219: Mut5 = Mut5("")
    method11(v1219, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])
    v1220: str = v1219.l0
    return trim_end(trim_start(((((((((("" + v826) + " ") + v1195) + " #") + str(v1214)) + " ") + v1_1(None)) + " / ") + v1220) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method16(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v4(v: US0, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut1, Mut2, Mut3, Mut4, int64 | None]:
        return closure5(None, v)

    if State_trace_state() is None:
        State_trace_state(v4(US0(0)))

    pattern_input: tuple[Mut1, Mut2, Mut3, Mut4, int64 | None] = value_2(State_trace_state())
    v13: Mut1 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v4(US0(0)))

    pattern_input_1: tuple[Mut1, Mut2, Mut3, Mut4, int64 | None] = value_2(State_trace_state())
    v61: US0 = pattern_input_1[3].l0
    class ObjectExpr70:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr72:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr70())) >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr72()))):
        v69: int64 = op_addition(v13.l0, int64(1))
        v13.l0 = v69
        v72: str = ("" + v1_1(None)) + ""
        _v81: None | None = None
        print(v72)
        _v81 = some(None)
        if _v81 is None:
            raise Exception("base.run_target / _v81=None")

        else: 
            value_2(_v81)

        pattern_input[1].l0(v72)



def method3(v0_1: US0, v1_1: Callable[[], str], v2: Callable[[], tuple[int, str, uint16]]) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2: Any=v2) -> str:
        return closure4(v0_1, v1_1, v2, None)

    method16(v0_1, v3)


def closure1(unit_var: None, v0_1: str) -> uint16:
    v3: int = int(char_code_at(v0_1[0], 0)) or 0
    v4: str = v0_1[0:7 + 1]
    v8: uint16
    value_1: int = (parse(v4, 511, False, 32, 16) + v3) or 0
    v8 = int(value_1+0x10000 if value_1 < 0 else value_1) & 0xFFFF
    def v10(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure2(None, None)

    def v11(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> tuple[int, str, uint16]:
        return closure3(v3, v4, v8, None)

    method3(US0(0), v10, v11)
    return (v8 % uint16(48128)) + uint16(1024)


def _arrow82(v: str) -> str:
    return closure0(None, v)


v0: Callable[[str], str] = _arrow82

def hash_text(x: str) -> str:
    return v0(x)


def _arrow84(v: str) -> uint16:
    return closure1(None, v)


v1: Callable[[str], uint16] = _arrow84

def hash_to_port(x: str) -> uint16:
    return v1(x)


