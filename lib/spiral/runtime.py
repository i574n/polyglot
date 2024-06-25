from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.array_ import fill
from fable_modules.fable_library.async_builder import (Async, CancellationToken)
from fable_modules.fable_library.date import (ticks as ticks_1, now, to_string, create as create_1)
from fable_modules.fable_library.list import (to_array, empty, of_array, FSharpList, fold_back, cons, item, length)
from fable_modules.fable_library.long import (op_subtraction, op_addition)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_12, default_arg)
from fable_modules.fable_library.range import range_big_int
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type, char_type, class_type, int32_type, tuple_type, option_type, array_type)
from fable_modules.fable_library.result import FSharpResult_2
from fable_modules.fable_library.seq import (delay, map)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, to_text, interpolate, replicate, join)
from fable_modules.fable_library.system_text import (StringBuilder__Clear, StringBuilder__Append_Z721C83C5, StringBuilder__ctor_Z721C83C5)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare, uncurry2, IEnumerable_1)

State_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr156() -> TypeInfo:
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


US0_reflection = _expr156

def _expr157() -> TypeInfo:
    return record_type("Runtime.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr157

def _expr158() -> TypeInfo:
    return record_type("Runtime.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr158

def _expr159() -> TypeInfo:
    return record_type("Runtime.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr159

def _expr160() -> TypeInfo:
    return record_type("Runtime.Mut3", [], Mut3, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: US0

Mut3_reflection = _expr160

def _expr161() -> TypeInfo:
    return union_type("Runtime.US1", [], US1, lambda: [[("f0_0", US0_reflection())], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr161

def _expr162() -> TypeInfo:
    return union_type("Runtime.US2", [], US2, lambda: [[("f0_0", int64_type)], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr162

def _expr163() -> TypeInfo:
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


US3_reflection = _expr163

def _expr164() -> TypeInfo:
    return record_type("Runtime.Mut4", [], Mut4, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: str

Mut4_reflection = _expr164

def _expr165() -> TypeInfo:
    return union_type("Runtime.US4", [], US4, lambda: [[("f0_0", string_type), ("f0_1", US3_reflection())], [("f1_0", string_type)]])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1"]


US4_reflection = _expr165

def _expr166() -> TypeInfo:
    return union_type("Runtime.US5", [], US5, lambda: [[("f0_0", char_type), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr166

def _expr167() -> TypeInfo:
    return record_type("Runtime.Mut5", [], Mut5, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut5(Record):
    l0: int

Mut5_reflection = _expr167

def _expr168() -> TypeInfo:
    return union_type("Runtime.UH0", [], UH0, lambda: [[], [("Item1", char_type), ("Item2", UH0_reflection())]])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr168

def _expr169() -> TypeInfo:
    return union_type("Runtime.UH1", [], UH1, lambda: [[], [("Item1", lambda_type(tuple_type(string_type, class_type("System.Text.StringBuilder"), int32_type, int32_type), US5_reflection())), ("Item2", UH1_reflection())]])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr169

def _expr170() -> TypeInfo:
    return union_type("Runtime.US6", [], US6, lambda: [[("f0_0", string_type), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1"]


US6_reflection = _expr170

def _expr171() -> TypeInfo:
    return union_type("Runtime.US7", [], US7, lambda: [[("f0_0", char_type)], []])


class US7(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US7_0", "US7_1"]


US7_reflection = _expr171

def _expr172() -> TypeInfo:
    return union_type("Runtime.US8", [], US8, lambda: [[("f0_0", string_type), ("f0_1", class_type("System.Text.StringBuilder")), ("f0_2", int32_type), ("f0_3", int32_type)], [("f1_0", string_type)]])


class US8(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US8_0", "US8_1"]


US8_reflection = _expr172

def _expr173() -> TypeInfo:
    return union_type("Runtime.US9", [], US9, lambda: [[("f0_0", string_type), ("f0_1", US3_reflection()), ("f0_2", string_type), ("f0_3", class_type("System.Text.StringBuilder")), ("f0_4", int32_type), ("f0_5", int32_type)], [("f1_0", string_type)]])


class US9(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US9_0", "US9_1"]


US9_reflection = _expr173

def _expr174() -> TypeInfo:
    return union_type("Runtime.US10", [], US10, lambda: [[("f0_0", US7_reflection()), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US10(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US10_0", "US10_1"]


US10_reflection = _expr174

def _expr175() -> TypeInfo:
    return union_type("Runtime.US11", [], US11, lambda: [[("f0_0", US3_reflection()), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US11(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US11_0", "US11_1"]


US11_reflection = _expr175

def _expr176() -> TypeInfo:
    return union_type("Runtime.US12", [], US12, lambda: [[("f0_0", lambda_type(tuple_type(int32_type, string_type, bool_type), class_type("Microsoft.FSharp.Control.FSharpAsync`1", [unit_type])))], []])


class US12(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US12_0", "US12_1"]


US12_reflection = _expr176

def _expr177() -> TypeInfo:
    return union_type("Runtime.US13", [], US13, lambda: [[("f0_0", class_type("System.Threading.CancellationToken"))], []])


class US13(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US13_0", "US13_1"]


US13_reflection = _expr177

def _expr178() -> TypeInfo:
    return record_type("Runtime.Heap0", [], Heap0, lambda: [("l0", string_type), ("l1", option_type(class_type("System.Threading.CancellationToken"))), ("l2", array_type(tuple_type(string_type, string_type))), ("l3", option_type(lambda_type(tuple_type(int32_type, string_type, bool_type), class_type("Microsoft.FSharp.Control.FSharpAsync`1", [unit_type])))), ("l4", option_type(lambda_type(class_type("Runtime.std_sync_Arc`1", [class_type("Runtime.std_sync_Mutex`1", [class_type("Runtime.std_process_ChildStdin")])]), unit_type))), ("l5", bool_type), ("l6", option_type(string_type))])


@dataclass(eq = False, repr = False, slots = True)
class Heap0(Record):
    l0: str
    l1: CancellationToken | None
    l2: Array[tuple[str, str]]
    l3: Callable[[tuple[int, str, bool]], Async[None]] | None
    l4: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None
    l5: bool
    l6: str | None

Heap0_reflection = _expr178

def _expr179() -> TypeInfo:
    return union_type("Runtime.US14", [], US14, lambda: [[("f0_0", array_type(string_type))], [("f1_0", string_type)]])


class US14(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US14_0", "US14_1"]


US14_reflection = _expr179

def _expr180() -> TypeInfo:
    return union_type("Runtime.UH2", [], UH2, lambda: [[], [("Item1", string_type), ("Item2", UH2_reflection())]])


class UH2(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH2_0", "UH2_1"]


UH2_reflection = _expr180

def _expr181() -> TypeInfo:
    return union_type("Runtime.US15", [], US15, lambda: [[("f0_0", UH2_reflection()), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US15(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US15_0", "US15_1"]


US15_reflection = _expr181

def _expr182() -> TypeInfo:
    return union_type("Runtime.UH3", [], UH3, lambda: [[], [("Item1", lambda_type(tuple_type(string_type, class_type("System.Text.StringBuilder"), int32_type, int32_type), US6_reflection())), ("Item2", UH3_reflection())]])


class UH3(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH3_0", "UH3_1"]


UH3_reflection = _expr182

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



def US14__get_IsUS14_0(this: FSharpRef[US14], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US14__get_IsUS14_1(this: FSharpRef[US14], unit_arg: None) -> bool:
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



def US15__get_IsUS15_0(this: FSharpRef[US15], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US15__get_IsUS15_1(this: FSharpRef[US15], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def UH3__get_IsUH3_0(this: UH3, unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def UH3__get_IsUH3_1(this: UH3, unit_arg: None) -> bool:
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
    _v54: (str | None) | None = None
    x: str | None = v52.get(v0_1)
    _v54 = some(x)
    v57: str | None
    if _v54 is None:
        raise Exception("optionm\'.of_obj / _v54=None")

    else: 
        v57 = value_12(_v54)

    _v58: FSharpRef[US3 | None] = FSharpRef(None)
    x_4: US3 | None
    if v57 is None:
        x_4 = None

    else: 
        x_2: str = v57
        def x_3(__unit: None=None, v0_1: Any=v0_1) -> US3:
            return US3(0, x_2)

        x_4 = x_3(None)

    _v58.contents = x_4
    v63: US3 = default_arg(_v58.contents, US3(1))
    x_5: str = v63.fields[0] if (v63.tag == 0) else ""
    _v1 = x_5
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method3(__unit: None=None) -> str:
    return "AUTOMATION"


def closure1(unit_var: None, v0_1: str) -> None:
    pass


def closure0(unit_var: None, v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
    _v1: tuple[US1, US2] | None = None
    v133: str = method1(method0())
    v139: US1 = US1(0, US0(0)) if ("Verbose" == v133) else US1(1)
    def _arrow183(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> US1:
        v147: US1 = US1(0, US0(1)) if ("Debug" == v133) else US1(1)
        if v147.tag == 0:
            return US1(0, v147.fields[0])

        else: 
            v155: US1 = US1(0, US0(2)) if ("Info" == v133) else US1(1)
            if v155.tag == 0:
                return US1(0, v155.fields[0])

            else: 
                v163: US1 = US1(0, US0(3)) if ("Warning" == v133) else US1(1)
                if v163.tag == 0:
                    return US1(0, v163.fields[0])

                else: 
                    v171: US1 = US1(0, US0(4)) if ("Critical" == v133) else US1(1)
                    return US1(0, v171.fields[0]) if (v171.tag == 0) else US1(1)




    x: tuple[US1, US2] = (US1(0, v139.fields[0]) if (v139.tag == 0) else _arrow183(), US2(0, ticks_1(now())) if (method1(method3()) == "True") else US2(1))
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

    return (Mut0(int64(0)), Mut1(v266), Mut2(True), Mut3(v258.fields[0] if (v258.tag == 0) else v0_1), v259.fields[0] if (v259.tag == 0) else None)


def closure4(unit_var: None, unit_var_1: None) -> str:
    return "runtime.current_process_kill / exiting... 3"


def closure5(unit_var: None, unit_var_1: None) -> None:
    pass


def method5(__unit: None=None) -> str:
    return "hh:mm:ss"


def method6(__unit: None=None) -> str:
    return ""


def method7(__unit: None=None) -> str:
    return "HH:mm:ss"


def method8(__unit: None=None) -> str:
    return "\u001b[0m"


def method9(v0_1: Mut4) -> None:
    pass


def closure6(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], None], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_12(State_trace_state())
    v9: int64 | None = pattern_input[4]
    _v10: str | None = None
    _v96: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v9 is None:
        x_2 = None

    else: 
        x: int64 = v9
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US2 = default_arg(_v96.contents, US2(1))
    def _arrow184(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow184() if (v101.tag == 0) else now(), method7())
    _v10 = x_3
    v152: str
    if _v10 is None:
        raise Exception("base.run_target / _v10=None")

    else: 
        v152 = _v10

    v159: US3 = US3(0, "Verbose") if (True if (v0_1.tag == 0) else False) else US3(1)
    v208: US3
    if v159.tag == 0:
        v208 = US3(0, v159.fields[0])

    else: 
        v168: US3 = US3(0, "Debug") if (True if (v0_1.tag == 1) else False) else US3(1)
        if v168.tag == 0:
            v208 = US3(0, v168.fields[0])

        else: 
            v177: US3 = US3(0, "Info") if (True if (v0_1.tag == 2) else False) else US3(1)
            if v177.tag == 0:
                v208 = US3(0, v177.fields[0])

            else: 
                v186: US3 = US3(0, "Warning") if (True if (v0_1.tag == 3) else False) else US3(1)
                if v186.tag == 0:
                    v208 = US3(0, v186.fields[0])

                else: 
                    v195: US3 = US3(0, "Critical") if (True if (v0_1.tag == 4) else False) else US3(1)
                    v208 = US3(0, v195.fields[0]) if (v195.tag == 0) else US3(1)




    v212: str
    if v208.tag == 0:
        v212 = v208.fields[0]

    else: 
        raise Exception("Option does not have a value.")

    v215: str = pad_left(v212.lower(), 7, " ")
    _v216: str | None = None
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method8()
    _v216 = x_5
    v328: str
    if _v216 is None:
        raise Exception("base.run_target / _v216=None")

    else: 
        v328 = _v216

    v329: int64 = pattern_input[0].l0
    v2_1(None)
    v331: Mut4 = Mut4("")
    method9(v331)
    v332: str = v331.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v332) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method10(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(v: US0, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
        return closure0(None, v)

    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_12(State_trace_state())
    v4_1: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_12(State_trace_state())
    v15: US0 = pattern_input_1[3].l0
    class ObjectExpr185:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr186:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr185())) >= find(v15, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr186()))):
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

        pattern_input[1].l0(v24)



def method4(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], None]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure6(v0_1, v1_1, v2_1, None)

    method10(v0_1, v3_1)


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



def method13(v0_1: int, v1_1: Mut5) -> bool:
    return v1_1.l0 < v0_1


def closure12(v0_1: str, v1_1: UH0) -> UH0:
    return UH0(1, v0_1, v1_1)


def closure11(unit_var: None, v0_1: str) -> Callable[[UH0], UH0]:
    def _arrow187(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure12(v0_1, v)

    return _arrow187


def method14(__unit: None=None) -> Callable[[str, UH0], UH0]:
    def _arrow188(v: str) -> Callable[[UH0], UH0]:
        return closure11(None, v)

    return _arrow188


def method15(v0_1_mut: UH0, v1_1_mut: Any, v2_1_mut: int, v3_1_mut: int) -> tuple[Any, int, int]:
    while True:
        (v0_1, v1_1, v2_1, v3_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut)
        if v0_1.tag == 0:
            return (v1_1, v2_1, v3_1)

        else: 
            v4_1: str = v0_1.fields[0]
            v6_1: bool = "\n" == v4_1
            pattern_input: tuple[int, int] = ((v2_1 + 1, 1)) if v6_1 else ((v2_1, v3_1 + 1))
            v0_1_mut = v0_1.fields[1]
            def _arrow189(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1) -> Any:
                v12: Any = StringBuilder__Clear(v1_1)
                return v1_1

            def _arrow190(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1) -> Any:
                v16: Any = StringBuilder__Append_Z721C83C5(v1_1, v4_1)
                return v1_1

            v1_1_mut = _arrow189() if v6_1 else _arrow190()
            v2_1_mut = pattern_input[0]
            v3_1_mut = pattern_input[1]
            continue

        break


def closure10(unit_var: None, _arg: tuple[str, Any, int, int]) -> US5:
    v3_1: int = _arg[3] or 0
    v2_1: int = _arg[2] or 0
    v1_1: Any = _arg[1]
    v0_1: str = _arg[0]
    if "" == v0_1:
        return US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v1_1, v2_1, v3_1)])))

    else: 
        v7: str = v0_1[0]
        if v7 == "\"":
            v10: int = len(v0_1) or 0
            v15: str = v0_1[1:v10 + 1]
            v17: str = v7
            v18: int = len(v17) or 0
            v19: Array[str] = fill([0] * v18, 0, v18, "")
            v20: Mut5 = Mut5(0)
            while method13(v18, v20):
                v22: int = v20.l0 or 0
                v23: str = v17[v22]
                v19[v22] = v23
                v24: int = (v22 + 1) or 0
                v20.l0 = v24 or 0
            v26: FSharpList[str] = of_array(v19)
            pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v26, UH0(0)), v1_1, v2_1, v3_1)
            return US5(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v38: int = len(v0_1) or 0
            v41: int = (v0_1.find("\n") - 1) or 0
            v43: int = (v38 if (-2 == v41) else v41) or 0
            return US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\"")) + "\' / line: ") + str(v2_1)) + " / col: ") + str(v3_1)) + "\n") + str(v1_1)) + "") + v0_1[0:v43 + 1]) + "")) + "\n") + (replicate(v3_1 - 1, " ") + "^")) + "\n")




def closure13(unit_var: None, _arg: tuple[str, Any, int, int]) -> US5:
    v3_1: int = _arg[3] or 0
    v2_1: int = _arg[2] or 0
    v1_1: Any = _arg[1]
    v0_1: str = _arg[0]
    if "" == v0_1:
        return US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v1_1, v2_1, v3_1)])))

    else: 
        v7: str = v0_1[0]
        if v7 == "\'":
            v10: int = len(v0_1) or 0
            v15: str = v0_1[1:v10 + 1]
            v17: str = v7
            v18: int = len(v17) or 0
            v19: Array[str] = fill([0] * v18, 0, v18, "")
            v20: Mut5 = Mut5(0)
            while method13(v18, v20):
                v22: int = v20.l0 or 0
                v23: str = v17[v22]
                v19[v22] = v23
                v24: int = (v22 + 1) or 0
                v20.l0 = v24 or 0
            v26: FSharpList[str] = of_array(v19)
            pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v26, UH0(0)), v1_1, v2_1, v3_1)
            return US5(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v38: int = len(v0_1) or 0
            v41: int = (v0_1.find("\n") - 1) or 0
            v43: int = (v38 if (-2 == v41) else v41) or 0
            return US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\'")) + "\' / line: ") + str(v2_1)) + " / col: ") + str(v3_1)) + "\n") + str(v1_1)) + "") + v0_1[0:v43 + 1]) + "")) + "\n") + (replicate(v3_1 - 1, " ") + "^")) + "\n")




def method16(v0_1_mut: str, v1_1_mut: Any, v2_1_mut: UH1) -> US5:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if v2_1.tag == 0:
            return US5(1, "choice / no parsers succeeded")

        else: 
            v7: US5 = v2_1.fields[0]((v0_1, v1_1, 1, 1))
            if v7.tag == 0:
                return v7

            else: 
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1.fields[1]
                continue


        break


def method17(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(2):
            return False

        else: 
            v11: US7
            if v1_1 == int64(0):
                v11 = US7(0, "\"")

            else: 
                v5_1: int64 = op_subtraction(v1_1, int64(1))
                if v5_1 == int64(0):
                    v11 = US7(0, "\'")

                else: 
                    v8: int64 = op_subtraction(v5_1, int64(1))
                    v11 = US7(1)


            def _arrow191(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v11.fields[0] if (v11.tag == 0) else _arrow191()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def method18(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_1_mut: int, v4_1_mut: int) -> US6:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v53: US5
        if "" == v1_1:
            v53 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'"])), (v2_1, v3_1, v4_1)])))

        else: 
            v13: str = v1_1[0]
            v15: int = len(v1_1) or 0
            v20: str = v1_1[1:v15 + 1]
            if method17(v13, int64(0)) == False:
                v25: str = v13
                v26: int = len(v25) or 0
                v27: Array[str] = fill([0] * v26, 0, v26, "")
                v28: Mut5 = Mut5(0)
                while method13(v26, v28):
                    v30: int = v28.l0 or 0
                    v31: str = v25[v30]
                    v27[v30] = v31
                    v32: int = (v30 + 1) or 0
                    v28.l0 = v32 or 0
                v34: FSharpList[str] = of_array(v27)
                pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v34, UH0(0)), v2_1, v3_1, v4_1)
                v53 = US5(0, v13, v20, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v53 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v13, to_array(of_array(["\"", "\'"])), (v2_1, v3_1, v4_1)])))


        v65: US5
        if v53.tag == 0:
            v54: str = v53.fields[0]
            v65 = US5(0, "/" if ("\\" == v54) else v54, v53.fields[1], v53.fields[2], v53.fields[3], v53.fields[4])

        else: 
            v65 = US5(1, v53.fields[0])

        if v65.tag == 0:
            v0_1_mut = v0_1 + v65.fields[0]
            v1_1_mut = v65.fields[1]
            v2_1_mut = v65.fields[2]
            v3_1_mut = v65.fields[3]
            v4_1_mut = v65.fields[4]
            continue

        else: 
            return US6(0, v0_1, v1_1, v2_1, v3_1, v4_1)

        break


def method19(v0_1_mut: str, v1_1_mut: Any, v2_1_mut: int, v3_1_mut: int, v4_1_mut: UH1) -> US5:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        if v4_1.tag == 0:
            return US5(1, "choice / no parsers succeeded")

        else: 
            v9: US5 = v4_1.fields[0]((v0_1, v1_1, v2_1, v3_1))
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


def method20(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(3):
            return False

        else: 
            v15: US7
            if v1_1 == int64(0):
                v15 = US7(0, "\"")

            else: 
                v5_1: int64 = op_subtraction(v1_1, int64(1))
                if v5_1 == int64(0):
                    v15 = US7(0, "\'")

                else: 
                    v8: int64 = op_subtraction(v5_1, int64(1))
                    if v8 == int64(0):
                        v15 = US7(0, " ")

                    else: 
                        v11: int64 = op_subtraction(v8, int64(1))
                        v15 = US7(1)



            def _arrow192(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v15.fields[0] if (v15.tag == 0) else _arrow192()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def method21(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_1_mut: int, v4_1_mut: int) -> US6:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v55: US5
        if "" == v1_1:
            v55 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'", " "])), (v2_1, v3_1, v4_1)])))

        else: 
            v14: str = v1_1[0]
            v16: int = len(v1_1) or 0
            v21: str = v1_1[1:v16 + 1]
            if method20(v14, int64(0)) == False:
                v26: str = v14
                v27: int = len(v26) or 0
                v28: Array[str] = fill([0] * v27, 0, v27, "")
                v29: Mut5 = Mut5(0)
                while method13(v27, v29):
                    v31: int = v29.l0 or 0
                    v32: str = v26[v31]
                    v28[v31] = v32
                    v33: int = (v31 + 1) or 0
                    v29.l0 = v33 or 0
                v35: FSharpList[str] = of_array(v28)
                pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v35, UH0(0)), v2_1, v3_1, v4_1)
                v55 = US5(0, v14, v21, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v55 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v14, to_array(of_array(["\"", "\'", " "])), (v2_1, v3_1, v4_1)])))


        v67: US5
        if v55.tag == 0:
            v56: str = v55.fields[0]
            v67 = US5(0, "/" if ("\\" == v56) else v56, v55.fields[1], v55.fields[2], v55.fields[3], v55.fields[4])

        else: 
            v67 = US5(1, v55.fields[0])

        if v67.tag == 0:
            v0_1_mut = v0_1 + v67.fields[0]
            v1_1_mut = v67.fields[1]
            v2_1_mut = v67.fields[2]
            v3_1_mut = v67.fields[3]
            v4_1_mut = v67.fields[4]
            continue

        else: 
            return US6(0, v0_1, v1_1, v2_1, v3_1, v4_1)

        break


def method22(v0_1_mut: str, v1_1_mut: int) -> int:
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


def method23(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_1_mut: int, v4_1_mut: int) -> US6:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v37: US5
        if "" == v1_1:
            v37 = US5(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v2_1, v3_1, v4_1)])))

        else: 
            v8: str = v1_1[0]
            v10: int = len(v1_1) or 0
            v15: str = v1_1[1:v10 + 1]
            v17: str = v8
            v18: int = len(v17) or 0
            v19: Array[str] = fill([0] * v18, 0, v18, "")
            v20: Mut5 = Mut5(0)
            while method13(v18, v20):
                v22: int = v20.l0 or 0
                v23: str = v17[v22]
                v19[v22] = v23
                v24: int = (v22 + 1) or 0
                v20.l0 = v24 or 0
            v26: FSharpList[str] = of_array(v19)
            pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v26, UH0(0)), v2_1, v3_1, v4_1)
            v37 = US5(0, v8, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        if v37.tag == 0:
            v0_1_mut = v0_1 + v37.fields[0]
            v1_1_mut = v37.fields[1]
            v2_1_mut = v37.fields[2]
            v3_1_mut = v37.fields[3]
            v4_1_mut = v37.fields[4]
            continue

        else: 
            return US6(0, v0_1, v1_1, v2_1, v3_1, v4_1)

        break


def method12(v0_1: str) -> US4:
    _v0: (str | None) | None = None
    _v0 = some(v0_1)
    def _arrow193(__unit: None=None, v0_1: Any=v0_1) -> str | None:
        raise Exception("optionm\'.of_obj / _v0=None")

    v5_1: str = default_arg(_arrow193() if (_v0 is None) else value_12(_v0), "")
    v7: Any = StringBuilder__ctor_Z721C83C5("")
    def v8(_arg10: tuple[str, Any, int, int], v0_1: Any=v0_1) -> US5:
        return closure10(None, _arg10)

    def v9(_arg10_1: tuple[str, Any, int, int], v0_1: Any=v0_1) -> US5:
        return closure13(None, _arg10_1)

    v13: US5 = method16(v5_1, v7, UH1(1, v8, UH1(1, v9, UH1(0))))
    v130: US6
    if v13.tag == 0:
        v18: int = v13.fields[4] or 0
        v17: int = v13.fields[3] or 0
        v16: Any = v13.fields[2]
        v15: str = v13.fields[1]
        v67: US5
        if "" == v15:
            v67 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'"])), (v16, v17, v18)])))

        else: 
            v27: str = v15[0]
            v29: int = len(v15) or 0
            v34: str = v15[1:v29 + 1]
            if method17(v27, int64(0)) == False:
                v39: str = v27
                v40: int = len(v39) or 0
                v41: Array[str] = fill([0] * v40, 0, v40, "")
                v42: Mut5 = Mut5(0)
                while method13(v40, v42):
                    v44: int = v42.l0 or 0
                    v45: str = v39[v44]
                    v41[v44] = v45
                    v46: int = (v44 + 1) or 0
                    v42.l0 = v46 or 0
                v48: FSharpList[str] = of_array(v41)
                pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v48, UH0(0)), v16, v17, v18)
                v67 = US5(0, v27, v34, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v67 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v27, to_array(of_array(["\"", "\'"])), (v16, v17, v18)])))


        v79: US5
        if v67.tag == 0:
            v68: str = v67.fields[0]
            v79 = US5(0, "/" if ("\\" == v68) else v68, v67.fields[1], v67.fields[2], v67.fields[3], v67.fields[4])

        else: 
            v79 = US5(1, v67.fields[0])

        v91: US6 = method18(v79.fields[0], v79.fields[1], v79.fields[2], v79.fields[3], v79.fields[4]) if (v79.tag == 0) else US6(1, v79.fields[0])
        v101: US6 = US6(0, v91.fields[0], v91.fields[1], v91.fields[2], v91.fields[3], v91.fields[4]) if (v91.tag == 0) else US6(0, "", v15, v16, v17, v18)
        if v101.tag == 0:
            v106: int = v101.fields[4] or 0
            v105: int = v101.fields[3] or 0
            v104: Any = v101.fields[2]
            v103: str = v101.fields[1]
            v110: US5 = method19(v103, v104, v105, v106, UH1(1, v8, UH1(1, v9, UH1(0))))
            v130 = US6(0, v101.fields[0], v110.fields[1], v110.fields[2], v110.fields[3], v110.fields[4]) if (v110.tag == 0) else US6(1, to_text(interpolate("between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v110.fields[0], (v5_1, v7, 1, 1), (v15, v16, v17, v18), (v103, v104, v105, v106)])))

        else: 
            v130 = US6(1, "between / expected content")


    else: 
        v130 = US6(1, v13.fields[0])

    v257: US6
    if v130.tag == 0:
        v257 = v130

    else: 
        v189: US5
        if "" == v5_1:
            v189 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'", " "])), (v7, 1, 1)])))

        else: 
            v146: str = v5_1[0]
            v148: int = len(v5_1) or 0
            v153: str = v5_1[1:v148 + 1]
            if method20(v146, int64(0)) == False:
                v158: str = v146
                v159: int = len(v158) or 0
                v160: Array[str] = fill([0] * v159, 0, v159, "")
                v161: Mut5 = Mut5(0)
                while method13(v159, v161):
                    v163: int = v161.l0 or 0
                    v164: str = v158[v163]
                    v160[v163] = v164
                    v165: int = (v163 + 1) or 0
                    v161.l0 = v165 or 0
                v167: FSharpList[str] = of_array(v160)
                pattern_input_1: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v167, UH0(0)), v7, 1, 1)
                v189 = US5(0, v146, v153, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])

            else: 
                v189 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v146, to_array(of_array(["\"", "\'", " "])), (v7, 1, 1)])))


        v201: US5
        if v189.tag == 0:
            v190: str = v189.fields[0]
            v201 = US5(0, "/" if ("\\" == v190) else v190, v189.fields[1], v189.fields[2], v189.fields[3], v189.fields[4])

        else: 
            v201 = US5(1, v189.fields[0])

        v213: US6 = method21(v201.fields[0], v201.fields[1], v201.fields[2], v201.fields[3], v201.fields[4]) if (v201.tag == 0) else US6(1, v201.fields[0])
        if v213.tag == 0:
            v257 = v213

        else: 
            v225: US8 = US8(0, v5_1, v7, 1, 1) if (len(v5_1) == 0) else US8(1, to_text(interpolate("parsing.eof / expected end of input / input: %A%P()", [v5_1])))
            v234: US6 = US6(0, "", v225.fields[0], v225.fields[1], v225.fields[2], v225.fields[3]) if (v225.tag == 0) else US6(1, v225.fields[0])
            if v234.tag == 0:
                v236: str = v234.fields[1]
                v241: int = method22(v236, 0) or 0
                v243: int = len(v236) or 0
                v257 = US6(0, v234.fields[0], v236[v241:v243 + 1], v234.fields[2], v234.fields[3], v234.fields[4])

            else: 
                v257 = US6(1, v234.fields[0])



    v411: US9
    if v257.tag == 0:
        v262: int = v257.fields[4] or 0
        v261: int = v257.fields[3] or 0
        v260: Any = v257.fields[2]
        v259: str = v257.fields[1]
        v319: US5
        if "" == v259:
            v319 = US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v260, v261, v262)])))

        else: 
            v266: str = v259[0]
            if v266 == " ":
                v269: int = len(v259) or 0
                v274: str = v259[1:v269 + 1]
                v276: str = v266
                v277: int = len(v276) or 0
                v278: Array[str] = fill([0] * v277, 0, v277, "")
                v279: Mut5 = Mut5(0)
                while method13(v277, v279):
                    v281: int = v279.l0 or 0
                    v282: str = v276[v281]
                    v278[v281] = v282
                    v283: int = (v281 + 1) or 0
                    v279.l0 = v283 or 0
                v285: FSharpList[str] = of_array(v278)
                pattern_input_2: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v285, UH0(0)), v260, v261, v262)
                v319 = US5(0, v266, v274, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2])

            else: 
                v297: int = len(v259) or 0
                v300: int = (v259.find("\n") - 1) or 0
                v302: int = (v297 if (-2 == v300) else v300) or 0
                v319 = US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str(" ")) + "\' / line: ") + str(v261)) + " / col: ") + str(v262)) + "\n") + str(v260)) + "") + v259[0:v302 + 1]) + "")) + "\n") + (replicate(v262 - 1, " ") + "^")) + "\n")


        v331: US10 = US10(0, US7(0, v319.fields[0]), v319.fields[1], v319.fields[2], v319.fields[3], v319.fields[4]) if (v319.tag == 0) else US10(0, US7(1), v259, v260, v261, v262)
        v385: US6
        if v331.tag == 0:
            v336: int = v331.fields[4] or 0
            v335: int = v331.fields[3] or 0
            v334: Any = v331.fields[2]
            v333: str = v331.fields[1]
            v369: US5
            if "" == v333:
                v369 = US5(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v334, v335, v336)])))

            else: 
                v340: str = v333[0]
                v342: int = len(v333) or 0
                v347: str = v333[1:v342 + 1]
                v349: str = v340
                v350: int = len(v349) or 0
                v351: Array[str] = fill([0] * v350, 0, v350, "")
                v352: Mut5 = Mut5(0)
                while method13(v350, v352):
                    v354: int = v352.l0 or 0
                    v355: str = v349[v354]
                    v351[v354] = v355
                    v356: int = (v354 + 1) or 0
                    v352.l0 = v356 or 0
                v358: FSharpList[str] = of_array(v351)
                pattern_input_3: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v358, UH0(0)), v334, v335, v336)
                v369 = US5(0, v340, v347, pattern_input_3[0], pattern_input_3[1], pattern_input_3[2])

            v385 = method23(v369.fields[0], v369.fields[1], v369.fields[2], v369.fields[3], v369.fields[4]) if (v369.tag == 0) else US6(1, v369.fields[0])

        else: 
            v385 = US6(1, v331.fields[0])

        v397: US11 = US11(0, US3(0, v385.fields[0]), v385.fields[1], v385.fields[2], v385.fields[3], v385.fields[4]) if (v385.tag == 0) else US11(0, US3(1), v259, v260, v261, v262)
        v411 = US9(0, v257.fields[0], v397.fields[0], v397.fields[1], v397.fields[2], v397.fields[3], v397.fields[4]) if (v397.tag == 0) else US9(1, v397.fields[0])

    else: 
        v411 = US9(1, v257.fields[0])

    if v411.tag == 0:
        return US4(0, v411.fields[0], v411.fields[1])

    else: 
        return US4(1, v411.fields[0])



