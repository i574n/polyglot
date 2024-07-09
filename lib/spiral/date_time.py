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

def _expr98() -> TypeInfo:
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


US0_reflection = _expr98

def _expr99() -> TypeInfo:
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


US1_reflection = _expr99

def _expr100() -> TypeInfo:
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


US2_reflection = _expr100

def _expr101() -> TypeInfo:
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


US3_reflection = _expr101

def method1(__unit: None=None) -> str:
    return "hh:mm"


def method2(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method3(__unit: None=None) -> str:
    return "hhmm"


def method0(v0: str, v1: Any) -> str:
    _v4: str | None = None
    v882: str = to_string(v1, method2())
    _v891: Any | None = None
    _v891 = None
    v931: Any
    if _v891 is None:
        raise Exception("base.run_target / _v891=None")

    else: 
        v931 = _v891

    _v948: Any | None = None
    x_2: Any
    raise Exception(("date_time.get_utc_offset / target: " + str(US3(4, US2(0)))) + "")
    _v948 = x_2
    v1047: Any
    if _v948 is None:
        raise Exception("base.run_target / _v948=None")

    else: 
        v1047 = _v948

    v1068: uint8 = uint8(1) if (hours(v1047) > 0) else uint8(0)
    v1069: str = method3()
    _v1072: str | None = None
    x_4: str = to_string_1(v1047, "c", {})
    _v1072 = x_4
    def _arrow102(__unit: None=None, v0: Any=v0, v1: Any=v1) -> str:
        raise Exception("base.run_target / _v1072=None")

    v1086: str = ((("" + str(v1068)) + "") + (_arrow102() if (_v1072 is None) else _v1072)) + ""
    v1090: str = str(v0)
    x_6: str = parse(((((("" + v882) + "") + v1086) + "") + v1090[len(v882) + len(v1086):len(v1090)]) + "")
    _v4 = x_6
    if _v4 is None:
        raise Exception("base.run_target / _v4=None")

    else: 
        return _v4



def closure1(v0: str, v1: Any) -> str:
    return method0(v0, v1)


def closure0(unit_var: None, v0: str) -> Callable[[Any], str]:
    def _arrow103(v: Any, unit_var: Any=unit_var, v0: Any=v0) -> str:
        return closure1(v0, v)

    return _arrow103


def closure5(v0: str, v1: str, v2: str) -> str:
    return replace(v2, v0, v1)


def closure4(v0: str, v1: str) -> Callable[[str], str]:
    def _arrow104(v: str, v0: Any=v0, v1: Any=v1) -> str:
        return closure5(v0, v1, v)

    return _arrow104


def closure3(unit_var: None, v0: str) -> Callable[[str, str], str]:
    def _arrow105(v: str, unit_var: Any=unit_var, v0: Any=v0) -> Callable[[str], str]:
        return closure4(v0, v)

    return _arrow105


def method4(__unit: None=None) -> Callable[[str, str, str], str]:
    def _arrow106(v: str) -> Callable[[str, str], str]:
        return closure3(None, v)

    return _arrow106


def closure2(unit_var: None, v0: str) -> Any:
    v4: str = str(v0)
    _v14: Any | None = None
    x: Any = parse_exact(method4()("-")("")(v4[:24 + 1]), "yyyyMMddHHmmssfffffff", None)
    _v14 = x
    if _v14 is None:
        raise Exception("base.run_target / _v14=None")

    else: 
        return _v14



def closure7(v0: str, v1: int64) -> str:
    v5: str = str(v0)
    v24: str = pad_left(int64_to_string(v1), 18, "0")
    return parse(((((((((("" + v24[0:7 + 1]) + "-") + v24[8:11 + 1]) + "-") + v24[12:15 + 1]) + "-") + v24[16:17 + 1]) + "") + v5[21:len(v5)]) + "")


def closure6(unit_var: None, v0: str) -> Callable[[int64], str]:
    def _arrow107(v: int64, unit_var: Any=unit_var, v0: Any=v0) -> str:
        return closure7(v0, v)

    return _arrow107


def closure8(unit_var: None, v0: str) -> int64:
    v4: str = str(v0)
    return parse_1(((((((("" + v4[0:7 + 1]) + "") + v4[9:12 + 1]) + "") + v4[14:17 + 1]) + "") + v4[19:20 + 1]) + "", 511, False, 64)


def closure9(unit_var: None, v0: Any) -> str:
    return method0(new_guid(), v0)


def closure10(unit_var: None, v0: int64) -> str:
    v14: str = str(new_guid())
    v33_1: str = pad_left(int64_to_string(v0), 18, "0")
    return parse(((((((((("" + v33_1[0:7 + 1]) + "-") + v33_1[8:11 + 1]) + "-") + v33_1[12:15 + 1]) + "-") + v33_1[16:17 + 1]) + "") + v14[21:len(v14)]) + "")


def closure12(v0: str, v1: Any) -> str:
    return to_string(v1, v0)


def closure11(unit_var: None, v0: str) -> Callable[[Any], str]:
    def _arrow108(v: Any, unit_var: Any=unit_var, v0: Any=v0) -> str:
        return closure12(v0, v)

    return _arrow108


def closure13(unit_var: None, v0: Any) -> str:
    return to_string(v0, "yyyy-MM-ddTHH-mm-ss.fff")


def _arrow109(v: str) -> Callable[[Any], str]:
    return closure0(None, v)


v30: Callable[[str, Any], str] = _arrow109

def date_time_guid_from_date_time(x: str) -> Callable[[Any], str]:
    return v30(x)


def _arrow110(v: str) -> Any:
    return closure2(None, v)


v31: Callable[[str], Any] = _arrow110

def date_time_from_guid(x: str) -> Any:
    return v31(x)


def _arrow111(v: str) -> Callable[[int64], str]:
    return closure6(None, v)


v32: Callable[[str, int64], str] = _arrow111

def timestamp_guid_from_timestamp(x: str) -> Callable[[int64], str]:
    return v32(x)


def _arrow112(v: str) -> int64:
    return closure8(None, v)


v33: Callable[[str], int64] = _arrow112

def timestamp_from_guid(x: str) -> int64:
    return v33(x)


def _arrow113(v: Any) -> str:
    return closure9(None, v)


v34: Callable[[Any], str] = _arrow113

def new_guid_from_date_time(x: Any) -> str:
    return v34(x)


def _arrow114(v: int64) -> str:
    return closure10(None, v)


v35: Callable[[int64], str] = _arrow114

def new_guid_from_timestamp(x: int64) -> str:
    return v35(x)


def _arrow115(v: str) -> Callable[[Any], str]:
    return closure11(None, v)


v36: Callable[[str, Any], str] = _arrow115

def format(x: str) -> Callable[[Any], str]:
    return v36(x)


def _arrow116(v: Any) -> str:
    return closure13(None, v)


v37: Callable[[Any], str] = _arrow116

def format_iso8601(x: Any) -> str:
    return v37(x)


