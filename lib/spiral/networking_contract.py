from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from typing import Any
from fable_modules.fable_library.async_builder import Async
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value)
from fable_modules.fable_library.reflection import (TypeInfo, int64_type, record_type, bool_type, union_type, string_type, unit_type, lambda_type, class_type, int32_type)
from fable_modules.fable_library.string_ import (trim_end, trim_start)
from fable_modules.fable_library.types import (int64, Record, Array, Union, FSharpRef)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare)

State_trace_state: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] | None = create_atom(None)

def _expr80() -> TypeInfo:
    return record_type("Networking.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr80

def _expr81() -> TypeInfo:
    return record_type("Networking.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr81

def _expr82() -> TypeInfo:
    return union_type("Networking.US0", [], US0, lambda: [[], [], [], [], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1", "US0_2", "US0_3", "US0_4"]


US0_reflection = _expr82

def _expr83() -> TypeInfo:
    return record_type("Networking.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr83

def _expr84() -> TypeInfo:
    return record_type("Networking.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr84

def _expr85() -> TypeInfo:
    return union_type("Networking.US1", [], US1, lambda: [[("f0_0", int64_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr85

def _expr86() -> TypeInfo:
    return union_type("Networking.US2", [], US2, lambda: [[("f0_0", int64_type)], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr86

def _expr87() -> TypeInfo:
    return union_type("Networking.US3", [], US3, lambda: [[("f0_0", bool_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr87

def _expr88() -> TypeInfo:
    return union_type("Networking.US4", [], US4, lambda: [[("f0_0", bool_type)], [("f1_0", class_type("System.Exception"))]])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1"]


US4_reflection = _expr88

def _expr89() -> TypeInfo:
    return union_type("Networking.US5", [], US5, lambda: [[("f0_0", bool_type)], [("f1_0", class_type("System.Exception"))]])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr89

def _expr90() -> TypeInfo:
    return union_type("Networking.US6", [], US6, lambda: [[("f0_0", int32_type)], []])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1"]


US6_reflection = _expr90

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



def US4__get_IsUS4_0(this: FSharpRef[US4], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US4__get_IsUS4_1(this: FSharpRef[US4], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US5__get_IsUS5_0(this: FSharpRef[US5], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US5__get_IsUS5_1(this: FSharpRef[US5], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US6__get_IsUS6_0(this: FSharpRef[US6], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US6__get_IsUS6_1(this: FSharpRef[US6], unit_arg: None) -> bool:
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
    v3_1: Mut2 = Mut2(US0(0))
    def v4_1(v: str, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure1(None, v)

    v5: Mut3 = Mut3(v4_1)
    _v6: (int64 | None) | None = None
    x: int64 | None = method1(None)
    _v6 = some(x)
    return (v1_1, v0_1, v3_1, value(_v6), v5)


def closure3(v0_1: str, unit_var: None) -> str:
    return ("test_port_open / ex: " + v0_1) + ""


def closure4(unit_var: None, unit_var_1: None) -> str:
    return ""


def closure6(unit_var: None, v0_1: int64) -> US2:
    return US2(0, v0_1)


def method3(__unit: None=None) -> Callable[[int64], US2]:
    def _arrow91(v: int64) -> US2:
        return closure6(None, v)

    return _arrow91


def method4(__unit: None=None) -> str:
    return ""


def closure5(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, None))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    _v9: str | None = None
    _v9 = None
    v61: str = value(_v9)
    v62: int64 = pattern_input[0].l0
    v72: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    v73: str = v72.lower()
    _v74: str | None = None
    _v74 = None
    return trim_end(trim_start(((((((((("" + v61) + " ") + value(_v74)) + " #") + str(v62)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method5(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
        return closure0(None, None)

    if State_trace_state() is None:
        State_trace_state(v2_1(None))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    v3_1: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(None))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    v13: US0 = pattern_input_1[2].l0
    class ObjectExpr92:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr93:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr92())) >= find(v13, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr93()))):
        v21: int64 = op_addition(v3_1.l0, int64(1))
        v3_1.l0 = v21
        v22: str = ("" + v1_1(None)) + ""
        _v23: None | None = None
        _v23 = some(None)
        value(_v23)
        pattern_input[4].l0(v22)



def method2(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure5(v0_1, v1_1, v2_1, None)

    method5(v0_1, v3_1)


def closure2(unit_var: None, v0_1: int) -> Async[bool]:
    _v1: Async[bool] | None = None
    _v1 = None
    return value(_v1)


def closure9(unit_var: None, v0_1: bool) -> US4:
    return US4(0, v0_1)


def closure10(unit_var: None, v0_1: Exception) -> US4:
    return US4(1, v0_1)


def closure11(unit_var: None, unit_var_1: None) -> str:
    return "run_with_timeout_async"


def closure12(v0_1: int, unit_var: None) -> str:
    return ((("timeout: " + str(v0_1)) + " / ") + closure4(None, None)) + ""


def closure13(v0_1: str, unit_var: None) -> str:
    return ("run_with_timeout_async** / ex: " + v0_1) + ""


def closure8(v0_1: int, v1_1: int) -> Async[bool]:
    _v2: Async[bool] | None = None
    _v2 = None
    return value(_v2)


def closure7(unit_var: None, v0_1: int) -> Callable[[int], Async[bool]]:
    def _arrow94(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[bool]:
        return closure8(v0_1, v)

    return _arrow94


def closure17(unit_var: None, v0_1: int) -> US6:
    return US6(0, v0_1)


def method7(__unit: None=None) -> Callable[[int], US6]:
    def _arrow95(v: int) -> US6:
        return closure17(None, v)

    return _arrow95


def closure18(unit_var: None, unit_var_1: None) -> str:
    return "wait_for_port_access"


def closure19(v0_1: int, v1_1: int64, unit_var: None) -> str:
    return ((((("port: " + str(v0_1)) + " / retry: ") + str(v1_1)) + " / ") + closure4(None, None)) + ""


def method6(v0_1: int | None, v1_1: bool, v2_1: int, v3_1: int64) -> Async[int64]:
    _v4: Async[int64] | None = None
    _v4 = None
    return value(_v4)


def closure16(v0_1: int | None, v1_1: bool, v2_1: int) -> Async[int64]:
    return method6(v0_1, v1_1, v2_1, int64(0))


def closure15(v0_1: int | None, v1_1: bool) -> Callable[[int], Async[int64]]:
    def _arrow96(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[int64]:
        return closure16(v0_1, v1_1, v)

    return _arrow96


def closure14(unit_var: None, v0_1: int | None=None) -> Callable[[bool, int], Async[int64]]:
    def _arrow97(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[int64]]:
        return closure15(v0_1, v)

    return _arrow97


def method8(v0_1: int | None, v1_1: int) -> Async[int]:
    _v2: Async[int] | None = None
    _v2 = None
    return value(_v2)


def closure21(v0_1: int | None, v1_1: int) -> Async[int]:
    return method8(v0_1, v1_1)


def closure20(unit_var: None, v0_1: int | None=None) -> Callable[[int], Async[int]]:
    def _arrow98(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int]:
        return closure21(v0_1, v)

    return _arrow98


def _arrow99(__unit: None=None) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, None)


v0: Callable[[], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow99


if State_trace_state() is None:
    State_trace_state(v0(None))


def _arrow100(v: int) -> Async[bool]:
    return closure2(None, v)


v1: Callable[[int], Async[bool]] = _arrow100

def test_port_open(x: int) -> Async[bool]:
    return v1(x)


def _arrow101(v: int) -> Callable[[int], Async[bool]]:
    return closure7(None, v)


v2: Callable[[int, int], Async[bool]] = _arrow101

def test_port_open_timeout(x: int) -> Callable[[int], Async[bool]]:
    return v2(x)


def _arrow102(v: int | None=None) -> Callable[[bool, int], Async[int64]]:
    return closure14(None, v)


v3: Callable[[int | None, bool, int], Async[int64]] = _arrow102

def wait_for_port_access(x: int | None=None) -> Callable[[bool, int], Async[int64]]:
    return v3(x)


def _arrow103(v: int | None=None) -> Callable[[int], Async[int]]:
    return closure20(None, v)


v4: Callable[[int | None, int], Async[int]] = _arrow103

def get_available_port(x: int | None=None) -> Callable[[int], Async[int]]:
    return v4(x)


