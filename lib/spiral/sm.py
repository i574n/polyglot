from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from math import (ceil, floor)
from typing import Any
from fable_modules.fable_library.array_ import fill
from fable_modules.fable_library.double import divide
from fable_modules.fable_library.long import (from_integer, to_number, from_number, op_subtraction, to_int)
from fable_modules.fable_library.reflection import (TypeInfo, int32_type, string_type, record_type)
from fable_modules.fable_library.seq import of_array
from fable_modules.fable_library.string_ import (ends_with as ends_with_1, pad_left as pad_left_1, pad_right as pad_right_1, replace as replace_1, split as split_1, join, substring as substring_1, trim_end as trim_end_1, trim_start as trim_start_1, to_text, interpolate)
from fable_modules.fable_library.types import (Record, Array, int64)
from fable_modules.fable_library.util import IEnumerable_1

def _expr0() -> TypeInfo:
    return record_type("Sm.Mut0", [], Mut0, lambda: [("l0", int32_type), ("l1", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int
    l1: str

Mut0_reflection = _expr0

def _expr1() -> TypeInfo:
    return record_type("Sm.Mut1", [], Mut1, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: int

Mut1_reflection = _expr1

def closure1(v0_1: str, v1_1: str) -> bool:
    return v1_1.find(v0_1) >= 0


def closure0(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow2(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure1(v0_1, v)

    return _arrow2


def closure3(v0_1: str, v1_1: str) -> bool:
    return ends_with_1(v1_1, v0_1)


def closure2(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow3(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure3(v0_1, v)

    return _arrow3


def closure6(v0_1: int, v1_1: str, v2_1: str) -> str:
    return pad_left_1(v2_1, v0_1, v1_1)


def closure5(v0_1: int, v1_1: str) -> Callable[[str], str]:
    def _arrow4(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure6(v0_1, v1_1, v)

    return _arrow4


def closure4(unit_var: None, v0_1: int) -> Callable[[str, str], str]:
    def _arrow5(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure5(v0_1, v)

    return _arrow5


def closure9(v0_1: int, v1_1: str, v2_1: str) -> str:
    return pad_right_1(v2_1, v0_1, v1_1)


def closure8(v0_1: int, v1_1: str) -> Callable[[str], str]:
    def _arrow6(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure9(v0_1, v1_1, v)

    return _arrow6


def closure7(unit_var: None, v0_1: int) -> Callable[[str, str], str]:
    def _arrow7(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure8(v0_1, v)

    return _arrow7


def closure12(v0_1: str, v1_1: str, v2_1: str) -> str:
    return replace_1(v2_1, v0_1, v1_1)


def closure11(v0_1: str, v1_1: str) -> Callable[[str], str]:
    def _arrow8(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure12(v0_1, v1_1, v)

    return _arrow8


def closure10(unit_var: None, v0_1: str) -> Callable[[str, str], str]:
    def _arrow9(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure11(v0_1, v)

    return _arrow9


def method0(v0_1: str) -> str:
    return v0_1


def method1(v0_1: str) -> str:
    return v0_1


def method2(v0_1: str) -> str:
    return v0_1


def closure15(v0_1: str, v1_1: str, v2_1: str) -> str:
    v3_1: str = method0(v1_1)
    _v4: str | None = None
    _v4 = None
    if _v4 is None:
        raise Exception("base.run_target / _v4=None")

    else: 
        return _v4



def closure14(v0_1: str, v1_1: str) -> Callable[[str], str]:
    def _arrow15(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure15(v0_1, v1_1, v)

    return _arrow15


def closure13(unit_var: None, v0_1: str) -> Callable[[str, str], str]:
    def _arrow16(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure14(v0_1, v)

    return _arrow16


def closure18(v0_1: int, v1_1: int, v2_1: str) -> str:
    return v2_1[v0_1:v1_1 + 1]


def closure17(v0_1: int, v1_1: int) -> Callable[[str], str]:
    def _arrow20(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure18(v0_1, v1_1, v)

    return _arrow20


def closure16(unit_var: None, v0_1: int) -> Callable[[int, str], str]:
    def _arrow22(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure17(v0_1, v)

    return _arrow22


def closure20(v0_1: str, v1_1: str) -> Array[str]:
    return split_1(v1_1, [v0_1], None, 0)


def closure19(unit_var: None, v0_1: str) -> Callable[[str], Array[str]]:
    def _arrow25(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Array[str]:
        return closure20(v0_1, v)

    return _arrow25


def method3(__unit: None=None) -> str:
    return ""


def closure22(v0_1: Array[str], v1_1: str) -> Array[str]:
    _v2: Array[str] | None = None
    v32: IEnumerable_1[str] = of_array(v0_1)
    x: Array[str] = split_1(v1_1, [join(method3(), v32)], None, 0)
    _v2 = x
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure21(unit_var: None, v0_1: Array[str]) -> Callable[[str], Array[str]]:
    def _arrow26(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Array[str]:
        return closure22(v0_1, v)

    return _arrow26


def closure24(v0_1: str, v1_1: str) -> bool:
    return v1_1.find(v0_1) == 0


def closure23(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow27(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure24(v0_1, v)

    return _arrow27


def closure27(v0_1: int, v1_1: int, v2_1: str) -> str:
    return substring_1(v2_1, v0_1, v1_1)


def closure26(v0_1: int, v1_1: int) -> Callable[[str], str]:
    def _arrow28(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure27(v0_1, v1_1, v)

    return _arrow28


def closure25(unit_var: None, v0_1: int) -> Callable[[int, str], str]:
    def _arrow29(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure26(v0_1, v)

    return _arrow29


def closure28(unit_var: None, v0_1: str) -> str:
    return v0_1.lower()


def closure29(unit_var: None, v0_1: str) -> str:
    return v0_1.upper()


def closure30(unit_var: None, v0_1: str) -> str:
    return v0_1.strip()


def closure32(v0_1: Array[str], v1_1: str) -> str:
    return trim_end_1(v1_1, *v0_1)


def closure31(unit_var: None, v0_1: Array[str]) -> Callable[[str], str]:
    def _arrow30(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure32(v0_1, v)

    return _arrow30


def closure34(v0_1: Array[str], v1_1: str) -> str:
    return trim_start_1(v1_1, *v0_1)


def closure33(unit_var: None, v0_1: Array[str]) -> Callable[[str], str]:
    def _arrow31(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure34(v0_1, v)

    return _arrow31


def closure36(v0_1: int, v1_1: str) -> str:
    if len(v1_1) <= v0_1:
        return v1_1

    else: 
        v4_1: int = (v0_1 - 1) or 0
        return v1_1[0:v4_1 + 1] + "..."



def closure35(unit_var: None, v0_1: int) -> Callable[[str], str]:
    def _arrow32(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure36(v0_1, v)

    return _arrow32


def method4(v0_1: int64, v1_1: str) -> str:
    v2_1: int64 = from_integer(len(v1_1), False, 2)
    if v2_1 <= v0_1:
        return v1_1

    else: 
        v6_1: float = divide(to_number(v0_1), 2.0)
        v10_1: int64 = from_number(ceil(v6_1), False)
        v14_1: int64 = from_number(floor(v6_1), False)
        v15_1: int64 = op_subtraction(v10_1, int64(1))
        v16_1: str = v1_1[int(to_int(int64(0))):int(to_int(v15_1)) + 1]
        v17_1: int64 = op_subtraction(v2_1, v14_1)
        v18_1: int64 = op_subtraction(v2_1, int64(1))
        return join("", of_array([v16_1, "...", v1_1[int(to_int(v17_1)):int(to_int(v18_1)) + 1]]))



def closure38(v0_1: int64, v1_1: str) -> str:
    return method4(v0_1, v1_1)


def closure37(unit_var: None, v0_1: int64) -> Callable[[str], str]:
    def _arrow33(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure38(v0_1, v)

    return _arrow33


def closure39(unit_var: None, v0_1: Exception) -> str:
    _v1: str | None = None
    x: str = to_text(interpolate("%A%P()", [v0_1]))
    _v1 = x
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method5(v0_1: int, v1_1: Mut0) -> bool:
    return v1_1.l0 < v0_1


def closure41(v0_1: str, v1_1: Array[str]) -> str:
    v2_1: int = len(v1_1) or 0
    v4_1: Mut0 = Mut0(0, "")
    while method5(v2_1, v4_1):
        v6_1: int = v4_1.l0 or 0
        v9_1: str = ((v4_1.l1 + v1_1[v6_1]) + v0_1) + ""
        v10_1: int = (v6_1 + 1) or 0
        v4_1.l0 = v10_1 or 0
        v4_1.l1 = v9_1
    return v4_1.l1


def closure40(unit_var: None, v0_1: str) -> Callable[[Array[str]], str]:
    def _arrow34(v: Array[str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure41(v0_1, v)

    return _arrow34


def closure43(v0_1: str, v1_1: IEnumerable_1[str]) -> str:
    return join(v0_1, v1_1)


def closure42(unit_var: None, v0_1: str) -> Callable[[IEnumerable_1[str]], str]:
    def _arrow35(v: IEnumerable_1[str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure43(v0_1, v)

    return _arrow35


def closure45(v0_1: str, v1_1: Array[str]) -> str:
    return join(v0_1, v1_1)


def closure44(unit_var: None, v0_1: str) -> Callable[[Array[str]], str]:
    def _arrow36(v: Array[str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure45(v0_1, v)

    return _arrow36


def method6(v0_1: int, v1_1: Mut1) -> bool:
    return v1_1.l0 < v0_1


def closure46(unit_var: None, v0_1: str) -> Array[str]:
    v1_1: int = len(v0_1) or 0
    v2_1: Array[str] = fill([0] * v1_1, 0, v1_1, "")
    v3_1: Mut1 = Mut1(0)
    while method6(v1_1, v3_1):
        v5_1: int = v3_1.l0 or 0
        v6_1: str = v0_1[v5_1]
        v2_1[v5_1] = v6_1
        v7_1: int = (v5_1 + 1) or 0
        v3_1.l0 = v7_1 or 0
    return v2_1


def _arrow37(v: str) -> Callable[[str], bool]:
    return closure0(None, v)


v0: Callable[[str, str], bool] = _arrow37

def contains(x: str) -> Callable[[str], bool]:
    return v0(x)


def _arrow38(v: str) -> Callable[[str], bool]:
    return closure2(None, v)


v1: Callable[[str, str], bool] = _arrow38

def ends_with(x: str) -> Callable[[str], bool]:
    return v1(x)


def _arrow39(v: int) -> Callable[[str, str], str]:
    return closure4(None, v)


v2: Callable[[int, str, str], str] = _arrow39

def pad_left(x: int) -> Callable[[str, str], str]:
    return v2(x)


def _arrow40(v: int) -> Callable[[str, str], str]:
    return closure7(None, v)


v3: Callable[[int, str, str], str] = _arrow40

def pad_right(x: int) -> Callable[[str, str], str]:
    return v3(x)


def _arrow41(v: str) -> Callable[[str, str], str]:
    return closure10(None, v)


v4: Callable[[str, str, str], str] = _arrow41

def replace(x: str) -> Callable[[str, str], str]:
    return v4(x)


def _arrow42(v: str) -> Callable[[str, str], str]:
    return closure13(None, v)


v5: Callable[[str, str, str], str] = _arrow42

def replace_regex(x: str) -> Callable[[str, str], str]:
    return v5(x)


def _arrow43(v: int) -> Callable[[int, str], str]:
    return closure16(None, v)


v6: Callable[[int, int, str], str] = _arrow43

def slice(x: int) -> Callable[[int, str], str]:
    return v6(x)


def _arrow44(v: str) -> Callable[[str], Array[str]]:
    return closure19(None, v)


v7: Callable[[str, str], Array[str]] = _arrow44

def split(x: str) -> Callable[[str], Array[str]]:
    return v7(x)


def _arrow45(v: Array[str]) -> Callable[[str], Array[str]]:
    return closure21(None, v)


v8: Callable[[Array[str], str], Array[str]] = _arrow45

def split_string(x: Array[str]) -> Callable[[str], Array[str]]:
    return v8(x)


def _arrow46(v: str) -> Callable[[str], bool]:
    return closure23(None, v)


v9: Callable[[str, str], bool] = _arrow46

def starts_with(x: str) -> Callable[[str], bool]:
    return v9(x)


def _arrow48(v: int) -> Callable[[int, str], str]:
    return closure25(None, v)


v10: Callable[[int, int, str], str] = _arrow48

def substring(x: int) -> Callable[[int, str], str]:
    return v10(x)


def _arrow49(v: str) -> str:
    return closure28(None, v)


v11: Callable[[str], str] = _arrow49

def to_lower(x: str) -> str:
    return v11(x)


def _arrow50(v: str) -> str:
    return closure29(None, v)


v12: Callable[[str], str] = _arrow50

def to_upper(x: str) -> str:
    return v12(x)


def _arrow51(v: str) -> str:
    return closure30(None, v)


v13: Callable[[str], str] = _arrow51

def trim(x: str) -> str:
    return v13(x)


def _arrow52(v: Array[str]) -> Callable[[str], str]:
    return closure31(None, v)


v14: Callable[[Array[str], str], str] = _arrow52

def trim_end(x: Array[str]) -> Callable[[str], str]:
    return v14(x)


def _arrow53(v: Array[str]) -> Callable[[str], str]:
    return closure33(None, v)


v15: Callable[[Array[str], str], str] = _arrow53

def trim_start(x: Array[str]) -> Callable[[str], str]:
    return v15(x)


def _arrow55(v: int) -> Callable[[str], str]:
    return closure35(None, v)


v16: Callable[[int, str], str] = _arrow55

def ellipsis(x: int) -> Callable[[str], str]:
    return v16(x)


def _arrow56(v: int64) -> Callable[[str], str]:
    return closure37(None, v)


v17: Callable[[int64, str], str] = _arrow56

def ellipsis_end(x: int64) -> Callable[[str], str]:
    return v17(x)


def _arrow57(v: Exception) -> str:
    return closure39(None, v)


v18: Callable[[Exception], str] = _arrow57

def format_exception(x: Exception) -> str:
    return v18(x)


def _arrow58(v: str) -> Callable[[Array[str]], str]:
    return closure40(None, v)


v19: Callable[[str, Array[str]], str] = _arrow58

def concat_array_trailing(x: str) -> Callable[[Array[str]], str]:
    return v19(x)


def _arrow59(v: str) -> Callable[[IEnumerable_1[str]], str]:
    return closure42(None, v)


v20: Callable[[str, IEnumerable_1[str]], str] = _arrow59

def concat(x: str) -> Callable[[IEnumerable_1[str]], str]:
    return v20(x)


def _arrow60(v: str) -> Callable[[Array[str]], str]:
    return closure44(None, v)


v21: Callable[[str, Array[str]], str] = _arrow60

def join_0027(x: str) -> Callable[[Array[str]], str]:
    return v21(x)


def _arrow61(v: str) -> Array[str]:
    return closure46(None, v)


v22: Callable[[str], Array[str]] = _arrow61

def to_char_array(x: str) -> Array[str]:
    return v22(x)


