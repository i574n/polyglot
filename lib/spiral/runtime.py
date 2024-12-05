from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.array_ import fill
from fable_modules.fable_library.async_ import start_immediate
from fable_modules.fable_library.async_builder import (Async, CancellationToken, singleton)
from fable_modules.fable_library.date import (ticks as ticks_1, now, create as create_1, to_string)
from fable_modules.fable_library.list import (to_array, empty, of_array, FSharpList, fold_back, cons, item, length)
from fable_modules.fable_library.long import (from_value, op_subtraction, op_addition)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_12, default_arg, map)
from fable_modules.fable_library.range import range_big_int
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type, char_type, class_type, int32_type, tuple_type, option_type, array_type)
from fable_modules.fable_library.result import FSharpResult_2
from fable_modules.fable_library.seq import (delay, map as map_1)
from fable_modules.fable_library.string_ import (trim_end, trim_start, to_text, interpolate, replicate, join)
from fable_modules.fable_library.system_text import (StringBuilder__Clear, StringBuilder__Append_Z721C83C5, StringBuilder__ctor_Z721C83C5)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare, uncurry2, IEnumerable_1)

TraceState_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr209() -> TypeInfo:
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


US0_reflection = _expr209

def _expr210() -> TypeInfo:
    return record_type("Runtime.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr210

def _expr211() -> TypeInfo:
    return record_type("Runtime.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr211

def _expr212() -> TypeInfo:
    return record_type("Runtime.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr212

def _expr213() -> TypeInfo:
    return record_type("Runtime.Mut3", [], Mut3, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: str

Mut3_reflection = _expr213

def _expr214() -> TypeInfo:
    return record_type("Runtime.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr214

def _expr215() -> TypeInfo:
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


US1_reflection = _expr215

def _expr216() -> TypeInfo:
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


US2_reflection = _expr216

def _expr217() -> TypeInfo:
    return union_type("Runtime.US3", [], US3, lambda: [[], [], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1", "US3_2"]


US3_reflection = _expr217

def _expr218() -> TypeInfo:
    return union_type("Runtime.US4", [], US4, lambda: [[("f0_0", US3_reflection())], [("f1_0", US3_reflection())], [("f2_0", US3_reflection())], [("f3_0", US3_reflection())], [("f4_0", US3_reflection())]])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1", "US4_2", "US4_3", "US4_4"]


US4_reflection = _expr218

def _expr219() -> TypeInfo:
    return union_type("Runtime.US5", [], US5, lambda: [[("f0_0", string_type)], []])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr219

def _expr220() -> TypeInfo:
    return union_type("Runtime.US6", [], US6, lambda: [[("f0_0", string_type), ("f0_1", US5_reflection())], [("f1_0", string_type)]])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1"]


US6_reflection = _expr220

def _expr221() -> TypeInfo:
    return union_type("Runtime.US7", [], US7, lambda: [[("f0_0", char_type), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US7(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US7_0", "US7_1"]


US7_reflection = _expr221

def _expr222() -> TypeInfo:
    return record_type("Runtime.Mut5", [], Mut5, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut5(Record):
    l0: int

Mut5_reflection = _expr222

def _expr223() -> TypeInfo:
    return union_type("Runtime.UH0", [], UH0, lambda: [[], [("Item1", char_type), ("Item2", UH0_reflection())]])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr223

def _expr224() -> TypeInfo:
    return union_type("Runtime.UH1", [], UH1, lambda: [[], [("Item1", lambda_type(tuple_type(string_type, class_type("System.Text.StringBuilder"), int32_type, int32_type), US7_reflection())), ("Item2", UH1_reflection())]])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr224

def _expr225() -> TypeInfo:
    return union_type("Runtime.US8", [], US8, lambda: [[("f0_0", string_type), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US8(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US8_0", "US8_1"]


US8_reflection = _expr225

def _expr226() -> TypeInfo:
    return union_type("Runtime.US9", [], US9, lambda: [[("f0_0", char_type)], []])


class US9(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US9_0", "US9_1"]


US9_reflection = _expr226

def _expr227() -> TypeInfo:
    return union_type("Runtime.US10", [], US10, lambda: [[("f0_0", string_type), ("f0_1", class_type("System.Text.StringBuilder")), ("f0_2", int32_type), ("f0_3", int32_type)], [("f1_0", string_type)]])


class US10(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US10_0", "US10_1"]


US10_reflection = _expr227

def _expr228() -> TypeInfo:
    return union_type("Runtime.US11", [], US11, lambda: [[("f0_0", string_type), ("f0_1", US5_reflection()), ("f0_2", string_type), ("f0_3", class_type("System.Text.StringBuilder")), ("f0_4", int32_type), ("f0_5", int32_type)], [("f1_0", string_type)]])


class US11(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US11_0", "US11_1"]


US11_reflection = _expr228

def _expr229() -> TypeInfo:
    return union_type("Runtime.US12", [], US12, lambda: [[("f0_0", US9_reflection()), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US12(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US12_0", "US12_1"]


US12_reflection = _expr229

def _expr230() -> TypeInfo:
    return union_type("Runtime.US13", [], US13, lambda: [[("f0_0", US5_reflection()), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US13(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US13_0", "US13_1"]


US13_reflection = _expr230

def _expr231() -> TypeInfo:
    return union_type("Runtime.US14", [], US14, lambda: [[("f0_0", lambda_type(tuple_type(int32_type, string_type, bool_type), class_type("Microsoft.FSharp.Control.FSharpAsync`1", [unit_type])))], []])


class US14(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US14_0", "US14_1"]


US14_reflection = _expr231

def _expr232() -> TypeInfo:
    return union_type("Runtime.US15", [], US15, lambda: [[("f0_0", class_type("System.Threading.CancellationToken"))], []])


class US15(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US15_0", "US15_1"]


US15_reflection = _expr232

def _expr233() -> TypeInfo:
    return record_type("Runtime.Heap0", [], Heap0, lambda: [("l0", string_type), ("l1", option_type(class_type("System.Threading.CancellationToken"))), ("l2", array_type(tuple_type(string_type, string_type))), ("l3", option_type(lambda_type(tuple_type(int32_type, string_type, bool_type), class_type("Microsoft.FSharp.Control.FSharpAsync`1", [unit_type])))), ("l4", option_type(lambda_type(class_type("Runtime.std_sync_Arc`1", [class_type("Runtime.std_sync_Mutex`1", [class_type("Runtime.std_process_ChildStdin")])]), unit_type))), ("l5", bool_type), ("l6", option_type(string_type))])


@dataclass(eq = False, repr = False, slots = True)
class Heap0(Record):
    l0: str
    l1: CancellationToken | None
    l2: Array[tuple[str, str]]
    l3: Callable[[tuple[int, str, bool]], Async[None]] | None
    l4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None
    l5: bool
    l6: str | None

Heap0_reflection = _expr233

def _expr234() -> TypeInfo:
    return union_type("Runtime.US16", [], US16, lambda: [[("f0_0", array_type(string_type))], [("f1_0", string_type)]])


class US16(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US16_0", "US16_1"]


US16_reflection = _expr234

def _expr235() -> TypeInfo:
    return union_type("Runtime.UH2", [], UH2, lambda: [[], [("Item1", string_type), ("Item2", UH2_reflection())]])


class UH2(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH2_0", "UH2_1"]


UH2_reflection = _expr235

def _expr236() -> TypeInfo:
    return union_type("Runtime.US17", [], US17, lambda: [[("f0_0", UH2_reflection()), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US17(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US17_0", "US17_1"]


US17_reflection = _expr236

def _expr237() -> TypeInfo:
    return union_type("Runtime.UH3", [], UH3, lambda: [[], [("Item1", lambda_type(tuple_type(string_type, class_type("System.Text.StringBuilder"), int32_type, int32_type), US8_reflection())), ("Item2", UH3_reflection())]])


class UH3(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH3_0", "UH3_1"]


UH3_reflection = _expr237

def method3(__unit: None=None) -> str:
    return ""


def closure1(unit_var: None, v0_1: str) -> US5:
    return US5(0, v0_1)


def method4(__unit: None=None) -> Callable[[str], US5]:
    def _arrow238(v: str) -> US5:
        return closure1(None, v)

    return _arrow238


def method2(v0_1: str) -> str:
    v28: IOsEnviron = os
    v30: Any = v28.environ
    _v34: (str | None) | None = None
    x: str | None = v30.get(v0_1)
    _v34 = some(x)
    v39: str | None
    if _v34 is None:
        raise Exception("optionm\'.of_obj / _v34=None")

    else: 
        v39 = value_12(_v34)

    v55: US5 = default_arg(map(method4(), v39), US5(1))
    if v55.tag == 0:
        return v55.fields[0]

    else: 
        return ""



def method1(__unit: None=None) -> tuple[US1, US2]:
    v1_1: str = method2("TRACE_LEVEL")
    v6: US1 = US1(0, US0(0)) if ("Verbose" == v1_1) else US1(1)
    def _arrow239(__unit: None=None) -> US1:
        v13: US1 = US1(0, US0(1)) if ("Debug" == v1_1) else US1(1)
        if v13.tag == 0:
            return US1(0, v13.fields[0])

        else: 
            v20_1: US1 = US1(0, US0(2)) if ("Info" == v1_1) else US1(1)
            if v20_1.tag == 0:
                return US1(0, v20_1.fields[0])

            else: 
                v27: US1 = US1(0, US0(3)) if ("Warning" == v1_1) else US1(1)
                if v27.tag == 0:
                    return US1(0, v27.fields[0])

                else: 
                    v34: US1 = US1(0, US0(4)) if ("Critical" == v1_1) else US1(1)
                    return US1(0, v34.fields[0]) if (v34.tag == 0) else US1(1)




    return (US1(0, v6.fields[0]) if (v6.tag == 0) else _arrow239(), US2(1) if (method2("AUTOMATION") != "True") else US2(0, from_value(ticks_1(now()), False)))


def closure2(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None]:
    pattern_input: tuple[US1, US2] = method1()
    _v1: tuple[US1, US2] = (pattern_input[0], pattern_input[1])
    v132: US2 = _v1[1]
    v131: US1 = _v1[0]
    def v138(v: str, v0_1: Any=v0_1) -> None:
        closure2(None, v)

    return (Mut0(int64(1)), Mut1(v138), Mut2(True), Mut3(""), Mut4(v131.fields[0] if (v131.tag == 0) else v0_1), v132.fields[0] if (v132.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = method0(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def method5(v0_1: US0) -> bool:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v35: US0 = pattern_input[4].l0
    if pattern_input[2].l0 == False:
        return False

    else: 
        class ObjectExpr240:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        class ObjectExpr241:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        return find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr240())) >= find(v35, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr241()))



def closure6(unit_var: None, v0_1: int64) -> US2:
    return US2(0, v0_1)


def method7(__unit: None=None) -> Callable[[int64], US2]:
    def _arrow242(v: int64) -> US2:
        return closure6(None, v)

    return _arrow242


def method8(__unit: None=None) -> str:
    return "hh:mm:ss"


def method9(__unit: None=None) -> str:
    return "HH:mm:ss"


def method6(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None=None) -> str:
    v453: US2 = default_arg(map(method7(), v5), US2(1))
    v550: Any
    if v453.tag == 0:
        v510: Any = create(op_subtraction(from_value(ticks_1(now()), False), v453.fields[0]))
        v550 = create_1(1, 1, 1, hours(v510), minutes(v510), seconds(v510), milliseconds(v510))

    else: 
        v550 = now()

    v551: str = method9()
    return to_string(v550, "M-d-y hh:mm:ss tt" if (v551 == "") else v551)


def method12(__unit: None=None) -> str:
    return ""


def closure7(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def method11(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method12())
    v8: None
    closure7(v2_1, ("" + str(v0_1)) + "", None)
    v8 = None
    return v2_1.l0


def method13(__unit: None=None) -> str:
    return "\u001b[0m"


def method10(__unit: None=None) -> str:
    v2_1: str = "Warning".lower()
    return ("\u001b[93m" + method11(v2_1[0])) + method13()


def method15(__unit: None=None) -> str:
    v1_1: Mut3 = Mut3(method12())
    return v1_1.l0


def method16(v0_1: str) -> str:
    return trim_end(trim_start(v0_1, *to_array(empty())), *to_array(of_array([" ", "/"])))


def method14(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str) -> str:
    v8: str = method15()
    return method16(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "runtime.current_process_kill / exiting... 3") + " / ") + v8) + "")


def closure8(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure10(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure9(unit_var: None, v0_1: str) -> None:
    v3: None
    closure10(v0_1, None)
    v3 = None


def method17(v0_1: str) -> None:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v37: None
    closure8(pattern_input[0], None)
    v37 = None
    closure9(None, v0_1)
    pattern_input[1].l0(v0_1)


def closure5(unit_var: None, unit_var_1: None) -> None:
    if method5(US0(3)):
        v4: None
        closure0(None, None)
        v4 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        v23: int64 | None = pattern_input[5]
        v22: Mut4 = pattern_input[4]
        v21: Mut3 = pattern_input[3]
        v20_1: Mut2 = pattern_input[2]
        v19_1: Mut1 = pattern_input[1]
        v18_1: Mut0 = pattern_input[0]
        method17(method14(v18_1, v19_1, v20_1, v21, v22, v23, method6(v18_1, v19_1, v20_1, v21, v22, v23), method10()))



def method18(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str) -> str:
    v8: str = method15()
    return method16(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "runtime.current_process_kill / exiting... 2") + " / ") + v8) + "")


def closure11(unit_var: None, unit_var_1: None) -> None:
    if method5(US0(3)):
        v4: None
        closure0(None, None)
        v4 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        v23: int64 | None = pattern_input[5]
        v22: Mut4 = pattern_input[4]
        v21: Mut3 = pattern_input[3]
        v20_1: Mut2 = pattern_input[2]
        v19_1: Mut1 = pattern_input[1]
        v18_1: Mut0 = pattern_input[0]
        method17(method18(v18_1, v19_1, v20_1, v21, v22, v23, method6(v18_1, v19_1, v20_1, v21, v22, v23), method10()))



def method19(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str) -> str:
    v8: str = method15()
    return method16(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "runtime.current_process_kill / exiting... 1") + " / ") + v8) + "")


def closure12(unit_var: None, unit_var_1: None) -> None:
    if method5(US0(3)):
        v4: None
        closure0(None, None)
        v4 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        v23: int64 | None = pattern_input[5]
        v22: Mut4 = pattern_input[4]
        v21: Mut3 = pattern_input[3]
        v20_1: Mut2 = pattern_input[2]
        v19_1: Mut1 = pattern_input[1]
        v18_1: Mut0 = pattern_input[0]
        method17(method19(v18_1, v19_1, v20_1, v21, v22, v23, method6(v18_1, v19_1, v20_1, v21, v22, v23), method10()))



def closure4(unit_var: None, unit_var_1: None) -> None:
    pass


def closure3(unit_var: None, unit_var_1: None) -> None:
    pass


def method22(__unit: None=None) -> str:
    return ""


def method23(v0_1: int, v1_1: Mut5) -> bool:
    return v1_1.l0 < v0_1


def closure16(v0_1: str, v1_1: UH0) -> UH0:
    return UH0(1, v0_1, v1_1)


def closure15(unit_var: None, v0_1: str) -> Callable[[UH0], UH0]:
    def _arrow243(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure16(v0_1, v)

    return _arrow243


def method24(__unit: None=None) -> Callable[[str, UH0], UH0]:
    def _arrow244(v: str) -> Callable[[UH0], UH0]:
        return closure15(None, v)

    return _arrow244


def method25(v0_1_mut: UH0, v1_1_mut: Any, v2_1_mut: int, v3_mut: int) -> tuple[Any, int, int]:
    while True:
        (v0_1, v1_1, v2_1, v3) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut)
        if v0_1.tag == 0:
            return (v1_1, v2_1, v3)

        else: 
            v4: str = v0_1.fields[0]
            v6: bool = "\n" == v4
            pattern_input: tuple[int, int] = ((v2_1 + 1, 1)) if v6 else ((v2_1, v3 + 1))
            v0_1_mut = v0_1.fields[1]
            def _arrow245(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3) -> Any:
                v12: Any = StringBuilder__Clear(v1_1)
                return v1_1

            def _arrow246(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3) -> Any:
                v21: Any = StringBuilder__Append_Z721C83C5(v1_1, v4)
                return v1_1

            v1_1_mut = _arrow245() if v6 else _arrow246()
            v2_1_mut = pattern_input[0]
            v3_mut = pattern_input[1]
            continue

        break


def closure14(unit_var: None, _arg: tuple[str, Any, int, int]) -> US7:
    v3: int = _arg[3] or 0
    v2_1: int = _arg[2] or 0
    v1_1: Any = _arg[1]
    v0_1: str = _arg[0]
    if "" == v0_1:
        return US7(1, to_text(interpolate("parsing.p_char / unexpected end of input / c: \'%P()\' / s: %A%P()", ["\"", (v1_1, v2_1, v3)])))

    else: 
        v9: str = v0_1[0]
        if v9 == "\"":
            v29: int = (len(v0_1) - 1) or 0
            v30: str = v0_1[1:v29 + 1]
            v35: str = v9
            v38: int = len(v35) or 0
            v39: Array[str] = fill([0] * v38, 0, v38, "")
            v40: Mut5 = Mut5(0)
            while method23(v38, v40):
                v42: int = v40.l0 or 0
                v43: str = v35[v42]
                v39[v42] = v43
                v44: int = (v42 + 1) or 0
                v40.l0 = v44 or 0
            v45: FSharpList[str] = of_array(v39)
            pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v45, UH0(0)), v1_1, v2_1, v3)
            return US7(0, v9, v30, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v83: int = (v0_1.find("\n") - 1) or 0
            v106: int = (((len(v0_1) + 1) if (-2 == v83) else (v83 + 1)) - 1) or 0
            return US7(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\"")) + "\' / line: ") + str(v2_1)) + " / col: ") + str(v3)) + "\n") + str(v1_1)) + "") + v0_1[0:v106 + 1]) + "")) + "\n") + (replicate(v3 - 1, " ") + "^")) + "\n")




def closure17(unit_var: None, _arg: tuple[str, Any, int, int]) -> US7:
    v3: int = _arg[3] or 0
    v2_1: int = _arg[2] or 0
    v1_1: Any = _arg[1]
    v0_1: str = _arg[0]
    if "" == v0_1:
        return US7(1, to_text(interpolate("parsing.p_char / unexpected end of input / c: \'%P()\' / s: %A%P()", ["\'", (v1_1, v2_1, v3)])))

    else: 
        v9: str = v0_1[0]
        if v9 == "\'":
            v29: int = (len(v0_1) - 1) or 0
            v30: str = v0_1[1:v29 + 1]
            v35: str = v9
            v38: int = len(v35) or 0
            v39: Array[str] = fill([0] * v38, 0, v38, "")
            v40: Mut5 = Mut5(0)
            while method23(v38, v40):
                v42: int = v40.l0 or 0
                v43: str = v35[v42]
                v39[v42] = v43
                v44: int = (v42 + 1) or 0
                v40.l0 = v44 or 0
            v45: FSharpList[str] = of_array(v39)
            pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v45, UH0(0)), v1_1, v2_1, v3)
            return US7(0, v9, v30, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v83: int = (v0_1.find("\n") - 1) or 0
            v106: int = (((len(v0_1) + 1) if (-2 == v83) else (v83 + 1)) - 1) or 0
            return US7(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\'")) + "\' / line: ") + str(v2_1)) + " / col: ") + str(v3)) + "\n") + str(v1_1)) + "") + v0_1[0:v106 + 1]) + "")) + "\n") + (replicate(v3 - 1, " ") + "^")) + "\n")




def method26(v0_1_mut: str, v1_1_mut: Any, v2_1_mut: UH1) -> US7:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if v2_1.tag == 0:
            return US7(1, "parsing.choice / no parsers succeeded")

        else: 
            v7: US7 = v2_1.fields[0]((v0_1, v1_1, 1, 1))
            if v7.tag == 0:
                return v7

            else: 
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1.fields[1]
                continue


        break


def method27(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(2):
            return False

        else: 
            v11: US9
            if v1_1 == int64(0):
                v11 = US9(0, "\"")

            else: 
                v5: int64 = op_subtraction(v1_1, int64(1))
                if v5 == int64(0):
                    v11 = US9(0, "\'")

                else: 
                    v8: int64 = op_subtraction(v5, int64(1))
                    v11 = US9(1)


            def _arrow247(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v11.fields[0] if (v11.tag == 0) else _arrow247()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def method28(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> tuple[str, str, Any, int, int]:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v109: US7
        if "" == v1_1:
            v109 = US7(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'"])), (v2_1, v3, v4)])))

        else: 
            v21: str = v1_1[0]
            if method27(v21, int64(0)) == False:
                v43: int = (len(v1_1) - 1) or 0
                v44: str = v1_1[1:v43 + 1]
                v49: str = v21
                v52: int = len(v49) or 0
                v53: Array[str] = fill([0] * v52, 0, v52, "")
                v54: Mut5 = Mut5(0)
                while method23(v52, v54):
                    v56: int = v54.l0 or 0
                    v57: str = v49[v56]
                    v53[v56] = v57
                    v58: int = (v56 + 1) or 0
                    v54.l0 = v58 or 0
                v59: FSharpList[str] = of_array(v53)
                pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v59, UH0(0)), v2_1, v3, v4)
                v109 = US7(0, v21, v44, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v109 = US7(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v21, to_array(of_array(["\"", "\'"])), (v2_1, v3, v4)])))


        v121: US7
        if v109.tag == 0:
            v110: str = v109.fields[0]
            v121 = US7(0, "/" if ("\\" == v110) else v110, v109.fields[1], v109.fields[2], v109.fields[3], v109.fields[4])

        else: 
            v121 = US7(1, v109.fields[0])

        if v121.tag == 0:
            v0_1_mut = v0_1 + v121.fields[0]
            v1_1_mut = v121.fields[1]
            v2_1_mut = v121.fields[2]
            v3_mut = v121.fields[3]
            v4_mut = v121.fields[4]
            continue

        else: 
            return (v0_1, v1_1, v2_1, v3, v4)

        break


def method29(v0_1_mut: str, v1_1_mut: Any, v2_1_mut: int, v3_mut: int, v4_mut: UH1) -> US7:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        if v4.tag == 0:
            return US7(1, "parsing.choice / no parsers succeeded")

        else: 
            v9: US7 = v4.fields[0]((v0_1, v1_1, v2_1, v3))
            if v9.tag == 0:
                return v9

            else: 
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_mut = v3
                v4_mut = v4.fields[1]
                continue


        break


def method30(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(3):
            return False

        else: 
            v15: US9
            if v1_1 == int64(0):
                v15 = US9(0, "\"")

            else: 
                v5: int64 = op_subtraction(v1_1, int64(1))
                if v5 == int64(0):
                    v15 = US9(0, "\'")

                else: 
                    v8: int64 = op_subtraction(v5, int64(1))
                    if v8 == int64(0):
                        v15 = US9(0, " ")

                    else: 
                        v11: int64 = op_subtraction(v8, int64(1))
                        v15 = US9(1)



            def _arrow248(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v15.fields[0] if (v15.tag == 0) else _arrow248()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def method31(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> tuple[str, str, Any, int, int]:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v115: US7
        if "" == v1_1:
            v115 = US7(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'", " "])), (v2_1, v3, v4)])))

        else: 
            v24: str = v1_1[0]
            if method30(v24, int64(0)) == False:
                v46: int = (len(v1_1) - 1) or 0
                v47: str = v1_1[1:v46 + 1]
                v52: str = v24
                v55: int = len(v52) or 0
                v56: Array[str] = fill([0] * v55, 0, v55, "")
                v57: Mut5 = Mut5(0)
                while method23(v55, v57):
                    v59: int = v57.l0 or 0
                    v60: str = v52[v59]
                    v56[v59] = v60
                    v61: int = (v59 + 1) or 0
                    v57.l0 = v61 or 0
                v62: FSharpList[str] = of_array(v56)
                pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v62, UH0(0)), v2_1, v3, v4)
                v115 = US7(0, v24, v47, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v115 = US7(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v24, to_array(of_array(["\"", "\'", " "])), (v2_1, v3, v4)])))


        v127: US7
        if v115.tag == 0:
            v116: str = v115.fields[0]
            v127 = US7(0, "/" if ("\\" == v116) else v116, v115.fields[1], v115.fields[2], v115.fields[3], v115.fields[4])

        else: 
            v127 = US7(1, v115.fields[0])

        if v127.tag == 0:
            v0_1_mut = v0_1 + v127.fields[0]
            v1_1_mut = v127.fields[1]
            v2_1_mut = v127.fields[2]
            v3_mut = v127.fields[3]
            v4_mut = v127.fields[4]
            continue

        else: 
            return (v0_1, v1_1, v2_1, v3, v4)

        break


def method32(v0_1_mut: str, v1_1_mut: int) -> int:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= len(v0_1):
            return v1_1

        elif " " == v0_1[v1_1]:
            v0_1_mut = v0_1
            v1_1_mut = v1_1 + 1
            continue

        else: 
            return v1_1

        break


def method33(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> tuple[str, str, Any, int, int]:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v79: US7
        if "" == v1_1:
            v79 = US7(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v2_1, v3, v4)])))

        else: 
            v10: str = v1_1[0]
            v29: int = (len(v1_1) - 1) or 0
            v30: str = v1_1[1:v29 + 1]
            v35: str = v10
            v38: int = len(v35) or 0
            v39: Array[str] = fill([0] * v38, 0, v38, "")
            v40: Mut5 = Mut5(0)
            while method23(v38, v40):
                v42: int = v40.l0 or 0
                v43: str = v35[v42]
                v39[v42] = v43
                v44: int = (v42 + 1) or 0
                v40.l0 = v44 or 0
            v45: FSharpList[str] = of_array(v39)
            pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v45, UH0(0)), v2_1, v3, v4)
            v79 = US7(0, v10, v30, pattern_input[0], pattern_input[1], pattern_input[2])

        if v79.tag == 0:
            v0_1_mut = v0_1 + v79.fields[0]
            v1_1_mut = v79.fields[1]
            v2_1_mut = v79.fields[2]
            v3_mut = v79.fields[3]
            v4_mut = v79.fields[4]
            continue

        else: 
            return (v0_1, v1_1, v2_1, v3, v4)

        break


def method21(v0_1: str) -> US6:
    _v0: (str | None) | None = None
    _v0 = some(v0_1)
    def _arrow249(__unit: None=None, v0_1: Any=v0_1) -> str | None:
        raise Exception("optionm\'.of_obj / _v0=None")

    v7: str = default_arg(_arrow249() if (_v0 is None) else value_12(_v0), "")
    v12: Any = StringBuilder__ctor_Z721C83C5(method22())
    def v15(_arg10: tuple[str, Any, int, int], v0_1: Any=v0_1) -> US7:
        return closure14(None, _arg10)

    def v16_1(_arg10_1: tuple[str, Any, int, int], v0_1: Any=v0_1) -> US7:
        return closure17(None, _arg10_1)

    v20_1: US7 = method26(v7, v12, UH1(1, v15, UH1(1, v16_1, UH1(0))))
    v202: US8
    if v20_1.tag == 0:
        v25: int = v20_1.fields[4] or 0
        v24: int = v20_1.fields[3] or 0
        v23: Any = v20_1.fields[2]
        v22: str = v20_1.fields[1]
        v130: US7
        if "" == v22:
            v130 = US7(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'"])), (v23, v24, v25)])))

        else: 
            v42: str = v22[0]
            if method27(v42, int64(0)) == False:
                v64: int = (len(v22) - 1) or 0
                v65: str = v22[1:v64 + 1]
                v70: str = v42
                v73: int = len(v70) or 0
                v74: Array[str] = fill([0] * v73, 0, v73, "")
                v75: Mut5 = Mut5(0)
                while method23(v73, v75):
                    v77: int = v75.l0 or 0
                    v78: str = v70[v77]
                    v74[v77] = v78
                    v79: int = (v77 + 1) or 0
                    v75.l0 = v79 or 0
                v80: FSharpList[str] = of_array(v74)
                pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v80, UH0(0)), v23, v24, v25)
                v130 = US7(0, v42, v65, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v130 = US7(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v42, to_array(of_array(["\"", "\'"])), (v23, v24, v25)])))


        v142: US7
        if v130.tag == 0:
            v131: str = v130.fields[0]
            v142 = US7(0, "/" if ("\\" == v131) else v131, v130.fields[1], v130.fields[2], v130.fields[3], v130.fields[4])

        else: 
            v142 = US7(1, v130.fields[0])

        v161: US8
        if v142.tag == 0:
            pattern_input_1: tuple[str, str, Any, int, int] = method28(v142.fields[0], v142.fields[1], v142.fields[2], v142.fields[3], v142.fields[4])
            v161 = US8(0, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4])

        else: 
            v161 = US8(1, v142.fields[0])

        v171: US8 = US8(0, v161.fields[0], v161.fields[1], v161.fields[2], v161.fields[3], v161.fields[4]) if (v161.tag == 0) else US8(0, "", v22, v23, v24, v25)
        if v171.tag == 0:
            v176: int = v171.fields[4] or 0
            v175: int = v171.fields[3] or 0
            v174: Any = v171.fields[2]
            v173: str = v171.fields[1]
            v180: US7 = method29(v173, v174, v175, v176, UH1(1, v15, UH1(1, v16_1, UH1(0))))
            v202 = US8(0, v171.fields[0], v180.fields[1], v180.fields[2], v180.fields[3], v180.fields[4]) if (v180.tag == 0) else US8(1, to_text(interpolate("parsing.between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v180.fields[0], (v7, v12, 1, 1), (v22, v23, v24, v25), (v173, v174, v175, v176)])))

        else: 
            v202 = US8(1, "parsing.between / expected content")


    else: 
        v202 = US8(1, v20_1.fields[0])

    v414: US8
    if v202.tag == 0:
        v414 = v202

    else: 
        v321: US7
        if "" == v7:
            v321 = US7(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'", " "])), (v12, 1, 1)])))

        else: 
            v228: str = v7[0]
            if method30(v228, int64(0)) == False:
                v250: int = (len(v7) - 1) or 0
                v251: str = v7[1:v250 + 1]
                v256: str = v228
                v259: int = len(v256) or 0
                v260: Array[str] = fill([0] * v259, 0, v259, "")
                v261: Mut5 = Mut5(0)
                while method23(v259, v261):
                    v263: int = v261.l0 or 0
                    v264: str = v256[v263]
                    v260[v263] = v264
                    v265: int = (v263 + 1) or 0
                    v261.l0 = v265 or 0
                v266: FSharpList[str] = of_array(v260)
                pattern_input_2: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v266, UH0(0)), v12, 1, 1)
                v321 = US7(0, v228, v251, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2])

            else: 
                v321 = US7(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v228, to_array(of_array(["\"", "\'", " "])), (v12, 1, 1)])))


        v333: US7
        if v321.tag == 0:
            v322: str = v321.fields[0]
            v333 = US7(0, "/" if ("\\" == v322) else v322, v321.fields[1], v321.fields[2], v321.fields[3], v321.fields[4])

        else: 
            v333 = US7(1, v321.fields[0])

        v352: US8
        if v333.tag == 0:
            pattern_input_3: tuple[str, str, Any, int, int] = method31(v333.fields[0], v333.fields[1], v333.fields[2], v333.fields[3], v333.fields[4])
            v352 = US8(0, pattern_input_3[0], pattern_input_3[1], pattern_input_3[2], pattern_input_3[3], pattern_input_3[4])

        else: 
            v352 = US8(1, v333.fields[0])

        if v352.tag == 0:
            v414 = v352

        else: 
            v366: US10 = US10(0, v7, v12, 1, 1) if (len(v7) == 0) else US10(1, to_text(interpolate("parsing.eof / expected end of input / input: %A%P()", [v7])))
            v375: US8 = US8(0, "", v366.fields[0], v366.fields[1], v366.fields[2], v366.fields[3]) if (v366.tag == 0) else US8(1, v366.fields[0])
            if v375.tag == 0:
                v377: str = v375.fields[1]
                v382: int = method32(v377, 0) or 0
                v401: int = (len(v377) - 1) or 0
                v414 = US8(0, v375.fields[0], v377[v382:v401 + 1], v375.fields[2], v375.fields[3], v375.fields[4])

            else: 
                v414 = US8(1, v375.fields[0])



    v685: US11
    if v414.tag == 0:
        v419: int = v414.fields[4] or 0
        v418: int = v414.fields[3] or 0
        v417: Any = v414.fields[2]
        v416: str = v414.fields[1]
        v544: US7
        if "" == v416:
            v544 = US7(1, to_text(interpolate("parsing.p_char / unexpected end of input / c: \'%P()\' / s: %A%P()", [" ", (v417, v418, v419)])))

        else: 
            v425: str = v416[0]
            if v425 == " ":
                v445: int = (len(v416) - 1) or 0
                v446: str = v416[1:v445 + 1]
                v451: str = v425
                v454: int = len(v451) or 0
                v455: Array[str] = fill([0] * v454, 0, v454, "")
                v456: Mut5 = Mut5(0)
                while method23(v454, v456):
                    v458: int = v456.l0 or 0
                    v459: str = v451[v458]
                    v455[v458] = v459
                    v460: int = (v458 + 1) or 0
                    v456.l0 = v460 or 0
                v461: FSharpList[str] = of_array(v455)
                pattern_input_4: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v461, UH0(0)), v417, v418, v419)
                v544 = US7(0, v425, v446, pattern_input_4[0], pattern_input_4[1], pattern_input_4[2])

            else: 
                v499: int = (v416.find("\n") - 1) or 0
                v522: int = (((len(v416) + 1) if (-2 == v499) else (v499 + 1)) - 1) or 0
                v544 = US7(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str(" ")) + "\' / line: ") + str(v418)) + " / col: ") + str(v419)) + "\n") + str(v417)) + "") + v416[0:v522 + 1]) + "")) + "\n") + (replicate(v419 - 1, " ") + "^")) + "\n")


        v556: US12 = US12(0, US9(0, v544.fields[0]), v544.fields[1], v544.fields[2], v544.fields[3], v544.fields[4]) if (v544.tag == 0) else US12(0, US9(1), v416, v417, v418, v419)
        v659: US8
        if v556.tag == 0:
            v561: int = v556.fields[4] or 0
            v560: int = v556.fields[3] or 0
            v559: Any = v556.fields[2]
            v558: str = v556.fields[1]
            v636: US7
            if "" == v558:
                v636 = US7(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v559, v560, v561)])))

            else: 
                v567: str = v558[0]
                v586: int = (len(v558) - 1) or 0
                v587: str = v558[1:v586 + 1]
                v592: str = v567
                v595: int = len(v592) or 0
                v596: Array[str] = fill([0] * v595, 0, v595, "")
                v597: Mut5 = Mut5(0)
                while method23(v595, v597):
                    v599: int = v597.l0 or 0
                    v600: str = v592[v599]
                    v596[v599] = v600
                    v601: int = (v599 + 1) or 0
                    v597.l0 = v601 or 0
                v602: FSharpList[str] = of_array(v596)
                pattern_input_5: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v602, UH0(0)), v559, v560, v561)
                v636 = US7(0, v567, v587, pattern_input_5[0], pattern_input_5[1], pattern_input_5[2])

            if v636.tag == 0:
                pattern_input_6: tuple[str, str, Any, int, int] = method33(v636.fields[0], v636.fields[1], v636.fields[2], v636.fields[3], v636.fields[4])
                v659 = US8(0, pattern_input_6[0], pattern_input_6[1], pattern_input_6[2], pattern_input_6[3], pattern_input_6[4])

            else: 
                v659 = US8(1, v636.fields[0])


        else: 
            v659 = US8(1, v556.fields[0])

        v671: US13 = US13(0, US5(0, v659.fields[0]), v659.fields[1], v659.fields[2], v659.fields[3], v659.fields[4]) if (v659.tag == 0) else US13(0, US5(1), v416, v417, v418, v419)
        v685 = US11(0, v414.fields[0], v671.fields[0], v671.fields[1], v671.fields[2], v671.fields[3], v671.fields[4]) if (v671.tag == 0) else US11(1, v671.fields[0])

    else: 
        v685 = US11(1, v414.fields[0])

    if v685.tag == 0:
        return US6(0, v685.fields[0], v685.fields[1])

    else: 
        return US6(1, v685.fields[0])



