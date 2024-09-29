from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.date import (ticks as ticks_1, now, to_string, create as create_1)
from fable_modules.fable_library.list import (to_array, empty, of_array)
from fable_modules.fable_library.long import (op_subtraction, op_addition)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_1, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare)

TraceState_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr160() -> TypeInfo:
    return union_type("Trace.US0", [], US0, lambda: [[], [], [], [], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1", "US0_2", "US0_3", "US0_4"]


US0_reflection = _expr160

def _expr161() -> TypeInfo:
    return record_type("Trace.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr161

def _expr162() -> TypeInfo:
    return record_type("Trace.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr162

def _expr163() -> TypeInfo:
    return record_type("Trace.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr163

def _expr164() -> TypeInfo:
    return record_type("Trace.Mut3", [], Mut3, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: str

Mut3_reflection = _expr164

def _expr165() -> TypeInfo:
    return record_type("Trace.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr165

def _expr166() -> TypeInfo:
    return union_type("Trace.US1", [], US1, lambda: [[("f0_0", string_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr166

def _expr167() -> TypeInfo:
    return union_type("Trace.US2", [], US2, lambda: [[("f0_0", US0_reflection())], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr167

def _expr168() -> TypeInfo:
    return union_type("Trace.US3", [], US3, lambda: [[("f0_0", int64_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr168

def method1(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method3(__unit: None=None) -> str:
    return ""


def closure1(unit_var: None, v0_1: str) -> US1:
    return US1(0, v0_1)


def method4(__unit: None=None) -> Callable[[str], US1]:
    def _arrow169(v: str) -> US1:
        return closure1(None, v)

    return _arrow169


def method2(v0_1: str) -> str:
    v50: IOsEnviron = os
    v52: Any = v50.environ
    _v56: (str | None) | None = None
    x: str | None = v52.get(v0_1)
    _v56 = some(x)
    v61: str | None
    if _v56 is None:
        raise Exception("optionm\'.of_obj / _v56=None")

    else: 
        v61 = value_1(_v56)

    v77: US1 = default_arg(map(method4(), v61), US1(1))
    if v77.tag == 0:
        return v77.fields[0]

    else: 
        return ""



def method5(__unit: None=None) -> str:
    return "AUTOMATION"


def closure2(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None]:
    v230: str = method2(method1())
    v235: US2 = US2(0, US0(0)) if ("Verbose" == v230) else US2(1)
    def _arrow170(__unit: None=None, v0_1: Any=v0_1) -> US2:
        v242: US2 = US2(0, US0(1)) if ("Debug" == v230) else US2(1)
        if v242.tag == 0:
            return US2(0, v242.fields[0])

        else: 
            v249: US2 = US2(0, US0(2)) if ("Info" == v230) else US2(1)
            if v249.tag == 0:
                return US2(0, v249.fields[0])

            else: 
                v256: US2 = US2(0, US0(3)) if ("Warning" == v230) else US2(1)
                if v256.tag == 0:
                    return US2(0, v256.fields[0])

                else: 
                    v263: US2 = US2(0, US0(4)) if ("Critical" == v230) else US2(1)
                    return US2(0, v263.fields[0]) if (v263.tag == 0) else US2(1)




    _v1: tuple[US2, US3] = (US2(0, v235.fields[0]) if (v235.tag == 0) else _arrow170(), US3(0, ticks_1(now())) if (method2(method5()) == "True") else US3(1))
    v352: US3 = _v1[1]
    v351: US2 = _v1[0]
    def v417(v: str, v0_1: Any=v0_1) -> None:
        closure2(None, v)

    return (Mut0(int64(1)), Mut1(v417), Mut2(True), Mut3(""), Mut4(v351.fields[0] if (v351.tag == 0) else v0_1), v352.fields[0] if (v352.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = method0(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def closure7(unit_var: None, v0_1: int64) -> US3:
    return US3(0, v0_1)


def method7(__unit: None=None) -> Callable[[int64], US3]:
    def _arrow171(v: int64) -> US3:
        return closure7(None, v)

    return _arrow171


def method8(__unit: None=None) -> str:
    return "hh:mm:ss"


def method9(__unit: None=None) -> str:
    return "HH:mm:ss"


def method6(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None=None) -> str:
    v238: US3 = default_arg(map(method7(), v5), US3(1))
    def _arrow172(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4, v5: Any=v5) -> Any:
        v252: Any = create(op_subtraction(ticks_1(now()), v238.fields[0]))
        return create_1(1, 1, 1, hours(v252), minutes(v252), seconds(v252), milliseconds(v252))

    return to_string(_arrow172() if (v238.tag == 0) else now(), method9())


def method11(__unit: None=None) -> str:
    return "\u001b[0m"


def method10(v0_1: US0) -> str:
    v5: US1 = US1(0, "Verbose") if (True if (v0_1.tag == 0) else False) else US1(1)
    v46: US1
    if v5.tag == 0:
        v46 = US1(0, v5.fields[0])

    else: 
        v12: US1 = US1(0, "Debug") if (True if (v0_1.tag == 1) else False) else US1(1)
        if v12.tag == 0:
            v46 = US1(0, v12.fields[0])

        else: 
            v19: US1 = US1(0, "Info") if (True if (v0_1.tag == 2) else False) else US1(1)
            if v19.tag == 0:
                v46 = US1(0, v19.fields[0])

            else: 
                v26: US1 = US1(0, "Warning") if (True if (v0_1.tag == 3) else False) else US1(1)
                if v26.tag == 0:
                    v46 = US1(0, v26.fields[0])

                else: 
                    v33: US1 = US1(0, "Critical") if (True if (v0_1.tag == 4) else False) else US1(1)
                    v46 = US1(0, v33.fields[0]) if (v33.tag == 0) else US1(1)




    v50: str
    if v46.tag == 0:
        v50 = v46.fields[0]

    else: 
        raise Exception("Option does not have a value.")

    v55: str = pad_left(v50.lower(), 7, " ")
    return (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v55) + method11()


def method13(__unit: None=None) -> str:
    return ""


def closure8(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def method12(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method13())
    v8: None
    closure8(v2_1, ("" + v0_1) + "", None)
    v8 = None
    return v2_1.l0


def method14(v0_1: str, v1_1: str, v2_1: str, v3: int64, v4: str) -> str:
    return trim_end(trim_start(((((((((("" + v0_1) + " ") + v1_1) + " #") + str(v3)) + " ") + v2_1) + " / ") + v4) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def closure9(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure11(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure10(unit_var: None, v0_1: str) -> None:
    v3: None
    closure11(v0_1, None)
    v3 = None


def method15(v0_1: str, v1_1: Mut0, v2_1: Mut1, v3: Mut2, v4: Mut3, v5: Mut4, v6: int64 | None=None) -> None:
    v9: None
    closure9(v1_1, None)
    v9 = None
    closure10(None, v0_1)
    v2_1.l0(v0_1)


def closure6(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> None:
    def v4(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v5: None
    v4(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr173:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr174:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr173())) >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr174()))):
        v45: None
        v4(None)
        v45 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        v59: Mut0 = pattern_input_1[0]
        v77: str = method6(v59, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5])
        v78: str = method10(v0_1)
        v79: str = v1_1(None)
        v86: str = "" if (v79 == "") else method14(v77, v78, v79, v59.l0, method12(v2_1(None)))
        v88: None
        v4(None)
        v88 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        method15(v86, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure5(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    v5: None
    closure6(v0_1, v1_1, v2_1, None)
    v5 = None


def closure4(v0_1: US0, v1_1: Callable[[], str]) -> Callable[[Callable[[], str]], None]:
    def _arrow175(v: Callable[[], str], v0_1: Any=v0_1, v1_1: Any=v1_1) -> None:
        closure5(v0_1, v1_1, v)

    return _arrow175


def closure3(unit_var: None, v0_1: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    def _arrow176(v: Callable[[], str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[Callable[[], str]], None]:
        return closure4(v0_1, v)

    return _arrow176


v0: None = None

def _arrow177(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow177

def _expr178():
    v1(None)
    return v0


v2: None = _expr178()

def _arrow179(v: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return closure3(None, v)


v16: Callable[[US0, Callable[[], str], Callable[[], str]], None] = _arrow179

def trace(x: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return v16(x)


