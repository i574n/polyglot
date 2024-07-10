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


def method1(v0: str) -> str:
    _v3: str | None = None
    v54: IOsEnviron = os
    v56: Any = v54.environ
    _v66: (str | None) | None = None
    x: str | None = v56.get(v0)
    _v66 = some(x)
    v77: str | None
    if _v66 is None:
        raise Exception("optionm\'.of_obj / _v66=None")

    else: 
        v77 = value_1(_v66)

    _v86: FSharpRef[US3 | None] = FSharpRef(None)
    x_4: US3 | None
    if v77 is None:
        x_4 = None

    else: 
        x_2: str = v77
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
    def _arrow135(__unit: None=None, unit_var: Any=unit_var, v0: Any=v0) -> US1:
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




    x: tuple[US1, US2] = (US1(0, v173.fields[0]) if (v173.tag == 0) else _arrow135(), US2(0, ticks_1(now())) if (method1(method3()) == "True") else US2(1))
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
    return "networking.test_port_open"


def closure5(v0: int, v1: str, unit_var: None) -> tuple[int, str]:
    return (v0, v1)


def method5(__unit: None=None) -> str:
    return "hh:mm:ss"


def method6(__unit: None=None) -> str:
    return ""


def method7(__unit: None=None) -> str:
    return "HH:mm:ss"


def method8(__unit: None=None) -> str:
    return "\u001b[0m"


def method10(v0: Mut4, v1: str) -> None:
    v12_1: str = v0.l0 + (("" + v1) + "")
    v0.l0 = v12_1


def method11(v0: Mut4) -> None:
    pass


def method12(v0: Mut4, v1: int) -> None:
    v12_1: str = v0.l0 + (("" + str(v1)) + "")
    v0.l0 = v12_1


def method9(v0: Mut4, v1: int, v2_1: str) -> None:
    method10(v0, "{ ")
    method11(v0)
    method10(v0, "port")
    method10(v0, " = ")
    method12(v0, v1)
    method10(v0, "; ")
    method10(v0, "ex")
    method10(v0, " = ")
    method10(v0, v2_1)
    method10(v0, " }")


