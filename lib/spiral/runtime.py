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
    l4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None
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

def method0(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method2(__unit: None=None) -> str:
    return ""


def method1(v0: str) -> str:
    _v3: str | None = None
    v54: IOsEnviron = os
    v56: Any = v54.environ
    _v66: (str | None) | None = None
    x: str | None = v56.get(v0)
    _v66 = some(x)
    v77_1: str | None
    if _v66 is None:
        raise Exception("optionm\'.of_obj / _v66=None")

    else: 
        v77_1 = value_12(_v66)

    _v86: FSharpRef[US3 | None] = FSharpRef(None)
    x_4: US3 | None
    if v77_1 is None:
        x_4 = None

    else: 
        x_2: str = v77_1
        def x_3(__unit: None=None, v0: Any=v0) -> US3:
            return US3(0, x_2)

        x_4 = x_3(None)

    _v86.contents = x_4
    v113: US3 = default_arg(_v86.contents, US3(1))
    x_5: str = v113.fields[0] if (v113.tag == 0) else ""
    _v3 = x_5
    if _v3 is None:
        raise Exception("base.run_target / _v3=None")

    else: 
        return _v3



def method3(__unit: None=None) -> str:
    return "AUTOMATION"


def closure1(unit_var: None, v0: str) -> None:
    pass


def closure0(unit_var: None, v0: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
    _v3: tuple[US1, US2] | None = None
    v167: str = method1(method0())
    v173: US1 = US1(0, US0(0)) if ("Verbose" == v167) else US1(1)
    def _arrow183(__unit: None=None, unit_var: Any=unit_var, v0: Any=v0) -> US1:
        v181: US1 = US1(0, US0(1)) if ("Debug" == v167) else US1(1)
        if v181.tag == 0:
            return US1(0, v181.fields[0])

        else: 
            v189: US1 = US1(0, US0(2)) if ("Info" == v167) else US1(1)
            if v189.tag == 0:
                return US1(0, v189.fields[0])

            else: 
                v197: US1 = US1(0, US0(3)) if ("Warning" == v167) else US1(1)
                if v197.tag == 0:
                    return US1(0, v197.fields[0])

                else: 
                    v205: US1 = US1(0, US0(4)) if ("Critical" == v167) else US1(1)
                    return US1(0, v205.fields[0]) if (v205.tag == 0) else US1(1)




    x: tuple[US1, US2] = (US1(0, v173.fields[0]) if (v173.tag == 0) else _arrow183(), US2(0, ticks_1(now())) if (method1(method3()) == "True") else US2(1))
    _v3 = x
    pattern_input: tuple[US1, US2]
    if _v3 is None:
        raise Exception("base.run_target / _v3=None")

    else: 
        pattern_input = _v3

    v325: US2 = pattern_input[1]
    v324: US1 = pattern_input[0]
    def v417(v: str, unit_var: Any=unit_var, v0: Any=v0) -> None:
        closure1(None, v)

    return (Mut0(int64(0)), Mut1(v417), Mut2(True), Mut3(v324.fields[0] if (v324.tag == 0) else v0), v325.fields[0] if (v325.tag == 0) else None)


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


def method9(v0: Mut4) -> None:
    pass


def closure6(v0: US0, v1: Callable[[], str], v2: Callable[[], None], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_12(State_trace_state())
    v18: int64 | None = pattern_input[4]
    _v35: str | None = None
    _v480: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v18 is None:
        x_2 = None

    else: 
        x: int64 = v18
        def x_1(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v480.contents = x_2
    v507: US2 = default_arg(_v480.contents, US2(1))
    def _arrow184(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2, unit_var: Any=unit_var) -> Any:
        v539: Any = create(op_subtraction(ticks_1(now()), v507.fields[0]))
        return create_1(1, 1, 1, hours(v539), minutes(v539), seconds(v539), milliseconds(v539))

    x_3: str = to_string(_arrow184() if (v507.tag == 0) else now(), method7())
    _v35 = x_3
    v772: str
    if _v35 is None:
        raise Exception("base.run_target / _v35=None")

    else: 
        v772 = _v35

    v931: US3 = US3(0, "Verbose") if (True if (v0.tag == 0) else False) else US3(1)
    v980: US3
    if v931.tag == 0:
        v980 = US3(0, v931.fields[0])

    else: 
        v940: US3 = US3(0, "Debug") if (True if (v0.tag == 1) else False) else US3(1)
        if v940.tag == 0:
            v980 = US3(0, v940.fields[0])

        else: 
            v949: US3 = US3(0, "Info") if (True if (v0.tag == 2) else False) else US3(1)
            if v949.tag == 0:
                v980 = US3(0, v949.fields[0])

            else: 
                v958: US3 = US3(0, "Warning") if (True if (v0.tag == 3) else False) else US3(1)
                if v958.tag == 0:
                    v980 = US3(0, v958.fields[0])

                else: 
                    v967: US3 = US3(0, "Critical") if (True if (v0.tag == 4) else False) else US3(1)
                    v980 = US3(0, v967.fields[0]) if (v967.tag == 0) else US3(1)




    v984: str
    if v980.tag == 0:
        v984 = v980.fields[0]

    else: 
        raise Exception("Option does not have a value.")

    v997: str = pad_left(v984.lower(), 7, " ")
    _v1029: str | None = None
    x_5: str = (("\u001b[94m" if (v0.tag == 1) else ("\u001b[92m" if (v0.tag == 2) else ("\u001b[90m" if (v0.tag == 0) else ("\u001b[93m" if (v0.tag == 3) else "\u001b[91m")))) + v997) + method8()
    _v1029 = x_5
    v1141: str
    if _v1029 is None:
        raise Exception("base.run_target / _v1029=None")

    else: 
        v1141 = _v1029

    v1160: int64 = pattern_input[0].l0
    v2(None)
    v1162: Mut4 = Mut4("")
    method9(v1162)
    v1163: str = v1162.l0
    return trim_end(trim_start(((((((((("" + v772) + " ") + v1141) + " #") + str(v1160)) + " ") + v1(None)) + " / ") + v1163) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method10(v0: US0, v1: Callable[[], str]) -> None:
    def v4(v: US0, v0: Any=v0, v1: Any=v1) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
        return closure0(None, v)

    if State_trace_state() is None:
        State_trace_state(v4(US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_12(State_trace_state())
    v13: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v4(US0(0)))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_12(State_trace_state())
    v61: US0 = pattern_input_1[3].l0
    class ObjectExpr185:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr186:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (find(v0, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr185())) >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr186()))):
        v69_1: int64 = op_addition(v13.l0, int64(1))
        v13.l0 = v69_1
        v72: str = ("" + v1(None)) + ""
        _v81: None | None = None
        print(v72)
        _v81 = some(None)
        if _v81 is None:
            raise Exception("base.run_target / _v81=None")

        else: 
            value_12(_v81)

        pattern_input[1].l0(v72)



def method4(v0: US0, v1: Callable[[], str], v2: Callable[[], None]) -> None:
    def v3(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2) -> str:
        return closure6(v0, v1, v2, None)

    method10(v0, v3)


def closure7(unit_var: None, unit_var_1: None) -> str:
    return "runtime.current_process_kill / exiting... 2"


def closure8(unit_var: None, unit_var_1: None) -> str:
    return "runtime.current_process_kill / exiting... 1"


def closure3(unit_var: None, unit_var_1: None) -> None:
    _v2: None | None = None
    _v2 = some(None)
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        value_12(_v2)



def closure2(unit_var: None, unit_var_1: None) -> None:
    _v2: None | None = None
    _v2 = some(None)
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        value_12(_v2)



def method13(v0: int, v1: Mut5) -> bool:
    return v1.l0 < v0


def closure12(v0: str, v1: UH0) -> UH0:
    return UH0(1, v0, v1)


def closure11(unit_var: None, v0: str) -> Callable[[UH0], UH0]:
    def _arrow187(v: UH0, unit_var: Any=unit_var, v0: Any=v0) -> UH0:
        return closure12(v0, v)

    return _arrow187


def method14(__unit: None=None) -> Callable[[str, UH0], UH0]:
    def _arrow188(v: str) -> Callable[[UH0], UH0]:
        return closure11(None, v)

    return _arrow188


def method15(v0_mut: UH0, v1_mut: Any, v2_mut: int, v3_mut: int) -> tuple[Any, int, int]:
    while True:
        (v0, v1, v2, v3) = (v0_mut, v1_mut, v2_mut, v3_mut)
        if v0.tag == 0:
            return (v1, v2, v3)

        else: 
            v4: str = v0.fields[0]
            v6: bool = "\n" == v4
            pattern_input: tuple[int, int] = ((v2 + 1, 1)) if v6 else ((v2, v3 + 1))
            v0_mut = v0.fields[1]
            def _arrow189(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2, v3: Any=v3) -> Any:
                v12: Any = StringBuilder__Clear(v1)
                return v1

            def _arrow190(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2, v3: Any=v3) -> Any:
                v24: Any = StringBuilder__Append_Z721C83C5(v1, v4)
                return v1

            v1_mut = _arrow189() if v6 else _arrow190()
            v2_mut = pattern_input[0]
            v3_mut = pattern_input[1]
            continue

        break


def closure10(unit_var: None, _arg: tuple[str, Any, int, int]) -> US5:
    v3: int = _arg[3] or 0
    v2: int = _arg[2] or 0
    v1: Any = _arg[1]
    v0: str = _arg[0]
    if "" == v0:
        return US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v1, v2, v3)])))

    else: 
        v7: str = v0[0]
        if v7 == "\"":
            v10: int = len(v0) or 0
            v15: str = v0[1:v10 + 1]
            v19: str = v7
            v26: int = len(v19) or 0
            v27: Array[str] = fill([0] * v26, 0, v26, "")
            v28: Mut5 = Mut5(0)
            while method13(v26, v28):
                v30: int = v28.l0 or 0
                v31: str = v19[v30]
                v27[v30] = v31
                v32: int = (v30 + 1) or 0
                v28.l0 = v32 or 0
            v33: FSharpList[str] = of_array(v27)
            pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v33, UH0(0)), v1, v2, v3)
            return US5(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v55: int = len(v0) or 0
            v58: int = (v0.find("\n") - 1) or 0
            v60: int = (v55 if (-2 == v58) else v58) or 0
            return US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\"")) + "\' / line: ") + str(v2)) + " / col: ") + str(v3)) + "\n") + str(v1)) + "") + v0[0:v60 + 1]) + "")) + "\n") + (replicate(v3 - 1, " ") + "^")) + "\n")