def closure14(unit_var: None, unit_var_1: None) -> str:
    return "runtime.execute_with_options_async"


def closure15(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3_1: Callable[[tuple[int, str, bool]], Async[None]] | None, v4_1: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, v5_1: bool, v6_1: str | None, unit_var: None) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]:
    return (v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1)


def method26(v0_1: Mut4, v1_1: str) -> None:
    v4_1: str = v0_1.l0 + (("" + v1_1) + "")
    v0_1.l0 = v4_1


def method28(v0_1: Mut4, v1_1: CancellationToken | None=None) -> None:
    method26(v0_1, to_text(interpolate("%A%P()", [v1_1])))


def method29(v0_1: Mut4, v1_1: Array[tuple[str, str]]) -> None:
    method26(v0_1, to_text(interpolate("%A%P()", [v1_1])))


def method30(v0_1: Mut4, v1_1: Callable[[tuple[int, str, bool]], Async[None]] | None=None) -> None:
    method26(v0_1, to_text(interpolate("%A%P()", [v1_1])))


def method31(v0_1: Mut4, v1_1: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None=None) -> None:
    method26(v0_1, to_text(interpolate("%A%P()", [v1_1])))


def method32(v0_1: Mut4, v1_1: bool) -> None:
    v4_1: str = "true" if v1_1 else "false"
    v7: str = v0_1.l0 + (("" + v4_1) + "")
    v0_1.l0 = v7


