from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from typing import Any
from fable_modules.fable_library.async_builder import Async
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.option import (some, value)
from fable_modules.fable_library.reflection import (TypeInfo, int64_type, record_type, bool_type, union_type, class_type, int32_type)
from fable_modules.fable_library.string_ import (trim_end, trim_start)
from fable_modules.fable_library.types import (int64, Record, Array, Union, FSharpRef)
from fable_modules.fable_library.util import (create_atom, equals, compare)

State_trace_state: tuple[Mut0, Mut1, Mut1, Mut2, int64 | None] | None = create_atom(None)

def _expr70() -> TypeInfo:
    return record_type("Networking.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr70

def _expr71() -> TypeInfo:
    return record_type("Networking.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr71

def _expr72() -> TypeInfo:
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


US0_reflection = _expr72

def _expr73() -> TypeInfo:
    return record_type("Networking.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr73

def _expr74() -> TypeInfo:
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


US1_reflection = _expr74

def _expr75() -> TypeInfo:
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


US2_reflection = _expr75

def _expr76() -> TypeInfo:
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


US3_reflection = _expr76

def _expr77() -> TypeInfo:
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


US4_reflection = _expr77

def _expr78() -> TypeInfo:
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


US5_reflection = _expr78

def _expr79() -> TypeInfo:
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


US6_reflection = _expr79

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



def method0(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def method1(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def closure0(unit_var: None, unit_var_1: None) -> tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]:
    v0_1: Mut1 = Mut1(True)
    v1_1: Mut0 = Mut0(int64(0))
    v3_1: Mut2 = Mut2(US0(0))
    v4_1: Mut1 = Mut1(False)
    _v5: (int64 | None) | None = None
    x: int64 | None = method1(None)
    _v5 = some(x)
    return (v1_1, v4_1, v0_1, v3_1, value(_v5))


def closure2(v0_1: str, unit_var: None) -> str:
    return ("test_port_open / ex: " + v0_1) + ""


def closure3(unit_var: None, unit_var_1: None) -> str:
    return ""


def closure5(unit_var: None, v0_1: int64) -> US2:
    return US2(0, v0_1)


def method3(__unit: None=None) -> Callable[[int64], US2]:
    def _arrow80(v: int64) -> US2:
        return closure5(None, v)

    return _arrow80


def method4(__unit: None=None) -> str:
    return ""


def closure4(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
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
    return trim_end(trim_start(((((((((("" + v61) + " ") + value(_v74)) + " #") + str(v62)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method2(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]:
        return closure0(None, None)

    if equals(State_trace_state(), None):
        State_trace_state(v3_1(None))

    v4_1: Mut0 = value(State_trace_state())[0]
    if equals(State_trace_state(), None):
        State_trace_state(v3_1(None))

    pattern_input_1: tuple[Mut0, Mut1, Mut1, Mut2, int64 | None] = value(State_trace_state())
    v14: US0 = pattern_input_1[3].l0
    if (compare(v0_1, v14) >= 0) if pattern_input_1[2].l0 else False:
        v19: int64 = op_addition(v4_1.l0, int64(1))
        v4_1.l0 = v19
        v21: str = ("" + closure4(v0_1, v1_1, v2_1, None)) + ""
        _v22: None | None = None
        _v22 = some(None)
        value(_v22)



def closure1(unit_var: None, v0_1: int) -> Async[bool]:
    _v1: Async[bool] | None = None
    _v1 = None
    return value(_v1)


def closure8(unit_var: None, v0_1: bool) -> US4:
    return US4(0, v0_1)


def closure9(unit_var: None, v0_1: Exception) -> US4:
    return US4(1, v0_1)


def closure10(unit_var: None, unit_var_1: None) -> str:
    return "run_with_timeout_async"


def closure11(v0_1: int, unit_var: None) -> str:
    return ((("timeout: " + str(v0_1)) + " / ") + closure3(None, None)) + ""


def closure12(v0_1: str, unit_var: None) -> str:
    return ("run_with_timeout_async** / ex: " + v0_1) + ""


def closure7(v0_1: int, v1_1: int) -> Async[bool]:
    _v2: Async[bool] | None = None
    _v2 = None
    return value(_v2)


def closure6(unit_var: None, v0_1: int) -> Callable[[int], Async[bool]]:
    def _arrow81(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[bool]:
        return closure7(v0_1, v)

    return _arrow81


def closure16(unit_var: None, v0_1: int) -> US6:
    return US6(0, v0_1)


def method6(__unit: None=None) -> Callable[[int], US6]:
    def _arrow82(v: int) -> US6:
        return closure16(None, v)

    return _arrow82


def closure17(unit_var: None, unit_var_1: None) -> str:
    return "wait_for_port_access"


def closure18(v0_1: int, v1_1: int64, unit_var: None) -> str:
    return ((((("port: " + str(v0_1)) + " / retry: ") + str(v1_1)) + " / ") + closure3(None, None)) + ""


def method5(v0_1: int | None, v1_1: bool, v2_1: int, v3_1: int64) -> Async[int64]:
    _v4: Async[int64] | None = None
    _v4 = None
    return value(_v4)


def closure15(v0_1: int | None, v1_1: bool, v2_1: int) -> Async[int64]:
    return method5(v0_1, v1_1, v2_1, int64(0))


def closure14(v0_1: int | None, v1_1: bool) -> Callable[[int], Async[int64]]:
    def _arrow83(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[int64]:
        return closure15(v0_1, v1_1, v)

    return _arrow83


def closure13(unit_var: None, v0_1: int | None=None) -> Callable[[bool, int], Async[int64]]:
    def _arrow84(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[int64]]:
        return closure14(v0_1, v)

    return _arrow84


def method7(v0_1: int | None, v1_1: int) -> Async[int]:
    _v2: Async[int] | None = None
    _v2 = None
    return value(_v2)


def closure20(v0_1: int | None, v1_1: int) -> Async[int]:
    return method7(v0_1, v1_1)


def closure19(unit_var: None, v0_1: int | None=None) -> Callable[[int], Async[int]]:
    def _arrow85(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int]:
        return closure20(v0_1, v)

    return _arrow85


def _arrow86(__unit: None=None) -> tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]:
    return closure0(None, None)


v0: Callable[[], tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]] = _arrow86


if equals(State_trace_state(), None):
    State_trace_state(v0(None))


def _arrow87(v: int) -> Async[bool]:
    return closure1(None, v)


v1: Callable[[int], Async[bool]] = _arrow87

def test_port_open(x: int) -> Async[bool]:
    return v1(x)


def _arrow88(v: int) -> Callable[[int], Async[bool]]:
    return closure6(None, v)


v2: Callable[[int, int], Async[bool]] = _arrow88

def test_port_open_timeout(x: int) -> Callable[[int], Async[bool]]:
    return v2(x)


def _arrow89(v: int | None=None) -> Callable[[bool, int], Async[int64]]:
    return closure13(None, v)


v3: Callable[[int | None, bool, int], Async[int64]] = _arrow89

def wait_for_port_access(x: int | None=None) -> Callable[[bool, int], Async[int64]]:
    return v3(x)


def _arrow90(v: int | None=None) -> Callable[[int], Async[int]]:
    return closure19(None, v)


v4: Callable[[int | None, int], Async[int]] = _arrow90

def get_available_port(x: int | None=None) -> Callable[[int], Async[int]]:
    return v4(x)