def closure6(v0: US0, v1: Callable[[], str], v2_1: Callable[[], tuple[int, str]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v18: int64 | None = pattern_input[4]
    _v35: str | None = None
    _v480: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v18 is None:
        x_2 = None

    else: 
        x: int64 = v18
        def x_1(__unit: None=None, v0: Any=v0, v1: Any=v1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v480.contents = x_2
    v507: US2 = default_arg(_v480.contents, US2(1))
    def _arrow136(__unit: None=None, v0: Any=v0, v1: Any=v1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v539: Any = create(op_subtraction(ticks_1(now()), v507.fields[0]))
        return create_1(1, 1, 1, hours(v539), minutes(v539), seconds(v539), milliseconds(v539))

    x_3: str = to_string(_arrow136() if (v507.tag == 0) else now(), method7())
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
    pattern_input_1: tuple[int, str] = v2_1(None)
    v1164: Mut4 = Mut4("")
    method9(v1164, pattern_input_1[0], pattern_input_1[1])
    v1165: str = v1164.l0
    return trim_end(trim_start(((((((((("" + v772) + " ") + v1141) + " #") + str(v1160)) + " ") + v1(None)) + " / ") + v1165) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method13(v0: US0, v1: Callable[[], str]) -> None:
    def v4(v: US0, v0: Any=v0, v1: Any=v1) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
        return closure0(None, v)

    if State_trace_state() is None:
        State_trace_state(v4(US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v13: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v4(US0(0)))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v61: US0 = pattern_input_1[3].l0
    class ObjectExpr137:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr138:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (find(v0, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr137())) >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr138()))):
        v69: int64 = op_addition(v13.l0, int64(1))
        v13.l0 = v69
        v72: str = ("" + v1(None)) + ""
        _v81: None | None = None
        print(v72)
        _v81 = some(None)
        if _v81 is None:
            raise Exception("base.run_target / _v81=None")

        else: 
            value_1(_v81)

        pattern_input[1].l0(v72)



def method4(v0: US0, v1: Callable[[], str], v2_1: Callable[[], tuple[int, str]]) -> None:
    def v3_1(__unit: None=None, v0: Any=v0, v1: Any=v1, v2_1: Any=v2_1) -> str:
        return closure6(v0, v1, v2_1, None)

    method13(v0, v3_1)


def closure3(v0: str, v1: int) -> Async[bool]:
    _v4: Async[bool] | None = None
    _v4 = None
    if _v4 is None:
        raise Exception("base.run_target / _v4=None")

    else: 
        return _v4



def closure2(unit_var: None, v0: str) -> Callable[[int], Async[bool]]:
    def _arrow139(v: int, unit_var: Any=unit_var, v0: Any=v0) -> Async[bool]:
        return closure3(v0, v)

    return _arrow139


def closure10(unit_var: None, v0: bool) -> US5:
    return US5(0, v0)


def closure11(unit_var: None, v0: Exception) -> US5:
    return US5(1, v0)


def closure12(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async"


def closure13(v0: int, unit_var: None) -> int:
    return v0


def method15(v0: Mut4, v1: int) -> None:
    method10(v0, "{ ")
    method11(v0)
    method10(v0, "timeout")
    method10(v0, " = ")
    method12(v0, v1)
    method10(v0, " }")


def closure14(v0: US0, v1: Callable[[], str], v2_1: Callable[[], int], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v18: int64 | None = pattern_input[4]
    _v35: str | None = None
    _v480: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v18 is None:
        x_2 = None

    else: 
        x: int64 = v18
        def x_1(__unit: None=None, v0: Any=v0, v1: Any=v1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v480.contents = x_2
    v507: US2 = default_arg(_v480.contents, US2(1))
    def _arrow140(__unit: None=None, v0: Any=v0, v1: Any=v1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v539: Any = create(op_subtraction(ticks_1(now()), v507.fields[0]))
        return create_1(1, 1, 1, hours(v539), minutes(v539), seconds(v539), milliseconds(v539))

    x_3: str = to_string(_arrow140() if (v507.tag == 0) else now(), method7())
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
    method15(v1163, v2_1(None))
    v1164: str = v1163.l0
    return trim_end(trim_start(((((((((("" + v772) + " ") + v1141) + " #") + str(v1160)) + " ") + v1(None)) + " / ") + v1164) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method14(v0: US0, v1: Callable[[], str], v2_1: Callable[[], int]) -> None:
    def v3_1(__unit: None=None, v0: Any=v0, v1: Any=v1, v2_1: Any=v2_1) -> str:
        return closure14(v0, v1, v2_1, None)

    method13(v0, v3_1)


def closure15(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async**"


def closure16(v0: int, v1: Exception, unit_var: None) -> tuple[int, str]:
    _v4: str | None = None
    x: str = to_text(interpolate("%A%P()", [v1]))
    _v4 = x
    def _arrow141(__unit: None=None, v0: Any=v0, v1: Any=v1, unit_var: Any=unit_var) -> str:
        raise Exception("base.run_target / _v4=None")

    return (v0, _arrow141() if (_v4 is None) else _v4)


def method17(v0: Mut4, v1: int, v2_1: str) -> None:
    method10(v0, "{ ")
    method11(v0)
    method10(v0, "timeout")
    method10(v0, " = ")
    method12(v0, v1)
    method10(v0, "; ")
    method10(v0, "ex")
    method10(v0, " = ")
    method10(v0, v2_1)
    method10(v0, " }")


def closure17(v0: US0, v1: Callable[[], str], v2_1: Callable[[], tuple[int, str]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v18: int64 | None = pattern_input[4]
    _v35: str | None = None
    _v480: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v18 is None:
        x_2 = None

    else: 
        x: int64 = v18
        def x_1(__unit: None=None, v0: Any=v0, v1: Any=v1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v480.contents = x_2
    v507: US2 = default_arg(_v480.contents, US2(1))
    def _arrow142(__unit: None=None, v0: Any=v0, v1: Any=v1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v539: Any = create(op_subtraction(ticks_1(now()), v507.fields[0]))
        return create_1(1, 1, 1, hours(v539), minutes(v539), seconds(v539), milliseconds(v539))

    x_3: str = to_string(_arrow142() if (v507.tag == 0) else now(), method7())
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
    pattern_input_1: tuple[int, str] = v2_1(None)
    v1164: Mut4 = Mut4("")
    method17(v1164, pattern_input_1[0], pattern_input_1[1])
    v1165: str = v1164.l0
    return trim_end(trim_start(((((((((("" + v772) + " ") + v1141) + " #") + str(v1160)) + " ") + v1(None)) + " / ") + v1165) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method16(v0: US0, v1: Callable[[], str], v2_1: Callable[[], tuple[int, str]]) -> None:
    def v3_1(__unit: None=None, v0: Any=v0, v1: Any=v1, v2_1: Any=v2_1) -> str:
        return closure17(v0, v1, v2_1, None)

    method13(v0, v3_1)


def closure9(v0: int, v1: str, v2_1: int) -> Async[bool]:
    _v5: Async[bool] | None = None
    _v5 = None
    if _v5 is None:
        raise Exception("base.run_target / _v5=None")

    else: 
        return _v5



def closure8(v0: int, v1: str) -> Callable[[int], Async[bool]]:
    def _arrow143(v: int, v0: Any=v0, v1: Any=v1) -> Async[bool]:
        return closure9(v0, v1, v)

    return _arrow143


def closure7(unit_var: None, v0: int) -> Callable[[str, int], Async[bool]]:
    def _arrow144(v: str, unit_var: Any=unit_var, v0: Any=v0) -> Callable[[int], Async[bool]]:
        return closure8(v0, v)

    return _arrow144


def closure22(unit_var: None, unit_var_1: None) -> str:
    return "networking.wait_for_port_access"


def closure23(v0: int | None, v1: bool, v2_1: int, v3_1: int64, unit_var: None) -> tuple[int, int64, int | None, bool]:
    return (v2_1, v3_1, v0, v1)


def method21(v0: Mut4, v1: int64) -> None:
    v12_1: str = v0.l0 + (("" + str(v1)) + "")
    v0.l0 = v12_1


def method22(v0: Mut4, v1: int | None=None) -> None:
    method10(v0, to_text(interpolate("%A%P()", [v1])))


def method23(v0: Mut4, v1: bool) -> None:
    v4: str = "true" if v1 else "false"
    v15: str = v0.l0 + (("" + v4) + "")
    v0.l0 = v15


def method20(v0: Mut4, v1: int, v2_1: int64, v3_1: int | None, v4: bool) -> None:
    method10(v0, "{ ")
    method11(v0)
    method10(v0, "port")
    method10(v0, " = ")
    method12(v0, v1)
    method10(v0, "; ")
    method10(v0, "retry")
    method10(v0, " = ")
    method21(v0, v2_1)
    method10(v0, "; ")
    method10(v0, "timeout")
    method10(v0, " = ")
    method22(v0, v3_1)
    method10(v0, "; ")
    method10(v0, "status")
    method10(v0, " = ")
    method23(v0, v4)
    method10(v0, " }")


def closure24(v0: US0, v1: Callable[[], str], v2_1: Callable[[], tuple[int, int64, int | None, bool]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v18: int64 | None = pattern_input[4]
    _v35: str | None = None
    _v480: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v18 is None:
        x_2 = None

    else: 
        x: int64 = v18
        def x_1(__unit: None=None, v0: Any=v0, v1: Any=v1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v480.contents = x_2
    v507: US2 = default_arg(_v480.contents, US2(1))
    def _arrow145(__unit: None=None, v0: Any=v0, v1: Any=v1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v539: Any = create(op_subtraction(ticks_1(now()), v507.fields[0]))
        return create_1(1, 1, 1, hours(v539), minutes(v539), seconds(v539), milliseconds(v539))

    x_3: str = to_string(_arrow145() if (v507.tag == 0) else now(), method7())
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
    pattern_input_1: tuple[int, int64, int | None, bool] = v2_1(None)
    v1166: Mut4 = Mut4("")
    method20(v1166, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2], pattern_input_1[3])
    v1167: str = v1166.l0
    return trim_end(trim_start(((((((((("" + v772) + " ") + v1141) + " #") + str(v1160)) + " ") + v1(None)) + " / ") + v1167) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method19(v0: US0, v1: Callable[[], str], v2_1: Callable[[], tuple[int, int64, int | None, bool]]) -> None:
    def v3_1(__unit: None=None, v0: Any=v0, v1: Any=v1, v2_1: Any=v2_1) -> str:
        return closure24(v0, v1, v2_1, None)

    method13(v0, v3_1)


def method18(v0: int | None, v1: bool, v2_1: str, v3_1: int, v4: int64) -> Async[int64]:
    _v7: Async[int64] | None = None
    _v7 = None
    if _v7 is None:
        raise Exception("base.run_target / _v7=None")

    else: 
        return _v7



def closure21(v0: int | None, v1: bool, v2_1: str, v3_1: int) -> Async[int64]:
    return method18(v0, v1, v2_1, v3_1, int64(0))


def closure20(v0: int | None, v1: bool, v2_1: str) -> Callable[[int], Async[int64]]:
    def _arrow146(v: int, v0: Any=v0, v1: Any=v1, v2_1: Any=v2_1) -> Async[int64]:
        return closure21(v0, v1, v2_1, v)

    return _arrow146


def closure19(v0: int | None, v1: bool) -> Callable[[str, int], Async[int64]]:
    def _arrow147(v: str, v0: Any=v0, v1: Any=v1) -> Callable[[int], Async[int64]]:
        return closure20(v0, v1, v)

    return _arrow147


def closure18(unit_var: None, v0: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    def _arrow148(v: bool, unit_var: Any=unit_var, v0: Any=v0) -> Callable[[str, int], Async[int64]]:
        return closure19(v0, v)

    return _arrow148


def method24(v0: int | None, v1: str, v2_1: int) -> Async[int]:
    _v5: Async[int] | None = None
    _v5 = None
    if _v5 is None:
        raise Exception("base.run_target / _v5=None")

    else: 
        return _v5



def closure27(v0: int | None, v1: str, v2_1: int) -> Async[int]:
    return method24(v0, v1, v2_1)


def closure26(v0: int | None, v1: str) -> Callable[[int], Async[int]]:
    def _arrow149(v: int, v0: Any=v0, v1: Any=v1) -> Async[int]:
        return closure27(v0, v1, v)

    return _arrow149


def closure25(unit_var: None, v0: int | None=None) -> Callable[[str, int], Async[int]]:
    def _arrow150(v: str, unit_var: Any=unit_var, v0: Any=v0) -> Callable[[int], Async[int]]:
        return closure26(v0, v)

    return _arrow150


def _arrow151(v: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
    return closure0(None, v)


v2: Callable[[US0], tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]] = _arrow151

v3: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v2(v3))


def _arrow152(v: str) -> Callable[[int], Async[bool]]:
    return closure2(None, v)


v9: Callable[[str, int], Async[bool]] = _arrow152

def test_port_open(x: str) -> Callable[[int], Async[bool]]:
    return v9(x)


def _arrow153(v: int) -> Callable[[str, int], Async[bool]]:
    return closure7(None, v)


v10: Callable[[int, str, int], Async[bool]] = _arrow153

def test_port_open_timeout(x: int) -> Callable[[str, int], Async[bool]]:
    return v10(x)


def _arrow154(v: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return closure18(None, v)


v11: Callable[[int | None, bool, str, int], Async[int64]] = _arrow154

def wait_for_port_access(x: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return v11(x)


def _arrow155(v: int | None=None) -> Callable[[str, int], Async[int]]:
    return closure25(None, v)


v12: Callable[[int | None, str, int], Async[int]] = _arrow155

def get_available_port(x: int | None=None) -> Callable[[str, int], Async[int]]:
    return v12(x)


