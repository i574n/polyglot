from __future__ import annotations
from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.async_builder import CancellationToken
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type)
from fable_modules.fable_library.types import (Array, Union)
from fable_modules.fable_library.util import IDisposable

def _expr102() -> TypeInfo:
    return class_type("Threading.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr102

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


def _expr103() -> TypeInfo:
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


US0_reflection = _expr103

def closure1(unit_var: None, v0_1: CancellationToken) -> US0:
    return US0(0, v0_1)


def method0(__unit: None=None) -> Callable[[CancellationToken], US0]:
    def _arrow104(v: CancellationToken) -> US0:
        return closure1(None, v)

    return _arrow104


def closure2(v0_1: Any, unit_var: None) -> None:
    pass


def method1(v0_1: Any) -> Callable[[], None]:
    def _arrow105(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure2(v0_1, None)

    return _arrow105


def method2(v0_1: Any) -> Callable[[], None]:
    def _arrow106(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure2(v0_1, None)

    return _arrow106


def closure0(unit_var: None, v0_1: CancellationToken | None=None) -> tuple[CancellationToken, IDisposable]:
    pattern_input: tuple[CancellationToken, IDisposable] = None
    _run_target_args_0027_v1: tuple[CancellationToken, IDisposable] = (pattern_input[0], pattern_input[1])
    return (_run_target_args_0027_v1[0], _run_target_args_0027_v1[1])


def _arrow107(v: CancellationToken | None=None) -> tuple[CancellationToken, IDisposable]:
    return closure0(None, v)


v0: Callable[[CancellationToken | None], tuple[CancellationToken, IDisposable]] = _arrow107

def new_disposable_token(x: CancellationToken | None=None) -> tuple[CancellationToken, IDisposable]:
    return v0(x)