def closure13(unit_var: None, _arg: tuple[str, Any, int, int]) -> US5:
    v3: int = _arg[3] or 0
    v2: int = _arg[2] or 0
    v1: Any = _arg[1]
    v0: str = _arg[0]
    if "" == v0:
        return US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v1, v2, v3)])))

    else: 
        v7: str = v0[0]
        if v7 == "\'":
            v10: int = len(v0) or 0
            v15: str = v0[1:v10 + 1]
            v19: str = v7
            v26: int = len(v19) or 0
            v27: Array[str] = fill([0] * v26, 0, v26, "")
            v28: Mut5 = Mut5(0)
            while method13(v26, v28):
                v30: int = v28.l0 or 0
                v31: str = v19[v30]
                v27[v30] = v31
                v32: int = (v30 + 1) or 0
                v28.l0 = v32 or 0
            v33: FSharpList[str] = of_array(v27)
            pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v33, UH0(0)), v1, v2, v3)
            return US5(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v55: int = len(v0) or 0
            v58: int = (v0.find("\n") - 1) or 0
            v60: int = (v55 if (-2 == v58) else v58) or 0
            return US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\'")) + "\' / line: ") + str(v2)) + " / col: ") + str(v3)) + "\n") + str(v1)) + "") + v0[0:v60 + 1]) + "")) + "\n") + (replicate(v3 - 1, " ") + "^")) + "\n")




def method16(v0_mut: str, v1_mut: Any, v2_mut: UH1) -> US5:
    while True:
        (v0, v1, v2) = (v0_mut, v1_mut, v2_mut)
        if v2.tag == 0:
            return US5(1, "choice / no parsers succeeded")

        else: 
            v7: US5 = v2.fields[0]((v0, v1, 1, 1))
            if v7.tag == 0:
                return v7

            else: 
                v0_mut = v0
                v1_mut = v1
                v2_mut = v2.fields[1]
                continue


        break


def method17(v0_mut: str, v1_mut: int64) -> bool:
    while True:
        (v0, v1) = (v0_mut, v1_mut)
        if v1 >= int64(2):
            return False

        else: 
            v11: US7
            if v1 == int64(0):
                v11 = US7(0, "\"")

            else: 
                v5: int64 = op_subtraction(v1, int64(1))
                if v5 == int64(0):
                    v11 = US7(0, "\'")

                else: 
                    v8: int64 = op_subtraction(v5, int64(1))
                    v11 = US7(1)


            def _arrow191(__unit: None=None, v0: Any=v0, v1: Any=v1) -> str:
                raise Exception("Option does not have a value.")

            if v0 == (v11.fields[0] if (v11.tag == 0) else _arrow191()):
                return True

            else: 
                v0_mut = v0
                v1_mut = op_addition(v1, int64(1))
                continue


        break


def method18(v0_mut: str, v1_mut: str, v2_mut: Any, v3_mut: int, v4_mut: int) -> US6:
    while True:
        (v0, v1, v2, v3, v4) = (v0_mut, v1_mut, v2_mut, v3_mut, v4_mut)
        v118: US5
        if "" == v1:
            v118 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'"])), (v2, v3, v4)])))

        else: 
            v37: str = v1[0]
            v39: int = len(v1) or 0
            v44: str = v1[1:v39 + 1]
            if method17(v37, int64(0)) == False:
                v51: str = v37
                v58: int = len(v51) or 0
                v59: Array[str] = fill([0] * v58, 0, v58, "")
                v60: Mut5 = Mut5(0)
                while method13(v58, v60):
                    v62: int = v60.l0 or 0
                    v63: str = v51[v62]
                    v59[v62] = v63
                    v64: int = (v62 + 1) or 0
                    v60.l0 = v64 or 0
                v65: FSharpList[str] = of_array(v59)
                pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v65, UH0(0)), v2, v3, v4)
                v118 = US5(0, v37, v44, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v118 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v37, to_array(of_array(["\"", "\'"])), (v2, v3, v4)])))


        v130: US5
        if v118.tag == 0:
            v119: str = v118.fields[0]
            v130 = US5(0, "/" if ("\\" == v119) else v119, v118.fields[1], v118.fields[2], v118.fields[3], v118.fields[4])

        else: 
            v130 = US5(1, v118.fields[0])

        if v130.tag == 0:
            v0_mut = v0 + v130.fields[0]
            v1_mut = v130.fields[1]
            v2_mut = v130.fields[2]
            v3_mut = v130.fields[3]
            v4_mut = v130.fields[4]
            continue

        else: 
            return US6(0, v0, v1, v2, v3, v4)

        break


def method19(v0_mut: str, v1_mut: Any, v2_mut: int, v3_mut: int, v4_mut: UH1) -> US5:
    while True:
        (v0, v1, v2, v3, v4) = (v0_mut, v1_mut, v2_mut, v3_mut, v4_mut)
        if v4.tag == 0:
            return US5(1, "choice / no parsers succeeded")

        else: 
            v9: US5 = v4.fields[0]((v0, v1, v2, v3))
            if v9.tag == 0:
                return v9

            else: 
                v0_mut = v0
                v1_mut = v1
                v2_mut = v2
                v3_mut = v3
                v4_mut = v4.fields[1]
                continue


        break


def method20(v0_mut: str, v1_mut: int64) -> bool:
    while True:
        (v0, v1) = (v0_mut, v1_mut)
        if v1 >= int64(3):
            return False

        else: 
            v15: US7
            if v1 == int64(0):
                v15 = US7(0, "\"")

            else: 
                v5: int64 = op_subtraction(v1, int64(1))
                if v5 == int64(0):
                    v15 = US7(0, "\'")

                else: 
                    v8: int64 = op_subtraction(v5, int64(1))
                    if v8 == int64(0):
                        v15 = US7(0, " ")

                    else: 
                        v11: int64 = op_subtraction(v8, int64(1))
                        v15 = US7(1)



            def _arrow192(__unit: None=None, v0: Any=v0, v1: Any=v1) -> str:
                raise Exception("Option does not have a value.")

            if v0 == (v15.fields[0] if (v15.tag == 0) else _arrow192()):
                return True

            else: 
                v0_mut = v0
                v1_mut = op_addition(v1, int64(1))
                continue


        break


def method21(v0_mut: str, v1_mut: str, v2_mut: Any, v3_mut: int, v4_mut: int) -> US6:
    while True:
        (v0, v1, v2, v3, v4) = (v0_mut, v1_mut, v2_mut, v3_mut, v4_mut)
        v136: US5
        if "" == v1:
            v136 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'", " "])), (v2, v3, v4)])))

        else: 
            v46: str = v1[0]
            v48: int = len(v1) or 0
            v53: str = v1[1:v48 + 1]
            if method20(v46, int64(0)) == False:
                v60: str = v46
                v67: int = len(v60) or 0
                v68_1: Array[str] = fill([0] * v67, 0, v67, "")
                v69_1: Mut5 = Mut5(0)
                while method13(v67, v69_1):
                    v71: int = v69_1.l0 or 0
                    v72: str = v60[v71]
                    v68_1[v71] = v72
                    v73: int = (v71 + 1) or 0
                    v69_1.l0 = v73 or 0
                v74: FSharpList[str] = of_array(v68_1)
                pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v74, UH0(0)), v2, v3, v4)
                v136 = US5(0, v46, v53, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v136 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v46, to_array(of_array(["\"", "\'", " "])), (v2, v3, v4)])))


        v148: US5
        if v136.tag == 0:
            v137: str = v136.fields[0]
            v148 = US5(0, "/" if ("\\" == v137) else v137, v136.fields[1], v136.fields[2], v136.fields[3], v136.fields[4])

        else: 
            v148 = US5(1, v136.fields[0])

        if v148.tag == 0:
            v0_mut = v0 + v148.fields[0]
            v1_mut = v148.fields[1]
            v2_mut = v148.fields[2]
            v3_mut = v148.fields[3]
            v4_mut = v148.fields[4]
            continue

        else: 
            return US6(0, v0, v1, v2, v3, v4)

        break


