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
from fable_modules.fable_library.option import (some, value, default_arg)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare)

State_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr142() -> TypeInfo:
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


US0_reflection = _expr142

def _expr143() -> TypeInfo:
    return record_type("Trace.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr143

def _expr144() -> TypeInfo:
    return record_type("Trace.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr144

def _expr145() -> TypeInfo:
    return record_type("Trace.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr145

def _expr146() -> TypeInfo:
    return record_type("Trace.Mut3", [], Mut3, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: US0

Mut3_reflection = _expr146

def _expr147() -> TypeInfo:
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


US1_reflection = _expr147

def _expr148() -> TypeInfo:
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


US2_reflection = _expr148

def _expr149() -> TypeInfo:
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


US3_reflection = _expr149

def _expr150() -> TypeInfo:
    return record_type("Trace.Mut4", [], Mut4, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: str

Mut4_reflection = _expr150

def method1(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method3(__unit: None=None) -> str:
    return ""


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
        v61 = value(_v56)

    _v64: FSharpRef[US1 | None] = FSharpRef(None)
    x_4: US1 | None
    if v61 is None:
        x_4 = None

    else: 
        x_2: str = v61
        def x_3(__unit: None=None, v0_1: Any=v0_1) -> US1:
            return US1(0, x_2)

        x_4 = x_3(None)

    _v64.contents = x_4
    v79: US1 = default_arg(_v64.contents, US1(1))
    if v79.tag == 0:
        return v79.fields[0]

    else: 
        return ""



def method4(__unit: None=None) -> str:
    return "AUTOMATION"


def closure0(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
    v173: str = method2(method1())
    v178: US2 = US2(0, US0(0)) if ("Verbose" == v173) else US2(1)
    def _arrow151(__unit: None=None, v0_1: Any=v0_1) -> US2:
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




    _v1: tuple[US2, US3] = (US2(0, v178.fields[0]) if (v178.tag == 0) else _arrow151(), US3(0, ticks_1(now())) if (method2(method4()) == "True") else US3(1))
    v295: US3 = _v1[1]
    v294: US2 = _v1[0]
    def v365(v: str, v0_1: Any=v0_1) -> None:
        closure0(None, v)

    return (Mut0(int64(0)), Mut1(v365), Mut2(True), Mut3(v294.fields[0] if (v294.tag == 0) else v0_1), v295.fields[0] if (v295.tag == 0) else None)


def method5(__unit: None=None) -> str:
    return "hh:mm:ss"


def method6(__unit: None=None) -> str:
    return "HH:mm:ss"


def method7(__unit: None=None) -> str:
    return "\u001b[0m"


def method8(__unit: None=None) -> str:
    return ""


def closure3(v0_1: US0, v1: Callable[[], str], v2: Callable[[], str]) -> None:
    if State_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
        State_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4]))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value(State_trace_state())
    v15: Mut0 = pattern_input_1[0]
    if State_trace_state() is None:
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
        State_trace_state((pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4]))

    pattern_input_3: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value(State_trace_state())
    v57: US0 = pattern_input_3[3].l0
    class ObjectExpr152:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr153:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_3[2].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr152())) >= find(v57, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr153()))):
        v65: int64 = op_addition(v15.l0, int64(1))
        v15.l0 = v65
        if State_trace_state() is None:
            pattern_input_4: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
            State_trace_state((pattern_input_4[0], pattern_input_4[1], pattern_input_4[2], pattern_input_4[3], pattern_input_4[4]))

        pattern_input_5: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value(State_trace_state())
        v82: int64 | None = pattern_input_5[4]
        _v320: FSharpRef[US3 | None] = FSharpRef(None)
        x_4: US3 | None
        if v82 is None:
            x_4 = None

        else: 
            x_2: int64 = v82
            def x_3(__unit: None=None, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2) -> US3:
                return US3(0, x_2)

            x_4 = x_3(None)

        _v320.contents = x_4
        v335: US3 = default_arg(_v320.contents, US3(1))
        def _arrow154(__unit: None=None, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2) -> Any:
            v349: Any = create(op_subtraction(ticks_1(now()), v335.fields[0]))
            return create_1(1, 1, 1, hours(v349), minutes(v349), seconds(v349), milliseconds(v349))

        v380: str = to_string(_arrow154() if (v335.tag == 0) else now(), method6())
        v515: US1 = US1(0, "Verbose") if (True if (v0_1.tag == 0) else False) else US1(1)
        v556: US1
        if v515.tag == 0:
            v556 = US1(0, v515.fields[0])

        else: 
            v522: US1 = US1(0, "Debug") if (True if (v0_1.tag == 1) else False) else US1(1)
            if v522.tag == 0:
                v556 = US1(0, v522.fields[0])

            else: 
                v529: US1 = US1(0, "Info") if (True if (v0_1.tag == 2) else False) else US1(1)
                if v529.tag == 0:
                    v556 = US1(0, v529.fields[0])

                else: 
                    v536: US1 = US1(0, "Warning") if (True if (v0_1.tag == 3) else False) else US1(1)
                    if v536.tag == 0:
                        v556 = US1(0, v536.fields[0])

                    else: 
                        v543: US1 = US1(0, "Critical") if (True if (v0_1.tag == 4) else False) else US1(1)
                        v556 = US1(0, v543.fields[0]) if (v543.tag == 0) else US1(1)




        v560: str
        if v556.tag == 0:
            v560 = v556.fields[0]

        else: 
            raise Exception("Option does not have a value.")

        v565: str = pad_left(v560.lower(), 7, " ")
        v677: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v565) + method7()
        v706: int64 = pattern_input_5[0].l0
        v707: str = v2(None)
        v709: Mut4 = Mut4(method8())
        v714: str = v709.l0 + (("" + v707) + "")
        v709.l0 = v714
        v715: str = v709.l0
        v753: str = trim_end(trim_start(((((((((("" + v380) + " ") + v677) + " #") + str(v706)) + " ") + v1(None)) + " / ") + v715) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v753)
        pattern_input_1[1].l0(v753)



def closure2(v0_1: US0, v1: Callable[[], str]) -> Callable[[Callable[[], str]], None]:
    def _arrow155(v: Callable[[], str], v0_1: Any=v0_1, v1: Any=v1) -> None:
        closure3(v0_1, v1, v)

    return _arrow155


def closure1(unit_var: None, v0_1: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    def _arrow156(v: Callable[[], str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[Callable[[], str]], None]:
        return closure2(v0_1, v)

    return _arrow156


v0: bool = State_trace_state() is None


if v0:
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
    State_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4]))


def _arrow157(v: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return closure1(None, v)


v12: Callable[[US0, Callable[[], str], Callable[[], str]], None] = _arrow157

def trace(x: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return v12(x)


