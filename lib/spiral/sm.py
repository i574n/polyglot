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

def _expr0() -> TypeInfo:
    return union_type("Sm.UH0", [], UH0, lambda: [[], [("Item1", char_type), ("Item2", UH0_reflection())]])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr0

def _expr1() -> TypeInfo:
    return record_type("Sm.Mut0", [], Mut0, lambda: [("l0", int32_type), ("l1", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int
    l1: str

Mut0_reflection = _expr1

def _expr2() -> TypeInfo:
    return record_type("Sm.Mut1", [], Mut1, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: int

Mut1_reflection = _expr2

def closure1(v0: str, v1: str) -> bool:
    return v1.find(v0) >= 0


def closure0(unit_var: None, v0: str) -> Callable[[str], bool]:
    def _arrow3(v: str, unit_var: Any=unit_var, v0: Any=v0) -> bool:
        return closure1(v0, v)

    return _arrow3


def closure3(v0: str, v1: str) -> bool:
    return ends_with_1(v1, v0)


def closure2(unit_var: None, v0: str) -> Callable[[str], bool]:
    def _arrow4(v: str, unit_var: Any=unit_var, v0: Any=v0) -> bool:
        return closure3(v0, v)

    return _arrow4


def closure6(v0: int, v1: str, v2: str) -> str:
    return pad_left_1(v2, v0, v1)


def closure5(v0: int, v1: str) -> Callable[[str], str]:
    def _arrow5(v: str, v0: Any=v0, v1: Any=v1) -> str:
        return closure6(v0, v1, v)

    return _arrow5


def closure4(unit_var: None, v0: int) -> Callable[[str, str], str]:
    def _arrow6(v: str, unit_var: Any=unit_var, v0: Any=v0) -> Callable[[str], str]:
        return closure5(v0, v)

    return _arrow6


def closure9(v0: int, v1: str, v2: str) -> str:
    return pad_right_1(v2, v0, v1)


def closure8(v0: int, v1: str) -> Callable[[str], str]:
    def _arrow7(v: str, v0: Any=v0, v1: Any=v1) -> str:
        return closure9(v0, v1, v)

    return _arrow7


def closure7(unit_var: None, v0: int) -> Callable[[str, str], str]:
    def _arrow8(v: str, unit_var: Any=unit_var, v0: Any=v0) -> Callable[[str], str]:
        return closure8(v0, v)

    return _arrow8


def closure12(v0: str, v1: str, v2: str) -> str:
    return replace_1(v2, v0, v1)


def closure11(v0: str, v1: str) -> Callable[[str], str]:
    def _arrow9(v: str, v0: Any=v0, v1: Any=v1) -> str:
        return closure12(v0, v1, v)

    return _arrow9


def closure10(unit_var: None, v0: str) -> Callable[[str, str], str]:
    def _arrow10(v: str, unit_var: Any=unit_var, v0: Any=v0) -> Callable[[str], str]:
        return closure11(v0, v)

    return _arrow10


def method0(v0: str) -> str:
    return v0


def method1(v0: str) -> str:
    return v0


def method2(v0: str) -> str:
    return v0


def closure15(v0: str, v1: str, v2: str) -> str:
    v3: str = method0(v1)
    _v6: str | None = None
    _v6 = None
    if _v6 is None:
        raise Exception("base.run_target / _v6=None")

    else: 
        return _v6



def closure14(v0: str, v1: str) -> Callable[[str], str]:
    def _arrow23(v: str, v0: Any=v0, v1: Any=v1) -> str:
        return closure15(v0, v1, v)

    return _arrow23


def closure13(unit_var: None, v0: str) -> Callable[[str, str], str]:
    def _arrow24(v: str, unit_var: Any=unit_var, v0: Any=v0) -> Callable[[str], str]:
        return closure14(v0, v)

    return _arrow24


def closure18(v0: int, v1: int, v2: str) -> str:
    return v2[v0:v1 + 1]


def closure17(v0: int, v1: int) -> Callable[[str], str]:
    def _arrow25(v: str, v0: Any=v0, v1: Any=v1) -> str:
        return closure18(v0, v1, v)

    return _arrow25


def closure16(unit_var: None, v0: int) -> Callable[[int, str], str]:
    def _arrow26(v: int, unit_var: Any=unit_var, v0: Any=v0) -> Callable[[str], str]:
        return closure17(v0, v)

    return _arrow26


def closure20(v0: str, v1: str) -> Array[str]:
    return split_1(v1, [v0], None, 0)


def closure19(unit_var: None, v0: str) -> Callable[[str], Array[str]]:
    def _arrow27(v: str, unit_var: Any=unit_var, v0: Any=v0) -> Array[str]:
        return closure20(v0, v)

    return _arrow27


def method3(__unit: None=None) -> str:
    return ""


def closure22(v0: Array[str], v1: str) -> Array[str]:
    _v4: Array[str] | None = None
    v95: IEnumerable_1[str] = of_array(v0)
    x: Array[str] = split_1(v1, [join(method3(), v95)], None, 0)
    _v4 = x
    if _v4 is None:
        raise Exception("base.run_target / _v4=None")

    else: 
        return _v4



def closure21(unit_var: None, v0: Array[str]) -> Callable[[str], Array[str]]:
    def _arrow28(v: str, unit_var: Any=unit_var, v0: Any=v0) -> Array[str]:
        return closure22(v0, v)

    return _arrow28


def closure24(v0: str, v1: str) -> bool:
    return v1.find(v0) == 0


def closure23(unit_var: None, v0: str) -> Callable[[str], bool]:
    def _arrow29(v: str, unit_var: Any=unit_var, v0: Any=v0) -> bool:
        return closure24(v0, v)

    return _arrow29


def closure27(v0: int, v1: int, v2: str) -> str:
    return substring_1(v2, v0, v1)


def closure26(v0: int, v1: int) -> Callable[[str], str]:
    def _arrow30(v: str, v0: Any=v0, v1: Any=v1) -> str:
        return closure27(v0, v1, v)

    return _arrow30


def closure25(unit_var: None, v0: int) -> Callable[[int, str], str]:
    def _arrow31(v: int, unit_var: Any=unit_var, v0: Any=v0) -> Callable[[str], str]:
        return closure26(v0, v)

    return _arrow31


def closure28(unit_var: None, v0: str) -> str:
    return v0.lower()


def closure29(unit_var: None, v0: str) -> str:
    return v0.upper()


def closure30(unit_var: None, v0: str) -> str:
    return v0.strip()


def closure33(v0: str, v1: UH0) -> UH0:
    return UH0(1, v0, v1)


def closure32(unit_var: None, v0: str) -> Callable[[UH0], UH0]:
    def _arrow32(v: UH0, unit_var: Any=unit_var, v0: Any=v0) -> UH0:
        return closure33(v0, v)

    return _arrow32


def method4(__unit: None=None) -> Callable[[str, UH0], UH0]:
    def _arrow33(v: str) -> Callable[[UH0], UH0]:
        return closure32(None, v)

    return _arrow33


def method5(v0: UH0, v1: FSharpList[str]) -> FSharpList[str]:
    if v0.tag == 0:
        return v1

    else: 
        return cons(v0.fields[0], method5(v0.fields[1], v1))



def closure34(v0: UH0, v1: str) -> str:
    return trim_end_1(v1, *to_array(method5(v0, empty())))


def closure31(unit_var: None, v0: Array[str]) -> Callable[[str], str]:
    v1: FSharpList[str] = of_array_1(v0)
    v9: UH0 = fold_back(uncurry2(method4()), v1, UH0(0))
    def _arrow35(v: str, unit_var: Any=unit_var, v0: Any=v0) -> str:
        return closure34(v9, v)

    return _arrow35


def closure36(v0: UH0, v1: str) -> str:
    return trim_start_1(v1, *to_array(method5(v0, empty())))


def closure35(unit_var: None, v0: Array[str]) -> Callable[[str], str]:
    v1: FSharpList[str] = of_array_1(v0)
    v9: UH0 = fold_back(uncurry2(method4()), v1, UH0(0))
    def _arrow36(v: str, unit_var: Any=unit_var, v0: Any=v0) -> str:
        return closure36(v9, v)

    return _arrow36


def closure38(v0: int, v1: str) -> str:
    if len(v1) <= v0:
        return v1

    else: 
        v4: int = (v0 - 1) or 0
        return v1[0:v4 + 1] + "..."



def closure37(unit_var: None, v0: int) -> Callable[[str], str]:
    def _arrow37(v: str, unit_var: Any=unit_var, v0: Any=v0) -> str:
        return closure38(v0, v)

    return _arrow37


def method6(v0: int64, v1: str) -> str:
    v2: int64 = from_integer(len(v1), False, 2)
    if v2 <= v0:
        return v1

    else: 
        v6: float = divide(to_number(v0), 2.0)
        v10: int64 = from_number(ceil(v6), False)
        v14: int64 = from_number(floor(v6), False)
        v15: int64 = op_subtraction(v10, int64(1))
        v16: str = v1[int(to_int(int64(0))):int(to_int(v15)) + 1]
        v17: int64 = op_subtraction(v2, v14)
        v18: int64 = op_subtraction(v2, int64(1))
        return join("", of_array([v16, "...", v1[int(to_int(v17)):int(to_int(v18)) + 1]]))



def closure40(v0: int64, v1: str) -> str:
    return method6(v0, v1)


def closure39(unit_var: None, v0: int64) -> Callable[[str], str]:
    def _arrow38(v: str, unit_var: Any=unit_var, v0: Any=v0) -> str:
        return closure40(v0, v)

    return _arrow38


def closure41(unit_var: None, v0: Exception) -> str:
    _v3: str | None = None
    x: str = to_text(interpolate("%A%P()", [v0]))
    _v3 = x
    if _v3 is None:
        raise Exception("base.run_target / _v3=None")

    else: 
        return _v3



def method7(v0: int, v1: Mut0) -> bool:
    return v1.l0 < v0


def closure43(v0: str, v1: Array[str]) -> str:
    v2: int = len(v1) or 0
    v4: Mut0 = Mut0(0, "")
    while method7(v2, v4):
        v6: int = v4.l0 or 0
        v9: str = ((v4.l1 + v1[v6]) + v0) + ""
        v10: int = (v6 + 1) or 0
        v4.l0 = v10 or 0
        v4.l1 = v9
    return v4.l1


def closure42(unit_var: None, v0: str) -> Callable[[Array[str]], str]:
    def _arrow40(v: Array[str], unit_var: Any=unit_var, v0: Any=v0) -> str:
        return closure43(v0, v)

    return _arrow40


def closure45(v0: str, v1: IEnumerable_1[str]) -> str:
    return join(v0, v1)


def closure44(unit_var: None, v0: str) -> Callable[[IEnumerable_1[str]], str]:
    def _arrow41(v: IEnumerable_1[str], unit_var: Any=unit_var, v0: Any=v0) -> str:
        return closure45(v0, v)

    return _arrow41


def closure47(v0: str, v1: Array[str]) -> str:
    return join(v0, v1)


def closure46(unit_var: None, v0: str) -> Callable[[Array[str]], str]:
    def _arrow42(v: Array[str], unit_var: Any=unit_var, v0: Any=v0) -> str:
        return closure47(v0, v)

    return _arrow42


def method8(v0: int, v1: Mut1) -> bool:
    return v1.l0 < v0


def closure48(unit_var: None, v0: str) -> Array[str]:
    v1: int = len(v0) or 0
    v2: Array[str] = fill([0] * v1, 0, v1, "")
    v3: Mut1 = Mut1(0)
    while method8(v1, v3):
        v5: int = v3.l0 or 0
        v6: str = v0[v5]
        v2[v5] = v6
        v7: int = (v5 + 1) or 0
        v3.l0 = v7 or 0
    return v2


def _arrow43(v: str) -> Callable[[str], bool]:
    return closure0(None, v)


v24: Callable[[str, str], bool] = _arrow43

def contains(x: str) -> Callable[[str], bool]:
    return v24(x)


def _arrow44(v: str) -> Callable[[str], bool]:
    return closure2(None, v)


v25: Callable[[str, str], bool] = _arrow44

def ends_with(x: str) -> Callable[[str], bool]:
    return v25(x)


def _arrow45(v: int) -> Callable[[str, str], str]:
    return closure4(None, v)


v26: Callable[[int, str, str], str] = _arrow45

def pad_left(x: int) -> Callable[[str, str], str]:
    return v26(x)


def _arrow46(v: int) -> Callable[[str, str], str]:
    return closure7(None, v)


v27: Callable[[int, str, str], str] = _arrow46

def pad_right(x: int) -> Callable[[str, str], str]:
    return v27(x)


def _arrow47(v: str) -> Callable[[str, str], str]:
    return closure10(None, v)


v28: Callable[[str, str, str], str] = _arrow47

def replace(x: str) -> Callable[[str, str], str]:
    return v28(x)


def _arrow48(v: str) -> Callable[[str, str], str]:
    return closure13(None, v)


v29: Callable[[str, str, str], str] = _arrow48

def replace_regex(x: str) -> Callable[[str, str], str]:
    return v29(x)


def _arrow49(v: int) -> Callable[[int, str], str]:
    return closure16(None, v)


v30: Callable[[int, int, str], str] = _arrow49

def slice(x: int) -> Callable[[int, str], str]:
    return v30(x)


def _arrow50(v: str) -> Callable[[str], Array[str]]:
    return closure19(None, v)


v31: Callable[[str, str], Array[str]] = _arrow50

def split(x: str) -> Callable[[str], Array[str]]:
    return v31(x)


def _arrow51(v: Array[str]) -> Callable[[str], Array[str]]:
    return closure21(None, v)


v32: Callable[[Array[str], str], Array[str]] = _arrow51

def split_string(x: Array[str]) -> Callable[[str], Array[str]]:
    return v32(x)


def _arrow53(v: str) -> Callable[[str], bool]:
    return closure23(None, v)


v33: Callable[[str, str], bool] = _arrow53

def starts_with(x: str) -> Callable[[str], bool]:
    return v33(x)


def _arrow54(v: int) -> Callable[[int, str], str]:
    return closure25(None, v)


v34: Callable[[int, int, str], str] = _arrow54

def substring(x: int) -> Callable[[int, str], str]:
    return v34(x)


def _arrow55(v: str) -> str:
    return closure28(None, v)


v35: Callable[[str], str] = _arrow55

def to_lower(x: str) -> str:
    return v35(x)


def _arrow56(v: str) -> str:
    return closure29(None, v)


v36: Callable[[str], str] = _arrow56

def to_upper(x: str) -> str:
    return v36(x)


def _arrow57(v: str) -> str:
    return closure30(None, v)


v37: Callable[[str], str] = _arrow57

def trim(x: str) -> str:
    return v37(x)


def _arrow58(v: Array[str]) -> Callable[[str], str]:
    return closure31(None, v)


v38: Callable[[Array[str], str], str] = _arrow58

def trim_end(x: Array[str]) -> Callable[[str], str]:
    return v38(x)


def _arrow59(v: Array[str]) -> Callable[[str], str]:
    return closure35(None, v)


v39: Callable[[Array[str], str], str] = _arrow59

def trim_start(x: Array[str]) -> Callable[[str], str]:
    return v39(x)


def _arrow60(v: int) -> Callable[[str], str]:
    return closure37(None, v)


v40: Callable[[int, str], str] = _arrow60

def ellipsis(x: int) -> Callable[[str], str]:
    return v40(x)


def _arrow61(v: int64) -> Callable[[str], str]:
    return closure39(None, v)


v41: Callable[[int64, str], str] = _arrow61

def ellipsis_end(x: int64) -> Callable[[str], str]:
    return v41(x)


def _arrow62(v: Exception) -> str:
    return closure41(None, v)


v42: Callable[[Exception], str] = _arrow62

def format_exception(x: Exception) -> str:
    return v42(x)


def _arrow63(v: str) -> Callable[[Array[str]], str]:
    return closure42(None, v)


v43: Callable[[str, Array[str]], str] = _arrow63

def concat_array_trailing(x: str) -> Callable[[Array[str]], str]:
    return v43(x)


def _arrow64(v: str) -> Callable[[IEnumerable_1[str]], str]:
    return closure44(None, v)


v44: Callable[[str, IEnumerable_1[str]], str] = _arrow64

def concat(x: str) -> Callable[[IEnumerable_1[str]], str]:
    return v44(x)


def _arrow65(v: str) -> Callable[[Array[str]], str]:
    return closure46(None, v)


v45: Callable[[str, Array[str]], str] = _arrow65

def join_0027(x: str) -> Callable[[Array[str]], str]:
    return v45(x)


def _arrow66(v: str) -> Array[str]:
    return closure48(None, v)


v46: Callable[[str], Array[str]] = _arrow66

def to_char_array(x: str) -> Array[str]:
    return v46(x)


