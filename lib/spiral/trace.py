from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.date import (ticks as ticks_1, now, to_string, create as create_1)
from fable_modules.fable_library.list import (to_array, empty, of_array)
from fable_modules.fable_library.long import (op_addition, op_subtraction)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_1, default_arg)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, ignore, to_enumerable, compare)

TraceState_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr163() -> TypeInfo:
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


US0_reflection = _expr163

def _expr164() -> TypeInfo:
    return record_type("Trace.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr164

def _expr165() -> TypeInfo:
    return record_type("Trace.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr165

def _expr166() -> TypeInfo:
    return record_type("Trace.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr166

def _expr167() -> TypeInfo:
    return record_type("Trace.Mut3", [], Mut3, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: str

Mut3_reflection = _expr167

def _expr168() -> TypeInfo:
    return record_type("Trace.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr168

def _expr169() -> TypeInfo:
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


US1_reflection = _expr169

def _expr170() -> TypeInfo:
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


US2_reflection = _expr170

def _expr171() -> TypeInfo:
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


US3_reflection = _expr171

def method1(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method3(__unit: None=None) -> str:
    return ""


def closure1(v0_1: FSharpRef[US1 | None], v1_1: US1 | None=None) -> FSharpRef[US1 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure2(v0_1: str | None, v1_1: Callable[[US1 | None], FSharpRef[US1 | None]], unit_var: None) -> None:
    def _arrow172(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US1 | None:
        x: str = v0_1
        def x_1(__unit: None=None) -> US1:
            return US1(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow172()))


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

    _v64: FSharpRef[US1 | None] = FSharpRef(None)
    v69: None
    def v66(v: US1 | None=None, v0_1: Any=v0_1) -> FSharpRef[US1 | None]:
        return closure1(_v64, v)

    closure2(v61, v66, None)
    v69 = None
    v84: US1 = default_arg(_v64.contents, US1(1))
    if v84.tag == 0:
        return v84.fields[0]

    else: 
        return ""



def method4(__unit: None=None) -> str:
    return "AUTOMATION"


def closure3(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None]:
    v173: str = method2(method1())
    v178: US2 = US2(0, US0(0)) if ("Verbose" == v173) else US2(1)
    def _arrow173(__unit: None=None, v0_1: Any=v0_1) -> US2:
        v185: US2 = US2(0, US0(1)) if ("Debug" == v173) else US2(1)
        if v185.tag == 0:
            return US2(0, v185.fields[0])

        else: 
            v192: US2 = US2(0, US0(2)) if ("Info" == v173) else US2(1)
            if v192.tag == 0:
                return US2(0, v192.fields[0])

            else: 
                v199: US2 = US2(0, US0(3)) if ("Warning" == v173) else US2(1)
                if v199.tag == 0:
                    return US2(0, v199.fields[0])

                else: 
                    v206: US2 = US2(0, US0(4)) if ("Critical" == v173) else US2(1)
                    return US2(0, v206.fields[0]) if (v206.tag == 0) else US2(1)




    _v1: tuple[US2, US3] = (US2(0, v178.fields[0]) if (v178.tag == 0) else _arrow173(), US3(0, ticks_1(now())) if (method2(method4()) == "True") else US3(1))
    v295: US3 = _v1[1]
    v294: US2 = _v1[0]
    def v360(v: str, v0_1: Any=v0_1) -> None:
        closure3(None, v)

    return (Mut0(int64(0)), Mut1(v360), Mut2(True), Mut3(""), Mut4(v294.fields[0] if (v294.tag == 0) else v0_1), v295.fields[0] if (v295.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = method0(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def closure8(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure9(v0_1: FSharpRef[US3 | None], v1_1: US3 | None=None) -> FSharpRef[US3 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure10(v0_1: int64 | None, v1_1: Callable[[US3 | None], FSharpRef[US3 | None]], unit_var: None) -> None:
    def _arrow174(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US3 | None:
        x: int64 = v0_1
        def x_1(__unit: None=None) -> US3:
            return US3(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow174()))


def method5(__unit: None=None) -> str:
    return "hh:mm:ss"


def method6(__unit: None=None) -> str:
    return "HH:mm:ss"


def method7(__unit: None=None) -> str:
    return "\u001b[0m"


def method8(__unit: None=None) -> str:
    return ""


def closure11(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def closure13(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure12(unit_var: None, v0_1: str) -> None:
    v3: None
    closure13(v0_1, None)
    v3 = None


def closure7(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> None:
    def v4(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v5: None
    v4(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v38: None
    v4(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr175:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr176:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr175())) >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr176()))):
        v79: None
        closure8(pattern_input[0], None)
        v79 = None
        v83: None
        v4(None)
        v83 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        _v362: FSharpRef[US3 | None] = FSharpRef(None)
        v367: None
        def v364(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure9(_v362, v)

        closure10(pattern_input_2[5], v364, None)
        v367 = None
        v382: US3 = default_arg(_v362.contents, US3(1))
        def _arrow177(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v396: Any = create(op_subtraction(ticks_1(now()), v382.fields[0]))
            return create_1(1, 1, 1, hours(v396), minutes(v396), seconds(v396), milliseconds(v396))

        v427: str = to_string(_arrow177() if (v382.tag == 0) else now(), method6())
        v572: US1 = US1(0, "Verbose") if (True if (v0_1.tag == 0) else False) else US1(1)
        v613: US1
        if v572.tag == 0:
            v613 = US1(0, v572.fields[0])

        else: 
            v579: US1 = US1(0, "Debug") if (True if (v0_1.tag == 1) else False) else US1(1)
            if v579.tag == 0:
                v613 = US1(0, v579.fields[0])

            else: 
                v586: US1 = US1(0, "Info") if (True if (v0_1.tag == 2) else False) else US1(1)
                if v586.tag == 0:
                    v613 = US1(0, v586.fields[0])

                else: 
                    v593: US1 = US1(0, "Warning") if (True if (v0_1.tag == 3) else False) else US1(1)
                    if v593.tag == 0:
                        v613 = US1(0, v593.fields[0])

                    else: 
                        v600: US1 = US1(0, "Critical") if (True if (v0_1.tag == 4) else False) else US1(1)
                        v613 = US1(0, v600.fields[0]) if (v600.tag == 0) else US1(1)




        v617: str
        if v613.tag == 0:
            v617 = v613.fields[0]

        else: 
            raise Exception("Option does not have a value.")

        v622: str = pad_left(v617.lower(), 7, " ")
        v734: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v622) + method7()
        v763: int64 = pattern_input_2[0].l0
        v764: str = v2_1(None)
        v766: Mut3 = Mut3(method8())
        v772: None
        closure11(v766, ("" + v764) + "", None)
        v772 = None
        v775: str = v766.l0
        v776: str = v1_1(None)
        v834: str = "" if (v776 == "") else trim_end(trim_start(((((((((("" + v427) + " ") + v734) + " #") + str(v763)) + " ") + v776) + " / ") + v775) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v834)
        pattern_input[1].l0(v834)



def closure6(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    v5: None
    closure7(v0_1, v1_1, v2_1, None)
    v5 = None


def closure5(v0_1: US0, v1_1: Callable[[], str]) -> Callable[[Callable[[], str]], None]:
    def _arrow178(v: Callable[[], str], v0_1: Any=v0_1, v1_1: Any=v1_1) -> None:
        closure6(v0_1, v1_1, v)

    return _arrow178


def closure4(unit_var: None, v0_1: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    def _arrow179(v: Callable[[], str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[Callable[[], str]], None]:
        return closure5(v0_1, v)

    return _arrow179


v0: None = None

def _arrow180(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow180

def _expr181():
    v1(None)
    return v0


v2: None = _expr181()

def _arrow182(v: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return closure4(None, v)


v16: Callable[[US0, Callable[[], str], Callable[[], str]], None] = _arrow182

def trace(x: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return v16(x)


