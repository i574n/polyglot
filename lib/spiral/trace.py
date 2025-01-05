from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.date import (ticks as ticks_1, now, create as create_1, to_string)
from fable_modules.fable_library.list import (to_array, empty, of_array)
from fable_modules.fable_library.long import (from_value, op_subtraction, op_addition)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_1, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.string_ import (trim_end, trim_start)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare)

TraceState_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr263() -> TypeInfo:
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


US0_reflection = _expr263

def _expr264() -> TypeInfo:
    return record_type("Trace.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr264

def _expr265() -> TypeInfo:
    return record_type("Trace.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr265

def _expr266() -> TypeInfo:
    return record_type("Trace.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr266

def _expr267() -> TypeInfo:
    return record_type("Trace.Mut3", [], Mut3, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: str

Mut3_reflection = _expr267

def _expr268() -> TypeInfo:
    return record_type("Trace.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr268

def _expr269() -> TypeInfo:
    return union_type("Trace.US1", [], US1, lambda: [[("f0_0", US0_reflection())], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr269

def _expr270() -> TypeInfo:
    return union_type("Trace.US2", [], US2, lambda: [[("f0_0", int64_type)], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr270

def _expr271() -> TypeInfo:
    return union_type("Trace.US3", [], US3, lambda: [[], [], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1", "US3_2"]


US3_reflection = _expr271

def _expr272() -> TypeInfo:
    return union_type("Trace.US4", [], US4, lambda: [[("f0_0", US3_reflection())], [("f1_0", US3_reflection())], [("f2_0", US3_reflection())], [("f3_0", US3_reflection())], [("f4_0", US3_reflection())]])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1", "US4_2", "US4_3", "US4_4"]


US4_reflection = _expr272

def _expr273() -> TypeInfo:
    return union_type("Trace.US5", [], US5, lambda: [[("f0_0", string_type)], []])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr273

def method3(v0_1: str) -> str:
    return v0_1


def method4(__unit: None=None) -> str:
    return ""


def closure1(unit_var: None, v0_1: str) -> US5:
    return US5(0, v0_1)


def method5(__unit: None=None) -> Callable[[str], US5]:
    def _arrow274(v: str) -> US5:
        return closure1(None, v)

    return _arrow274


def method2(v0_1: str) -> str:
    v29: IOsEnviron = os
    v31: Any = v29.environ
    _v35: (str | None) | None = None
    x: str | None = v31.get(v0_1)
    _v35 = some(x)
    v40: str | None
    if _v35 is None:
        raise Exception("optionm\'.of_obj / _v35=None")

    else: 
        v40 = value_1(_v35)

    v56: US5 = default_arg(map(method5(), v40), US5(1))
    if v56.tag == 0:
        return v56.fields[0]

    else: 
        return ""



def method1(__unit: None=None) -> tuple[US1, US2]:
    v1_1: str = method2("TRACE_LEVEL")
    v6: US1 = US1(0, US0(0)) if ("Verbose" == v1_1) else US1(1)
    def _arrow275(__unit: None=None) -> US1:
        v13: US1 = US1(0, US0(1)) if ("Debug" == v1_1) else US1(1)
        if v13.tag == 0:
            return US1(0, v13.fields[0])

        else: 
            v20: US1 = US1(0, US0(2)) if ("Info" == v1_1) else US1(1)
            if v20.tag == 0:
                return US1(0, v20.fields[0])

            else: 
                v27: US1 = US1(0, US0(3)) if ("Warning" == v1_1) else US1(1)
                if v27.tag == 0:
                    return US1(0, v27.fields[0])

                else: 
                    v34: US1 = US1(0, US0(4)) if ("Critical" == v1_1) else US1(1)
                    return US1(0, v34.fields[0]) if (v34.tag == 0) else US1(1)




    return (US1(0, v6.fields[0]) if (v6.tag == 0) else _arrow275(), US2(1) if (method2("AUTOMATION") != "True") else US2(0, from_value(ticks_1(now()), False)))


def closure2(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None]:
    pattern_input: tuple[US1, US2] = method1()
    _run_target_args_0027_v1: tuple[US1, US2] = (pattern_input[0], pattern_input[1])
    v132: US2 = _run_target_args_0027_v1[1]
    v131: US1 = _run_target_args_0027_v1[0]
    def v138(v: str, v0_1: Any=v0_1) -> None:
        closure2(None, v)

    return (Mut0(int64(1)), Mut1(v138), Mut2(True), Mut3(""), Mut4(v131.fields[0] if (v131.tag == 0) else v0_1), v132.fields[0] if (v132.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = method0(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def method6(v0_1: US0) -> bool:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v35: US0 = pattern_input[4].l0
    if pattern_input[2].l0 == False:
        return False

    else: 
        class ObjectExpr276:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        class ObjectExpr277:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        return find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr276())) >= find(v35, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr277()))



def closure7(unit_var: None, v0_1: int64) -> US2:
    return US2(0, v0_1)


def method8(__unit: None=None) -> Callable[[int64], US2]:
    def _arrow278(v: int64) -> US2:
        return closure7(None, v)

    return _arrow278


def method9(__unit: None=None) -> str:
    return "hh:mm:ss"


def method10(__unit: None=None) -> str:
    return "HH:mm:ss"


def method7(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None=None) -> str:
    v453: US2 = default_arg(map(method8(), v5), US2(1))
    v550: Any
    if v453.tag == 0:
        v510: Any = create(op_subtraction(from_value(ticks_1(now()), False), v453.fields[0]))
        v550 = create_1(1, 1, 1, hours(v510), minutes(v510), seconds(v510), milliseconds(v510))

    else: 
        v550 = now()

    v551: str = method10()
    return to_string(v550, "M-d-y hh:mm:ss tt" if (v551 == "") else v551)


def method13(__unit: None=None) -> str:
    return ""


def closure8(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def method12(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method13())
    v8: None
    closure8(v2_1, ("" + str(v0_1)) + "", None)
    v8 = None
    return v2_1.l0


def method14(__unit: None=None) -> str:
    return "\u001b[0m"


def method11(v0_1: US0) -> str:
    v5: US5 = US5(0, "Verbose") if (True if (v0_1.tag == 0) else False) else US5(1)
    v46: US5
    if v5.tag == 0:
        v46 = US5(0, v5.fields[0])

    else: 
        v12: US5 = US5(0, "Debug") if (True if (v0_1.tag == 1) else False) else US5(1)
        if v12.tag == 0:
            v46 = US5(0, v12.fields[0])

        else: 
            v19: US5 = US5(0, "Info") if (True if (v0_1.tag == 2) else False) else US5(1)
            if v19.tag == 0:
                v46 = US5(0, v19.fields[0])

            else: 
                v26: US5 = US5(0, "Warning") if (True if (v0_1.tag == 3) else False) else US5(1)
                if v26.tag == 0:
                    v46 = US5(0, v26.fields[0])

                else: 
                    v33: US5 = US5(0, "Critical") if (True if (v0_1.tag == 4) else False) else US5(1)
                    v46 = US5(0, v33.fields[0]) if (v33.tag == 0) else US5(1)




    v50: str
    if v46.tag == 0:
        v50 = v46.fields[0]

    else: 
        raise Exception("Option does not have a value.")

    v52: str = v50.lower()
    v56: str = method12(v52[0])
    return (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v56) + method14()


def method16(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method13())
    v8: None
    closure8(v2_1, v0_1, None)
    v8 = None
    return v2_1.l0


def method17(v0_1: str) -> str:
    return trim_end(trim_start(v0_1, *to_array(empty())), *to_array(of_array([" ", "/"])))


def method15(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str, v9: str) -> str:
    v10: str = method16(v9)
    return method17(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + v8) + " / ") + v10) + "")


def closure9(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure11(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure10(unit_var: None, v0_1: str) -> None:
    v3: None
    closure11(v0_1, None)
    v3 = None


def method18(v0_1: str) -> None:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v37: None
    closure9(pattern_input[0], None)
    v37 = None
    closure10(None, v0_1)
    pattern_input[1].l0(v0_1)


def closure6(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> None:
    if method6(v0_1):
        v6: None
        closure0(None, None)
        v6 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut4 = pattern_input[4]
        v23: Mut3 = pattern_input[3]
        v22: Mut2 = pattern_input[2]
        v21: Mut1 = pattern_input[1]
        v20: Mut0 = pattern_input[0]
        v38: str = method7(v20, v21, v22, v23, v24, v25)
        v39: str = method11(v0_1)
        v40: str = v1_1(None)
        method18("" if (v40 == "") else method15(v20, v21, v22, v23, v24, v25, v38, v39, v40, v2_1(None)))



def closure5(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    v5: None
    closure6(v0_1, v1_1, v2_1, None)
    v5 = None


def closure4(v0_1: US0, v1_1: Callable[[], str]) -> Callable[[Callable[[], str]], None]:
    def _arrow279(v: Callable[[], str], v0_1: Any=v0_1, v1_1: Any=v1_1) -> None:
        closure5(v0_1, v1_1, v)

    return _arrow279


def closure3(unit_var: None, v0_1: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    def _arrow280(v: Callable[[], str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[Callable[[], str]], None]:
        return closure4(v0_1, v)

    return _arrow280


v0: None = None

def _arrow281(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow281

def _expr282():
    v1(None)
    return v0


v2: None = _expr282()

def _arrow283(v: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return closure3(None, v)


v16: Callable[[US0, Callable[[], str], Callable[[], str]], None] = _arrow283

def trace(x: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return v16(x)


