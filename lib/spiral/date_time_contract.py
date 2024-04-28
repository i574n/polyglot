from __future__ import annotations
from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.date import (parse_exact, to_string)
from fable_modules.fable_library.guid import (parse, new_guid)
from fable_modules.fable_library.long import parse as parse_1
from fable_modules.fable_library.option import value as value_1
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, string_type)
from fable_modules.fable_library.string_ import (replace, pad_left)
from fable_modules.fable_library.types import (Array, Union, FSharpRef, int64)
from fable_modules.fable_library.util import int64_to_string

def _expr74() -> TypeInfo:
    return union_type("Date_time.US0", [], US0, lambda: [[("f0_0", class_type("Date_time.chrono_DateTime`1", [class_type("Date_time.chrono_Utc")]))], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1"]


US0_reflection = _expr74

def _expr75() -> TypeInfo:
    return union_type("Date_time.US1", [], US1, lambda: [[("f0_0", string_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr75

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



def closure2(unit_var: None, v0_1: chrono_DateTime_1[chrono_Utc]) -> US0:
    return US0(0, v0_1)


def method0(__unit: None=None) -> Callable[[chrono_DateTime_1[chrono_Utc]], US0]:
    def _arrow76(v: chrono_DateTime_1[chrono_Utc]) -> US0:
        return closure2(None, v)

    return _arrow76


def method1(v0_1: chrono_DateTime_1[chrono_Utc]) -> chrono_DateTime_1[chrono_Utc]:
    return v0_1


def method2(v0_1: chrono_DateTime_1[chrono_Local]) -> chrono_DateTime_1[chrono_Local]:
    return v0_1


def method3(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method4(__unit: None=None) -> str:
    return "hhmm"


def closure1(v0_1: str, v1_1: Any) -> str:
    v3_1: str = str(v0_1)
    _v4: tuple[str, str] | None = None
    pattern_input: tuple[str, str] = None
    _v4 = (pattern_input[0], pattern_input[1])
    pattern_input_1: tuple[str, str] = value_1(_v4)
    v138: str = pattern_input_1[1]
    v137: str = pattern_input_1[0]
    return parse(((((("" + v137) + "") + v138) + "") + v3_1[len(v137) + len(v138):len(v3_1)]) + "")


def closure0(unit_var: None, v0_1: str) -> Callable[[Any], str]:
    def _arrow77(v: Any, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure1(v0_1, v)

    return _arrow77


def closure6(v0_1: str, v1_1: str, v2_1: str) -> str:
    return replace(v2_1, v0_1, v1_1)


def closure5(v0_1: str, v1_1: str) -> Callable[[str], str]:
    def _arrow78(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure6(v0_1, v1_1, v)

    return _arrow78


def closure4(unit_var: None, v0_1: str) -> Callable[[str, str], str]:
    def _arrow79(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure5(v0_1, v)

    return _arrow79


def method5(__unit: None=None) -> Callable[[str, str, str], str]:
    def _arrow80(v: str) -> Callable[[str, str], str]:
        return closure4(None, v)

    return _arrow80


def closure3(unit_var: None, v0_1: str) -> Any:
    v2_1: str = str(v0_1)
    _v4: Any | None = None
    x: Any = parse_exact(method5()("-")("")(v2_1[:24 + 1]), "yyyyMMddHHmmssfffffff", None)
    _v4 = x
    return value_1(_v4)


def closure8(v0_1: str, v1_1: int64) -> str:
    v3_1: str = str(v0_1)
    v6_1: str = pad_left(int64_to_string(v1_1), 18, "0")
    return parse(((((((((("" + v6_1[0:7 + 1]) + "-") + v6_1[8:11 + 1]) + "-") + v6_1[12:15 + 1]) + "-") + v6_1[16:17 + 1]) + "") + v3_1[21:len(v3_1)]) + "")


def closure7(unit_var: None, v0_1: str) -> Callable[[int64], str]:
    def _arrow81(v: int64, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure8(v0_1, v)

    return _arrow81


def closure9(unit_var: None, v0_1: str) -> int64:
    v2_1: str = str(v0_1)
    return parse_1(((((((("" + v2_1[0:7 + 1]) + "") + v2_1[9:12 + 1]) + "") + v2_1[14:17 + 1]) + "") + v2_1[19:20 + 1]) + "", 511, False, 64)


def closure10(unit_var: None, v0_1: Any) -> str:
    v3_1: str = str(new_guid())
    _v4: tuple[str, str] | None = None
    pattern_input: tuple[str, str] = None
    _v4 = (pattern_input[0], pattern_input[1])
    pattern_input_1: tuple[str, str] = value_1(_v4)
    v138: str = pattern_input_1[1]
    v137: str = pattern_input_1[0]
    return parse(((((("" + v137) + "") + v138) + "") + v3_1[len(v137) + len(v138):len(v3_1)]) + "")


def closure11(unit_var: None, v0_1: int64) -> str:
    v3_1: str = str(new_guid())
    v6_1: str = pad_left(int64_to_string(v0_1), 18, "0")
    return parse(((((((((("" + v6_1[0:7 + 1]) + "-") + v6_1[8:11 + 1]) + "-") + v6_1[12:15 + 1]) + "-") + v6_1[16:17 + 1]) + "") + v3_1[21:len(v3_1)]) + "")


def closure13(v0_1: str, v1_1: Any) -> str:
    return to_string(v1_1, v0_1)


def closure12(unit_var: None, v0_1: str) -> Callable[[Any], str]:
    def _arrow82(v: Any, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure13(v0_1, v)

    return _arrow82


def closure14(unit_var: None, v0_1: Any) -> str:
    return to_string(v0_1, "yyyy-MM-ddTHH-mm-ss.fff")


def _arrow83(v: str) -> Callable[[Any], str]:
    return closure0(None, v)


v0: Callable[[str, Any], str] = _arrow83

def date_time_guid_from_date_time(x: str) -> Callable[[Any], str]:
    return v0(x)


def _arrow84(v: str) -> Any:
    return closure3(None, v)


v1: Callable[[str], Any] = _arrow84

def date_time_from_guid(x: str) -> Any:
    return v1(x)


def _arrow85(v: str) -> Callable[[int64], str]:
    return closure7(None, v)


v2: Callable[[str, int64], str] = _arrow85

def timestamp_guid_from_timestamp(x: str) -> Callable[[int64], str]:
    return v2(x)


def _arrow86(v: str) -> int64:
    return closure9(None, v)


v3: Callable[[str], int64] = _arrow86

def timestamp_from_guid(x: str) -> int64:
    return v3(x)


def _arrow87(v: Any) -> str:
    return closure10(None, v)


v4: Callable[[Any], str] = _arrow87

def new_guid_from_date_time(x: Any) -> str:
    return v4(x)


def _arrow88(v: int64) -> str:
    return closure11(None, v)


v5: Callable[[int64], str] = _arrow88

def new_guid_from_timestamp(x: int64) -> str:
    return v5(x)


def _arrow89(v: str) -> Callable[[Any], str]:
    return closure12(None, v)


v6: Callable[[str, Any], str] = _arrow89

def format(x: str) -> Callable[[Any], str]:
    return v6(x)


def _arrow90(v: Any) -> str:
    return closure14(None, v)


v7: Callable[[Any], str] = _arrow90

def format_iso8601(x: Any) -> str:
    return v7(x)