def method22(v0_mut: str, v1_mut: int) -> int:
    while True:
        (v0, v1) = (v0_mut, v1_mut)
        if v1 >= len(v0):
            return v1

        elif v0[v1] == " ":
            v0_mut = v0
            v1_mut = v1 + 1
            continue

        else: 
            return v1

        break


def method23(v0_mut: str, v1_mut: str, v2_mut: Any, v3_mut: int, v4_mut: int) -> US6:
    while True:
        (v0, v1, v2, v3, v4) = (v0_mut, v1_mut, v2_mut, v3_mut, v4_mut)
        v54: US5
        if "" == v1:
            v54 = US5(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v2, v3, v4)])))

        else: 
            v8: str = v1[0]
            v10: int = len(v1) or 0
            v15: str = v1[1:v10 + 1]
            v19: str = v8
            v26: int = len(v19) or 0
            v27: Array[str] = fill([0] * v26, 0, v26, "")
            v28: Mut5 = Mut5(0)
            while method13(v26, v28):
                v30: int = v28.l0 or 0
                v31: str = v19[v30]
                v27[v30] = v31
                v32: int = (v30 + 1) or 0
                v28.l0 = v32 or 0
            v33: FSharpList[str] = of_array(v27)
            pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v33, UH0(0)), v2, v3, v4)
            v54 = US5(0, v8, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        if v54.tag == 0:
            v0_mut = v0 + v54.fields[0]
            v1_mut = v54.fields[1]
            v2_mut = v54.fields[2]
            v3_mut = v54.fields[3]
            v4_mut = v54.fields[4]
            continue

        else: 
            return US6(0, v0, v1, v2, v3, v4)

        break


def method12(v0: str) -> US4:
    _v0: (str | None) | None = None
    _v0 = some(v0)
    def _arrow193(__unit: None=None, v0: Any=v0) -> str | None:
        raise Exception("optionm\'.of_obj / _v0=None")

    v15: str = default_arg(_arrow193() if (_v0 is None) else value_12(_v0), "")
    v23: Any = StringBuilder__ctor_Z721C83C5("")
    def v24(_arg10: tuple[str, Any, int, int], v0: Any=v0) -> US5:
        return closure10(None, _arg10)

    def v25(_arg10_1: tuple[str, Any, int, int], v0: Any=v0) -> US5:
        return closure13(None, _arg10_1)

    v29: US5 = method16(v15, v23, UH1(1, v24, UH1(1, v25, UH1(0))))
    v219: US6
    if v29.tag == 0:
        v34: int = v29.fields[4] or 0
        v33: int = v29.fields[3] or 0
        v32: Any = v29.fields[2]
        v31: str = v29.fields[1]
        v148: US5
        if "" == v31:
            v148 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'"])), (v32, v33, v34)])))

        else: 
            v67: str = v31[0]
            v69_1: int = len(v31) or 0
            v74: str = v31[1:v69_1 + 1]
            if method17(v67, int64(0)) == False:
                v81: str = v67
                v88: int = len(v81) or 0
                v89: Array[str] = fill([0] * v88, 0, v88, "")
                v90: Mut5 = Mut5(0)
                while method13(v88, v90):
                    v92: int = v90.l0 or 0
                    v93: str = v81[v92]
                    v89[v92] = v93
                    v94: int = (v92 + 1) or 0
                    v90.l0 = v94 or 0
                v95: FSharpList[str] = of_array(v89)
                pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v95, UH0(0)), v32, v33, v34)
                v148 = US5(0, v67, v74, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v148 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v67, to_array(of_array(["\"", "\'"])), (v32, v33, v34)])))


        v160: US5
        if v148.tag == 0:
            v149: str = v148.fields[0]
            v160 = US5(0, "/" if ("\\" == v149) else v149, v148.fields[1], v148.fields[2], v148.fields[3], v148.fields[4])

        else: 
            v160 = US5(1, v148.fields[0])

        v180: US6 = method18(v160.fields[0], v160.fields[1], v160.fields[2], v160.fields[3], v160.fields[4]) if (v160.tag == 0) else US6(1, v160.fields[0])
        v190: US6 = US6(0, v180.fields[0], v180.fields[1], v180.fields[2], v180.fields[3], v180.fields[4]) if (v180.tag == 0) else US6(0, "", v31, v32, v33, v34)
        if v190.tag == 0:
            v195: int = v190.fields[4] or 0
            v194: int = v190.fields[3] or 0
            v193: Any = v190.fields[2]
            v192: str = v190.fields[1]
            v199: US5 = method19(v192, v193, v194, v195, UH1(1, v24, UH1(1, v25, UH1(0))))
            v219 = US6(0, v190.fields[0], v199.fields[1], v199.fields[2], v199.fields[3], v199.fields[4]) if (v199.tag == 0) else US6(1, to_text(interpolate("between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v199.fields[0], (v15, v23, 1, 1), (v31, v32, v33, v34), (v192, v193, v194, v195)])))

        else: 
            v219 = US6(1, "between / expected content")


    else: 
        v219 = US6(1, v29.fields[0])

    v435: US6
    if v219.tag == 0:
        v435 = v219

    else: 
        v359: US5
        if "" == v15:
            v359 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'", " "])), (v23, 1, 1)])))

        else: 
            v267: str = v15[0]
            v269: int = len(v15) or 0
            v274: str = v15[1:v269 + 1]
            if method20(v267, int64(0)) == False:
                v281: str = v267
                v288: int = len(v281) or 0
                v289: Array[str] = fill([0] * v288, 0, v288, "")
                v290: Mut5 = Mut5(0)
                while method13(v288, v290):
                    v292: int = v290.l0 or 0
                    v293: str = v281[v292]
                    v289[v292] = v293
                    v294: int = (v292 + 1) or 0
                    v290.l0 = v294 or 0
                v295: FSharpList[str] = of_array(v289)
                pattern_input_1: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v295, UH0(0)), v23, 1, 1)
                v359 = US5(0, v267, v274, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])

            else: 
                v359 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v267, to_array(of_array(["\"", "\'", " "])), (v23, 1, 1)])))


        v371: US5
        if v359.tag == 0:
            v360: str = v359.fields[0]
            v371 = US5(0, "/" if ("\\" == v360) else v360, v359.fields[1], v359.fields[2], v359.fields[3], v359.fields[4])

        else: 
            v371 = US5(1, v359.fields[0])

        v391: US6 = method21(v371.fields[0], v371.fields[1], v371.fields[2], v371.fields[3], v371.fields[4]) if (v371.tag == 0) else US6(1, v371.fields[0])
        if v391.tag == 0:
            v435 = v391

        else: 
            v403: US8 = US8(0, v15, v23, 1, 1) if (len(v15) == 0) else US8(1, to_text(interpolate("parsing.eof / expected end of input / input: %A%P()", [v15])))
            v412: US6 = US6(0, "", v403.fields[0], v403.fields[1], v403.fields[2], v403.fields[3]) if (v403.tag == 0) else US6(1, v403.fields[0])
            if v412.tag == 0:
                v414: str = v412.fields[1]
                v419: int = method22(v414, 0) or 0
                v421: int = len(v414) or 0
                v435 = US6(0, v412.fields[0], v414[v419:v421 + 1], v412.fields[2], v412.fields[3], v412.fields[4])

            else: 
                v435 = US6(1, v412.fields[0])



    v639: US9
    if v435.tag == 0:
        v440: int = v435.fields[4] or 0
        v439: int = v435.fields[3] or 0
        v438: Any = v435.fields[2]
        v437: str = v435.fields[1]
        v522: US5
        if "" == v437:
            v522 = US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v438, v439, v440)])))

        else: 
            v444: str = v437[0]
            if v444 == " ":
                v447: int = len(v437) or 0
                v452: str = v437[1:v447 + 1]
                v456: str = v444
                v463: int = len(v456) or 0
                v464: Array[str] = fill([0] * v463, 0, v463, "")
                v465: Mut5 = Mut5(0)
                while method13(v463, v465):
                    v467: int = v465.l0 or 0
                    v468: str = v456[v467]
                    v464[v467] = v468
                    v469: int = (v467 + 1) or 0
                    v465.l0 = v469 or 0
                v470: FSharpList[str] = of_array(v464)
                pattern_input_2: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v470, UH0(0)), v438, v439, v440)
                v522 = US5(0, v444, v452, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2])

            else: 
                v492: int = len(v437) or 0
                v495: int = (v437.find("\n") - 1) or 0
                v497: int = (v492 if (-2 == v495) else v495) or 0
                v522 = US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str(" ")) + "\' / line: ") + str(v439)) + " / col: ") + str(v440)) + "\n") + str(v438)) + "") + v437[0:v497 + 1]) + "")) + "\n") + (replicate(v440 - 1, " ") + "^")) + "\n")


        v534: US10 = US10(0, US7(0, v522.fields[0]), v522.fields[1], v522.fields[2], v522.fields[3], v522.fields[4]) if (v522.tag == 0) else US10(0, US7(1), v437, v438, v439, v440)
        v613: US6
        if v534.tag == 0:
            v539: int = v534.fields[4] or 0
            v538: int = v534.fields[3] or 0
            v537: Any = v534.fields[2]
            v536: str = v534.fields[1]
            v589: US5
            if "" == v536:
                v589 = US5(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v537, v538, v539)])))

            else: 
                v543: str = v536[0]
                v545: int = len(v536) or 0
                v550: str = v536[1:v545 + 1]
                v554: str = v543
                v561: int = len(v554) or 0
                v562: Array[str] = fill([0] * v561, 0, v561, "")
                v563: Mut5 = Mut5(0)
                while method13(v561, v563):
                    v565: int = v563.l0 or 0
                    v566: str = v554[v565]
                    v562[v565] = v566
                    v567: int = (v565 + 1) or 0
                    v563.l0 = v567 or 0
                v568: FSharpList[str] = of_array(v562)
                pattern_input_3: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v568, UH0(0)), v537, v538, v539)
                v589 = US5(0, v543, v550, pattern_input_3[0], pattern_input_3[1], pattern_input_3[2])

            v613 = method23(v589.fields[0], v589.fields[1], v589.fields[2], v589.fields[3], v589.fields[4]) if (v589.tag == 0) else US6(1, v589.fields[0])

        else: 
            v613 = US6(1, v534.fields[0])

        v625: US11 = US11(0, US3(0, v613.fields[0]), v613.fields[1], v613.fields[2], v613.fields[3], v613.fields[4]) if (v613.tag == 0) else US11(0, US3(1), v437, v438, v439, v440)
        v639 = US9(0, v435.fields[0], v625.fields[0], v625.fields[1], v625.fields[2], v625.fields[3], v625.fields[4]) if (v625.tag == 0) else US9(1, v625.fields[0])

    else: 
        v639 = US9(1, v435.fields[0])

    if v639.tag == 0:
        return US4(0, v639.fields[0], v639.fields[1])

    else: 
        return US4(1, v639.fields[0])



