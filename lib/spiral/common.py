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
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.string_ import (pad_left, to_text, interpolate, trim_end, trim_start)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, IDisposable, ignore, to_enumerable, compare, Lazy)

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


def _expr23() -> TypeInfo:
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


US0_reflection = _expr23

def _expr24() -> TypeInfo:
    return record_type("Common.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr24

def _expr25() -> TypeInfo:
    return record_type("Common.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr25

def _expr26() -> TypeInfo:
    return record_type("Common.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr26

def _expr27() -> TypeInfo:
    return record_type("Common.Mut3", [], Mut3, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: US0

Mut3_reflection = _expr27

def _expr28() -> TypeInfo:
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


US1_reflection = _expr28

def _expr29() -> TypeInfo:
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


US2_reflection = _expr29

def _expr30() -> TypeInfo:
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


US3_reflection = _expr30

def _expr31() -> TypeInfo:
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


US4_reflection = _expr31

def _expr32() -> TypeInfo:
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


US5_reflection = _expr32

def _expr33() -> TypeInfo:
    return record_type("Common.Mut4", [], Mut4, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: str

Mut4_reflection = _expr33

def method1(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method3(__unit: None=None) -> str:
    return ""


def closure1(v0_1: FSharpRef[US1 | None], v1_1: US1 | None=None) -> FSharpRef[US1 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure2(v0_1: str | None, v1_1: Callable[[US1 | None], FSharpRef[US1 | None]], unit_var: None) -> None:
    def _arrow34(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US1 | None:
        x: str = v0_1
        def x_1(__unit: None=None) -> US1:
            return US1(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow34()))


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
    def _arrow38(__unit: None=None, v0_1: Any=v0_1) -> US2:
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




    _v1: tuple[US2, US3] = (US2(0, v178.fields[0]) if (v178.tag == 0) else _arrow38(), US3(0, ticks_1(now())) if (method2(method4()) == "True") else US3(1))
    v295: US3 = _v1[1]
    v294: US2 = _v1[0]
    def v365(v: str, v0_1: Any=v0_1) -> None:
        closure3(None, v)

    return (Mut0(int64(0)), Mut1(v365), Mut2(True), Mut3(v294.fields[0] if (v294.tag == 0) else v0_1), v295.fields[0] if (v295.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if State_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
        State_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4]))



def method5(v0_1: Callable[[], None]) -> Callable[[], None]:
    return v0_1


def method6(v0_1: Callable[[], None]) -> Callable[[], None]:
    return v0_1


def closure4(unit_var: None, v0_1: Callable[[], None]) -> IDisposable:
    v10: Callable[[], None] = method6(v0_1)
    class ObjectExpr43(IDisposable):
        def Dispose(self, __unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
            v10(None)

    return ObjectExpr43()


def closure7(unit_var: None, v0_1: US4) -> US5:
    return US5(0, v0_1)


def closure8(v0_1: int, v1_1: Callable[[], None], v2_1: int, unit_var: None) -> US4:
    if v2_1 < v0_1:
        v1_1(None)
        return US4(0)

    else: 
        return US4(1)



def closure11(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure12(v0_1: FSharpRef[US3 | None], v1_1: US3 | None=None) -> FSharpRef[US3 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure13(v0_1: int64 | None, v1_1: Callable[[US3 | None], FSharpRef[US3 | None]], unit_var: None) -> None:
    def _arrow49(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US3 | None:
        x: int64 = v0_1
        def x_1(__unit: None=None) -> US3:
            return US3(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow49()))


def method8(__unit: None=None) -> str:
    return "hh:mm:ss"


def method9(__unit: None=None) -> str:
    return "HH:mm:ss"


def method10(__unit: None=None) -> str:
    return "\u001b[0m"


def method11(__unit: None=None) -> str:
    return ""


def closure14(v0_1: Mut4, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def closure15(unit_var: None, unit_var_1: None) -> str:
    return "common.retry_fn"


def closure10(v0_1: int, v1_1: Exception, unit_var: None) -> None:
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
    class ObjectExpr63:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v41, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr63()))):
        v49: None
        closure11(pattern_input[0], None)
        v49 = None
        v51: None
        v3(None)
        v51 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_1(State_trace_state())
        _v308: FSharpRef[US3 | None] = FSharpRef(None)
        v313: None
        def v310(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure12(_v308, v)

        closure13(pattern_input_2[4], v310, None)
        v313 = None
        v326: US3 = default_arg(_v308.contents, US3(1))
        def _arrow66(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v340: Any = create(op_subtraction(ticks_1(now()), v326.fields[0]))
            return create_1(1, 1, 1, hours(v340), minutes(v340), seconds(v340), milliseconds(v340))

        v371: str = to_string(_arrow66() if (v326.tag == 0) else now(), method9())
        v568: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method10()
        v579: int64 = pattern_input_2[0].l0
        v581: Mut4 = Mut4(method11())
        v588: None
        closure14(v581, ("" + "{ ") + "", None)
        v588 = None
        v595: None
        closure14(v581, ("" + "retry") + "", None)
        v595 = None
        v602: None
        closure14(v581, ("" + " = ") + "", None)
        v602 = None
        v608: None
        closure14(v581, ("" + str(v0_1)) + "", None)
        v608 = None
        v615: None
        closure14(v581, ("" + "; ") + "", None)
        v615 = None
        v622: None
        closure14(v581, ("" + "ex") + "", None)
        v622 = None
        v628: None
        closure14(v581, ("" + " = ") + "", None)
        v628 = None
        v661: None
        closure14(v581, ("" + to_text(interpolate("%A%P()", [v1_1]))) + "", None)
        v661 = None
        v668: None
        closure14(v581, ("" + " }") + "", None)
        v668 = None
        v669: str = v581.l0
        v708: str = trim_end(trim_start(((((((((("" + v371) + " ") + v568) + " #") + str(v579)) + " ") + closure15(None, None)) + " / ") + v669) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v708)
        pattern_input[1].l0(v708)



def closure9(v0_1: int, v1_1: Exception) -> US5:
    v4: None
    closure10(v0_1, v1_1, None)
    v4 = None
    return US5(1)


def method7(v0_1_mut: int, v1_1_mut: Callable[[], None], v2_1_mut: int) -> US4:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        result: FSharpRef[US5] = FSharpRef(US5(1))
        try: 
            result.contents = closure7(None, closure8(v0_1, v1_1, v2_1, None))

        except Exception as ex:
            result.contents = closure9(v2_1, ex)

        v7_1: US5 = result.contents
        if v7_1.tag == 0:
            return v7_1.fields[0]

        else: 
            v0_1_mut = v0_1
            v1_1_mut = v1_1
            v2_1_mut = v2_1 + 1
            continue

        break


def closure6(v0_1: int, v1_1: Callable[[], None]) -> None | None:
    v3: US4 = method7(v0_1, v1_1, 0)
    if v3.tag == 0:
        return some(None)

    else: 
        return None



def closure5(unit_var: None, v0_1: int) -> Callable[[Callable[[], None]], None | None]:
    def _arrow79(v: Callable[[], None], unit_var: Any=unit_var, v0_1: Any=v0_1) -> None | None:
        return closure6(v0_1, v)

    return _arrow79


def method12(v0_1: Callable[[], None]) -> Callable[[], None]:
    return v0_1


def closure17(v0_1: Any, unit_var: None) -> None:
    v0_1.Value


def closure16(unit_var: None, v0_1: Callable[[], None]) -> Callable[[], None]:
    v1_1: Callable[[], None] = method12(v0_1)
    def _arrow82(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        v1_1(None)

    v2_1: Any = Lazy(_arrow82)
    def _arrow83(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure17(v2_1, None)

    return _arrow83


v0: None = None

def _arrow84(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow84

def _expr86():
    v1(None)
    return v0


v2: None = _expr86()

def _arrow87(v: Callable[[], None]) -> IDisposable:
    return closure4(None, v)


v5: Callable[[Callable[[], None]], IDisposable] = _arrow87

def new_disposable(x: Callable[[], None]) -> IDisposable:
    return v5(x)


def _arrow88(v: int) -> Callable[[Callable[[], None]], None | None]:
    return closure5(None, v)


v6: Callable[[int, Callable[[], None]], None | None] = _arrow88

def retry_fn(x: int) -> Callable[[Callable[[], None]], None | None]:
    return v6(x)


def _arrow89(v: Callable[[], None]) -> Callable[[], None]:
    return closure16(None, v)


v7: Callable[[Callable[[], None], None], None] = _arrow89

def memoize(x: Callable[[], None]) -> Callable[[], None]:
    return v7(x)


