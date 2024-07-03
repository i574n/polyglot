from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.async_builder import Async
from fable_modules.fable_library.date import (ticks as ticks_1, now, to_string, create as create_1)
from fable_modules.fable_library.list import (to_array, empty, of_array)
from fable_modules.fable_library.long import (op_subtraction, op_addition)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_1, default_arg)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type, class_type, int32_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, to_text, interpolate)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare)

State_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr122() -> TypeInfo:
    return union_type("Networking.US0", [], US0, lambda: [[], [], [], [], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1", "US0_2", "US0_3", "US0_4"]


US0_reflection = _expr122

def _expr123() -> TypeInfo:
    return record_type("Networking.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr123

def _expr124() -> TypeInfo:
    return record_type("Networking.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr124

def _expr125() -> TypeInfo:
    return record_type("Networking.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr125

def _expr126() -> TypeInfo:
    return record_type("Networking.Mut3", [], Mut3, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: US0

Mut3_reflection = _expr126

def _expr127() -> TypeInfo:
    return union_type("Networking.US1", [], US1, lambda: [[("f0_0", US0_reflection())], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr127

def _expr128() -> TypeInfo:
    return union_type("Networking.US2", [], US2, lambda: [[("f0_0", int64_type)], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr128

def _expr129() -> TypeInfo:
    return union_type("Networking.US3", [], US3, lambda: [[("f0_0", string_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr129

def _expr130() -> TypeInfo:
    return record_type("Networking.Mut4", [], Mut4, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: str

Mut4_reflection = _expr130

def _expr131() -> TypeInfo:
    return union_type("Networking.US4", [], US4, lambda: [[("f0_0", bool_type)], []])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1"]


US4_reflection = _expr131

def _expr132() -> TypeInfo:
    return union_type("Networking.US5", [], US5, lambda: [[("f0_0", bool_type)], [("f1_0", class_type("System.Exception"))]])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr132

def _expr133() -> TypeInfo:
    return union_type("Networking.US6", [], US6, lambda: [[("f0_0", bool_type)], [("f1_0", class_type("System.Exception"))]])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1"]


US6_reflection = _expr133

def _expr134() -> TypeInfo:
    return union_type("Networking.US7", [], US7, lambda: [[("f0_0", int32_type)], []])


class US7(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US7_0", "US7_1"]


US7_reflection = _expr134

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
        v57 = value_1(_v54)

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
    def _arrow135(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> US1:
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




    x: tuple[US1, US2] = (US1(0, v139.fields[0]) if (v139.tag == 0) else _arrow135(), US2(0, ticks_1(now())) if (method1(method3()) == "True") else US2(1))
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
    return "networking.test_port_open"


def closure5(v0_1: int, v1_1: str, unit_var: None) -> tuple[int, str]:
    return (v0_1, v1_1)


def method5(__unit: None=None) -> str:
    return "hh:mm:ss"


def method6(__unit: None=None) -> str:
    return ""


def method7(__unit: None=None) -> str:
    return "HH:mm:ss"


def method8(__unit: None=None) -> str:
    return "\u001b[0m"


def method10(v0_1: Mut4, v1_1: str) -> None:
    v4_1: str = v0_1.l0 + (("" + v1_1) + "")
    v0_1.l0 = v4_1


def method11(v0_1: Mut4) -> None:
    pass


def method12(v0_1: Mut4, v1_1: int) -> None:
    v4_1: str = v0_1.l0 + (("" + str(v1_1)) + "")
    v0_1.l0 = v4_1


def method9(v0_1: Mut4, v1_1: int, v2_1: str) -> None:
    method10(v0_1, "{ ")
    method11(v0_1)
    method10(v0_1, "port")
    method10(v0_1, " = ")
    method12(v0_1, v1_1)
    method10(v0_1, "; ")
    method10(v0_1, "ex")
    method10(v0_1, " = ")
    method10(v0_1, v2_1)
    method10(v0_1, " }")


def closure6(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[int, str]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
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
    def _arrow136(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow136() if (v101.tag == 0) else now(), method7())
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
    pattern_input_1: tuple[int, str] = v2_1(None)
    v333: Mut4 = Mut4("")
    method9(v333, pattern_input_1[0], pattern_input_1[1])
    v334: str = v333.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v334) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method13(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(v: US0, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
        return closure0(None, v)

    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v4_1: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v15: US0 = pattern_input_1[3].l0
    class ObjectExpr137:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr138:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr137())) >= find(v15, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr138()))):
        v23: int64 = op_addition(v4_1.l0, int64(1))
        v4_1.l0 = v23
        v24: str = ("" + v1_1(None)) + ""
        _v25: None | None = None
        print(v24)
        _v25 = some(None)
        if _v25 is None:
            raise Exception("base.run_target / _v25=None")

        else: 
            value_1(_v25)

        pattern_input[1].l0(v24)



def method4(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[int, str]]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure6(v0_1, v1_1, v2_1, None)

    method13(v0_1, v3_1)


def closure3(v0_1: str, v1_1: int) -> Async[bool]:
    _v2: Async[bool] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure2(unit_var: None, v0_1: str) -> Callable[[int], Async[bool]]:
    def _arrow139(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[bool]:
        return closure3(v0_1, v)

    return _arrow139


def closure10(unit_var: None, v0_1: bool) -> US5:
    return US5(0, v0_1)


def closure11(unit_var: None, v0_1: Exception) -> US5:
    return US5(1, v0_1)


def closure12(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async"


def closure13(v0_1: int, unit_var: None) -> int:
    return v0_1


def method15(v0_1: Mut4, v1_1: int) -> None:
    method10(v0_1, "{ ")
    method11(v0_1)
    method10(v0_1, "timeout")
    method10(v0_1, " = ")
    method12(v0_1, v1_1)
    method10(v0_1, " }")


def closure14(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], int], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
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
    def _arrow140(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow140() if (v101.tag == 0) else now(), method7())
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
    method15(v332, v2_1(None))
    v333: str = v332.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v333) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method14(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], int]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure14(v0_1, v1_1, v2_1, None)

    method13(v0_1, v3_1)


def closure15(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async**"


def closure16(v0_1: int, v1_1: Exception, unit_var: None) -> tuple[int, str]:
    _v2: str | None = None
    x: str = to_text(interpolate("%A%P()", [v1_1]))
    _v2 = x
    def _arrow141(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> str:
        raise Exception("base.run_target / _v2=None")

    return (v0_1, _arrow141() if (_v2 is None) else _v2)


def method17(v0_1: Mut4, v1_1: int, v2_1: str) -> None:
    method10(v0_1, "{ ")
    method11(v0_1)
    method10(v0_1, "timeout")
    method10(v0_1, " = ")
    method12(v0_1, v1_1)
    method10(v0_1, "; ")
    method10(v0_1, "ex")
    method10(v0_1, " = ")
    method10(v0_1, v2_1)
    method10(v0_1, " }")


def closure17(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[int, str]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
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
    def _arrow142(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow142() if (v101.tag == 0) else now(), method7())
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
    pattern_input_1: tuple[int, str] = v2_1(None)
    v333: Mut4 = Mut4("")
    method17(v333, pattern_input_1[0], pattern_input_1[1])
    v334: str = v333.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v334) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method16(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[int, str]]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure17(v0_1, v1_1, v2_1, None)

    method13(v0_1, v3_1)


def closure9(v0_1: int, v1_1: str, v2_1: int) -> Async[bool]:
    _v3: Async[bool] | None = None
    _v3 = None
    if _v3 is None:
        raise Exception("base.run_target / _v3=None")

    else: 
        return _v3



def closure8(v0_1: int, v1_1: str) -> Callable[[int], Async[bool]]:
    def _arrow143(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[bool]:
        return closure9(v0_1, v1_1, v)

    return _arrow143


def closure7(unit_var: None, v0_1: int) -> Callable[[str, int], Async[bool]]:
    def _arrow144(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[bool]]:
        return closure8(v0_1, v)

    return _arrow144


def closure22(unit_var: None, unit_var_1: None) -> str:
    return "networking.wait_for_port_access"


def closure23(v0_1: int | None, v1_1: bool, v2_1: int, v3_1: int64, unit_var: None) -> tuple[int, int64, int | None, bool]:
    return (v2_1, v3_1, v0_1, v1_1)


def method21(v0_1: Mut4, v1_1: int64) -> None:
    v4_1: str = v0_1.l0 + (("" + str(v1_1)) + "")
    v0_1.l0 = v4_1


def method22(v0_1: Mut4, v1_1: int | None=None) -> None:
    method10(v0_1, to_text(interpolate("%A%P()", [v1_1])))


def method23(v0_1: Mut4, v1_1: bool) -> None:
    v4_1: str = "true" if v1_1 else "false"
    v7: str = v0_1.l0 + (("" + v4_1) + "")
    v0_1.l0 = v7


def method20(v0_1: Mut4, v1_1: int, v2_1: int64, v3_1: int | None, v4_1: bool) -> None:
    method10(v0_1, "{ ")
    method11(v0_1)
    method10(v0_1, "port")
    method10(v0_1, " = ")
    method12(v0_1, v1_1)
    method10(v0_1, "; ")
    method10(v0_1, "retry")
    method10(v0_1, " = ")
    method21(v0_1, v2_1)
    method10(v0_1, "; ")
    method10(v0_1, "timeout")
    method10(v0_1, " = ")
    method22(v0_1, v3_1)
    method10(v0_1, "; ")
    method10(v0_1, "status")
    method10(v0_1, " = ")
    method23(v0_1, v4_1)
    method10(v0_1, " }")


def closure24(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[int, int64, int | None, bool]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
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
    def _arrow145(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow145() if (v101.tag == 0) else now(), method7())
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
    pattern_input_1: tuple[int, int64, int | None, bool] = v2_1(None)
    v335: Mut4 = Mut4("")
    method20(v335, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2], pattern_input_1[3])
    v336: str = v335.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v336) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method19(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[int, int64, int | None, bool]]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure24(v0_1, v1_1, v2_1, None)

    method13(v0_1, v3_1)


def method18(v0_1: int | None, v1_1: bool, v2_1: str, v3_1: int, v4_1: int64) -> Async[int64]:
    _v5: Async[int64] | None = None
    _v5 = None
    if _v5 is None:
        raise Exception("base.run_target / _v5=None")

    else: 
        return _v5



def closure21(v0_1: int | None, v1_1: bool, v2_1: str, v3_1: int) -> Async[int64]:
    return method18(v0_1, v1_1, v2_1, v3_1, int64(0))


def closure20(v0_1: int | None, v1_1: bool, v2_1: str) -> Callable[[int], Async[int64]]:
    def _arrow146(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> Async[int64]:
        return closure21(v0_1, v1_1, v2_1, v)

    return _arrow146


def closure19(v0_1: int | None, v1_1: bool) -> Callable[[str, int], Async[int64]]:
    def _arrow147(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Callable[[int], Async[int64]]:
        return closure20(v0_1, v1_1, v)

    return _arrow147


def closure18(unit_var: None, v0_1: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    def _arrow148(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str, int], Async[int64]]:
        return closure19(v0_1, v)

    return _arrow148


def method24(v0_1: int | None, v1_1: str, v2_1: int) -> Async[int]:
    _v3: Async[int] | None = None
    _v3 = None
    if _v3 is None:
        raise Exception("base.run_target / _v3=None")

    else: 
        return _v3



def closure27(v0_1: int | None, v1_1: str, v2_1: int) -> Async[int]:
    return method24(v0_1, v1_1, v2_1)


def closure26(v0_1: int | None, v1_1: str) -> Callable[[int], Async[int]]:
    def _arrow149(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[int]:
        return closure27(v0_1, v1_1, v)

    return _arrow149


def closure25(unit_var: None, v0_1: int | None=None) -> Callable[[str, int], Async[int]]:
    def _arrow150(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[int]]:
        return closure26(v0_1, v)

    return _arrow150


def _arrow151(v: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
    return closure0(None, v)


v0: Callable[[US0], tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]] = _arrow151

v1: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v0(v1))


def _arrow152(v: str) -> Callable[[int], Async[bool]]:
    return closure2(None, v)


v2: Callable[[str, int], Async[bool]] = _arrow152

def test_port_open(x: str) -> Callable[[int], Async[bool]]:
    return v2(x)


def _arrow153(v: int) -> Callable[[str, int], Async[bool]]:
    return closure7(None, v)


v3: Callable[[int, str, int], Async[bool]] = _arrow153

def test_port_open_timeout(x: int) -> Callable[[str, int], Async[bool]]:
    return v3(x)


def _arrow154(v: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return closure18(None, v)


v4: Callable[[int | None, bool, str, int], Async[int64]] = _arrow154

def wait_for_port_access(x: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return v4(x)


def _arrow155(v: int | None=None) -> Callable[[str, int], Async[int]]:
    return closure25(None, v)


v5: Callable[[int | None, str, int], Async[int]] = _arrow155

def get_available_port(x: int | None=None) -> Callable[[str, int], Async[int]]:
    return v5(x)


