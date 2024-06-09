from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.array_ import fill
from fable_modules.fable_library.async_builder import (Async, CancellationToken)
from fable_modules.fable_library.date import (ticks as ticks_1, now, to_string, create as create_1)
from fable_modules.fable_library.list import (of_array, FSharpList, fold_back, to_array, cons, empty, item, length)
from fable_modules.fable_library.long import (op_subtraction, op_addition)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (value as value_12, default_arg, some)
from fable_modules.fable_library.range import range_big_int
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, bool_type, string_type, unit_type, lambda_type, int32_type, char_type, tuple_type, class_type, option_type, array_type)
from fable_modules.fable_library.result import FSharpResult_2
from fable_modules.fable_library.seq import (delay, map)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, replace, to_text, interpolate, replicate, join)
from fable_modules.fable_library.system_text import (StringBuilder__Clear, StringBuilder__Append_Z721C83C5, StringBuilder__ctor_Z721C83C5)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare, uncurry2, IEnumerable_1)

State_trace_state: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr145() -> TypeInfo:
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


US0_reflection = _expr145

def _expr146() -> TypeInfo:
    return record_type("Runtime.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr146

def _expr147() -> TypeInfo:
    return record_type("Runtime.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr147

def _expr148() -> TypeInfo:
    return record_type("Runtime.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr148

def _expr149() -> TypeInfo:
    return record_type("Runtime.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr149

def _expr150() -> TypeInfo:
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


US1_reflection = _expr150

def _expr151() -> TypeInfo:
    return union_type("Runtime.US2", [], US2, lambda: [[("f0_0", US0_reflection())], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr151

def _expr152() -> TypeInfo:
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


US3_reflection = _expr152

def _expr153() -> TypeInfo:
    return record_type("Runtime.Mut4", [], Mut4, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: int

Mut4_reflection = _expr153

def _expr154() -> TypeInfo:
    return union_type("Runtime.UH0", [], UH0, lambda: [[], [("Item1", char_type), ("Item2", UH0_reflection())]])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr154

def _expr155() -> TypeInfo:
    return union_type("Runtime.US5", [], US5, lambda: [[], []])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr155

def _expr156() -> TypeInfo:
    return union_type("Runtime.US4", [], US4, lambda: [[], [("f1_0", US5_reflection())], []])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1", "US4_2"]


US4_reflection = _expr156

def _expr157() -> TypeInfo:
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


US6_reflection = _expr157

def _expr158() -> TypeInfo:
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


US7_reflection = _expr158

def _expr159() -> TypeInfo:
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

Heap0_reflection = _expr159

def _expr160() -> TypeInfo:
    return union_type("Runtime.US8", [], US8, lambda: [[("f0_0", array_type(string_type))], [("f1_0", string_type)]])


class US8(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US8_0", "US8_1"]


US8_reflection = _expr160

def _expr161() -> TypeInfo:
    return union_type("Runtime.UH1", [], UH1, lambda: [[], [("Item1", string_type), ("Item2", UH1_reflection())]])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr161

def _expr162() -> TypeInfo:
    return union_type("Runtime.US9", [], US9, lambda: [[("f0_0", UH1_reflection()), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US9(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US9_0", "US9_1"]


US9_reflection = _expr162

def _expr163() -> TypeInfo:
    return union_type("Runtime.US10", [], US10, lambda: [[("f0_0", char_type), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US10(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US10_0", "US10_1"]


US10_reflection = _expr163

def _expr164() -> TypeInfo:
    return union_type("Runtime.US11", [], US11, lambda: [[("f0_0", char_type)], []])


class US11(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US11_0", "US11_1"]


US11_reflection = _expr164

def _expr165() -> TypeInfo:
    return union_type("Runtime.US12", [], US12, lambda: [[("f0_0", string_type), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US12(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US12_0", "US12_1"]


US12_reflection = _expr165

def _expr166() -> TypeInfo:
    return union_type("Runtime.UH2", [], UH2, lambda: [[], [("Item1", lambda_type(tuple_type(string_type, class_type("System.Text.StringBuilder"), int32_type, int32_type), US12_reflection())), ("Item2", UH2_reflection())]])


class UH2(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH2_0", "UH2_1"]


UH2_reflection = _expr166

def _expr167() -> TypeInfo:
    return union_type("Runtime.US13", [], US13, lambda: [[("f0_0", string_type), ("f0_1", class_type("System.Text.StringBuilder")), ("f0_2", int32_type), ("f0_3", int32_type)], [("f1_0", string_type)]])


class US13(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US13_0", "US13_1"]


US13_reflection = _expr167

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



def US4__get_IsUS4_2(this: FSharpRef[US4], unit_arg: None) -> bool:
    if this.tag == 2:
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



def US9__get_IsUS9_0(this: FSharpRef[US9], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US9__get_IsUS9_1(this: FSharpRef[US9], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US10__get_IsUS10_0(this: FSharpRef[US10], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US10__get_IsUS10_1(this: FSharpRef[US10], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US11__get_IsUS11_0(this: FSharpRef[US11], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US11__get_IsUS11_1(this: FSharpRef[US11], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US12__get_IsUS12_0(this: FSharpRef[US12], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US12__get_IsUS12_1(this: FSharpRef[US12], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def UH2__get_IsUH2_0(this: UH2, unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def UH2__get_IsUH2_1(this: UH2, unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US13__get_IsUS13_0(this: FSharpRef[US13], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US13__get_IsUS13_1(this: FSharpRef[US13], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def method0(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method2(__unit: None=None) -> str:
    return ""


def method1(v0_1: str) -> str:
    _v1: str | None = None
    v50: IOsEnviron = os
    v52: Any = v50.environ
    x: str = v52.get(v0_1)
    _v1 = x
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method3(__unit: None=None) -> str:
    return "AUTOMATION"


def closure1(unit_var: None, v0_1: str) -> None:
    pass


def closure0(unit_var: None, v0_1: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    _v1: tuple[US1, US2] | None = None
    v133: str = method1(method0())
    v139: US2 = US2(0, US0(0)) if ("Verbose" == v133) else US2(1)
    v184: US2
    if v139.tag == 0:
        v184 = US2(0, v139.fields[0])

    else: 
        v147: US2 = US2(0, US0(1)) if ("Debug" == v133) else US2(1)
        if v147.tag == 0:
            v184 = US2(0, v147.fields[0])

        else: 
            v155: US2 = US2(0, US0(2)) if ("Info" == v133) else US2(1)
            if v155.tag == 0:
                v184 = US2(0, v155.fields[0])

            else: 
                v163: US2 = US2(0, US0(3)) if ("Warning" == v133) else US2(1)
                if v163.tag == 0:
                    v184 = US2(0, v163.fields[0])

                else: 
                    v171: US2 = US2(0, US0(4)) if ("Critical" == v133) else US2(1)
                    v184 = US2(0, v171.fields[0]) if (v171.tag == 0) else US2(1)




    x: tuple[US1, US2] = (US1(0, ticks_1(now())) if (method1(method3()) == "True") else US1(1), v184)
    _v1 = x
    pattern_input: tuple[US1, US2]
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        pattern_input = _v1

    v259: US2 = pattern_input[1]
    v258: US1 = pattern_input[0]
    def v266(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure1(None, v)

    v267: Mut3 = Mut3(v266)
    return (Mut0(int64(0)), Mut1(True), Mut2(v259.fields[0] if (v259.tag == 0) else v0_1), v258.fields[0] if (v258.tag == 0) else None, v267)


def closure4(unit_var: None, unit_var_1: None) -> str:
    return "runtime.current_process_kill / exiting... 3"


def closure5(unit_var: None, unit_var_1: None) -> str:
    return ""


def method5(__unit: None=None) -> str:
    return "hh:mm:ss"


def method6(__unit: None=None) -> str:
    return ""


def method7(__unit: None=None) -> str:
    return "HH:mm:ss"


def closure6(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_12(State_trace_state())
    v8: int64 | None = pattern_input[3]
    _v10: str | None = None
    _v93: FSharpRef[US1 | None] = FSharpRef(None)
    x_2: US1 | None
    if v8 is None:
        x_2 = None

    else: 
        x: int64 = v8
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US1:
            return US1(0, x)

        x_2 = x_1(None)

    _v93.contents = x_2
    v98: US1 = default_arg(_v93.contents, US1(1))
    def _arrow168(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v105: Any = create(op_subtraction(ticks_1(now()), v98.fields[0]))
        return create_1(1, 1, 1, hours(v105), minutes(v105), seconds(v105), milliseconds(v105))

    x_3: str = to_string(_arrow168() if (v98.tag == 0) else now(), method7())
    _v10 = x_3
    v147: str
    if _v10 is None:
        raise Exception("base.run_target / _v10=None")

    else: 
        v147 = _v10

    v154: US3 = US3(0, "Verbose") if (True if (v0_1.tag == 0) else False) else US3(1)
    v203: US3
    if v154.tag == 0:
        v203 = US3(0, v154.fields[0])

    else: 
        v163: US3 = US3(0, "Debug") if (True if (v0_1.tag == 1) else False) else US3(1)
        if v163.tag == 0:
            v203 = US3(0, v163.fields[0])

        else: 
            v172: US3 = US3(0, "Info") if (True if (v0_1.tag == 2) else False) else US3(1)
            if v172.tag == 0:
                v203 = US3(0, v172.fields[0])

            else: 
                v181: US3 = US3(0, "Warning") if (True if (v0_1.tag == 3) else False) else US3(1)
                if v181.tag == 0:
                    v203 = US3(0, v181.fields[0])

                else: 
                    v190: US3 = US3(0, "Critical") if (True if (v0_1.tag == 4) else False) else US3(1)
                    v203 = US3(0, v190.fields[0]) if (v190.tag == 0) else US3(1)




    v207: str
    if v203.tag == 0:
        v207 = v203.fields[0]

    else: 
        raise Exception("Option does not have a value.")

    _v211: str | None = None
    x_5: str = pad_left(v207.lower(), 7, " ")
    _v211 = x_5
    def _arrow169(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> str:
        raise Exception("base.run_target / _v211=None")

    return trim_end(trim_start(((((((((("" + v147) + " ") + (_arrow169() if (_v211 is None) else _v211)) + " #") + str(pattern_input[0].l0)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method8(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(v: US0, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
        return closure0(None, v)

    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_12(State_trace_state())
    v4_1: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_12(State_trace_state())
    v15: US0 = pattern_input_1[2].l0
    class ObjectExpr170:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr171:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr170())) >= find(v15, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr171()))):
        v23: int64 = op_addition(v4_1.l0, int64(1))
        v4_1.l0 = v23
        v24: str = ("" + v1_1(None)) + ""
        _v25: None | None = None
        print(v24)
        _v25 = some(None)
        if _v25 is None:
            raise Exception("base.run_target / _v25=None")

        else: 
            value_12(_v25)

        pattern_input[4].l0(v24)



def method4(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure6(v0_1, v1_1, v2_1, None)

    method8(v0_1, v3_1)


def closure7(unit_var: None, unit_var_1: None) -> str:
    return "runtime.current_process_kill / exiting... 2"


def closure8(unit_var: None, unit_var_1: None) -> str:
    return "runtime.current_process_kill / exiting... 1"


def closure3(unit_var: None, unit_var_1: None) -> None:
    _v0: None | None = None
    _v0 = some(None)
    if _v0 is None:
        raise Exception("base.run_target / _v0=None")

    else: 
        value_12(_v0)



def closure2(unit_var: None, unit_var_1: None) -> None:
    _v0: None | None = None
    _v0 = some(None)
    if _v0 is None:
        raise Exception("base.run_target / _v0=None")

    else: 
        value_12(_v0)



def method11(__unit: None=None) -> tuple[str, str]:
    return ("", "")


def method12(v0_1: int, v1_1: Mut4) -> bool:
    return v1_1.l0 < v0_1


def closure11(v0_1: str, v1_1: UH0) -> UH0:
    return UH0(1, v0_1, v1_1)


def closure10(unit_var: None, v0_1: str) -> Callable[[UH0], UH0]:
    def _arrow172(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure11(v0_1, v)

    return _arrow172


def method13(__unit: None=None) -> Callable[[str, UH0], UH0]:
    def _arrow173(v: str) -> Callable[[UH0], UH0]:
        return closure10(None, v)

    return _arrow173


def method14(v0_1_mut: str, v1_1_mut: str, v2_1_mut: UH0, v3_1_mut: US4) -> tuple[str, str]:
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
                    v3_1_mut = US4(1, US5(0))
                    continue

                elif v3_1.tag == 1:
                    if v3_1.fields[0].tag == 0:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5_1
                        v3_1_mut = US4(1, US5(1))
                        continue

                    elif " " == v4_1:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5_1
                        v3_1_mut = US4(2)
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
                        v3_1_mut = US4(2)
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
                    v3_1_mut = US4(2)
                    continue


            elif "\'" == v4_1:
                if v1_1 == "":
                    v0_1_mut = v0_1
                    v1_1_mut = v1_1
                    v2_1_mut = v5_1
                    v3_1_mut = US4(1, US5(0))
                    continue

                elif v3_1.tag == 1:
                    if v3_1.fields[0].tag == 0:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5_1
                        v3_1_mut = US4(1, US5(1))
                        continue

                    elif " " == v4_1:
                        v0_1_mut = v0_1
                        v1_1_mut = v1_1
                        v2_1_mut = v5_1
                        v3_1_mut = US4(2)
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
                        v3_1_mut = US4(2)
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
                    v3_1_mut = US4(2)
                    continue


            elif v3_1.tag == 1:
                if v3_1.fields[0].tag == 0:
                    if " " == v4_1:
                        v0_1_mut = v0_1
                        v1_1_mut = ("" + v1_1) + " "
                        v2_1_mut = v5_1
                        v3_1_mut = US4(1, US5(0))
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
                    v3_1_mut = US4(2)
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
                    v3_1_mut = US4(2)
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
                v3_1_mut = US4(2)
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


def method10(v0_1: str) -> tuple[str, str]:
    pattern_input: tuple[str, str] = method11()
    v3_1: int = len(v0_1) or 0
    v4_1: Array[str] = fill([0] * v3_1, 0, v3_1, "")
    v5_1: Mut4 = Mut4(0)
    while method12(v3_1, v5_1):
        v7: int = v5_1.l0 or 0
        v8: str = v0_1[v7]
        v4_1[v7] = v8
        v9: int = (v7 + 1) or 0
        v5_1.l0 = v9 or 0
    v11: FSharpList[str] = of_array(v4_1)
    return method14(pattern_input[1], pattern_input[0], fold_back(uncurry2(method13()), v11, UH0(0)), US4(0))


def closure12(v0_1: CancellationToken | None, v1_1: str, v2_1: Array[tuple[str, str]], v3_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v4_1: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, v5_1: bool, v6_1: str | None, unit_var: None) -> str:
    return to_text(interpolate("runtime.execute_with_options_async / options: %A%P()", [(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1)]))


def method15(__unit: None=None) -> Callable[[], str]:
    def _arrow174(__unit: None=None) -> str:
        return closure5(None, None)

    return _arrow174


def closure14(v0_1: str, unit_var: None) -> str:
    return v0_1


def closure13(v0_1: CancellationToken | None, v1_1: str, v2_1: Array[tuple[str, str]], v3_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v4_1: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, v5_1: bool, v6_1: str | None, v7: None, v8: Any, v9: None) -> None:
    _v10: Async[None] | None = None
    _v10 = None
    v39: Async[None]
    if _v10 is None:
        raise Exception("base.run_target / _v10=None")

    else: 
        v39 = _v10

    _v40: None | None = None
    _v40 = some(None)
    if _v40 is None:
        raise Exception("base.run_target / _v40=None")

    else: 
        value_12(_v40)



def closure15(v0_1: CancellationToken | None, v1_1: str, v2_1: Array[tuple[str, str]], v3_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v4_1: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, v5_1: bool, v6_1: str | None, v7: None, v8: Any, v9: None) -> None:
    _v10: Async[None] | None = None
    _v10 = None
    v40: Async[None]
    if _v10 is None:
        raise Exception("base.run_target / _v10=None")

    else: 
        v40 = _v10

    _v41: None | None = None
    _v41 = some(None)
    if _v41 is None:
        raise Exception("base.run_target / _v41=None")

    else: 
        value_12(_v41)



def closure16(v0_1: None, unit_var: None) -> None:
    _v1: bool | None = None
    _v1 = None
    def _arrow175(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> bool:
        raise Exception("base.run_target / _v1=None")

    if (_arrow175() if (_v1 is None) else _v1) == False:
        _v10: None | None = None
        _v10 = some(None)
        if _v10 is None:
            raise Exception("base.run_target / _v10=None")

        else: 
            value_12(_v10)




def closure17(v0_1: Any, unit_var: None) -> str:
    return to_text(interpolate("runtime.execute_with_options_async / WaitForExitAsync / ex: %A%P()", [v0_1]))


def closure18(v0_1: int, v1_1: str, unit_var: None) -> str:
    return ((("runtime.execute_with_options_async / exit_code: " + str(v0_1)) + " / output.Length: ") + str(len(v1_1))) + ""


def method9(v0_1: CancellationToken | None, v1_1: str, v2_1: Array[tuple[str, str]], v3_1: Callable[[tuple[bool, str, int]], Async[None]] | None, v4_1: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, v5_1: bool, v6_1: str | None=None) -> Async[tuple[int, str]]:
    _v7: Async[tuple[int, str]] | None = None
    _v7 = None
    if _v7 is None:
        raise Exception("base.run_target / _v7=None")

    else: 
        return _v7



def closure9(unit_var: None, v0_1: str) -> Async[tuple[int, str]]:
    return method9(None, v0_1, [], None, None, True, None)


def closure19(unit_var: None, _arg: tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return method9(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6])


def closure20(unit_var: None, v0_1: Callable[[Heap0], Heap0]) -> tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]:
    v8: Heap0 = v0_1(Heap0(None, "", [], None, None, True, None))
    return (v8.l0, v8.l1, v8.l2, v8.l3, v8.l4, v8.l5, v8.l6)


def method18(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(4):
            return False

        else: 
            v19: US11
            if v1_1 == int64(0):
                v19 = US11(0, "\\")

            else: 
                v5_1: int64 = op_subtraction(v1_1, int64(1))
                if v5_1 == int64(0):
                    v19 = US11(0, "`")

                else: 
                    v8: int64 = op_subtraction(v5_1, int64(1))
                    if v8 == int64(0):
                        v19 = US11(0, "\"")

                    else: 
                        v11: int64 = op_subtraction(v8, int64(1))
                        if v11 == int64(0):
                            v19 = US11(0, " ")

                        else: 
                            v14: int64 = op_subtraction(v11, int64(1))
                            v19 = US11(1)




            def _arrow176(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v19.fields[0] if (v19.tag == 0) else _arrow176()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def method19(v0_1_mut: UH0, v1_1_mut: Any, v2_1_mut: int, v3_1_mut: int) -> tuple[Any, int, int]:
    while True:
        (v0_1, v1_1, v2_1, v3_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut)
        if v0_1.tag == 0:
            return (v1_1, v2_1, v3_1)

        else: 
            v4_1: str = v0_1.fields[0]
            v6_1: bool = "\n" == v4_1
            pattern_input: tuple[int, int] = ((1, v3_1 + 1)) if v6_1 else ((v2_1 + 1, v3_1))
            v0_1_mut = v0_1.fields[1]
            def _arrow177(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1) -> Any:
                v12: Any = StringBuilder__Clear(v1_1)
                return v1_1

            def _arrow178(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1) -> Any:
                v16: Any = StringBuilder__Append_Z721C83C5(v1_1, v4_1)
                return v1_1

            v1_1_mut = _arrow177() if v6_1 else _arrow178()
            v2_1_mut = pattern_input[0]
            v3_1_mut = pattern_input[1]
            continue

        break


def method20(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_1_mut: int, v4_1_mut: int) -> US12:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v57: US10
        if "" == v1_1:
            v57 = US10(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3_1, v4_1)])))

        else: 
            v15: str = v1_1[0]
            v17: int = len(v1_1) or 0
            v22: str = v1_1[1:v17 + 1]
            if method18(v15, int64(0)) == False:
                v27: str = v15
                v28: int = len(v27) or 0
                v29: Array[str] = fill([0] * v28, 0, v28, "")
                v30: Mut4 = Mut4(0)
                while method12(v28, v30):
                    v32: int = v30.l0 or 0
                    v33: str = v27[v32]
                    v29[v32] = v33
                    v34: int = (v32 + 1) or 0
                    v30.l0 = v34 or 0
                v36: FSharpList[str] = of_array(v29)
                pattern_input: tuple[Any, int, int] = method19(fold_back(uncurry2(method13()), v36, UH0(0)), v2_1, v3_1, v4_1)
                v57 = US10(0, v15, v22, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v57 = US10(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v15, to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3_1, v4_1)])))


        if v57.tag == 0:
            v0_1_mut = v0_1 + v57.fields[0]
            v1_1_mut = v57.fields[1]
            v2_1_mut = v57.fields[2]
            v3_1_mut = v57.fields[3]
            v4_1_mut = v57.fields[4]
            continue

        else: 
            return US12(0, v0_1, v1_1, v2_1, v3_1, v4_1)

        break


def method22(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(3):
            return False

        else: 
            v15: US11
            if v1_1 == int64(0):
                v15 = US11(0, "\\")

            else: 
                v5_1: int64 = op_subtraction(v1_1, int64(1))
                if v5_1 == int64(0):
                    v15 = US11(0, "`")

                else: 
                    v8: int64 = op_subtraction(v5_1, int64(1))
                    if v8 == int64(0):
                        v15 = US11(0, "\"")

                    else: 
                        v11: int64 = op_subtraction(v8, int64(1))
                        v15 = US11(1)



            def _arrow179(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v15.fields[0] if (v15.tag == 0) else _arrow179()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def closure22(unit_var: None, _arg: tuple[str, Any, int, int]) -> US12:
    v3_1: int = _arg[3] or 0
    v2_1: int = _arg[2] or 0
    v1_1: Any = _arg[1]
    v0_1: str = _arg[0]
    v60: US10
    if "" == v0_1:
        v60 = US10(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v1_1, v2_1, v3_1)])))

    else: 
        v7: str = v0_1[0]
        if v7 == "\\":
            v10: int = len(v0_1) or 0
            v15: str = v0_1[1:v10 + 1]
            v17: str = v7
            v18: int = len(v17) or 0
            v19: Array[str] = fill([0] * v18, 0, v18, "")
            v20: Mut4 = Mut4(0)
            while method12(v18, v20):
                v22: int = v20.l0 or 0
                v23: str = v17[v22]
                v19[v22] = v23
                v24: int = (v22 + 1) or 0
                v20.l0 = v24 or 0
            v26: FSharpList[str] = of_array(v19)
            pattern_input: tuple[Any, int, int] = method19(fold_back(uncurry2(method13()), v26, UH0(0)), v1_1, v2_1, v3_1)
            v60 = US10(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v38: int = len(v0_1) or 0
            v41: int = (v0_1.find("\n") - 1) or 0
            v43: int = (v38 if (-2 == v41) else v41) or 0
            v60 = US10(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\\")) + "\' / line: ") + str(v3_1)) + " / col: ") + str(v2_1)) + "\n") + str(v1_1)) + "") + v0_1[0:v43 + 1]) + "")) + "\n") + (replicate(v2_1 - 1, " ") + "^")) + "\n")


    v102: US10
    if v60.tag == 0:
        v65: int = v60.fields[4] or 0
        v64: int = v60.fields[3] or 0
        v63: Any = v60.fields[2]
        v62: str = v60.fields[1]
        if "" == v62:
            v102 = US10(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v63, v64, v65)])))

        else: 
            v69: str = v62[0]
            v71: int = len(v62) or 0
            v76: str = v62[1:v71 + 1]
            v78: str = v69
            v79: int = len(v78) or 0
            v80: Array[str] = fill([0] * v79, 0, v79, "")
            v81: Mut4 = Mut4(0)
            while method12(v79, v81):
                v83: int = v81.l0 or 0
                v84: str = v78[v83]
                v80[v83] = v84
                v85: int = (v83 + 1) or 0
                v81.l0 = v85 or 0
            v87: FSharpList[str] = of_array(v80)
            pattern_input_1: tuple[Any, int, int] = method19(fold_back(uncurry2(method13()), v87, UH0(0)), v63, v64, v65)
            v102 = US10(0, v69, v76, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])


    else: 
        v102 = US10(1, v60.fields[0])

    if v102.tag == 0:
        return US12(0, ((("" + str("\\")) + "") + str(v102.fields[0])) + "", v102.fields[1], v102.fields[2], v102.fields[3], v102.fields[4])

    else: 
        return US12(1, v102.fields[0])



def closure23(unit_var: None, _arg: tuple[str, Any, int, int]) -> US12:
    v3_1: int = _arg[3] or 0
    v2_1: int = _arg[2] or 0
    v1_1: Any = _arg[1]
    v0_1: str = _arg[0]
    v60: US10
    if "" == v0_1:
        v60 = US10(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v1_1, v2_1, v3_1)])))

    else: 
        v7: str = v0_1[0]
        if v7 == "`":
            v10: int = len(v0_1) or 0
            v15: str = v0_1[1:v10 + 1]
            v17: str = v7
            v18: int = len(v17) or 0
            v19: Array[str] = fill([0] * v18, 0, v18, "")
            v20: Mut4 = Mut4(0)
            while method12(v18, v20):
                v22: int = v20.l0 or 0
                v23: str = v17[v22]
                v19[v22] = v23
                v24: int = (v22 + 1) or 0
                v20.l0 = v24 or 0
            v26: FSharpList[str] = of_array(v19)
            pattern_input: tuple[Any, int, int] = method19(fold_back(uncurry2(method13()), v26, UH0(0)), v1_1, v2_1, v3_1)
            v60 = US10(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v38: int = len(v0_1) or 0
            v41: int = (v0_1.find("\n") - 1) or 0
            v43: int = (v38 if (-2 == v41) else v41) or 0
            v60 = US10(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("`")) + "\' / line: ") + str(v3_1)) + " / col: ") + str(v2_1)) + "\n") + str(v1_1)) + "") + v0_1[0:v43 + 1]) + "")) + "\n") + (replicate(v2_1 - 1, " ") + "^")) + "\n")


    v102: US10
    if v60.tag == 0:
        v65: int = v60.fields[4] or 0
        v64: int = v60.fields[3] or 0
        v63: Any = v60.fields[2]
        v62: str = v60.fields[1]
        if "" == v62:
            v102 = US10(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v63, v64, v65)])))

        else: 
            v69: str = v62[0]
            v71: int = len(v62) or 0
            v76: str = v62[1:v71 + 1]
            v78: str = v69
            v79: int = len(v78) or 0
            v80: Array[str] = fill([0] * v79, 0, v79, "")
            v81: Mut4 = Mut4(0)
            while method12(v79, v81):
                v83: int = v81.l0 or 0
                v84: str = v78[v83]
                v80[v83] = v84
                v85: int = (v83 + 1) or 0
                v81.l0 = v85 or 0
            v87: FSharpList[str] = of_array(v80)
            pattern_input_1: tuple[Any, int, int] = method19(fold_back(uncurry2(method13()), v87, UH0(0)), v63, v64, v65)
            v102 = US10(0, v69, v76, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])


    else: 
        v102 = US10(1, v60.fields[0])

    if v102.tag == 0:
        return US12(0, ((("" + str("`")) + "") + str(v102.fields[0])) + "", v102.fields[1], v102.fields[2], v102.fields[3], v102.fields[4])

    else: 
        return US12(1, v102.fields[0])



def method23(v0_1_mut: str, v1_1_mut: Any, v2_1_mut: int, v3_1_mut: int, v4_1_mut: UH2) -> US12:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        if v4_1.tag == 0:
            return US12(1, "choice / no parsers succeeded")

        else: 
            v9: US12 = v4_1.fields[0]((v0_1, v1_1, v2_1, v3_1))
            if v9.tag == 0:
                return v9

            else: 
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v3_1
                v4_1_mut = v4_1.fields[1]
                continue


        break


def method24(v0_1_mut: UH1, v1_1_mut: UH1) -> UH1:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v0_1.tag == 0:
            return v1_1

        else: 
            v0_1_mut = v0_1.fields[1]
            v1_1_mut = UH1(1, v0_1.fields[0], v1_1)
            continue

        break


def method21(v0_1_mut: UH1, v1_1_mut: str, v2_1_mut: Any, v3_1_mut: int, v4_1_mut: int) -> US9:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v55: US10
        if "" == v1_1:
            v55 = US10(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\""])), (v2_1, v3_1, v4_1)])))

        else: 
            v14: str = v1_1[0]
            v16: int = len(v1_1) or 0
            v21: str = v1_1[1:v16 + 1]
            if method22(v14, int64(0)) == False:
                v26: str = v14
                v27: int = len(v26) or 0
                v28: Array[str] = fill([0] * v27, 0, v27, "")
                v29: Mut4 = Mut4(0)
                while method12(v27, v29):
                    v31: int = v29.l0 or 0
                    v32: str = v26[v31]
                    v28[v31] = v32
                    v33: int = (v31 + 1) or 0
                    v29.l0 = v33 or 0
                v35: FSharpList[str] = of_array(v28)
                pattern_input: tuple[Any, int, int] = method19(fold_back(uncurry2(method13()), v35, UH0(0)), v2_1, v3_1, v4_1)
                v55 = US10(0, v14, v21, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v55 = US10(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v14, to_array(of_array(["\\", "`", "\""])), (v2_1, v3_1, v4_1)])))


        v67: US12 = US12(0, v55.fields[0], v55.fields[1], v55.fields[2], v55.fields[3], v55.fields[4]) if (v55.tag == 0) else US12(1, v55.fields[0])
        def v74(_arg10: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, v4_1: Any=v4_1) -> US12:
            return closure22(None, _arg10)

        def v75(_arg10_1: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, v4_1: Any=v4_1) -> US12:
            return closure23(None, _arg10_1)

        v81: US12 = v67 if (v67.tag == 0) else method23(v1_1, v2_1, v3_1, v4_1, UH2(1, v74, UH2(1, v75, UH2(0))))
        if v81.tag == 0:
            v0_1_mut = UH1(1, v81.fields[0], v0_1)
            v1_1_mut = v81.fields[1]
            v2_1_mut = v81.fields[2]
            v3_1_mut = v81.fields[3]
            v4_1_mut = v81.fields[4]
            continue

        else: 
            return US9(0, method24(v0_1, UH1(0)), v1_1, v2_1, v3_1, v4_1)

        break


def method25(v0_1: UH1, v1_1: FSharpList[str]) -> FSharpList[str]:
    if v0_1.tag == 0:
        return v1_1

    else: 
        return cons(v0_1.fields[0], method25(v0_1.fields[1], v1_1))



def method26(v0_1_mut: UH1, v1_1_mut: str, v2_1_mut: Any, v3_1_mut: int, v4_1_mut: int) -> US9:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v55: US10
        if "" == v1_1:
            v55 = US10(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\""])), (v2_1, v3_1, v4_1)])))

        else: 
            v14: str = v1_1[0]
            v16: int = len(v1_1) or 0
            v21: str = v1_1[1:v16 + 1]
            if method22(v14, int64(0)) == False:
                v26: str = v14
                v27: int = len(v26) or 0
                v28: Array[str] = fill([0] * v27, 0, v27, "")
                v29: Mut4 = Mut4(0)
                while method12(v27, v29):
                    v31: int = v29.l0 or 0
                    v32: str = v26[v31]
                    v28[v31] = v32
                    v33: int = (v31 + 1) or 0
                    v29.l0 = v33 or 0
                v35: FSharpList[str] = of_array(v28)
                pattern_input: tuple[Any, int, int] = method19(fold_back(uncurry2(method13()), v35, UH0(0)), v2_1, v3_1, v4_1)
                v55 = US10(0, v14, v21, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v55 = US10(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v14, to_array(of_array(["\\", "`", "\""])), (v2_1, v3_1, v4_1)])))


        v67: US12 = US12(0, v55.fields[0], v55.fields[1], v55.fields[2], v55.fields[3], v55.fields[4]) if (v55.tag == 0) else US12(1, v55.fields[0])
        if v67.tag == 0:
            v0_1_mut = UH1(1, v67.fields[0], v0_1)
            v1_1_mut = v67.fields[1]
            v2_1_mut = v67.fields[2]
            v3_1_mut = v67.fields[3]
            v4_1_mut = v67.fields[4]
            continue

        else: 
            return US9(0, method24(v0_1, UH1(0)), v1_1, v2_1, v3_1, v4_1)

        break


def method27(v0_1_mut: str, v1_1_mut: int) -> int:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= len(v0_1):
            return v1_1

        elif v0_1[v1_1] == " ":
            v0_1_mut = v0_1
            v1_1_mut = v1_1 + 1
            continue

        else: 
            return v1_1

        break


def method17(v0_1_mut: UH1, v1_1_mut: str, v2_1_mut: Any, v3_1_mut: int, v4_1_mut: int) -> US9:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v5_1: bool = "" == v1_1
        v57: US10
        if v5_1:
            v57 = US10(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3_1, v4_1)])))

        else: 
            v15: str = v1_1[0]
            v17: int = len(v1_1) or 0
            v22: str = v1_1[1:v17 + 1]
            if method18(v15, int64(0)) == False:
                v27: str = v15
                v28: int = len(v27) or 0
                v29: Array[str] = fill([0] * v28, 0, v28, "")
                v30: Mut4 = Mut4(0)
                while method12(v28, v30):
                    v32: int = v30.l0 or 0
                    v33: str = v27[v32]
                    v29[v32] = v33
                    v34: int = (v32 + 1) or 0
                    v30.l0 = v34 or 0
                v36: FSharpList[str] = of_array(v29)
                pattern_input: tuple[Any, int, int] = method19(fold_back(uncurry2(method13()), v36, UH0(0)), v2_1, v3_1, v4_1)
                v57 = US10(0, v15, v22, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v57 = US10(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v15, to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3_1, v4_1)])))


        v69: US12 = method20(v57.fields[0], v57.fields[1], v57.fields[2], v57.fields[3], v57.fields[4]) if (v57.tag == 0) else US12(1, v57.fields[0])
        v292: US12
        if v69.tag == 0:
            v292 = v69

        else: 
            v131: US10
            if v5_1:
                v131 = US10(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v2_1, v3_1, v4_1)])))

            else: 
                v78: str = v1_1[0]
                if v78 == "\"":
                    v81: int = len(v1_1) or 0
                    v86: str = v1_1[1:v81 + 1]
                    v88: str = v78
                    v89: int = len(v88) or 0
                    v90: Array[str] = fill([0] * v89, 0, v89, "")
                    v91: Mut4 = Mut4(0)
                    while method12(v89, v91):
                        v93: int = v91.l0 or 0
                        v94: str = v88[v93]
                        v90[v93] = v94
                        v95: int = (v93 + 1) or 0
                        v91.l0 = v95 or 0
                    v97: FSharpList[str] = of_array(v90)
                    pattern_input_1: tuple[Any, int, int] = method19(fold_back(uncurry2(method13()), v97, UH0(0)), v2_1, v3_1, v4_1)
                    v131 = US10(0, v78, v86, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])

                else: 
                    v109: int = len(v1_1) or 0
                    v112: int = (v1_1.find("\n") - 1) or 0
                    v114: int = (v109 if (-2 == v112) else v112) or 0
                    v131 = US10(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\"")) + "\' / line: ") + str(v4_1)) + " / col: ") + str(v3_1)) + "\n") + str(v2_1)) + "") + v1_1[0:v114 + 1]) + "")) + "\n") + (replicate(v3_1 - 1, " ") + "^")) + "\n")


            v237: US12
            if v131.tag == 0:
                v136: int = v131.fields[4] or 0
                v135: int = v131.fields[3] or 0
                v134: Any = v131.fields[2]
                v133: str = v131.fields[1]
                v138: US9 = method21(UH1(0), v133, v134, v135, v136)
                v155: US12
                if v138.tag == 0:
                    v145: FSharpList[str] = method25(v138.fields[0], empty())
                    def _arrow181(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, v4_1: Any=v4_1) -> IEnumerable_1[str]:
                        def _arrow180(i: int) -> str:
                            return item(i, v145)

                        return map(_arrow180, range_big_int(0, 1, length(v145) - 1))

                    v155 = US12(0, join("", delay(_arrow181)), v138.fields[1], v138.fields[2], v138.fields[3], v138.fields[4])

                else: 
                    v155 = US12(1, v138.fields[0])

                if v155.tag == 0:
                    v160: int = v155.fields[4] or 0
                    v159: int = v155.fields[3] or 0
                    v158: Any = v155.fields[2]
                    v157: str = v155.fields[1]
                    v217: US10
                    if "" == v157:
                        v217 = US10(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v158, v159, v160)])))

                    else: 
                        v164: str = v157[0]
                        if v164 == "\"":
                            v167: int = len(v157) or 0
                            v172: str = v157[1:v167 + 1]
                            v174: str = v164
                            v175: int = len(v174) or 0
                            v176: Array[str] = fill([0] * v175, 0, v175, "")
                            v177: Mut4 = Mut4(0)
                            while method12(v175, v177):
                                v179: int = v177.l0 or 0
                                v180: str = v174[v179]
                                v176[v179] = v180
                                v181: int = (v179 + 1) or 0
                                v177.l0 = v181 or 0
                            v183: FSharpList[str] = of_array(v176)
                            pattern_input_2: tuple[Any, int, int] = method19(fold_back(uncurry2(method13()), v183, UH0(0)), v158, v159, v160)
                            v217 = US10(0, v164, v172, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2])

                        else: 
                            v195: int = len(v157) or 0
                            v198: int = (v157.find("\n") - 1) or 0
                            v200: int = (v195 if (-2 == v198) else v198) or 0
                            v217 = US10(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\"")) + "\' / line: ") + str(v160)) + " / col: ") + str(v159)) + "\n") + str(v158)) + "") + v157[0:v200 + 1]) + "")) + "\n") + (replicate(v159 - 1, " ") + "^")) + "\n")


                    v237 = US12(0, v155.fields[0], v217.fields[1], v217.fields[2], v217.fields[3], v217.fields[4]) if (v217.tag == 0) else US12(1, to_text(interpolate("between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v217.fields[0], (v1_1, v2_1, v3_1, v4_1), (v133, v134, v135, v136), (v157, v158, v159, v160)])))

                else: 
                    v237 = US12(1, "between / expected content")


            else: 
                v237 = US12(1, v131.fields[0])

            if v237.tag == 0:
                v292 = v237

            else: 
                def v244(_arg10: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, v4_1: Any=v4_1) -> US12:
                    return closure22(None, _arg10)

                def v245(_arg10_1: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, v4_1: Any=v4_1) -> US12:
                    return closure23(None, _arg10_1)

                v249: US12 = method23(v1_1, v2_1, v3_1, v4_1, UH2(1, v244, UH2(1, v245, UH2(0))))
                v260: US12 = US12(0, "", v249.fields[1], v249.fields[2], v249.fields[3], v249.fields[4]) if (v249.tag == 0) else US12(1, v249.fields[0])
                v271: US9 = method26(UH1(0), v260.fields[1], v260.fields[2], v260.fields[3], v260.fields[4]) if (v260.tag == 0) else US9(1, v260.fields[0])
                if v271.tag == 0:
                    v278: FSharpList[str] = method25(v271.fields[0], empty())
                    def _arrow183(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, v4_1: Any=v4_1) -> IEnumerable_1[str]:
                        def _arrow182(i_1: int) -> str:
                            return item(i_1, v278)

                        return map(_arrow182, range_big_int(0, 1, length(v278) - 1))

                    v292 = US12(0, join("", delay(_arrow183)), v271.fields[1], v271.fields[2], v271.fields[3], v271.fields[4])

                else: 
                    v292 = US12(1, v271.fields[0])



        if v292.tag == 0:
            v301: int = v292.fields[4] or 0
            v300: int = v292.fields[3] or 0
            v299: Any = v292.fields[2]
            v298: str = v292.fields[1]
            v297: str = v292.fields[0]
            v303: int = method27(v298, 0) or 0
            v315: US13
            if 0 == v303:
                v315 = US13(1, "spaces1 / expected at least one space")

            else: 
                v308: int = len(v298) or 0
                v315 = US13(0, v298[v303:v308 + 1], v299, v300, v301)

            if v315.tag == 0:
                v0_1_mut = UH1(1, v297, v0_1)
                v1_1_mut = v315.fields[0]
                v2_1_mut = v315.fields[1]
                v3_1_mut = v315.fields[2]
                v4_1_mut = v315.fields[3]
                continue

            else: 
                return US9(0, method24(v0_1, UH1(1, v297, UH1(0))), v298, v299, v300, v301)


        else: 
            return US9(0, method24(v0_1, UH1(0)), v1_1, v2_1, v3_1, v4_1)

        break


def method16(v0_1: str) -> US8:
    _v0: (str | None) | None = None
    _v0 = some(v0_1)
    def _arrow184(__unit: None=None, v0_1: Any=v0_1) -> str | None:
        raise Exception("optionm\'.of_obj / _v0=None")

    v11: US9 = method17(UH1(0), default_arg(_arrow184() if (_v0 is None) else value_12(_v0), ""), StringBuilder__ctor_Z721C83C5(""), 1, 1)
    if v11.tag == 0:
        return US8(0, to_array(method25(v11.fields[0], empty())))

    else: 
        return US8(1, v11.fields[0])



def closure21(unit_var: None, v0_1: str) -> FSharpResult_2[Array[str], str]:
    v1_1: US8 = method16(v0_1)
    if v1_1.tag == 0:
        return FSharpResult_2(0, v1_1.fields[0])

    else: 
        return FSharpResult_2(1, v1_1.fields[0])



def _arrow185(v: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, v)


v0: Callable[[US0], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow185

v1: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v0(v1))


def _arrow186(__unit: None=None) -> None:
    closure2(None, None)


v2: Callable[[], None] = _arrow186

def current_process_kill(__unit: None=None) -> None:
    v2(None)


def _arrow187(v: str) -> Async[tuple[int, str]]:
    return closure9(None, v)


v3: Callable[[str], Async[tuple[int, str]]] = _arrow187

def execute_async(x: str) -> Async[tuple[int, str]]:
    return v3(x)


def _arrow188(_arg10: tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return closure19(None, _arg10)


v4: Callable[[tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]], Async[tuple[int, str]]] = _arrow188

def execute_with_options_async(x: tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return v4(x)


def _arrow189(v: Callable[[Heap0], Heap0]) -> tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]:
    return closure20(None, v)


v5: Callable[[Callable[[Heap0], Heap0]], tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]] = _arrow189

def execution_options(x: Callable[[Heap0], Heap0]) -> tuple[CancellationToken | None, str, Array[tuple[str, str]], Callable[[tuple[bool, str, int]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]:
    return v5(x)


def _arrow190(v: str) -> FSharpResult_2[Array[str], str]:
    return closure21(None, v)


v6: Callable[[str], FSharpResult_2[Array[str], str]] = _arrow190

def split_args(x: str) -> FSharpResult_2[Array[str], str]:
    return v6(x)


