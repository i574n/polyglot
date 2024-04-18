from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.date import (to_string, min_value)
from fable_modules.fable_library.guid import (parse, new_guid)
from fable_modules.fable_library.long import parse as parse_1
from fable_modules.fable_library.option import value
from fable_modules.fable_library.string_ import (replace, pad_left)
from fable_modules.fable_library.types import int64
from fable_modules.fable_library.util import int64_to_string

def closure1(v0_1: str, v1_1: Any) -> str:
    v3_1: str = str(v0_1)
    v4_1: str = to_string(v1_1, "yyyyMMdd-HHmm-ssff-ffff-f")
    return parse(((("" + v4_1) + "") + v3_1[len(v4_1):len(v3_1)]) + "")


def closure0(unit_var: None, v0_1: str) -> Callable[[Any], str]:
    def _arrow53(v: Any, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure1(v0_1, v)

    return _arrow53


def closure5(v0_1: str, v1_1: str, v2_1: str) -> str:
    return replace(v2_1, v0_1, v1_1)


def closure4(v0_1: str, v1_1: str) -> Callable[[str], str]:
    def _arrow54(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure5(v0_1, v1_1, v)

    return _arrow54


def closure3(unit_var: None, v0_1: str) -> Callable[[str, str], str]:
    def _arrow55(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure4(v0_1, v)

    return _arrow55


def method0(__unit: None=None) -> Callable[[str, str, str], str]:
    def _arrow56(v: str) -> Callable[[str, str], str]:
        return closure3(None, v)

    return _arrow56


def closure2(unit_var: None, v0_1: str) -> Any:
    v2_1: str = str(v0_1)
    v3_1: Callable[[str, str, str], str] = method0()
    _v4: Any | None = None
    x: Any = min_value()
    _v4 = x
    return value(_v4)


def closure7(v0_1: str, v1_1: int64) -> str:
    v3_1: str = str(v0_1)
    v6_1: str = pad_left(int64_to_string(v1_1), 18, "0")
    return parse(((((((((("" + v6_1[0:7 + 1]) + "-") + v6_1[8:11 + 1]) + "-") + v6_1[12:15 + 1]) + "-") + v6_1[16:17 + 1]) + "") + v3_1[21:len(v3_1)]) + "")


def closure6(unit_var: None, v0_1: str) -> Callable[[int64], str]:
    def _arrow57(v: int64, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure7(v0_1, v)

    return _arrow57


def closure8(unit_var: None, v0_1: str) -> int64:
    v2_1: str = str(v0_1)
    return parse_1(((((((("" + v2_1[0:7 + 1]) + "") + v2_1[9:12 + 1]) + "") + v2_1[14:17 + 1]) + "") + v2_1[19:20 + 1]) + "", 511, False, 64)


def closure9(unit_var: None, v0_1: Any) -> str:
    v3_1: str = str(new_guid())
    v4_1: str = to_string(v0_1, "yyyyMMdd-HHmm-ssff-ffff-f")
    return parse(((("" + v4_1) + "") + v3_1[len(v4_1):len(v3_1)]) + "")


def closure10(unit_var: None, v0_1: int64) -> str:
    v3_1: str = str(new_guid())
    v6_1: str = pad_left(int64_to_string(v0_1), 18, "0")
    return parse(((((((((("" + v6_1[0:7 + 1]) + "-") + v6_1[8:11 + 1]) + "-") + v6_1[12:15 + 1]) + "-") + v6_1[16:17 + 1]) + "") + v3_1[21:len(v3_1)]) + "")


def closure12(v0_1: str, v1_1: Any) -> str:
    return to_string(v1_1, v0_1)


def closure11(unit_var: None, v0_1: str) -> Callable[[Any], str]:
    def _arrow58(v: Any, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure12(v0_1, v)

    return _arrow58


def closure13(unit_var: None, v0_1: Any) -> str:
    return to_string(v0_1, "yyyy-MM-ddTHH-mm-ss.fff")


def _arrow59(v: str) -> Callable[[Any], str]:
    return closure0(None, v)


v0: Callable[[str, Any], str] = _arrow59

def date_time_guid_from_date_time(x: str) -> Callable[[Any], str]:
    return v0(x)


def _arrow60(v: str) -> Any:
    return closure2(None, v)


v1: Callable[[str], Any] = _arrow60

def date_time_from_guid(x: str) -> Any:
    return v1(x)


def _arrow61(v: str) -> Callable[[int64], str]:
    return closure6(None, v)


v2: Callable[[str, int64], str] = _arrow61

def timestamp_guid_from_timestamp(x: str) -> Callable[[int64], str]:
    return v2(x)


def _arrow62(v: str) -> int64:
    return closure8(None, v)


v3: Callable[[str], int64] = _arrow62

def timestamp_from_guid(x: str) -> int64:
    return v3(x)


def _arrow63(v: Any) -> str:
    return closure9(None, v)


v4: Callable[[Any], str] = _arrow63

def new_guid_from_date_time(x: Any) -> str:
    return v4(x)


def _arrow64(v: int64) -> str:
    return closure10(None, v)


v5: Callable[[int64], str] = _arrow64

def new_guid_from_timestamp(x: int64) -> str:
    return v5(x)


def _arrow65(v: str) -> Callable[[Any], str]:
    return closure11(None, v)


v6: Callable[[str, Any], str] = _arrow65

def format(x: str) -> Callable[[Any], str]:
    return v6(x)


def _arrow66(v: Any) -> str:
    return closure13(None, v)


v7: Callable[[Any], str] = _arrow66

def format_iso8601(x: Any) -> str:
    return v7(x)