def method33(v0_1: Mut4, v1_1: str | None=None) -> None:
    method26(v0_1, to_text(interpolate("%A%P()", [v1_1])))


def method27(v0_1: Mut4, v1_1: str, v2_1: CancellationToken | None, v3_1: Array[tuple[str, str]], v4_1: Callable[[tuple[int, str, bool]], Async[None]] | None, v5_1: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, v6_1: bool, v7: str | None=None) -> None:
    method26(v0_1, "{ ")
    method9(v0_1)
    method26(v0_1, "command")
    method26(v0_1, " = ")
    method26(v0_1, v1_1)
    method26(v0_1, "; ")
    method26(v0_1, "cancellation_token")
    method26(v0_1, " = ")
    method28(v0_1, v2_1)
    method26(v0_1, "; ")
    method26(v0_1, "environment_variables")
    method26(v0_1, " = ")
    method29(v0_1, v3_1)
    method26(v0_1, "; ")
    method26(v0_1, "on_line")
    method26(v0_1, " = ")
    method30(v0_1, v4_1)
    method26(v0_1, "; ")
    method26(v0_1, "stdin")
    method26(v0_1, " = ")
    method31(v0_1, v5_1)
    method26(v0_1, "; ")
    method26(v0_1, "trace")
    method26(v0_1, " = ")
    method32(v0_1, v6_1)
    method26(v0_1, "; ")
    method26(v0_1, "working_directory")
    method26(v0_1, " = ")
    method33(v0_1, v7)
    method26(v0_1, " }")


