from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.reflection import (TypeInfo, union_type)
from fable_modules.fable_library.types import (Array, Union)

def _expr120() -> TypeInfo:
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


US0_reflection = _expr120

def _expr121() -> TypeInfo:
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


US1_reflection = _expr121

def closure0(unit_var: None, unit_var_1: None) -> bool:
    raise Exception(("platform.is_windows / target: " + str(US1(4, US0(0)))) + "")


def closure1(unit_var: None, unit_var_1: None) -> str:
    def _arrow122(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> bool:
        raise Exception(("platform.is_windows / target: " + str(US1(4, US0(0)))) + "")

    if _arrow122():
        return ".exe"

    else: 
        return ""



def _arrow123(__unit: None=None) -> bool:
    return closure0(None, None)


v0: Callable[[], bool] = _arrow123

def is_windows(__unit: None=None) -> bool:
    return v0(None)


def _arrow124(__unit: None=None) -> str:
    return closure1(None, None)


v1: Callable[[], str] = _arrow124

def get_executable_suffix(__unit: None=None) -> str:
    return v1(None)


