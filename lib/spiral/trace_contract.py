from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from typing import Any
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value)
from fable_modules.fable_library.reflection import (TypeInfo, int64_type, record_type, bool_type, union_type, string_type, unit_type, lambda_type)
from fable_modules.fable_library.string_ import (pad_right, trim_end, trim_start)
from fable_modules.fable_library.types import (int64, Record, Array, Union, FSharpRef)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare)

State_trace_state: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] | None = create_atom(None)

def _expr146() -> TypeInfo:
    return record_type("Trace.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr146

def _expr147() -> TypeInfo:
    return record_type("Trace.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr147

def _expr148() -> TypeInfo:
    return union_type("Trace.US0", [], US0, lambda: [[], [], [], [], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1", "US0_2", "US0_3", "US0_4"]


US0_reflection = _expr148

def _expr149() -> TypeInfo:
    return record_type("Trace.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr149

def _expr150() -> TypeInfo:
    return record_type("Trace.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr150

def _expr151() -> TypeInfo:
    return union_type("Trace.US1", [], US1, lambda: [[("f0_0", int64_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr151

def _expr152() -> TypeInfo:
    return union_type("Trace.US2", [], US2, lambda: [[("f0_0", int64_type)], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr152

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



def closure1(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def method1(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def closure0(unit_var: None, unit_var_1: None) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    v0_1: Mut1 = Mut1(True)
    v1_1: Mut0 = Mut0(int64(0))
    v3: Mut2 = Mut2(US0(0))
    def v4(v: str, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure1(None, v)

    v5: Mut3 = Mut3(v4)
    _v6: (int64 | None) | None = None
    x: int64 | None = method1(None)
    _v6 = some(x)
    return (v1_1, v0_1, v3, value(_v6), v5)


def closure6(unit_var: None, v0_1: int64) -> US2:
    return US2(0, v0_1)


def method3(__unit: None=None) -> Callable[[int64], US2]:
    def _arrow153(v: int64) -> US2:
        return closure6(None, v)

    return _arrow153


def method4(__unit: None=None) -> str:
    return ""


def closure5(v0_1: US0, v1_1: Callable[[], str], v2: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, None))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    _v9: str | None = None
    x: str = method4()
    _v9 = x
    v61: str = value(_v9)
    v62: int64 = pattern_input[0].l0
    v72: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    _v75: str | None = None
    x_1: str = pad_right(v72.lower(), 7, " ")
    _v75 = x_1
    return trim_end(trim_start(((((((((("" + v61) + " ") + value(_v75)) + " #") + str(v62)) + " ") + v1_1(None)) + " / ") + v2(None)) + ""), " ", "/")


def method5(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
        return closure0(None, None)

    if State_trace_state() is None:
        State_trace_state(v2(None))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    v3: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2(None))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    v13: US0 = pattern_input_1[2].l0
    class ObjectExpr154:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr155:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr154())) >= find(v13, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr155()))):
        v21: int64 = op_addition(v3.l0, int64(1))
        v3.l0 = v21
        v22: str = ("" + v1_1(None)) + ""
        _v23: None | None = None
        print(v22)
        _v23 = some(None)
        value(_v23)
        pattern_input[4].l0(v22)



def method2(v0_1: US0, v1_1: Callable[[], str], v2: Callable[[], str]) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2: Any=v2) -> str:
        return closure5(v0_1, v1_1, v2, None)

    method5(v0_1, v3)


def closure4(v0_1: US0, v1_1: Callable[[], str], v2: Callable[[], str]) -> None:
    method2(v0_1, v1_1, v2)


def closure3(v0_1: US0, v1_1: Callable[[], str]) -> Callable[[Callable[[], str]], None]:
    def _arrow157(v: Callable[[], str], v0_1: Any=v0_1, v1_1: Any=v1_1) -> None:
        closure4(v0_1, v1_1, v)

    return _arrow157


def closure2(unit_var: None, v0_1: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    def _arrow158(v: Callable[[], str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[Callable[[], str]], None]:
        return closure3(v0_1, v)

    return _arrow158


def _arrow159(__unit: None=None) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, None)


v0: Callable[[], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow159


if State_trace_state() is None:
    State_trace_state(v0(None))


def _arrow160(v: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return closure2(None, v)


v1: Callable[[US0, Callable[[], str], Callable[[], str]], None] = _arrow160

def trace(x: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return v1(x)


