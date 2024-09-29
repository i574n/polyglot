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
from fable_modules.fable_library.option import (some, value as value_1, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type, class_type, int32_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, to_text, interpolate)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare)

TraceState_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr123() -> TypeInfo:
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


US0_reflection = _expr123

def _expr124() -> TypeInfo:
    return record_type("Networking.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr124

def _expr125() -> TypeInfo:
    return record_type("Networking.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr125

def _expr126() -> TypeInfo:
    return record_type("Networking.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr126

def _expr127() -> TypeInfo:
    return record_type("Networking.Mut3", [], Mut3, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: str

Mut3_reflection = _expr127

def _expr128() -> TypeInfo:
    return record_type("Networking.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr128

def _expr129() -> TypeInfo:
    return union_type("Networking.US1", [], US1, lambda: [[("f0_0", string_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr129

def _expr130() -> TypeInfo:
    return union_type("Networking.US2", [], US2, lambda: [[("f0_0", US0_reflection())], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr130

def _expr131() -> TypeInfo:
    return union_type("Networking.US3", [], US3, lambda: [[("f0_0", int64_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr131

def _expr132() -> TypeInfo:
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


US4_reflection = _expr132

def _expr133() -> TypeInfo:
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


US5_reflection = _expr133

def _expr134() -> TypeInfo:
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


US6_reflection = _expr134

def _expr135() -> TypeInfo:
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


US7_reflection = _expr135

def method1(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method3(__unit: None=None) -> str:
    return ""


def closure1(unit_var: None, v0_1: str) -> US1:
    return US1(0, v0_1)


def method4(__unit: None=None) -> Callable[[str], US1]:
    def _arrow136(v: str) -> US1:
        return closure1(None, v)

    return _arrow136


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
    def _arrow137(__unit: None=None, v0_1: Any=v0_1) -> US2:
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




    _v1: tuple[US2, US3] = (US2(0, v235.fields[0]) if (v235.tag == 0) else _arrow137(), US3(0, ticks_1(now())) if (method2(method5()) == "True") else US3(1))
    v352: US3 = _v1[1]
    v351: US2 = _v1[0]
    def v417(v: str, v0_1: Any=v0_1) -> None:
        closure2(None, v)

    return (Mut0(int64(1)), Mut1(v417), Mut2(True), Mut3(""), Mut4(v351.fields[0] if (v351.tag == 0) else v0_1), v352.fields[0] if (v352.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = method0(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def closure6(unit_var: None, v0_1: int64) -> US3:
    return US3(0, v0_1)


def method7(__unit: None=None) -> Callable[[int64], US3]:
    def _arrow138(v: int64) -> US3:
        return closure6(None, v)

    return _arrow138


def method8(__unit: None=None) -> str:
    return "hh:mm:ss"


def method9(__unit: None=None) -> str:
    return "HH:mm:ss"


def method6(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None=None) -> str:
    v238: US3 = default_arg(map(method7(), v5), US3(1))
    def _arrow139(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4, v5: Any=v5) -> Any:
        v252: Any = create(op_subtraction(ticks_1(now()), v238.fields[0]))
        return create_1(1, 1, 1, hours(v252), minutes(v252), seconds(v252), milliseconds(v252))

    return to_string(_arrow139() if (v238.tag == 0) else now(), method9())


def method11(__unit: None=None) -> str:
    return "\u001b[0m"


def method10(__unit: None=None) -> str:
    return ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method11()


def method13(__unit: None=None) -> str:
    return ""


def closure7(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def method12(v0_1: int, v1_1: str) -> str:
    v3: Mut3 = Mut3(method13())
    v10: None
    closure7(v3, ("" + "{ ") + "", None)
    v10 = None
    v19_1: None
    closure7(v3, ("" + "port") + "", None)
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
    closure7(v3, ("" + "ex") + "", None)
    v54 = None
    v62: None
    closure7(v3, ("" + " = ") + "", None)
    v62 = None
    v70: None
    closure7(v3, ("" + v1_1) + "", None)
    v70 = None
    v79: None
    closure7(v3, ("" + " }") + "", None)
    v79 = None
    return v3.l0


def method14(v0_1: str, v1_1: str, v2_1: str, v3: int64, v4: str) -> str:
    return trim_end(trim_start(((((((((("" + v0_1) + " ") + v1_1) + " #") + str(v3)) + " ") + v2_1) + " / ") + v4) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def closure8(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure10(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure9(unit_var: None, v0_1: str) -> None:
    v3: None
    closure10(v0_1, None)
    v3 = None


def method15(v0_1: str, v1_1: Mut0, v2_1: Mut1, v3: Mut2, v4: Mut3, v5: Mut4, v6: int64 | None=None) -> None:
    v9: None
    closure8(v1_1, None)
    v9 = None
    closure9(None, v0_1)
    v2_1.l0(v0_1)


def closure5(v0_1: int, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr140:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (0 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr140()))):
        v43: None
        v3(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v83: str = method14(method6(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method10(), "networking.test_port_open", v57.l0, method12(v0_1, v1_1))
        v85: None
        v3(None)
        v85 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        method15(v83, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure4(v0_1: str, v1_1: int) -> Async[bool]:
    return None


def closure3(unit_var: None, v0_1: str) -> Callable[[int], Async[bool]]:
    def _arrow141(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[bool]:
        return closure4(v0_1, v)

    return _arrow141


def closure14(unit_var: None, v0_1: bool) -> US5:
    return US5(0, v0_1)


def closure15(unit_var: None, v0_1: Exception) -> US5:
    return US5(1, v0_1)


def method16(v0_1: int) -> str:
    v2_1: Mut3 = Mut3(method13())
    v9: None
    closure7(v2_1, ("" + "{ ") + "", None)
    v9 = None
    v18_1: None
    closure7(v2_1, ("" + "timeout") + "", None)
    v18_1 = None
    v27: None
    closure7(v2_1, ("" + " = ") + "", None)
    v27 = None
    v35: None
    closure7(v2_1, ("" + str(v0_1)) + "", None)
    v35 = None
    v44: None
    closure7(v2_1, ("" + " }") + "", None)
    v44 = None
    return v2_1.l0


def closure16(v0_1: int, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v35: US0 = pattern_input[4].l0
    class ObjectExpr142:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (0 >= find(v35, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr142()))):
        v42: None
        v2_1(None)
        v42 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        v56: Mut0 = pattern_input_1[0]
        v82: str = method14(method6(v56, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method10(), "async.run_with_timeout_async", v56.l0, method16(v0_1))
        v84: None
        v2_1(None)
        v84 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        method15(v82, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method17(__unit: None=None) -> str:
    return ("\u001b[91m" + pad_left("Critical".lower(), 7, " ")) + method11()


def method18(v0_1: int, v1_1: str) -> str:
    v3: Mut3 = Mut3(method13())
    v10: None
    closure7(v3, ("" + "{ ") + "", None)
    v10 = None
    v19_1: None
    closure7(v3, ("" + "timeout") + "", None)
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
    closure7(v3, ("" + "ex") + "", None)
    v54 = None
    v62: None
    closure7(v3, ("" + " = ") + "", None)
    v62 = None
    v70: None
    closure7(v3, ("" + v1_1) + "", None)
    v70 = None
    v79: None
    closure7(v3, ("" + " }") + "", None)
    v79 = None
    return v3.l0


def closure17(v0_1: int, v1_1: Exception, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr143:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (4 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr143()))):
        v43: None
        v3(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v105: str = method14(method6(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method17(), "async.run_with_timeout_async**", v57.l0, method18(v0_1, to_text(interpolate("%A%P()", [v1_1]))))
        v107: None
        v3(None)
        v107 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        method15(v105, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure13(v0_1: int, v1_1: str, v2_1: int) -> Async[bool]:
    return None


def closure12(v0_1: int, v1_1: str) -> Callable[[int], Async[bool]]:
    def _arrow144(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[bool]:
        return closure13(v0_1, v1_1, v)

    return _arrow144


def closure11(unit_var: None, v0_1: int) -> Callable[[str, int], Async[bool]]:
    def _arrow145(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[bool]]:
        return closure12(v0_1, v)

    return _arrow145


def closure22(unit_var: None, v0_1: int) -> US7:
    return US7(0, v0_1)


def method20(__unit: None=None) -> Callable[[int], US7]:
    def _arrow146(v: int) -> US7:
        return closure22(None, v)

    return _arrow146


def method21(v0_1: int, v1_1: int64, v2_1: int | None, v3: bool) -> str:
    v5: Mut3 = Mut3(method13())
    v12: None
    closure7(v5, ("" + "{ ") + "", None)
    v12 = None
    v21: None
    closure7(v5, ("" + "port") + "", None)
    v21 = None
    v30: None
    closure7(v5, ("" + " = ") + "", None)
    v30 = None
    v38: None
    closure7(v5, ("" + str(v0_1)) + "", None)
    v38 = None
    v47: None
    closure7(v5, ("" + "; ") + "", None)
    v47 = None
    v56: None
    closure7(v5, ("" + "retry") + "", None)
    v56 = None
    v64: None
    closure7(v5, ("" + " = ") + "", None)
    v64 = None
    v72: None
    closure7(v5, ("" + str(v1_1)) + "", None)
    v72 = None
    v80: None
    closure7(v5, ("" + "; ") + "", None)
    v80 = None
    v89: None
    closure7(v5, ("" + "timeout") + "", None)
    v89 = None
    v97: None
    closure7(v5, ("" + " = ") + "", None)
    v97 = None
    v132: None
    closure7(v5, ("" + to_text(interpolate("%A%P()", [v2_1]))) + "", None)
    v132 = None
    v140: None
    closure7(v5, ("" + "; ") + "", None)
    v140 = None
    v149: None
    closure7(v5, ("" + "status") + "", None)
    v149 = None
    v157: None
    closure7(v5, ("" + " = ") + "", None)
    v157 = None
    v168: None
    closure7(v5, ("" + ("true" if v3 else "false")) + "", None)
    v168 = None
    v177: None
    closure7(v5, ("" + " }") + "", None)
    v177 = None
    return v5.l0


def method22(v0_1: str, v1_1: str, v2_1: int64, v3: str) -> str:
    return trim_end(trim_start(((((((((("" + v0_1) + " ") + v1_1) + " #") + str(v2_1)) + " ") + "networking.wait_for_port_access") + " / ") + v3) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def closure23(v0_1: int | None, v1_1: bool, v2_1: int, v3: int64, unit_var: None) -> None:
    def v5(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v6: None
    v5(None)
    v6 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v38: US0 = pattern_input[4].l0
    class ObjectExpr147:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (0 >= find(v38, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr147()))):
        v45: None
        v5(None)
        v45 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        v59: Mut0 = pattern_input_1[0]
        v81: str = method22(method6(v59, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method10(), v59.l0, method21(v2_1, v3, v0_1, v1_1))
        v83: None
        v5(None)
        v83 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        method15(v81, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method19(v0_1: int | None, v1_1: bool, v2_1: str, v3: int, v4: int64) -> Async[int64]:
    return None


def closure21(v0_1: int | None, v1_1: bool, v2_1: str, v3: int) -> Async[int64]:
    return method19(v0_1, v1_1, v2_1, v3, int64(0))


def closure20(v0_1: int | None, v1_1: bool, v2_1: str) -> Callable[[int], Async[int64]]:
    def _arrow148(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> Async[int64]:
        return closure21(v0_1, v1_1, v2_1, v)

    return _arrow148


def closure19(v0_1: int | None, v1_1: bool) -> Callable[[str, int], Async[int64]]:
    def _arrow149(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Callable[[int], Async[int64]]:
        return closure20(v0_1, v1_1, v)

    return _arrow149


def closure18(unit_var: None, v0_1: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    def _arrow150(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str, int], Async[int64]]:
        return closure19(v0_1, v)

    return _arrow150


def method23(v0_1: int | None, v1_1: str, v2_1: int) -> Async[int]:
    return None


def closure26(v0_1: int | None, v1_1: str, v2_1: int) -> Async[int]:
    return method23(v0_1, v1_1, v2_1)


def closure25(v0_1: int | None, v1_1: str) -> Callable[[int], Async[int]]:
    def _arrow151(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[int]:
        return closure26(v0_1, v1_1, v)

    return _arrow151


def closure24(unit_var: None, v0_1: int | None=None) -> Callable[[str, int], Async[int]]:
    def _arrow152(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[int]]:
        return closure25(v0_1, v)

    return _arrow152


v0: None = None

def _arrow153(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow153

def _expr154():
    v1(None)
    return v0


v2: None = _expr154()

def _arrow155(v: str) -> Callable[[int], Async[bool]]:
    return closure3(None, v)


v16: Callable[[str, int], Async[bool]] = _arrow155

def test_port_open(x: str) -> Callable[[int], Async[bool]]:
    return v16(x)


def _arrow156(v: int) -> Callable[[str, int], Async[bool]]:
    return closure11(None, v)


v17: Callable[[int, str, int], Async[bool]] = _arrow156

def test_port_open_timeout(x: int) -> Callable[[str, int], Async[bool]]:
    return v17(x)


def _arrow157(v: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return closure18(None, v)


v18: Callable[[int | None, bool, str, int], Async[int64]] = _arrow157

def wait_for_port_access(x: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return v18(x)


def _arrow158(v: int | None=None) -> Callable[[str, int], Async[int]]:
    return closure24(None, v)


v19: Callable[[int | None, str, int], Async[int]] = _arrow158

def get_available_port(x: int | None=None) -> Callable[[str, int], Async[int]]:
    return v19(x)


