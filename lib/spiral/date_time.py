from __future__ import annotations
from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.date import (to_string, parse_exact)
from fable_modules.fable_library.guid import (parse, new_guid)
from fable_modules.fable_library.long import parse as parse_1
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, string_type)
from fable_modules.fable_library.string_ import (replace, pad_left)
from fable_modules.fable_library.time_span import (hours, to_string as to_string_1)
from fable_modules.fable_library.types import (Array, Union, FSharpRef, uint8, int64)
from fable_modules.fable_library.util import (ignore, int64_to_string)

def _expr93() -> TypeInfo:
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


US0_reflection = _expr93

def _expr94() -> TypeInfo:
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


US1_reflection = _expr94

def _expr95() -> TypeInfo:
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


US2_reflection = _expr95

def _expr96() -> TypeInfo:
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


US3_reflection = _expr96

def closure2(v0_1: FSharpRef[US0 | None], v1_1: US0 | None=None) -> FSharpRef[US0 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure3(v0_1: chrono_date_time_1[chrono_utc] | None, v1_1: Callable[[US0 | None], FSharpRef[US0 | None]], unit_var: None) -> None:
    def _arrow97(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US0 | None:
        x: chrono_date_time_1[chrono_utc] = v0_1
        def x_1(__unit: None=None) -> US0:
            return US0(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow97()))


def method1(__unit: None=None) -> str:
    return "hh:mm"


def method2(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method3(__unit: None=None) -> str:
    return "hhmm"


def method0(v0_1: str, v1_1: Any) -> str:
    v438: str = to_string(v1_1, method2())
    v507: Any
    raise Exception(("date_time.get_utc_offset / target: " + str(US3(4, US2(0)))) + "")
    v518: uint8 = uint8(1) if (hours(v507) > 0) else uint8(0)
    v519: str = method3()
    v530: str = ((("" + str(v518)) + "") + to_string_1(v507, "c", {})) + ""
    v532: str = str(v0_1)
    return parse(((((("" + v438) + "") + v530) + "") + v532[len(v438) + len(v530):len(v532)]) + "")


def closure1(v0_1: str, v1_1: Any) -> str:
    return method0(v0_1, v1_1)


def closure0(unit_var: None, v0_1: str) -> Callable[[Any], str]:
    def _arrow98(v: Any, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure1(v0_1, v)

    return _arrow98


def closure5(unit_var: None, v0_1: str) -> str:
    return replace(v0_1, "-", "")


def closure4(unit_var: None, v0_1: str) -> Any:
    v2_1: str = str(v0_1)
    return parse_exact(closure5(None, v2_1[:24 + 1]), "yyyyMMddHHmmssfffffff", None)


def closure7(v0_1: str, v1_1: int64) -> str:
    v3_1: str = str(v0_1)
    v10: str = pad_left(int64_to_string(v1_1), 18, "0")
    return parse(((((((((("" + v10[0:7 + 1]) + "-") + v10[8:11 + 1]) + "-") + v10[12:15 + 1]) + "-") + v10[16:17 + 1]) + "") + v3_1[21:len(v3_1)]) + "")


def closure6(unit_var: None, v0_1: str) -> Callable[[int64], str]:
    def _arrow99(v: int64, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure7(v0_1, v)

    return _arrow99


def closure8(unit_var: None, v0_1: str) -> int64:
    v2_1: str = str(v0_1)
    return parse_1(((((((("" + v2_1[0:7 + 1]) + "") + v2_1[9:12 + 1]) + "") + v2_1[14:17 + 1]) + "") + v2_1[19:20 + 1]) + "", 511, False, 64)


def closure9(unit_var: None, v0_1: Any) -> str:
    return method0(new_guid(), v0_1)


def closure10(unit_var: None, v0_1: int64) -> str:
    v6_1: str = str(new_guid())
    v13: str = pad_left(int64_to_string(v0_1), 18, "0")
    return parse(((((((((("" + v13[0:7 + 1]) + "-") + v13[8:11 + 1]) + "-") + v13[12:15 + 1]) + "-") + v13[16:17 + 1]) + "") + v6_1[21:len(v6_1)]) + "")


def closure12(v0_1: str, v1_1: Any) -> str:
    return to_string(v1_1, v0_1)


def closure11(unit_var: None, v0_1: str) -> Callable[[Any], str]:
    def _arrow100(v: Any, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure12(v0_1, v)

    return _arrow100


def closure13(unit_var: None, v0_1: Any) -> str:
    return to_string(v0_1, "yyyy-MM-ddTHH-mm-ss.fff")


def _arrow101(v: str) -> Callable[[Any], str]:
    return closure0(None, v)


v0: Callable[[str, Any], str] = _arrow101

def date_time_guid_from_date_time(x: str) -> Callable[[Any], str]:
    return v0(x)


def _arrow102(v: str) -> Any:
    return closure4(None, v)


v1: Callable[[str], Any] = _arrow102

def date_time_from_guid(x: str) -> Any:
    return v1(x)


def _arrow103(v: str) -> Callable[[int64], str]:
    return closure6(None, v)


v2: Callable[[str, int64], str] = _arrow103

def timestamp_guid_from_timestamp(x: str) -> Callable[[int64], str]:
    return v2(x)


def _arrow104(v: str) -> int64:
    return closure8(None, v)


v3: Callable[[str], int64] = _arrow104

def timestamp_from_guid(x: str) -> int64:
    return v3(x)


def _arrow105(v: Any) -> str:
    return closure9(None, v)


v4: Callable[[Any], str] = _arrow105

def new_guid_from_date_time(x: Any) -> str:
    return v4(x)


def _arrow106(v: int64) -> str:
    return closure10(None, v)


v5: Callable[[int64], str] = _arrow106

def new_guid_from_timestamp(x: int64) -> str:
    return v5(x)


def _arrow107(v: str) -> Callable[[Any], str]:
    return closure11(None, v)


v6: Callable[[str, Any], str] = _arrow107

def format(x: str) -> Callable[[Any], str]:
    return v6(x)


def _arrow108(v: Any) -> str:
    return closure13(None, v)


v7: Callable[[Any], str] = _arrow108

def format_iso8601(x: Any) -> str:
    return v7(x)


