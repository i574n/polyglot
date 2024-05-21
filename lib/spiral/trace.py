from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from typing import Any
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, bool_type, string_type, unit_type, lambda_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare)

State_trace_state: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] | None = create_atom(None)

def _expr120() -> TypeInfo:
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


US0_reflection = _expr120

def _expr121() -> TypeInfo:
    return record_type("Trace.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr121

def _expr122() -> TypeInfo:
    return record_type("Trace.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr122

def _expr123() -> TypeInfo:
    return record_type("Trace.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr123

def _expr124() -> TypeInfo:
    return record_type("Trace.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr124

def _expr125() -> TypeInfo:
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


US1_reflection = _expr125

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



def closure1(unit_var: None, v0_1: str) -> None:
    pass


def method0(__unit: None=None) -> str:
    return ""


def method1(__unit: None=None) -> str:
    return "AUTOMATION"


def closure0(unit_var: None, v0_1: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    v1_1: Mut1 = Mut1(True)
    v2_1: Mut0 = Mut0(int64(0))
    v3: Mut2 = Mut2(v0_1)
    def v4(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure1(None, v)

    v5: Mut3 = Mut3(v4)
    _v6: (int64 | None) | None = None
    _v6 = some(None)
    def _arrow126(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> int64 | None:
        raise Exception("base.run_target / _v6=None")

    return (v2_1, v1_1, v3, _arrow126() if (_v6 is None) else value(_v6), v5)


def method3(__unit: None=None) -> str:
    return ""


def closure5(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    _v10: str | None = None
    x: str = method3()
    _v10 = x
    v67: str
    if _v10 is None:
        raise Exception("base.run_target / _v10=None")

    else: 
        v67 = _v10

    v68: int64 = pattern_input[0].l0
    v78: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    _v82: str | None = None
    x_2: str = pad_left(v78.lower(), 7, " ")
    _v82 = x_2
    def _arrow127(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> str:
        raise Exception("base.run_target / _v82=None")

    return trim_end(trim_start(((((((((("" + v67) + " ") + (_arrow127() if (_v82 is None) else _v82)) + " #") + str(v68)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method4(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(v: US0, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
        return closure0(None, v)

    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    v4: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    v15: US0 = pattern_input_1[2].l0
    class ObjectExpr128:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr129:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr128())) >= find(v15, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr129()))):
        v23: int64 = op_addition(v4.l0, int64(1))
        v4.l0 = v23
        v24: str = ("" + v1_1(None)) + ""
        _v25: None | None = None
        print(v24)
        _v25 = some(None)
        if _v25 is None:
            raise Exception("base.run_target / _v25=None")

        else: 
            value(_v25)

        pattern_input[4].l0(v24)



def method2(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure5(v0_1, v1_1, v2_1, None)

    method4(v0_1, v3)


def closure4(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    method2(v0_1, v1_1, v2_1)


def closure3(v0_1: US0, v1_1: Callable[[], str]) -> Callable[[Callable[[], str]], None]:
    def _arrow130(v: Callable[[], str], v0_1: Any=v0_1, v1_1: Any=v1_1) -> None:
        closure4(v0_1, v1_1, v)

    return _arrow130


def closure2(unit_var: None, v0_1: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    def _arrow131(v: Callable[[], str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[Callable[[], str]], None]:
        return closure3(v0_1, v)

    return _arrow131


def _arrow132(v: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, v)


v0: Callable[[US0], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow132

v1: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v0(v1))


def _arrow133(v: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return closure2(None, v)


v2: Callable[[US0, Callable[[], str], Callable[[], str]], None] = _arrow133

def trace(x: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return v2(x)


