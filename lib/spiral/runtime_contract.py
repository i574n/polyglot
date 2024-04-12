from collections.abc import Callable
from fable_modules.fable_library.option import value

def closure0(unit_var: None, unit_var_1: None) -> bool:
    _v0: bool | None = None
    _v0 = False
    return value(_v0)


def closure1(unit_var: None, unit_var_1: None) -> str:
    _v0: bool | None = None
    _v0 = False
    if value(_v0):
        return ".exe"

    else: 
        return ""



def _arrow53(__unit: None=None) -> bool:
    return closure0(None, None)


v0: Callable[[], bool] = _arrow53

def is_windows(__unit: None=None) -> bool:
    return v0(None)


def _arrow54(__unit: None=None) -> str:
    return closure1(None, None)


v1: Callable[[], str] = _arrow54

def get_executable_suffix(__unit: None=None) -> str:
    return v1(None)


