from __future__ import annotations
from collections.abc import Callable
from typing import Any
from fable_modules.fable_library.date import (to_string, parse_exact)
from fable_modules.fable_library.guid import (parse, new_guid)
from fable_modules.fable_library.long import parse as parse_1
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, string_type)
from fable_modules.fable_library.string_ import (replace, pad_left)
from fable_modules.fable_library.time_span import (hours, to_string as to_string_1)
from fable_modules.fable_library.types import (Array, Union, FSharpRef, int64)
from fable_modules.fable_library.util import int64_to_string

def _expr92() -> TypeInfo:
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


US0_reflection = _expr92

def _expr93() -> TypeInfo:
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


US1_reflection = _expr93

def _expr94() -> TypeInfo:
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


US2_reflection = _expr94

def _expr95() -> TypeInfo:
    return union_type("Date_time.US3", [], US3, lambda: [[("f0_0", US2_reflection())], [("f1_0", US2_reflection())], [("f2_0", US2_reflection())], [("f3_0", US2_reflection())]])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1", "US3_2", "US3_3"]


US3_reflection = _expr95

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



def US2__get_IsUS2_0(this: FSharpRef[US2], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US2__get_IsUS2_1(this: FSharpRef[US2], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US2__get_IsUS2_2(this: FSharpRef[US2], unit_arg: None) -> bool:
    if this.tag == 2:
        return True

    else: 
        return False



def US3__get_IsUS3_0(this: FSharpRef[US3], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US3__get_IsUS3_1(this: FSharpRef[US3], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US3__get_IsUS3_2(this: FSharpRef[US3], unit_arg: None) -> bool:
    if this.tag == 2:
        return True

    else: 
        return False



def US3__get_IsUS3_3(this: FSharpRef[US3], unit_arg: None) -> bool:
    if this.tag == 3:
        return True

    else: 
        return False



def method1(v0_1: chrono_DateTime_1[chrono_Utc]) -> chrono_DateTime_1[chrono_Utc]:
    return v0_1


def method2(v0_1: chrono_DateTime_1[chrono_Local]) -> chrono_DateTime_1[chrono_Local]:
    return v0_1


def method3(__unit: None=None) -> str:
    return "hh:mm"


def method4(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method5(__unit: None=None) -> str:
    return "hhmm"


def method0(v0_1: str, v1_1: Any) -> str:
    _v2: str | None = None
    v260: str = to_string(v1_1, method4())
    _v261: Any | None = None
    _v261 = None
    v269: Any
    if _v261 is None:
        raise Exception("base.run_target / _v261=None")

    else: 
        v269 = _v261

    _v270: Any | None = None
    x_2: Any
    raise Exception(("date_time.get_utc_offset / target: " + str(US3(3, US2(0)))) + "")
    _v270 = x_2
    v297: Any
    if _v270 is None:
        raise Exception("base.run_target / _v270=None")

    else: 
        v297 = _v270

    v302: int = (hours(v297) > 0) or 0
    v303: str = method5()
    _v304: str | None = None
    x_4: str = to_string_1(v297, "c", {})
    _v304 = x_4
    def _arrow96(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        raise Exception("base.run_target / _v304=None")

    v312: str = ((("" + str(v302)) + "") + (_arrow96() if (_v304 is None) else _v304)) + ""
    v314: str = str(v0_1)
    x_6: str = parse(((((("" + v260) + "") + v312) + "") + v314[len(v260) + len(v312):len(v314)]) + "")
    _v2 = x_6
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure1(v0_1: str, v1_1: Any) -> str:
    return method0(v0_1, v1_1)


def closure0(unit_var: None, v0_1: str) -> Callable[[Any], str]:
    def _arrow97(v: Any, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure1(v0_1, v)

    return _arrow97


def closure5(v0_1: str, v1_1: str, v2_1: str) -> str:
    return replace(v2_1, v0_1, v1_1)


def closure4(v0_1: str, v1_1: str) -> Callable[[str], str]:
    def _arrow98(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure5(v0_1, v1_1, v)

    return _arrow98


def closure3(unit_var: None, v0_1: str) -> Callable[[str, str], str]:
    def _arrow99(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure4(v0_1, v)

    return _arrow99


def method6(__unit: None=None) -> Callable[[str, str, str], str]:
    def _arrow100(v: str) -> Callable[[str, str], str]:
        return closure3(None, v)

    return _arrow100


def closure2(unit_var: None, v0_1: str) -> Any:
    v2_1: str = str(v0_1)
    _v4: Any | None = None
    x: Any = parse_exact(method6()("-")("")(v2_1[:24 + 1]), "yyyyMMddHHmmssfffffff", None)
    _v4 = x
    if _v4 is None:
        raise Exception("base.run_target / _v4=None")

    else: 
        return _v4



def closure7(v0_1: str, v1_1: int64) -> str:
    v3_1: str = str(v0_1)
    v6_1: str = pad_left(int64_to_string(v1_1), 18, "0")
    return parse(((((((((("" + v6_1[0:7 + 1]) + "-") + v6_1[8:11 + 1]) + "-") + v6_1[12:15 + 1]) + "-") + v6_1[16:17 + 1]) + "") + v3_1[21:len(v3_1)]) + "")


def closure6(unit_var: None, v0_1: str) -> Callable[[int64], str]:
    def _arrow101(v: int64, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure7(v0_1, v)

    return _arrow101


def closure8(unit_var: None, v0_1: str) -> int64:
    v2_1: str = str(v0_1)
    return parse_1(((((((("" + v2_1[0:7 + 1]) + "") + v2_1[9:12 + 1]) + "") + v2_1[14:17 + 1]) + "") + v2_1[19:20 + 1]) + "", 511, False, 64)


def closure9(unit_var: None, v0_1: Any) -> str:
    return method0(new_guid(), v0_1)


def closure10(unit_var: None, v0_1: int64) -> str:
    v4_1: str = str(new_guid())
    v7_1: str = pad_left(int64_to_string(v0_1), 18, "0")
    return parse(((((((((("" + v7_1[0:7 + 1]) + "-") + v7_1[8:11 + 1]) + "-") + v7_1[12:15 + 1]) + "-") + v7_1[16:17 + 1]) + "") + v4_1[21:len(v4_1)]) + "")


def closure12(v0_1: str, v1_1: Any) -> str:
    return to_string(v1_1, v0_1)


def closure11(unit_var: None, v0_1: str) -> Callable[[Any], str]:
    def _arrow102(v: Any, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure12(v0_1, v)

    return _arrow102


def closure13(unit_var: None, v0_1: Any) -> str:
    return to_string(v0_1, "yyyy-MM-ddTHH-mm-ss.fff")


def _arrow103(v: str) -> Callable[[Any], str]:
    return closure0(None, v)


v0: Callable[[str, Any], str] = _arrow103

def date_time_guid_from_date_time(x: str) -> Callable[[Any], str]:
    return v0(x)


def _arrow104(v: str) -> Any:
    return closure2(None, v)


v1: Callable[[str], Any] = _arrow104

def date_time_from_guid(x: str) -> Any:
    return v1(x)


def _arrow105(v: str) -> Callable[[int64], str]:
    return closure6(None, v)


v2: Callable[[str, int64], str] = _arrow105

def timestamp_guid_from_timestamp(x: str) -> Callable[[int64], str]:
    return v2(x)


def _arrow106(v: str) -> int64:
    return closure8(None, v)


v3: Callable[[str], int64] = _arrow106

def timestamp_from_guid(x: str) -> int64:
    return v3(x)


def _arrow107(v: Any) -> str:
    return closure9(None, v)


v4: Callable[[Any], str] = _arrow107

def new_guid_from_date_time(x: Any) -> str:
    return v4(x)


def _arrow108(v: int64) -> str:
    return closure10(None, v)


v5: Callable[[int64], str] = _arrow108

def new_guid_from_timestamp(x: int64) -> str:
    return v5(x)


def _arrow109(v: str) -> Callable[[Any], str]:
    return closure11(None, v)


v6: Callable[[str, Any], str] = _arrow109

def format(x: str) -> Callable[[Any], str]:
    return v6(x)


def _arrow110(v: Any) -> str:
    return closure13(None, v)


v7: Callable[[Any], str] = _arrow110

def format_iso8601(x: Any) -> str:
    return v7(x)


