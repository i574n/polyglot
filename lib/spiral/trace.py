from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.date import (ticks as ticks_1, now, to_string, create as create_1)
from fable_modules.fable_library.long import (op_subtraction, op_addition)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (value, default_arg, some)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, bool_type, string_type, unit_type, lambda_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare)

State_trace_state: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr192() -> TypeInfo:
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


US0_reflection = _expr192

def _expr193() -> TypeInfo:
    return record_type("Trace.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr193

def _expr194() -> TypeInfo:
    return record_type("Trace.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr194

def _expr195() -> TypeInfo:
    return record_type("Trace.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr195

def _expr196() -> TypeInfo:
    return record_type("Trace.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr196

def _expr197() -> TypeInfo:
    return union_type("Trace.US1", [], US1, lambda: [[("f0_0", int64_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr197

def _expr198() -> TypeInfo:
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


US2_reflection = _expr198

def _expr199() -> TypeInfo:
    return union_type("Trace.US3", [], US3, lambda: [[("f0_0", string_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr199

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


def method5(__unit: None=None) -> str:
    return "hh:mm:ss"


def method6(__unit: None=None) -> str:
    return ""


def method7(__unit: None=None) -> str:
    return "HH:mm:ss"


def closure5(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
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
    def _arrow200(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v105: Any = create(op_subtraction(ticks_1(now()), v98.fields[0]))
        return create_1(1, 1, 1, hours(v105), minutes(v105), seconds(v105), milliseconds(v105))

    x_3: str = to_string(_arrow200() if (v98.tag == 0) else now(), method7())
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
    def _arrow201(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> str:
        raise Exception("base.run_target / _v211=None")

    return trim_end(trim_start(((((((((("" + v147) + " ") + (_arrow201() if (_v211 is None) else _v211)) + " #") + str(pattern_input[0].l0)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method8(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(v: US0, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
        return closure0(None, v)

    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    v4: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    v15: US0 = pattern_input_1[2].l0
    class ObjectExpr202:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr203:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr202())) >= find(v15, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr203()))):
        v23: int64 = op_addition(v4.l0, int64(1))
        v4.l0 = v23
        v24: str = ("" + v1_1(None)) + ""
        _v25: None | None = None
        print(v24)
        _v25 = some(None)
        if _v25 is None:
            raise Exception("base.run_target / _v25=None")

        else: 
            value(_v25)

        pattern_input[4].l0(v24)



def method4(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure5(v0_1, v1_1, v2_1, None)

    method8(v0_1, v3)


def closure4(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    method4(v0_1, v1_1, v2_1)


def closure3(v0_1: US0, v1_1: Callable[[], str]) -> Callable[[Callable[[], str]], None]:
    def _arrow204(v: Callable[[], str], v0_1: Any=v0_1, v1_1: Any=v1_1) -> None:
        closure4(v0_1, v1_1, v)

    return _arrow204


def closure2(unit_var: None, v0_1: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    def _arrow205(v: Callable[[], str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[Callable[[], str]], None]:
        return closure3(v0_1, v)

    return _arrow205


def _arrow206(v: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, v)


v0: Callable[[US0], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow206

v1: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v0(v1))


def _arrow207(v: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return closure2(None, v)


v2: Callable[[US0, Callable[[], str], Callable[[], str]], None] = _arrow207

def trace(x: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return v2(x)


