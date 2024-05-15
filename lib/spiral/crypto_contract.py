from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
from typing import (Any, Protocol)
from fable_modules.fable_library.option import value as value_1
from fable_modules.fable_library.reflection import (TypeInfo, int32_type, record_type)
from fable_modules.fable_library.types import Record

class ICryptoCreateHash(Protocol):
    @abstractmethod
    def create_hash(self, x: str) -> Any:
        ...


def _expr0() -> TypeInfo:
    return record_type("Crypto.Mut0", [], Mut0, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int

Mut0_reflection = _expr0

def method0(v0_1: int, v1: Mut0) -> bool:
    return v1.l0 < v0_1


def method1(__unit: None=None) -> str:
    return ""


def closure0(unit_var: None, v0_1: str) -> str:
    _v1: str | None = None
    _v1 = None
    return value_1(_v1)


def _arrow11(v: str) -> str:
    return closure0(None, v)


v0: Callable[[str], str] = _arrow11

def hash_text(x: str) -> str:
    return v0(x)