def method25(v0_1: Mut4, v1_1: str, v2_1: CancellationToken | None, v3_1: Array[tuple[str, str]], v4_1: Callable[[tuple[int, str, bool]], Async[None]] | None, v5_1: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, v6_1: bool, v7: str | None=None) -> None:
    method26(v0_1, "{ ")
    method9(v0_1)
    method26(v0_1, "options")
    method26(v0_1, " = ")
    method27(v0_1, v1_1, v2_1, v3_1, v4_1, v5_1, v6_1, v7)
    method26(v0_1, " }")


def closure16(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_12(State_trace_state())
    v9: int64 | None = pattern_input[4]
    _v10: str | None = None
    _v96: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v9 is None:
        x_2 = None

    else: 
        x: int64 = v9
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US2 = default_arg(_v96.contents, US2(1))
    def _arrow194(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow194() if (v101.tag == 0) else now(), method7())
    _v10 = x_3
    v152: str
    if _v10 is None:
        raise Exception("base.run_target / _v10=None")

    else: 
        v152 = _v10

    v159: US3 = US3(0, "Verbose") if (True if (v0_1.tag == 0) else False) else US3(1)
    v208: US3
    if v159.tag == 0:
        v208 = US3(0, v159.fields[0])

    else: 
        v168: US3 = US3(0, "Debug") if (True if (v0_1.tag == 1) else False) else US3(1)
        if v168.tag == 0:
            v208 = US3(0, v168.fields[0])

        else: 
            v177: US3 = US3(0, "Info") if (True if (v0_1.tag == 2) else False) else US3(1)
            if v177.tag == 0:
                v208 = US3(0, v177.fields[0])

            else: 
                v186: US3 = US3(0, "Warning") if (True if (v0_1.tag == 3) else False) else US3(1)
                if v186.tag == 0:
                    v208 = US3(0, v186.fields[0])

                else: 
                    v195: US3 = US3(0, "Critical") if (True if (v0_1.tag == 4) else False) else US3(1)
                    v208 = US3(0, v195.fields[0]) if (v195.tag == 0) else US3(1)




    v212: str
    if v208.tag == 0:
        v212 = v208.fields[0]

    else: 
        raise Exception("Option does not have a value.")

    v215: str = pad_left(v212.lower(), 7, " ")
    _v216: str | None = None
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method8()
    _v216 = x_5
    v328: str
    if _v216 is None:
        raise Exception("base.run_target / _v216=None")

    else: 
        v328 = _v216

    v329: int64 = pattern_input[0].l0
    pattern_input_1: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None] = v2_1(None)
    v338: Mut4 = Mut4("")
    method25(v338, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5], pattern_input_1[6])
    v339: str = v338.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v339) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method24(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure16(v0_1, v1_1, v2_1, None)

    method10(v0_1, v3_1)


def closure18(v0_1: str, unit_var: None) -> str:
    return v0_1


def closure17(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3_1: Callable[[tuple[int, str, bool]], Async[None]] | None, v4_1: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, v5_1: bool, v6_1: str | None, v7: None, v8: Any, v9: None) -> None:
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



def closure19(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3_1: Callable[[tuple[int, str, bool]], Async[None]] | None, v4_1: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, v5_1: bool, v6_1: str | None, v7: None, v8: Any, v9: None) -> None:
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



def closure20(v0_1: None, unit_var: None) -> None:
    _v1: bool | None = None
    _v1 = None
    def _arrow195(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> bool:
        raise Exception("base.run_target / _v1=None")

    if (_arrow195() if (_v1 is None) else _v1) == False:
        _v10: None | None = None
        _v10 = some(None)
        if _v10 is None:
            raise Exception("base.run_target / _v10=None")

        else: 
            value_12(_v10)




def closure21(unit_var: None, unit_var_1: None) -> str:
    return "runtime.execute_with_options_async / WaitForExitAsync"


def closure22(v0_1: Any, unit_var: None) -> Any:
    return v0_1


def method36(v0_1: Mut4, v1_1: Any) -> None:
    method26(v0_1, to_text(interpolate("%A%P()", [v1_1])))


def method35(v0_1: Mut4, v1_1: Any) -> None:
    method26(v0_1, "{ ")
    method9(v0_1)
    method26(v0_1, "ex")
    method26(v0_1, " = ")
    method36(v0_1, v1_1)
    method26(v0_1, " }")


def closure23(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], Any], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_12(State_trace_state())
    v9: int64 | None = pattern_input[4]
    _v10: str | None = None
    _v96: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v9 is None:
        x_2 = None

    else: 
        x: int64 = v9
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US2 = default_arg(_v96.contents, US2(1))
    def _arrow196(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow196() if (v101.tag == 0) else now(), method7())
    _v10 = x_3
    v152: str
    if _v10 is None:
        raise Exception("base.run_target / _v10=None")

    else: 
        v152 = _v10

    v159: US3 = US3(0, "Verbose") if (True if (v0_1.tag == 0) else False) else US3(1)
    v208: US3
    if v159.tag == 0:
        v208 = US3(0, v159.fields[0])

    else: 
        v168: US3 = US3(0, "Debug") if (True if (v0_1.tag == 1) else False) else US3(1)
        if v168.tag == 0:
            v208 = US3(0, v168.fields[0])

        else: 
            v177: US3 = US3(0, "Info") if (True if (v0_1.tag == 2) else False) else US3(1)
            if v177.tag == 0:
                v208 = US3(0, v177.fields[0])

            else: 
                v186: US3 = US3(0, "Warning") if (True if (v0_1.tag == 3) else False) else US3(1)
                if v186.tag == 0:
                    v208 = US3(0, v186.fields[0])

                else: 
                    v195: US3 = US3(0, "Critical") if (True if (v0_1.tag == 4) else False) else US3(1)
                    v208 = US3(0, v195.fields[0]) if (v195.tag == 0) else US3(1)




    v212: str
    if v208.tag == 0:
        v212 = v208.fields[0]

    else: 
        raise Exception("Option does not have a value.")

    v215: str = pad_left(v212.lower(), 7, " ")
    _v216: str | None = None
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method8()
    _v216 = x_5
    v328: str
    if _v216 is None:
        raise Exception("base.run_target / _v216=None")

    else: 
        v328 = _v216

    v329: int64 = pattern_input[0].l0
    v332: Mut4 = Mut4("")
    method35(v332, v2_1(None))
    v333: str = v332.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v333) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method34(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], Any]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure23(v0_1, v1_1, v2_1, None)

    method10(v0_1, v3_1)


