from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from typing import Any
from fable_modules.fable_library.async_builder import (CancellationToken, Async)
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.option import (value, some)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, char_type, string_type, int64_type, record_type, bool_type, int32_type, tuple_type, unit_type, class_type, lambda_type)
from fable_modules.fable_library.string_ import (replace, to_text, interpolate, trim_end, trim_start)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, equals, compare)

State_trace_state: tuple[Mut0, Mut1, Mut1, Mut2, int64 | None] | None = create_atom(None)

def _expr67() -> TypeInfo:
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


US0_reflection = _expr67

def _expr68() -> TypeInfo:
    return union_type("Runtime.UH0", [], UH0, lambda: [[], [("Item1", char_type), ("Item2", UH0_reflection())]])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr68

def _expr69() -> TypeInfo:
    return union_type("Runtime.US2", [], US2, lambda: [[], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr69

def _expr70() -> TypeInfo:
    return union_type("Runtime.US1", [], US1, lambda: [[], [("f1_0", US2_reflection())], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1", "US1_2"]


US1_reflection = _expr70

def _expr71() -> TypeInfo:
    return union_type("Runtime.US3", [], US3, lambda: [[("f0_0", string_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr71

def _expr72() -> TypeInfo:
    return record_type("Runtime.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr72

def _expr73() -> TypeInfo:
    return record_type("Runtime.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr73

def _expr74() -> TypeInfo:
    return record_type("Runtime.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr74

def _expr75() -> TypeInfo:
    return union_type("Runtime.US4", [], US4, lambda: [[("f0_0", int64_type)], []])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1"]


US4_reflection = _expr75

def _expr76() -> TypeInfo:
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


US5_reflection = _expr76

def _expr77() -> TypeInfo:
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


US6_reflection = _expr77

def _expr78() -> TypeInfo:
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


US7_reflection = _expr78

def _expr79() -> TypeInfo:
    return union_type("Runtime.US8", [], US8, lambda: [[("f0_0", US0_reflection())], []])


class US8(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US8_0", "US8_1"]


US8_reflection = _expr79

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



def US1__get_IsUS1_2(this: FSharpRef[US1], unit_arg: None) -> bool:
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



def US8__get_IsUS8_0(this: FSharpRef[US8], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US8__get_IsUS8_1(this: FSharpRef[US8], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def closure0(unit_var: None, unit_var_1: None) -> bool:
    _v0: bool | None = None
    _v0 = False
    return value(_v0)


def closure1(unit_var: None, unit_var_1: None) -> str:
    _v0: bool | None = None
    _v0 = False
    if value(_v0):
        return ".exe"

    else: 
        return ""



def method0(__unit: None=None) -> tuple[str, str]:
    return ("", "")


def closure4(v0_1: str, v1_1: UH0) -> UH0:
    return UH0(1, v0_1, v1_1)


def closure3(unit_var: None, v0_1: str) -> Callable[[UH0], UH0]:
    def _arrow80(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure4(v0_1, v)

    return _arrow80


def method1(__unit: None=None) -> Callable[[str, UH0], UH0]:
    def _arrow81(v: str) -> Callable[[UH0], UH0]:
        return closure3(None, v)

    return _arrow81


def method2(v0_1_mut: str, v1_1_mut: str, v2_1_mut: UH0, v3_1_mut: US1) -> tuple[str, str]:
    while True:
        (v0_1, v1_1, v2_1, v3_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut)
        if v2_1.tag == 1:
            v5: UH0 = v2_1.fields[1]
            v4: str = v2_1.fields[0]
            if "\"" == v4:
                if v1_1 == "":
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v5
                    v3_1_mut = US1(1, US2(0))
                    continue

                elif v3_1.tag == 1:
                    if v3_1.fields[0].tag == 0:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5
                        v3_1_mut = US1(1, US2(1))
                        continue

                    elif " " == v4:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5
                        v3_1_mut = US1(2)
                        continue

                    else: 
                        v0_1_mut = v0_1
                        v1_1_mut = ((("" + v1_1) + "") + str(v4)) + ""
                        v2_1_mut = v5
                        v3_1_mut = v3_1
                        continue


                elif v3_1.tag == 0:
                    if " " == v4:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5
                        v3_1_mut = US1(2)
                        continue

                    else: 
                        v0_1_mut = v0_1
                        v1_1_mut = ((("" + v1_1) + "") + str(v4)) + ""
                        v2_1_mut = v5
                        v3_1_mut = v3_1
                        continue


                else: 
                    v0_1_mut = ((("" + v0_1) + "") + str(v4)) + ""
                    v1_1_mut = v1_1
                    v2_1_mut = v5
                    v3_1_mut = US1(2)
                    continue


            elif "\'" == v4:
                if v1_1 == "":
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v5
                    v3_1_mut = US1(1, US2(0))
                    continue

                elif v3_1.tag == 1:
                    if v3_1.fields[0].tag == 0:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5
                        v3_1_mut = US1(1, US2(1))
                        continue

                    elif " " == v4:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5
                        v3_1_mut = US1(2)
                        continue

                    else: 
                        v0_1_mut = v0_1
                        v1_1_mut = ((("" + v1_1) + "") + str(v4)) + ""
                        v2_1_mut = v5
                        v3_1_mut = v3_1
                        continue


                elif v3_1.tag == 0:
                    if " " == v4:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5
                        v3_1_mut = US1(2)
                        continue

                    else: 
                        v0_1_mut = v0_1
                        v1_1_mut = ((("" + v1_1) + "") + str(v4)) + ""
                        v2_1_mut = v5
                        v3_1_mut = v3_1
                        continue


                else: 
                    v0_1_mut = ((("" + v0_1) + "") + str(v4)) + ""
                    v1_1_mut = v1_1
                    v2_1_mut = v5
                    v3_1_mut = US1(2)
                    continue


            elif v3_1.tag == 1:
                if v3_1.fields[0].tag == 0:
                    if " " == v4:
                        v0_1_mut = v0_1
                        v1_1_mut = ("" + v1_1) + " "
                        v2_1_mut = v5
                        v3_1_mut = US1(1, US2(0))
                        continue

                    else: 
                        v0_1_mut = v0_1
                        v1_1_mut = ((("" + v1_1) + "") + str(v4)) + ""
                        v2_1_mut = v5
                        v3_1_mut = v3_1
                        continue


                elif " " == v4:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v5
                    v3_1_mut = US1(2)
                    continue

                else: 
                    v0_1_mut = v0_1
                    v1_1_mut = ((("" + v1_1) + "") + str(v4)) + ""
                    v2_1_mut = v5
                    v3_1_mut = v3_1
                    continue


            elif v3_1.tag == 0:
                if " " == v4:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v5
                    v3_1_mut = US1(2)
                    continue

                else: 
                    v0_1_mut = v0_1
                    v1_1_mut = ((("" + v1_1) + "") + str(v4)) + ""
                    v2_1_mut = v5
                    v3_1_mut = v3_1
                    continue


            else: 
                v0_1_mut = ((("" + v0_1) + "") + str(v4)) + ""
                v1_1_mut = v1_1
                v2_1_mut = v5
                v3_1_mut = US1(2)
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


def closure5(unit_var: None, v0_1: str) -> US3:
    return US3(0, v0_1)


def method3(__unit: None=None) -> Callable[[str], US3]:
    def _arrow82(v: str) -> US3:
        return closure5(None, v)

    return _arrow82


def closure6(v0_1: CancellationToken | None, v1_1: str, v2_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v3_1: US0 | None, v4: str | None, unit_var: None) -> str:
    return to_text(interpolate("execute_with_options_async / options: %A%P()", [(v0_1, v1_1, v2_1, v3_1, v4)]))


def closure7(unit_var: None, unit_var_1: None) -> str:
    return ""


def method4(__unit: None=None) -> Callable[[], str]:
    def _arrow83(__unit: None=None) -> str:
        return closure7(None, None)

    return _arrow83


def method6(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def method7(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def closure8(unit_var: None, unit_var_1: None) -> tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]:
    v0_1: Mut1 = Mut1(True)
    v1_1: Mut0 = Mut0(int64(0))
    v3_1: Mut2 = Mut2(US0(0))
    v4: Mut1 = Mut1(False)
    _v5: (int64 | None) | None = None
    x: int64 | None = method7(None)
    _v5 = some(x)
    return (v1_1, v4, v0_1, v3_1, value(_v5))


def closure10(unit_var: None, v0_1: int64) -> US5:
    return US5(0, v0_1)


def method8(__unit: None=None) -> Callable[[int64], US5]:
    def _arrow84(v: int64) -> US5:
        return closure10(None, v)

    return _arrow84


def method9(__unit: None=None) -> str:
    return ""


def closure9(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if equals(State_trace_state(), None):
        State_trace_state(closure8(None, None))

    pattern_input: tuple[Mut0, Mut1, Mut1, Mut2, int64 | None] = value(State_trace_state())
    _v9: str | None = None
    _v9 = None
    v60: str = value(_v9)
    v61: int64 = pattern_input[0].l0
    v71: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    return trim_end(trim_start(((((((((("" + v60) + " #") + str(v61)) + " [") + v71.lower()) + "] ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method5(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]:
        return closure8(None, None)

    if equals(State_trace_state(), None):
        State_trace_state(v3_1(None))

    v4: Mut0 = value(State_trace_state())[0]
    if equals(State_trace_state(), None):
        State_trace_state(v3_1(None))

    pattern_input_1: tuple[Mut0, Mut1, Mut1, Mut2, int64 | None] = value(State_trace_state())
    v14: US0 = pattern_input_1[3].l0
    if (compare(v0_1, v14) >= 0) if pattern_input_1[2].l0 else False:
        v19: int64 = op_addition(v4.l0, int64(1))
        v4.l0 = v19
        v21: str = ("" + closure9(v0_1, v1_1, v2_1, None)) + ""
        _v22: None | None = None
        _v22 = some(None)
        value(_v22)



def closure12(unit_var: None, v0_1: Callable[[tuple[bool, str, int]], Async[None]]) -> US6:
    return US6(0, v0_1)


def method10(__unit: None=None) -> Callable[[Callable[[tuple[bool, str, int]], Async[None]]], US6]:
    def _arrow85(v: Callable[[tuple[bool, str, int]], Async[None]]) -> US6:
        return closure12(None, v)

    return _arrow85


def closure13(v0_1: str, unit_var: None) -> str:
    return ("> " + v0_1) + ""


def closure11(v0_1: CancellationToken | None, v1_1: str, v2_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v3_1: US0 | None, v4: str | None, v5: None, v6: Any, v7: None) -> None:
    _v8: Async[None] | None = None
    _v8 = None
    v32: Async[None] = value(_v8)
    _v33: None | None = None
    _v33 = some(None)
    value(_v33)


def closure14(v0_1: CancellationToken | None, v1_1: str, v2_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v3_1: US0 | None, v4: str | None, v5: None, v6: Any, v7: None) -> None:
    _v8: Async[None] | None = None
    _v8 = None
    v33: Async[None] = value(_v8)
    _v34: None | None = None
    _v34 = some(None)
    value(_v34)


def closure15(unit_var: None, v0_1: CancellationToken) -> US7:
    return US7(0, v0_1)


def method11(__unit: None=None) -> Callable[[CancellationToken], US7]:
    def _arrow86(v: CancellationToken) -> US7:
        return closure15(None, v)

    return _arrow86


def closure16(v0_1: None, unit_var: None) -> None:
    _v1: bool | None = None
    _v1 = False
    if value(_v1) == False:
        _v10: None | None = None
        _v10 = some(None)
        value(_v10)



def closure17(v0_1: Any, unit_var: None) -> str:
    return to_text(interpolate("execute_with_options_async / WaitForExitAsync / ex: %A%P()", [v0_1]))


def method12(__unit: None=None) -> str:
    return "\n"


def closure18(v0_1: int, v1_1: str, unit_var: None) -> str:
    return ((("execute_with_options_async / exit_code: " + str(v0_1)) + " / output.Length: ") + str(len(v1_1))) + ""


def closure19(unit_var: None, v0_1: US0) -> US8:
    return US8(0, v0_1)


def method13(__unit: None=None) -> Callable[[US0], US8]:
    def _arrow87(v: US0) -> US8:
        return closure19(None, v)

    return _arrow87


def closure2(unit_var: None, v0_1: str) -> Async[tuple[int, str]]:
    _v5: Async[tuple[int, str]] | None = None
    _v5 = None
    return value(_v5)


def closure20(unit_var: None, _arg: tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, US0 | None, str | None]) -> Async[tuple[int, str]]:
    _v5: Async[tuple[int, str]] | None = None
    _v5 = None
    return value(_v5)


def _arrow88(__unit: None=None) -> bool:
    return closure0(None, None)


v0: Callable[[], bool] = _arrow88

def is_windows(__unit: None=None) -> bool:
    return v0(None)


def _arrow89(__unit: None=None) -> str:
    return closure1(None, None)


v1: Callable[[], str] = _arrow89

def get_executable_suffix(__unit: None=None) -> str:
    return v1(None)


def _arrow90(v: str) -> Async[tuple[int, str]]:
    return closure2(None, v)


v2: Callable[[str], Async[tuple[int, str]]] = _arrow90

def execute_async(x: str) -> Async[tuple[int, str]]:
    return v2(x)


def _arrow91(_arg10: tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, US0 | None, str | None]) -> Async[tuple[int, str]]:
    return closure20(None, _arg10)


v3: Callable[[tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, US0 | None, str | None]], Async[tuple[int, str]]] = _arrow91

def execute_with_options_async(x: tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, US0 | None, str | None]) -> Async[tuple[int, str]]:
    return v3(x)


