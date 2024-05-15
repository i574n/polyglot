from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from typing import Any
from fable_modules.fable_library.array_ import fill
from fable_modules.fable_library.async_builder import (CancellationToken, Async)
from fable_modules.fable_library.list import (cons, FSharpList, of_array, to_array, fold_back, empty)
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_2, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, int64_type, record_type, bool_type, union_type, string_type, unit_type, lambda_type, int32_type, char_type, tuple_type, class_type, uint8_type)
from fable_modules.fable_library.string_ import (replace, to_text, interpolate, pad_right, trim_end, trim_start)
from fable_modules.fable_library.types import (int64, Record, Array, Union, FSharpRef, uint8)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare, equals, uncurry2)

State_trace_state: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] | None = create_atom(None)

def _expr115() -> TypeInfo:
    return record_type("Runtime.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr115

def _expr116() -> TypeInfo:
    return record_type("Runtime.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr116

def _expr117() -> TypeInfo:
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


US0_reflection = _expr117

def _expr118() -> TypeInfo:
    return record_type("Runtime.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr118

def _expr119() -> TypeInfo:
    return record_type("Runtime.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr119

def _expr120() -> TypeInfo:
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


US1_reflection = _expr120

def _expr121() -> TypeInfo:
    return record_type("Runtime.Mut4", [], Mut4, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: int

Mut4_reflection = _expr121

def _expr122() -> TypeInfo:
    return union_type("Runtime.UH0", [], UH0, lambda: [[], [("Item1", char_type), ("Item2", UH0_reflection())]])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr122

def _expr123() -> TypeInfo:
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


US3_reflection = _expr123

def _expr124() -> TypeInfo:
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


US2_reflection = _expr124

def _expr125() -> TypeInfo:
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


US4_reflection = _expr125

def _expr126() -> TypeInfo:
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


US5_reflection = _expr126

def _expr127() -> TypeInfo:
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


US6_reflection = _expr127

def _expr128() -> TypeInfo:
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


US7_reflection = _expr128

def _expr129() -> TypeInfo:
    return union_type("Runtime.UH1", [], UH1, lambda: [[], [("Item1", string_type), ("Item2", UH1_reflection())]])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr129

def _expr130() -> TypeInfo:
    return union_type("Runtime.US8", [], US8, lambda: [[], [("f1_0", char_type)], [("f2_0", uint8_type)]])


class US8(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US8_0", "US8_1", "US8_2"]


US8_reflection = _expr130

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



def UH1__get_IsUH1_0(this: UH1, unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def UH1__get_IsUH1_1(this: UH1, unit_arg: None) -> bool:
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



def US8__get_IsUS8_2(this: FSharpRef[US8], unit_arg: None) -> bool:
    if this.tag == 2:
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

    v5_1: Mut3 = Mut3(v4_1)
    _v6: (int64 | None) | None = None
    x: int64 | None = method1(None)
    _v6 = some(x)
    return (v1_1, v0_1, v3_1, value_2(_v6), v5_1)


def closure2(unit_var: None, unit_var_1: None) -> bool:
    _v0: bool | None = None
    _v0 = None
    return value_2(_v0)


def closure3(unit_var: None, unit_var_1: None) -> str:
    _v0: bool | None = None
    _v0 = None
    if value_2(_v0):
        return ".exe"

    else: 
        return ""



def method2(__unit: None=None) -> tuple[str, str]:
    return ("", "")


def method3(v0_1: int, v1_1: Mut4) -> bool:
    return v1_1.l0 < v0_1


def closure6(v0_1: str, v1_1: UH0) -> UH0:
    return UH0(1, v0_1, v1_1)


def closure5(unit_var: None, v0_1: str) -> Callable[[UH0], UH0]:
    def _arrow131(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure6(v0_1, v)

    return _arrow131


def method4(__unit: None=None) -> Callable[[str, UH0], UH0]:
    def _arrow132(v: str) -> Callable[[UH0], UH0]:
        return closure5(None, v)

    return _arrow132


def method5(v0_1_mut: str, v1_1_mut: str, v2_1_mut: UH0, v3_1_mut: US2) -> tuple[str, str]:
    while True:
        (v0_1, v1_1, v2_1, v3_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut)
        if v2_1.tag == 1:
            v5_1: UH0 = v2_1.fields[1]
            v4_1: str = v2_1.fields[0]
            if "\"" == v4_1:
                if v1_1 == "":
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v5_1
                    v3_1_mut = US2(1, US3(0))
                    continue

                elif v3_1.tag == 1:
                    if v3_1.fields[0].tag == 0:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5_1
                        v3_1_mut = US2(1, US3(1))
                        continue

                    elif " " == v4_1:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5_1
                        v3_1_mut = US2(2)
                        continue

                    else: 
                        v0_1_mut = v0_1
                        v1_1_mut = ((("" + v1_1) + "") + str(v4_1)) + ""
                        v2_1_mut = v5_1
                        v3_1_mut = v3_1
                        continue


                elif v3_1.tag == 0:
                    if " " == v4_1:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5_1
                        v3_1_mut = US2(2)
                        continue

                    else: 
                        v0_1_mut = v0_1
                        v1_1_mut = ((("" + v1_1) + "") + str(v4_1)) + ""
                        v2_1_mut = v5_1
                        v3_1_mut = v3_1
                        continue


                else: 
                    v0_1_mut = ((("" + v0_1) + "") + str(v4_1)) + ""
                    v1_1_mut = v1_1
                    v2_1_mut = v5_1
                    v3_1_mut = US2(2)
                    continue


            elif "\'" == v4_1:
                if v1_1 == "":
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v5_1
                    v3_1_mut = US2(1, US3(0))
                    continue

                elif v3_1.tag == 1:
                    if v3_1.fields[0].tag == 0:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5_1
                        v3_1_mut = US2(1, US3(1))
                        continue

                    elif " " == v4_1:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5_1
                        v3_1_mut = US2(2)
                        continue

                    else: 
                        v0_1_mut = v0_1
                        v1_1_mut = ((("" + v1_1) + "") + str(v4_1)) + ""
                        v2_1_mut = v5_1
                        v3_1_mut = v3_1
                        continue


                elif v3_1.tag == 0:
                    if " " == v4_1:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5_1
                        v3_1_mut = US2(2)
                        continue

                    else: 
                        v0_1_mut = v0_1
                        v1_1_mut = ((("" + v1_1) + "") + str(v4_1)) + ""
                        v2_1_mut = v5_1
                        v3_1_mut = v3_1
                        continue


                else: 
                    v0_1_mut = ((("" + v0_1) + "") + str(v4_1)) + ""
                    v1_1_mut = v1_1
                    v2_1_mut = v5_1
                    v3_1_mut = US2(2)
                    continue


            elif v3_1.tag == 1:
                if v3_1.fields[0].tag == 0:
                    if " " == v4_1:
                        v0_1_mut = v0_1
                        v1_1_mut = ("" + v1_1) + " "
                        v2_1_mut = v5_1
                        v3_1_mut = US2(1, US3(0))
                        continue

                    else: 
                        v0_1_mut = v0_1
                        v1_1_mut = ((("" + v1_1) + "") + str(v4_1)) + ""
                        v2_1_mut = v5_1
                        v3_1_mut = v3_1
                        continue


                elif " " == v4_1:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v5_1
                    v3_1_mut = US2(2)
                    continue

                else: 
                    v0_1_mut = v0_1
                    v1_1_mut = ((("" + v1_1) + "") + str(v4_1)) + ""
                    v2_1_mut = v5_1
                    v3_1_mut = v3_1
                    continue


            elif v3_1.tag == 0:
                if " " == v4_1:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v5_1
                    v3_1_mut = US2(2)
                    continue

                else: 
                    v0_1_mut = v0_1
                    v1_1_mut = ((("" + v1_1) + "") + str(v4_1)) + ""
                    v2_1_mut = v5_1
                    v3_1_mut = v3_1
                    continue


            else: 
                v0_1_mut = ((("" + v0_1) + "") + str(v4_1)) + ""
                v1_1_mut = v1_1
                v2_1_mut = v5_1
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


def method6(__unit: None=None) -> Callable[[str], US4]:
    def _arrow133(v: str) -> US4:
        return closure7(None, v)

    return _arrow133


def closure8(v0_1: CancellationToken | None, v1_1: str, v2_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v3_1: str | None, unit_var: None) -> str:
    return to_text(interpolate("execute_with_options_async / options: %A%P()", [(v0_1, v1_1, v2_1, v3_1)]))


def closure9(unit_var: None, unit_var_1: None) -> str:
    return ""


def method7(__unit: None=None) -> Callable[[], str]:
    def _arrow134(__unit: None=None) -> str:
        return closure9(None, None)

    return _arrow134


def closure11(unit_var: None, v0_1: int64) -> US5:
    return US5(0, v0_1)


def method9(__unit: None=None) -> Callable[[int64], US5]:
    def _arrow135(v: int64) -> US5:
        return closure11(None, v)

    return _arrow135


def method10(__unit: None=None) -> str:
    return ""


def closure10(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, None))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_2(State_trace_state())
    _v9: str | None = None
    x: str = method10()
    _v9 = x
    v61: str = value_2(_v9)
    v62: int64 = pattern_input[0].l0
    v72: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    _v75: str | None = None
    x_1: str = pad_right(v72.lower(), 7, " ")
    _v75 = x_1
    return trim_end(trim_start(((((((((("" + v61) + " ") + value_2(_v75)) + " #") + str(v62)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method11(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
        return closure0(None, None)

    if State_trace_state() is None:
        State_trace_state(v2_1(None))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_2(State_trace_state())
    v3_1: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(None))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_2(State_trace_state())
    v13: US0 = pattern_input_1[2].l0
    class ObjectExpr136:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr137:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr136())) >= find(v13, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr137()))):
        v21: int64 = op_addition(v3_1.l0, int64(1))
        v3_1.l0 = v21
        v22: str = ("" + v1_1(None)) + ""
        _v23: None | None = None
        print(v22)
        _v23 = some(None)
        value_2(_v23)
        pattern_input[4].l0(v22)



def method8(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure10(v0_1, v1_1, v2_1, None)

    method11(v0_1, v3_1)


def closure13(unit_var: None, v0_1: Callable[[tuple[bool, str, int]], Async[None]]) -> US6:
    return US6(0, v0_1)


def method12(__unit: None=None) -> Callable[[Callable[[tuple[bool, str, int]], Async[None]]], US6]:
    def _arrow138(v: Callable[[tuple[bool, str, int]], Async[None]]) -> US6:
        return closure13(None, v)

    return _arrow138


def closure14(v0_1: str, unit_var: None) -> str:
    return ("> " + v0_1) + ""


def closure12(v0_1: CancellationToken | None, v1_1: str, v2_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v3_1: str | None, v4_1: None, v5_1: Any, v6: None) -> None:
    _v7: Async[None] | None = None
    _v7 = None
    v32: Async[None] = value_2(_v7)
    _v33: None | None = None
    _v33 = some(None)
    value_2(_v33)


def closure15(v0_1: CancellationToken | None, v1_1: str, v2_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v3_1: str | None, v4_1: None, v5_1: Any, v6: None) -> None:
    _v7: Async[None] | None = None
    _v7 = None
    v33: Async[None] = value_2(_v7)
    _v34: None | None = None
    _v34 = some(None)
    value_2(_v34)


def closure16(unit_var: None, v0_1: CancellationToken) -> US7:
    return US7(0, v0_1)


def method13(__unit: None=None) -> Callable[[CancellationToken], US7]:
    def _arrow139(v: CancellationToken) -> US7:
        return closure16(None, v)

    return _arrow139


def closure17(v0_1: None, unit_var: None) -> None:
    _v1: bool | None = None
    _v1 = None
    if value_2(_v1) == False:
        _v11: None | None = None
        _v11 = some(None)
        value_2(_v11)



def closure18(v0_1: Any, unit_var: None) -> str:
    return to_text(interpolate("execute_with_options_async / WaitForExitAsync / ex: %A%P()", [v0_1]))


def method14(__unit: None=None) -> str:
    return "\n"


def closure19(v0_1: int, v1_1: str, unit_var: None) -> str:
    return ((("execute_with_options_async / exit_code: " + str(v0_1)) + " / output.Length: ") + str(len(v1_1))) + ""


def closure4(unit_var: None, v0_1: str) -> Async[tuple[int, str]]:
    _v4: Async[tuple[int, str]] | None = None
    _v4 = None
    return value_2(_v4)


def closure20(unit_var: None, _arg: tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, str | None]) -> Async[tuple[int, str]]:
    _v4: Async[tuple[int, str]] | None = None
    _v4 = None
    return value_2(_v4)


def method18(v0_1: UH1, v1_1: UH1) -> UH1:
    if v0_1.tag == 0:
        return v1_1

    else: 
        return UH1(1, v0_1.fields[0], method18(v0_1.fields[1], v1_1))



def method17(v0_1_mut: str, v1_1_mut: UH1, v2_1_mut: UH0, v3_1_mut: US8) -> tuple[UH1, str]:
    while True:
        (v0_1, v1_1, v2_1, v3_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut)
        if v3_1.tag == 1:
            v105: str = v3_1.fields[0]
            if "\"" == v105:
                if v2_1.tag == 1:
                    v108: UH0 = v2_1.fields[1]
                    v107: str = v2_1.fields[0]
                    if "\"" == v107:
                        if equals(v3_1, US8(1, "\\")):
                            return method16(v0_1, v1_1, v108, v3_1, US8(0))

                        elif "\\" == v105:
                            if not equals(v3_1, US8(2, uint8(0))):
                                return method16(("" + v0_1) + "\"", v1_1, v108, v3_1, US8(1, "\""))

                            elif equals(v3_1, US8(1, "\\")):
                                return method16(("" + v0_1) + "\"", v1_1, v108, v3_1, US8(1, "\""))

                            else: 
                                return method16(v0_1, v1_1, v108, v3_1, US8(0))


                        elif "\\" == v107:
                            return method16(v0_1, v1_1, v108, v3_1, US8(2, uint8(1)))

                        elif equals(v3_1, US8(2, uint8(0))):
                            return method16(("" + v0_1) + "\"", v1_1, v108, v3_1, US8(1, "\""))

                        else: 
                            return method16("", method18(v1_1, UH1(1, v0_1, UH1(0))), v108, v3_1, US8(0))


                    elif "\\" == v105:
                        if "\\" == v107:
                            return method16(v0_1, v1_1, v108, v3_1, US8(2, uint8(1)))

                        elif " " == v107:
                            v0_1_mut = ("" + v0_1) + " "
                            v1_1_mut = v1_1
                            v2_1_mut = v108
                            v3_1_mut = v3_1
                            continue

                        else: 
                            v0_1_mut = ((("" + v0_1) + "") + str(v107)) + ""
                            v1_1_mut = v1_1
                            v2_1_mut = v108
                            v3_1_mut = v3_1
                            continue


                    elif "\\" == v107:
                        return method16(v0_1, v1_1, v108, v3_1, US8(2, uint8(1)))

                    elif " " == v107:
                        v0_1_mut = ("" + v0_1) + " "
                        v1_1_mut = v1_1
                        v2_1_mut = v108
                        v3_1_mut = v3_1
                        continue

                    else: 
                        v0_1_mut = ((("" + v0_1) + "") + str(v107)) + ""
                        v1_1_mut = v1_1
                        v2_1_mut = v108
                        v3_1_mut = v3_1
                        continue


                elif "\\" == v105:
                    return (v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                else: 
                    return (v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


            elif "\\" == v105:
                if v2_1.tag == 1:
                    v220: UH0 = v2_1.fields[1]
                    v219: str = v2_1.fields[0]
                    if "\"" == v219:
                        if not equals(v3_1, US8(2, uint8(0))):
                            return method16(("" + v0_1) + "\"", v1_1, v220, v3_1, US8(1, "\""))

                        elif equals(v3_1, US8(1, "\\")):
                            return method16(("" + v0_1) + "\"", v1_1, v220, v3_1, US8(1, "\""))

                        else: 
                            return method16(v0_1, v1_1, v220, v3_1, US8(0))


                    elif "\\" == v219:
                        return method16(v0_1, v1_1, v220, v3_1, US8(2, uint8(1)))

                    elif " " == v219:
                        v0_1_mut = ("" + v0_1) + " "
                        v1_1_mut = v1_1
                        v2_1_mut = v220
                        v3_1_mut = v3_1
                        continue

                    else: 
                        v0_1_mut = ((("" + v0_1) + "") + str(v219)) + ""
                        v1_1_mut = v1_1
                        v2_1_mut = v220
                        v3_1_mut = v3_1
                        continue


                else: 
                    return (v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


            elif v2_1.tag == 1:
                v270: UH0 = v2_1.fields[1]
                v269: str = v2_1.fields[0]
                if "\\" == v269:
                    return method16(v0_1, v1_1, v270, v3_1, US8(2, uint8(1)))

                elif "\"" == v269:
                    if equals(v3_1, US8(2, uint8(0))):
                        return method16(("" + v0_1) + "\"", v1_1, v270, v3_1, US8(1, "\""))

                    else: 
                        return method16("", method18(v1_1, UH1(1, v0_1, UH1(0))), v270, v3_1, US8(0))


                elif " " == v269:
                    v0_1_mut = ("" + v0_1) + " "
                    v1_1_mut = v1_1
                    v2_1_mut = v270
                    v3_1_mut = v3_1
                    continue

                else: 
                    v0_1_mut = ((("" + v0_1) + "") + str(v269)) + ""
                    v1_1_mut = v1_1
                    v2_1_mut = v270
                    v3_1_mut = v3_1
                    continue


            else: 
                return (v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


        elif v3_1.tag == 0:
            if v2_1.tag == 1:
                v5_1: UH0 = v2_1.fields[1]
                v4_1: str = v2_1.fields[0]
                if "\"" == v4_1:
                    return method16("", v1_1, v5_1, v3_1, US8(1, "\""))

                elif "\\" == v4_1:
                    return method16(v0_1, v1_1, v5_1, v3_1, US8(2, uint8(0)))

                elif " " == v4_1:
                    v0_1_mut = ""
                    v1_1_mut = v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0)))
                    v2_1_mut = v5_1
                    v3_1_mut = v3_1
                    continue

                else: 
                    v0_1_mut = ((("" + v0_1) + "") + str(v4_1)) + ""
                    v1_1_mut = v1_1
                    v2_1_mut = v5_1
                    v3_1_mut = v3_1
                    continue


            else: 
                return (v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


        else: 
            v44: uint8 = v3_1.fields[0]
            if v2_1.tag == 1:
                v46: UH0 = v2_1.fields[1]
                v45: str = v2_1.fields[0]
                if "\\" == v45:
                    return method16(v0_1, v1_1, v46, v3_1, US8(1, "\\"))

                elif "\"" == v45:
                    if True if (v3_1.tag == 0) else False:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v46
                        v3_1_mut = v3_1
                        continue

                    else: 
                        return method16(("" + v0_1) + "\"", v1_1, v46, v3_1, US8(2, v44))


                elif " " == v45:
                    v0_1_mut = ("" + v0_1) + " "
                    v1_1_mut = v1_1
                    v2_1_mut = v46
                    v3_1_mut = v3_1
                    continue

                elif uint8(1) == v44:
                    if not equals(v3_1, v3_1):
                        v0_1_mut = ((("" + v0_1) + "\\") + str(v45)) + ""
                        v1_1_mut = v1_1
                        v2_1_mut = v46
                        v3_1_mut = v3_1
                        continue

                    else: 
                        v0_1_mut = ((("" + v0_1) + "") + str(v45)) + ""
                        v1_1_mut = v1_1
                        v2_1_mut = v46
                        v3_1_mut = v3_1
                        continue


                else: 
                    v0_1_mut = ((("" + v0_1) + "") + str(v45)) + ""
                    v1_1_mut = v1_1
                    v2_1_mut = v46
                    v3_1_mut = v3_1
                    continue


            elif uint8(1) == v44:
                return (v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

            else: 
                return (v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


        break


def method16(v0_1_mut: str, v1_1_mut: UH1, v2_1_mut: UH0, v3_1_mut: US8, v4_1_mut: US8) -> tuple[UH1, str]:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        if v4_1.tag == 1:
            v106: str = v4_1.fields[0]
            if "\"" == v106:
                if v2_1.tag == 1:
                    v109: UH0 = v2_1.fields[1]
                    v108: str = v2_1.fields[0]
                    if "\"" == v108:
                        if equals(v3_1, US8(1, "\\")):
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v109
                            v3_1_mut = v4_1
                            v4_1_mut = US8(0)
                            continue

                        elif "\\" == v106:
                            if not equals(v3_1, US8(2, uint8(0))):
                                v0_1_mut = ("" + v0_1) + "\""
                                v1_1_mut = v1_1
                                v2_1_mut = v109
                                v3_1_mut = v4_1
                                v4_1_mut = US8(1, "\"")
                                continue

                            elif equals(v3_1, US8(1, "\\")):
                                v0_1_mut = ("" + v0_1) + "\""
                                v1_1_mut = v1_1
                                v2_1_mut = v109
                                v3_1_mut = v4_1
                                v4_1_mut = US8(1, "\"")
                                continue

                            else: 
                                v0_1_mut = v0_1
                                v1_1_mut = v1_1
                                v2_1_mut = v109
                                v3_1_mut = v4_1
                                v4_1_mut = US8(0)
                                continue


                        elif "\\" == v108:
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v109
                            v3_1_mut = v4_1
                            v4_1_mut = US8(2, uint8(1))
                            continue

                        elif equals(v3_1, US8(2, uint8(0))):
                            v0_1_mut = ("" + v0_1) + "\""
                            v1_1_mut = v1_1
                            v2_1_mut = v109
                            v3_1_mut = v4_1
                            v4_1_mut = US8(1, "\"")
                            continue

                        else: 
                            v0_1_mut = ""
                            v1_1_mut = method18(v1_1, UH1(1, v0_1, UH1(0)))
                            v2_1_mut = v109
                            v3_1_mut = v4_1
                            v4_1_mut = US8(0)
                            continue


                    elif "\\" == v106:
                        if "\\" == v108:
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v109
                            v3_1_mut = v4_1
                            v4_1_mut = US8(2, uint8(1))
                            continue

                        elif " " == v108:
                            return method17(("" + v0_1) + " ", v1_1, v109, v4_1)

                        else: 
                            return method17(((("" + v0_1) + "") + str(v108)) + "", v1_1, v109, v4_1)


                    elif "\\" == v108:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v109
                        v3_1_mut = v4_1
                        v4_1_mut = US8(2, uint8(1))
                        continue

                    elif " " == v108:
                        return method17(("" + v0_1) + " ", v1_1, v109, v4_1)

                    else: 
                        return method17(((("" + v0_1) + "") + str(v108)) + "", v1_1, v109, v4_1)


                elif "\\" == v106:
                    return (v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                else: 
                    return (v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


            elif "\\" == v106:
                if v2_1.tag == 1:
                    v221: UH0 = v2_1.fields[1]
                    v220: str = v2_1.fields[0]
                    if "\"" == v220:
                        if not equals(v3_1, US8(2, uint8(0))):
                            v0_1_mut = ("" + v0_1) + "\""
                            v1_1_mut = v1_1
                            v2_1_mut = v221
                            v3_1_mut = v4_1
                            v4_1_mut = US8(1, "\"")
                            continue

                        elif equals(v3_1, US8(1, "\\")):
                            v0_1_mut = ("" + v0_1) + "\""
                            v1_1_mut = v1_1
                            v2_1_mut = v221
                            v3_1_mut = v4_1
                            v4_1_mut = US8(1, "\"")
                            continue

                        else: 
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v221
                            v3_1_mut = v4_1
                            v4_1_mut = US8(0)
                            continue


                    elif "\\" == v220:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v221
                        v3_1_mut = v4_1
                        v4_1_mut = US8(2, uint8(1))
                        continue

                    elif " " == v220:
                        return method17(("" + v0_1) + " ", v1_1, v221, v4_1)

                    else: 
                        return method17(((("" + v0_1) + "") + str(v220)) + "", v1_1, v221, v4_1)


                else: 
                    return (v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


            elif v2_1.tag == 1:
                v271: UH0 = v2_1.fields[1]
                v270: str = v2_1.fields[0]
                if "\\" == v270:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v271
                    v3_1_mut = v4_1
                    v4_1_mut = US8(2, uint8(1))
                    continue

                elif "\"" == v270:
                    if equals(v3_1, US8(2, uint8(0))):
                        v0_1_mut = ("" + v0_1) + "\""
                        v1_1_mut = v1_1
                        v2_1_mut = v271
                        v3_1_mut = v4_1
                        v4_1_mut = US8(1, "\"")
                        continue

                    else: 
                        v0_1_mut = ""
                        v1_1_mut = method18(v1_1, UH1(1, v0_1, UH1(0)))
                        v2_1_mut = v271
                        v3_1_mut = v4_1
                        v4_1_mut = US8(0)
                        continue


                elif " " == v270:
                    return method17(("" + v0_1) + " ", v1_1, v271, v4_1)

                else: 
                    return method17(((("" + v0_1) + "") + str(v270)) + "", v1_1, v271, v4_1)


            else: 
                return (v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


        elif v4_1.tag == 0:
            if v2_1.tag == 1:
                v6: UH0 = v2_1.fields[1]
                v5_1: str = v2_1.fields[0]
                if "\"" == v5_1:
                    v0_1_mut = ""
                    v1_1_mut = v1_1
                    v2_1_mut = v6
                    v3_1_mut = v4_1
                    v4_1_mut = US8(1, "\"")
                    continue

                elif "\\" == v5_1:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v6
                    v3_1_mut = v4_1
                    v4_1_mut = US8(2, uint8(0))
                    continue

                elif " " == v5_1:
                    return method17("", v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0))), v6, v4_1)

                else: 
                    return method17(((("" + v0_1) + "") + str(v5_1)) + "", v1_1, v6, v4_1)


            else: 
                return (v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


        else: 
            v45: uint8 = v4_1.fields[0]
            if v2_1.tag == 1:
                v47: UH0 = v2_1.fields[1]
                v46: str = v2_1.fields[0]
                if "\\" == v46:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v47
                    v3_1_mut = v4_1
                    v4_1_mut = US8(1, "\\")
                    continue

                elif "\"" == v46:
                    if True if (v3_1.tag == 0) else False:
                        return method17(v0_1, v1_1, v47, v4_1)

                    else: 
                        v0_1_mut = ("" + v0_1) + "\""
                        v1_1_mut = v1_1
                        v2_1_mut = v47
                        v3_1_mut = v4_1
                        v4_1_mut = US8(2, v45)
                        continue


                elif " " == v46:
                    return method17(("" + v0_1) + " ", v1_1, v47, v4_1)

                elif uint8(1) == v45:
                    if not equals(v3_1, v4_1):
                        v0_1_mut = ((("" + v0_1) + "\\") + str(v46)) + ""
                        v1_1_mut = v1_1
                        v2_1_mut = v47
                        v3_1_mut = v4_1
                        v4_1_mut = v3_1
                        continue

                    else: 
                        return method17(((("" + v0_1) + "") + str(v46)) + "", v1_1, v47, v4_1)


                else: 
                    return method17(((("" + v0_1) + "") + str(v46)) + "", v1_1, v47, v4_1)


            elif uint8(1) == v45:
                return (v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

            else: 
                return (v1_1 if (v0_1 == "") else method18(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


        break


def method19(v0_1: UH1, v1_1: FSharpList[str]) -> FSharpList[str]:
    if v0_1.tag == 0:
        return v1_1

    else: 
        return cons(v0_1.fields[0], method19(v0_1.fields[1], v1_1))



def method15(v0_1: str) -> Array[str]:
    _v0: (str | None) | None = None
    _v0 = some(v0_1)
    v6: str | None = value_2(_v0)
    v9: US4 = default_arg(map(method6(), v6), US4(1))
    v12: str = v9.fields[0] if (v9.tag == 0) else ""
    v13: int = len(v12) or 0
    v14: Array[str] = fill([0] * v13, 0, v13, "")
    v15: Mut4 = Mut4(0)
    while method3(v13, v15):
        v17: int = v15.l0 or 0
        v18: str = v12[v17]
        v14[v17] = v18
        v19: int = (v17 + 1) or 0
        v15.l0 = v19 or 0
    v21: FSharpList[str] = of_array(v14)
    return to_array(method19(method16("", UH1(0), fold_back(uncurry2(method4()), v21, UH0(0)), US8(0), US8(0))[0], empty()))


def closure21(unit_var: None, v0_1: str) -> Array[str]:
    return method15(v0_1)


def _arrow140(__unit: None=None) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, None)


v0: Callable[[], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow140


if State_trace_state() is None:
    State_trace_state(v0(None))


def _arrow141(__unit: None=None) -> bool:
    return closure2(None, None)


v1: Callable[[], bool] = _arrow141

def is_windows(__unit: None=None) -> bool:
    return v1(None)


def _arrow142(__unit: None=None) -> str:
    return closure3(None, None)


v2: Callable[[], str] = _arrow142

def get_executable_suffix(__unit: None=None) -> str:
    return v2(None)


def _arrow143(v: str) -> Async[tuple[int, str]]:
    return closure4(None, v)


v3: Callable[[str], Async[tuple[int, str]]] = _arrow143

def execute_async(x: str) -> Async[tuple[int, str]]:
    return v3(x)


def _arrow144(_arg10: tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, str | None]) -> Async[tuple[int, str]]:
    return closure20(None, _arg10)


v4: Callable[[tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, str | None]], Async[tuple[int, str]]] = _arrow144

def execute_with_options_async(x: tuple[CancellationToken | None, str, Callable[[tuple[bool, str, int]], Async[None]] | None, str | None]) -> Async[tuple[int, str]]:
    return v4(x)


def _arrow145(v: str) -> Array[str]:
    return closure21(None, v)


v5: Callable[[str], Array[str]] = _arrow145

def split_args(x: str) -> Array[str]:
    return v5(x)


