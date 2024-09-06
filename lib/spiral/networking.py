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
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, to_text, interpolate, split)
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
    v84: US1 = default_arg(_v64.contents, US1(1))
    if v84.tag == 0:
        return v84.fields[0]

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


def closure13(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure12(unit_var: None, v0_1: str) -> None:
    v3: None
    closure13(v0_1, None)
    v3 = None


def closure6(v0_1: int, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v33: None
    v3(None)
    v33 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v61: US0 = pattern_input_1[3].l0
    class ObjectExpr139:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr139()))):
        v69: None
        closure7(pattern_input[0], None)
        v69 = None
        v73: None
        v3(None)
        v73 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
        _v348: FSharpRef[US3 | None] = FSharpRef(None)
        v353: None
        def v350(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v348, v)

        closure9(pattern_input_2[4], v350, None)
        v353 = None
        v368: US3 = default_arg(_v348.contents, US3(1))
        def _arrow140(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v382: Any = create(op_subtraction(ticks_1(now()), v368.fields[0]))
            return create_1(1, 1, 1, hours(v382), minutes(v382), seconds(v382), milliseconds(v382))

        v413: str = to_string(_arrow140() if (v368.tag == 0) else now(), method6())
        v614: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method7()
        v625: int64 = pattern_input_2[0].l0
        v627: Mut4 = Mut4(method8())
        v634: None
        closure10(v627, ("" + "{ ") + "", None)
        v634 = None
        v643: None
        closure10(v627, ("" + "port") + "", None)
        v643 = None
        v652: None
        closure10(v627, ("" + " = ") + "", None)
        v652 = None
        v660: None
        closure10(v627, ("" + str(v0_1)) + "", None)
        v660 = None
        v669: None
        closure10(v627, ("" + "; ") + "", None)
        v669 = None
        v678: None
        closure10(v627, ("" + "ex") + "", None)
        v678 = None
        v686: None
        closure10(v627, ("" + " = ") + "", None)
        v686 = None
        v694: None
        closure10(v627, ("" + v1_1) + "", None)
        v694 = None
        v703: None
        closure10(v627, ("" + " }") + "", None)
        v703 = None
        v706: str = v627.l0
        v745: str = trim_end(trim_start(((((((((("" + v413) + " ") + v614) + " #") + str(v625)) + " ") + closure11(None, None)) + " / ") + v706) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v745)
        pattern_input[1].l0(v745)



def closure5(v0_1: str, v1_1: int) -> Async[bool]:
    return None


def closure4(unit_var: None, v0_1: str) -> Callable[[int], Async[bool]]:
    def _arrow141(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[bool]:
        return closure5(v0_1, v)

    return _arrow141


def closure17(unit_var: None, v0_1: bool) -> US5:
    return US5(0, v0_1)


def closure18(unit_var: None, v0_1: Exception) -> US5:
    return US5(1, v0_1)


def closure20(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async"


def closure19(v0_1: int, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v32: None
    v2_1(None)
    v32 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v60: US0 = pattern_input_1[3].l0
    class ObjectExpr142:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v60, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr142()))):
        v68: None
        closure7(pattern_input[0], None)
        v68 = None
        v72: None
        v2_1(None)
        v72 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
        _v347: FSharpRef[US3 | None] = FSharpRef(None)
        v352: None
        def v349(v: US3 | None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v347, v)

        closure9(pattern_input_2[4], v349, None)
        v352 = None
        v367: US3 = default_arg(_v347.contents, US3(1))
        def _arrow143(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v381: Any = create(op_subtraction(ticks_1(now()), v367.fields[0]))
            return create_1(1, 1, 1, hours(v381), minutes(v381), seconds(v381), milliseconds(v381))

        v412: str = to_string(_arrow143() if (v367.tag == 0) else now(), method6())
        v613: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method7()
        v624: int64 = pattern_input_2[0].l0
        v626: Mut4 = Mut4(method8())
        v633: None
        closure10(v626, ("" + "{ ") + "", None)
        v633 = None
        v642: None
        closure10(v626, ("" + "timeout") + "", None)
        v642 = None
        v651: None
        closure10(v626, ("" + " = ") + "", None)
        v651 = None
        v659: None
        closure10(v626, ("" + str(v0_1)) + "", None)
        v659 = None
        v668: None
        closure10(v626, ("" + " }") + "", None)
        v668 = None
        v671: str = v626.l0
        v710: str = trim_end(trim_start(((((((((("" + v412) + " ") + v613) + " #") + str(v624)) + " ") + closure20(None, None)) + " / ") + v671) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v710)
        pattern_input[1].l0(v710)



def method9(__unit: None=None) -> str:
    return "("


def method10(__unit: None=None) -> str:
    return " "


def closure22(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async**"


def closure21(v0_1: int, v1_1: Exception, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v33: None
    v3(None)
    v33 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v61: US0 = pattern_input_1[3].l0
    class ObjectExpr144:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (4 >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr144()))):
        v69: None
        closure7(pattern_input[0], None)
        v69 = None
        v73: None
        v3(None)
        v73 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
        _v348: FSharpRef[US3 | None] = FSharpRef(None)
        v353: None
        def v350(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v348, v)

        closure9(pattern_input_2[4], v350, None)
        v353 = None
        v368: US3 = default_arg(_v348.contents, US3(1))
        def _arrow145(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v382: Any = create(op_subtraction(ticks_1(now()), v368.fields[0]))
            return create_1(1, 1, 1, hours(v382), minutes(v382), seconds(v382), milliseconds(v382))

        v413: str = to_string(_arrow145() if (v368.tag == 0) else now(), method6())
        v559: str = method10()
        v567: Mut4 = Mut4(method8())
        v578: None
        closure10(v567, ("" + to_text(interpolate("%A%P()", [US0(0)]))) + "", None)
        v578 = None
        v582: Array[str] = split(v567.l0, [v559], None, 0)
        v585: str = v582[0]
        v589: Mut4 = Mut4(method8())
        v600: None
        closure10(v589, ("" + to_text(interpolate("%A%P()", [US0(4)]))) + "", None)
        v600 = None
        v603: str = v589.l0
        v610: US1 = US1(0, "Verbose") if (v603.find(v585) == 0) else US1(1)
        v799: US1
        if v610.tag == 0:
            v799 = US1(0, v610.fields[0])

        else: 
            v618: str = method10()
            v626: Mut4 = Mut4(method8())
            v637: None
            closure10(v626, ("" + to_text(interpolate("%A%P()", [US0(1)]))) + "", None)
            v637 = None
            v641: Array[str] = split(v626.l0, [v618], None, 0)
            v644: str = v641[0]
            v648: Mut4 = Mut4(method8())
            v659: None
            closure10(v648, ("" + to_text(interpolate("%A%P()", [US0(4)]))) + "", None)
            v659 = None
            v662: str = v648.l0
            v669: US1 = US1(0, "Debug") if (v662.find(v644) == 0) else US1(1)
            if v669.tag == 0:
                v799 = US1(0, v669.fields[0])

            else: 
                v677: str = method10()
                v685: Mut4 = Mut4(method8())
                v696: None
                closure10(v685, ("" + to_text(interpolate("%A%P()", [US0(2)]))) + "", None)
                v696 = None
                v700: Array[str] = split(v685.l0, [v677], None, 0)
                v703: str = v700[0]
                v707: Mut4 = Mut4(method8())
                v718: None
                closure10(v707, ("" + to_text(interpolate("%A%P()", [US0(4)]))) + "", None)
                v718 = None
                v721: str = v707.l0
                v728: US1 = US1(0, "Info") if (v721.find(v703) == 0) else US1(1)
                if v728.tag == 0:
                    v799 = US1(0, v728.fields[0])

                else: 
                    v736: str = method10()
                    v744: Mut4 = Mut4(method8())
                    v755: None
                    closure10(v744, ("" + to_text(interpolate("%A%P()", [US0(3)]))) + "", None)
                    v755 = None
                    v759: Array[str] = split(v744.l0, [v736], None, 0)
                    v762: str = v759[0]
                    v766: Mut4 = Mut4(method8())
                    v777: None
                    closure10(v766, ("" + to_text(interpolate("%A%P()", [US0(4)]))) + "", None)
                    v777 = None
                    v780: str = v766.l0
                    v787: US1 = US1(0, "Warning") if (v780.find(v762) == 0) else US1(1)
                    v799 = US1(0, v787.fields[0]) if (v787.tag == 0) else US1(0, "Critical")



        v803: str
        if v799.tag == 0:
            v803 = v799.fields[0]

        else: 
            raise Exception("Option does not have a value.")

        v863: str = ("\u001b[91m" + pad_left(v803.lower(), 7, " ")) + method7()
        v874: int64 = pattern_input_2[0].l0
        v888: str = to_text(interpolate("%A%P()", [v1_1]))
        v898: Mut4 = Mut4(method8())
        v905: None
        closure10(v898, ("" + "{ ") + "", None)
        v905 = None
        v914: None
        closure10(v898, ("" + "timeout") + "", None)
        v914 = None
        v923: None
        closure10(v898, ("" + " = ") + "", None)
        v923 = None
        v931: None
        closure10(v898, ("" + str(v0_1)) + "", None)
        v931 = None
        v940: None
        closure10(v898, ("" + "; ") + "", None)
        v940 = None
        v949: None
        closure10(v898, ("" + "ex") + "", None)
        v949 = None
        v957: None
        closure10(v898, ("" + " = ") + "", None)
        v957 = None
        v965: None
        closure10(v898, ("" + v888) + "", None)
        v965 = None
        v974: None
        closure10(v898, ("" + " }") + "", None)
        v974 = None
        v977: str = v898.l0
        v1016: str = trim_end(trim_start(((((((((("" + v413) + " ") + v863) + " #") + str(v874)) + " ") + closure22(None, None)) + " / ") + v977) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v1016)
        pattern_input[1].l0(v1016)



def closure16(v0_1: int, v1_1: str, v2_1: int) -> Async[bool]:
    return None


def closure15(v0_1: int, v1_1: str) -> Callable[[int], Async[bool]]:
    def _arrow146(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[bool]:
        return closure16(v0_1, v1_1, v)

    return _arrow146


def closure14(unit_var: None, v0_1: int) -> Callable[[str, int], Async[bool]]:
    def _arrow147(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[bool]]:
        return closure15(v0_1, v)

    return _arrow147


def closure27(v0_1: FSharpRef[US7 | None], v1_1: US7 | None=None) -> FSharpRef[US7 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure28(v0_1: int | None, v1_1: Callable[[US7 | None], FSharpRef[US7 | None]], unit_var: None) -> None:
    def _arrow148(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US7 | None:
        x: int = v0_1 or 0
        def x_1(__unit: None=None) -> US7:
            return US7(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow148()))


def closure30(unit_var: None, unit_var_1: None) -> str:
    return "networking.wait_for_port_access"


def closure29(v0_1: int | None, v1_1: bool, v2_1: int, v3: int64, unit_var: None) -> None:
    def v5(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v6: None
    v5(None)
    v6 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v35: None
    v5(None)
    v35 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v63: US0 = pattern_input_1[3].l0
    class ObjectExpr149:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v63, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr149()))):
        v71: None
        closure7(pattern_input[0], None)
        v71 = None
        v75: None
        v5(None)
        v75 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
        _v350: FSharpRef[US3 | None] = FSharpRef(None)
        v355: None
        def v352(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v350, v)

        closure9(pattern_input_2[4], v352, None)
        v355 = None
        v370: US3 = default_arg(_v350.contents, US3(1))
        def _arrow150(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, unit_var: Any=unit_var) -> Any:
            v384: Any = create(op_subtraction(ticks_1(now()), v370.fields[0]))
            return create_1(1, 1, 1, hours(v384), minutes(v384), seconds(v384), milliseconds(v384))

        v415: str = to_string(_arrow150() if (v370.tag == 0) else now(), method6())
        v616: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method7()
        v627: int64 = pattern_input_2[0].l0
        v629: Mut4 = Mut4(method8())
        v636: None
        closure10(v629, ("" + "{ ") + "", None)
        v636 = None
        v645: None
        closure10(v629, ("" + "port") + "", None)
        v645 = None
        v654: None
        closure10(v629, ("" + " = ") + "", None)
        v654 = None
        v662: None
        closure10(v629, ("" + str(v2_1)) + "", None)
        v662 = None
        v671: None
        closure10(v629, ("" + "; ") + "", None)
        v671 = None
        v680: None
        closure10(v629, ("" + "retry") + "", None)
        v680 = None
        v688: None
        closure10(v629, ("" + " = ") + "", None)
        v688 = None
        v696: None
        closure10(v629, ("" + str(v3)) + "", None)
        v696 = None
        v704: None
        closure10(v629, ("" + "; ") + "", None)
        v704 = None
        v713: None
        closure10(v629, ("" + "timeout") + "", None)
        v713 = None
        v721: None
        closure10(v629, ("" + " = ") + "", None)
        v721 = None
        v756: None
        closure10(v629, ("" + to_text(interpolate("%A%P()", [v0_1]))) + "", None)
        v756 = None
        v764: None
        closure10(v629, ("" + "; ") + "", None)
        v764 = None
        v773: None
        closure10(v629, ("" + "status") + "", None)
        v773 = None
        v781: None
        closure10(v629, ("" + " = ") + "", None)
        v781 = None
        v792: None
        closure10(v629, ("" + ("true" if v1_1 else "false")) + "", None)
        v792 = None
        v801: None
        closure10(v629, ("" + " }") + "", None)
        v801 = None
        v804: str = v629.l0
        v843: str = trim_end(trim_start(((((((((("" + v415) + " ") + v616) + " #") + str(v627)) + " ") + closure30(None, None)) + " / ") + v804) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v843)
        pattern_input[1].l0(v843)



def method11(v0_1: int | None, v1_1: bool, v2_1: str, v3: int, v4: int64) -> Async[int64]:
    return None


def closure26(v0_1: int | None, v1_1: bool, v2_1: str, v3: int) -> Async[int64]:
    return method11(v0_1, v1_1, v2_1, v3, int64(0))


def closure25(v0_1: int | None, v1_1: bool, v2_1: str) -> Callable[[int], Async[int64]]:
    def _arrow151(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> Async[int64]:
        return closure26(v0_1, v1_1, v2_1, v)

    return _arrow151


def closure24(v0_1: int | None, v1_1: bool) -> Callable[[str, int], Async[int64]]:
    def _arrow152(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Callable[[int], Async[int64]]:
        return closure25(v0_1, v1_1, v)

    return _arrow152


def closure23(unit_var: None, v0_1: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    def _arrow153(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str, int], Async[int64]]:
        return closure24(v0_1, v)

    return _arrow153


def method12(v0_1: int | None, v1_1: str, v2_1: int) -> Async[int]:
    return None


def closure33(v0_1: int | None, v1_1: str, v2_1: int) -> Async[int]:
    return method12(v0_1, v1_1, v2_1)


def closure32(v0_1: int | None, v1_1: str) -> Callable[[int], Async[int]]:
    def _arrow154(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[int]:
        return closure33(v0_1, v1_1, v)

    return _arrow154


def closure31(unit_var: None, v0_1: int | None=None) -> Callable[[str, int], Async[int]]:
    def _arrow155(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[int]]:
        return closure32(v0_1, v)

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


v15: Callable[[str, int], Async[bool]] = _arrow158

def test_port_open(x: str) -> Callable[[int], Async[bool]]:
    return v15(x)


def _arrow159(v: int) -> Callable[[str, int], Async[bool]]:
    return closure14(None, v)


v16: Callable[[int, str, int], Async[bool]] = _arrow159

def test_port_open_timeout(x: int) -> Callable[[str, int], Async[bool]]:
    return v16(x)


def _arrow160(v: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return closure23(None, v)


v17: Callable[[int | None, bool, str, int], Async[int64]] = _arrow160

def wait_for_port_access(x: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return v17(x)


def _arrow161(v: int | None=None) -> Callable[[str, int], Async[int]]:
    return closure31(None, v)


v18: Callable[[int | None, str, int], Async[int]] = _arrow161

def get_available_port(x: int | None=None) -> Callable[[str, int], Async[int]]:
    return v18(x)