def method34(__unit: None=None) -> str:
    v2_1: str = "Debug".lower()
    return ("\u001b[94m" + method11(v2_1[0])) + method13()


def method36(v0_1: str, v1_1: US5, v2_1: str, v3: CancellationToken | None, v4: Array[tuple[str, str]], v5: Callable[[tuple[int, str, bool]], Async[None]] | None, v6: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v7: bool, v8: str | None=None) -> str:
    v10: Mut3 = Mut3(method12())
    v17_1: None
    closure7(v10, ("" + "{ ") + "", None)
    v17_1 = None
    v26: None
    closure7(v10, ("" + "file_name") + "", None)
    v26 = None
    v35: None
    closure7(v10, ("" + " = ") + "", None)
    v35 = None
    v43: None
    closure7(v10, ("" + v0_1) + "", None)
    v43 = None
    v52: None
    closure7(v10, ("" + "; ") + "", None)
    v52 = None
    v61: None
    closure7(v10, ("" + "arguments") + "", None)
    v61 = None
    v69: None
    closure7(v10, ("" + " = ") + "", None)
    v69 = None
    v80: None
    closure7(v10, ("" + to_text(interpolate("%A%P()", [v1_1]))) + "", None)
    v80 = None
    v88: None
    closure7(v10, ("" + "; ") + "", None)
    v88 = None
    v97: None
    closure7(v10, ("" + "options") + "", None)
    v97 = None
    v105: None
    closure7(v10, ("" + " = ") + "", None)
    v105 = None
    v113: None
    closure7(v10, ("" + "{ ") + "", None)
    v113 = None
    v122: None
    closure7(v10, ("" + "command") + "", None)
    v122 = None
    v130: None
    closure7(v10, ("" + " = ") + "", None)
    v130 = None
    v138: None
    closure7(v10, ("" + v2_1) + "", None)
    v138 = None
    v146: None
    closure7(v10, ("" + "; ") + "", None)
    v146 = None
    v155: None
    closure7(v10, ("" + "cancellation_token") + "", None)
    v155 = None
    v163: None
    closure7(v10, ("" + " = ") + "", None)
    v163 = None
    v201: None
    closure7(v10, ("" + to_text(interpolate("%A%P()", [v3]))) + "", None)
    v201 = None
    v209: None
    closure7(v10, ("" + "; ") + "", None)
    v209 = None
    v218: None
    closure7(v10, ("" + "environment_variables") + "", None)
    v218 = None
    v226: None
    closure7(v10, ("" + " = ") + "", None)
    v226 = None
    v237: None
    closure7(v10, ("" + to_text(interpolate("%A%P()", [v4]))) + "", None)
    v237 = None
    v245: None
    closure7(v10, ("" + "; ") + "", None)
    v245 = None
    v254: None
    closure7(v10, ("" + "on_line") + "", None)
    v254 = None
    v262: None
    closure7(v10, ("" + " = ") + "", None)
    v262 = None
    v300: None
    closure7(v10, ("" + to_text(interpolate("%A%P()", [v5]))) + "", None)
    v300 = None
    v308: None
    closure7(v10, ("" + "; ") + "", None)
    v308 = None
    v317: None
    closure7(v10, ("" + "stdin") + "", None)
    v317 = None
    v325: None
    closure7(v10, ("" + " = ") + "", None)
    v325 = None
    v363: None
    closure7(v10, ("" + to_text(interpolate("%A%P()", [v6]))) + "", None)
    v363 = None
    v371: None
    closure7(v10, ("" + "; ") + "", None)
    v371 = None
    v380: None
    closure7(v10, ("" + "trace") + "", None)
    v380 = None
    v388: None
    closure7(v10, ("" + " = ") + "", None)
    v388 = None
    v399: None
    closure7(v10, ("" + ("true" if v7 else "false")) + "", None)
    v399 = None
    v407: None
    closure7(v10, ("" + "; ") + "", None)
    v407 = None
    v416: None
    closure7(v10, ("" + "working_directory") + "", None)
    v416 = None
    v424: None
    closure7(v10, ("" + " = ") + "", None)
    v424 = None
    v462: None
    closure7(v10, ("" + to_text(interpolate("%A%P()", [v8]))) + "", None)
    v462 = None
    v471: None
    closure7(v10, ("" + " }") + "", None)
    v471 = None
    v479: None
    closure7(v10, ("" + " }") + "", None)
    v479 = None
    return v10.l0