def closure14(unit_var: None, unit_var_1: None) -> str:
    return "runtime.execute_with_options_async"


def closure15(v0: str, v1: CancellationToken | None, v2: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None, unit_var: None) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]:
    return (v0, v1, v2, v3, v4, v5, v6)


def method26(v0: Mut4, v1: str) -> None:
    v12: str = v0.l0 + (("" + v1) + "")
    v0.l0 = v12


def method28(v0: Mut4, v1: CancellationToken | None=None) -> None:
    method26(v0, to_text(interpolate("%A%P()", [v1])))


def method29(v0: Mut4, v1: Array[tuple[str, str]]) -> None:
    method26(v0, to_text(interpolate("%A%P()", [v1])))


def method30(v0: Mut4, v1: Callable[[tuple[int, str, bool]], Async[None]] | None=None) -> None:
    method26(v0, to_text(interpolate("%A%P()", [v1])))


def method31(v0: Mut4, v1: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None=None) -> None:
    method26(v0, to_text(interpolate("%A%P()", [v1])))


def method32(v0: Mut4, v1: bool) -> None:
    v4: str = "true" if v1 else "false"
    v15: str = v0.l0 + (("" + v4) + "")
    v0.l0 = v15


def method33(v0: Mut4, v1: str | None=None) -> None:
    method26(v0, to_text(interpolate("%A%P()", [v1])))


def method27(v0: Mut4, v1: str, v2: CancellationToken | None, v3: Array[tuple[str, str]], v4: Callable[[tuple[int, str, bool]], Async[None]] | None, v5: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v6: bool, v7: str | None=None) -> None:
    method26(v0, "{ ")
    method9(v0)
    method26(v0, "command")
    method26(v0, " = ")
    method26(v0, v1)
    method26(v0, "; ")
    method26(v0, "cancellation_token")
    method26(v0, " = ")
    method28(v0, v2)
    method26(v0, "; ")
    method26(v0, "environment_variables")
    method26(v0, " = ")
    method29(v0, v3)
    method26(v0, "; ")
    method26(v0, "on_line")
    method26(v0, " = ")
    method30(v0, v4)
    method26(v0, "; ")
    method26(v0, "stdin")
    method26(v0, " = ")
    method31(v0, v5)
    method26(v0, "; ")
    method26(v0, "trace")
    method26(v0, " = ")
    method32(v0, v6)
    method26(v0, "; ")
    method26(v0, "working_directory")
    method26(v0, " = ")
    method33(v0, v7)
    method26(v0, " }")


def method25(v0: Mut4, v1: str, v2: CancellationToken | None, v3: Array[tuple[str, str]], v4: Callable[[tuple[int, str, bool]], Async[None]] | None, v5: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v6: bool, v7: str | None=None) -> None:
    method26(v0, "{ ")
    method9(v0)
    method26(v0, "options")
    method26(v0, " = ")
    method27(v0, v1, v2, v3, v4, v5, v6, v7)
    method26(v0, " }")


