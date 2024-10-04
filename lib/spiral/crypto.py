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
from fable_modules.fable_library.option import (some, value as value_2, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, int32_type, record_type, union_type, int64_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.string_ import (trim_end, trim_start)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Record, Array, Union, uint16)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare)

class ICryptoCreateHash(Protocol):
    @abstractmethod
    def create_hash(self, x: str) -> Any:
        ...


class IHashlibSha256(Protocol):
    @abstractmethod
    def sha256(self) -> Any:
        ...


TraceState_trace_state: tuple[Mut1, Mut2, Mut3, Mut4, Mut5, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr14() -> TypeInfo:
    return record_type("Crypto.Mut0", [], Mut0, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int

Mut0_reflection = _expr14

def _expr15() -> TypeInfo:
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


US0_reflection = _expr15

def _expr18() -> TypeInfo:
    return record_type("Crypto.Mut1", [], Mut1, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: int64

Mut1_reflection = _expr18

def _expr19() -> TypeInfo:
    return record_type("Crypto.Mut2", [], Mut2, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: Callable[[str], None]

Mut2_reflection = _expr19

def _expr21() -> TypeInfo:
    return record_type("Crypto.Mut3", [], Mut3, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: bool

Mut3_reflection = _expr21

def _expr22() -> TypeInfo:
    return record_type("Crypto.Mut4", [], Mut4, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: str

Mut4_reflection = _expr22

def _expr23() -> TypeInfo:
    return record_type("Crypto.Mut5", [], Mut5, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut5(Record):
    l0: US0

Mut5_reflection = _expr23

def _expr25() -> TypeInfo:
    return union_type("Crypto.US1", [], US1, lambda: [[("f0_0", string_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr25

def _expr28() -> TypeInfo:
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


US2_reflection = _expr28

def _expr30() -> TypeInfo:
    return union_type("Crypto.US3", [], US3, lambda: [[("f0_0", int64_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr30

def method1(__unit: None=None) -> str:
    return ""


def method2(v0_1: int, v1_1: Mut0) -> bool:
    return v1_1.l0 < v0_1


def method3(__unit: None=None) -> str:
    return ""


def method0(v0_1: str) -> str:
    v136: IHashlibSha256 = hashlib
    v138: Any = v136.sha256()
    v143: str = v0_1.encode("utf-8")
    v138.update(v143)
    return v138.hexdigest()


def closure0(unit_var: None, v0_1: str) -> str:
    return method0(v0_1)


def method6(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method8(__unit: None=None) -> str:
    return ""


def closure4(unit_var: None, v0_1: str) -> US1:
    return US1(0, v0_1)


def method9(__unit: None=None) -> Callable[[str], US1]:
    def _arrow39(v: str) -> US1:
        return closure4(None, v)

    return _arrow39


def method7(v0_1: str) -> str:
    v50: IOsEnviron = os
    v52: Any = v50.environ
    _v56: (str | None) | None = None
    x: str | None = v52.get(v0_1)
    _v56 = some(x)
    v61: str | None
    if _v56 is None:
        raise Exception("optionm\'.of_obj / _v56=None")

    else: 
        v61 = value_2(_v56)

    v77: US1 = default_arg(map(method9(), v61), US1(1))
    if v77.tag == 0:
        return v77.fields[0]

    else: 
        return ""



def method10(__unit: None=None) -> str:
    return "AUTOMATION"


def closure5(unit_var: None, v0_1: str) -> None:
    pass


def method5(v0_1: US0) -> tuple[Mut1, Mut2, Mut3, Mut4, Mut5, int64 | None]:
    v230: str = method7(method6())
    v235: US2 = US2(0, US0(0)) if ("Verbose" == v230) else US2(1)
    def _arrow56(__unit: None=None, v0_1: Any=v0_1) -> US2:
        v242: US2 = US2(0, US0(1)) if ("Debug" == v230) else US2(1)
        if v242.tag == 0:
            return US2(0, v242.fields[0])

        else: 
            v249: US2 = US2(0, US0(2)) if ("Info" == v230) else US2(1)
            if v249.tag == 0:
                return US2(0, v249.fields[0])

            else: 
                v256: US2 = US2(0, US0(3)) if ("Warning" == v230) else US2(1)
                if v256.tag == 0:
                    return US2(0, v256.fields[0])

                else: 
                    v263: US2 = US2(0, US0(4)) if ("Critical" == v230) else US2(1)
                    return US2(0, v263.fields[0]) if (v263.tag == 0) else US2(1)




    _v1: tuple[US2, US3] = (US2(0, v235.fields[0]) if (v235.tag == 0) else _arrow56(), US3(0, ticks_1(now())) if (method7(method10()) == "True") else US3(1))
    v352: US3 = _v1[1]
    v351: US2 = _v1[0]
    def v417(v: str, v0_1: Any=v0_1) -> None:
        closure5(None, v)

    return (Mut1(int64(1)), Mut2(v417), Mut3(True), Mut4(""), Mut5(v351.fields[0] if (v351.tag == 0) else v0_1), v352.fields[0] if (v352.tag == 0) else None)


def closure3(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut1, Mut2, Mut3, Mut4, Mut5, int64 | None] = method5(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def method4(v0_1: US0) -> bool:
    v3: None
    closure3(None, None)
    v3 = None
    pattern_input: tuple[Mut1, Mut2, Mut3, Mut4, Mut5, int64 | None] = value_2(TraceState_trace_state())
    v35: US0 = pattern_input[4].l0
    if pattern_input[2].l0 == False:
        return False

    else: 
        class ObjectExpr71:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        class ObjectExpr74:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        return find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr71())) >= find(v35, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr74()))



def closure6(unit_var: None, v0_1: int64) -> US3:
    return US3(0, v0_1)


def method12(__unit: None=None) -> Callable[[int64], US3]:
    def _arrow78(v: int64) -> US3:
        return closure6(None, v)

    return _arrow78


def method13(__unit: None=None) -> str:
    return "hh:mm:ss"


def method14(__unit: None=None) -> str:
    return "HH:mm:ss"


def method11(v0_1: Mut1, v1_1: Mut2, v2: Mut3, v3: Mut4, v4: Mut5, v5: int64 | None=None) -> str:
    v238: US3 = default_arg(map(method12(), v5), US3(1))
    def _arrow87(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2: Any=v2, v3: Any=v3, v4: Any=v4, v5: Any=v5) -> Any:
        v252: Any = create(op_subtraction(ticks_1(now()), v238.fields[0]))
        return create_1(1, 1, 1, hours(v252), minutes(v252), seconds(v252), milliseconds(v252))

    return to_string(_arrow87() if (v238.tag == 0) else now(), method14())


def method17(__unit: None=None) -> str:
    return ""


def closure7(v0_1: Mut4, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def method16(v0_1: str) -> str:
    v2: Mut4 = Mut4(method17())
    v8: None
    closure7(v2, ("" + str(v0_1)) + "", None)
    v8 = None
    return v2.l0


def method18(__unit: None=None) -> str:
    return "\u001b[0m"


def method15(__unit: None=None) -> str:
    v2: str = "Verbose".lower()
    return ("\u001b[90m" + method16(v2[0])) + method18()


def method20(v0_1: int, v1_1: str, v2: uint16) -> str:
    v4: Mut4 = Mut4(method17())
    v11: None
    closure7(v4, ("" + "{ ") + "", None)
    v11 = None
    v20: None
    closure7(v4, ("" + "first_letter_code") + "", None)
    v20 = None
    v29: None
    closure7(v4, ("" + " = ") + "", None)
    v29 = None
    v37: None
    closure7(v4, ("" + str(v0_1)) + "", None)
    v37 = None
    v46: None
    closure7(v4, ("" + "; ") + "", None)
    v46 = None
    v55: None
    closure7(v4, ("" + "hash_part") + "", None)
    v55 = None
    v63: None
    closure7(v4, ("" + " = ") + "", None)
    v63 = None
    v71: None
    closure7(v4, ("" + v1_1) + "", None)
    v71 = None
    v79: None
    closure7(v4, ("" + "; ") + "", None)
    v79 = None
    v88: None
    closure7(v4, ("" + "combined_value") + "", None)
    v88 = None
    v96: None
    closure7(v4, ("" + " = ") + "", None)
    v96 = None
    v104: None
    closure7(v4, ("" + str(v2)) + "", None)
    v104 = None
    v113: None
    closure7(v4, ("" + " }") + "", None)
    v113 = None
    return v4.l0


def method21(v0_1: str) -> str:
    return trim_end(trim_start(v0_1, *to_array(empty())), *to_array(of_array([" ", "/"])))


def method19(v0_1: Mut1, v1_1: Mut2, v2: Mut3, v3: Mut4, v4: Mut5, v5: int64 | None, v6: str, v7: str, v8: int, v9: str, v10: uint16) -> str:
    v11: str = method20(v8, v9, v10)
    return method21(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "crypto.hash_to_port") + " / ") + v11) + "")


def closure8(v0_1: Mut1, unit_var: None) -> None:
    v2: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2


def closure10(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure9(unit_var: None, v0_1: str) -> None:
    v3: None
    closure10(v0_1, None)
    v3 = None


def method22(v0_1: str) -> None:
    v3: None
    closure3(None, None)
    v3 = None
    pattern_input: tuple[Mut1, Mut2, Mut3, Mut4, Mut5, int64 | None] = value_2(TraceState_trace_state())
    v37: None
    closure8(pattern_input[0], None)
    v37 = None
    closure9(None, v0_1)
    pattern_input[1].l0(v0_1)


def closure2(v0_1: int, v1_1: str, v2: uint16, unit_var: None) -> None:
    if method4(US0(0)):
        v7: None
        closure3(None, None)
        v7 = None
        pattern_input: tuple[Mut1, Mut2, Mut3, Mut4, Mut5, int64 | None] = value_2(TraceState_trace_state())
        v26: int64 | None = pattern_input[5]
        v25: Mut5 = pattern_input[4]
        v24: Mut4 = pattern_input[3]
        v23: Mut3 = pattern_input[2]
        v22: Mut2 = pattern_input[1]
        v21: Mut1 = pattern_input[0]
        method22(method19(v21, v22, v23, v24, v25, v26, method11(v21, v22, v23, v24, v25, v26), method15(), v0_1, v1_1, v2))



def closure1(unit_var: None, v0_1: str) -> uint16:
    v3: int = int(char_code_at(v0_1[0], 0)) or 0
    v4: str = v0_1[0:7 + 1]
    v8: uint16
    value_1: int = (parse(v4, 511, False, 32, 16) + v3) or 0
    v8 = int(value_1+0x10000 if value_1 < 0 else value_1) & 0xFFFF
    v11: None
    closure2(v3, v4, v8, None)
    v11 = None
    return (v8 % uint16(48128)) + uint16(1024)


def _arrow106(v: str) -> str:
    return closure0(None, v)


v0: Callable[[str], str] = _arrow106

def hash_text(x: str) -> str:
    return v0(x)


def _arrow108(v: str) -> uint16:
    return closure1(None, v)


v1: Callable[[str], uint16] = _arrow108

def hash_to_port(x: str) -> uint16:
    return v1(x)


