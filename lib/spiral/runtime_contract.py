from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from typing import Any
from fable_modules.fable_library.async_builder import (CancellationToken, Async)
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value)
from fable_modules.fable_library.reflection import (TypeInfo, int64_type, record_type, bool_type, union_type, string_type, unit_type, lambda_type, char_type, int32_type, tuple_type, class_type)
from fable_modules.fable_library.string_ import (replace, to_text, interpolate, trim_end, trim_start)
from fable_modules.fable_library.types import (int64, Record, Array, Union, FSharpRef)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare)

State_trace_state: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] | None = create_atom(None)

def _expr104() -> TypeInfo:
    return record_type("Runtime.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr104

def _expr105() -> TypeInfo:
    return record_type("Runtime.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr105

def _expr106() -> TypeInfo:
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


US0_reflection = _expr106

def _expr107() -> TypeInfo:
    return record_type("Runtime.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr107

def _expr108() -> TypeInfo:
    return record_type("Runtime.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr108

def _expr109() -> TypeInfo:
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


US1_reflection = _expr109

def _expr110() -> TypeInfo:
    return union_type("Runtime.UH0", [], UH0, lambda: [[], [("Item1", char_type), ("Item2", UH0_reflection())]])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr110

def _expr111() -> TypeInfo:
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


US3_reflection = _expr111

def _expr112() -> TypeInfo:
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


US2_reflection = _expr112

def _expr113() -> TypeInfo:
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


US4_reflection = _expr113

def _expr114() -> TypeInfo:
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


US5_reflection = _expr114

def _expr115() -> TypeInfo:
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


US6_reflection = _expr115

def _expr116() -> TypeInfo:
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


US7_reflection = _expr116

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



def closure1(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def method1(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def closure0(unit_var: None, unit_var_1: None) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    v0_1: Mut1 = Mut1(True)
    v1_1: Mut0 = Mut0(int64(0))
    v3_1: Mut2 = Mut2(US0(0))
    def v4_1(v: str, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure1(None, v)

    v5: Mut3 = Mut3(v4_1)
    _v6: (int64 | None) | None = None
    x: int64 | None = method1(None)
    _v6 = some(x)
    return (v1_1, v0_1, v3_1, value(_v6), v5)


def closure2(unit_var: None, unit_var_1: None) -> bool:
    _v0: bool | None = None
    _v0 = False
    return value(_v0)


def closure3(unit_var: None, unit_var_1: None) -> str:
    _v0: bool | None = None
    _v0 = False
    if value(_v0):
        return ".exe"

    else: 
        return ""



def method2(__unit: None=None) -> tuple[str, str]:
    return ("", "")


def closure6(v0_1: str, v1_1: UH0) -> UH0:
    return UH0(1, v0_1, v1_1)


def closure5(unit_var: None, v0_1: str) -> Callable[[UH0], UH0]:
    def _arrow117(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure6(v0_1, v)

    return _arrow117


def method3(__unit: None=None) -> Callable[[str, UH0], UH0]:
    def _arrow118(v: str) -> Callable[[UH0], UH0]:
        return closure5(None, v)

    return _arrow118


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


def closure7(unit_var: None, v0_1: str) -> US4:
    return US4(0, v0_1)


def method5(__unit: None=None) -> Callable[[str], US4]:
    def _arrow119(v: str) -> US4:
        return closure7(None, v)

    return _arrow119


def closure8(v0_1: CancellationToken | None, v1_1: str, v2_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v3_1: str | None, unit_var: None) -> str:
    return to_text(interpolate("execute_with_options_async / options: %A%P()", [(v0_1, v1_1, v2_1, v3_1)]))


def closure9(unit_var: None, unit_var_1: None) -> str:
    return ""


def method6(__unit: None=None) -> Callable[[], str]:
    def _arrow120(__unit: None=None) -> str:
        return closure9(None, None)

    return _arrow120


def closure11(unit_var: None, v0_1: int64) -> US5:
    return US5(0, v0_1)


def method8(__unit: None=None) -> Callable[[int64], US5]:
    def _arrow121(v: int64) -> US5:
        return closure11(None, v)

    return _arrow121


def method9(__unit: None=None) -> str:
    return ""


def closure10(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, None))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    _v9: str | None = None
    _v9 = None
    v61: str = value(_v9)
    v62: int64 = pattern_input[0].l0
    v72: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    v73: str = v72.lower()
    _v74: str | None = None
    _v74 = None
    return trim_end(trim_start(((((((((("" + v61) + " ") + value(_v74)) + " #") + str(v62)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method10(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
        return closure0(None, None)

    if State_trace_state() is None:
        State_trace_state(v2_1(None))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    v3_1: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(None))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    v13: US0 = pattern_input_1[2].l0
    class ObjectExpr122:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr123:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr122())) >= find(v13, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr123()))):
        v21: int64 = op_addition(v3_1.l0, int64(1))
        v3_1.l0 = v21
        v22: str = ("" + v1_1(None)) + ""
        _v23: None | None = None
        _v23 = some(None)
        value(_v23)
        pattern_input[4].l0(v22)



def method7(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure10(v0_1, v1_1, v2_1, None)

    method10(v0_1, v3_1)


def closure13(unit_var: None, v0_1: Callable[[tuple[bool, str, int]], Async[None]]) -> US6:
    return US6(0, v0_1)


def method11(__unit: None=None) -> Callable[[Callable[[tuple[bool, str, int]], Async[None]]], US6]:
    def _arrow124(v: Callable[[tuple[bool, str, int]], Async[None]]) -> US6:
        return closure13(None, v)

    return _arrow124


def closure14(v0_1: str, unit_var: None) -> str:
    return ("> " + v0_1) + ""


def closure12(v0_1: CancellationToken | None, v1_1: str, v2_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v3_1: str | None, v4_1: None, v5: Any, v6: None) -> None:
    _v7: Async[None] | None = None
    _v7 = None
    v32: Async[None] = value(_v7)
    _v33: None | None = None
    _v33 = some(None)
    value(_v33)


def closure15(v0_1: CancellationToken | None, v1_1: str, v2_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v3_1: str | None, v4_1: None, v5: Any, v6: None) -> None:
    _v7: Async[None] | None = None
    _v7 = None
    v33: Async[None] = value(_v7)
    _v34: None | None = None
    _v34 = some(None)
    value(_v34)


def closure16(unit_var: None, v0_1: CancellationToken) -> US7:
    return US7(0, v0_1)


def method12(__unit: None=None) -> Callable[[CancellationToken], US7]:
    def _arrow125(v: CancellationToken) -> US7:
        return closure16(None, v)

    return _arrow125


def closure17(v0_1: None, unit_var: None) -> None:
    _v1: bool | None = None
    _v1 = False
    if value(_v1) == False:
        _v11: None | None = None
        _v11 = some(None)
        value(_v11)



def closure18(v0_1: Any, unit_var: None) -> str:
    return to_text(interpolate("execute_with_options_async / WaitForExitAsync / ex: %A%P()", [v0_1]))


def method13(__unit: None=None) -> str:
    return "\n"


def closure19(v0_1: int, v1_1: str, unit_var: None) -> str:
    return ((("execute_with_options_async / exit_code: " + str(v0_1)) + " / output.Length: ") + str(len(v1_1))) + ""


def closure4(unit_var: None, v0_1: str) -> Async[tuple[int, str]]:
    _v4: Async[tuple[int, str]] | None = None
    _v4 = None
    return value(_v4)


def closure20(unit_var: None, _arg: tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, str | None]) -> Async[tuple[int, str]]:
    _v4: Async[tuple[int, str]] | None = None
    _v4 = None
    return value(_v4)


def _arrow126(__unit: None=None) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, None)


v0: Callable[[], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow126


if State_trace_state() is None:
    State_trace_state(v0(None))


def _arrow127(__unit: None=None) -> bool:
    return closure2(None, None)


v1: Callable[[], bool] = _arrow127

def is_windows(__unit: None=None) -> bool:
    return v1(None)


def _arrow128(__unit: None=None) -> str:
    return closure3(None, None)


v2: Callable[[], str] = _arrow128

def get_executable_suffix(__unit: None=None) -> str:
    return v2(None)


def _arrow129(v: str) -> Async[tuple[int, str]]:
    return closure4(None, v)


v3: Callable[[str], Async[tuple[int, str]]] = _arrow129

def execute_async(x: str) -> Async[tuple[int, str]]:
    return v3(x)


def _arrow130(_arg10: tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, str | None]) -> Async[tuple[int, str]]:
    return closure20(None, _arg10)


v4: Callable[[tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, str | None]], Async[tuple[int, str]]] = _arrow130

def execute_with_options_async(x: tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, str | None]) -> Async[tuple[int, str]]:
    return v4(x)