def closure16(v0: US0, v1: Callable[[], str], v2: Callable[[], tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_12(State_trace_state())
    v18: int64 | None = pattern_input[4]
    _v35: str | None = None
    _v480: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v18 is None:
        x_2 = None

    else: 
        x: int64 = v18
        def x_1(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v480.contents = x_2
    v507: US2 = default_arg(_v480.contents, US2(1))
    def _arrow194(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2, unit_var: Any=unit_var) -> Any:
        v539: Any = create(op_subtraction(ticks_1(now()), v507.fields[0]))
        return create_1(1, 1, 1, hours(v539), minutes(v539), seconds(v539), milliseconds(v539))

    x_3: str = to_string(_arrow194() if (v507.tag == 0) else now(), method7())
    _v35 = x_3
    v772: str
    if _v35 is None:
        raise Exception("base.run_target / _v35=None")

    else: 
        v772 = _v35

    v931: US3 = US3(0, "Verbose") if (True if (v0.tag == 0) else False) else US3(1)
    v980: US3
    if v931.tag == 0:
        v980 = US3(0, v931.fields[0])

    else: 
        v940: US3 = US3(0, "Debug") if (True if (v0.tag == 1) else False) else US3(1)
        if v940.tag == 0:
            v980 = US3(0, v940.fields[0])

        else: 
            v949: US3 = US3(0, "Info") if (True if (v0.tag == 2) else False) else US3(1)
            if v949.tag == 0:
                v980 = US3(0, v949.fields[0])

            else: 
                v958: US3 = US3(0, "Warning") if (True if (v0.tag == 3) else False) else US3(1)
                if v958.tag == 0:
                    v980 = US3(0, v958.fields[0])

                else: 
                    v967: US3 = US3(0, "Critical") if (True if (v0.tag == 4) else False) else US3(1)
                    v980 = US3(0, v967.fields[0]) if (v967.tag == 0) else US3(1)




    v984: str
    if v980.tag == 0:
        v984 = v980.fields[0]

    else: 
        raise Exception("Option does not have a value.")

    v997: str = pad_left(v984.lower(), 7, " ")
    _v1029: str | None = None
    x_5: str = (("\u001b[94m" if (v0.tag == 1) else ("\u001b[92m" if (v0.tag == 2) else ("\u001b[90m" if (v0.tag == 0) else ("\u001b[93m" if (v0.tag == 3) else "\u001b[91m")))) + v997) + method8()
    _v1029 = x_5
    v1141: str
    if _v1029 is None:
        raise Exception("base.run_target / _v1029=None")

    else: 
        v1141 = _v1029

    v1160: int64 = pattern_input[0].l0
    pattern_input_1: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None] = v2(None)
    v1169: Mut4 = Mut4("")
    method25(v1169, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5], pattern_input_1[6])
    v1170: str = v1169.l0
    return trim_end(trim_start(((((((((("" + v772) + " ") + v1141) + " #") + str(v1160)) + " ") + v1(None)) + " / ") + v1170) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method24(v0: US0, v1: Callable[[], str], v2: Callable[[], tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]]) -> None:
    def v3(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2) -> str:
        return closure16(v0, v1, v2, None)

    method10(v0, v3)


def closure18(v0: str, unit_var: None) -> str:
    return v0


def closure17(v0: str, v1: CancellationToken | None, v2: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None, v7: None, v8: Any, v9: None) -> None:
    _v12: Async[None] | None = None
    _v12 = None
    v126: Async[None]
    if _v12 is None:
        raise Exception("base.run_target / _v12=None")

    else: 
        v126 = _v12

    _v143: None | None = None
    _v143 = some(None)
    if _v143 is None:
        raise Exception("base.run_target / _v143=None")

    else: 
        value_12(_v143)



def closure19(v0: str, v1: CancellationToken | None, v2: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None, v7: None, v8: Any, v9: None) -> None:
    _v12: Async[None] | None = None
    _v12 = None
    v127: Async[None]
    if _v12 is None:
        raise Exception("base.run_target / _v12=None")

    else: 
        v127 = _v12

    _v144: None | None = None
    _v144 = some(None)
    if _v144 is None:
        raise Exception("base.run_target / _v144=None")

    else: 
        value_12(_v144)



def closure20(v0: None, unit_var: None) -> None:
    _v3: bool | None = None
    _v3 = None
    def _arrow195(__unit: None=None, v0: Any=v0, unit_var: Any=unit_var) -> bool:
        raise Exception("base.run_target / _v3=None")

    if (_arrow195() if (_v3 is None) else _v3) == False:
        _v68: None | None = None
        _v68 = some(None)
        if _v68 is None:
            raise Exception("base.run_target / _v68=None")

        else: 
            value_12(_v68)




def closure21(unit_var: None, unit_var_1: None) -> str:
    return "runtime.execute_with_options_async / WaitForExitAsync"


def closure22(v0: Any, unit_var: None) -> Any:
    return v0


def method36(v0: Mut4, v1: Any) -> None:
    method26(v0, to_text(interpolate("%A%P()", [v1])))


def method35(v0: Mut4, v1: Any) -> None:
    method26(v0, "{ ")
    method9(v0)
    method26(v0, "ex")
    method26(v0, " = ")
    method36(v0, v1)
    method26(v0, " }")


def closure23(v0: US0, v1: Callable[[], str], v2: Callable[[], Any], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_12(State_trace_state())
    v18: int64 | None = pattern_input[4]
    _v35: str | None = None
    _v480: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v18 is None:
        x_2 = None

    else: 
        x: int64 = v18
        def x_1(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v480.contents = x_2
    v507: US2 = default_arg(_v480.contents, US2(1))
    def _arrow196(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2, unit_var: Any=unit_var) -> Any:
        v539: Any = create(op_subtraction(ticks_1(now()), v507.fields[0]))
        return create_1(1, 1, 1, hours(v539), minutes(v539), seconds(v539), milliseconds(v539))

    x_3: str = to_string(_arrow196() if (v507.tag == 0) else now(), method7())
    _v35 = x_3
    v772: str
    if _v35 is None:
        raise Exception("base.run_target / _v35=None")

    else: 
        v772 = _v35

    v931: US3 = US3(0, "Verbose") if (True if (v0.tag == 0) else False) else US3(1)
    v980: US3
    if v931.tag == 0:
        v980 = US3(0, v931.fields[0])

    else: 
        v940: US3 = US3(0, "Debug") if (True if (v0.tag == 1) else False) else US3(1)
        if v940.tag == 0:
            v980 = US3(0, v940.fields[0])

        else: 
            v949: US3 = US3(0, "Info") if (True if (v0.tag == 2) else False) else US3(1)
            if v949.tag == 0:
                v980 = US3(0, v949.fields[0])

            else: 
                v958: US3 = US3(0, "Warning") if (True if (v0.tag == 3) else False) else US3(1)
                if v958.tag == 0:
                    v980 = US3(0, v958.fields[0])

                else: 
                    v967: US3 = US3(0, "Critical") if (True if (v0.tag == 4) else False) else US3(1)
                    v980 = US3(0, v967.fields[0]) if (v967.tag == 0) else US3(1)




    v984: str
    if v980.tag == 0:
        v984 = v980.fields[0]

    else: 
        raise Exception("Option does not have a value.")

    v997: str = pad_left(v984.lower(), 7, " ")
    _v1029: str | None = None
    x_5: str = (("\u001b[94m" if (v0.tag == 1) else ("\u001b[92m" if (v0.tag == 2) else ("\u001b[90m" if (v0.tag == 0) else ("\u001b[93m" if (v0.tag == 3) else "\u001b[91m")))) + v997) + method8()
    _v1029 = x_5
    v1141: str
    if _v1029 is None:
        raise Exception("base.run_target / _v1029=None")

    else: 
        v1141 = _v1029

    v1160: int64 = pattern_input[0].l0
    v1163: Mut4 = Mut4("")
    method35(v1163, v2(None))
    v1164: str = v1163.l0
    return trim_end(trim_start(((((((((("" + v772) + " ") + v1141) + " #") + str(v1160)) + " ") + v1(None)) + " / ") + v1164) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method34(v0: US0, v1: Callable[[], str], v2: Callable[[], Any]) -> None:
    def v3(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2) -> str:
        return closure23(v0, v1, v2, None)

    method10(v0, v3)


def closure24(unit_var: None, unit_var_1: None) -> str:
    return "runtime.execute_with_options_async"


def closure25(v0: int, v1: str, unit_var: None) -> tuple[int, int]:
    return (v0, len(v1))


def method39(v0: Mut4, v1: int) -> None:
    v12: str = v0.l0 + (("" + str(v1)) + "")
    v0.l0 = v12


def method38(v0: Mut4, v1: int, v2: int) -> None:
    method26(v0, "{ ")
    method9(v0)
    method26(v0, "exit_code")
    method26(v0, " = ")
    method39(v0, v1)
    method26(v0, "; ")
    method26(v0, "output_length")
    method26(v0, " = ")
    method39(v0, v2)
    method26(v0, " }")


def closure26(v0: US0, v1: Callable[[], str], v2: Callable[[], tuple[int, int]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_12(State_trace_state())
    v18: int64 | None = pattern_input[4]
    _v35: str | None = None
    _v480: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v18 is None:
        x_2 = None

    else: 
        x: int64 = v18
        def x_1(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v480.contents = x_2
    v507: US2 = default_arg(_v480.contents, US2(1))
    def _arrow197(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2, unit_var: Any=unit_var) -> Any:
        v539: Any = create(op_subtraction(ticks_1(now()), v507.fields[0]))
        return create_1(1, 1, 1, hours(v539), minutes(v539), seconds(v539), milliseconds(v539))

    x_3: str = to_string(_arrow197() if (v507.tag == 0) else now(), method7())
    _v35 = x_3
    v772: str
    if _v35 is None:
        raise Exception("base.run_target / _v35=None")

    else: 
        v772 = _v35

    v931: US3 = US3(0, "Verbose") if (True if (v0.tag == 0) else False) else US3(1)
    v980: US3
    if v931.tag == 0:
        v980 = US3(0, v931.fields[0])

    else: 
        v940: US3 = US3(0, "Debug") if (True if (v0.tag == 1) else False) else US3(1)
        if v940.tag == 0:
            v980 = US3(0, v940.fields[0])

        else: 
            v949: US3 = US3(0, "Info") if (True if (v0.tag == 2) else False) else US3(1)
            if v949.tag == 0:
                v980 = US3(0, v949.fields[0])

            else: 
                v958: US3 = US3(0, "Warning") if (True if (v0.tag == 3) else False) else US3(1)
                if v958.tag == 0:
                    v980 = US3(0, v958.fields[0])

                else: 
                    v967: US3 = US3(0, "Critical") if (True if (v0.tag == 4) else False) else US3(1)
                    v980 = US3(0, v967.fields[0]) if (v967.tag == 0) else US3(1)




    v984: str
    if v980.tag == 0:
        v984 = v980.fields[0]

    else: 
        raise Exception("Option does not have a value.")

    v997: str = pad_left(v984.lower(), 7, " ")
    _v1029: str | None = None
    x_5: str = (("\u001b[94m" if (v0.tag == 1) else ("\u001b[92m" if (v0.tag == 2) else ("\u001b[90m" if (v0.tag == 0) else ("\u001b[93m" if (v0.tag == 3) else "\u001b[91m")))) + v997) + method8()
    _v1029 = x_5
    v1141: str
    if _v1029 is None:
        raise Exception("base.run_target / _v1029=None")

    else: 
        v1141 = _v1029

    v1160: int64 = pattern_input[0].l0
    pattern_input_1: tuple[int, int] = v2(None)
    v1164: Mut4 = Mut4("")
    method38(v1164, pattern_input_1[0], pattern_input_1[1])
    v1165: str = v1164.l0
    return trim_end(trim_start(((((((((("" + v772) + " ") + v1141) + " #") + str(v1160)) + " ") + v1(None)) + " / ") + v1165) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method37(v0: US0, v1: Callable[[], str], v2: Callable[[], tuple[int, int]]) -> None:
    def v3(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2) -> str:
        return closure26(v0, v1, v2, None)

    method10(v0, v3)


def method11(v0: str, v1: CancellationToken | None, v2: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None=None) -> Async[tuple[int, str]]:
    _v9: Async[tuple[int, str]] | None = None
    _v9 = None
    if _v9 is None:
        raise Exception("base.run_target / _v9=None")

    else: 
        return _v9



def closure9(unit_var: None, v0: str) -> Async[tuple[int, str]]:
    return method11(v0, None, [], None, None, True, None)


def closure27(unit_var: None, _arg: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return method11(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6])


def closure28(unit_var: None, v0: Callable[[Heap0], Heap0]) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]:
    v8: Heap0 = v0(Heap0("", None, [], None, None, True, None))
    return (v8.l0, v8.l1, v8.l2, v8.l3, v8.l4, v8.l5, v8.l6)


def method42(v0_mut: str, v1_mut: int64) -> bool:
    while True:
        (v0, v1) = (v0_mut, v1_mut)
        if v1 >= int64(4):
            return False

        else: 
            v19: US7
            if v1 == int64(0):
                v19 = US7(0, "\\")

            else: 
                v5: int64 = op_subtraction(v1, int64(1))
                if v5 == int64(0):
                    v19 = US7(0, "`")

                else: 
                    v8: int64 = op_subtraction(v5, int64(1))
                    if v8 == int64(0):
                        v19 = US7(0, "\"")

                    else: 
                        v11: int64 = op_subtraction(v8, int64(1))
                        if v11 == int64(0):
                            v19 = US7(0, " ")

                        else: 
                            v14: int64 = op_subtraction(v11, int64(1))
                            v19 = US7(1)




            def _arrow198(__unit: None=None, v0: Any=v0, v1: Any=v1) -> str:
                raise Exception("Option does not have a value.")

            if v0 == (v19.fields[0] if (v19.tag == 0) else _arrow198()):
                return True

            else: 
                v0_mut = v0
                v1_mut = op_addition(v1, int64(1))
                continue


        break


def method43(v0_mut: str, v1_mut: str, v2_mut: Any, v3_mut: int, v4_mut: int) -> US6:
    while True:
        (v0, v1, v2, v3, v4) = (v0_mut, v1_mut, v2_mut, v3_mut, v4_mut)
        v154: US5
        if "" == v1:
            v154 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\"", " "])), (v2, v3, v4)])))

        else: 
            v55: str = v1[0]
            v57: int = len(v1) or 0
            v62: str = v1[1:v57 + 1]
            if method42(v55, int64(0)) == False:
                v69_1: str = v55
                v76_1: int = len(v69_1) or 0
                v77_1: Array[str] = fill([0] * v76_1, 0, v76_1, "")
                v78_1: Mut5 = Mut5(0)
                while method13(v76_1, v78_1):
                    v80: int = v78_1.l0 or 0
                    v81: str = v69_1[v80]
                    v77_1[v80] = v81
                    v82: int = (v80 + 1) or 0
                    v78_1.l0 = v82 or 0
                v83: FSharpList[str] = of_array(v77_1)
                pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v83, UH0(0)), v2, v3, v4)
                v154 = US5(0, v55, v62, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v154 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v55, to_array(of_array(["\\", "`", "\"", " "])), (v2, v3, v4)])))


        if v154.tag == 0:
            v0_mut = v0 + v154.fields[0]
            v1_mut = v154.fields[1]
            v2_mut = v154.fields[2]
            v3_mut = v154.fields[3]
            v4_mut = v154.fields[4]
            continue

        else: 
            return US6(0, v0, v1, v2, v3, v4)

        break


