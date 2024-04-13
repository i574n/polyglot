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
from fable_modules.fable_library.string_ import (ends_with as ends_with_1, pad_left as pad_left_1, pad_right as pad_right_1, replace as replace_1, split as split_1, substring as substring_1, trim_end as trim_end_1, trim_start as trim_start_1, join)
from fable_modules.fable_library.types import (Record, Array, int64)
from fable_modules.fable_library.util import IEnumerable_1

def _expr7() -> TypeInfo:
    return record_type("Sm.Mut0", [], Mut0, lambda: [("l0", int32_type), ("l1", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int
    l1: str

Mut0_reflection = _expr7

def _expr8() -> TypeInfo:
    return record_type("Sm.Mut1", [], Mut1, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: int

Mut1_reflection = _expr8

def closure1(v0_1: str, v1_1: str) -> bool:
    return v1_1.find(v0_1) >= 0


def closure0(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow9(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure1(v0_1, v)

    return _arrow9


def closure3(v0_1: str, v1_1: str) -> bool:
    return ends_with_1(v1_1, v0_1)


def closure2(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow10(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure3(v0_1, v)

    return _arrow10


def closure6(v0_1: int, v1_1: str, v2_1: str) -> str:
    return pad_left_1(v2_1, v0_1, v1_1)


def closure5(v0_1: int, v1_1: str) -> Callable[[str], str]:
    def _arrow11(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure6(v0_1, v1_1, v)

    return _arrow11


def closure4(unit_var: None, v0_1: int) -> Callable[[str, str], str]:
    def _arrow12(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure5(v0_1, v)

    return _arrow12


def closure8(v0_1: int, v1_1: str) -> str:
    return pad_right_1(v1_1, v0_1)


def closure7(unit_var: None, v0_1: int) -> Callable[[str], str]:
    def _arrow13(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure8(v0_1, v)

    return _arrow13


def closure11(v0_1: str, v1_1: str, v2_1: str) -> str:
    return replace_1(v2_1, v0_1, v1_1)


def closure10(v0_1: str, v1_1: str) -> Callable[[str], str]:
    def _arrow14(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure11(v0_1, v1_1, v)

    return _arrow14


def closure9(unit_var: None, v0_1: str) -> Callable[[str, str], str]:
    def _arrow15(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure10(v0_1, v)

    return _arrow15


def closure14(v0_1: int, v1_1: int, v2_1: str) -> str:
    return v2_1[v0_1:v1_1 + 1]


def closure13(v0_1: int, v1_1: int) -> Callable[[str], str]:
    def _arrow16(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure14(v0_1, v1_1, v)

    return _arrow16


def closure12(unit_var: None, v0_1: int) -> Callable[[int, str], str]:
    def _arrow17(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure13(v0_1, v)

    return _arrow17


def closure16(v0_1: str, v1_1: str) -> Array[str]:
    return split_1(v1_1, [v0_1], None, 0)


def closure15(unit_var: None, v0_1: str) -> Callable[[str], Array[str]]:
    def _arrow18(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Array[str]:
        return closure16(v0_1, v)

    return _arrow18


def method0(__unit: None=None) -> str:
    return ""


def closure18(v0_1: Array[str], v1_1: str) -> Array[str]:
    _v2: Array[str] | None = None
    _v2 = None
    return value_2(_v2)


def closure17(unit_var: None, v0_1: Array[str]) -> Callable[[str], Array[str]]:
    def _arrow19(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Array[str]:
        return closure18(v0_1, v)

    return _arrow19


def closure20(v0_1: str, v1_1: str) -> bool:
    return v1_1.find(v0_1) == 0


def closure19(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow20(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure20(v0_1, v)

    return _arrow20


def closure23(v0_1: int, v1_1: int, v2_1: str) -> str:
    return substring_1(v2_1, v0_1, v1_1)


def closure22(v0_1: int, v1_1: int) -> Callable[[str], str]:
    def _arrow21(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure23(v0_1, v1_1, v)

    return _arrow21


def closure21(unit_var: None, v0_1: int) -> Callable[[int, str], str]:
    def _arrow22(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure22(v0_1, v)

    return _arrow22


def closure24(unit_var: None, v0_1: str) -> str:
    return v0_1.lower()


def closure25(unit_var: None, v0_1: str) -> str:
    return v0_1.upper()


def closure26(unit_var: None, v0_1: str) -> str:
    return v0_1.strip()


def closure28(v0_1: Array[str], v1_1: str) -> str:
    return trim_end_1(v1_1, *v0_1)


def closure27(unit_var: None, v0_1: Array[str]) -> Callable[[str], str]:
    def _arrow23(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure28(v0_1, v)

    return _arrow23


def closure30(v0_1: Array[str], v1_1: str) -> str:
    return trim_start_1(v1_1, *v0_1)


def closure29(unit_var: None, v0_1: Array[str]) -> Callable[[str], str]:
    def _arrow24(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure30(v0_1, v)

    return _arrow24


def closure32(v0_1: int, v1_1: str) -> str:
    if len(v1_1) <= v0_1:
        return v1_1

    else: 
        v4_1: int = (v0_1 - 1) or 0
        return v1_1[0:v4_1 + 1] + "..."



def closure31(unit_var: None, v0_1: int) -> Callable[[str], str]:
    def _arrow25(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure32(v0_1, v)

    return _arrow25


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
        v20_1: IEnumerable_1[str] = of_array([v13_1, "...", v1_1[int(to_int(v14_1)):int(to_int(v15_1)) + 1]])
        return join(method0(), v20_1)



def closure33(unit_var: None, v0_1: int64) -> Callable[[str], str]:
    def _arrow26(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure34(v0_1, v)

    return _arrow26


def closure35(unit_var: None, v0_1: Exception) -> str:
    _v1: str | None = None
    _v1 = None
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
    def _arrow27(v: Array[str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure37(v0_1, v)

    return _arrow27


def method2(v0_1: str) -> str:
    return v0_1


def closure39(v0_1: str, v1_1: IEnumerable_1[str]) -> str:
    return join(method2(v0_1), v1_1)


def closure38(unit_var: None, v0_1: str) -> Callable[[IEnumerable_1[str]], str]:
    def _arrow28(v: IEnumerable_1[str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure39(v0_1, v)

    return _arrow28


def closure41(v0_1: str, v1_1: Array[str]) -> str:
    return join(v0_1, v1_1)


def closure40(unit_var: None, v0_1: str) -> Callable[[Array[str]], str]:
    def _arrow29(v: Array[str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure41(v0_1, v)

    return _arrow29


def method3(v0_1: int, v1_1: Mut1) -> bool:
    return v1_1.l0 < v0_1


def closure42(unit_var: None, v0_1: str) -> Array[str]:
    v1_1: int = len(v0_1) or 0
    v2_1: Array[str] = fill([0] * v1_1, 0, v1_1, "")
    v3_1: Mut1 = Mut1(0)
    while method3(v1_1, v3_1):
        v5_1: int = v3_1.l0 or 0
        v6_1: str = v0_1[v5_1]
        v2_1[v5_1] = v6_1
        v7_1: int = (v5_1 + 1) or 0
        v3_1.l0 = v7_1 or 0
    return v2_1


def _arrow30(v: str) -> Callable[[str], bool]:
    return closure0(None, v)


v0: Callable[[str, str], bool] = _arrow30

def contains(x: str) -> Callable[[str], bool]:
    return v0(x)


def _arrow31(v: str) -> Callable[[str], bool]:
    return closure2(None, v)


v1: Callable[[str, str], bool] = _arrow31

def ends_with(x: str) -> Callable[[str], bool]:
    return v1(x)


def _arrow32(v: int) -> Callable[[str, str], str]:
    return closure4(None, v)


v2: Callable[[int, str, str], str] = _arrow32

def pad_left(x: int) -> Callable[[str, str], str]:
    return v2(x)


def _arrow33(v: int) -> Callable[[str], str]:
    return closure7(None, v)


v3: Callable[[int, str], str] = _arrow33

def pad_right(x: int) -> Callable[[str], str]:
    return v3(x)


def _arrow34(v: str) -> Callable[[str, str], str]:
    return closure9(None, v)


v4: Callable[[str, str, str], str] = _arrow34

def replace(x: str) -> Callable[[str, str], str]:
    return v4(x)


def _arrow35(v: int) -> Callable[[int, str], str]:
    return closure12(None, v)


v5: Callable[[int, int, str], str] = _arrow35

def slice(x: int) -> Callable[[int, str], str]:
    return v5(x)


def _arrow36(v: str) -> Callable[[str], Array[str]]:
    return closure15(None, v)


v6: Callable[[str, str], Array[str]] = _arrow36

def split(x: str) -> Callable[[str], Array[str]]:
    return v6(x)


def _arrow37(v: Array[str]) -> Callable[[str], Array[str]]:
    return closure17(None, v)


v7: Callable[[Array[str], str], Array[str]] = _arrow37

def split_string(x: Array[str]) -> Callable[[str], Array[str]]:
    return v7(x)


def _arrow38(v: str) -> Callable[[str], bool]:
    return closure19(None, v)


v8: Callable[[str, str], bool] = _arrow38

def starts_with(x: str) -> Callable[[str], bool]:
    return v8(x)


def _arrow39(v: int) -> Callable[[int, str], str]:
    return closure21(None, v)


v9: Callable[[int, int, str], str] = _arrow39

def substring(x: int) -> Callable[[int, str], str]:
    return v9(x)


def _arrow40(v: str) -> str:
    return closure24(None, v)


v10: Callable[[str], str] = _arrow40

def to_lower(x: str) -> str:
    return v10(x)


def _arrow41(v: str) -> str:
    return closure25(None, v)


v11: Callable[[str], str] = _arrow41

def to_upper(x: str) -> str:
    return v11(x)


def _arrow42(v: str) -> str:
    return closure26(None, v)


v12: Callable[[str], str] = _arrow42

def trim(x: str) -> str:
    return v12(x)


def _arrow43(v: Array[str]) -> Callable[[str], str]:
    return closure27(None, v)


v13: Callable[[Array[str], str], str] = _arrow43

def trim_end(x: Array[str]) -> Callable[[str], str]:
    return v13(x)


def _arrow44(v: Array[str]) -> Callable[[str], str]:
    return closure29(None, v)


v14: Callable[[Array[str], str], str] = _arrow44

def trim_start(x: Array[str]) -> Callable[[str], str]:
    return v14(x)


def _arrow45(v: int) -> Callable[[str], str]:
    return closure31(None, v)


v15: Callable[[int, str], str] = _arrow45

def ellipsis(x: int) -> Callable[[str], str]:
    return v15(x)


def _arrow46(v: int64) -> Callable[[str], str]:
    return closure33(None, v)


v16: Callable[[int64, str], str] = _arrow46

def ellipsis_end(x: int64) -> Callable[[str], str]:
    return v16(x)


def _arrow47(v: Exception) -> str:
    return closure35(None, v)


v17: Callable[[Exception], str] = _arrow47

def format_exception(x: Exception) -> str:
    return v17(x)


def _arrow48(v: str) -> Callable[[Array[str]], str]:
    return closure36(None, v)


v18: Callable[[str, Array[str]], str] = _arrow48

def concat_array_trailing(x: str) -> Callable[[Array[str]], str]:
    return v18(x)


def _arrow49(v: str) -> Callable[[IEnumerable_1[str]], str]:
    return closure38(None, v)


v19: Callable[[str, IEnumerable_1[str]], str] = _arrow49

def concat(x: str) -> Callable[[IEnumerable_1[str]], str]:
    return v19(x)


def _arrow50(v: str) -> Callable[[Array[str]], str]:
    return closure40(None, v)


v20: Callable[[str, Array[str]], str] = _arrow50

def join_0027(x: str) -> Callable[[Array[str]], str]:
    return v20(x)


def _arrow51(v: str) -> Array[str]:
    return closure42(None, v)


v21: Callable[[str], Array[str]] = _arrow51

def to_char_array(x: str) -> Array[str]:
    return v21(x)


