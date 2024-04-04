from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from math import (ceil, floor)
from typing import Any
from fable_modules.fable_library.array_ import fill
from fable_modules.fable_library.double import divide
from fable_modules.fable_library.long import (from_integer, to_number, from_number, op_subtraction, to_int)
from fable_modules.fable_library.option import value as value_2
from fable_modules.fable_library.reflection import (TypeInfo, int32_type, string_type, record_type)
from fable_modules.fable_library.seq import of_array
from fable_modules.fable_library.string_ import (ends_with as ends_with_1, pad_left as pad_left_1, pad_right as pad_right_1, replace as replace_1, split as split_1, join, substring as substring_1, trim_end as trim_end_1, trim_start as trim_start_1, to_text, interpolate)
from fable_modules.fable_library.types import (Record, Array, int64)
from fable_modules.fable_library.util import IEnumerable_1

def _expr22() -> TypeInfo:
    return record_type("Sm.Mut0", [], Mut0, lambda: [("l0", int32_type), ("l1", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int
    l1: str

Mut0_reflection = _expr22

def _expr23() -> TypeInfo:
    return record_type("Sm.Mut1", [], Mut1, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: int

Mut1_reflection = _expr23

def closure1(v0_1: str, v1_1: str) -> bool:
    return v1_1.find(v0_1) >= 0


def closure0(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow24(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure1(v0_1, v)

    return _arrow24


def closure3(v0_1: str, v1_1: str) -> bool:
    return ends_with_1(v1_1, v0_1)


def closure2(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow25(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure3(v0_1, v)

    return _arrow25


def closure6(v0_1: int, v1_1: str, v2_1: str) -> str:
    return pad_left_1(v2_1, v0_1, v1_1)


def closure5(v0_1: int, v1_1: str) -> Callable[[str], str]:
    def _arrow26(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure6(v0_1, v1_1, v)

    return _arrow26


def closure4(unit_var: None, v0_1: int) -> Callable[[str, str], str]:
    def _arrow27(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure5(v0_1, v)

    return _arrow27


def closure8(v0_1: int, v1_1: str) -> str:
    return pad_right_1(v1_1, v0_1)


def closure7(unit_var: None, v0_1: int) -> Callable[[str], str]:
    def _arrow28(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure8(v0_1, v)

    return _arrow28


def closure11(v0_1: str, v1_1: str, v2_1: str) -> str:
    return replace_1(v2_1, v0_1, v1_1)


def closure10(v0_1: str, v1_1: str) -> Callable[[str], str]:
    def _arrow29(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure11(v0_1, v1_1, v)

    return _arrow29


def closure9(unit_var: None, v0_1: str) -> Callable[[str, str], str]:
    def _arrow30(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure10(v0_1, v)

    return _arrow30


def closure14(v0_1: int, v1_1: int, v2_1: str) -> str:
    return v2_1[v0_1:v1_1 + 1]


def closure13(v0_1: int, v1_1: int) -> Callable[[str], str]:
    def _arrow31(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure14(v0_1, v1_1, v)

    return _arrow31


def closure12(unit_var: None, v0_1: int) -> Callable[[int, str], str]:
    def _arrow32(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure13(v0_1, v)

    return _arrow32


def closure16(v0_1: str, v1_1: str) -> Array[str]:
    return split_1(v1_1, [v0_1], None, 0)


def closure15(unit_var: None, v0_1: str) -> Callable[[str], Array[str]]:
    def _arrow33(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Array[str]:
        return closure16(v0_1, v)

    return _arrow33


def method0(__unit: None=None) -> str:
    return ""


def closure18(v0_1: Array[str], v1_1: str) -> Array[str]:
    _v2: Array[str] | None = None
    v20_1: IEnumerable_1[str] = of_array(v0_1)
    x: Array[str] = split_1(v1_1, [join(method0(), v20_1)], None, 0)
    _v2 = x
    return value_2(_v2)


def closure17(unit_var: None, v0_1: Array[str]) -> Callable[[str], Array[str]]:
    def _arrow34(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Array[str]:
        return closure18(v0_1, v)

    return _arrow34


def closure20(v0_1: str, v1_1: str) -> bool:
    return v1_1.find(v0_1) == 0


def closure19(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow35(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure20(v0_1, v)

    return _arrow35


def closure23(v0_1: int, v1_1: int, v2_1: str) -> str:
    return substring_1(v2_1, v0_1, v1_1)


def closure22(v0_1: int, v1_1: int) -> Callable[[str], str]:
    def _arrow36(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure23(v0_1, v1_1, v)

    return _arrow36


def closure21(unit_var: None, v0_1: int) -> Callable[[int, str], str]:
    def _arrow37(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure22(v0_1, v)

    return _arrow37


def closure24(unit_var: None, v0_1: str) -> str:
    return v0_1.lower()


def closure25(unit_var: None, v0_1: str) -> str:
    return v0_1.upper()


def closure26(unit_var: None, v0_1: str) -> str:
    return v0_1.strip()


def closure28(v0_1: Array[str], v1_1: str) -> str:
    return trim_end_1(v1_1, *v0_1)


def closure27(unit_var: None, v0_1: Array[str]) -> Callable[[str], str]:
    def _arrow38(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure28(v0_1, v)

    return _arrow38


def closure30(v0_1: Array[str], v1_1: str) -> str:
    return trim_start_1(v1_1, *v0_1)


def closure29(unit_var: None, v0_1: Array[str]) -> Callable[[str], str]:
    def _arrow39(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure30(v0_1, v)

    return _arrow39


def closure32(v0_1: int, v1_1: str) -> str:
    if len(v1_1) <= v0_1:
        return v1_1

    else: 
        v4_1: int = (v0_1 - 1) or 0
        return v1_1[0:v4_1 + 1] + "..."



def closure31(unit_var: None, v0_1: int) -> Callable[[str], str]:
    def _arrow40(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure32(v0_1, v)

    return _arrow40


def closure34(v0_1: int64, v1_1: str) -> str:
    v2_1: int64 = from_integer(len(v1_1), False, 2)
    if v2_1 <= v0_1:
        return v1_1

    else: 
        v5_1: float = divide(to_number(v0_1), 2.0)
        v8_1: int64 = from_number(ceil(v5_1), False)
        v11_1: int64 = from_number(floor(v5_1), False)
        v12_1: int64 = op_subtraction(v8_1, int64(1))
        v13_1: str = v1_1[int(to_int(int64(0))):int(to_int(v12_1)) + 1]
        v14_1: int64 = op_subtraction(v2_1, v11_1)
        v15_1: int64 = op_subtraction(v2_1, int64(1))
        return join("", of_array([v13_1, "...", v1_1[int(to_int(v14_1)):int(to_int(v15_1)) + 1]]))



def closure33(unit_var: None, v0_1: int64) -> Callable[[str], str]:
    def _arrow41(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure34(v0_1, v)

    return _arrow41


def closure35(unit_var: None, v0_1: Exception) -> str:
    _v1: str | None = None
    x: str = to_text(interpolate("%A%P()", [v0_1]))
    _v1 = x
    return value_2(_v1)


def method1(v0_1: int, v1_1: Mut0) -> bool:
    return v1_1.l0 < v0_1


def closure37(v0_1: str, v1_1: Array[str]) -> str:
    v2_1: int = len(v1_1) or 0
    v4_1: Mut0 = Mut0(0, "")
    while method1(v2_1, v4_1):
        v6_1: int = v4_1.l0 or 0
        v9_1: str = ((v4_1.l1 + v1_1[v6_1]) + v0_1) + ""
        v10_1: int = (v6_1 + 1) or 0
        v4_1.l0 = v10_1 or 0
        v4_1.l1 = v9_1
    return v4_1.l1


def closure36(unit_var: None, v0_1: str) -> Callable[[Array[str]], str]:
    def _arrow42(v: Array[str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure37(v0_1, v)

    return _arrow42


def closure39(v0_1: str, v1_1: IEnumerable_1[str]) -> str:
    return join(v0_1, v1_1)


def closure38(unit_var: None, v0_1: str) -> Callable[[IEnumerable_1[str]], str]:
    def _arrow43(v: IEnumerable_1[str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure39(v0_1, v)

    return _arrow43


def closure41(v0_1: str, v1_1: Array[str]) -> str:
    return join(v0_1, v1_1)


def closure40(unit_var: None, v0_1: str) -> Callable[[Array[str]], str]:
    def _arrow44(v: Array[str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure41(v0_1, v)

    return _arrow44


def method2(v0_1: int, v1_1: Mut1) -> bool:
    return v1_1.l0 < v0_1


def closure42(unit_var: None, v0_1: str) -> Array[str]:
    v1_1: int = len(v0_1) or 0
    v2_1: Array[str] = fill([0] * v1_1, 0, v1_1, "")
    v3_1: Mut1 = Mut1(0)
    while method2(v1_1, v3_1):
        v5_1: int = v3_1.l0 or 0
        v6_1: str = v0_1[v5_1]
        v2_1[v5_1] = v6_1
        v7_1: int = (v5_1 + 1) or 0
        v3_1.l0 = v7_1 or 0
    return v2_1


def _arrow45(v: str) -> Callable[[str], bool]:
    return closure0(None, v)


v0: Callable[[str, str], bool] = _arrow45

def contains(x: str) -> Callable[[str], bool]:
    return v0(x)


def _arrow46(v: str) -> Callable[[str], bool]:
    return closure2(None, v)


v1: Callable[[str, str], bool] = _arrow46

def ends_with(x: str) -> Callable[[str], bool]:
    return v1(x)


def _arrow47(v: int) -> Callable[[str, str], str]:
    return closure4(None, v)


v2: Callable[[int, str, str], str] = _arrow47

def pad_left(x: int) -> Callable[[str, str], str]:
    return v2(x)


def _arrow48(v: int) -> Callable[[str], str]:
    return closure7(None, v)


v3: Callable[[int, str], str] = _arrow48

def pad_right(x: int) -> Callable[[str], str]:
    return v3(x)


def _arrow49(v: str) -> Callable[[str, str], str]:
    return closure9(None, v)


v4: Callable[[str, str, str], str] = _arrow49

def replace(x: str) -> Callable[[str, str], str]:
    return v4(x)


def _arrow50(v: int) -> Callable[[int, str], str]:
    return closure12(None, v)


v5: Callable[[int, int, str], str] = _arrow50

def slice(x: int) -> Callable[[int, str], str]:
    return v5(x)


def _arrow51(v: str) -> Callable[[str], Array[str]]:
    return closure15(None, v)


v6: Callable[[str, str], Array[str]] = _arrow51

def split(x: str) -> Callable[[str], Array[str]]:
    return v6(x)


def _arrow52(v: Array[str]) -> Callable[[str], Array[str]]:
    return closure17(None, v)


v7: Callable[[Array[str], str], Array[str]] = _arrow52

def split_string(x: Array[str]) -> Callable[[str], Array[str]]:
    return v7(x)


def _arrow53(v: str) -> Callable[[str], bool]:
    return closure19(None, v)


v8: Callable[[str, str], bool] = _arrow53

def starts_with(x: str) -> Callable[[str], bool]:
    return v8(x)


def _arrow54(v: int) -> Callable[[int, str], str]:
    return closure21(None, v)


v9: Callable[[int, int, str], str] = _arrow54

def substring(x: int) -> Callable[[int, str], str]:
    return v9(x)


def _arrow55(v: str) -> str:
    return closure24(None, v)


v10: Callable[[str], str] = _arrow55

def to_lower(x: str) -> str:
    return v10(x)


def _arrow56(v: str) -> str:
    return closure25(None, v)


v11: Callable[[str], str] = _arrow56

def to_upper(x: str) -> str:
    return v11(x)


def _arrow57(v: str) -> str:
    return closure26(None, v)


v12: Callable[[str], str] = _arrow57

def trim(x: str) -> str:
    return v12(x)


def _arrow58(v: Array[str]) -> Callable[[str], str]:
    return closure27(None, v)


v13: Callable[[Array[str], str], str] = _arrow58

def trim_end(x: Array[str]) -> Callable[[str], str]:
    return v13(x)


def _arrow59(v: Array[str]) -> Callable[[str], str]:
    return closure29(None, v)


v14: Callable[[Array[str], str], str] = _arrow59

def trim_start(x: Array[str]) -> Callable[[str], str]:
    return v14(x)


def _arrow60(v: int) -> Callable[[str], str]:
    return closure31(None, v)


v15: Callable[[int, str], str] = _arrow60

def ellipsis(x: int) -> Callable[[str], str]:
    return v15(x)


def _arrow61(v: int64) -> Callable[[str], str]:
    return closure33(None, v)


v16: Callable[[int64, str], str] = _arrow61

def ellipsis_end(x: int64) -> Callable[[str], str]:
    return v16(x)


def _arrow62(v: Exception) -> str:
    return closure35(None, v)


v17: Callable[[Exception], str] = _arrow62

def format_exception(x: Exception) -> str:
    return v17(x)


def _arrow63(v: str) -> Callable[[Array[str]], str]:
    return closure36(None, v)


v18: Callable[[str, Array[str]], str] = _arrow63

def concat_array_trailing(x: str) -> Callable[[Array[str]], str]:
    return v18(x)


def _arrow64(v: str) -> Callable[[IEnumerable_1[str]], str]:
    return closure38(None, v)


v19: Callable[[str, IEnumerable_1[str]], str] = _arrow64

def concat(x: str) -> Callable[[IEnumerable_1[str]], str]:
    return v19(x)


def _arrow65(v: str) -> Callable[[Array[str]], str]:
    return closure40(None, v)


v20: Callable[[str, Array[str]], str] = _arrow65

def join_0027(x: str) -> Callable[[Array[str]], str]:
    return v20(x)


def _arrow66(v: str) -> Array[str]:
    return closure42(None, v)


v21: Callable[[str], Array[str]] = _arrow66

def to_char_array(x: str) -> Array[str]:
    return v21(x)


