from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from typing import Any
from fable_modules.fable_library.async_builder import Async
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_1)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, bool_type, string_type, unit_type, lambda_type, class_type, int32_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, to_text, interpolate)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare)

State_trace_state: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] | None = create_atom(None)

def _expr89() -> TypeInfo:
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


US0_reflection = _expr89

def _expr90() -> TypeInfo:
    return record_type("Networking.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr90

def _expr91() -> TypeInfo:
    return record_type("Networking.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr91

def _expr92() -> TypeInfo:
    return record_type("Networking.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr92

def _expr93() -> TypeInfo:
    return record_type("Networking.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr93

def _expr94() -> TypeInfo:
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


US1_reflection = _expr94

def _expr95() -> TypeInfo:
    return union_type("Networking.US2", [], US2, lambda: [[("f0_0", bool_type)], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr95

def _expr96() -> TypeInfo:
    return union_type("Networking.US3", [], US3, lambda: [[("f0_0", bool_type)], [("f1_0", class_type("System.Exception"))]])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr96

def _expr97() -> TypeInfo:
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


US4_reflection = _expr97

def _expr98() -> TypeInfo:
    return union_type("Networking.US5", [], US5, lambda: [[("f0_0", int32_type)], []])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr98

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



def closure1(unit_var: None, v0_1: str) -> None:
    pass


def method0(__unit: None=None) -> str:
    return ""


def method1(__unit: None=None) -> str:
    return "AUTOMATION"


def closure0(unit_var: None, v0_1: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    v1_1: Mut1 = Mut1(True)
    v2_1: Mut0 = Mut0(int64(0))
    v3_1: Mut2 = Mut2(v0_1)
    def v4_1(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure1(None, v)

    v5_1: Mut3 = Mut3(v4_1)
    _v6: (int64 | None) | None = None
    _v6 = some(None)
    return (v2_1, v1_1, v3_1, value_1(_v6), v5_1)


def closure4(v0_1: int, v1_1: str, unit_var: None) -> str:
    return ((("networking.test_port_open / port: " + str(v0_1)) + " / ex: ") + v1_1) + ""


def closure5(unit_var: None, unit_var_1: None) -> str:
    return ""


def method3(__unit: None=None) -> str:
    return ""


def closure6(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_1(State_trace_state())
    _v10: str | None = None
    x: str = method3()
    _v10 = x
    v67: str = value_1(_v10)
    v68: int64 = pattern_input[0].l0
    v78: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    _v81: str | None = None
    x_1: str = pad_left(v78.lower(), 7, " ")
    _v81 = x_1
    return trim_end(trim_start(((((((((("" + v67) + " ") + value_1(_v81)) + " #") + str(v68)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method4(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(v: US0, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
        return closure0(None, v)

    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_1(State_trace_state())
    v4_1: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_1(State_trace_state())
    v15: US0 = pattern_input_1[2].l0
    class ObjectExpr99:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr100:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr99())) >= find(v15, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr100()))):
        v23: int64 = op_addition(v4_1.l0, int64(1))
        v4_1.l0 = v23
        v24: str = ("" + v1_1(None)) + ""
        _v25: None | None = None
        print(v24)
        _v25 = some(None)
        value_1(_v25)
        pattern_input[4].l0(v24)



def method2(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure6(v0_1, v1_1, v2_1, None)

    method4(v0_1, v3_1)


def closure3(v0_1: str, v1_1: int) -> Async[bool]:
    _v2: Async[bool] | None = None
    _v2 = None
    return value_1(_v2)


def closure2(unit_var: None, v0_1: str) -> Callable[[int], Async[bool]]:
    def _arrow101(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[bool]:
        return closure3(v0_1, v)

    return _arrow101


def closure10(unit_var: None, v0_1: bool) -> US3:
    return US3(0, v0_1)


def closure11(unit_var: None, v0_1: Exception) -> US3:
    return US3(1, v0_1)


def closure12(unit_var: None, unit_var_1: None) -> str:
    return "run_with_timeout_async"


def closure13(v0_1: int, unit_var: None) -> str:
    return ((("timeout: " + str(v0_1)) + " / ") + closure5(None, None)) + ""


def closure14(v0_1: str, unit_var: None) -> str:
    return ("run_with_timeout_async** / ex: " + v0_1) + ""


def closure9(v0_1: int, v1_1: str, v2_1: int) -> Async[bool]:
    _v3: Async[bool] | None = None
    _v3 = None
    return value_1(_v3)


def closure8(v0_1: int, v1_1: str) -> Callable[[int], Async[bool]]:
    def _arrow102(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[bool]:
        return closure9(v0_1, v1_1, v)

    return _arrow102


def closure7(unit_var: None, v0_1: int) -> Callable[[str, int], Async[bool]]:
    def _arrow103(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[bool]]:
        return closure8(v0_1, v)

    return _arrow103


def closure19(unit_var: None, unit_var_1: None) -> str:
    return "networking.wait_for_port_access"


def closure20(v0_1: int | None, v1_1: bool, v2_1: int, v3_1: int64, unit_var: None) -> str:
    return to_text(interpolate("port: %P() / retry: %P() / timeout: %A%P() / status: %P() / %P()", [v2_1, v3_1, v0_1, v1_1, closure5(None, None)]))


def method5(v0_1: int | None, v1_1: bool, v2_1: str, v3_1: int, v4_1: int64) -> Async[int64]:
    _v5: Async[int64] | None = None
    _v5 = None
    return value_1(_v5)


def closure18(v0_1: int | None, v1_1: bool, v2_1: str, v3_1: int) -> Async[int64]:
    return method5(v0_1, v1_1, v2_1, v3_1, int64(0))


def closure17(v0_1: int | None, v1_1: bool, v2_1: str) -> Callable[[int], Async[int64]]:
    def _arrow104(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> Async[int64]:
        return closure18(v0_1, v1_1, v2_1, v)

    return _arrow104


def closure16(v0_1: int | None, v1_1: bool) -> Callable[[str, int], Async[int64]]:
    def _arrow105(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Callable[[int], Async[int64]]:
        return closure17(v0_1, v1_1, v)

    return _arrow105


def closure15(unit_var: None, v0_1: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    def _arrow106(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str, int], Async[int64]]:
        return closure16(v0_1, v)

    return _arrow106


def method6(v0_1: int | None, v1_1: str, v2_1: int) -> Async[int]:
    _v3: Async[int] | None = None
    _v3 = None
    return value_1(_v3)


def closure23(v0_1: int | None, v1_1: str, v2_1: int) -> Async[int]:
    return method6(v0_1, v1_1, v2_1)


def closure22(v0_1: int | None, v1_1: str) -> Callable[[int], Async[int]]:
    def _arrow107(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[int]:
        return closure23(v0_1, v1_1, v)

    return _arrow107


def closure21(unit_var: None, v0_1: int | None=None) -> Callable[[str, int], Async[int]]:
    def _arrow108(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[int]]:
        return closure22(v0_1, v)

    return _arrow108


def _arrow109(v: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, v)


v0: Callable[[US0], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow109

v1: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v0(v1))


def _arrow110(v: str) -> Callable[[int], Async[bool]]:
    return closure2(None, v)


v2: Callable[[str, int], Async[bool]] = _arrow110

def test_port_open(x: str) -> Callable[[int], Async[bool]]:
    return v2(x)


def _arrow111(v: int) -> Callable[[str, int], Async[bool]]:
    return closure7(None, v)


v3: Callable[[int, str, int], Async[bool]] = _arrow111

def test_port_open_timeout(x: int) -> Callable[[str, int], Async[bool]]:
    return v3(x)


def _arrow112(v: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return closure15(None, v)


v4: Callable[[int | None, bool, str, int], Async[int64]] = _arrow112

def wait_for_port_access(x: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return v4(x)


def _arrow113(v: int | None=None) -> Callable[[str, int], Async[int]]:
    return closure21(None, v)


v5: Callable[[int | None, str, int], Async[int]] = _arrow113

def get_available_port(x: int | None=None) -> Callable[[str, int], Async[int]]:
    return v5(x)