def method45(v0_mut: str, v1_mut: int64) -> bool:
    while True:
        (v0, v1) = (v0_mut, v1_mut)
        if v1 >= int64(3):
            return False

        else: 
            v15: US7
            if v1 == int64(0):
                v15 = US7(0, "\\")

            else: 
                v5: int64 = op_subtraction(v1, int64(1))
                if v5 == int64(0):
                    v15 = US7(0, "`")

                else: 
                    v8: int64 = op_subtraction(v5, int64(1))
                    if v8 == int64(0):
                        v15 = US7(0, "\"")

                    else: 
                        v11: int64 = op_subtraction(v8, int64(1))
                        v15 = US7(1)



            def _arrow199(__unit: None=None, v0: Any=v0, v1: Any=v1) -> str:
                raise Exception("Option does not have a value.")

            if v0 == (v15.fields[0] if (v15.tag == 0) else _arrow199()):
                return True

            else: 
                v0_mut = v0
                v1_mut = op_addition(v1, int64(1))
                continue


        break


def closure30(unit_var: None, _arg: tuple[str, Any, int, int]) -> US6:
    v3: int = _arg[3] or 0
    v2: int = _arg[2] or 0
    v1: Any = _arg[1]
    v0: str = _arg[0]
    v85: US5
    if "" == v0:
        v85 = US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v1, v2, v3)])))

    else: 
        v7: str = v0[0]
        if v7 == "\\":
            v10: int = len(v0) or 0
            v15: str = v0[1:v10 + 1]
            v19: str = v7
            v26: int = len(v19) or 0
            v27: Array[str] = fill([0] * v26, 0, v26, "")
            v28: Mut5 = Mut5(0)
            while method13(v26, v28):
                v30: int = v28.l0 or 0
                v31: str = v19[v30]
                v27[v30] = v31
                v32: int = (v30 + 1) or 0
                v28.l0 = v32 or 0
            v33: FSharpList[str] = of_array(v27)
            pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v33, UH0(0)), v1, v2, v3)
            v85 = US5(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v55: int = len(v0) or 0
            v58: int = (v0.find("\n") - 1) or 0
            v60: int = (v55 if (-2 == v58) else v58) or 0
            v85 = US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\\")) + "\' / line: ") + str(v2)) + " / col: ") + str(v3)) + "\n") + str(v1)) + "") + v0[0:v60 + 1]) + "")) + "\n") + (replicate(v3 - 1, " ") + "^")) + "\n")


    v144: US5
    if v85.tag == 0:
        v90: int = v85.fields[4] or 0
        v89: int = v85.fields[3] or 0
        v88: Any = v85.fields[2]
        v87: str = v85.fields[1]
        if "" == v87:
            v144 = US5(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v88, v89, v90)])))

        else: 
            v94: str = v87[0]
            v96: int = len(v87) or 0
            v101: str = v87[1:v96 + 1]
            v105: str = v94
            v112: int = len(v105) or 0
            v113: Array[str] = fill([0] * v112, 0, v112, "")
            v114: Mut5 = Mut5(0)
            while method13(v112, v114):
                v116: int = v114.l0 or 0
                v117: str = v105[v116]
                v113[v116] = v117
                v118: int = (v116 + 1) or 0
                v114.l0 = v118 or 0
            v119: FSharpList[str] = of_array(v113)
            pattern_input_1: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v119, UH0(0)), v88, v89, v90)
            v144 = US5(0, v94, v101, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])


    else: 
        v144 = US5(1, v85.fields[0])

    if v144.tag == 0:
        return US6(0, ((("" + str("\\")) + "") + str(v144.fields[0])) + "", v144.fields[1], v144.fields[2], v144.fields[3], v144.fields[4])

    else: 
        return US6(1, v144.fields[0])



