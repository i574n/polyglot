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
    def v360(v: str, v0_1: Any=v0_1) -> None:
        closure3(None, v)

    return (Mut0(int64(0)), Mut1(v360), Mut2(True), Mut3(""), Mut4(v294.fields[0] if (v294.tag == 0) else v0_1), v295.fields[0] if (v295.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = method0(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



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


def closure10(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def closure12(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure11(unit_var: None, v0_1: str) -> None:
    v3: None
    closure12(v0_1, None)
    v3 = None


def closure6(v0_1: int, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v37: None
    v3(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr139:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr139()))):
        v77: None
        closure7(pattern_input[0], None)
        v77 = None
        v81: None
        v3(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v360, v)

        closure9(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow140(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow140() if (v380.tag == 0) else now(), method6())
        v626: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method7()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method8())
        v646: None
        closure10(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure10(v639, ("" + "port") + "", None)
        v655 = None
        v664: None
        closure10(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure10(v639, ("" + str(v0_1)) + "", None)
        v672 = None
        v681: None
        closure10(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure10(v639, ("" + "ex") + "", None)
        v690 = None
        v698: None
        closure10(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure10(v639, ("" + v1_1) + "", None)
        v706 = None
        v715: None
        closure10(v639, ("" + " }") + "", None)
        v715 = None
        v777: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "networking.test_port_open") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v777)
        pattern_input[1].l0(v777)



def closure5(v0_1: str, v1_1: int) -> Async[bool]:
    return None


def closure4(unit_var: None, v0_1: str) -> Callable[[int], Async[bool]]:
    def _arrow141(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[bool]:
        return closure5(v0_1, v)

    return _arrow141


def closure16(unit_var: None, v0_1: bool) -> US5:
    return US5(0, v0_1)


def closure17(unit_var: None, v0_1: Exception) -> US5:
    return US5(1, v0_1)


def closure18(v0_1: int, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v36: None
    v2_1(None)
    v36 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v68: US0 = pattern_input_1[4].l0
    class ObjectExpr142:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v68, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr142()))):
        v76: None
        closure7(pattern_input[0], None)
        v76 = None
        v80: None
        v2_1(None)
        v80 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        _v359: FSharpRef[US3 | None] = FSharpRef(None)
        v364: None
        def v361(v: US3 | None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v359, v)

        closure9(pattern_input_2[5], v361, None)
        v364 = None
        v379: US3 = default_arg(_v359.contents, US3(1))
        def _arrow143(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v393: Any = create(op_subtraction(ticks_1(now()), v379.fields[0]))
            return create_1(1, 1, 1, hours(v393), minutes(v393), seconds(v393), milliseconds(v393))

        v424: str = to_string(_arrow143() if (v379.tag == 0) else now(), method6())
        v625: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method7()
        v636: int64 = pattern_input_2[0].l0
        v638: Mut3 = Mut3(method8())
        v645: None
        closure10(v638, ("" + "{ ") + "", None)
        v645 = None
        v654: None
        closure10(v638, ("" + "timeout") + "", None)
        v654 = None
        v663: None
        closure10(v638, ("" + " = ") + "", None)
        v663 = None
        v671: None
        closure10(v638, ("" + str(v0_1)) + "", None)
        v671 = None
        v680: None
        closure10(v638, ("" + " }") + "", None)
        v680 = None
        v742: str = trim_end(trim_start(((((((((("" + v424) + " ") + v625) + " #") + str(v636)) + " ") + "async.run_with_timeout_async") + " / ") + v638.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v742)
        pattern_input[1].l0(v742)



def closure19(v0_1: int, v1_1: Exception, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v37: None
    v3(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr144:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (4 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr144()))):
        v77: None
        closure7(pattern_input[0], None)
        v77 = None
        v81: None
        v3(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v360, v)

        closure9(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow145(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow145() if (v380.tag == 0) else now(), method6())
        v626: str = ("\u001b[91m" + pad_left("Critical".lower(), 7, " ")) + method7()
        v637: int64 = pattern_input_2[0].l0
        v651: str = to_text(interpolate("%A%P()", [v1_1]))
        v661: Mut3 = Mut3(method8())
        v668: None
        closure10(v661, ("" + "{ ") + "", None)
        v668 = None
        v677: None
        closure10(v661, ("" + "timeout") + "", None)
        v677 = None
        v686: None
        closure10(v661, ("" + " = ") + "", None)
        v686 = None
        v694: None
        closure10(v661, ("" + str(v0_1)) + "", None)
        v694 = None
        v703: None
        closure10(v661, ("" + "; ") + "", None)
        v703 = None
        v712: None
        closure10(v661, ("" + "ex") + "", None)
        v712 = None
        v720: None
        closure10(v661, ("" + " = ") + "", None)
        v720 = None
        v728: None
        closure10(v661, ("" + v651) + "", None)
        v728 = None
        v737: None
        closure10(v661, ("" + " }") + "", None)
        v737 = None
        v799: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "async.run_with_timeout_async**") + " / ") + v661.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v799)
        pattern_input[1].l0(v799)



def closure15(v0_1: int, v1_1: str, v2_1: int) -> Async[bool]:
    return None


def closure14(v0_1: int, v1_1: str) -> Callable[[int], Async[bool]]:
    def _arrow146(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[bool]:
        return closure15(v0_1, v1_1, v)

    return _arrow146


def closure13(unit_var: None, v0_1: int) -> Callable[[str, int], Async[bool]]:
    def _arrow147(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[bool]]:
        return closure14(v0_1, v)

    return _arrow147


def closure24(v0_1: FSharpRef[US7 | None], v1_1: US7 | None=None) -> FSharpRef[US7 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure25(v0_1: int | None, v1_1: Callable[[US7 | None], FSharpRef[US7 | None]], unit_var: None) -> None:
    def _arrow148(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US7 | None:
        x: int = v0_1 or 0
        def x_1(__unit: None=None) -> US7:
            return US7(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow148()))


def closure26(v0_1: int | None, v1_1: bool, v2_1: int, v3: int64, unit_var: None) -> None:
    def v5(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v6: None
    v5(None)
    v6 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v39: None
    v5(None)
    v39 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v71: US0 = pattern_input_1[4].l0
    class ObjectExpr149:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v71, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr149()))):
        v79: None
        closure7(pattern_input[0], None)
        v79 = None
        v83: None
        v5(None)
        v83 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        _v362: FSharpRef[US3 | None] = FSharpRef(None)
        v367: None
        def v364(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v362, v)

        closure9(pattern_input_2[5], v364, None)
        v367 = None
        v382: US3 = default_arg(_v362.contents, US3(1))
        def _arrow150(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, unit_var: Any=unit_var) -> Any:
            v396: Any = create(op_subtraction(ticks_1(now()), v382.fields[0]))
            return create_1(1, 1, 1, hours(v396), minutes(v396), seconds(v396), milliseconds(v396))

        v427: str = to_string(_arrow150() if (v382.tag == 0) else now(), method6())
        v628: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method7()
        v639: int64 = pattern_input_2[0].l0
        v641: Mut3 = Mut3(method8())
        v648: None
        closure10(v641, ("" + "{ ") + "", None)
        v648 = None
        v657: None
        closure10(v641, ("" + "port") + "", None)
        v657 = None
        v666: None
        closure10(v641, ("" + " = ") + "", None)
        v666 = None
        v674: None
        closure10(v641, ("" + str(v2_1)) + "", None)
        v674 = None
        v683: None
        closure10(v641, ("" + "; ") + "", None)
        v683 = None
        v692: None
        closure10(v641, ("" + "retry") + "", None)
        v692 = None
        v700: None
        closure10(v641, ("" + " = ") + "", None)
        v700 = None
        v708: None
        closure10(v641, ("" + str(v3)) + "", None)
        v708 = None
        v716: None
        closure10(v641, ("" + "; ") + "", None)
        v716 = None
        v725: None
        closure10(v641, ("" + "timeout") + "", None)
        v725 = None
        v733: None
        closure10(v641, ("" + " = ") + "", None)
        v733 = None
        v768: None
        closure10(v641, ("" + to_text(interpolate("%A%P()", [v0_1]))) + "", None)
        v768 = None
        v776: None
        closure10(v641, ("" + "; ") + "", None)
        v776 = None
        v785: None
        closure10(v641, ("" + "status") + "", None)
        v785 = None
        v793: None
        closure10(v641, ("" + " = ") + "", None)
        v793 = None
        v804: None
        closure10(v641, ("" + ("true" if v1_1 else "false")) + "", None)
        v804 = None
        v813: None
        closure10(v641, ("" + " }") + "", None)
        v813 = None
        v855: str = trim_end(trim_start(((((((((("" + v427) + " ") + v628) + " #") + str(v639)) + " ") + "networking.wait_for_port_access") + " / ") + v641.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v855)
        pattern_input[1].l0(v855)



def method9(v0_1: int | None, v1_1: bool, v2_1: str, v3: int, v4: int64) -> Async[int64]:
    return None


def closure23(v0_1: int | None, v1_1: bool, v2_1: str, v3: int) -> Async[int64]:
    return method9(v0_1, v1_1, v2_1, v3, int64(0))


def closure22(v0_1: int | None, v1_1: bool, v2_1: str) -> Callable[[int], Async[int64]]:
    def _arrow151(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> Async[int64]:
        return closure23(v0_1, v1_1, v2_1, v)

    return _arrow151


def closure21(v0_1: int | None, v1_1: bool) -> Callable[[str, int], Async[int64]]:
    def _arrow152(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Callable[[int], Async[int64]]:
        return closure22(v0_1, v1_1, v)

    return _arrow152


def closure20(unit_var: None, v0_1: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    def _arrow153(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str, int], Async[int64]]:
        return closure21(v0_1, v)

    return _arrow153


def method10(v0_1: int | None, v1_1: str, v2_1: int) -> Async[int]:
    return None


def closure29(v0_1: int | None, v1_1: str, v2_1: int) -> Async[int]:
    return method10(v0_1, v1_1, v2_1)


def closure28(v0_1: int | None, v1_1: str) -> Callable[[int], Async[int]]:
    def _arrow154(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[int]:
        return closure29(v0_1, v1_1, v)

    return _arrow154


def closure27(unit_var: None, v0_1: int | None=None) -> Callable[[str, int], Async[int]]:
    def _arrow155(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[int]]:
        return closure28(v0_1, v)

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


v16: Callable[[str, int], Async[bool]] = _arrow158

def test_port_open(x: str) -> Callable[[int], Async[bool]]:
    return v16(x)


def _arrow159(v: int) -> Callable[[str, int], Async[bool]]:
    return closure13(None, v)


v17: Callable[[int, str, int], Async[bool]] = _arrow159

def test_port_open_timeout(x: int) -> Callable[[str, int], Async[bool]]:
    return v17(x)


def _arrow160(v: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return closure20(None, v)


v18: Callable[[int | None, bool, str, int], Async[int64]] = _arrow160

def wait_for_port_access(x: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return v18(x)


def _arrow161(v: int | None=None) -> Callable[[str, int], Async[int]]:
    return closure27(None, v)


v19: Callable[[int | None, str, int], Async[int]] = _arrow161

def get_available_port(x: int | None=None) -> Callable[[str, int], Async[int]]:
    return v19(x)


