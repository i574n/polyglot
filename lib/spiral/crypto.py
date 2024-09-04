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
from fable_modules.fable_library.long import (op_addition, op_subtraction)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_2, default_arg)
from fable_modules.fable_library.reflection import (TypeInfo, int32_type, record_type, union_type, int64_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Record, Array, Union, FSharpRef, uint16)
from fable_modules.fable_library.util import (create_atom, ignore, to_enumerable, compare)

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


def _expr23() -> TypeInfo:
    return record_type("Crypto.Mut0", [], Mut0, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int

Mut0_reflection = _expr23

def _expr24() -> TypeInfo:
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


US0_reflection = _expr24

def _expr25() -> TypeInfo:
    return record_type("Crypto.Mut1", [], Mut1, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: int64

Mut1_reflection = _expr25

def _expr26() -> TypeInfo:
    return record_type("Crypto.Mut2", [], Mut2, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: Callable[[str], None]

Mut2_reflection = _expr26

def _expr27() -> TypeInfo:
    return record_type("Crypto.Mut3", [], Mut3, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: bool

Mut3_reflection = _expr27

def _expr30() -> TypeInfo:
    return record_type("Crypto.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr30

def _expr33() -> TypeInfo:
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


US1_reflection = _expr33

def _expr36() -> TypeInfo:
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


US2_reflection = _expr36

def _expr39() -> TypeInfo:
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


US3_reflection = _expr39

def _expr40() -> TypeInfo:
    return record_type("Crypto.Mut5", [], Mut5, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut5(Record):
    l0: str

Mut5_reflection = _expr40

def method1(__unit: None=None) -> str:
    return ""


def method2(v0_1: int, v1_1: Mut0) -> bool:
    return v1_1.l0 < v0_1


def method3(__unit: None=None) -> str:
    return ""


def method0(v0_1: str) -> str:
    v114: IHashlibSha256 = hashlib
    v116: Any = v114.sha256()
    v121: str = v0_1.encode("utf-8")
    v116.update(v121)
    return v116.hexdigest()


def closure0(unit_var: None, v0_1: str) -> str:
    return method0(v0_1)


def method5(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method7(__unit: None=None) -> str:
    return ""


def closure4(v0_1: FSharpRef[US1 | None], v1_1: US1 | None=None) -> FSharpRef[US1 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure5(v0_1: str | None, v1_1: Callable[[US1 | None], FSharpRef[US1 | None]], unit_var: None) -> None:
    def _arrow47(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US1 | None:
        x: str = v0_1
        def x_1(__unit: None=None) -> US1:
            return US1(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow47()))


def method6(v0_1: str) -> str:
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

    _v64: FSharpRef[US1 | None] = FSharpRef(None)
    v69: None
    def v66(v: US1 | None=None, v0_1: Any=v0_1) -> FSharpRef[US1 | None]:
        return closure4(_v64, v)

    closure5(v61, v66, None)
    v69 = None
    v84: US1 = default_arg(_v64.contents, US1(1))
    if v84.tag == 0:
        return v84.fields[0]

    else: 
        return ""



def method8(__unit: None=None) -> str:
    return "AUTOMATION"


def closure6(unit_var: None, v0_1: str) -> None:
    pass


def method4(v0_1: US0) -> tuple[Mut1, Mut2, Mut3, Mut4, int64 | None]:
    v173: str = method6(method5())
    v178: US2 = US2(0, US0(0)) if ("Verbose" == v173) else US2(1)
    def _arrow53(__unit: None=None, v0_1: Any=v0_1) -> US2:
        v185: US2 = US2(0, US0(1)) if ("Debug" == v173) else US2(1)
        if v185.tag == 0:
            return US2(0, v185.fields[0])

        else: 
            v192: US2 = US2(0, US0(2)) if ("Info" == v173) else US2(1)
            if v192.tag == 0:
                return US2(0, v192.fields[0])

            else: 
                v199: US2 = US2(0, US0(3)) if ("Warning" == v173) else US2(1)
                if v199.tag == 0:
                    return US2(0, v199.fields[0])

                else: 
                    v206: US2 = US2(0, US0(4)) if ("Critical" == v173) else US2(1)
                    return US2(0, v206.fields[0]) if (v206.tag == 0) else US2(1)




    _v1: tuple[US2, US3] = (US2(0, v178.fields[0]) if (v178.tag == 0) else _arrow53(), US3(0, ticks_1(now())) if (method6(method8()) == "True") else US3(1))
    v295: US3 = _v1[1]
    v294: US2 = _v1[0]
    def v365(v: str, v0_1: Any=v0_1) -> None:
        closure6(None, v)

    return (Mut1(int64(0)), Mut2(v365), Mut3(True), Mut4(v294.fields[0] if (v294.tag == 0) else v0_1), v295.fields[0] if (v295.tag == 0) else None)


def closure3(unit_var: None, unit_var_1: None) -> None:
    if State_trace_state() is None:
        pattern_input: tuple[Mut1, Mut2, Mut3, Mut4, int64 | None] = method4(US0(0))
        State_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4]))



def closure7(v0_1: Mut1, unit_var: None) -> None:
    v2: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2


def closure8(v0_1: FSharpRef[US3 | None], v1_1: US3 | None=None) -> FSharpRef[US3 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure9(v0_1: int64 | None, v1_1: Callable[[US3 | None], FSharpRef[US3 | None]], unit_var: None) -> None:
    def _arrow57(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US3 | None:
        x: int64 = v0_1
        def x_1(__unit: None=None) -> US3:
            return US3(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow57()))


def method9(__unit: None=None) -> str:
    return "hh:mm:ss"


def method10(__unit: None=None) -> str:
    return "HH:mm:ss"


def method11(__unit: None=None) -> str:
    return "\u001b[0m"


def method12(__unit: None=None) -> str:
    return ""


def closure10(v0_1: Mut5, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def closure11(unit_var: None, unit_var_1: None) -> str:
    return "crypto.hash_to_port"


def closure13(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure12(unit_var: None, v0_1: str) -> None:
    v3: None
    closure13(v0_1, None)
    v3 = None


def closure2(v0_1: int, v1_1: str, v2: uint16, unit_var: None) -> None:
    def v4(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2: Any=v2, unit_var: Any=unit_var) -> None:
        closure3(None, None)

    v5: None
    v4(None)
    v5 = None
    pattern_input: tuple[Mut1, Mut2, Mut3, Mut4, int64 | None] = value_2(State_trace_state())
    v34: None
    v4(None)
    v34 = None
    pattern_input_1: tuple[Mut1, Mut2, Mut3, Mut4, int64 | None] = value_2(State_trace_state())
    v62: US0 = pattern_input_1[3].l0
    class ObjectExpr66:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v62, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr66()))):
        v70: None
        closure7(pattern_input[0], None)
        v70 = None
        v74: None
        v4(None)
        v74 = None
        pattern_input_2: tuple[Mut1, Mut2, Mut3, Mut4, int64 | None] = value_2(State_trace_state())
        _v349: FSharpRef[US3 | None] = FSharpRef(None)
        v354: None
        def v351(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2: Any=v2, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v349, v)

        closure9(pattern_input_2[4], v351, None)
        v354 = None
        v369: US3 = default_arg(_v349.contents, US3(1))
        def _arrow71(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2: Any=v2, unit_var: Any=unit_var) -> Any:
            v383: Any = create(op_subtraction(ticks_1(now()), v369.fields[0]))
            return create_1(1, 1, 1, hours(v383), minutes(v383), seconds(v383), milliseconds(v383))

        v414: str = to_string(_arrow71() if (v369.tag == 0) else now(), method10())
        v615: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method11()
        v626: int64 = pattern_input_2[0].l0
        v628: Mut5 = Mut5(method12())
        v635: None
        closure10(v628, ("" + "{ ") + "", None)
        v635 = None
        v644: None
        closure10(v628, ("" + "first_letter_code") + "", None)
        v644 = None
        v653: None
        closure10(v628, ("" + " = ") + "", None)
        v653 = None
        v661: None
        closure10(v628, ("" + str(v0_1)) + "", None)
        v661 = None
        v670: None
        closure10(v628, ("" + "; ") + "", None)
        v670 = None
        v679: None
        closure10(v628, ("" + "hash_part") + "", None)
        v679 = None
        v687: None
        closure10(v628, ("" + " = ") + "", None)
        v687 = None
        v695: None
        closure10(v628, ("" + v1_1) + "", None)
        v695 = None
        v703: None
        closure10(v628, ("" + "; ") + "", None)
        v703 = None
        v712: None
        closure10(v628, ("" + "combined_value") + "", None)
        v712 = None
        v720: None
        closure10(v628, ("" + " = ") + "", None)
        v720 = None
        v728: None
        closure10(v628, ("" + str(v2)) + "", None)
        v728 = None
        v737: None
        closure10(v628, ("" + " }") + "", None)
        v737 = None
        v740: str = v628.l0
        v779: str = trim_end(trim_start(((((((((("" + v414) + " ") + v615) + " #") + str(v626)) + " ") + closure11(None, None)) + " / ") + v740) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v779)
        pattern_input[1].l0(v779)



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


def _arrow83(v: str) -> str:
    return closure0(None, v)


v0: Callable[[str], str] = _arrow83

def hash_text(x: str) -> str:
    return v0(x)


def _arrow85(v: str) -> uint16:
    return closure1(None, v)


v1: Callable[[str], uint16] = _arrow85

def hash_to_port(x: str) -> uint16:
    return v1(x)