def closure31(unit_var: None, _arg: tuple[str, Any, int, int]) -> US6:
    v3: int = _arg[3] or 0
    v2: int = _arg[2] or 0
    v1: Any = _arg[1]
    v0: str = _arg[0]
    v85: US5
    if "" == v0:
        v85 = US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v1, v2, v3)])))

    else: 
        v7: str = v0[0]
        if v7 == "`":
            v10: int = len(v0) or 0
            v15: str = v0[1:v10 + 1]
            v19: str = v7
            v26: int = len(v19) or 0
            v27: Array[str] = fill([0] * v26, 0, v26, "")
            v28: Mut5 = Mut5(0)
            while method13(v26, v28):
                v30: int = v28.l0 or 0
                v31: str = v19[v30]
                v27[v30] = v31
                v32: int = (v30 + 1) or 0
                v28.l0 = v32 or 0
            v33: FSharpList[str] = of_array(v27)
            pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v33, UH0(0)), v1, v2, v3)
            v85 = US5(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v55: int = len(v0) or 0
            v58: int = (v0.find("\n") - 1) or 0
            v60: int = (v55 if (-2 == v58) else v58) or 0
            v85 = US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("`")) + "\' / line: ") + str(v2)) + " / col: ") + str(v3)) + "\n") + str(v1)) + "") + v0[0:v60 + 1]) + "")) + "\n") + (replicate(v3 - 1, " ") + "^")) + "\n")


    v144: US5
    if v85.tag == 0:
        v90: int = v85.fields[4] or 0
        v89: int = v85.fields[3] or 0
        v88: Any = v85.fields[2]
        v87: str = v85.fields[1]
        if "" == v87:
            v144 = US5(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v88, v89, v90)])))

        else: 
            v94: str = v87[0]
            v96: int = len(v87) or 0
            v101: str = v87[1:v96 + 1]
            v105: str = v94
            v112: int = len(v105) or 0
            v113: Array[str] = fill([0] * v112, 0, v112, "")
            v114: Mut5 = Mut5(0)
            while method13(v112, v114):
                v116: int = v114.l0 or 0
                v117: str = v105[v116]
                v113[v116] = v117
                v118: int = (v116 + 1) or 0
                v114.l0 = v118 or 0
            v119: FSharpList[str] = of_array(v113)
            pattern_input_1: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v119, UH0(0)), v88, v89, v90)
            v144 = US5(0, v94, v101, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])


    else: 
        v144 = US5(1, v85.fields[0])

    if v144.tag == 0:
        return US6(0, ((("" + str("`")) + "") + str(v144.fields[0])) + "", v144.fields[1], v144.fields[2], v144.fields[3], v144.fields[4])

    else: 
        return US6(1, v144.fields[0])



def method46(v0_mut: str, v1_mut: Any, v2_mut: int, v3_mut: int, v4_mut: UH3) -> US6:
    while True:
        (v0, v1, v2, v3, v4) = (v0_mut, v1_mut, v2_mut, v3_mut, v4_mut)
        if v4.tag == 0:
            return US6(1, "choice / no parsers succeeded")

        else: 
            v9: US6 = v4.fields[0]((v0, v1, v2, v3))
            if v9.tag == 0:
                return v9

            else: 
                v0_mut = v0
                v1_mut = v1
                v2_mut = v2
                v3_mut = v3
                v4_mut = v4.fields[1]
                continue


        break


def method47(v0_mut: UH2, v1_mut: UH2) -> UH2:
    while True:
        (v0, v1) = (v0_mut, v1_mut)
        if v0.tag == 0:
            return v1

        else: 
            v0_mut = v0.fields[1]
            v1_mut = UH2(1, v0.fields[0], v1)
            continue

        break


def method44(v0_mut: UH2, v1_mut: str, v2_mut: Any, v3_mut: int, v4_mut: int) -> US15:
    while True:
        (v0, v1, v2, v3, v4) = (v0_mut, v1_mut, v2_mut, v3_mut, v4_mut)
        v136: US5
        if "" == v1:
            v136 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\""])), (v2, v3, v4)])))

        else: 
            v46: str = v1[0]
            v48: int = len(v1) or 0
            v53: str = v1[1:v48 + 1]
            if method45(v46, int64(0)) == False:
                v60: str = v46
                v67: int = len(v60) or 0
                v68_1: Array[str] = fill([0] * v67, 0, v67, "")
                v69_1: Mut5 = Mut5(0)
                while method13(v67, v69_1):
                    v71: int = v69_1.l0 or 0
                    v72: str = v60[v71]
                    v68_1[v71] = v72
                    v73: int = (v71 + 1) or 0
                    v69_1.l0 = v73 or 0
                v74: FSharpList[str] = of_array(v68_1)
                pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v74, UH0(0)), v2, v3, v4)
                v136 = US5(0, v46, v53, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v136 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v46, to_array(of_array(["\\", "`", "\""])), (v2, v3, v4)])))


        v156: US6 = US6(0, v136.fields[0], v136.fields[1], v136.fields[2], v136.fields[3], v136.fields[4]) if (v136.tag == 0) else US6(1, v136.fields[0])
        def v163(_arg10: tuple[str, Any, int, int], v0: Any=v0, v1: Any=v1, v2: Any=v2, v3: Any=v3, v4: Any=v4) -> US6:
            return closure30(None, _arg10)

        def v164(_arg10_1: tuple[str, Any, int, int], v0: Any=v0, v1: Any=v1, v2: Any=v2, v3: Any=v3, v4: Any=v4) -> US6:
            return closure31(None, _arg10_1)

        v170: US6 = v156 if (v156.tag == 0) else method46(v1, v2, v3, v4, UH3(1, v163, UH3(1, v164, UH3(0))))
        if v170.tag == 0:
            v0_mut = UH2(1, v170.fields[0], v0)
            v1_mut = v170.fields[1]
            v2_mut = v170.fields[2]
            v3_mut = v170.fields[3]
            v4_mut = v170.fields[4]
            continue

        else: 
            return US15(0, method47(v0, UH2(0)), v1, v2, v3, v4)

        break


def method48(v0: UH2, v1: FSharpList[str]) -> FSharpList[str]:
    if v0.tag == 0:
        return v1

    else: 
        return cons(v0.fields[0], method48(v0.fields[1], v1))



def method49(v0_mut: UH2, v1_mut: str, v2_mut: Any, v3_mut: int, v4_mut: int) -> US15:
    while True:
        (v0, v1, v2, v3, v4) = (v0_mut, v1_mut, v2_mut, v3_mut, v4_mut)
        v136: US5
        if "" == v1:
            v136 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\""])), (v2, v3, v4)])))

        else: 
            v46: str = v1[0]
            v48: int = len(v1) or 0
            v53: str = v1[1:v48 + 1]
            if method45(v46, int64(0)) == False:
                v60: str = v46
                v67: int = len(v60) or 0
                v68_1: Array[str] = fill([0] * v67, 0, v67, "")
                v69_1: Mut5 = Mut5(0)
                while method13(v67, v69_1):
                    v71: int = v69_1.l0 or 0
                    v72: str = v60[v71]
                    v68_1[v71] = v72
                    v73: int = (v71 + 1) or 0
                    v69_1.l0 = v73 or 0
                v74: FSharpList[str] = of_array(v68_1)
                pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v74, UH0(0)), v2, v3, v4)
                v136 = US5(0, v46, v53, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v136 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v46, to_array(of_array(["\\", "`", "\""])), (v2, v3, v4)])))


        v156: US6 = US6(0, v136.fields[0], v136.fields[1], v136.fields[2], v136.fields[3], v136.fields[4]) if (v136.tag == 0) else US6(1, v136.fields[0])
        if v156.tag == 0:
            v0_mut = UH2(1, v156.fields[0], v0)
            v1_mut = v156.fields[1]
            v2_mut = v156.fields[2]
            v3_mut = v156.fields[3]
            v4_mut = v156.fields[4]
            continue

        else: 
            return US15(0, method47(v0, UH2(0)), v1, v2, v3, v4)

        break


def method50(v0_mut: str, v1_mut: int) -> int:
    while True:
        (v0, v1) = (v0_mut, v1_mut)
        if v1 >= len(v0):
            return v1

        elif v0[v1] == " ":
            v0_mut = v0
            v1_mut = v1 + 1
            continue

        else: 
            return v1

        break