def method35(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str, v9: US5, v10: str, v11: CancellationToken | None, v12: Array[tuple[str, str]], v13: Callable[[tuple[int, str, bool]], Async[None]] | None, v14: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v15: bool, v16_1: str | None=None) -> str:
    v17_1: str = method36(v8, v9, v10, v11, v12, v13, v14, v15, v16_1)
    return method16(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "runtime.execute_with_options_async") + " / ") + v17_1) + "")


def closure18(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None, v7: US5, v8: str, unit_var: None) -> None:
    if method5(US0(1)):
        v13: None
        closure0(None, None)
        v13 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        v32: int64 | None = pattern_input[5]
        v31: Mut4 = pattern_input[4]
        v30: Mut3 = pattern_input[3]
        v29: Mut2 = pattern_input[2]
        v28: Mut1 = pattern_input[1]
        v27: Mut0 = pattern_input[0]
        method17(method35(v27, v28, v29, v30, v31, v32, method6(v27, v28, v29, v30, v31, v32), method34(), v8, v7, v0_1, v1_1, v2_1, v3, v4, v5, v6))



def method37(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None=None) -> Array[tuple[str, str]]:
    return v2_1


def closure20(unit_var: None, v0_1: Callable[[tuple[int, str, bool]], Async[None]]) -> US14:
    return US14(0, v0_1)