def closure24(unit_var: None, unit_var_1: None) -> str:
    return "runtime.execute_with_options_async"


def closure25(v0_1: int, v1_1: str, unit_var: None) -> tuple[int, int]:
    return (v0_1, len(v1_1))


def method39(v0_1: Mut4, v1_1: int) -> None:
    v4_1: str = v0_1.l0 + (("" + str(v1_1)) + "")
    v0_1.l0 = v4_1


def method38(v0_1: Mut4, v1_1: int, v2_1: int) -> None:
    method26(v0_1, "{ ")
    method9(v0_1)
    method26(v0_1, "exit_code")
    method26(v0_1, " = ")
    method39(v0_1, v1_1)
    method26(v0_1, "; ")
    method26(v0_1, "output_length")
    method26(v0_1, " = ")
    method39(v0_1, v2_1)
    method26(v0_1, " }")


def closure26(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[int, int]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_12(State_trace_state())
    v9: int64 | None = pattern_input[4]
    _v10: str | None = None
    _v96: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v9 is None:
        x_2 = None

    else: 
        x: int64 = v9
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US2 = default_arg(_v96.contents, US2(1))
    def _arrow197(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow197() if (v101.tag == 0) else now(), method7())
    _v10 = x_3
    v152: str
    if _v10 is None:
        raise Exception("base.run_target / _v10=None")

    else: 
        v152 = _v10

    v159: US3 = US3(0, "Verbose") if (True if (v0_1.tag == 0) else False) else US3(1)
    v208: US3
    if v159.tag == 0:
        v208 = US3(0, v159.fields[0])

    else: 
        v168: US3 = US3(0, "Debug") if (True if (v0_1.tag == 1) else False) else US3(1)
        if v168.tag == 0:
            v208 = US3(0, v168.fields[0])

        else: 
            v177: US3 = US3(0, "Info") if (True if (v0_1.tag == 2) else False) else US3(1)
            if v177.tag == 0:
                v208 = US3(0, v177.fields[0])

            else: 
                v186: US3 = US3(0, "Warning") if (True if (v0_1.tag == 3) else False) else US3(1)
                if v186.tag == 0:
                    v208 = US3(0, v186.fields[0])

                else: 
                    v195: US3 = US3(0, "Critical") if (True if (v0_1.tag == 4) else False) else US3(1)
                    v208 = US3(0, v195.fields[0]) if (v195.tag == 0) else US3(1)




    v212: str
    if v208.tag == 0:
        v212 = v208.fields[0]

    else: 
        raise Exception("Option does not have a value.")

    v215: str = pad_left(v212.lower(), 7, " ")
    _v216: str | None = None
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method8()
    _v216 = x_5
    v328: str
    if _v216 is None:
        raise Exception("base.run_target / _v216=None")

    else: 
        v328 = _v216

    v329: int64 = pattern_input[0].l0
    pattern_input_1: tuple[int, int] = v2_1(None)
    v333: Mut4 = Mut4("")
    method38(v333, pattern_input_1[0], pattern_input_1[1])
    v334: str = v333.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v334) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method37(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[int, int]]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure26(v0_1, v1_1, v2_1, None)

    method10(v0_1, v3_1)


