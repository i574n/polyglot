from __future__ import annotations
from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.async_builder import CancellationToken
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type)
from fable_modules.fable_library.types import (Array, Union, FSharpRef)
from fable_modules.fable_library.util import (IDisposable, ignore)

def _expr31() -> TypeInfo:
    return class_type("Threading.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr31

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


def _expr36() -> TypeInfo:
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


US0_reflection = _expr36

def closure1(v0_1: FSharpRef[US0 | None], v1: US0 | None=None) -> FSharpRef[US0 | None]:
    v0_1.contents = v1
    return v0_1


def closure2(v0_1: CancellationToken | None, v1: Callable[[US0 | None], FSharpRef[US0 | None]], unit_var: None) -> None:
    def _arrow48(__unit: None=None, v0_1: Any=v0_1, v1: Any=v1, unit_var: Any=unit_var) -> US0 | None:
        x: CancellationToken = v0_1
        def x_1(__unit: None=None) -> US0:
            return US0(0, x)

        return x_1(None)

    ignore(v1(None if (v0_1 is None) else _arrow48()))


def closure3(v0_1: Any, unit_var: None) -> None:
    pass


def method0(v0_1: Any) -> Callable[[], None]:
    def _arrow50(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure3(v0_1, None)

    return _arrow50


def method1(v0_1: Any) -> Callable[[], None]:
    def _arrow51(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure3(v0_1, None)

    return _arrow51


def closure0(unit_var: None, v0_1: CancellationToken | None=None) -> tuple[CancellationToken, IDisposable]:
    pattern_input: tuple[CancellationToken, IDisposable] = None
    _v1: tuple[CancellationToken, IDisposable] = (pattern_input[0], pattern_input[1])
    return (_v1[0], _v1[1])


def _arrow52(v: CancellationToken | None=None) -> tuple[CancellationToken, IDisposable]:
    return closure0(None, v)


v0: Callable[[CancellationToken | None], tuple[CancellationToken, IDisposable]] = _arrow52

def new_disposable_token(x: CancellationToken | None=None) -> tuple[CancellationToken, IDisposable]:
    return v0(x)