def method38(__unit: None=None) -> Callable[[Callable[[tuple[int, str, bool]], Async[None]]], US14]:
    def _arrow250(v: Callable[[tuple[int, str, bool]], Async[None]]) -> US14:
        return closure20(None, v)

    return _arrow250


def method39(__unit: None=None) -> str:
    v2_1: str = "Verbose".lower()
    return ("\u001b[90m" + method11(v2_1[0])) + method13()


def method40(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str) -> str:
    v9: str = method15()
    return method16(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + v8) + " / ") + v9) + "")


def closure21(v0_1: str, unit_var: None) -> None:
    if method5(US0(0)):
        v5: None
        closure0(None, None)
        v5 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        v24: int64 | None = pattern_input[5]
        v23: Mut4 = pattern_input[4]
        v22: Mut3 = pattern_input[3]
        v21: Mut2 = pattern_input[2]
        v20_1: Mut1 = pattern_input[1]
        v19_1: Mut0 = pattern_input[0]
        method17("" if (v0_1 == "") else method40(v19_1, v20_1, v21, v22, v23, v24, method6(v19_1, v20_1, v21, v22, v23, v24), method39(), v0_1))



def closure19(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None, v7: None, v8: Any, v9: None) -> None:
    def _arrow260(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4, v5: Any=v5, v6: Any=v6, v7: Any=v7, v8: Any=v8, v9: Any=v9) -> Async[None]:
        v171: str = None
        v180: bool = (v171 is None) != True
        def _arrow258(__unit: None=None) -> Async[None]:
            v194: US14 = default_arg(map(method38(), v3), US14(1))
            def _arrow252(__unit: None=None) -> Async[None]:
                v224: Async[None] = v194.fields[0]((None, v171, False))
                def _arrow251(__unit: None=None) -> Async[None]:
                    return singleton.Zero()

                return singleton.Bind(v224, _arrow251)

            def _expr253():
                return singleton.Zero()

            def _arrow257(__unit: None=None) -> Async[None]:
                v225: str = ("> " + v171) + ""
                def _arrow254(__unit: None=None) -> Async[None]:
                    v228: None
                    closure21(v225, None)
                    v228 = None
                    return singleton.Zero()

                def _arrow255(__unit: None=None) -> Async[None]:
                    v273: None
                    closure10(v225, None)
                    v273 = None
                    return singleton.Zero()

                def _arrow256(__unit: None=None) -> Async[None]:
                    return singleton.Zero()

                return singleton.Combine(_arrow254() if v5 else _arrow255(), singleton.Delay(_arrow256))

            return singleton.Combine(_arrow252() if (v194.tag == 0) else _expr253(), singleton.Delay(_arrow257))

        def _arrow259(__unit: None=None) -> Async[None]:
            return singleton.Zero()

        return singleton.Combine(_arrow258() if v180 else singleton.Zero(), singleton.Delay(_arrow259))

    start_immediate(singleton.Delay(_arrow260))