def method11(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3_1: Callable[[tuple[int, str, bool]], Async[None]] | None, v4_1: Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, v5_1: bool, v6_1: str | None=None) -> Async[tuple[int, str]]:
    _v7: Async[tuple[int, str]] | None = None
    _v7 = None
    if _v7 is None:
        raise Exception("base.run_target / _v7=None")

    else: 
        return _v7



def closure9(unit_var: None, v0_1: str) -> Async[tuple[int, str]]:
    return method11(v0_1, None, [], None, None, True, None)


def closure27(unit_var: None, _arg: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return method11(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6])


def closure28(unit_var: None, v0_1: Callable[[Heap0], Heap0]) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]:
    v8: Heap0 = v0_1(Heap0("", None, [], None, None, True, None))
    return (v8.l0, v8.l1, v8.l2, v8.l3, v8.l4, v8.l5, v8.l6)


def method42(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(4):
            return False

        else: 
            v19: US7
            if v1_1 == int64(0):
                v19 = US7(0, "\\")

            else: 
                v5_1: int64 = op_subtraction(v1_1, int64(1))
                if v5_1 == int64(0):
                    v19 = US7(0, "`")

                else: 
                    v8: int64 = op_subtraction(v5_1, int64(1))
                    if v8 == int64(0):
                        v19 = US7(0, "\"")

                    else: 
                        v11: int64 = op_subtraction(v8, int64(1))
                        if v11 == int64(0):
                            v19 = US7(0, " ")

                        else: 
                            v14: int64 = op_subtraction(v11, int64(1))
                            v19 = US7(1)




            def _arrow198(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v19.fields[0] if (v19.tag == 0) else _arrow198()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def method43(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_1_mut: int, v4_1_mut: int) -> US6:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v57: US5
        if "" == v1_1:
            v57 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3_1, v4_1)])))

        else: 
            v15: str = v1_1[0]
            v17: int = len(v1_1) or 0
            v22: str = v1_1[1:v17 + 1]
            if method42(v15, int64(0)) == False:
                v27: str = v15
                v28: int = len(v27) or 0
                v29: Array[str] = fill([0] * v28, 0, v28, "")
                v30: Mut5 = Mut5(0)
                while method13(v28, v30):
                    v32: int = v30.l0 or 0
                    v33: str = v27[v32]
                    v29[v32] = v33
                    v34: int = (v32 + 1) or 0
                    v30.l0 = v34 or 0
                v36: FSharpList[str] = of_array(v29)
                pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v36, UH0(0)), v2_1, v3_1, v4_1)
                v57 = US5(0, v15, v22, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v57 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v15, to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3_1, v4_1)])))


        if v57.tag == 0:
            v0_1_mut = v0_1 + v57.fields[0]
            v1_1_mut = v57.fields[1]
            v2_1_mut = v57.fields[2]
            v3_1_mut = v57.fields[3]
            v4_1_mut = v57.fields[4]
            continue

        else: 
            return US6(0, v0_1, v1_1, v2_1, v3_1, v4_1)

        break


def method45(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(3):
            return False

        else: 
            v15: US7
            if v1_1 == int64(0):
                v15 = US7(0, "\\")

            else: 
                v5_1: int64 = op_subtraction(v1_1, int64(1))
                if v5_1 == int64(0):
                    v15 = US7(0, "`")

                else: 
                    v8: int64 = op_subtraction(v5_1, int64(1))
                    if v8 == int64(0):
                        v15 = US7(0, "\"")

                    else: 
                        v11: int64 = op_subtraction(v8, int64(1))
                        v15 = US7(1)



            def _arrow199(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v15.fields[0] if (v15.tag == 0) else _arrow199()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def closure30(unit_var: None, _arg: tuple[str, Any, int, int]) -> US6:
    v3_1: int = _arg[3] or 0
    v2_1: int = _arg[2] or 0
    v1_1: Any = _arg[1]
    v0_1: str = _arg[0]
    v60: US5
    if "" == v0_1:
        v60 = US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v1_1, v2_1, v3_1)])))

    else: 
        v7: str = v0_1[0]
        if v7 == "\\":
            v10: int = len(v0_1) or 0
            v15: str = v0_1[1:v10 + 1]
            v17: str = v7
            v18: int = len(v17) or 0
            v19: Array[str] = fill([0] * v18, 0, v18, "")
            v20: Mut5 = Mut5(0)
            while method13(v18, v20):
                v22: int = v20.l0 or 0
                v23: str = v17[v22]
                v19[v22] = v23
                v24: int = (v22 + 1) or 0
                v20.l0 = v24 or 0
            v26: FSharpList[str] = of_array(v19)
            pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v26, UH0(0)), v1_1, v2_1, v3_1)
            v60 = US5(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v38: int = len(v0_1) or 0
            v41: int = (v0_1.find("\n") - 1) or 0
            v43: int = (v38 if (-2 == v41) else v41) or 0
            v60 = US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\\")) + "\' / line: ") + str(v2_1)) + " / col: ") + str(v3_1)) + "\n") + str(v1_1)) + "") + v0_1[0:v43 + 1]) + "")) + "\n") + (replicate(v3_1 - 1, " ") + "^")) + "\n")


    v102: US5
    if v60.tag == 0:
        v65: int = v60.fields[4] or 0
        v64: int = v60.fields[3] or 0
        v63: Any = v60.fields[2]
        v62: str = v60.fields[1]
        if "" == v62:
            v102 = US5(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v63, v64, v65)])))

        else: 
            v69: str = v62[0]
            v71: int = len(v62) or 0
            v76: str = v62[1:v71 + 1]
            v78: str = v69
            v79: int = len(v78) or 0
            v80: Array[str] = fill([0] * v79, 0, v79, "")
            v81: Mut5 = Mut5(0)
            while method13(v79, v81):
                v83: int = v81.l0 or 0
                v84: str = v78[v83]
                v80[v83] = v84
                v85: int = (v83 + 1) or 0
                v81.l0 = v85 or 0
            v87: FSharpList[str] = of_array(v80)
            pattern_input_1: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v87, UH0(0)), v63, v64, v65)
            v102 = US5(0, v69, v76, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])


    else: 
        v102 = US5(1, v60.fields[0])

    if v102.tag == 0:
        return US6(0, ((("" + str("\\")) + "") + str(v102.fields[0])) + "", v102.fields[1], v102.fields[2], v102.fields[3], v102.fields[4])

    else: 
        return US6(1, v102.fields[0])



