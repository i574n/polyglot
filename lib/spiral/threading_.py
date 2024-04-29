from __future__ import annotations
from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.async_builder import CancellationToken
from fable_modules.fable_library.option import (some, value as value_1)
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type)
from fable_modules.fable_library.types import (Array, Union, FSharpRef)
from fable_modules.fable_library.util import IDisposable

def _expr65() -> TypeInfo:
    return class_type("Threading.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr65

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


def _expr66() -> TypeInfo:
    return union_type("Threading.US0", [], US0, lambda: [[("f0_0", class_type("System.Threading.CancellationToken"))], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1"]


US0_reflection = _expr66

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



def closure1(unit_var: None, v0_1: CancellationToken) -> US0:
    return US0(0, v0_1)


def method0(__unit: None=None) -> Callable[[CancellationToken], US0]:
    def _arrow67(v: CancellationToken) -> US0:
        return closure1(None, v)

    return _arrow67


def closure2(v0_1: Any, unit_var: None) -> None:
    _v1: None | None = None
    _v1 = some(None)
    value_1(_v1)


def method1(v0_1: Any) -> Callable[[], None]:
    def _arrow68(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure2(v0_1, None)

    return _arrow68


def closure0(unit_var: None, v0_1: CancellationToken | None=None) -> tuple[CancellationToken, IDisposable]:
    _v1: tuple[CancellationToken, IDisposable] | None = None
    pattern_input: tuple[CancellationToken, IDisposable] = None
    _v1 = (pattern_input[0], pattern_input[1])
    pattern_input_1: tuple[CancellationToken, IDisposable] = value_1(_v1)
    return (pattern_input_1[0], pattern_input_1[1])


def _arrow69(v: CancellationToken | None=None) -> tuple[CancellationToken, IDisposable]:
    return closure0(None, v)


v0: Callable[[CancellationToken | None], tuple[CancellationToken, IDisposable]] = _arrow69

def new_disposable_token(x: CancellationToken | None=None) -> tuple[CancellationToken, IDisposable]:
    return v0(x)