def closure22(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None, v7: None, v8: Any, v9: None) -> None:
    def _arrow270(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4, v5: Any=v5, v6: Any=v6, v7: Any=v7, v8: Any=v8, v9: Any=v9) -> Async[None]:
        v172: str = None
        v181: bool = (v172 is None) != True
        def _arrow268(__unit: None=None) -> Async[None]:
            v195: US14 = default_arg(map(method38(), v3), US14(1))
            def _arrow262(__unit: None=None) -> Async[None]:
                v225: Async[None] = v195.fields[0]((None, v172, True))
                def _arrow261(__unit: None=None) -> Async[None]:
                    return singleton.Zero()

                return singleton.Bind(v225, _arrow261)

            def _expr263():
                return singleton.Zero()

            def _arrow267(__unit: None=None) -> Async[None]:
                v226: str = ("! " + v172) + ""
                def _arrow264(__unit: None=None) -> Async[None]:
                    v229: None
                    closure21(v226, None)
                    v229 = None
                    return singleton.Zero()

                def _arrow265(__unit: None=None) -> Async[None]:
                    v274: None
                    closure10(v226, None)
                    v274 = None
                    return singleton.Zero()

                def _arrow266(__unit: None=None) -> Async[None]:
                    return singleton.Zero()

                return singleton.Combine(_arrow264() if v5 else _arrow265(), singleton.Delay(_arrow266))

            return singleton.Combine(_arrow262() if (v195.tag == 0) else _expr263(), singleton.Delay(_arrow267))

        def _arrow269(__unit: None=None) -> Async[None]:
            return singleton.Zero()

        return singleton.Combine(_arrow268() if v181 else singleton.Zero(), singleton.Delay(_arrow269))

    start_immediate(singleton.Delay(_arrow270))


