from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from typing import Any
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_1)
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, int64_type, record_type, bool_type, string_type, unit_type, lambda_type)
from fable_modules.fable_library.string_ import (to_text, interpolate, pad_left, trim_end, trim_start)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, IDisposable, to_enumerable, compare, Lazy)

State_trace_state: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] | None = create_atom(None)

def _expr24() -> TypeInfo:
    return class_type("Common.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr24

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


def _expr33() -> TypeInfo:
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


US0_reflection = _expr33

def _expr35() -> TypeInfo:
    return record_type("Common.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr35

def _expr37() -> TypeInfo:
    return record_type("Common.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr37

def _expr39() -> TypeInfo:
    return record_type("Common.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr39

def _expr43() -> TypeInfo:
    return record_type("Common.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr43

def _expr47() -> TypeInfo:
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


US1_reflection = _expr47

def _expr49() -> TypeInfo:
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


US2_reflection = _expr49

def _expr52() -> TypeInfo:
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


US3_reflection = _expr52

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

    v5: Mut3 = Mut3(v4_1)
    _v6: (int64 | None) | None = None
    _v6 = some(None)
    return (v2_1, v1_1, v3_1, value_1(_v6), v5)


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


def method5(__unit: None=None) -> str:
    return ""


def closure11(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_1(State_trace_state())
    _v10: str | None = None
    x: str = method5()
    _v10 = x
    v67: str = value_1(_v10)
    v68: int64 = pattern_input[0].l0
    v78: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    _v81: str | None = None
    x_1: str = pad_left(v78.lower(), 7, " ")
    _v81 = x_1
    return trim_end(trim_start(((((((((("" + v67) + " ") + value_1(_v81)) + " #") + str(v68)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method6(v0_1: US0, v1_1: Callable[[], str]) -> None:
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
    class ObjectExpr59:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr60:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr59())) >= find(v15, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr60()))):
        v23: int64 = op_addition(v4_1.l0, int64(1))
        v4_1.l0 = v23
        v24: str = ("" + v1_1(None)) + ""
        _v25: None | None = None
        print(v24)
        _v25 = some(None)
        value_1(_v25)
        pattern_input[4].l0(v24)



def method4(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure11(v0_1, v1_1, v2_1, None)

    method6(v0_1, v3_1)


def closure7(v0_1: int, v1_1: Exception) -> US3:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure8(None, None)

    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure9(v0_1, v1_1, None)

    method4(US0(3), v3_1, v4_1)
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
    v3_1: US2 = method3(v0_1, v1_1, 0)
    if v3_1.tag == 0:
        return some(None)

    else: 
        return None



def closure3(unit_var: None, v0_1: int) -> Callable[[Callable[[], None]], None | None]:
    def _arrow61(v: Callable[[], None], unit_var: Any=unit_var, v0_1: Any=v0_1) -> None | None:
        return closure4(v0_1, v)

    return _arrow61


def method7(v0_1: Callable[[], None]) -> Callable[[], None]:
    return v0_1


def closure13(v0_1: Any, unit_var: None) -> None:
    v0_1.Value


def closure12(unit_var: None, v0_1: Callable[[], None]) -> Callable[[], None]:
    v1_1: Callable[[], None] = method7(v0_1)
    def _arrow62(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        v1_1(None)

    v2_1: Any = Lazy(_arrow62)
    def _arrow63(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure13(v2_1, None)

    return _arrow63


def _arrow64(v: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, v)


v0: Callable[[US0], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow64

v1: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v0(v1))


def _arrow65(v: Callable[[], None]) -> IDisposable:
    return closure2(None, v)


v2: Callable[[Callable[[], None]], IDisposable] = _arrow65

def new_disposable(x: Callable[[], None]) -> IDisposable:
    return v2(x)


def _arrow66(v: int) -> Callable[[Callable[[], None]], None | None]:
    return closure3(None, v)


v3: Callable[[int, Callable[[], None]], None | None] = _arrow66

def retry_fn(x: int) -> Callable[[Callable[[], None]], None | None]:
    return v3(x)


def _arrow67(v: Callable[[], None]) -> Callable[[], None]:
    return closure12(None, v)


v4: Callable[[Callable[[], None], None], None] = _arrow67

def memoize(x: Callable[[], None]) -> Callable[[], None]:
    return v4(x)


