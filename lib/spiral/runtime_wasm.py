from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from typing import Any
from fable_modules.fable_library.async_builder import (CancellationToken, Async)
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.option import (some, value)
from fable_modules.fable_library.reflection import (TypeInfo, int64_type, record_type, bool_type, union_type, char_type, string_type, int32_type, tuple_type, unit_type, class_type, lambda_type)
from fable_modules.fable_library.string_ import (replace, to_text, interpolate, trim_end, trim_start)
from fable_modules.fable_library.types import (int64, Record, Array, Union, FSharpRef)
from fable_modules.fable_library.util import (create_atom, equals, compare)

State_trace_state: tuple[Mut0, Mut1, Mut1, Mut2, int64 | None] | None = create_atom(None)

def _expr91() -> TypeInfo:
    return record_type("Runtime.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr91

def _expr92() -> TypeInfo:
    return record_type("Runtime.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr92

def _expr93() -> TypeInfo:
    return union_type("Runtime.US0", [], US0, lambda: [[], [], [], [], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1", "US0_2", "US0_3", "US0_4"]


US0_reflection = _expr93

def _expr94() -> TypeInfo:
    return record_type("Runtime.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr94

def _expr95() -> TypeInfo:
    return union_type("Runtime.US1", [], US1, lambda: [[("f0_0", int64_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr95

def _expr96() -> TypeInfo:
    return union_type("Runtime.UH0", [], UH0, lambda: [[], [("Item1", char_type), ("Item2", UH0_reflection())]])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr96

def _expr97() -> TypeInfo:
    return union_type("Runtime.US3", [], US3, lambda: [[], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr97

def _expr98() -> TypeInfo:
    return union_type("Runtime.US2", [], US2, lambda: [[], [("f1_0", US3_reflection())], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1", "US2_2"]


US2_reflection = _expr98

def _expr99() -> TypeInfo:
    return union_type("Runtime.US4", [], US4, lambda: [[("f0_0", string_type)], []])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1"]


US4_reflection = _expr99

def _expr100() -> TypeInfo:
    return union_type("Runtime.US5", [], US5, lambda: [[("f0_0", int64_type)], []])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr100

def _expr101() -> TypeInfo:
    return union_type("Runtime.US6", [], US6, lambda: [[("f0_0", lambda_type(tuple_type(bool_type, string_type, int32_type), class_type("Microsoft.FSharp.Control.FSharpAsync`1", [unit_type])))], []])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1"]


US6_reflection = _expr101

def _expr102() -> TypeInfo:
    return union_type("Runtime.US7", [], US7, lambda: [[("f0_0", class_type("System.Threading.CancellationToken"))], []])


class US7(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US7_0", "US7_1"]


US7_reflection = _expr102

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



def US0__get_IsUS0_2(this: FSharpRef[US0], unit_arg: None) -> bool:
    if this.tag == 2:
        return True

    else: 
        return False



def US0__get_IsUS0_3(this: FSharpRef[US0], unit_arg: None) -> bool:
    if this.tag == 3:
        return True

    else: 
        return False



def US0__get_IsUS0_4(this: FSharpRef[US0], unit_arg: None) -> bool:
    if this.tag == 4:
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



def UH0__get_IsUH0_0(this: UH0, unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def UH0__get_IsUH0_1(this: UH0, unit_arg: None) -> bool:
    if this.tag == 1:
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



def US4__get_IsUS4_0(this: FSharpRef[US4], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US4__get_IsUS4_1(this: FSharpRef[US4], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US5__get_IsUS5_0(this: FSharpRef[US5], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US5__get_IsUS5_1(this: FSharpRef[US5], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US6__get_IsUS6_0(this: FSharpRef[US6], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US6__get_IsUS6_1(this: FSharpRef[US6], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US7__get_IsUS7_0(this: FSharpRef[US7], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US7__get_IsUS7_1(this: FSharpRef[US7], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def method0(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def method1(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def closure0(unit_var: None, unit_var_1: None) -> tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]:
    v0_1: Mut1 = Mut1(True)
    v1_1: Mut0 = Mut0(int64(0))
    v3_1: Mut2 = Mut2(US0(0))
    v4_1: Mut1 = Mut1(False)
    _v5: (int64 | None) | None = None
    x: int64 | None = method1(None)
    _v5 = some(x)
    return (v1_1, v4_1, v0_1, v3_1, value(_v5))


def closure1(unit_var: None, unit_var_1: None) -> bool:
    _v0: bool | None = None
    _v0 = False
    return value(_v0)


def closure2(unit_var: None, unit_var_1: None) -> str:
    _v0: bool | None = None
    _v0 = False
    if value(_v0):
        return ".exe"

    else: 
        return ""



def method2(__unit: None=None) -> tuple[str, str]:
    return ("", "")


def closure5(v0_1: str, v1_1: UH0) -> UH0:
    return UH0(1, v0_1, v1_1)


def closure4(unit_var: None, v0_1: str) -> Callable[[UH0], UH0]:
    def _arrow103(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure5(v0_1, v)

    return _arrow103


def method3(__unit: None=None) -> Callable[[str, UH0], UH0]:
    def _arrow104(v: str) -> Callable[[UH0], UH0]:
        return closure4(None, v)

    return _arrow104


def method4(v0_1_mut: str, v1_1_mut: str, v2_1_mut: UH0, v3_1_mut: US2) -> tuple[str, str]:
    while True:
        (v0_1, v1_1, v2_1, v3_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut)
        if v2_1.tag == 1:
            v5: UH0 = v2_1.fields[1]
            v4_1: str = v2_1.fields[0]
            if "\"" == v4_1:
                if v1_1 == "":
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v5
                    v3_1_mut = US2(1, US3(0))
                    continue

                elif v3_1.tag == 1:
                    if v3_1.fields[0].tag == 0:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5
                        v3_1_mut = US2(1, US3(1))
                        continue

                    elif " " == v4_1:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5
                        v3_1_mut = US2(2)
                        continue

                    else: 
                        v0_1_mut = v0_1
                        v1_1_mut = ((("" + v1_1) + "") + str(v4_1)) + ""
                        v2_1_mut = v5
                        v3_1_mut = v3_1
                        continue


                elif v3_1.tag == 0:
                    if " " == v4_1:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5
                        v3_1_mut = US2(2)
                        continue

                    else: 
                        v0_1_mut = v0_1
                        v1_1_mut = ((("" + v1_1) + "") + str(v4_1)) + ""
                        v2_1_mut = v5
                        v3_1_mut = v3_1
                        continue


                else: 
                    v0_1_mut = ((("" + v0_1) + "") + str(v4_1)) + ""
                    v1_1_mut = v1_1
                    v2_1_mut = v5
                    v3_1_mut = US2(2)
                    continue


            elif "\'" == v4_1:
                if v1_1 == "":
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v5
                    v3_1_mut = US2(1, US3(0))
                    continue

                elif v3_1.tag == 1:
                    if v3_1.fields[0].tag == 0:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5
                        v3_1_mut = US2(1, US3(1))
                        continue

                    elif " " == v4_1:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5
                        v3_1_mut = US2(2)
                        continue

                    else: 
                        v0_1_mut = v0_1
                        v1_1_mut = ((("" + v1_1) + "") + str(v4_1)) + ""
                        v2_1_mut = v5
                        v3_1_mut = v3_1
                        continue


                elif v3_1.tag == 0:
                    if " " == v4_1:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5
                        v3_1_mut = US2(2)
                        continue

                    else: 
                        v0_1_mut = v0_1
                        v1_1_mut = ((("" + v1_1) + "") + str(v4_1)) + ""
                        v2_1_mut = v5
                        v3_1_mut = v3_1
                        continue


                else: 
                    v0_1_mut = ((("" + v0_1) + "") + str(v4_1)) + ""
                    v1_1_mut = v1_1
                    v2_1_mut = v5
                    v3_1_mut = US2(2)
                    continue


            elif v3_1.tag == 1:
                if v3_1.fields[0].tag == 0:
                    if " " == v4_1:
                        v0_1_mut = v0_1
                        v1_1_mut = ("" + v1_1) + " "
                        v2_1_mut = v5
                        v3_1_mut = US2(1, US3(0))
                        continue

                    else: 
                        v0_1_mut = v0_1
                        v1_1_mut = ((("" + v1_1) + "") + str(v4_1)) + ""
                        v2_1_mut = v5
                        v3_1_mut = v3_1
                        continue


                elif " " == v4_1:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v5
                    v3_1_mut = US2(2)
                    continue

                else: 
                    v0_1_mut = v0_1
                    v1_1_mut = ((("" + v1_1) + "") + str(v4_1)) + ""
                    v2_1_mut = v5
                    v3_1_mut = v3_1
                    continue


            elif v3_1.tag == 0:
                if " " == v4_1:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v5
                    v3_1_mut = US2(2)
                    continue

                else: 
                    v0_1_mut = v0_1
                    v1_1_mut = ((("" + v1_1) + "") + str(v4_1)) + ""
                    v2_1_mut = v5
                    v3_1_mut = v3_1
                    continue


            else: 
                v0_1_mut = ((("" + v0_1) + "") + str(v4_1)) + ""
                v1_1_mut = v1_1
                v2_1_mut = v5
                v3_1_mut = US2(2)
                continue


        elif v3_1.tag == 1:
            if v3_1.fields[0].tag == 0:
                return (replace(v1_1, "\\", "/"), v0_1)

            else: 
                return (replace(v1_1, "\\", "/"), v0_1)


        elif v3_1.tag == 0:
            return (replace(v1_1, "\\", "/"), v0_1)

        else: 
            return (replace(v1_1, "\\", "/"), v0_1)

        break


def closure6(unit_var: None, v0_1: str) -> US4:
    return US4(0, v0_1)


def method5(__unit: None=None) -> Callable[[str], US4]:
    def _arrow105(v: str) -> US4:
        return closure6(None, v)

    return _arrow105


def closure7(v0_1: CancellationToken | None, v1_1: str, v2_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v3_1: str | None, unit_var: None) -> str:
    return to_text(interpolate("execute_with_options_async / options: %A%P()", [(v0_1, v1_1, v2_1, v3_1)]))


def closure8(unit_var: None, unit_var_1: None) -> str:
    return ""


def method6(__unit: None=None) -> Callable[[], str]:
    def _arrow106(__unit: None=None) -> str:
        return closure8(None, None)

    return _arrow106


def closure10(unit_var: None, v0_1: int64) -> US5:
    return US5(0, v0_1)


def method8(__unit: None=None) -> Callable[[int64], US5]:
    def _arrow107(v: int64) -> US5:
        return closure10(None, v)

    return _arrow107


def method9(__unit: None=None) -> str:
    return ""


def closure9(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if equals(State_trace_state(), None):
        State_trace_state(closure0(None, None))

    pattern_input: tuple[Mut0, Mut1, Mut1, Mut2, int64 | None] = value(State_trace_state())
    _v9: str | None = None
    _v9 = None
    v61: str = value(_v9)
    v62: int64 = pattern_input[0].l0
    v72: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    v73: str = v72.lower()
    _v74: str | None = None
    _v74 = None
    return trim_end(trim_start(((((((((("" + v61) + " ") + value(_v74)) + " #") + str(v62)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method7(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]:
        return closure0(None, None)

    if equals(State_trace_state(), None):
        State_trace_state(v3_1(None))

    v4_1: Mut0 = value(State_trace_state())[0]
    if equals(State_trace_state(), None):
        State_trace_state(v3_1(None))

    pattern_input_1: tuple[Mut0, Mut1, Mut1, Mut2, int64 | None] = value(State_trace_state())
    v14: US0 = pattern_input_1[3].l0
    if (compare(v0_1, v14) >= 0) if pattern_input_1[2].l0 else False:
        v19: int64 = op_addition(v4_1.l0, int64(1))
        v4_1.l0 = v19
        v21: str = ("" + closure9(v0_1, v1_1, v2_1, None)) + ""
        _v22: None | None = None
        _v22 = some(None)
        value(_v22)



def closure12(unit_var: None, v0_1: Callable[[tuple[bool, str, int]], Async[None]]) -> US6:
    return US6(0, v0_1)


def method10(__unit: None=None) -> Callable[[Callable[[tuple[bool, str, int]], Async[None]]], US6]:
    def _arrow108(v: Callable[[tuple[bool, str, int]], Async[None]]) -> US6:
        return closure12(None, v)

    return _arrow108


def closure13(v0_1: str, unit_var: None) -> str:
    return ("> " + v0_1) + ""


def closure11(v0_1: CancellationToken | None, v1_1: str, v2_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v3_1: str | None, v4_1: None, v5: Any, v6: None) -> None:
    _v7: Async[None] | None = None
    _v7 = None
    v32: Async[None] = value(_v7)
    _v33: None | None = None
    _v33 = some(None)
    value(_v33)


def closure14(v0_1: CancellationToken | None, v1_1: str, v2_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v3_1: str | None, v4_1: None, v5: Any, v6: None) -> None:
    _v7: Async[None] | None = None
    _v7 = None
    v33: Async[None] = value(_v7)
    _v34: None | None = None
    _v34 = some(None)
    value(_v34)


def closure15(unit_var: None, v0_1: CancellationToken) -> US7:
    return US7(0, v0_1)


def method11(__unit: None=None) -> Callable[[CancellationToken], US7]:
    def _arrow109(v: CancellationToken) -> US7:
        return closure15(None, v)

    return _arrow109


def closure16(v0_1: None, unit_var: None) -> None:
    _v1: bool | None = None
    _v1 = False
    if value(_v1) == False:
        _v11: None | None = None
        _v11 = some(None)
        value(_v11)



def closure17(v0_1: Any, unit_var: None) -> str:
    return to_text(interpolate("execute_with_options_async / WaitForExitAsync / ex: %A%P()", [v0_1]))


def method12(__unit: None=None) -> str:
    return "\n"


def closure18(v0_1: int, v1_1: str, unit_var: None) -> str:
    return ((("execute_with_options_async / exit_code: " + str(v0_1)) + " / output.Length: ") + str(len(v1_1))) + ""


def closure3(unit_var: None, v0_1: str) -> Async[tuple[int, str]]:
    _v4: Async[tuple[int, str]] | None = None
    _v4 = None
    return value(_v4)


def closure19(unit_var: None, _arg: tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, str | None]) -> Async[tuple[int, str]]:
    _v4: Async[tuple[int, str]] | None = None
    _v4 = None
    return value(_v4)


def _arrow110(__unit: None=None) -> tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]:
    return closure0(None, None)


v0: Callable[[], tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]] = _arrow110


if equals(State_trace_state(), None):
    State_trace_state(v0(None))


def _arrow111(__unit: None=None) -> bool:
    return closure1(None, None)


v1: Callable[[], bool] = _arrow111

def is_windows(__unit: None=None) -> bool:
    return v1(None)


def _arrow112(__unit: None=None) -> str:
    return closure2(None, None)


v2: Callable[[], str] = _arrow112

def get_executable_suffix(__unit: None=None) -> str:
    return v2(None)


def _arrow113(v: str) -> Async[tuple[int, str]]:
    return closure3(None, v)


v3: Callable[[str], Async[tuple[int, str]]] = _arrow113

def execute_async(x: str) -> Async[tuple[int, str]]:
    return v3(x)


def _arrow114(_arg10: tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, str | None]) -> Async[tuple[int, str]]:
    return closure19(None, _arg10)


v4: Callable[[tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, str | None]], Async[tuple[int, str]]] = _arrow114

def execute_with_options_async(x: tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, str | None]) -> Async[tuple[int, str]]:
    return v4(x)