def closure23(unit_var: None, v0_1: CancellationToken) -> US15:
    return US15(0, v0_1)


def method41(__unit: None=None) -> Callable[[CancellationToken], US15]:
    def _arrow271(v: CancellationToken) -> US15:
        return closure23(None, v)

    return _arrow271


def closure24(v0_1: None, unit_var: None) -> None:
    if None == False:
        pass



def method43(v0_1: Any) -> str:
    v2_1: Mut3 = Mut3(method12())
    v9: None
    closure7(v2_1, ("" + "{ ") + "", None)
    v9 = None
    v18_1: None
    closure7(v2_1, ("" + "ex") + "", None)
    v18_1 = None
    v27: None
    closure7(v2_1, ("" + " = ") + "", None)
    v27 = None
    v65: None
    closure7(v2_1, ("" + to_text(interpolate("%A%P()", [v0_1]))) + "", None)
    v65 = None
    v74: None
    closure7(v2_1, ("" + " }") + "", None)
    v74 = None
    return v2_1.l0


def method42(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: Any) -> str:
    v9: str = method43(v8)
    return method16(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "runtime.execute_with_options_async / WaitForExitAsync") + " / ") + v9) + "")


def closure25(v0_1: Any, unit_var: None) -> None:
    if method5(US0(3)):
        v5: None
        closure0(None, None)
        v5 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        v24: int64 | None = pattern_input[5]
        v23: Mut4 = pattern_input[4]
        v22: Mut3 = pattern_input[3]
        v21: Mut2 = pattern_input[2]
        v20_1: Mut1 = pattern_input[1]
        v19_1: Mut0 = pattern_input[0]
        method17(method42(v19_1, v20_1, v21, v22, v23, v24, method6(v19_1, v20_1, v21, v22, v23, v24), method10(), v0_1))



def method44(__unit: None=None) -> str:
    return "\n"


def method46(v0_1: int, v1_1: int) -> str:
    v3: Mut3 = Mut3(method12())
    v10: None
    closure7(v3, ("" + "{ ") + "", None)
    v10 = None
    v19_1: None
    closure7(v3, ("" + "exit_code") + "", None)
    v19_1 = None
    v28: None
    closure7(v3, ("" + " = ") + "", None)
    v28 = None
    v36: None
    closure7(v3, ("" + str(v0_1)) + "", None)
    v36 = None
    v45: None
    closure7(v3, ("" + "; ") + "", None)
    v45 = None
    v54: None
    closure7(v3, ("" + "output_length") + "", None)
    v54 = None
    v62: None
    closure7(v3, ("" + " = ") + "", None)
    v62 = None
    v70: None
    closure7(v3, ("" + str(v1_1)) + "", None)
    v70 = None
    v79: None
    closure7(v3, ("" + " }") + "", None)
    v79 = None
    return v3.l0


def method45(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: int, v9: int) -> str:
    v10: str = method46(v8, v9)
    return method16(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "runtime.execute_with_options_async") + " / ") + v10) + "")


def closure26(v0_1: int, v1_1: str, unit_var: None) -> None:
    if method5(US0(1)):
        v6: None
        closure0(None, None)
        v6 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut4 = pattern_input[4]
        v23: Mut3 = pattern_input[3]
        v22: Mut2 = pattern_input[2]
        v21: Mut1 = pattern_input[1]
        v20_1: Mut0 = pattern_input[0]
        method17(method45(v20_1, v21, v22, v23, v24, v25, method6(v20_1, v21, v22, v23, v24, v25), method34(), v0_1, len(v1_1)))



def method20(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None=None) -> Async[tuple[int, str]]:
    return None


def closure13(unit_var: None, v0_1: str) -> Async[tuple[int, str]]:
    return method20(v0_1, None, [], None, None, True, None)


def closure27(unit_var: None, _arg: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return method20(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6])


def closure28(unit_var: None, v0_1: Callable[[Heap0], Heap0]) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]:
    v8: Heap0 = v0_1(Heap0("", None, [], None, None, True, None))
    return (v8.l0, v8.l1, v8.l2, v8.l3, v8.l4, v8.l5, v8.l6)


def method49(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(4):
            return False

        else: 
            v19_1: US9
            if v1_1 == int64(0):
                v19_1 = US9(0, "\\")

            else: 
                v5: int64 = op_subtraction(v1_1, int64(1))
                if v5 == int64(0):
                    v19_1 = US9(0, "`")

                else: 
                    v8: int64 = op_subtraction(v5, int64(1))
                    if v8 == int64(0):
                        v19_1 = US9(0, "\"")

                    else: 
                        v11: int64 = op_subtraction(v8, int64(1))
                        if v11 == int64(0):
                            v19_1 = US9(0, " ")

                        else: 
                            v14: int64 = op_subtraction(v11, int64(1))
                            v19_1 = US9(1)




            def _arrow272(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v19_1.fields[0] if (v19_1.tag == 0) else _arrow272()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def method50(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> tuple[str, str, Any, int, int]:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v121: US7
        if "" == v1_1:
            v121 = US7(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3, v4)])))

        else: 
            v27: str = v1_1[0]
            if method49(v27, int64(0)) == False:
                v49: int = (len(v1_1) - 1) or 0
                v50: str = v1_1[1:v49 + 1]
                v55: str = v27
                v58: int = len(v55) or 0
                v59: Array[str] = fill([0] * v58, 0, v58, "")
                v60: Mut5 = Mut5(0)
                while method23(v58, v60):
                    v62: int = v60.l0 or 0
                    v63: str = v55[v62]
                    v59[v62] = v63
                    v64: int = (v62 + 1) or 0
                    v60.l0 = v64 or 0
                v65: FSharpList[str] = of_array(v59)
                pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v65, UH0(0)), v2_1, v3, v4)
                v121 = US7(0, v27, v50, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v121 = US7(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v27, to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3, v4)])))


        if v121.tag == 0:
            v0_1_mut = v0_1 + v121.fields[0]
            v1_1_mut = v121.fields[1]
            v2_1_mut = v121.fields[2]
            v3_mut = v121.fields[3]
            v4_mut = v121.fields[4]
            continue

        else: 
            return (v0_1, v1_1, v2_1, v3, v4)

        break


def method52(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(3):
            return False

        else: 
            v15: US9
            if v1_1 == int64(0):
                v15 = US9(0, "\\")

            else: 
                v5: int64 = op_subtraction(v1_1, int64(1))
                if v5 == int64(0):
                    v15 = US9(0, "`")

                else: 
                    v8: int64 = op_subtraction(v5, int64(1))
                    if v8 == int64(0):
                        v15 = US9(0, "\"")

                    else: 
                        v11: int64 = op_subtraction(v8, int64(1))
                        v15 = US9(1)



            def _arrow273(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v15.fields[0] if (v15.tag == 0) else _arrow273()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def closure30(unit_var: None, _arg: tuple[str, Any, int, int]) -> US8:
    v3: int = _arg[3] or 0
    v2_1: int = _arg[2] or 0
    v1_1: Any = _arg[1]
    v0_1: str = _arg[0]
    v128: US7
    if "" == v0_1:
        v128 = US7(1, to_text(interpolate("parsing.p_char / unexpected end of input / c: \'%P()\' / s: %A%P()", ["\\", (v1_1, v2_1, v3)])))

    else: 
        v9: str = v0_1[0]
        if v9 == "\\":
            v29: int = (len(v0_1) - 1) or 0
            v30: str = v0_1[1:v29 + 1]
            v35: str = v9
            v38: int = len(v35) or 0
            v39: Array[str] = fill([0] * v38, 0, v38, "")
            v40: Mut5 = Mut5(0)
            while method23(v38, v40):
                v42: int = v40.l0 or 0
                v43: str = v35[v42]
                v39[v42] = v43
                v44: int = (v42 + 1) or 0
                v40.l0 = v44 or 0
            v45: FSharpList[str] = of_array(v39)
            pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v45, UH0(0)), v1_1, v2_1, v3)
            v128 = US7(0, v9, v30, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v83: int = (v0_1.find("\n") - 1) or 0
            v106: int = (((len(v0_1) + 1) if (-2 == v83) else (v83 + 1)) - 1) or 0
            v128 = US7(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\\")) + "\' / line: ") + str(v2_1)) + " / col: ") + str(v3)) + "\n") + str(v1_1)) + "") + v0_1[0:v106 + 1]) + "")) + "\n") + (replicate(v3 - 1, " ") + "^")) + "\n")


    v212: US7
    if v128.tag == 0:
        v133: int = v128.fields[4] or 0
        v132: int = v128.fields[3] or 0
        v131: Any = v128.fields[2]
        v130: str = v128.fields[1]
        if "" == v130:
            v212 = US7(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v131, v132, v133)])))

        else: 
            v139: str = v130[0]
            v158: int = (len(v130) - 1) or 0
            v159: str = v130[1:v158 + 1]
            v164: str = v139
            v167: int = len(v164) or 0
            v168: Array[str] = fill([0] * v167, 0, v167, "")
            v169: Mut5 = Mut5(0)
            while method23(v167, v169):
                v171: int = v169.l0 or 0
                v172: str = v164[v171]
                v168[v171] = v172
                v173: int = (v171 + 1) or 0
                v169.l0 = v173 or 0
            v174: FSharpList[str] = of_array(v168)
            pattern_input_1: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v174, UH0(0)), v131, v132, v133)
            v212 = US7(0, v139, v159, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])


    else: 
        v212 = US7(1, v128.fields[0])

    if v212.tag == 0:
        return US8(0, "\\" + v212.fields[0], v212.fields[1], v212.fields[2], v212.fields[3], v212.fields[4])

    else: 
        return US8(1, v212.fields[0])



