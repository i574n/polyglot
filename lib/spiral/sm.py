from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from math import (ceil, floor)
from typing import Any
from fable_modules.fable_library.array_ import fill
from fable_modules.fable_library.double import divide
from fable_modules.fable_library.list import (cons, FSharpList, to_array, empty, of_array as of_array_1, fold_back)
from fable_modules.fable_library.long import (from_integer, to_number, from_number, op_subtraction, to_int)
from fable_modules.fable_library.reflection import (TypeInfo, char_type, union_type, int32_type, string_type, record_type)
from fable_modules.fable_library.seq import of_array
from fable_modules.fable_library.string_ import (ends_with as ends_with_1, pad_left as pad_left_1, pad_right as pad_right_1, replace as replace_1, split as split_1, join, substring as substring_1, trim_end as trim_end_1, trim_start as trim_start_1, to_text, interpolate)
from fable_modules.fable_library.types import (Array, Union, Record, int64)
from fable_modules.fable_library.util import (IEnumerable_1, uncurry2)

def _expr1() -> TypeInfo:
    return union_type("Sm.UH0", [], UH0, lambda: [[], [("Item1", char_type), ("Item2", UH0_reflection())]])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr1

def _expr2() -> TypeInfo:
    return record_type("Sm.Mut0", [], Mut0, lambda: [("l0", int32_type), ("l1", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int
    l1: str

Mut0_reflection = _expr2

def _expr3() -> TypeInfo:
    return record_type("Sm.Mut1", [], Mut1, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: int

Mut1_reflection = _expr3

def closure1(v0_1: str, v1_1: str) -> bool:
    return v1_1.find(v0_1) >= 0


def closure0(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow4(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure1(v0_1, v)

    return _arrow4


def closure3(v0_1: str, v1_1: str) -> bool:
    return ends_with_1(v1_1, v0_1)


def closure2(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow5(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure3(v0_1, v)

    return _arrow5


def closure6(v0_1: int, v1_1: str, v2_1: str) -> str:
    return pad_left_1(v2_1, v0_1, v1_1)


def closure5(v0_1: int, v1_1: str) -> Callable[[str], str]:
    def _arrow6(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure6(v0_1, v1_1, v)

    return _arrow6


def closure4(unit_var: None, v0_1: int) -> Callable[[str, str], str]:
    def _arrow7(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure5(v0_1, v)

    return _arrow7


def closure9(v0_1: int, v1_1: str, v2_1: str) -> str:
    return pad_right_1(v2_1, v0_1, v1_1)


def closure8(v0_1: int, v1_1: str) -> Callable[[str], str]:
    def _arrow8(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure9(v0_1, v1_1, v)

    return _arrow8


def closure7(unit_var: None, v0_1: int) -> Callable[[str, str], str]:
    def _arrow9(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure8(v0_1, v)

    return _arrow9


def closure12(v0_1: str, v1_1: str, v2_1: str) -> str:
    return replace_1(v2_1, v0_1, v1_1)


def closure11(v0_1: str, v1_1: str) -> Callable[[str], str]:
    def _arrow10(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure12(v0_1, v1_1, v)

    return _arrow10


def closure10(unit_var: None, v0_1: str) -> Callable[[str, str], str]:
    def _arrow11(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure11(v0_1, v)

    return _arrow11


def method0(v0_1: str) -> str:
    return v0_1


def closure15(v0_1: str, v1_1: str, v2_1: str) -> str:
    return None


def closure14(v0_1: str, v1_1: str) -> Callable[[str], str]:
    def _arrow12(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure15(v0_1, v1_1, v)

    return _arrow12


def closure13(unit_var: None, v0_1: str) -> Callable[[str, str], str]:
    def _arrow13(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure14(v0_1, v)

    return _arrow13


def closure18(v0_1: int, v1_1: int, v2_1: str) -> str:
    return v2_1[v0_1:v1_1 + 1]


def closure17(v0_1: int, v1_1: int) -> Callable[[str], str]:
    def _arrow14(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure18(v0_1, v1_1, v)

    return _arrow14


def closure16(unit_var: None, v0_1: int) -> Callable[[int, str], str]:
    def _arrow15(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure17(v0_1, v)

    return _arrow15


def closure20(v0_1: str, v1_1: str) -> Array[str]:
    return split_1(v1_1, [v0_1], None, 0)


def closure19(unit_var: None, v0_1: str) -> Callable[[str], Array[str]]:
    def _arrow16(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Array[str]:
        return closure20(v0_1, v)

    return _arrow16


def method1(__unit: None=None) -> str:
    return ""


def closure22(v0_1: Array[str], v1_1: str) -> Array[str]:
    v51: IEnumerable_1[str] = of_array(v0_1)
    return split_1(v1_1, [join(method1(), v51)], None, 0)


def closure21(unit_var: None, v0_1: Array[str]) -> Callable[[str], Array[str]]:
    def _arrow18(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Array[str]:
        return closure22(v0_1, v)

    return _arrow18


def closure24(v0_1: str, v1_1: str) -> bool:
    return v1_1.find(v0_1) == 0


def closure23(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow19(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure24(v0_1, v)

    return _arrow19


def closure27(v0_1: int, v1_1: int, v2_1: str) -> str:
    return substring_1(v2_1, v0_1, v1_1)


def closure26(v0_1: int, v1_1: int) -> Callable[[str], str]:
    def _arrow20(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure27(v0_1, v1_1, v)

    return _arrow20


def closure25(unit_var: None, v0_1: int) -> Callable[[int, str], str]:
    def _arrow21(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure26(v0_1, v)

    return _arrow21


def closure28(unit_var: None, v0_1: str) -> str:
    return v0_1.lower()


def closure29(unit_var: None, v0_1: str) -> str:
    return v0_1.upper()


def closure30(unit_var: None, v0_1: str) -> str:
    return v0_1.strip()


def closure33(v0_1: str, v1_1: UH0) -> UH0:
    return UH0(1, v0_1, v1_1)


def closure32(unit_var: None, v0_1: str) -> Callable[[UH0], UH0]:
    def _arrow24(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure33(v0_1, v)

    return _arrow24


def method2(__unit: None=None) -> Callable[[str, UH0], UH0]:
    def _arrow25(v: str) -> Callable[[UH0], UH0]:
        return closure32(None, v)

    return _arrow25


def method3(v0_1: UH0, v1_1: FSharpList[str]) -> FSharpList[str]:
    if v0_1.tag == 0:
        return v1_1

    else: 
        return cons(v0_1.fields[0], method3(v0_1.fields[1], v1_1))



def closure34(v0_1: UH0, v1_1: str) -> str:
    return trim_end_1(v1_1, *to_array(method3(v0_1, empty())))


def closure31(unit_var: None, v0_1: Array[str]) -> Callable[[str], str]:
    v1_1: FSharpList[str] = of_array_1(v0_1)
    v7_1: UH0 = fold_back(uncurry2(method2()), v1_1, UH0(0))
    def _arrow54(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure34(v7_1, v)

    return _arrow54


def closure36(v0_1: UH0, v1_1: str) -> str:
    return trim_start_1(v1_1, *to_array(method3(v0_1, empty())))


def closure35(unit_var: None, v0_1: Array[str]) -> Callable[[str], str]:
    v1_1: FSharpList[str] = of_array_1(v0_1)
    v7_1: UH0 = fold_back(uncurry2(method2()), v1_1, UH0(0))
    def _arrow56(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure36(v7_1, v)

    return _arrow56


def closure38(v0_1: int, v1_1: str) -> str:
    if len(v1_1) <= v0_1:
        return v1_1

    else: 
        v4_1: int = (v0_1 - 1) or 0
        return v1_1[0:v4_1 + 1] + "..."



def closure37(unit_var: None, v0_1: int) -> Callable[[str], str]:
    def _arrow57(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure38(v0_1, v)

    return _arrow57


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



def closure40(v0_1: int64, v1_1: str) -> str:
    return method4(v0_1, v1_1)


def closure39(unit_var: None, v0_1: int64) -> Callable[[str], str]:
    def _arrow59(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure40(v0_1, v)

    return _arrow59


def closure41(unit_var: None, v0_1: Exception) -> str:
    return to_text(interpolate("%A%P()", [v0_1]))


def method5(v0_1: int, v1_1: Mut0) -> bool:
    return v1_1.l0 < v0_1


def closure43(v0_1: str, v1_1: Array[str]) -> str:
    v2_1: int = len(v1_1) or 0
    v4_1: Mut0 = Mut0(0, "")
    while method5(v2_1, v4_1):
        v6_1: int = v4_1.l0 or 0
        v9_1: str = ((v4_1.l1 + v1_1[v6_1]) + v0_1) + ""
        v10_1: int = (v6_1 + 1) or 0
        v4_1.l0 = v10_1 or 0
        v4_1.l1 = v9_1
    return v4_1.l1


def closure42(unit_var: None, v0_1: str) -> Callable[[Array[str]], str]:
    def _arrow60(v: Array[str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure43(v0_1, v)

    return _arrow60


def closure45(v0_1: str, v1_1: IEnumerable_1[str]) -> str:
    return join(v0_1, v1_1)


def closure44(unit_var: None, v0_1: str) -> Callable[[IEnumerable_1[str]], str]:
    def _arrow62(v: IEnumerable_1[str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure45(v0_1, v)

    return _arrow62


def closure47(v0_1: str, v1_1: Array[str]) -> str:
    return join(v0_1, v1_1)


def closure46(unit_var: None, v0_1: str) -> Callable[[Array[str]], str]:
    def _arrow63(v: Array[str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure47(v0_1, v)

    return _arrow63


def method6(v0_1: int, v1_1: Mut1) -> bool:
    return v1_1.l0 < v0_1


def closure48(unit_var: None, v0_1: str) -> Array[str]:
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


def _arrow65(v: str) -> Callable[[str], bool]:
    return closure0(None, v)


v0: Callable[[str, str], bool] = _arrow65

def contains(x: str) -> Callable[[str], bool]:
    return v0(x)


def _arrow67(v: str) -> Callable[[str], bool]:
    return closure2(None, v)


v1: Callable[[str, str], bool] = _arrow67

def ends_with(x: str) -> Callable[[str], bool]:
    return v1(x)


def _arrow68(v: int) -> Callable[[str, str], str]:
    return closure4(None, v)


v2: Callable[[int, str, str], str] = _arrow68

def pad_left(x: int) -> Callable[[str, str], str]:
    return v2(x)


def _arrow69(v: int) -> Callable[[str, str], str]:
    return closure7(None, v)


v3: Callable[[int, str, str], str] = _arrow69

def pad_right(x: int) -> Callable[[str, str], str]:
    return v3(x)


def _arrow70(v: str) -> Callable[[str, str], str]:
    return closure10(None, v)


v4: Callable[[str, str, str], str] = _arrow70

def replace(x: str) -> Callable[[str, str], str]:
    return v4(x)


def _arrow72(v: str) -> Callable[[str, str], str]:
    return closure13(None, v)


v5: Callable[[str, str, str], str] = _arrow72

def replace_regex(x: str) -> Callable[[str, str], str]:
    return v5(x)


def _arrow73(v: int) -> Callable[[int, str], str]:
    return closure16(None, v)


v6: Callable[[int, int, str], str] = _arrow73

def slice(x: int) -> Callable[[int, str], str]:
    return v6(x)


def _arrow74(v: str) -> Callable[[str], Array[str]]:
    return closure19(None, v)


v7: Callable[[str, str], Array[str]] = _arrow74

def split(x: str) -> Callable[[str], Array[str]]:
    return v7(x)


def _arrow75(v: Array[str]) -> Callable[[str], Array[str]]:
    return closure21(None, v)


v8: Callable[[Array[str], str], Array[str]] = _arrow75

def split_string(x: Array[str]) -> Callable[[str], Array[str]]:
    return v8(x)


def _arrow76(v: str) -> Callable[[str], bool]:
    return closure23(None, v)


v9: Callable[[str, str], bool] = _arrow76

def starts_with(x: str) -> Callable[[str], bool]:
    return v9(x)


def _arrow77(v: int) -> Callable[[int, str], str]:
    return closure25(None, v)


v10: Callable[[int, int, str], str] = _arrow77

def substring(x: int) -> Callable[[int, str], str]:
    return v10(x)


def _arrow79(v: str) -> str:
    return closure28(None, v)


v11: Callable[[str], str] = _arrow79

def to_lower(x: str) -> str:
    return v11(x)


def _arrow80(v: str) -> str:
    return closure29(None, v)


v12: Callable[[str], str] = _arrow80

def to_upper(x: str) -> str:
    return v12(x)


def _arrow82(v: str) -> str:
    return closure30(None, v)


v13: Callable[[str], str] = _arrow82

def trim(x: str) -> str:
    return v13(x)


def _arrow85(v: Array[str]) -> Callable[[str], str]:
    return closure31(None, v)


v14: Callable[[Array[str], str], str] = _arrow85

def trim_end(x: Array[str]) -> Callable[[str], str]:
    return v14(x)


def _arrow86(v: Array[str]) -> Callable[[str], str]:
    return closure35(None, v)


v15: Callable[[Array[str], str], str] = _arrow86

def trim_start(x: Array[str]) -> Callable[[str], str]:
    return v15(x)


def _arrow87(v: int) -> Callable[[str], str]:
    return closure37(None, v)


v16: Callable[[int, str], str] = _arrow87

def ellipsis(x: int) -> Callable[[str], str]:
    return v16(x)


def _arrow88(v: int64) -> Callable[[str], str]:
    return closure39(None, v)


v17: Callable[[int64, str], str] = _arrow88

def ellipsis_end(x: int64) -> Callable[[str], str]:
    return v17(x)


def _arrow89(v: Exception) -> str:
    return closure41(None, v)


v18: Callable[[Exception], str] = _arrow89

def format_exception(x: Exception) -> str:
    return v18(x)


def _arrow90(v: str) -> Callable[[Array[str]], str]:
    return closure42(None, v)


v19: Callable[[str, Array[str]], str] = _arrow90

def concat_array_trailing(x: str) -> Callable[[Array[str]], str]:
    return v19(x)


def _arrow91(v: str) -> Callable[[IEnumerable_1[str]], str]:
    return closure44(None, v)


v20: Callable[[str, IEnumerable_1[str]], str] = _arrow91

def concat(x: str) -> Callable[[IEnumerable_1[str]], str]:
    return v20(x)


def _arrow92(v: str) -> Callable[[Array[str]], str]:
    return closure46(None, v)


v21: Callable[[str, Array[str]], str] = _arrow92

def join_0027(x: str) -> Callable[[Array[str]], str]:
    return v21(x)


def _arrow93(v: str) -> Array[str]:
    return closure48(None, v)


v22: Callable[[str], Array[str]] = _arrow93

def to_char_array(x: str) -> Array[str]:
    return v22(x)


