from __future__ import annotations
from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.option import (value as value_1, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, string_type, union_type)
from fable_modules.fable_library.types import (Array, Union, FSharpRef)

def _expr67() -> TypeInfo:
    return union_type("File_system.US0", [], US0, lambda: [[("f0_0", string_type)], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1"]


US0_reflection = _expr67

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



def method0(v0_1: str) -> str:
    return v0_1


def closure0(unit_var: None, unit_var_1: None) -> str:
    _v0: str | None = None
    _v0 = None
    return value_1(_v0)


def closure3(unit_var: None, unit_var_1: None) -> str:
    return ""


def closure2(v0_1: str, v1_1: str, unit_var: None) -> str:
    return ((((("temp_folder: " + v0_1) + " / result: ") + v1_1) + " ") + closure3(None, None)) + ""


def closure1(unit_var: None, unit_var_1: None) -> str:
    _v0: str | None = None
    _v0 = None
    return value_1(_v0)


def closure4(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def closure8(unit_var: None, v0_1: str) -> bool:
    _v1: bool | None = None
    _v1 = None
    return value_1(_v1)


def closure9(unit_var: None, v0_1: str) -> bool:
    _v1: bool | None = None
    _v1 = None
    return value_1(_v1)


def closure10(unit_var: None, v0_1: str) -> str | None:
    _v1: US0 | None = None
    _v1 = None
    v37: US0 = value_1(_v1)
    if v37.tag == 0:
        return v37.fields[0]

    else: 
        return None



def method2(__unit: None=None) -> Callable[[str], str | None]:
    def _arrow68(v: str) -> str | None:
        return closure10(None, v)

    return _arrow68


def closure11(unit_var: None, v0_1: str) -> US0:
    return US0(0, v0_1)


def method3(__unit: None=None) -> Callable[[str], US0]:
    def _arrow69(v: str) -> US0:
        return closure11(None, v)

    return _arrow69


def method4(v0_1_mut: str, v1_1_mut: bool, v2_1_mut: str, v3_1_mut: str) -> str:
    while True:
        (v0_1, v1_1, v2_1, v3_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut)
        _v4: str | None = None
        _v4 = None
        def _arrow70(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1) -> bool:
            return closure8(None, v)

        def _arrow71(v_1: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1) -> bool:
            return closure9(None, v_1)

        if (_arrow70 if v1_1 else _arrow71)(value_1(_v4)):
            return v3_1

        else: 
            v34: str | None = method2()(v3_1)
            v37: US0 = default_arg(map(method3(), v34), US0(1))
            if v37.tag == 0:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v37.fields[0]
                continue

            else: 
                raise Exception(((((("No parent for " + ("file" if v1_1 else "dir")) + " \'") + v0_1) + "\' at \'") + v2_1) + "\'")


        break


def method1(v0_1: str, v1_1: bool, v2_1: str) -> str:
    _v3: str | None = None
    _v3 = None
    def _arrow72(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> bool:
        return closure8(None, v)

    def _arrow73(v_1: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> bool:
        return closure9(None, v_1)

    if (_arrow72 if v1_1 else _arrow73)(value_1(_v3)):
        return v2_1

    else: 
        v33: str | None = method2()(v2_1)
        v36: US0 = default_arg(map(method3(), v33), US0(1))
        if v36.tag == 0:
            return method4(v0_1, v1_1, v2_1, v36.fields[0])

        else: 
            raise Exception(((((("No parent for " + ("file" if v1_1 else "dir")) + " \'") + v0_1) + "\' at \'") + v2_1) + "\'")




def closure7(v0_1: str, v1_1: bool, v2_1: str) -> str:
    return method1(v0_1, v1_1, v2_1)


def closure6(v0_1: str, v1_1: bool) -> Callable[[str], str]:
    def _arrow74(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure7(v0_1, v1_1, v)

    return _arrow74


def closure5(unit_var: None, v0_1: str) -> Callable[[bool, str], str]:
    def _arrow75(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure6(v0_1, v)

    return _arrow75


def closure13(v0_1: str, v1_1: str) -> str:
    _v2: str | None = None
    _v2 = None
    return value_1(_v2)


def closure12(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow76(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure13(v0_1, v)

    return _arrow76


def _arrow77(__unit: None=None) -> str:
    return closure0(None, None)


v0: Callable[[], str] = _arrow77

def create_temp_directory_name(__unit: None=None) -> str:
    return v0(None)


def _arrow78(__unit: None=None) -> str:
    return closure1(None, None)


v1: Callable[[], str] = _arrow78

def create_temp_directory(__unit: None=None) -> str:
    return v1(None)


def _arrow79(__unit: None=None) -> str:
    return closure4(None, None)


v2: Callable[[], str] = _arrow79

def get_source_directory(__unit: None=None) -> str:
    return v2(None)


def _arrow80(v: str) -> Callable[[bool, str], str]:
    return closure5(None, v)


v3: Callable[[str, bool, str], str] = _arrow80

def find_parent(x: str) -> Callable[[bool, str], str]:
    return v3(x)


def _arrow81(v: str) -> Callable[[str], str]:
    return closure12(None, v)


v4: Callable[[str, str], str] = _arrow81

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v4(x)


