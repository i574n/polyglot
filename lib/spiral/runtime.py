from __future__ import annotations
from collections.abc import Callable
from dataclasses import dataclass
from typing import Any
from fable_modules.fable_library.array_ import fill
from fable_modules.fable_library.async_builder import (Async, CancellationToken)
from fable_modules.fable_library.list import (cons, FSharpList, of_array, to_array, fold_back, empty)
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_2, default_arg)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, bool_type, string_type, unit_type, lambda_type, int32_type, char_type, tuple_type, class_type, option_type, array_type, uint8_type)
from fable_modules.fable_library.string_ import (replace, to_text, interpolate, pad_left, trim_end, trim_start)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef, uint8)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare, equals, uncurry2)

State_trace_state: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] | None = create_atom(None)

def _expr128() -> TypeInfo:
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


US0_reflection = _expr128

def _expr129() -> TypeInfo:
    return record_type("Runtime.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr129

def _expr130() -> TypeInfo:
    return record_type("Runtime.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr130

def _expr131() -> TypeInfo:
    return record_type("Runtime.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr131

def _expr132() -> TypeInfo:
    return record_type("Runtime.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr132

def _expr133() -> TypeInfo:
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


US1_reflection = _expr133

def _expr134() -> TypeInfo:
    return record_type("Runtime.Mut4", [], Mut4, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: int

Mut4_reflection = _expr134

def _expr135() -> TypeInfo:
    return union_type("Runtime.UH0", [], UH0, lambda: [[], [("Item1", char_type), ("Item2", UH0_reflection())]])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr135

def _expr136() -> TypeInfo:
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


US3_reflection = _expr136

def _expr138() -> TypeInfo:
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


US2_reflection = _expr138

def _expr142() -> TypeInfo:
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


US4_reflection = _expr142

def _expr144() -> TypeInfo:
    return union_type("Runtime.US5", [], US5, lambda: [[("f0_0", lambda_type(tuple_type(bool_type, string_type, int32_type), class_type("Microsoft.FSharp.Control.FSharpAsync`1", [unit_type])))], []])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr144

def _expr146() -> TypeInfo:
    return union_type("Runtime.US6", [], US6, lambda: [[("f0_0", class_type("System.Threading.CancellationToken"))], []])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1"]


US6_reflection = _expr146

def _expr151() -> TypeInfo:
    return record_type("Runtime.Heap0", [], Heap0, lambda: [("l0", option_type(class_type("System.Threading.CancellationToken"))), ("l1", string_type), ("l2", array_type(tuple_type(string_type, string_type))), ("l3", option_type(lambda_type(tuple_type(bool_type, string_type, int32_type), class_type("Microsoft.FSharp.Control.FSharpAsync`1", [unit_type])))), ("l4", option_type(lambda_type(class_type("Runtime.std_sync_Arc`1", [class_type("Runtime.std_sync_Mutex`1", [class_type("Runtime.std_process_ChildStdin")])]), unit_type))), ("l5", bool_type), ("l6", option_type(string_type))])


@dataclass(eq = False, repr = False, slots = True)
class Heap0(Record):
    l0: CancellationToken | None
    l1: str
    l2: Array[tuple[str, str]]
    l3: Callable[[tuple[bool, str, int]], Async[None]] | None
    l4: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None
    l5: bool
    l6: str | None

Heap0_reflection = _expr151

def _expr152() -> TypeInfo:
    return union_type("Runtime.UH1", [], UH1, lambda: [[], [("Item1", string_type), ("Item2", UH1_reflection())]])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr152

def _expr154() -> TypeInfo:
    return union_type("Runtime.US7", [], US7, lambda: [[], [("f1_0", char_type)], [("f2_0", uint8_type), ("f2_1", char_type)]])


class US7(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US7_0", "US7_1", "US7_2"]


US7_reflection = _expr154

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



def US7__get_IsUS7_2(this: FSharpRef[US7], unit_arg: None) -> bool:
    if this.tag == 2:
        return True

    else: 
        return False



def closure1(unit_var: None, v0_1: str) -> None:
    pass


def method0(__unit: None=None) -> str:
    return ""


def method1(__unit: None=None) -> str:
    return "AUTOMATION"


def closure0(unit_var: None, v0_1: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    v1_1: Mut1 = Mut1(True)
    v2_1: Mut0 = Mut0(int64(0))
    v3_1: Mut2 = Mut2(v0_1)
    def v4_1(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure1(None, v)

    v5_1: Mut3 = Mut3(v4_1)
    _v6: (int64 | None) | None = None
    _v6 = some(None)
    return (v2_1, v1_1, v3_1, value_2(_v6), v5_1)


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



def method3(__unit: None=None) -> tuple[str, str]:
    return ("", "")


def method4(v0_1: int, v1_1: Mut4) -> bool:
    return v1_1.l0 < v0_1


def closure6(v0_1: str, v1_1: UH0) -> UH0:
    return UH0(1, v0_1, v1_1)


def closure5(unit_var: None, v0_1: str) -> Callable[[UH0], UH0]:
    def _arrow159(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure6(v0_1, v)

    return _arrow159


def method5(__unit: None=None) -> Callable[[str, UH0], UH0]:
    def _arrow160(v: str) -> Callable[[UH0], UH0]:
        return closure5(None, v)

    return _arrow160


def method6(v0_1_mut: str, v1_1_mut: str, v2_1_mut: UH0, v3_1_mut: US2) -> tuple[str, str]:
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


def closure7(v0_1: CancellationToken | None, v1_1: str, v2_1: Array[tuple[str, str]], v3_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v4_1: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, v5_1: bool, v6_1: str | None, unit_var: None) -> str:
    return to_text(interpolate("execute_with_options_async / options: %A%P()", [(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1)]))


def closure8(unit_var: None, unit_var_1: None) -> str:
    return ""


def method7(__unit: None=None) -> Callable[[], str]:
    def _arrow161(__unit: None=None) -> str:
        return closure8(None, None)

    return _arrow161


def method9(__unit: None=None) -> str:
    return ""


def closure9(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_2(State_trace_state())
    _v10: str | None = None
    x: str = method9()
    _v10 = x
    v67: str = value_2(_v10)
    v68: int64 = pattern_input[0].l0
    v78: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    _v81: str | None = None
    x_1: str = pad_left(v78.lower(), 7, " ")
    _v81 = x_1
    return trim_end(trim_start(((((((((("" + v67) + " ") + value_2(_v81)) + " #") + str(v68)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method10(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(v: US0, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
        return closure0(None, v)

    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_2(State_trace_state())
    v4_1: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_2(State_trace_state())
    v15: US0 = pattern_input_1[2].l0
    class ObjectExpr162:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr163:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr162())) >= find(v15, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr163()))):
        v23: int64 = op_addition(v4_1.l0, int64(1))
        v4_1.l0 = v23
        v24: str = ("" + v1_1(None)) + ""
        _v25: None | None = None
        print(v24)
        _v25 = some(None)
        value_2(_v25)
        pattern_input[4].l0(v24)



def method8(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure9(v0_1, v1_1, v2_1, None)

    method10(v0_1, v3_1)


def closure11(v0_1: str, unit_var: None) -> str:
    return v0_1


def closure10(v0_1: CancellationToken | None, v1_1: str, v2_1: Array[tuple[str, str]], v3_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v4_1: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, v5_1: bool, v6_1: str | None, v7_1: None, v8: Any, v9: None) -> None:
    _v10: Async[None] | None = None
    _v10 = None
    v38: Async[None] = value_2(_v10)
    _v39: None | None = None
    _v39 = some(None)
    value_2(_v39)


def closure12(v0_1: CancellationToken | None, v1_1: str, v2_1: Array[tuple[str, str]], v3_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v4_1: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, v5_1: bool, v6_1: str | None, v7_1: None, v8: Any, v9: None) -> None:
    _v10: Async[None] | None = None
    _v10 = None
    v39: Async[None] = value_2(_v10)
    _v40: None | None = None
    _v40 = some(None)
    value_2(_v40)


def closure13(v0_1: None, unit_var: None) -> None:
    _v1: bool | None = None
    _v1 = None
    if value_2(_v1) == False:
        _v10: None | None = None
        _v10 = some(None)
        value_2(_v10)



def closure14(v0_1: Any, unit_var: None) -> str:
    return to_text(interpolate("execute_with_options_async / WaitForExitAsync / ex: %A%P()", [v0_1]))


def method11(__unit: None=None) -> str:
    return "\n"


def closure15(v0_1: int, v1_1: str, unit_var: None) -> str:
    return ((("execute_with_options_async / exit_code: " + str(v0_1)) + " / output.Length: ") + str(len(v1_1))) + ""


def method2(v0_1: CancellationToken | None, v1_1: str, v2_1: Array[tuple[str, str]], v3_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v4_1: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, v5_1: bool, v6_1: str | None=None) -> Async[tuple[int, str]]:
    _v7: Async[tuple[int, str]] | None = None
    _v7 = None
    return value_2(_v7)


def closure4(unit_var: None, v0_1: str) -> Async[tuple[int, str]]:
    return method2(None, v0_1, [], None, None, True, None)


def closure16(unit_var: None, _arg: tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return method2(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6])


def closure17(unit_var: None, v0_1: Callable[[Heap0], Heap0]) -> tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]:
    v8: Heap0 = v0_1(Heap0(None, "", [], None, None, True, None))
    return (v8.l0, v8.l1, v8.l2, v8.l3, v8.l4, v8.l5, v8.l6)


def method15(v0_1: UH1, v1_1: UH1) -> UH1:
    if v0_1.tag == 0:
        return v1_1

    else: 
        return UH1(1, v0_1.fields[0], method15(v0_1.fields[1], v1_1))



def method14(v0_1_mut: str, v1_1_mut: UH1, v2_1_mut: UH0, v3_1_mut: US7) -> tuple[UH1, str]:
    while True:
        (v0_1, v1_1, v2_1, v3_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut)
        if v3_1.tag == 1:
            v259: str = v3_1.fields[0]
            if "\"" == v259:
                if v2_1.tag == 1:
                    v262: UH0 = v2_1.fields[1]
                    v261: str = v2_1.fields[0]
                    if "\"" == v261:
                        return method13(v0_1, v1_1, v262, v3_1, US7(0))

                    elif "\\" == v259:
                        if "\\" == v261:
                            return method13(v0_1, v1_1, v262, v3_1, US7(2, uint8(0), v261))

                        elif "`" == v261:
                            return method13(v0_1, v1_1, v262, v3_1, US7(2, uint8(0), v261))

                        elif " " == v261:
                            v0_1_mut = ("" + v0_1) + " "
                            v1_1_mut = v1_1
                            v2_1_mut = v262
                            v3_1_mut = v3_1
                            continue

                        else: 
                            v0_1_mut = ((("" + v0_1) + "") + str(v261)) + ""
                            v1_1_mut = v1_1
                            v2_1_mut = v262
                            v3_1_mut = v3_1
                            continue


                    elif "`" == v259:
                        if "\\" == v261:
                            return method13(v0_1, v1_1, v262, v3_1, US7(2, uint8(0), v261))

                        elif "`" == v261:
                            return method13(v0_1, v1_1, v262, v3_1, US7(2, uint8(0), v261))

                        elif " " == v261:
                            v0_1_mut = ("" + v0_1) + " "
                            v1_1_mut = v1_1
                            v2_1_mut = v262
                            v3_1_mut = v3_1
                            continue

                        else: 
                            v0_1_mut = ((("" + v0_1) + "") + str(v261)) + ""
                            v1_1_mut = v1_1
                            v2_1_mut = v262
                            v3_1_mut = v3_1
                            continue


                    elif "\\" == v261:
                        return method13(v0_1, v1_1, v262, v3_1, US7(2, uint8(0), v261))

                    elif "`" == v261:
                        return method13(v0_1, v1_1, v262, v3_1, US7(2, uint8(0), v261))

                    elif " " == v261:
                        v0_1_mut = ("" + v0_1) + " "
                        v1_1_mut = v1_1
                        v2_1_mut = v262
                        v3_1_mut = v3_1
                        continue

                    else: 
                        v0_1_mut = ((("" + v0_1) + "") + str(v261)) + ""
                        v1_1_mut = v1_1
                        v2_1_mut = v262
                        v3_1_mut = v3_1
                        continue


                elif "\\" == v259:
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                elif "`" == v259:
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                else: 
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


            elif "\\" == v259:
                if v2_1.tag == 1:
                    v372: UH0 = v2_1.fields[1]
                    v371: str = v2_1.fields[0]
                    if "\"" == v371:
                        if (not equals(v3_1, US7(2, uint8(0), "`"))) if (not equals(v3_1, US7(2, uint8(0), "\\"))) else False:
                            return method13(((("" + v0_1) + "") + str(v259)) + "\"", v1_1, v372, v3_1, US7(1, "\""))

                        else: 
                            return method13(((("" + v0_1) + "") + str(v259)) + "\"", v1_1, v372, v3_1, US7(1, "\""))


                    elif "\\" == v371:
                        return method13(v0_1, v1_1, v372, v3_1, US7(2, uint8(0), v371))

                    elif "`" == v371:
                        return method13(v0_1, v1_1, v372, v3_1, US7(2, uint8(0), v371))

                    elif " " == v371:
                        v0_1_mut = ("" + v0_1) + " "
                        v1_1_mut = v1_1
                        v2_1_mut = v372
                        v3_1_mut = v3_1
                        continue

                    else: 
                        v0_1_mut = ((("" + v0_1) + "") + str(v371)) + ""
                        v1_1_mut = v1_1
                        v2_1_mut = v372
                        v3_1_mut = v3_1
                        continue


                else: 
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


            elif "`" == v259:
                if v2_1.tag == 1:
                    v426: UH0 = v2_1.fields[1]
                    v425: str = v2_1.fields[0]
                    if "\"" == v425:
                        if (not equals(v3_1, US7(2, uint8(0), "`"))) if (not equals(v3_1, US7(2, uint8(0), "\\"))) else False:
                            return method13(((("" + v0_1) + "") + str(v259)) + "\"", v1_1, v426, v3_1, US7(1, "\""))

                        else: 
                            return method13(((("" + v0_1) + "") + str(v259)) + "\"", v1_1, v426, v3_1, US7(1, "\""))


                    elif "\\" == v425:
                        return method13(v0_1, v1_1, v426, v3_1, US7(2, uint8(0), v425))

                    elif "`" == v425:
                        return method13(v0_1, v1_1, v426, v3_1, US7(2, uint8(0), v425))

                    elif " " == v425:
                        v0_1_mut = ("" + v0_1) + " "
                        v1_1_mut = v1_1
                        v2_1_mut = v426
                        v3_1_mut = v3_1
                        continue

                    else: 
                        v0_1_mut = ((("" + v0_1) + "") + str(v425)) + ""
                        v1_1_mut = v1_1
                        v2_1_mut = v426
                        v3_1_mut = v3_1
                        continue


                else: 
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


            elif v2_1.tag == 1:
                v479: UH0 = v2_1.fields[1]
                v478: str = v2_1.fields[0]
                if "\\" == v478:
                    return method13(v0_1, v1_1, v479, v3_1, US7(2, uint8(0), v478))

                elif "`" == v478:
                    return method13(v0_1, v1_1, v479, v3_1, US7(2, uint8(0), v478))

                elif "\"" == v478:
                    return method13("", method15(v1_1, UH1(1, v0_1, UH1(0))), v479, v3_1, US7(0))

                elif " " == v478:
                    v0_1_mut = ("" + v0_1) + " "
                    v1_1_mut = v1_1
                    v2_1_mut = v479
                    v3_1_mut = v3_1
                    continue

                else: 
                    v0_1_mut = ((("" + v0_1) + "") + str(v478)) + ""
                    v1_1_mut = v1_1
                    v2_1_mut = v479
                    v3_1_mut = v3_1
                    continue


            else: 
                return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


        elif v3_1.tag == 0:
            if v2_1.tag == 1:
                v5_1: UH0 = v2_1.fields[1]
                v4_1: str = v2_1.fields[0]
                if "\"" == v4_1:
                    return method13("", v1_1, v5_1, v3_1, US7(1, "\""))

                elif "\\" == v4_1:
                    return method13(v0_1, v1_1, v5_1, v3_1, US7(2, uint8(0), v4_1))

                elif "`" == v4_1:
                    return method13(v0_1, v1_1, v5_1, v3_1, US7(2, uint8(0), v4_1))

                elif " " == v4_1:
                    v0_1_mut = ""
                    v1_1_mut = v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0)))
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
                return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


        else: 
            v52: str = v3_1.fields[1]
            v51: uint8 = v3_1.fields[0]
            if v2_1.tag == 1:
                v54: UH0 = v2_1.fields[1]
                v53: str = v2_1.fields[0]
                if "\\" == v53:
                    return method13(v0_1, v1_1, v54, v3_1, US7(1, v53))

                elif "`" == v53:
                    return method13(v0_1, v1_1, v54, v3_1, US7(1, v53))

                elif uint8(0) == v51:
                    if "\\" == v52:
                        if "\"" == v53:
                            return method13(((("" + v0_1) + "") + str(v52)) + "\"", v1_1, v54, v3_1, US7(2, v51, v52))

                        elif " " == v53:
                            v0_1_mut = ("" + v0_1) + " "
                            v1_1_mut = v1_1
                            v2_1_mut = v54
                            v3_1_mut = v3_1
                            continue

                        elif uint8(1) == v51:
                            if not equals(v3_1, v3_1):
                                v0_1_mut = ((("" + v0_1) + "\\") + str(v53)) + ""
                                v1_1_mut = v1_1
                                v2_1_mut = v54
                                v3_1_mut = v3_1
                                continue

                            else: 
                                v0_1_mut = ((("" + v0_1) + "") + str(v53)) + ""
                                v1_1_mut = v1_1
                                v2_1_mut = v54
                                v3_1_mut = v3_1
                                continue


                        else: 
                            v0_1_mut = ((("" + v0_1) + "") + str(v53)) + ""
                            v1_1_mut = v1_1
                            v2_1_mut = v54
                            v3_1_mut = v3_1
                            continue


                    elif "`" == v52:
                        if "\"" == v53:
                            return method13(((("" + v0_1) + "") + str(v52)) + "\"", v1_1, v54, v3_1, US7(2, v51, v52))

                        elif " " == v53:
                            v0_1_mut = ("" + v0_1) + " "
                            v1_1_mut = v1_1
                            v2_1_mut = v54
                            v3_1_mut = v3_1
                            continue

                        elif uint8(1) == v51:
                            if not equals(v3_1, v3_1):
                                v0_1_mut = ((("" + v0_1) + "\\") + str(v53)) + ""
                                v1_1_mut = v1_1
                                v2_1_mut = v54
                                v3_1_mut = v3_1
                                continue

                            else: 
                                v0_1_mut = ((("" + v0_1) + "") + str(v53)) + ""
                                v1_1_mut = v1_1
                                v2_1_mut = v54
                                v3_1_mut = v3_1
                                continue


                        else: 
                            v0_1_mut = ((("" + v0_1) + "") + str(v53)) + ""
                            v1_1_mut = v1_1
                            v2_1_mut = v54
                            v3_1_mut = v3_1
                            continue


                    elif "\"" == v53:
                        return method13(((("" + v0_1) + "") + str(v52)) + "\"", v1_1, v54, v3_1, US7(2, v51, v52))

                    elif " " == v53:
                        v0_1_mut = ("" + v0_1) + " "
                        v1_1_mut = v1_1
                        v2_1_mut = v54
                        v3_1_mut = v3_1
                        continue

                    elif uint8(1) == v51:
                        if not equals(v3_1, v3_1):
                            v0_1_mut = ((("" + v0_1) + "\\") + str(v53)) + ""
                            v1_1_mut = v1_1
                            v2_1_mut = v54
                            v3_1_mut = v3_1
                            continue

                        else: 
                            v0_1_mut = ((("" + v0_1) + "") + str(v53)) + ""
                            v1_1_mut = v1_1
                            v2_1_mut = v54
                            v3_1_mut = v3_1
                            continue


                    else: 
                        v0_1_mut = ((("" + v0_1) + "") + str(v53)) + ""
                        v1_1_mut = v1_1
                        v2_1_mut = v54
                        v3_1_mut = v3_1
                        continue


                elif "\"" == v53:
                    return method13(((("" + v0_1) + "") + str(v52)) + "\"", v1_1, v54, v3_1, US7(2, v51, v52))

                elif " " == v53:
                    v0_1_mut = ("" + v0_1) + " "
                    v1_1_mut = v1_1
                    v2_1_mut = v54
                    v3_1_mut = v3_1
                    continue

                elif uint8(1) == v51:
                    if not equals(v3_1, v3_1):
                        v0_1_mut = ((("" + v0_1) + "\\") + str(v53)) + ""
                        v1_1_mut = v1_1
                        v2_1_mut = v54
                        v3_1_mut = v3_1
                        continue

                    else: 
                        v0_1_mut = ((("" + v0_1) + "") + str(v53)) + ""
                        v1_1_mut = v1_1
                        v2_1_mut = v54
                        v3_1_mut = v3_1
                        continue


                else: 
                    v0_1_mut = ((("" + v0_1) + "") + str(v53)) + ""
                    v1_1_mut = v1_1
                    v2_1_mut = v54
                    v3_1_mut = v3_1
                    continue


            elif uint8(0) == v51:
                if "\\" == v52:
                    if uint8(1) == v51:
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                    else: 
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                elif "`" == v52:
                    if uint8(1) == v51:
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                    else: 
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                elif uint8(1) == v51:
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                else: 
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


            elif uint8(1) == v51:
                return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

            else: 
                return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


        break


def method13(v0_1_mut: str, v1_1_mut: UH1, v2_1_mut: UH0, v3_1_mut: US7, v4_1_mut: US7) -> tuple[UH1, str]:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        if v4_1.tag == 1:
            v581: str = v4_1.fields[0]
            if "\"" == v581:
                if v3_1.tag == 1:
                    if v2_1.tag == 1:
                        v585: UH0 = v2_1.fields[1]
                        v584: str = v2_1.fields[0]
                        if "\"" == v584:
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v585
                            v3_1_mut = v4_1
                            v4_1_mut = US7(0)
                            continue

                        elif "\\" == v581:
                            if "\\" == v584:
                                v0_1_mut = v0_1
                                v1_1_mut = v1_1
                                v2_1_mut = v585
                                v3_1_mut = v4_1
                                v4_1_mut = US7(2, uint8(0), v584)
                                continue

                            elif "`" == v584:
                                v0_1_mut = v0_1
                                v1_1_mut = v1_1
                                v2_1_mut = v585
                                v3_1_mut = v4_1
                                v4_1_mut = US7(2, uint8(0), v584)
                                continue

                            elif " " == v584:
                                return method14(("" + v0_1) + " ", v1_1, v585, v4_1)

                            else: 
                                return method14(((("" + v0_1) + "") + str(v584)) + "", v1_1, v585, v4_1)


                        elif "`" == v581:
                            if "\\" == v584:
                                v0_1_mut = v0_1
                                v1_1_mut = v1_1
                                v2_1_mut = v585
                                v3_1_mut = v4_1
                                v4_1_mut = US7(2, uint8(0), v584)
                                continue

                            elif "`" == v584:
                                v0_1_mut = v0_1
                                v1_1_mut = v1_1
                                v2_1_mut = v585
                                v3_1_mut = v4_1
                                v4_1_mut = US7(2, uint8(0), v584)
                                continue

                            elif " " == v584:
                                return method14(("" + v0_1) + " ", v1_1, v585, v4_1)

                            else: 
                                return method14(((("" + v0_1) + "") + str(v584)) + "", v1_1, v585, v4_1)


                        elif "\\" == v584:
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v585
                            v3_1_mut = v4_1
                            v4_1_mut = US7(2, uint8(0), v584)
                            continue

                        elif "`" == v584:
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v585
                            v3_1_mut = v4_1
                            v4_1_mut = US7(2, uint8(0), v584)
                            continue

                        elif " " == v584:
                            return method14(("" + v0_1) + " ", v1_1, v585, v4_1)

                        else: 
                            return method14(((("" + v0_1) + "") + str(v584)) + "", v1_1, v585, v4_1)


                    elif "\\" == v581:
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                    elif "`" == v581:
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                    else: 
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                elif "\\" == v581:
                    if v2_1.tag == 1:
                        v695: UH0 = v2_1.fields[1]
                        v694: str = v2_1.fields[0]
                        if "\"" == v694:
                            if (not equals(v3_1, US7(2, uint8(0), "`"))) if (not equals(v3_1, US7(2, uint8(0), "\\"))) else False:
                                v0_1_mut = ((("" + v0_1) + "") + str(v581)) + "\""
                                v1_1_mut = v1_1
                                v2_1_mut = v695
                                v3_1_mut = v4_1
                                v4_1_mut = US7(1, "\"")
                                continue

                            else: 
                                v0_1_mut = v0_1
                                v1_1_mut = v1_1
                                v2_1_mut = v695
                                v3_1_mut = v4_1
                                v4_1_mut = US7(0)
                                continue


                        elif "\\" == v694:
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v695
                            v3_1_mut = v4_1
                            v4_1_mut = US7(2, uint8(1), v694)
                            continue

                        elif "`" == v694:
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v695
                            v3_1_mut = v4_1
                            v4_1_mut = US7(2, uint8(1), v694)
                            continue

                        elif v3_1.tag == 2:
                            if uint8(0) == v3_1.fields[0]:
                                if " " == v694:
                                    return method14(("" + v0_1) + " ", v1_1, v695, v4_1)

                                else: 
                                    return method14(((("" + v0_1) + "") + str(v694)) + "", v1_1, v695, v4_1)


                            elif " " == v694:
                                return method14(("" + v0_1) + " ", v1_1, v695, v4_1)

                            else: 
                                return method14(((("" + v0_1) + "") + str(v694)) + "", v1_1, v695, v4_1)


                        elif " " == v694:
                            return method14(("" + v0_1) + " ", v1_1, v695, v4_1)

                        else: 
                            return method14(((("" + v0_1) + "") + str(v694)) + "", v1_1, v695, v4_1)


                    elif v3_1.tag == 2:
                        if uint8(0) == v3_1.fields[0]:
                            return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                        else: 
                            return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                    else: 
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                elif "`" == v581:
                    if v2_1.tag == 1:
                        v791: UH0 = v2_1.fields[1]
                        v790: str = v2_1.fields[0]
                        if "\"" == v790:
                            if (not equals(v3_1, US7(2, uint8(0), "`"))) if (not equals(v3_1, US7(2, uint8(0), "\\"))) else False:
                                v0_1_mut = ((("" + v0_1) + "") + str(v581)) + "\""
                                v1_1_mut = v1_1
                                v2_1_mut = v791
                                v3_1_mut = v4_1
                                v4_1_mut = US7(1, "\"")
                                continue

                            else: 
                                v0_1_mut = v0_1
                                v1_1_mut = v1_1
                                v2_1_mut = v791
                                v3_1_mut = v4_1
                                v4_1_mut = US7(0)
                                continue


                        elif "\\" == v790:
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v791
                            v3_1_mut = v4_1
                            v4_1_mut = US7(2, uint8(1), v790)
                            continue

                        elif "`" == v790:
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v791
                            v3_1_mut = v4_1
                            v4_1_mut = US7(2, uint8(1), v790)
                            continue

                        elif v3_1.tag == 2:
                            if uint8(0) == v3_1.fields[0]:
                                if " " == v790:
                                    return method14(("" + v0_1) + " ", v1_1, v791, v4_1)

                                else: 
                                    return method14(((("" + v0_1) + "") + str(v790)) + "", v1_1, v791, v4_1)


                            elif " " == v790:
                                return method14(("" + v0_1) + " ", v1_1, v791, v4_1)

                            else: 
                                return method14(((("" + v0_1) + "") + str(v790)) + "", v1_1, v791, v4_1)


                        elif " " == v790:
                            return method14(("" + v0_1) + " ", v1_1, v791, v4_1)

                        else: 
                            return method14(((("" + v0_1) + "") + str(v790)) + "", v1_1, v791, v4_1)


                    elif v3_1.tag == 2:
                        if uint8(0) == v3_1.fields[0]:
                            return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                        else: 
                            return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                    else: 
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                elif v2_1.tag == 1:
                    v886: UH0 = v2_1.fields[1]
                    v885: str = v2_1.fields[0]
                    if "\\" == v885:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v886
                        v3_1_mut = v4_1
                        v4_1_mut = US7(2, uint8(1), v885)
                        continue

                    elif "`" == v885:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v886
                        v3_1_mut = v4_1
                        v4_1_mut = US7(2, uint8(1), v885)
                        continue

                    elif v3_1.tag == 2:
                        if uint8(0) == v3_1.fields[0]:
                            if "\"" == v885:
                                v0_1_mut = ("" + v0_1) + ""
                                v1_1_mut = v1_1
                                v2_1_mut = v886
                                v3_1_mut = v4_1
                                v4_1_mut = US7(1, "\"")
                                continue

                            elif " " == v885:
                                return method14(("" + v0_1) + " ", v1_1, v886, v4_1)

                            else: 
                                return method14(((("" + v0_1) + "") + str(v885)) + "", v1_1, v886, v4_1)


                        elif "\"" == v885:
                            v0_1_mut = ""
                            v1_1_mut = method15(v1_1, UH1(1, v0_1, UH1(0)))
                            v2_1_mut = v886
                            v3_1_mut = v4_1
                            v4_1_mut = US7(0)
                            continue

                        elif " " == v885:
                            return method14(("" + v0_1) + " ", v1_1, v886, v4_1)

                        else: 
                            return method14(((("" + v0_1) + "") + str(v885)) + "", v1_1, v886, v4_1)


                    elif "\"" == v885:
                        v0_1_mut = ""
                        v1_1_mut = method15(v1_1, UH1(1, v0_1, UH1(0)))
                        v2_1_mut = v886
                        v3_1_mut = v4_1
                        v4_1_mut = US7(0)
                        continue

                    elif " " == v885:
                        return method14(("" + v0_1) + " ", v1_1, v886, v4_1)

                    else: 
                        return method14(((("" + v0_1) + "") + str(v885)) + "", v1_1, v886, v4_1)


                elif v3_1.tag == 2:
                    if uint8(0) == v3_1.fields[0]:
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                    else: 
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                else: 
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


            elif "\\" == v581:
                if v2_1.tag == 1:
                    v998: UH0 = v2_1.fields[1]
                    v997: str = v2_1.fields[0]
                    if "\"" == v997:
                        if (not equals(v3_1, US7(2, uint8(0), "`"))) if (not equals(v3_1, US7(2, uint8(0), "\\"))) else False:
                            v0_1_mut = ((("" + v0_1) + "") + str(v581)) + "\""
                            v1_1_mut = v1_1
                            v2_1_mut = v998
                            v3_1_mut = v4_1
                            v4_1_mut = US7(1, "\"")
                            continue

                        elif v3_1.tag == 1:
                            v0_1_mut = ((("" + v0_1) + "") + str(v581)) + "\""
                            v1_1_mut = v1_1
                            v2_1_mut = v998
                            v3_1_mut = v4_1
                            v4_1_mut = US7(1, "\"")
                            continue

                        else: 
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v998
                            v3_1_mut = v4_1
                            v4_1_mut = US7(0)
                            continue


                    elif v3_1.tag == 1:
                        if "\\" == v997:
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v998
                            v3_1_mut = v4_1
                            v4_1_mut = US7(2, uint8(0), v997)
                            continue

                        elif "`" == v997:
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v998
                            v3_1_mut = v4_1
                            v4_1_mut = US7(2, uint8(0), v997)
                            continue

                        elif " " == v997:
                            return method14(("" + v0_1) + " ", v1_1, v998, v4_1)

                        else: 
                            return method14(((("" + v0_1) + "") + str(v997)) + "", v1_1, v998, v4_1)


                    elif "\\" == v997:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v998
                        v3_1_mut = v4_1
                        v4_1_mut = US7(2, uint8(1), v997)
                        continue

                    elif "`" == v997:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v998
                        v3_1_mut = v4_1
                        v4_1_mut = US7(2, uint8(1), v997)
                        continue

                    elif v3_1.tag == 2:
                        if uint8(0) == v3_1.fields[0]:
                            if " " == v997:
                                return method14(("" + v0_1) + " ", v1_1, v998, v4_1)

                            else: 
                                return method14(((("" + v0_1) + "") + str(v997)) + "", v1_1, v998, v4_1)


                        elif " " == v997:
                            return method14(("" + v0_1) + " ", v1_1, v998, v4_1)

                        else: 
                            return method14(((("" + v0_1) + "") + str(v997)) + "", v1_1, v998, v4_1)


                    elif " " == v997:
                        return method14(("" + v0_1) + " ", v1_1, v998, v4_1)

                    else: 
                        return method14(((("" + v0_1) + "") + str(v997)) + "", v1_1, v998, v4_1)


                elif v3_1.tag == 2:
                    if uint8(0) == v3_1.fields[0]:
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                    else: 
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                elif v3_1.tag == 1:
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                else: 
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


            elif "`" == v581:
                if v2_1.tag == 1:
                    v1137: UH0 = v2_1.fields[1]
                    v1136: str = v2_1.fields[0]
                    if "\"" == v1136:
                        if (not equals(v3_1, US7(2, uint8(0), "`"))) if (not equals(v3_1, US7(2, uint8(0), "\\"))) else False:
                            v0_1_mut = ((("" + v0_1) + "") + str(v581)) + "\""
                            v1_1_mut = v1_1
                            v2_1_mut = v1137
                            v3_1_mut = v4_1
                            v4_1_mut = US7(1, "\"")
                            continue

                        elif v3_1.tag == 1:
                            v0_1_mut = ((("" + v0_1) + "") + str(v581)) + "\""
                            v1_1_mut = v1_1
                            v2_1_mut = v1137
                            v3_1_mut = v4_1
                            v4_1_mut = US7(1, "\"")
                            continue

                        else: 
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v1137
                            v3_1_mut = v4_1
                            v4_1_mut = US7(0)
                            continue


                    elif v3_1.tag == 1:
                        if "\\" == v1136:
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v1137
                            v3_1_mut = v4_1
                            v4_1_mut = US7(2, uint8(0), v1136)
                            continue

                        elif "`" == v1136:
                            v0_1_mut = v0_1
                            v1_1_mut = v1_1
                            v2_1_mut = v1137
                            v3_1_mut = v4_1
                            v4_1_mut = US7(2, uint8(0), v1136)
                            continue

                        elif " " == v1136:
                            return method14(("" + v0_1) + " ", v1_1, v1137, v4_1)

                        else: 
                            return method14(((("" + v0_1) + "") + str(v1136)) + "", v1_1, v1137, v4_1)


                    elif "\\" == v1136:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v1137
                        v3_1_mut = v4_1
                        v4_1_mut = US7(2, uint8(1), v1136)
                        continue

                    elif "`" == v1136:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v1137
                        v3_1_mut = v4_1
                        v4_1_mut = US7(2, uint8(1), v1136)
                        continue

                    elif v3_1.tag == 2:
                        if uint8(0) == v3_1.fields[0]:
                            if " " == v1136:
                                return method14(("" + v0_1) + " ", v1_1, v1137, v4_1)

                            else: 
                                return method14(((("" + v0_1) + "") + str(v1136)) + "", v1_1, v1137, v4_1)


                        elif " " == v1136:
                            return method14(("" + v0_1) + " ", v1_1, v1137, v4_1)

                        else: 
                            return method14(((("" + v0_1) + "") + str(v1136)) + "", v1_1, v1137, v4_1)


                    elif " " == v1136:
                        return method14(("" + v0_1) + " ", v1_1, v1137, v4_1)

                    else: 
                        return method14(((("" + v0_1) + "") + str(v1136)) + "", v1_1, v1137, v4_1)


                elif v3_1.tag == 2:
                    if uint8(0) == v3_1.fields[0]:
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                    else: 
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                elif v3_1.tag == 1:
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                else: 
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


            elif v3_1.tag == 1:
                if v2_1.tag == 1:
                    v1276: UH0 = v2_1.fields[1]
                    v1275: str = v2_1.fields[0]
                    if "\\" == v1275:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v1276
                        v3_1_mut = v4_1
                        v4_1_mut = US7(2, uint8(0), v1275)
                        continue

                    elif "`" == v1275:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v1276
                        v3_1_mut = v4_1
                        v4_1_mut = US7(2, uint8(0), v1275)
                        continue

                    elif "\"" == v1275:
                        v0_1_mut = ""
                        v1_1_mut = method15(v1_1, UH1(1, v0_1, UH1(0)))
                        v2_1_mut = v1276
                        v3_1_mut = v4_1
                        v4_1_mut = US7(0)
                        continue

                    elif " " == v1275:
                        return method14(("" + v0_1) + " ", v1_1, v1276, v4_1)

                    else: 
                        return method14(((("" + v0_1) + "") + str(v1275)) + "", v1_1, v1276, v4_1)


                else: 
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


            elif v2_1.tag == 1:
                v1319: UH0 = v2_1.fields[1]
                v1318: str = v2_1.fields[0]
                if "\\" == v1318:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v1319
                    v3_1_mut = v4_1
                    v4_1_mut = US7(2, uint8(1), v1318)
                    continue

                elif "`" == v1318:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v1319
                    v3_1_mut = v4_1
                    v4_1_mut = US7(2, uint8(1), v1318)
                    continue

                elif v3_1.tag == 2:
                    if uint8(0) == v3_1.fields[0]:
                        if "\"" == v1318:
                            v0_1_mut = ("" + v0_1) + ""
                            v1_1_mut = v1_1
                            v2_1_mut = v1319
                            v3_1_mut = v4_1
                            v4_1_mut = US7(1, "\"")
                            continue

                        elif " " == v1318:
                            return method14(("" + v0_1) + " ", v1_1, v1319, v4_1)

                        else: 
                            return method14(((("" + v0_1) + "") + str(v1318)) + "", v1_1, v1319, v4_1)


                    elif "\"" == v1318:
                        v0_1_mut = ""
                        v1_1_mut = method15(v1_1, UH1(1, v0_1, UH1(0)))
                        v2_1_mut = v1319
                        v3_1_mut = v4_1
                        v4_1_mut = US7(0)
                        continue

                    elif " " == v1318:
                        return method14(("" + v0_1) + " ", v1_1, v1319, v4_1)

                    else: 
                        return method14(((("" + v0_1) + "") + str(v1318)) + "", v1_1, v1319, v4_1)


                elif "\"" == v1318:
                    v0_1_mut = ""
                    v1_1_mut = method15(v1_1, UH1(1, v0_1, UH1(0)))
                    v2_1_mut = v1319
                    v3_1_mut = v4_1
                    v4_1_mut = US7(0)
                    continue

                elif " " == v1318:
                    return method14(("" + v0_1) + " ", v1_1, v1319, v4_1)

                else: 
                    return method14(((("" + v0_1) + "") + str(v1318)) + "", v1_1, v1319, v4_1)


            elif v3_1.tag == 2:
                if uint8(0) == v3_1.fields[0]:
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                else: 
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


            else: 
                return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


        elif v4_1.tag == 0:
            if v2_1.tag == 1:
                v6_1: UH0 = v2_1.fields[1]
                v5_1: str = v2_1.fields[0]
                if "\"" == v5_1:
                    v0_1_mut = ""
                    v1_1_mut = v1_1
                    v2_1_mut = v6_1
                    v3_1_mut = v4_1
                    v4_1_mut = US7(1, "\"")
                    continue

                elif "\\" == v5_1:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v6_1
                    v3_1_mut = v4_1
                    v4_1_mut = US7(2, uint8(0), v5_1)
                    continue

                elif "`" == v5_1:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v6_1
                    v3_1_mut = v4_1
                    v4_1_mut = US7(2, uint8(0), v5_1)
                    continue

                elif " " == v5_1:
                    return method14("", v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v6_1, v4_1)

                else: 
                    return method14(((("" + v0_1) + "") + str(v5_1)) + "", v1_1, v6_1, v4_1)


            else: 
                return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


        else: 
            v53: str = v4_1.fields[1]
            v52: uint8 = v4_1.fields[0]
            if v2_1.tag == 1:
                v55: UH0 = v2_1.fields[1]
                v54: str = v2_1.fields[0]
                if "\\" == v54:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v55
                    v3_1_mut = v4_1
                    v4_1_mut = US7(1, v54)
                    continue

                elif "`" == v54:
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v55
                    v3_1_mut = v4_1
                    v4_1_mut = US7(1, v54)
                    continue

                elif v3_1.tag == 0:
                    if "\"" == v54:
                        return method14(v0_1, v1_1, v55, v4_1)

                    elif uint8(0) == v52:
                        if "\\" == v53:
                            if " " == v54:
                                return method14(("" + v0_1) + " ", v1_1, v55, v4_1)

                            elif uint8(1) == v52:
                                if not equals(v3_1, v4_1):
                                    v0_1_mut = ((("" + v0_1) + "\\") + str(v54)) + ""
                                    v1_1_mut = v1_1
                                    v2_1_mut = v55
                                    v3_1_mut = v4_1
                                    v4_1_mut = v3_1
                                    continue

                                else: 
                                    return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                            else: 
                                return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                        elif "`" == v53:
                            if " " == v54:
                                return method14(("" + v0_1) + " ", v1_1, v55, v4_1)

                            elif uint8(1) == v52:
                                if not equals(v3_1, v4_1):
                                    v0_1_mut = ((("" + v0_1) + "\\") + str(v54)) + ""
                                    v1_1_mut = v1_1
                                    v2_1_mut = v55
                                    v3_1_mut = v4_1
                                    v4_1_mut = v3_1
                                    continue

                                else: 
                                    return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                            else: 
                                return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                        elif " " == v54:
                            return method14(("" + v0_1) + " ", v1_1, v55, v4_1)

                        elif uint8(1) == v52:
                            if not equals(v3_1, v4_1):
                                v0_1_mut = ((("" + v0_1) + "\\") + str(v54)) + ""
                                v1_1_mut = v1_1
                                v2_1_mut = v55
                                v3_1_mut = v4_1
                                v4_1_mut = v3_1
                                continue

                            else: 
                                return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                        else: 
                            return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                    elif " " == v54:
                        return method14(("" + v0_1) + " ", v1_1, v55, v4_1)

                    elif uint8(1) == v52:
                        if not equals(v3_1, v4_1):
                            v0_1_mut = ((("" + v0_1) + "\\") + str(v54)) + ""
                            v1_1_mut = v1_1
                            v2_1_mut = v55
                            v3_1_mut = v4_1
                            v4_1_mut = v3_1
                            continue

                        else: 
                            return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                    else: 
                        return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                elif uint8(0) == v52:
                    if "\\" == v53:
                        if v3_1.tag == 1:
                            if "\"" == v3_1.fields[0]:
                                v0_1_mut = ((((("" + v0_1) + "") + str(v53)) + "") + str(v54)) + ""
                                v1_1_mut = v1_1
                                v2_1_mut = v55
                                v3_1_mut = v4_1
                                v4_1_mut = US7(1, "\"")
                                continue

                            elif "\"" == v54:
                                v0_1_mut = ((("" + v0_1) + "") + str(v53)) + "\""
                                v1_1_mut = v1_1
                                v2_1_mut = v55
                                v3_1_mut = v4_1
                                v4_1_mut = US7(2, v52, v53)
                                continue

                            elif " " == v54:
                                return method14(("" + v0_1) + " ", v1_1, v55, v4_1)

                            elif uint8(1) == v52:
                                if not equals(v3_1, v4_1):
                                    v0_1_mut = ((("" + v0_1) + "\\") + str(v54)) + ""
                                    v1_1_mut = v1_1
                                    v2_1_mut = v55
                                    v3_1_mut = v4_1
                                    v4_1_mut = v3_1
                                    continue

                                else: 
                                    return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                            else: 
                                return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                        elif "\"" == v54:
                            v0_1_mut = ((("" + v0_1) + "") + str(v53)) + "\""
                            v1_1_mut = v1_1
                            v2_1_mut = v55
                            v3_1_mut = v4_1
                            v4_1_mut = US7(2, v52, v53)
                            continue

                        elif " " == v54:
                            return method14(("" + v0_1) + " ", v1_1, v55, v4_1)

                        elif uint8(1) == v52:
                            if not equals(v3_1, v4_1):
                                v0_1_mut = ((("" + v0_1) + "\\") + str(v54)) + ""
                                v1_1_mut = v1_1
                                v2_1_mut = v55
                                v3_1_mut = v4_1
                                v4_1_mut = v3_1
                                continue

                            else: 
                                return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                        else: 
                            return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                    elif "`" == v53:
                        if v3_1.tag == 1:
                            if "\"" == v3_1.fields[0]:
                                v0_1_mut = ((((("" + v0_1) + "") + str(v53)) + "") + str(v54)) + ""
                                v1_1_mut = v1_1
                                v2_1_mut = v55
                                v3_1_mut = v4_1
                                v4_1_mut = US7(1, "\"")
                                continue

                            elif "\"" == v54:
                                v0_1_mut = ((("" + v0_1) + "") + str(v53)) + "\""
                                v1_1_mut = v1_1
                                v2_1_mut = v55
                                v3_1_mut = v4_1
                                v4_1_mut = US7(2, v52, v53)
                                continue

                            elif " " == v54:
                                return method14(("" + v0_1) + " ", v1_1, v55, v4_1)

                            elif uint8(1) == v52:
                                if not equals(v3_1, v4_1):
                                    v0_1_mut = ((("" + v0_1) + "\\") + str(v54)) + ""
                                    v1_1_mut = v1_1
                                    v2_1_mut = v55
                                    v3_1_mut = v4_1
                                    v4_1_mut = v3_1
                                    continue

                                else: 
                                    return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                            else: 
                                return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                        elif "\"" == v54:
                            v0_1_mut = ((("" + v0_1) + "") + str(v53)) + "\""
                            v1_1_mut = v1_1
                            v2_1_mut = v55
                            v3_1_mut = v4_1
                            v4_1_mut = US7(2, v52, v53)
                            continue

                        elif " " == v54:
                            return method14(("" + v0_1) + " ", v1_1, v55, v4_1)

                        elif uint8(1) == v52:
                            if not equals(v3_1, v4_1):
                                v0_1_mut = ((("" + v0_1) + "\\") + str(v54)) + ""
                                v1_1_mut = v1_1
                                v2_1_mut = v55
                                v3_1_mut = v4_1
                                v4_1_mut = v3_1
                                continue

                            else: 
                                return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                        else: 
                            return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                    elif "\"" == v54:
                        v0_1_mut = ((("" + v0_1) + "") + str(v53)) + "\""
                        v1_1_mut = v1_1
                        v2_1_mut = v55
                        v3_1_mut = v4_1
                        v4_1_mut = US7(2, v52, v53)
                        continue

                    elif " " == v54:
                        return method14(("" + v0_1) + " ", v1_1, v55, v4_1)

                    elif uint8(1) == v52:
                        if not equals(v3_1, v4_1):
                            v0_1_mut = ((("" + v0_1) + "\\") + str(v54)) + ""
                            v1_1_mut = v1_1
                            v2_1_mut = v55
                            v3_1_mut = v4_1
                            v4_1_mut = v3_1
                            continue

                        else: 
                            return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                    else: 
                        return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                elif "\"" == v54:
                    v0_1_mut = ((("" + v0_1) + "") + str(v53)) + "\""
                    v1_1_mut = v1_1
                    v2_1_mut = v55
                    v3_1_mut = v4_1
                    v4_1_mut = US7(2, v52, v53)
                    continue

                elif " " == v54:
                    return method14(("" + v0_1) + " ", v1_1, v55, v4_1)

                elif uint8(1) == v52:
                    if not equals(v3_1, v4_1):
                        v0_1_mut = ((("" + v0_1) + "\\") + str(v54)) + ""
                        v1_1_mut = v1_1
                        v2_1_mut = v55
                        v3_1_mut = v4_1
                        v4_1_mut = v3_1
                        continue

                    else: 
                        return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


                else: 
                    return method14(((("" + v0_1) + "") + str(v54)) + "", v1_1, v55, v4_1)


            elif v3_1.tag == 0:
                if uint8(0) == v52:
                    if "\\" == v53:
                        if uint8(1) == v52:
                            return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                        else: 
                            return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                    elif "`" == v53:
                        if uint8(1) == v52:
                            return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                        else: 
                            return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                    elif uint8(1) == v52:
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                    else: 
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                elif uint8(1) == v52:
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                else: 
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


            elif uint8(0) == v52:
                if "\\" == v53:
                    if v3_1.tag == 1:
                        if "\"" == v3_1.fields[0]:
                            if uint8(1) == v52:
                                return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                            else: 
                                return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                        elif uint8(1) == v52:
                            return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                        else: 
                            return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                    elif uint8(1) == v52:
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                    else: 
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                elif "`" == v53:
                    if v3_1.tag == 1:
                        if "\"" == v3_1.fields[0]:
                            if uint8(1) == v52:
                                return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                            else: 
                                return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                        elif uint8(1) == v52:
                            return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                        else: 
                            return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                    elif uint8(1) == v52:
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                    else: 
                        return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


                elif uint8(1) == v52:
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

                else: 
                    return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


            elif uint8(1) == v52:
                return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)

            else: 
                return (v1_1 if (v0_1 == "") else method15(v1_1, UH1(1, v0_1, UH1(0))), v0_1)


        break


def method16(v0_1: UH1, v1_1: FSharpList[str]) -> FSharpList[str]:
    if v0_1.tag == 0:
        return v1_1

    else: 
        return cons(v0_1.fields[0], method16(v0_1.fields[1], v1_1))



def method12(v0_1: str) -> Array[str]:
    _v0: (str | None) | None = None
    _v0 = some(v0_1)
    v5_1: str | None = value_2(_v0)
    _v6: FSharpRef[US4 | None] = FSharpRef(None)
    x_3: US4 | None
    if v5_1 is None:
        x_3 = None

    else: 
        x_1: str = v5_1
        def x_2(__unit: None=None, v0_1: Any=v0_1) -> US4:
            return US4(0, x_1)

        x_3 = x_2(None)

    _v6.contents = x_3
    v11: US4 = default_arg(_v6.contents, US4(1))
    v14: str = v11.fields[0] if (v11.tag == 0) else ""
    v15: int = len(v14) or 0
    v16: Array[str] = fill([0] * v15, 0, v15, "")
    v17: Mut4 = Mut4(0)
    while method4(v15, v17):
        v19: int = v17.l0 or 0
        v20: str = v14[v19]
        v16[v19] = v20
        v21: int = (v19 + 1) or 0
        v17.l0 = v21 or 0
    v23: FSharpList[str] = of_array(v16)
    return to_array(method16(method13("", UH1(0), fold_back(uncurry2(method5()), v23, UH0(0)), US7(0), US7(0))[0], empty()))


def closure18(unit_var: None, v0_1: str) -> Array[str]:
    return method12(v0_1)


def _arrow214(v: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, v)


v0: Callable[[US0], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow214

v1: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v0(v1))


def _arrow215(__unit: None=None) -> bool:
    return closure2(None, None)


v2: Callable[[], bool] = _arrow215

def is_windows(__unit: None=None) -> bool:
    return v2(None)


def _arrow216(__unit: None=None) -> str:
    return closure3(None, None)


v3: Callable[[], str] = _arrow216

def get_executable_suffix(__unit: None=None) -> str:
    return v3(None)


def _arrow217(v: str) -> Async[tuple[int, str]]:
    return closure4(None, v)


v4: Callable[[str], Async[tuple[int, str]]] = _arrow217

def execute_async(x: str) -> Async[tuple[int, str]]:
    return v4(x)


def _arrow218(_arg10: tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return closure16(None, _arg10)


v5: Callable[[tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]], Async[tuple[int, str]]] = _arrow218

def execute_with_options_async(x: tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return v5(x)


def _arrow219(v: Callable[[Heap0], Heap0]) -> tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]:
    return closure17(None, v)


v6: Callable[[Callable[[Heap0], Heap0]], tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]] = _arrow219

def execution_options(x: Callable[[Heap0], Heap0]) -> tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]:
    return v6(x)


def _arrow220(v: str) -> Array[str]:
    return closure18(None, v)


v7: Callable[[str], Array[str]] = _arrow220

def split_args(x: str) -> Array[str]:
    return v7(x)


