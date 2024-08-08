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
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.string_ import (pad_left, to_text, interpolate, trim_end, trim_start)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, IDisposable, to_enumerable, compare, Lazy)

State_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr22() -> TypeInfo:
    return class_type("Common.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr22

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


def _expr24() -> TypeInfo:
    return union_type("Common.US0", [], US0, lambda: [[], [], [], [], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1", "US0_2", "US0_3", "US0_4"]


US0_reflection = _expr24

def _expr25() -> TypeInfo:
    return record_type("Common.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr25

def _expr26() -> TypeInfo:
    return record_type("Common.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr26

def _expr27() -> TypeInfo:
    return record_type("Common.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr27

def _expr28() -> TypeInfo:
    return record_type("Common.Mut3", [], Mut3, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: US0

Mut3_reflection = _expr28

def _expr29() -> TypeInfo:
    return union_type("Common.US1", [], US1, lambda: [[("f0_0", string_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr29

def _expr30() -> TypeInfo:
    return union_type("Common.US2", [], US2, lambda: [[("f0_0", US0_reflection())], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr30

def _expr31() -> TypeInfo:
    return union_type("Common.US3", [], US3, lambda: [[("f0_0", int64_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr31

def _expr32() -> TypeInfo:
    return union_type("Common.US4", [], US4, lambda: [[], []])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1"]


US4_reflection = _expr32

def _expr33() -> TypeInfo:
    return union_type("Common.US5", [], US5, lambda: [[("f0_0", US4_reflection())], []])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr33

def _expr34() -> TypeInfo:
    return record_type("Common.Mut4", [], Mut4, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: str

Mut4_reflection = _expr34

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
    def _arrow39(__unit: None=None, v0_1: Any=v0_1) -> US2:
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




    _v1: tuple[US2, US3] = (US2(0, v178.fields[0]) if (v178.tag == 0) else _arrow39(), US3(0, ticks_1(now())) if (method2(method4()) == "True") else US3(1))
    v295: US3 = _v1[1]
    v294: US2 = _v1[0]
    def v365(v: str, v0_1: Any=v0_1) -> None:
        closure0(None, v)

    return (Mut0(int64(0)), Mut1(v365), Mut2(True), Mut3(v294.fields[0] if (v294.tag == 0) else v0_1), v295.fields[0] if (v295.tag == 0) else None)


def method5(v0_1: Callable[[], None]) -> Callable[[], None]:
    return v0_1


def method6(v0_1: Callable[[], None]) -> Callable[[], None]:
    return v0_1


def closure1(unit_var: None, v0_1: Callable[[], None]) -> IDisposable:
    v10: Callable[[], None] = method6(v0_1)
    class ObjectExpr49(IDisposable):
        def Dispose(self, __unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
            v10(None)

    return ObjectExpr49()


def closure4(unit_var: None, v0_1: US4) -> US5:
    return US5(0, v0_1)


def closure5(v0_1: int, v1: Callable[[], None], v2: int, unit_var: None) -> US4:
    if v2 < v0_1:
        v1(None)
        return US4(0)

    else: 
        return US4(1)



def method8(__unit: None=None) -> str:
    return "hh:mm:ss"


def method9(__unit: None=None) -> str:
    return "HH:mm:ss"


def method10(__unit: None=None) -> str:
    return "\u001b[0m"


def method11(__unit: None=None) -> str:
    return ""


def closure7(unit_var: None, unit_var_1: None) -> str:
    return "common.retry_fn"


def closure6(v0_1: int, v1: Exception) -> US5:
    if State_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
        State_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4]))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value(State_trace_state())
    v14_1: Mut0 = pattern_input_1[0]
    if State_trace_state() is None:
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
        State_trace_state((pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4]))

    pattern_input_3: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value(State_trace_state())
    v56: US0 = pattern_input_3[3].l0
    class ObjectExpr73:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_3[2].l0 == False) else (3 >= find(v56, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr73()))):
        v63: int64 = op_addition(v14_1.l0, int64(1))
        v14_1.l0 = v63
        if State_trace_state() is None:
            pattern_input_4: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
            State_trace_state((pattern_input_4[0], pattern_input_4[1], pattern_input_4[2], pattern_input_4[3], pattern_input_4[4]))

        pattern_input_5: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value(State_trace_state())
        v80: int64 | None = pattern_input_5[4]
        _v318: FSharpRef[US3 | None] = FSharpRef(None)
        x_3: US3 | None
        if v80 is None:
            x_3 = None

        else: 
            x_1: int64 = v80
            def x_2(__unit: None=None, v0_1: Any=v0_1, v1: Any=v1) -> US3:
                return US3(0, x_1)

            x_3 = x_2(None)

        _v318.contents = x_3
        v333: US3 = default_arg(_v318.contents, US3(1))
        def _arrow81(__unit: None=None, v0_1: Any=v0_1, v1: Any=v1) -> Any:
            v347: Any = create(op_subtraction(ticks_1(now()), v333.fields[0]))
            return create_1(1, 1, 1, hours(v347), minutes(v347), seconds(v347), milliseconds(v347))

        v378: str = to_string(_arrow81() if (v333.tag == 0) else now(), method9())
        v569: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method10()
        v580: int64 = pattern_input_5[0].l0
        v582: Mut4 = Mut4(method11())
        v588: str = v582.l0 + (("" + "{ ") + "")
        v582.l0 = v588
        v594: str = v582.l0 + (("" + "retry") + "")
        v582.l0 = v594
        v600: str = v582.l0 + (("" + " = ") + "")
        v582.l0 = v600
        v605: str = v582.l0 + (("" + str(v0_1)) + "")
        v582.l0 = v605
        v611: str = v582.l0 + (("" + "; ") + "")
        v582.l0 = v611
        v617: str = v582.l0 + (("" + "ex") + "")
        v582.l0 = v617
        v622: str = v582.l0 + (("" + " = ") + "")
        v582.l0 = v622
        v639: str = to_text(interpolate("%A%P()", [v1]))
        v654: str = v582.l0 + (("" + v639) + "")
        v582.l0 = v654
        v660: str = v582.l0 + (("" + " }") + "")
        v582.l0 = v660
        v661: str = v582.l0
        v700: str = trim_end(trim_start(((((((((("" + v378) + " ") + v569) + " #") + str(v580)) + " ") + closure7(None, None)) + " / ") + v661) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v700)
        pattern_input_1[1].l0(v700)

    return US5(1)


def method7(v0_1_mut: int, v1_mut: Callable[[], None], v2_mut: int) -> US4:
    while True:
        (v0_1, v1, v2) = (v0_1_mut, v1_mut, v2_mut)
        result: FSharpRef[US5] = FSharpRef(US5(1))
        try: 
            result.contents = closure4(None, closure5(v0_1, v1, v2, None))

        except Exception as ex:
            result.contents = closure6(v2, ex)

        v7: US5 = result.contents
        if v7.tag == 0:
            return v7.fields[0]

        else: 
            v0_1_mut = v0_1
            v1_mut = v1
            v2_mut = v2 + 1
            continue

        break


def closure3(v0_1: int, v1: Callable[[], None]) -> None | None:
    v3: US4 = method7(v0_1, v1, 0)
    if v3.tag == 0:
        return some(None)

    else: 
        return None



def closure2(unit_var: None, v0_1: int) -> Callable[[Callable[[], None]], None | None]:
    def _arrow89(v: Callable[[], None], unit_var: Any=unit_var, v0_1: Any=v0_1) -> None | None:
        return closure3(v0_1, v)

    return _arrow89


def method12(v0_1: Callable[[], None]) -> Callable[[], None]:
    return v0_1


def closure9(v0_1: Any, unit_var: None) -> None:
    v0_1.Value


def closure8(unit_var: None, v0_1: Callable[[], None]) -> Callable[[], None]:
    v1: Callable[[], None] = method12(v0_1)
    def _arrow90(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        v1(None)

    v2: Any = Lazy(_arrow90)
    def _arrow91(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure9(v2, None)

    return _arrow91


v0: bool = State_trace_state() is None


if v0:
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
    State_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4]))


def _arrow92(v: Callable[[], None]) -> IDisposable:
    return closure1(None, v)


v12: Callable[[Callable[[], None]], IDisposable] = _arrow92

def new_disposable(x: Callable[[], None]) -> IDisposable:
    return v12(x)


def _arrow93(v: int) -> Callable[[Callable[[], None]], None | None]:
    return closure2(None, v)


v13: Callable[[int, Callable[[], None]], None | None] = _arrow93

def retry_fn(x: int) -> Callable[[Callable[[], None]], None | None]:
    return v13(x)


def _arrow94(v: Callable[[], None]) -> Callable[[], None]:
    return closure8(None, v)


v14: Callable[[Callable[[], None], None], None] = _arrow94

def memoize(x: Callable[[], None]) -> Callable[[], None]:
    return v14(x)