def closure31(unit_var: None, _arg: tuple[str, Any, int, int]) -> US8:
    v3: int = _arg[3] or 0
    v2_1: int = _arg[2] or 0
    v1_1: Any = _arg[1]
    v0_1: str = _arg[0]
    v128: US7
    if "" == v0_1:
        v128 = US7(1, to_text(interpolate("parsing.p_char / unexpected end of input / c: \'%P()\' / s: %A%P()", ["`", (v1_1, v2_1, v3)])))

    else: 
        v9: str = v0_1[0]
        if v9 == "`":
            v29: int = (len(v0_1) - 1) or 0
            v30: str = v0_1[1:v29 + 1]
            v35: str = v9
            v38: int = len(v35) or 0
            v39: Array[str] = fill([0] * v38, 0, v38, "")
            v40: Mut5 = Mut5(0)
            while method23(v38, v40):
                v42: int = v40.l0 or 0
                v43: str = v35[v42]
                v39[v42] = v43
                v44: int = (v42 + 1) or 0
                v40.l0 = v44 or 0
            v45: FSharpList[str] = of_array(v39)
            pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v45, UH0(0)), v1_1, v2_1, v3)
            v128 = US7(0, v9, v30, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v83: int = (v0_1.find("\n") - 1) or 0
            v106: int = (((len(v0_1) + 1) if (-2 == v83) else (v83 + 1)) - 1) or 0
            v128 = US7(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("`")) + "\' / line: ") + str(v2_1)) + " / col: ") + str(v3)) + "\n") + str(v1_1)) + "") + v0_1[0:v106 + 1]) + "")) + "\n") + (replicate(v3 - 1, " ") + "^")) + "\n")


    v212: US7
    if v128.tag == 0:
        v133: int = v128.fields[4] or 0
        v132: int = v128.fields[3] or 0
        v131: Any = v128.fields[2]
        v130: str = v128.fields[1]
        if "" == v130:
            v212 = US7(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v131, v132, v133)])))

        else: 
            v139: str = v130[0]
            v158: int = (len(v130) - 1) or 0
            v159: str = v130[1:v158 + 1]
            v164: str = v139
            v167: int = len(v164) or 0
            v168: Array[str] = fill([0] * v167, 0, v167, "")
            v169: Mut5 = Mut5(0)
            while method23(v167, v169):
                v171: int = v169.l0 or 0
                v172: str = v164[v171]
                v168[v171] = v172
                v173: int = (v171 + 1) or 0
                v169.l0 = v173 or 0
            v174: FSharpList[str] = of_array(v168)
            pattern_input_1: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v174, UH0(0)), v131, v132, v133)
            v212 = US7(0, v139, v159, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])


    else: 
        v212 = US7(1, v128.fields[0])

    if v212.tag == 0:
        return US8(0, "`" + v212.fields[0], v212.fields[1], v212.fields[2], v212.fields[3], v212.fields[4])

    else: 
        return US8(1, v212.fields[0])



def method53(v0_1_mut: str, v1_1_mut: Any, v2_1_mut: int, v3_mut: int, v4_mut: UH3) -> US8:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        if v4.tag == 0:
            return US8(1, "parsing.choice / no parsers succeeded")

        else: 
            v9: US8 = v4.fields[0]((v0_1, v1_1, v2_1, v3))
            if v9.tag == 0:
                return v9

            else: 
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_mut = v3
                v4_mut = v4.fields[1]
                continue


        break


def method54(v0_1_mut: UH2, v1_1_mut: UH2) -> UH2:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v0_1.tag == 0:
            return v1_1

        else: 
            v0_1_mut = v0_1.fields[1]
            v1_1_mut = UH2(1, v0_1.fields[0], v1_1)
            continue

        break


def method51(v0_1_mut: UH2, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US17:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v115: US7
        if "" == v1_1:
            v115 = US7(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\""])), (v2_1, v3, v4)])))

        else: 
            v24: str = v1_1[0]
            if method52(v24, int64(0)) == False:
                v46: int = (len(v1_1) - 1) or 0
                v47: str = v1_1[1:v46 + 1]
                v52: str = v24
                v55: int = len(v52) or 0
                v56: Array[str] = fill([0] * v55, 0, v55, "")
                v57: Mut5 = Mut5(0)
                while method23(v55, v57):
                    v59: int = v57.l0 or 0
                    v60: str = v52[v59]
                    v56[v59] = v60
                    v61: int = (v59 + 1) or 0
                    v57.l0 = v61 or 0
                v62: FSharpList[str] = of_array(v56)
                pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v62, UH0(0)), v2_1, v3, v4)
                v115 = US7(0, v24, v47, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v115 = US7(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v24, to_array(of_array(["\\", "`", "\""])), (v2_1, v3, v4)])))


        v129: US8 = US8(0, v115.fields[0], v115.fields[1], v115.fields[2], v115.fields[3], v115.fields[4]) if (v115.tag == 0) else US8(1, v115.fields[0])
        def v136(_arg10: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> US8:
            return closure30(None, _arg10)

        def v137(_arg10_1: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> US8:
            return closure31(None, _arg10_1)

        v143: US8 = v129 if (v129.tag == 0) else method53(v1_1, v2_1, v3, v4, UH3(1, v136, UH3(1, v137, UH3(0))))
        if v143.tag == 0:
            v0_1_mut = UH2(1, v143.fields[0], v0_1)
            v1_1_mut = v143.fields[1]
            v2_1_mut = v143.fields[2]
            v3_mut = v143.fields[3]
            v4_mut = v143.fields[4]
            continue

        else: 
            return US17(0, method54(v0_1, UH2(0)), v1_1, v2_1, v3, v4)

        break


def method55(v0_1: UH2, v1_1: FSharpList[str]) -> FSharpList[str]:
    if v0_1.tag == 0:
        return v1_1

    else: 
        return cons(v0_1.fields[0], method55(v0_1.fields[1], v1_1))



def method56(v0_1_mut: UH2, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US17:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v115: US7
        if "" == v1_1:
            v115 = US7(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\""])), (v2_1, v3, v4)])))

        else: 
            v24: str = v1_1[0]
            if method52(v24, int64(0)) == False:
                v46: int = (len(v1_1) - 1) or 0
                v47: str = v1_1[1:v46 + 1]
                v52: str = v24
                v55: int = len(v52) or 0
                v56: Array[str] = fill([0] * v55, 0, v55, "")
                v57: Mut5 = Mut5(0)
                while method23(v55, v57):
                    v59: int = v57.l0 or 0
                    v60: str = v52[v59]
                    v56[v59] = v60
                    v61: int = (v59 + 1) or 0
                    v57.l0 = v61 or 0
                v62: FSharpList[str] = of_array(v56)
                pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v62, UH0(0)), v2_1, v3, v4)
                v115 = US7(0, v24, v47, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v115 = US7(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v24, to_array(of_array(["\\", "`", "\""])), (v2_1, v3, v4)])))


        v129: US8 = US8(0, v115.fields[0], v115.fields[1], v115.fields[2], v115.fields[3], v115.fields[4]) if (v115.tag == 0) else US8(1, v115.fields[0])
        if v129.tag == 0:
            v0_1_mut = UH2(1, v129.fields[0], v0_1)
            v1_1_mut = v129.fields[1]
            v2_1_mut = v129.fields[2]
            v3_mut = v129.fields[3]
            v4_mut = v129.fields[4]
            continue

        else: 
            return US17(0, method54(v0_1, UH2(0)), v1_1, v2_1, v3, v4)

        break


