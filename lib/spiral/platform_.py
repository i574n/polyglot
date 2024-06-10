from __future__ import annotations
from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.reflection import (TypeInfo, union_type)
from fable_modules.fable_library.types import (Array, Union, FSharpRef)

def _expr115() -> TypeInfo:
    return union_type("Platform.US0", [], US0, lambda: [[], [], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1", "US0_2"]


US0_reflection = _expr115

def _expr116() -> TypeInfo:
    return union_type("Platform.US1", [], US1, lambda: [[("f0_0", US0_reflection())], [("f1_0", US0_reflection())], [("f2_0", US0_reflection())], [("f3_0", US0_reflection())], [("f4_0", US0_reflection())]])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1", "US1_2", "US1_3", "US1_4"]


US1_reflection = _expr116

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



def US1__get_IsUS1_2(this: FSharpRef[US1], unit_arg: None) -> bool:
    if this.tag == 2:
        return True

    else: 
        return False



def US1__get_IsUS1_3(this: FSharpRef[US1], unit_arg: None) -> bool:
    if this.tag == 3:
        return True

    else: 
        return False



def US1__get_IsUS1_4(this: FSharpRef[US1], unit_arg: None) -> bool:
    if this.tag == 4:
        return True

    else: 
        return False



def closure0(unit_var: None, unit_var_1: None) -> bool:
    _v0: bool | None = None
    x: bool
    raise Exception(("platform.is_windows / target: " + str(US1(4, US0(0)))) + "")
    _v0 = x
    if _v0 is None:
        raise Exception("base.run_target / _v0=None")

    else: 
        return _v0



def closure1(unit_var: None, unit_var_1: None) -> str:
    _v0: bool | None = None
    x: bool
    raise Exception(("platform.is_windows / target: " + str(US1(4, US0(0)))) + "")
    _v0 = x
    def _arrow117(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> bool:
        raise Exception("base.run_target / _v0=None")

    if _arrow117() if (_v0 is None) else _v0:
        return ".exe"

    else: 
        return ""



def _arrow118(__unit: None=None) -> bool:
    return closure0(None, None)


v0: Callable[[], bool] = _arrow118

def is_windows(__unit: None=None) -> bool:
    return v0(None)


def _arrow119(__unit: None=None) -> str:
    return closure1(None, None)


v1: Callable[[], str] = _arrow119

def get_executable_suffix(__unit: None=None) -> str:
    return v1(None)