def closure31(unit_var: None, _arg: tuple[str, Any, int, int]) -> US6:
    v3_1: int = _arg[3] or 0
    v2_1: int = _arg[2] or 0
    v1_1: Any = _arg[1]
    v0_1: str = _arg[0]
    v60: US5
    if "" == v0_1:
        v60 = US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v1_1, v2_1, v3_1)])))

    else: 
        v7: str = v0_1[0]
        if v7 == "`":
            v10: int = len(v0_1) or 0
            v15: str = v0_1[1:v10 + 1]
            v17: str = v7
            v18: int = len(v17) or 0
            v19: Array[str] = fill([0] * v18, 0, v18, "")
            v20: Mut5 = Mut5(0)
            while method13(v18, v20):
                v22: int = v20.l0 or 0
                v23: str = v17[v22]
                v19[v22] = v23
                v24: int = (v22 + 1) or 0
                v20.l0 = v24 or 0
            v26: FSharpList[str] = of_array(v19)
            pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v26, UH0(0)), v1_1, v2_1, v3_1)
            v60 = US5(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v38: int = len(v0_1) or 0
            v41: int = (v0_1.find("\n") - 1) or 0
            v43: int = (v38 if (-2 == v41) else v41) or 0
            v60 = US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("`")) + "\' / line: ") + str(v2_1)) + " / col: ") + str(v3_1)) + "\n") + str(v1_1)) + "") + v0_1[0:v43 + 1]) + "")) + "\n") + (replicate(v3_1 - 1, " ") + "^")) + "\n")


    v102: US5
    if v60.tag == 0:
        v65: int = v60.fields[4] or 0
        v64: int = v60.fields[3] or 0
        v63: Any = v60.fields[2]
        v62: str = v60.fields[1]
        if "" == v62:
            v102 = US5(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v63, v64, v65)])))

        else: 
            v69: str = v62[0]
            v71: int = len(v62) or 0
            v76: str = v62[1:v71 + 1]
            v78: str = v69
            v79: int = len(v78) or 0
            v80: Array[str] = fill([0] * v79, 0, v79, "")
            v81: Mut5 = Mut5(0)
            while method13(v79, v81):
                v83: int = v81.l0 or 0
                v84: str = v78[v83]
                v80[v83] = v84
                v85: int = (v83 + 1) or 0
                v81.l0 = v85 or 0
            v87: FSharpList[str] = of_array(v80)
            pattern_input_1: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v87, UH0(0)), v63, v64, v65)
            v102 = US5(0, v69, v76, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])


    else: 
        v102 = US5(1, v60.fields[0])

    if v102.tag == 0:
        return US6(0, ((("" + str("`")) + "") + str(v102.fields[0])) + "", v102.fields[1], v102.fields[2], v102.fields[3], v102.fields[4])

    else: 
        return US6(1, v102.fields[0])



def method46(v0_1_mut: str, v1_1_mut: Any, v2_1_mut: int, v3_1_mut: int, v4_1_mut: UH3) -> US6:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        if v4_1.tag == 0:
            return US6(1, "choice / no parsers succeeded")

        else: 
            v9: US6 = v4_1.fields[0]((v0_1, v1_1, v2_1, v3_1))
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


def method47(v0_1_mut: UH2, v1_1_mut: UH2) -> UH2:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v0_1.tag == 0:
            return v1_1

        else: 
            v0_1_mut = v0_1.fields[1]
            v1_1_mut = UH2(1, v0_1.fields[0], v1_1)
            continue

        break


def method44(v0_1_mut: UH2, v1_1_mut: str, v2_1_mut: Any, v3_1_mut: int, v4_1_mut: int) -> US15:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v55: US5
        if "" == v1_1:
            v55 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\""])), (v2_1, v3_1, v4_1)])))

        else: 
            v14: str = v1_1[0]
            v16: int = len(v1_1) or 0
            v21: str = v1_1[1:v16 + 1]
            if method45(v14, int64(0)) == False:
                v26: str = v14
                v27: int = len(v26) or 0
                v28: Array[str] = fill([0] * v27, 0, v27, "")
                v29: Mut5 = Mut5(0)
                while method13(v27, v29):
                    v31: int = v29.l0 or 0
                    v32: str = v26[v31]
                    v28[v31] = v32
                    v33: int = (v31 + 1) or 0
                    v29.l0 = v33 or 0
                v35: FSharpList[str] = of_array(v28)
                pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v35, UH0(0)), v2_1, v3_1, v4_1)
                v55 = US5(0, v14, v21, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v55 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v14, to_array(of_array(["\\", "`", "\""])), (v2_1, v3_1, v4_1)])))


        v67: US6 = US6(0, v55.fields[0], v55.fields[1], v55.fields[2], v55.fields[3], v55.fields[4]) if (v55.tag == 0) else US6(1, v55.fields[0])
        def v74(_arg10: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, v4_1: Any=v4_1) -> US6:
            return closure30(None, _arg10)

        def v75(_arg10_1: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, v4_1: Any=v4_1) -> US6:
            return closure31(None, _arg10_1)

        v81: US6 = v67 if (v67.tag == 0) else method46(v1_1, v2_1, v3_1, v4_1, UH3(1, v74, UH3(1, v75, UH3(0))))
        if v81.tag == 0:
            v0_1_mut = UH2(1, v81.fields[0], v0_1)
            v1_1_mut = v81.fields[1]
            v2_1_mut = v81.fields[2]
            v3_1_mut = v81.fields[3]
            v4_1_mut = v81.fields[4]
            continue

        else: 
            return US15(0, method47(v0_1, UH2(0)), v1_1, v2_1, v3_1, v4_1)

        break


def method48(v0_1: UH2, v1_1: FSharpList[str]) -> FSharpList[str]:
    if v0_1.tag == 0:
        return v1_1

    else: 
        return cons(v0_1.fields[0], method48(v0_1.fields[1], v1_1))



def method49(v0_1_mut: UH2, v1_1_mut: str, v2_1_mut: Any, v3_1_mut: int, v4_1_mut: int) -> US15:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v55: US5
        if "" == v1_1:
            v55 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\""])), (v2_1, v3_1, v4_1)])))

        else: 
            v14: str = v1_1[0]
            v16: int = len(v1_1) or 0
            v21: str = v1_1[1:v16 + 1]
            if method45(v14, int64(0)) == False:
                v26: str = v14
                v27: int = len(v26) or 0
                v28: Array[str] = fill([0] * v27, 0, v27, "")
                v29: Mut5 = Mut5(0)
                while method13(v27, v29):
                    v31: int = v29.l0 or 0
                    v32: str = v26[v31]
                    v28[v31] = v32
                    v33: int = (v31 + 1) or 0
                    v29.l0 = v33 or 0
                v35: FSharpList[str] = of_array(v28)
                pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v35, UH0(0)), v2_1, v3_1, v4_1)
                v55 = US5(0, v14, v21, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v55 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v14, to_array(of_array(["\\", "`", "\""])), (v2_1, v3_1, v4_1)])))


        v67: US6 = US6(0, v55.fields[0], v55.fields[1], v55.fields[2], v55.fields[3], v55.fields[4]) if (v55.tag == 0) else US6(1, v55.fields[0])
        if v67.tag == 0:
            v0_1_mut = UH2(1, v67.fields[0], v0_1)
            v1_1_mut = v67.fields[1]
            v2_1_mut = v67.fields[2]
            v3_1_mut = v67.fields[3]
            v4_1_mut = v67.fields[4]
            continue

        else: 
            return US15(0, method47(v0_1, UH2(0)), v1_1, v2_1, v3_1, v4_1)

        break


def method50(v0_1_mut: str, v1_1_mut: int) -> int:
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


