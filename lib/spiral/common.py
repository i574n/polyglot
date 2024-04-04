from __future__ import annotations
from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.option import (value, some)
from fable_modules.fable_library.reflection import (TypeInfo, union_type)
from fable_modules.fable_library.types import (Array, Union, FSharpRef)
from fable_modules.fable_library.util import IDisposable

def _expr0() -> TypeInfo:
    return union_type("Common.US0", [], US0, lambda: [[], [], [], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1", "US0_2", "US0_3"]


US0_reflection = _expr0

def _expr1() -> TypeInfo:
    return union_type("Common.US1", [], US1, lambda: [[("f0_0", US0_reflection())], [("f1_0", US0_reflection())]])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr1

def _expr2() -> TypeInfo:
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


US2_reflection = _expr2

def _expr3() -> TypeInfo:
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


US3_reflection = _expr3

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



def closure0(unit_var: None, v0_1: Callable[[], None]) -> IDisposable:
    _v1: IDisposable | None = None
    class ObjectExpr4(IDisposable):
        def Dispose(self, __unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
            v0_1(None)

    x: IDisposable = ObjectExpr4()
    _v1 = x
    return value(_v1)


def closure3(v0_1: int, v1_1: Callable[[], None], v2: int, unit_var: None) -> US2:
    if v2 < v0_1:
        v1_1(None)
        return US2(0)

    else: 
        return US2(1)



def closure4(unit_var: None, v0_1: US2) -> US3:
    return US3(0, v0_1)


def closure5(unit_var: None, v0_1: Exception) -> None:
    _v1: None | None = None
    _v1 = some(None)
    value(_v1)


def method0(v0_1_mut: int, v1_1_mut: Callable[[], None], v2_mut: int) -> US2:
    while True:
        (v0_1, v1_1, v2) = (v0_1_mut, v1_1_mut, v2_mut)
        v7: US3
        try: 
            v7 = closure4(None, closure3(v0_1, v1_1, v2, None))

        except Exception as ex:
            closure5(None, ex)
            v7 = US3(1)

        if v7.tag == 0:
            return v7.fields[0]

        else: 
            v0_1_mut = v0_1
            v1_1_mut = v1_1
            v2_mut = v2 + 1
            continue

        break


def closure2(v0_1: int, v1_1: Callable[[], None]) -> None | None:
    v3: US2 = method0(v0_1, v1_1, 0)
    if v3.tag == 0:
        return some(None)

    else: 
        return None



def closure1(unit_var: None, v0_1: int) -> Callable[[Callable[[], None]], None | None]:
    def _arrow5(v: Callable[[], None], unit_var: Any=unit_var, v0_1: Any=v0_1) -> None | None:
        return closure2(v0_1, v)

    return _arrow5


def _arrow6(v: Callable[[], None]) -> IDisposable:
    return closure0(None, v)


v0: Callable[[Callable[[], None]], IDisposable] = _arrow6

def new_disposable(x: Callable[[], None]) -> IDisposable:
    return v0(x)


def _arrow7(v: int) -> Callable[[Callable[[], None]], None | None]:
    return closure1(None, v)


v1: Callable[[int, Callable[[], None]], None | None] = _arrow7

def retry_fn(x: int) -> Callable[[Callable[[], None]], None | None]:
    return v1(x)


