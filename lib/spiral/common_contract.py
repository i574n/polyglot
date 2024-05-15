from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from typing import Any
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_1)
from fable_modules.fable_library.reflection import (TypeInfo, class_type, int64_type, record_type, bool_type, union_type, string_type, unit_type, lambda_type)
from fable_modules.fable_library.string_ import (to_text, interpolate, pad_right, trim_end, trim_start)
from fable_modules.fable_library.types import (int64, Record, Array, Union, FSharpRef)
from fable_modules.fable_library.util import (create_atom, IDisposable, to_enumerable, compare)

State_trace_state: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] | None = create_atom(None)

def _expr25() -> TypeInfo:
    return class_type("Common.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr25

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


def _expr26() -> TypeInfo:
    return record_type("Common.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr26

def _expr27() -> TypeInfo:
    return record_type("Common.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr27

def _expr54() -> TypeInfo:
    return union_type("Common.US0", [], US0, lambda: [[], [], [], [], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1", "US0_2", "US0_3", "US0_4"]


US0_reflection = _expr54

def _expr56() -> TypeInfo:
    return record_type("Common.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr56

def _expr57() -> TypeInfo:
    return record_type("Common.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr57

def _expr58() -> TypeInfo:
    return union_type("Common.US1", [], US1, lambda: [[("f0_0", int64_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr58

def _expr59() -> TypeInfo:
    return union_type("Common.US2", [], US2, lambda: [[], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr59

def _expr60() -> TypeInfo:
    return union_type("Common.US3", [], US3, lambda: [[("f0_0", US2_reflection())], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr60

def _expr61() -> TypeInfo:
    return union_type("Common.US4", [], US4, lambda: [[("f0_0", int64_type)], []])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1"]


US4_reflection = _expr61

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
    return (v1_1, v0_1, v3, value_1(_v6), v5)


def method2(v0_1: Callable[[], None]) -> Callable[[], None]:
    return v0_1


def closure2(unit_var: None, v0_1: Callable[[], None]) -> IDisposable:
    _v1: IDisposable | None = None
    _v1 = None
    return value_1(_v1)


def closure5(v0_1: int, v1_1: Callable[[], None], v2_1: int, unit_var: None) -> US2:
    if v2_1 < v0_1:
        v1_1(None)
        return US2(0)

    else: 
        return US2(1)



def closure6(unit_var: None, v0_1: US2) -> US3:
    return US3(0, v0_1)


def closure8(unit_var: None, unit_var_1: None) -> str:
    return "retry_fn"


def closure10(unit_var: None, unit_var_1: None) -> str:
    return ""


def closure9(v0_1: int, v1_1: Exception, unit_var: None) -> str:
    return to_text(interpolate("retry: %P() / ex: %A%P() / %P()", [v0_1, v1_1, closure10(None, None)]))


def closure12(unit_var: None, v0_1: int64) -> US4:
    return US4(0, v0_1)


def method5(__unit: None=None) -> Callable[[int64], US4]:
    def _arrow62(v: int64) -> US4:
        return closure12(None, v)

    return _arrow62


def method6(__unit: None=None) -> str:
    return ""


def closure11(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, None))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_1(State_trace_state())
    _v9: str | None = None
    x: str = method6()
    _v9 = x
    v61: str = value_1(_v9)
    v62: int64 = pattern_input[0].l0
    v72: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    _v75: str | None = None
    x_1: str = pad_right(v72.lower(), 7, " ")
    _v75 = x_1
    return trim_end(trim_start(((((((((("" + v61) + " ") + value_1(_v75)) + " #") + str(v62)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method7(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
        return closure0(None, None)

    if State_trace_state() is None:
        State_trace_state(v2_1(None))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_1(State_trace_state())
    v3: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(None))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_1(State_trace_state())
    v13: US0 = pattern_input_1[2].l0
    class ObjectExpr63:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr64:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr63())) >= find(v13, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr64()))):
        v21: int64 = op_addition(v3.l0, int64(1))
        v3.l0 = v21
        v22: str = ("" + v1_1(None)) + ""
        _v23: None | None = None
        print(v22)
        _v23 = some(None)
        value_1(_v23)
        pattern_input[4].l0(v22)



def method4(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure11(v0_1, v1_1, v2_1, None)

    method7(v0_1, v3)


def closure7(v0_1: int, v1_1: Exception) -> US3:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure8(None, None)

    def v4(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure9(v0_1, v1_1, None)

    method4(US0(3), v3, v4)
    _v5: None | None = None
    _v5 = some(None)
    value_1(_v5)
    return US3(1)


def method3(v0_1_mut: int, v1_1_mut: Callable[[], None], v2_1_mut: int) -> US2:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        v6: US3
        try: 
            v6 = closure6(None, closure5(v0_1, v1_1, v2_1, None))

        except Exception as ex:
            v6 = closure7(v2_1, ex)

        if v6.tag == 0:
            return v6.fields[0]

        else: 
            v0_1_mut = v0_1
            v1_1_mut = v1_1
            v2_1_mut = v2_1 + 1
            continue

        break


def closure4(v0_1: int, v1_1: Callable[[], None]) -> None | None:
    v3: US2 = method3(v0_1, v1_1, 0)
    if v3.tag == 0:
        return some(None)

    else: 
        return None



def closure3(unit_var: None, v0_1: int) -> Callable[[Callable[[], None]], None | None]:
    def _arrow70(v: Callable[[], None], unit_var: Any=unit_var, v0_1: Any=v0_1) -> None | None:
        return closure4(v0_1, v)

    return _arrow70


def _arrow71(__unit: None=None) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, None)


v0: Callable[[], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow71


if State_trace_state() is None:
    State_trace_state(v0(None))


def _arrow72(v: Callable[[], None]) -> IDisposable:
    return closure2(None, v)


v1: Callable[[Callable[[], None]], IDisposable] = _arrow72

def new_disposable(x: Callable[[], None]) -> IDisposable:
    return v1(x)


def _arrow73(v: int) -> Callable[[Callable[[], None]], None | None]:
    return closure3(None, v)


v2: Callable[[int, Callable[[], None]], None | None] = _arrow73

def retry_fn(x: int) -> Callable[[Callable[[], None]], None | None]:
    return v2(x)