def method41(v0_1_mut: UH2, v1_1_mut: str, v2_1_mut: Any, v3_1_mut: int, v4_1_mut: int) -> US15:
    while True:
        (v0_1, v1_1, v2_1, v3_1, v4_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut, v4_1_mut)
        v5_1: bool = "" == v1_1
        v57: US5
        if v5_1:
            v57 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3_1, v4_1)])))

        else: 
            v15: str = v1_1[0]
            v17: int = len(v1_1) or 0
            v22: str = v1_1[1:v17 + 1]
            if method42(v15, int64(0)) == False:
                v27: str = v15
                v28: int = len(v27) or 0
                v29: Array[str] = fill([0] * v28, 0, v28, "")
                v30: Mut5 = Mut5(0)
                while method13(v28, v30):
                    v32: int = v30.l0 or 0
                    v33: str = v27[v32]
                    v29[v32] = v33
                    v34: int = (v32 + 1) or 0
                    v30.l0 = v34 or 0
                v36: FSharpList[str] = of_array(v29)
                pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v36, UH0(0)), v2_1, v3_1, v4_1)
                v57 = US5(0, v15, v22, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v57 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v15, to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3_1, v4_1)])))


        v69: US6 = method43(v57.fields[0], v57.fields[1], v57.fields[2], v57.fields[3], v57.fields[4]) if (v57.tag == 0) else US6(1, v57.fields[0])
        v292: US6
        if v69.tag == 0:
            v292 = v69

        else: 
            v131: US5
            if v5_1:
                v131 = US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v2_1, v3_1, v4_1)])))

            else: 
                v78: str = v1_1[0]
                if v78 == "\"":
                    v81: int = len(v1_1) or 0
                    v86: str = v1_1[1:v81 + 1]
                    v88: str = v78
                    v89: int = len(v88) or 0
                    v90: Array[str] = fill([0] * v89, 0, v89, "")
                    v91: Mut5 = Mut5(0)
                    while method13(v89, v91):
                        v93: int = v91.l0 or 0
                        v94: str = v88[v93]
                        v90[v93] = v94
                        v95: int = (v93 + 1) or 0
                        v91.l0 = v95 or 0
                    v97: FSharpList[str] = of_array(v90)
                    pattern_input_1: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v97, UH0(0)), v2_1, v3_1, v4_1)
                    v131 = US5(0, v78, v86, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])

                else: 
                    v109: int = len(v1_1) or 0
                    v112: int = (v1_1.find("\n") - 1) or 0
                    v114: int = (v109 if (-2 == v112) else v112) or 0
                    v131 = US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\"")) + "\' / line: ") + str(v3_1)) + " / col: ") + str(v4_1)) + "\n") + str(v2_1)) + "") + v1_1[0:v114 + 1]) + "")) + "\n") + (replicate(v4_1 - 1, " ") + "^")) + "\n")


            v237: US6
            if v131.tag == 0:
                v136: int = v131.fields[4] or 0
                v135: int = v131.fields[3] or 0
                v134: Any = v131.fields[2]
                v133: str = v131.fields[1]
                v138: US15 = method44(UH2(0), v133, v134, v135, v136)
                v155: US6
                if v138.tag == 0:
                    v145: FSharpList[str] = method48(v138.fields[0], empty())
                    def _arrow201(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, v4_1: Any=v4_1) -> IEnumerable_1[str]:
                        def _arrow200(i: int) -> str:
                            return item(i, v145)

                        return map(_arrow200, range_big_int(0, 1, length(v145) - 1))

                    v155 = US6(0, join("", delay(_arrow201)), v138.fields[1], v138.fields[2], v138.fields[3], v138.fields[4])

                else: 
                    v155 = US6(1, v138.fields[0])

                if v155.tag == 0:
                    v160: int = v155.fields[4] or 0
                    v159: int = v155.fields[3] or 0
                    v158: Any = v155.fields[2]
                    v157: str = v155.fields[1]
                    v217: US5
                    if "" == v157:
                        v217 = US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v158, v159, v160)])))

                    else: 
                        v164: str = v157[0]
                        if v164 == "\"":
                            v167: int = len(v157) or 0
                            v172: str = v157[1:v167 + 1]
                            v174: str = v164
                            v175: int = len(v174) or 0
                            v176: Array[str] = fill([0] * v175, 0, v175, "")
                            v177: Mut5 = Mut5(0)
                            while method13(v175, v177):
                                v179: int = v177.l0 or 0
                                v180: str = v174[v179]
                                v176[v179] = v180
                                v181: int = (v179 + 1) or 0
                                v177.l0 = v181 or 0
                            v183: FSharpList[str] = of_array(v176)
                            pattern_input_2: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v183, UH0(0)), v158, v159, v160)
                            v217 = US5(0, v164, v172, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2])

                        else: 
                            v195: int = len(v157) or 0
                            v198: int = (v157.find("\n") - 1) or 0
                            v200: int = (v195 if (-2 == v198) else v198) or 0
                            v217 = US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\"")) + "\' / line: ") + str(v159)) + " / col: ") + str(v160)) + "\n") + str(v158)) + "") + v157[0:v200 + 1]) + "")) + "\n") + (replicate(v160 - 1, " ") + "^")) + "\n")


                    v237 = US6(0, v155.fields[0], v217.fields[1], v217.fields[2], v217.fields[3], v217.fields[4]) if (v217.tag == 0) else US6(1, to_text(interpolate("between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v217.fields[0], (v1_1, v2_1, v3_1, v4_1), (v133, v134, v135, v136), (v157, v158, v159, v160)])))

                else: 
                    v237 = US6(1, "between / expected content")


            else: 
                v237 = US6(1, v131.fields[0])

            if v237.tag == 0:
                v292 = v237

            else: 
                def v244(_arg10: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, v4_1: Any=v4_1) -> US6:
                    return closure30(None, _arg10)

                def v245(_arg10_1: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, v4_1: Any=v4_1) -> US6:
                    return closure31(None, _arg10_1)

                v249: US6 = method46(v1_1, v2_1, v3_1, v4_1, UH3(1, v244, UH3(1, v245, UH3(0))))
                v260: US6 = US6(0, "", v249.fields[1], v249.fields[2], v249.fields[3], v249.fields[4]) if (v249.tag == 0) else US6(1, v249.fields[0])
                v271: US15 = method49(UH2(0), v260.fields[1], v260.fields[2], v260.fields[3], v260.fields[4]) if (v260.tag == 0) else US15(1, v260.fields[0])
                if v271.tag == 0:
                    v278: FSharpList[str] = method48(v271.fields[0], empty())
                    def _arrow203(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1, v4_1: Any=v4_1) -> IEnumerable_1[str]:
                        def _arrow202(i_1: int) -> str:
                            return item(i_1, v278)

                        return map(_arrow202, range_big_int(0, 1, length(v278) - 1))

                    v292 = US6(0, join("", delay(_arrow203)), v271.fields[1], v271.fields[2], v271.fields[3], v271.fields[4])

                else: 
                    v292 = US6(1, v271.fields[0])



        if v292.tag == 0:
            v301: int = v292.fields[4] or 0
            v300: int = v292.fields[3] or 0
            v299: Any = v292.fields[2]
            v298: str = v292.fields[1]
            v297: str = v292.fields[0]
            v303: int = method50(v298, 0) or 0
            v315: US8
            if 0 == v303:
                v315 = US8(1, "spaces1 / expected at least one space")

            else: 
                v308: int = len(v298) or 0
                v315 = US8(0, v298[v303:v308 + 1], v299, v300, v301)

            if v315.tag == 0:
                v0_1_mut = UH2(1, v297, v0_1)
                v1_1_mut = v315.fields[0]
                v2_1_mut = v315.fields[1]
                v3_1_mut = v315.fields[2]
                v4_1_mut = v315.fields[3]
                continue

            else: 
                return US15(0, method47(v0_1, UH2(1, v297, UH2(0))), v298, v299, v300, v301)


        else: 
            return US15(0, method47(v0_1, UH2(0)), v1_1, v2_1, v3_1, v4_1)

        break


def method40(v0_1: str) -> US14:
    _v0: (str | None) | None = None
    _v0 = some(v0_1)
    def _arrow204(__unit: None=None, v0_1: Any=v0_1) -> str | None:
        raise Exception("optionm\'.of_obj / _v0=None")

    v11: US15 = method41(UH2(0), default_arg(_arrow204() if (_v0 is None) else value_12(_v0), ""), StringBuilder__ctor_Z721C83C5(""), 1, 1)
    if v11.tag == 0:
        return US14(0, to_array(method48(v11.fields[0], empty())))

    else: 
        return US14(1, v11.fields[0])



def closure29(unit_var: None, v0_1: str) -> FSharpResult_2[Array[str], str]:
    v1_1: US14 = method40(v0_1)
    if v1_1.tag == 0:
        return FSharpResult_2(0, v1_1.fields[0])

    else: 
        return FSharpResult_2(1, v1_1.fields[0])



def _arrow205(v: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
    return closure0(None, v)


v0: Callable[[US0], tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]] = _arrow205

v1: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v0(v1))


def _arrow206(__unit: None=None) -> None:
    closure2(None, None)


v2: Callable[[], None] = _arrow206

def current_process_kill(__unit: None=None) -> None:
    v2(None)


def _arrow207(v: str) -> Async[tuple[int, str]]:
    return closure9(None, v)


v3: Callable[[str], Async[tuple[int, str]]] = _arrow207

def execute_async(x: str) -> Async[tuple[int, str]]:
    return v3(x)


def _arrow208(_arg10: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return closure27(None, _arg10)


v4: Callable[[tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]], Async[tuple[int, str]]] = _arrow208

def execute_with_options_async(x: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return v4(x)


def _arrow209(v: Callable[[Heap0], Heap0]) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]:
    return closure28(None, v)


v5: Callable[[Callable[[Heap0], Heap0]], tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]] = _arrow209

def execution_options(x: Callable[[Heap0], Heap0]) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_Arc_1[std_sync_Mutex_1[std_process_ChildStdin]]], None] | None, bool, str | None]:
    return v5(x)


def _arrow210(v: str) -> FSharpResult_2[Array[str], str]:
    return closure29(None, v)


v6: Callable[[str], FSharpResult_2[Array[str], str]] = _arrow210

def split_args(x: str) -> FSharpResult_2[Array[str], str]:
    return v6(x)


