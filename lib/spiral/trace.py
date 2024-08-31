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
from fable_modules.fable_library.string_ import (to_text, interpolate, split, pad_left, trim_end, trim_start)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, ignore, to_enumerable, compare)

State_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr207() -> TypeInfo:
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


US0_reflection = _expr207

def _expr208() -> TypeInfo:
    return record_type("Trace.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr208

def _expr209() -> TypeInfo:
    return record_type("Trace.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr209

def _expr210() -> TypeInfo:
    return record_type("Trace.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr210

def _expr211() -> TypeInfo:
    return record_type("Trace.Mut3", [], Mut3, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: US0

Mut3_reflection = _expr211

def _expr212() -> TypeInfo:
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


US1_reflection = _expr212

def _expr213() -> TypeInfo:
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


US2_reflection = _expr213

def _expr214() -> TypeInfo:
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


US3_reflection = _expr214

def _expr216() -> TypeInfo:
    return record_type("Trace.Mut4", [], Mut4, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: str

Mut4_reflection = _expr216

def method1(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method3(__unit: None=None) -> str:
    return ""


def closure1(v0_1: FSharpRef[US1 | None], v1_1: US1 | None=None) -> FSharpRef[US1 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure2(v0_1: str | None, v1_1: Callable[[US1 | None], FSharpRef[US1 | None]], unit_var: None) -> None:
    def _arrow217(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US1 | None:
        x: str = v0_1
        def x_1(__unit: None=None) -> US1:
            return US1(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow217()))


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
    def _arrow221(__unit: None=None, v0_1: Any=v0_1) -> US2:
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




    _v1: tuple[US2, US3] = (US2(0, v178.fields[0]) if (v178.tag == 0) else _arrow221(), US3(0, ticks_1(now())) if (method2(method4()) == "True") else US3(1))
    v295: US3 = _v1[1]
    v294: US2 = _v1[0]
    def v365(v: str, v0_1: Any=v0_1) -> None:
        closure3(None, v)

    return (Mut0(int64(0)), Mut1(v365), Mut2(True), Mut3(v294.fields[0] if (v294.tag == 0) else v0_1), v295.fields[0] if (v295.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if State_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
        State_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4]))



def closure8(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure9(v0_1: FSharpRef[US3 | None], v1_1: US3 | None=None) -> FSharpRef[US3 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure10(v0_1: int64 | None, v1_1: Callable[[US3 | None], FSharpRef[US3 | None]], unit_var: None) -> None:
    def _arrow224(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US3 | None:
        x: int64 = v0_1
        def x_1(__unit: None=None) -> US3:
            return US3(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow224()))


def method5(__unit: None=None) -> str:
    return "hh:mm:ss"


def method6(__unit: None=None) -> str:
    return "HH:mm:ss"


def method7(__unit: None=None) -> str:
    return "("


def method8(__unit: None=None) -> str:
    return " "


def method9(__unit: None=None) -> str:
    return ""


def closure11(v0_1: Mut4, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def method10(__unit: None=None) -> str:
    return "\u001b[0m"


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
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v34: None
    v4(None)
    v34 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
    v62: US0 = pattern_input_1[3].l0
    class ObjectExpr225:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr226:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr225())) >= find(v62, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr226()))):
        v71: None
        closure8(pattern_input[0], None)
        v71 = None
        v75: None
        v4(None)
        v75 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
        _v350: FSharpRef[US3 | None] = FSharpRef(None)
        v355: None
        def v352(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure9(_v350, v)

        closure10(pattern_input_2[4], v352, None)
        v355 = None
        v370: US3 = default_arg(_v350.contents, US3(1))
        def _arrow227(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v384: Any = create(op_subtraction(ticks_1(now()), v370.fields[0]))
            return create_1(1, 1, 1, hours(v384), minutes(v384), seconds(v384), milliseconds(v384))

        v415: str = to_string(_arrow227() if (v370.tag == 0) else now(), method6())
        v614: US1
        if True if (v0_1.tag == 0) else False:
            v614 = US1(0, "Verbose")

        else: 
            v564: str = method8()
            v572: Mut4 = Mut4(method9())
            v583: None
            closure11(v572, ("" + to_text(interpolate("%A%P()", [US0(0)]))) + "", None)
            v583 = None
            v587: Array[str] = split(v572.l0, [v564], None, 0)
            v590: str = v587[0]
            v594: Mut4 = Mut4(method9())
            v603: None
            closure11(v594, ("" + to_text(interpolate("%A%P()", [v0_1]))) + "", None)
            v603 = None
            v606: str = v594.l0
            v614 = US1(0, "Verbose") if (v606.find(v590) == 0) else US1(1)

        v871: US1
        if v614.tag == 0:
            v871 = US1(0, v614.fields[0])

        else: 
            v675: US1
            if True if (v0_1.tag == 1) else False:
                v675 = US1(0, "Debug")

            else: 
                v625: str = method8()
                v633: Mut4 = Mut4(method9())
                v644: None
                closure11(v633, ("" + to_text(interpolate("%A%P()", [US0(1)]))) + "", None)
                v644 = None
                v648: Array[str] = split(v633.l0, [v625], None, 0)
                v651: str = v648[0]
                v655: Mut4 = Mut4(method9())
                v664: None
                closure11(v655, ("" + to_text(interpolate("%A%P()", [v0_1]))) + "", None)
                v664 = None
                v667: str = v655.l0
                v675 = US1(0, "Debug") if (v667.find(v651) == 0) else US1(1)

            if v675.tag == 0:
                v871 = US1(0, v675.fields[0])

            else: 
                v736: US1
                if True if (v0_1.tag == 2) else False:
                    v736 = US1(0, "Info")

                else: 
                    v686: str = method8()
                    v694: Mut4 = Mut4(method9())
                    v705: None
                    closure11(v694, ("" + to_text(interpolate("%A%P()", [US0(2)]))) + "", None)
                    v705 = None
                    v709: Array[str] = split(v694.l0, [v686], None, 0)
                    v712: str = v709[0]
                    v716: Mut4 = Mut4(method9())
                    v725: None
                    closure11(v716, ("" + to_text(interpolate("%A%P()", [v0_1]))) + "", None)
                    v725 = None
                    v728: str = v716.l0
                    v736 = US1(0, "Info") if (v728.find(v712) == 0) else US1(1)

                if v736.tag == 0:
                    v871 = US1(0, v736.fields[0])

                else: 
                    v797: US1
                    if True if (v0_1.tag == 3) else False:
                        v797 = US1(0, "Warning")

                    else: 
                        v747: str = method8()
                        v755: Mut4 = Mut4(method9())
                        v766: None
                        closure11(v755, ("" + to_text(interpolate("%A%P()", [US0(3)]))) + "", None)
                        v766 = None
                        v770: Array[str] = split(v755.l0, [v747], None, 0)
                        v773: str = v770[0]
                        v777: Mut4 = Mut4(method9())
                        v786: None
                        closure11(v777, ("" + to_text(interpolate("%A%P()", [v0_1]))) + "", None)
                        v786 = None
                        v789: str = v777.l0
                        v797 = US1(0, "Warning") if (v789.find(v773) == 0) else US1(1)

                    if v797.tag == 0:
                        v871 = US1(0, v797.fields[0])

                    else: 
                        v858: US1
                        if True if (v0_1.tag == 4) else False:
                            v858 = US1(0, "Critical")

                        else: 
                            v808: str = method8()
                            v816: Mut4 = Mut4(method9())
                            v827: None
                            closure11(v816, ("" + to_text(interpolate("%A%P()", [US0(4)]))) + "", None)
                            v827 = None
                            v831: Array[str] = split(v816.l0, [v808], None, 0)
                            v834: str = v831[0]
                            v838: Mut4 = Mut4(method9())
                            v847: None
                            closure11(v838, ("" + to_text(interpolate("%A%P()", [v0_1]))) + "", None)
                            v847 = None
                            v850: str = v838.l0
                            v858 = US1(0, "Critical") if (v850.find(v834) == 0) else US1(1)

                        v871 = US1(0, v858.fields[0]) if (v858.tag == 0) else US1(1)




        v875: str
        if v871.tag == 0:
            v875 = v871.fields[0]

        else: 
            raise Exception("Option does not have a value.")

        v880: str = pad_left(v875.lower(), 7, " ")
        v992: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v880) + method10()
        v1021: int64 = pattern_input_2[0].l0
        v1022: str = v2_1(None)
        v1024: Mut4 = Mut4(method9())
        v1030: None
        closure11(v1024, ("" + v1022) + "", None)
        v1030 = None
        v1033: str = v1024.l0
        v1071: str = trim_end(trim_start(((((((((("" + v415) + " ") + v992) + " #") + str(v1021)) + " ") + v1_1(None)) + " / ") + v1033) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure12(None, v1071)
        pattern_input[1].l0(v1071)



def closure6(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    v5: None
    closure7(v0_1, v1_1, v2_1, None)
    v5 = None


def closure5(v0_1: US0, v1_1: Callable[[], str]) -> Callable[[Callable[[], str]], None]:
    def _arrow230(v: Callable[[], str], v0_1: Any=v0_1, v1_1: Any=v1_1) -> None:
        closure6(v0_1, v1_1, v)

    return _arrow230


def closure4(unit_var: None, v0_1: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    def _arrow231(v: Callable[[], str], unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[Callable[[], str]], None]:
        return closure5(v0_1, v)

    return _arrow231


v0: None = None

def _arrow232(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow232

def _expr233():
    v1(None)
    return v0


v2: None = _expr233()

def _arrow234(v: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return closure4(None, v)


v15: Callable[[US0, Callable[[], str], Callable[[], str]], None] = _arrow234

def trace(x: US0) -> Callable[[Callable[[], str], Callable[[], str]], None]:
    return v15(x)