def method41(v0_mut: UH2, v1_mut: str, v2_mut: Any, v3_mut: int, v4_mut: int) -> US15:
    while True:
        (v0, v1, v2, v3, v4) = (v0_mut, v1_mut, v2_mut, v3_mut, v4_mut)
        v5: bool = "" == v1
        v154: US5
        if v5:
            v154 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\"", " "])), (v2, v3, v4)])))

        else: 
            v55: str = v1[0]
            v57: int = len(v1) or 0
            v62: str = v1[1:v57 + 1]
            if method42(v55, int64(0)) == False:
                v69_1: str = v55
                v76_1: int = len(v69_1) or 0
                v77_1: Array[str] = fill([0] * v76_1, 0, v76_1, "")
                v78_1: Mut5 = Mut5(0)
                while method13(v76_1, v78_1):
                    v80: int = v78_1.l0 or 0
                    v81: str = v69_1[v80]
                    v77_1[v80] = v81
                    v82: int = (v80 + 1) or 0
                    v78_1.l0 = v82 or 0
                v83: FSharpList[str] = of_array(v77_1)
                pattern_input: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v83, UH0(0)), v2, v3, v4)
                v154 = US5(0, v55, v62, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v154 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v55, to_array(of_array(["\\", "`", "\"", " "])), (v2, v3, v4)])))


        v174: US6 = method43(v154.fields[0], v154.fields[1], v154.fields[2], v154.fields[3], v154.fields[4]) if (v154.tag == 0) else US6(1, v154.fields[0])
        v479: US6
        if v174.tag == 0:
            v479 = v174

        else: 
            v261: US5
            if v5:
                v261 = US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v2, v3, v4)])))

            else: 
                v183: str = v1[0]
                if v183 == "\"":
                    v186: int = len(v1) or 0
                    v191: str = v1[1:v186 + 1]
                    v195: str = v183
                    v202: int = len(v195) or 0
                    v203: Array[str] = fill([0] * v202, 0, v202, "")
                    v204: Mut5 = Mut5(0)
                    while method13(v202, v204):
                        v206: int = v204.l0 or 0
                        v207: str = v195[v206]
                        v203[v206] = v207
                        v208: int = (v206 + 1) or 0
                        v204.l0 = v208 or 0
                    v209: FSharpList[str] = of_array(v203)
                    pattern_input_1: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v209, UH0(0)), v2, v3, v4)
                    v261 = US5(0, v183, v191, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])

                else: 
                    v231: int = len(v1) or 0
                    v234: int = (v1.find("\n") - 1) or 0
                    v236: int = (v231 if (-2 == v234) else v234) or 0
                    v261 = US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\"")) + "\' / line: ") + str(v3)) + " / col: ") + str(v4)) + "\n") + str(v2)) + "") + v1[0:v236 + 1]) + "")) + "\n") + (replicate(v4 - 1, " ") + "^")) + "\n")


            v408: US6
            if v261.tag == 0:
                v266: int = v261.fields[4] or 0
                v265: int = v261.fields[3] or 0
                v264: Any = v261.fields[2]
                v263: str = v261.fields[1]
                v268: US15 = method44(UH2(0), v263, v264, v265, v266)
                v301: US6
                if v268.tag == 0:
                    v275: FSharpList[str] = method48(v268.fields[0], empty())
                    def _arrow201(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2, v3: Any=v3, v4: Any=v4) -> IEnumerable_1[str]:
                        def _arrow200(i: int) -> str:
                            return item(i, v275)

                        return map(_arrow200, range_big_int(0, 1, length(v275) - 1))

                    v301 = US6(0, join("", delay(_arrow201)), v268.fields[1], v268.fields[2], v268.fields[3], v268.fields[4])

                else: 
                    v301 = US6(1, v268.fields[0])

                if v301.tag == 0:
                    v306: int = v301.fields[4] or 0
                    v305: int = v301.fields[3] or 0
                    v304: Any = v301.fields[2]
                    v303: str = v301.fields[1]
                    v388: US5
                    if "" == v303:
                        v388 = US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v304, v305, v306)])))

                    else: 
                        v310: str = v303[0]
                        if v310 == "\"":
                            v313: int = len(v303) or 0
                            v318: str = v303[1:v313 + 1]
                            v322: str = v310
                            v329: int = len(v322) or 0
                            v330: Array[str] = fill([0] * v329, 0, v329, "")
                            v331: Mut5 = Mut5(0)
                            while method13(v329, v331):
                                v333: int = v331.l0 or 0
                                v334: str = v322[v333]
                                v330[v333] = v334
                                v335: int = (v333 + 1) or 0
                                v331.l0 = v335 or 0
                            v336: FSharpList[str] = of_array(v330)
                            pattern_input_2: tuple[Any, int, int] = method15(fold_back(uncurry2(method14()), v336, UH0(0)), v304, v305, v306)
                            v388 = US5(0, v310, v318, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2])

                        else: 
                            v358: int = len(v303) or 0
                            v361: int = (v303.find("\n") - 1) or 0
                            v363: int = (v358 if (-2 == v361) else v361) or 0
                            v388 = US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\"")) + "\' / line: ") + str(v305)) + " / col: ") + str(v306)) + "\n") + str(v304)) + "") + v303[0:v363 + 1]) + "")) + "\n") + (replicate(v306 - 1, " ") + "^")) + "\n")


                    v408 = US6(0, v301.fields[0], v388.fields[1], v388.fields[2], v388.fields[3], v388.fields[4]) if (v388.tag == 0) else US6(1, to_text(interpolate("between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v388.fields[0], (v1, v2, v3, v4), (v263, v264, v265, v266), (v303, v304, v305, v306)])))

                else: 
                    v408 = US6(1, "between / expected content")


            else: 
                v408 = US6(1, v261.fields[0])

            if v408.tag == 0:
                v479 = v408

            else: 
                def v415(_arg10: tuple[str, Any, int, int], v0: Any=v0, v1: Any=v1, v2: Any=v2, v3: Any=v3, v4: Any=v4) -> US6:
                    return closure30(None, _arg10)

                def v416(_arg10_1: tuple[str, Any, int, int], v0: Any=v0, v1: Any=v1, v2: Any=v2, v3: Any=v3, v4: Any=v4) -> US6:
                    return closure31(None, _arg10_1)

                v420: US6 = method46(v1, v2, v3, v4, UH3(1, v415, UH3(1, v416, UH3(0))))
                v431: US6 = US6(0, "", v420.fields[1], v420.fields[2], v420.fields[3], v420.fields[4]) if (v420.tag == 0) else US6(1, v420.fields[0])
                v442: US15 = method49(UH2(0), v431.fields[1], v431.fields[2], v431.fields[3], v431.fields[4]) if (v431.tag == 0) else US15(1, v431.fields[0])
                if v442.tag == 0:
                    v449: FSharpList[str] = method48(v442.fields[0], empty())
                    def _arrow203(__unit: None=None, v0: Any=v0, v1: Any=v1, v2: Any=v2, v3: Any=v3, v4: Any=v4) -> IEnumerable_1[str]:
                        def _arrow202(i_1: int) -> str:
                            return item(i_1, v449)

                        return map(_arrow202, range_big_int(0, 1, length(v449) - 1))

                    v479 = US6(0, join("", delay(_arrow203)), v442.fields[1], v442.fields[2], v442.fields[3], v442.fields[4])

                else: 
                    v479 = US6(1, v442.fields[0])



        if v479.tag == 0:
            v488: int = v479.fields[4] or 0
            v487: int = v479.fields[3] or 0
            v486: Any = v479.fields[2]
            v485: str = v479.fields[1]
            v484: str = v479.fields[0]
            v490: int = method50(v485, 0) or 0
            v502: US8
            if 0 == v490:
                v502 = US8(1, "spaces1 / expected at least one space")

            else: 
                v495: int = len(v485) or 0
                v502 = US8(0, v485[v490:v495 + 1], v486, v487, v488)

            if v502.tag == 0:
                v0_mut = UH2(1, v484, v0)
                v1_mut = v502.fields[0]
                v2_mut = v502.fields[1]
                v3_mut = v502.fields[2]
                v4_mut = v502.fields[3]
                continue

            else: 
                return US15(0, method47(v0, UH2(1, v484, UH2(0))), v485, v486, v487, v488)


        else: 
            return US15(0, method47(v0, UH2(0)), v1, v2, v3, v4)

        break


def method40(v0: str) -> US14:
    _v0: (str | None) | None = None
    _v0 = some(v0)
    def _arrow204(__unit: None=None, v0: Any=v0) -> str | None:
        raise Exception("optionm\'.of_obj / _v0=None")

    v27: US15 = method41(UH2(0), default_arg(_arrow204() if (_v0 is None) else value_12(_v0), ""), StringBuilder__ctor_Z721C83C5(""), 1, 1)
    if v27.tag == 0:
        return US14(0, to_array(method48(v27.fields[0], empty())))

    else: 
        return US14(1, v27.fields[0])



def closure29(unit_var: None, v0: str) -> FSharpResult_2[Array[str], str]:
    v1: US14 = method40(v0)
    if v1.tag == 0:
        return FSharpResult_2(0, v1.fields[0])

    else: 
        return FSharpResult_2(1, v1.fields[0])



def _arrow205(v: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
    return closure0(None, v)


v68: Callable[[US0], tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]] = _arrow205

v69: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v68(v69))


def _arrow206(__unit: None=None) -> None:
    closure2(None, None)


v75: Callable[[], None] = _arrow206

def current_process_kill(__unit: None=None) -> None:
    v75(None)


def _arrow207(v: str) -> Async[tuple[int, str]]:
    return closure9(None, v)


v76: Callable[[str], Async[tuple[int, str]]] = _arrow207

def execute_async(x: str) -> Async[tuple[int, str]]:
    return v76(x)


def _arrow208(_arg10: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return closure27(None, _arg10)


v77: Callable[[tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]], Async[tuple[int, str]]] = _arrow208

def execute_with_options_async(x: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return v77(x)


def _arrow209(v: Callable[[Heap0], Heap0]) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]:
    return closure28(None, v)


v78: Callable[[Callable[[Heap0], Heap0]], tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]] = _arrow209

def execution_options(x: Callable[[Heap0], Heap0]) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]:
    return v78(x)


def _arrow210(v: str) -> FSharpResult_2[Array[str], str]:
    return closure29(None, v)


v79: Callable[[str], FSharpResult_2[Array[str], str]] = _arrow210

def split_args(x: str) -> FSharpResult_2[Array[str], str]:
    return v79(x)


