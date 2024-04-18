from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from typing import Any
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.option import (some, value)
from fable_modules.fable_library.reflection import (TypeInfo, int64_type, record_type, bool_type, union_type)
from fable_modules.fable_library.string_ import (trim_end, trim_start)
from fable_modules.fable_library.types import (int64, Record, Array, Union, FSharpRef)
from fable_modules.fable_library.util import (create_atom, equals, compare)

State_trace_state: tuple[Mut0, Mut1, Mut1, Mut2, int64 | None] | None = create_atom(None)

def _expr115() -> TypeInfo:
    return record_type("Trace.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr115

def _expr116() -> TypeInfo:
    return record_type("Trace.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr116

def _expr117() -> TypeInfo:
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


US0_reflection = _expr117

def _expr118() -> TypeInfo:
    return record_type("Trace.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr118

def _expr119() -> TypeInfo:
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


US1_reflection = _expr119

def _expr120() -> TypeInfo:
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


US2_reflection = _expr120

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



def method0(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def method1(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def closure0(unit_var: None, unit_var_1: None) -> tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]:
    v0_1: Mut1 = Mut1(True)
    v1_1: Mut0 = Mut0(int64(0))
    v3: Mut2 = Mut2(US0(0))
    v4: Mut1 = Mut1(False)
    _v5: (int64 | None) | None = None
    x: int64 | None = method1(None)
    _v5 = some(x)
    return (v1_1, v4, v0_1, v3, value(_v5))


def closure5(unit_var: None, v0_1: int64) -> US2:
    return US2(0, v0_1)


def method3(__unit: None=None) -> Callable[[int64], US2]:
    def _arrow121(v: int64) -> US2:
        return closure5(None, v)

    return _arrow121


def method4(__unit: None=None) -> str:
    return ""


def closure4(v0_1: US0, v1_1: Callable[[], str], v2: Callable[[], str], unit_var: None) -> str:
    if equals(State_trace_state(), None):
        State_trace_state(closure0(None, None))

    pattern_input: tuple[Mut0, Mut1, Mut1, Mut2, int64 | None] = value(State_trace_state())
    _v9: str | None = None
    _v9 = None
    v61: str = value(_v9)
    v62: int64 = pattern_input[0].l0
    v72: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    v73: str = v72.lower()
    _v74: str | None = None
    _v74 = None
    return trim_end(trim_start(((((((((("" + v61) + " ") + value(_v74)) + " #") + str(v62)) + " ") + v1_1(None)) + " / ") + v2(None)) + ""), " ", "/")


def method2(v0_1: US0, v1_1: Callable[[], str], v2: Callable[[], str]) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2: Any=v2) -> tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]:
        return closure0(None, None)

    if equals(State_trace_state(), None):
        State_trace_state(v3(None))

    v4: Mut0 = value(State_trace_state())[0]
    if equals(State_trace_state(), None):
        State_trace_state(v3(None))

    pattern_input_1: tuple[Mut0, Mut1, Mut1, Mut2, int64 | None] = value(State_trace_state())
    v14: US0 = pattern_input_1[3].l0
    if (compare(v0_1, v14) >= 0) if pattern_input_1[2].l0 else False:
        v19: int64 = op_addition(v4.l0, int64(1))
        v4.l0 = v19
        v21: str = ("" + closure4(v0_1, v1_1, v2, None)) + ""
        _v22: None | None = None
        _v22 = some(None)
        value(_v22)



def closure3(v0_1: US0, v1_1: Callable[[], str], v2: Callable[[], str]) -> None:
    method2(v0_1, v1_1, v2)


def closure2(v0_1: US0, v1_1: Callable[[], str]) -> Callable[[Callable[[], str]], None]:
    def _arrow122(v: Callable[[], str], v0_1: Any=v0_1, v1_1: Any=v1_1) -> None:
        closure3(v0_1, v1_1, v)

    return _arrow122


def closure1(unit_var: None, v0_1: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    def _arrow123(v: Callable[[], str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[Callable[[], str]], None]:
        return closure2(v0_1, v)

    return _arrow123


def _arrow124(__unit: None=None) -> tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]:
    return closure0(None, None)


v0: Callable[[], tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]] = _arrow124


if equals(State_trace_state(), None):
    State_trace_state(v0(None))


def _arrow125(v: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return closure1(None, v)


v1: Callable[[US0, Callable[[], str], Callable[[], str]], None] = _arrow125

def trace(x: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return v1(x)