def method48(v0_1_mut: UH2, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US17:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v5: bool = "" == v1_1
        v121: US7
        if v5:
            v121 = US7(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3, v4)])))

        else: 
            v27: str = v1_1[0]
            if method49(v27, int64(0)) == False:
                v49: int = (len(v1_1) - 1) or 0
                v50: str = v1_1[1:v49 + 1]
                v55: str = v27
                v58: int = len(v55) or 0
                v59: Array[str] = fill([0] * v58, 0, v58, "")
                v60: Mut5 = Mut5(0)
                while method23(v58, v60):
                    v62: int = v60.l0 or 0
                    v63: str = v55[v62]
                    v59[v62] = v63
                    v64: int = (v62 + 1) or 0
                    v60.l0 = v64 or 0
                v65: FSharpList[str] = of_array(v59)
                pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v65, UH0(0)), v2_1, v3, v4)
                v121 = US7(0, v27, v50, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v121 = US7(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v27, to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3, v4)])))


        v140: US8
        if v121.tag == 0:
            pattern_input_1: tuple[str, str, Any, int, int] = method50(v121.fields[0], v121.fields[1], v121.fields[2], v121.fields[3], v121.fields[4])
            v140 = US8(0, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4])

        else: 
            v140 = US8(1, v121.fields[0])

        v517: US8
        if v140.tag == 0:
            v517 = v140

        else: 
            v270: US7
            if v5:
                v270 = US7(1, to_text(interpolate("parsing.p_char / unexpected end of input / c: \'%P()\' / s: %A%P()", ["\"", (v2_1, v3, v4)])))

            else: 
                v151: str = v1_1[0]
                if v151 == "\"":
                    v171: int = (len(v1_1) - 1) or 0
                    v172: str = v1_1[1:v171 + 1]
                    v177: str = v151
                    v180: int = len(v177) or 0
                    v181: Array[str] = fill([0] * v180, 0, v180, "")
                    v182: Mut5 = Mut5(0)
                    while method23(v180, v182):
                        v184: int = v182.l0 or 0
                        v185: str = v177[v184]
                        v181[v184] = v185
                        v186: int = (v184 + 1) or 0
                        v182.l0 = v186 or 0
                    v187: FSharpList[str] = of_array(v181)
                    pattern_input_2: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v187, UH0(0)), v2_1, v3, v4)
                    v270 = US7(0, v151, v172, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2])

                else: 
                    v225: int = (v1_1.find("\n") - 1) or 0
                    v248: int = (((len(v1_1) + 1) if (-2 == v225) else (v225 + 1)) - 1) or 0
                    v270 = US7(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\"")) + "\' / line: ") + str(v3)) + " / col: ") + str(v4)) + "\n") + str(v2_1)) + "") + v1_1[0:v248 + 1]) + "")) + "\n") + (replicate(v4 - 1, " ") + "^")) + "\n")


            v454: US8
            if v270.tag == 0:
                v275: int = v270.fields[4] or 0
                v274: int = v270.fields[3] or 0
                v273: Any = v270.fields[2]
                v272: str = v270.fields[1]
                v277: US17 = method51(UH2(0), v272, v273, v274, v275)
                v302: US8
                if v277.tag == 0:
                    v284: FSharpList[str] = method55(v277.fields[0], empty())
                    def _arrow275(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> IEnumerable_1[str]:
                        def _arrow274(i: int) -> str:
                            return item(i, v284)

                        return map_1(_arrow274, range_big_int(0, 1, length(v284) - 1))

                    v302 = US8(0, join("", delay(_arrow275)), v277.fields[1], v277.fields[2], v277.fields[3], v277.fields[4])

                else: 
                    v302 = US8(1, v277.fields[0])

                if v302.tag == 0:
                    v307: int = v302.fields[4] or 0
                    v306: int = v302.fields[3] or 0
                    v305: Any = v302.fields[2]
                    v304: str = v302.fields[1]
                    v432: US7
                    if "" == v304:
                        v432 = US7(1, to_text(interpolate("parsing.p_char / unexpected end of input / c: \'%P()\' / s: %A%P()", ["\"", (v305, v306, v307)])))

                    else: 
                        v313: str = v304[0]
                        if v313 == "\"":
                            v333: int = (len(v304) - 1) or 0
                            v334: str = v304[1:v333 + 1]
                            v339: str = v313
                            v342: int = len(v339) or 0
                            v343: Array[str] = fill([0] * v342, 0, v342, "")
                            v344: Mut5 = Mut5(0)
                            while method23(v342, v344):
                                v346: int = v344.l0 or 0
                                v347: str = v339[v346]
                                v343[v346] = v347
                                v348: int = (v346 + 1) or 0
                                v344.l0 = v348 or 0
                            v349: FSharpList[str] = of_array(v343)
                            pattern_input_3: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v349, UH0(0)), v305, v306, v307)
                            v432 = US7(0, v313, v334, pattern_input_3[0], pattern_input_3[1], pattern_input_3[2])

                        else: 
                            v387: int = (v304.find("\n") - 1) or 0
                            v410: int = (((len(v304) + 1) if (-2 == v387) else (v387 + 1)) - 1) or 0
                            v432 = US7(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\"")) + "\' / line: ") + str(v306)) + " / col: ") + str(v307)) + "\n") + str(v305)) + "") + v304[0:v410 + 1]) + "")) + "\n") + (replicate(v307 - 1, " ") + "^")) + "\n")


                    v454 = US8(0, v302.fields[0], v432.fields[1], v432.fields[2], v432.fields[3], v432.fields[4]) if (v432.tag == 0) else US8(1, to_text(interpolate("parsing.between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v432.fields[0], (v1_1, v2_1, v3, v4), (v272, v273, v274, v275), (v304, v305, v306, v307)])))

                else: 
                    v454 = US8(1, "parsing.between / expected content")


            else: 
                v454 = US8(1, v270.fields[0])

            if v454.tag == 0:
                v517 = v454

            else: 
                def v461(_arg10: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> US8:
                    return closure30(None, _arg10)

                def v462(_arg10_1: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> US8:
                    return closure31(None, _arg10_1)

                v466: US8 = method53(v1_1, v2_1, v3, v4, UH3(1, v461, UH3(1, v462, UH3(0))))
                v477: US8 = US8(0, "", v466.fields[1], v466.fields[2], v466.fields[3], v466.fields[4]) if (v466.tag == 0) else US8(1, v466.fields[0])
                v488: US17 = method56(UH2(0), v477.fields[1], v477.fields[2], v477.fields[3], v477.fields[4]) if (v477.tag == 0) else US17(1, v477.fields[0])
                if v488.tag == 0:
                    v495: FSharpList[str] = method55(v488.fields[0], empty())
                    def _arrow277(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> IEnumerable_1[str]:
                        def _arrow276(i_1: int) -> str:
                            return item(i_1, v495)

                        return map_1(_arrow276, range_big_int(0, 1, length(v495) - 1))

                    v517 = US8(0, join("", delay(_arrow277)), v488.fields[1], v488.fields[2], v488.fields[3], v488.fields[4])

                else: 
                    v517 = US8(1, v488.fields[0])



        if v517.tag == 0:
            v522: int = v517.fields[4] or 0
            v521: int = v517.fields[3] or 0
            v520: Any = v517.fields[2]
            v519: str = v517.fields[1]
            v518: str = v517.fields[0]
            v524: int = method32(v519, 0) or 0
            v552: US10
            if 0 == v524:
                v552 = US10(1, "parsing.spaces1 / expected at least one space")

            else: 
                v546: int = (len(v519) - 1) or 0
                v552 = US10(0, v519[v524:v546 + 1], v520, v521, v522)

            if v552.tag == 0:
                v0_1_mut = UH2(1, v518, v0_1)
                v1_1_mut = v552.fields[0]
                v2_1_mut = v552.fields[1]
                v3_mut = v552.fields[2]
                v4_mut = v552.fields[3]
                continue

            else: 
                return US17(0, method54(v0_1, UH2(1, v518, UH2(0))), v519, v520, v521, v522)


        else: 
            return US17(0, method54(v0_1, UH2(0)), v1_1, v2_1, v3, v4)

        break


def method47(v0_1: str) -> US16:
    _v0: (str | None) | None = None
    _v0 = some(v0_1)
    def _arrow278(__unit: None=None, v0_1: Any=v0_1) -> str | None:
        raise Exception("optionm\'.of_obj / _v0=None")

    v18_1: US17 = method48(UH2(0), default_arg(_arrow278() if (_v0 is None) else value_12(_v0), ""), StringBuilder__ctor_Z721C83C5(method22()), 1, 1)
    if v18_1.tag == 0:
        return US16(0, to_array(method55(v18_1.fields[0], empty())))

    else: 
        return US16(1, v18_1.fields[0])



def closure29(unit_var: None, v0_1: str) -> FSharpResult_2[Array[str], str]:
    v1_1: US16 = method47(v0_1)
    if v1_1.tag == 0:
        return FSharpResult_2(0, v1_1.fields[0])

    else: 
        return FSharpResult_2(1, v1_1.fields[0])



v0: None = None

def _arrow279(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow279

def _expr280():
    v1(None)
    return v0


v2: None = _expr280()

def _arrow281(__unit: None=None) -> None:
    closure3(None, None)


v16: Callable[[], None] = _arrow281

def current_process_kill(__unit: None=None) -> None:
    v16(None)


def _arrow282(v: str) -> Async[tuple[int, str]]:
    return closure13(None, v)


v17: Callable[[str], Async[tuple[int, str]]] = _arrow282

def execute_async(x: str) -> Async[tuple[int, str]]:
    return v17(x)


def _arrow283(_arg10: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return closure27(None, _arg10)


v18: Callable[[tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]], Async[tuple[int, str]]] = _arrow283

def execute_with_options_async(x: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return v18(x)


def _arrow284(v: Callable[[Heap0], Heap0]) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]:
    return closure28(None, v)


v19: Callable[[Callable[[Heap0], Heap0]], tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]] = _arrow284

def execution_options(x: Callable[[Heap0], Heap0]) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]:
    return v19(x)


def _arrow286(v: str) -> FSharpResult_2[Array[str], str]:
    return closure29(None, v)


v20: Callable[[str], FSharpResult_2[Array[str], str]] = _arrow286

def split_args(x: str) -> FSharpResult_2[Array[str], str]:
    return v20(x)


