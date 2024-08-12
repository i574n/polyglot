from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.async_builder import Async
from fable_modules.fable_library.date import (ticks as ticks_1, now, to_string, create as create_1)
from fable_modules.fable_library.list import (to_array, empty, of_array)
from fable_modules.fable_library.long import (op_addition, op_subtraction)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_1, default_arg)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type, class_type, int32_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, to_text, interpolate)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, ignore, to_enumerable, compare)

State_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] | None = create_atom(None)

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
    return record_type("Networking.Mut3", [], Mut3, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: US0

Mut3_reflection = _expr127

def _expr128() -> TypeInfo:
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


US1_reflection = _expr128

def _expr129() -> TypeInfo:
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


US2_reflection = _expr129

def _expr130() -> TypeInfo:
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


US3_reflection = _expr130

def _expr131() -> TypeInfo:
    return record_type("Networking.Mut4", [], Mut4, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: str

Mut4_reflection = _expr131

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


def closure1(v0_1: FSharpRef[US1 | None], v1_1: US1 | None=None) -> FSharpRef[US1 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure2(v0_1: str | None, v1_1: Callable[[US1 | None], FSharpRef[US1 | None]], unit_var: None) -> None:
    def _arrow136(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US1 | None:
        x: str = v0_1
        def x_1(__unit: None=None) -> US1:
            return US1(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow136()))


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
    v82: US1 = default_arg(_v64.contents, US1(1))
    if v82.tag == 0:
        return v82.fields[0]

    else: 
        return ""



def method4(__unit: None=None) -> str:
    return "AUTOMATION"


def closure3(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
    v173: str = method2(method1())
    v178: US2 = US2(0, US0(0)) if ("Verbose" == v173) else US2(1)
    def _arrow137(__unit: None=None, v0_1: Any=v0_1) -> US2:
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




    _v1: tuple[US2, US3] = (US2(0, v178.fields[0]) if (v178.tag == 0) else _arrow137(), US3(0, ticks_1(now())) if (method2(method4()) == "True") else US3(1))
    v295: US3 = _v1[1]
    v294: US2 = _v1[0]
    def v365(v: str, v0_1: Any=v0_1) -> None:
        closure3(None, v)

    return (Mut0(int64(0)), Mut1(v365), Mut2(True), Mut3(v294.fields[0] if (v294.tag == 0) else v0_1), v295.fields[0] if (v295.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if State_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
        State_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4]))



def closure7(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure8(v0_1: FSharpRef[US3 | None], v1_1: US3 | None=None) -> FSharpRef[US3 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure9(v0_1: int64 | None, v1_1: Callable[[US3 | None], FSharpRef[US3 | None]], unit_var: None) -> None:
    def _arrow138(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US3 | None:
        x: int64 = v0_1
        def x_1(__unit: None=None) -> US3:
            return US3(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow138()))


def method5(__unit: None=None) -> str:
    return "hh:mm:ss"


def method6(__unit: None=None) -> str:
    return "HH:mm:ss"


def method7(__unit: None=None) -> str:
    return "\u001b[0m"


def method8(__unit: None=None) -> str:
    return ""


def closure10(v0_1: Mut4, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def closure11(unit_var: None, unit_var_1: None) -> str:
    return "networking.test_port_open"


def closure6(v0_1: int, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v23: None
    v3(None)
    v23 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v41: US0 = pattern_input_1[3].l0
    class ObjectExpr139:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v41, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr139()))):
        v49: None
        closure7(pattern_input[0], None)
        v49 = None
        v51: None
        v3(None)
        v51 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
        _v308: FSharpRef[US3 | None] = FSharpRef(None)
        v313: None
        def v310(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v308, v)

        closure9(pattern_input_2[4], v310, None)
        v313 = None
        v326: US3 = default_arg(_v308.contents, US3(1))
        def _arrow140(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v340: Any = create(op_subtraction(ticks_1(now()), v326.fields[0]))
            return create_1(1, 1, 1, hours(v340), minutes(v340), seconds(v340), milliseconds(v340))

        v371: str = to_string(_arrow140() if (v326.tag == 0) else now(), method6())
        v568: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method7()
        v579: int64 = pattern_input_2[0].l0
        v581: Mut4 = Mut4(method8())
        v588: None
        closure10(v581, ("" + "{ ") + "", None)
        v588 = None
        v595: None
        closure10(v581, ("" + "port") + "", None)
        v595 = None
        v602: None
        closure10(v581, ("" + " = ") + "", None)
        v602 = None
        v608: None
        closure10(v581, ("" + str(v0_1)) + "", None)
        v608 = None
        v615: None
        closure10(v581, ("" + "; ") + "", None)
        v615 = None
        v622: None
        closure10(v581, ("" + "ex") + "", None)
        v622 = None
        v628: None
        closure10(v581, ("" + " = ") + "", None)
        v628 = None
        v634: None
        closure10(v581, ("" + v1_1) + "", None)
        v634 = None
        v641: None
        closure10(v581, ("" + " }") + "", None)
        v641 = None
        v642: str = v581.l0
        v681: str = trim_end(trim_start(((((((((("" + v371) + " ") + v568) + " #") + str(v579)) + " ") + closure11(None, None)) + " / ") + v642) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v681)
        pattern_input[1].l0(v681)



def closure5(v0_1: str, v1_1: int) -> Async[bool]:
    return None


def closure4(unit_var: None, v0_1: str) -> Callable[[int], Async[bool]]:
    def _arrow141(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[bool]:
        return closure5(v0_1, v)

    return _arrow141


def closure15(unit_var: None, v0_1: bool) -> US5:
    return US5(0, v0_1)


def closure16(unit_var: None, v0_1: Exception) -> US5:
    return US5(1, v0_1)


def closure18(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async"


def closure17(v0_1: int, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v22: None
    v2_1(None)
    v22 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v40: US0 = pattern_input_1[3].l0
    class ObjectExpr142:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v40, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr142()))):
        v48: None
        closure7(pattern_input[0], None)
        v48 = None
        v50: None
        v2_1(None)
        v50 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
        _v307: FSharpRef[US3 | None] = FSharpRef(None)
        v312: None
        def v309(v: US3 | None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v307, v)

        closure9(pattern_input_2[4], v309, None)
        v312 = None
        v325: US3 = default_arg(_v307.contents, US3(1))
        def _arrow143(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v339: Any = create(op_subtraction(ticks_1(now()), v325.fields[0]))
            return create_1(1, 1, 1, hours(v339), minutes(v339), seconds(v339), milliseconds(v339))

        v370: str = to_string(_arrow143() if (v325.tag == 0) else now(), method6())
        v567: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method7()
        v578: int64 = pattern_input_2[0].l0
        v580: Mut4 = Mut4(method8())
        v587: None
        closure10(v580, ("" + "{ ") + "", None)
        v587 = None
        v594: None
        closure10(v580, ("" + "timeout") + "", None)
        v594 = None
        v601: None
        closure10(v580, ("" + " = ") + "", None)
        v601 = None
        v607: None
        closure10(v580, ("" + str(v0_1)) + "", None)
        v607 = None
        v614: None
        closure10(v580, ("" + " }") + "", None)
        v614 = None
        v615: str = v580.l0
        v654: str = trim_end(trim_start(((((((((("" + v370) + " ") + v567) + " #") + str(v578)) + " ") + closure18(None, None)) + " / ") + v615) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v654)
        pattern_input[1].l0(v654)



def closure20(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async**"


def closure19(v0_1: int, v1_1: Exception, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v23: None
    v3(None)
    v23 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v41: US0 = pattern_input_1[3].l0
    class ObjectExpr144:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (4 >= find(v41, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr144()))):
        v49: None
        closure7(pattern_input[0], None)
        v49 = None
        v51: None
        v3(None)
        v51 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
        _v308: FSharpRef[US3 | None] = FSharpRef(None)
        v313: None
        def v310(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v308, v)

        closure9(pattern_input_2[4], v310, None)
        v313 = None
        v326: US3 = default_arg(_v308.contents, US3(1))
        def _arrow145(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v340: Any = create(op_subtraction(ticks_1(now()), v326.fields[0]))
            return create_1(1, 1, 1, hours(v340), minutes(v340), seconds(v340), milliseconds(v340))

        v371: str = to_string(_arrow145() if (v326.tag == 0) else now(), method6())
        v568: str = ("\u001b[91m" + pad_left("Critical".lower(), 7, " ")) + method7()
        v579: int64 = pattern_input_2[0].l0
        v593: str = to_text(interpolate("%A%P()", [v1_1]))
        v603: Mut4 = Mut4(method8())
        v610: None
        closure10(v603, ("" + "{ ") + "", None)
        v610 = None
        v617: None
        closure10(v603, ("" + "timeout") + "", None)
        v617 = None
        v624: None
        closure10(v603, ("" + " = ") + "", None)
        v624 = None
        v630: None
        closure10(v603, ("" + str(v0_1)) + "", None)
        v630 = None
        v637: None
        closure10(v603, ("" + "; ") + "", None)
        v637 = None
        v644: None
        closure10(v603, ("" + "ex") + "", None)
        v644 = None
        v650: None
        closure10(v603, ("" + " = ") + "", None)
        v650 = None
        v656: None
        closure10(v603, ("" + v593) + "", None)
        v656 = None
        v663: None
        closure10(v603, ("" + " }") + "", None)
        v663 = None
        v664: str = v603.l0
        v703: str = trim_end(trim_start(((((((((("" + v371) + " ") + v568) + " #") + str(v579)) + " ") + closure20(None, None)) + " / ") + v664) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v703)
        pattern_input[1].l0(v703)



def closure14(v0_1: int, v1_1: str, v2_1: int) -> Async[bool]:
    return None


def closure13(v0_1: int, v1_1: str) -> Callable[[int], Async[bool]]:
    def _arrow146(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[bool]:
        return closure14(v0_1, v1_1, v)

    return _arrow146


def closure12(unit_var: None, v0_1: int) -> Callable[[str, int], Async[bool]]:
    def _arrow147(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[bool]]:
        return closure13(v0_1, v)

    return _arrow147


def closure25(v0_1: FSharpRef[US7 | None], v1_1: US7 | None=None) -> FSharpRef[US7 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure26(v0_1: int | None, v1_1: Callable[[US7 | None], FSharpRef[US7 | None]], unit_var: None) -> None:
    def _arrow148(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US7 | None:
        x: int = v0_1 or 0
        def x_1(__unit: None=None) -> US7:
            return US7(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow148()))


def closure28(unit_var: None, unit_var_1: None) -> str:
    return "networking.wait_for_port_access"


def closure27(v0_1: int | None, v1_1: bool, v2_1: int, v3: int64, unit_var: None) -> None:
    def v5_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v6_1: None
    v5_1(None)
    v6_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v25: None
    v5_1(None)
    v25 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v43: US0 = pattern_input_1[3].l0
    class ObjectExpr149:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v43, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr149()))):
        v51: None
        closure7(pattern_input[0], None)
        v51 = None
        v53: None
        v5_1(None)
        v53 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
        _v310: FSharpRef[US3 | None] = FSharpRef(None)
        v315: None
        def v312(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v310, v)

        closure9(pattern_input_2[4], v312, None)
        v315 = None
        v328: US3 = default_arg(_v310.contents, US3(1))
        def _arrow150(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, unit_var: Any=unit_var) -> Any:
            v342: Any = create(op_subtraction(ticks_1(now()), v328.fields[0]))
            return create_1(1, 1, 1, hours(v342), minutes(v342), seconds(v342), milliseconds(v342))

        v373: str = to_string(_arrow150() if (v328.tag == 0) else now(), method6())
        v570: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method7()
        v581: int64 = pattern_input_2[0].l0
        v583: Mut4 = Mut4(method8())
        v590: None
        closure10(v583, ("" + "{ ") + "", None)
        v590 = None
        v597: None
        closure10(v583, ("" + "port") + "", None)
        v597 = None
        v604: None
        closure10(v583, ("" + " = ") + "", None)
        v604 = None
        v610: None
        closure10(v583, ("" + str(v2_1)) + "", None)
        v610 = None
        v617: None
        closure10(v583, ("" + "; ") + "", None)
        v617 = None
        v624: None
        closure10(v583, ("" + "retry") + "", None)
        v624 = None
        v630: None
        closure10(v583, ("" + " = ") + "", None)
        v630 = None
        v636: None
        closure10(v583, ("" + str(v3)) + "", None)
        v636 = None
        v642: None
        closure10(v583, ("" + "; ") + "", None)
        v642 = None
        v649: None
        closure10(v583, ("" + "timeout") + "", None)
        v649 = None
        v655: None
        closure10(v583, ("" + " = ") + "", None)
        v655 = None
        v688: None
        closure10(v583, ("" + to_text(interpolate("%A%P()", [v0_1]))) + "", None)
        v688 = None
        v694: None
        closure10(v583, ("" + "; ") + "", None)
        v694 = None
        v701: None
        closure10(v583, ("" + "status") + "", None)
        v701 = None
        v707: None
        closure10(v583, ("" + " = ") + "", None)
        v707 = None
        v716: None
        closure10(v583, ("" + ("true" if v1_1 else "false")) + "", None)
        v716 = None
        v723: None
        closure10(v583, ("" + " }") + "", None)
        v723 = None
        v724: str = v583.l0
        v763: str = trim_end(trim_start(((((((((("" + v373) + " ") + v570) + " #") + str(v581)) + " ") + closure28(None, None)) + " / ") + v724) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v763)
        pattern_input[1].l0(v763)



def method9(v0_1: int | None, v1_1: bool, v2_1: str, v3: int, v4: int64) -> Async[int64]:
    return None


def closure24(v0_1: int | None, v1_1: bool, v2_1: str, v3: int) -> Async[int64]:
    return method9(v0_1, v1_1, v2_1, v3, int64(0))


def closure23(v0_1: int | None, v1_1: bool, v2_1: str) -> Callable[[int], Async[int64]]:
    def _arrow151(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> Async[int64]:
        return closure24(v0_1, v1_1, v2_1, v)

    return _arrow151


def closure22(v0_1: int | None, v1_1: bool) -> Callable[[str, int], Async[int64]]:
    def _arrow152(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Callable[[int], Async[int64]]:
        return closure23(v0_1, v1_1, v)

    return _arrow152


def closure21(unit_var: None, v0_1: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    def _arrow153(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str, int], Async[int64]]:
        return closure22(v0_1, v)

    return _arrow153


def method10(v0_1: int | None, v1_1: str, v2_1: int) -> Async[int]:
    return None


def closure31(v0_1: int | None, v1_1: str, v2_1: int) -> Async[int]:
    return method10(v0_1, v1_1, v2_1)


def closure30(v0_1: int | None, v1_1: str) -> Callable[[int], Async[int]]:
    def _arrow154(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[int]:
        return closure31(v0_1, v1_1, v)

    return _arrow154


def closure29(unit_var: None, v0_1: int | None=None) -> Callable[[str, int], Async[int]]:
    def _arrow155(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[int]]:
        return closure30(v0_1, v)

    return _arrow155


v0: None = None

def _arrow156(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow156

def _expr157():
    v1(None)
    return v0


v2: None = _expr157()

def _arrow158(v: str) -> Callable[[int], Async[bool]]:
    return closure4(None, v)


v5: Callable[[str, int], Async[bool]] = _arrow158

def test_port_open(x: str) -> Callable[[int], Async[bool]]:
    return v5(x)


def _arrow159(v: int) -> Callable[[str, int], Async[bool]]:
    return closure12(None, v)


v6: Callable[[int, str, int], Async[bool]] = _arrow159

def test_port_open_timeout(x: int) -> Callable[[str, int], Async[bool]]:
    return v6(x)


def _arrow160(v: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return closure21(None, v)


v7: Callable[[int | None, bool, str, int], Async[int64]] = _arrow160

def wait_for_port_access(x: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return v7(x)


def _arrow161(v: int | None=None) -> Callable[[str, int], Async[int]]:
    return closure29(None, v)


v8: Callable[[int | None, str, int], Async[int]] = _arrow161

def get_available_port(x: int | None=None) -> Callable[[str, int], Async[int]]:
    return v8(x)


