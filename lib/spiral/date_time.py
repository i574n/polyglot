from __future__ import annotations
from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.date import (to_string, parse_exact)
from fable_modules.fable_library.guid import (parse, new_guid)
from fable_modules.fable_library.long import parse as parse_1
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, string_type)
from fable_modules.fable_library.string_ import (replace, pad_left)
from fable_modules.fable_library.time_span import (hours, to_string as to_string_1)
from fable_modules.fable_library.types import (Array, Union, uint8, int64)
from fable_modules.fable_library.util import int64_to_string

def _expr104() -> TypeInfo:
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


US0_reflection = _expr104

def _expr105() -> TypeInfo:
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


US1_reflection = _expr105

def _expr106() -> TypeInfo:
    return union_type("Date_time.US2", [], US2, lambda: [[], [], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1", "US2_2"]


US2_reflection = _expr106

def _expr107() -> TypeInfo:
    return union_type("Date_time.US3", [], US3, lambda: [[("f0_0", US2_reflection())], [("f1_0", US2_reflection())], [("f2_0", US2_reflection())], [("f3_0", US2_reflection())], [("f4_0", US2_reflection())]])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1", "US3_2", "US3_3", "US3_4"]


US3_reflection = _expr107

def closure2(unit_var: None, v0_1: chrono_date_time_1[chrono_utc]) -> US0:
    return US0(0, v0_1)


def method1(__unit: None=None) -> Callable[[chrono_date_time_1[chrono_utc]], US0]:
    def _arrow108(v: chrono_date_time_1[chrono_utc]) -> US0:
        return closure2(None, v)

    return _arrow108


def method2(__unit: None=None) -> str:
    return "hh:mm"


def method3(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method4(__unit: None=None) -> str:
    return "hhmm"


def method0(v0_1: str, v1_1: Any) -> str:
    v424: str = to_string(v1_1, method3())
    v493: Any
    raise Exception(("date_time.get_utc_offset / target: " + str(US3(4, US2(0)))) + "")
    v504: uint8 = uint8(1) if (hours(v493) > 0) else uint8(0)
    v505: str = method4()
    v516: str = ((("" + str(v504)) + "") + to_string_1(v493, "c", {})) + ""
    v518: str = str(v0_1)
    return parse(((((("" + v424) + "") + v516) + "") + v518[len(v424) + len(v516):len(v518)]) + "")


def closure1(v0_1: str, v1_1: Any) -> str:
    return method0(v0_1, v1_1)


def closure0(unit_var: None, v0_1: str) -> Callable[[Any], str]:
    def _arrow109(v: Any, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure1(v0_1, v)

    return _arrow109


def closure4(unit_var: None, v0_1: str) -> str:
    return replace(v0_1, "-", "")


def closure3(unit_var: None, v0_1: str) -> Any:
    v2_1: str = str(v0_1)
    return parse_exact(closure4(None, v2_1[:24 + 1]), "yyyyMMddHHmmssfffffff", None)


def closure6(v0_1: str, v1_1: int64) -> str:
    v3_1: str = str(v0_1)
    v10: str = pad_left(int64_to_string(v1_1), 18, "0")
    return parse(((((((((("" + v10[0:7 + 1]) + "-") + v10[8:11 + 1]) + "-") + v10[12:15 + 1]) + "-") + v10[16:17 + 1]) + "") + v3_1[21:len(v3_1)]) + "")


def closure5(unit_var: None, v0_1: str) -> Callable[[int64], str]:
    def _arrow110(v: int64, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure6(v0_1, v)

    return _arrow110


def closure7(unit_var: None, v0_1: str) -> int64:
    v2_1: str = str(v0_1)
    return parse_1(((((((("" + v2_1[0:7 + 1]) + "") + v2_1[9:12 + 1]) + "") + v2_1[14:17 + 1]) + "") + v2_1[19:20 + 1]) + "", 511, False, 64)


def closure8(unit_var: None, v0_1: Any) -> str:
    return method0(new_guid(), v0_1)


def closure9(unit_var: None, v0_1: int64) -> str:
    v6_1: str = str(new_guid())
    v13: str = pad_left(int64_to_string(v0_1), 18, "0")
    return parse(((((((((("" + v13[0:7 + 1]) + "-") + v13[8:11 + 1]) + "-") + v13[12:15 + 1]) + "-") + v13[16:17 + 1]) + "") + v6_1[21:len(v6_1)]) + "")


def closure11(v0_1: str, v1_1: Any) -> str:
    return to_string(v1_1, v0_1)


def closure10(unit_var: None, v0_1: str) -> Callable[[Any], str]:
    def _arrow111(v: Any, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure11(v0_1, v)

    return _arrow111


def closure12(unit_var: None, v0_1: Any) -> str:
    return to_string(v0_1, "yyyy-MM-ddTHH-mm-ss.fff")


def _arrow112(v: str) -> Callable[[Any], str]:
    return closure0(None, v)


v0: Callable[[str, Any], str] = _arrow112

def date_time_guid_from_date_time(x: str) -> Callable[[Any], str]:
    return v0(x)


def _arrow113(v: str) -> Any:
    return closure3(None, v)


v1: Callable[[str], Any] = _arrow113

def date_time_from_guid(x: str) -> Any:
    return v1(x)


def _arrow114(v: str) -> Callable[[int64], str]:
    return closure5(None, v)


v2: Callable[[str, int64], str] = _arrow114

def timestamp_guid_from_timestamp(x: str) -> Callable[[int64], str]:
    return v2(x)


def _arrow115(v: str) -> int64:
    return closure7(None, v)


v3: Callable[[str], int64] = _arrow115

def timestamp_from_guid(x: str) -> int64:
    return v3(x)


def _arrow116(v: Any) -> str:
    return closure8(None, v)


v4: Callable[[Any], str] = _arrow116

def new_guid_from_date_time(x: Any) -> str:
    return v4(x)


def _arrow117(v: int64) -> str:
    return closure9(None, v)


v5: Callable[[int64], str] = _arrow117

def new_guid_from_timestamp(x: int64) -> str:
    return v5(x)


def _arrow118(v: str) -> Callable[[Any], str]:
    return closure10(None, v)


v6: Callable[[str, Any], str] = _arrow118

def format(x: str) -> Callable[[Any], str]:
    return v6(x)


def _arrow119(v: Any) -> str:
    return closure12(None, v)


v7: Callable[[Any], str] = _arrow119

def format_iso8601(x: Any) -> str:
    return v7(x)


