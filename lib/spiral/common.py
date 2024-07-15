from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.date import (ticks as ticks_1, now, to_string, create as create_1)
from fable_modules.fable_library.list import (to_array, empty, of_array)
from fable_modules.fable_library.long import (op_subtraction, op_addition)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value, default_arg)
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.string_ import (to_text, interpolate, pad_left, trim_end, trim_start)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, IDisposable, to_enumerable, compare, Lazy)

State_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr11() -> TypeInfo:
    return class_type("Common.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr11

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


def _expr12() -> TypeInfo:
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


US0_reflection = _expr12

def _expr13() -> TypeInfo:
    return record_type("Common.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr13

def _expr14() -> TypeInfo:
    return record_type("Common.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr14

def _expr15() -> TypeInfo:
    return record_type("Common.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr15

def _expr16() -> TypeInfo:
    return record_type("Common.Mut3", [], Mut3, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: US0

Mut3_reflection = _expr16

def _expr17() -> TypeInfo:
    return union_type("Common.US1", [], US1, lambda: [[("f0_0", US0_reflection())], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr17

def _expr18() -> TypeInfo:
    return union_type("Common.US2", [], US2, lambda: [[("f0_0", int64_type)], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr18

def _expr19() -> TypeInfo:
    return union_type("Common.US3", [], US3, lambda: [[("f0_0", string_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr19

def _expr20() -> TypeInfo:
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


US4_reflection = _expr20

def _expr21() -> TypeInfo:
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


US5_reflection = _expr21

def _expr22() -> TypeInfo:
    return record_type("Common.Mut4", [], Mut4, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: str

Mut4_reflection = _expr22

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
        v77 = value(_v66)

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
    def _arrow45(__unit: None=None, unit_var: Any=unit_var, v0: Any=v0) -> US1:
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




    x: tuple[US1, US2] = (US1(0, v173.fields[0]) if (v173.tag == 0) else _arrow45(), US2(0, ticks_1(now())) if (method1(method3()) == "True") else US2(1))
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


def method4(v0: Callable[[], None]) -> Callable[[], None]:
    return v0


def method5(v0: Callable[[], None]) -> Callable[[], None]:
    return v0


def closure2(unit_var: None, v0: Callable[[], None]) -> IDisposable:
    _v3: IDisposable | None = None
    v12: Callable[[], None] = method5(v0)
    class ObjectExpr51(IDisposable):
        def Dispose(self, __unit: None=None, unit_var: Any=unit_var, v0: Any=v0) -> None:
            v12(None)

    x: IDisposable = ObjectExpr51()
    _v3 = x
    if _v3 is None:
        raise Exception("base.run_target / _v3=None")

    else: 
        return _v3



def closure5(unit_var: None, v0: US4) -> US5:
    return US5(0, v0)


def closure6(v0: int, v1: Callable[[], None], v2_1: int, unit_var: None) -> US4:
    if v2_1 < v0:
        v1(None)
        return US4(0)

    else: 
        return US4(1)



def closure8(unit_var: None, unit_var_1: None) -> str:
    return "common.retry_fn"


def closure9(v0: int, v1: Exception, unit_var: None) -> tuple[int, Exception]:
    return (v0, v1)


def method8(__unit: None=None) -> str:
    return "hh:mm:ss"


def method9(__unit: None=None) -> str:
    return ""


def method10(__unit: None=None) -> str:
    return "HH:mm:ss"


def method11(__unit: None=None) -> str:
    return "\u001b[0m"


def method13(v0: Mut4, v1: str) -> None:
    v12: str = v0.l0 + (("" + v1) + "")
    v0.l0 = v12


def method14(v0: Mut4) -> None:
    pass


def method15(v0: Mut4, v1: int) -> None:
    v12: str = v0.l0 + (("" + str(v1)) + "")
    v0.l0 = v12


def method16(v0: Mut4, v1: Exception) -> None:
    method13(v0, to_text(interpolate("%A%P()", [v1])))


def method12(v0: Mut4, v1: int, v2_1: Exception) -> None:
    method13(v0, "{ ")
    method14(v0)
    method13(v0, "retry")
    method13(v0, " = ")
    method15(v0, v1)
    method13(v0, "; ")
    method13(v0, "ex")
    method13(v0, " = ")
    method16(v0, v2_1)
    method13(v0, " }")


def closure10(v0: US0, v1: Callable[[], str], v2_1: Callable[[], tuple[int, Exception]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value(State_trace_state())
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
    def _arrow60(__unit: None=None, v0: Any=v0, v1: Any=v1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v539: Any = create(op_subtraction(ticks_1(now()), v507.fields[0]))
        return create_1(1, 1, 1, hours(v539), minutes(v539), seconds(v539), milliseconds(v539))

    x_3: str = to_string(_arrow60() if (v507.tag == 0) else now(), method10())
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
    x_5: str = (("\u001b[94m" if (v0.tag == 1) else ("\u001b[92m" if (v0.tag == 2) else ("\u001b[90m" if (v0.tag == 0) else ("\u001b[93m" if (v0.tag == 3) else "\u001b[91m")))) + v997) + method11()
    _v1029 = x_5
    v1141: str
    if _v1029 is None:
        raise Exception("base.run_target / _v1029=None")

    else: 
        v1141 = _v1029

    v1160: int64 = pattern_input[0].l0
    pattern_input_1: tuple[int, Exception] = v2_1(None)
    v1164: Mut4 = Mut4("")
    method12(v1164, pattern_input_1[0], pattern_input_1[1])
    v1165: str = v1164.l0
    return trim_end(trim_start(((((((((("" + v772) + " ") + v1141) + " #") + str(v1160)) + " ") + v1(None)) + " / ") + v1165) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method17(v0: US0, v1: Callable[[], str]) -> None:
    def v4(v: US0, v0: Any=v0, v1: Any=v1) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
        return closure0(None, v)

    if State_trace_state() is None:
        State_trace_state(v4(US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value(State_trace_state())
    v13: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v4(US0(0)))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value(State_trace_state())
    v61: US0 = pattern_input_1[3].l0
    class ObjectExpr80:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr83:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (find(v0, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr80())) >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr83()))):
        v69: int64 = op_addition(v13.l0, int64(1))
        v13.l0 = v69
        v72: str = ("" + v1(None)) + ""
        _v81: None | None = None
        print(v72)
        _v81 = some(None)
        if _v81 is None:
            raise Exception("base.run_target / _v81=None")

        else: 
            value(_v81)

        pattern_input[1].l0(v72)



def method7(v0: US0, v1: Callable[[], str], v2_1: Callable[[], tuple[int, Exception]]) -> None:
    def v3_1(__unit: None=None, v0: Any=v0, v1: Any=v1, v2_1: Any=v2_1) -> str:
        return closure10(v0, v1, v2_1, None)

    method17(v0, v3_1)


def closure7(v0: int, v1: Exception) -> US5:
    def v3_1(__unit: None=None, v0: Any=v0, v1: Any=v1) -> str:
        return closure8(None, None)

    def v4(__unit: None=None, v0: Any=v0, v1: Any=v1) -> tuple[int, Exception]:
        return closure9(v0, v1, None)

    method7(US0(3), v3_1, v4)
    return US5(1)


def method6(v0_mut: int, v1_mut: Callable[[], None], v2_1_mut: int) -> US4:
    while True:
        (v0, v1, v2_1) = (v0_mut, v1_mut, v2_1_mut)
        result: FSharpRef[US5] = FSharpRef(US5(1))
        try: 
            result.contents = closure5(None, closure6(v0, v1, v2_1, None))

        except Exception as ex:
            result.contents = closure7(v2_1, ex)

        v9_1: US5 = result.contents
        if v9_1.tag == 0:
            return v9_1.fields[0]

        else: 
            v0_mut = v0
            v1_mut = v1
            v2_1_mut = v2_1 + 1
            continue

        break


def closure4(v0: int, v1: Callable[[], None]) -> None | None:
    v3_1: US4 = method6(v0, v1, 0)
    if v3_1.tag == 0:
        return some(None)

    else: 
        return None



def closure3(unit_var: None, v0: int) -> Callable[[Callable[[], None]], None | None]:
    def _arrow91(v: Callable[[], None], unit_var: Any=unit_var, v0: Any=v0) -> None | None:
        return closure4(v0, v)

    return _arrow91


def method18(v0: Callable[[], None]) -> Callable[[], None]:
    return v0


def closure12(v0: Any, unit_var: None) -> None:
    v0.Value


def closure11(unit_var: None, v0: Callable[[], None]) -> Callable[[], None]:
    v1: Callable[[], None] = method18(v0)
    def _arrow92(__unit: None=None, unit_var: Any=unit_var, v0: Any=v0) -> None:
        v1(None)

    v4: Any = Lazy(_arrow92)
    def _arrow93(__unit: None=None, unit_var: Any=unit_var, v0: Any=v0) -> None:
        closure12(v4, None)

    return _arrow93


def _arrow94(v: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
    return closure0(None, v)


v2: Callable[[US0], tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]] = _arrow94

v3: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v2(v3))


def _arrow95(v: Callable[[], None]) -> IDisposable:
    return closure2(None, v)


v9: Callable[[Callable[[], None]], IDisposable] = _arrow95

def new_disposable(x: Callable[[], None]) -> IDisposable:
    return v9(x)


def _arrow96(v: int) -> Callable[[Callable[[], None]], None | None]:
    return closure3(None, v)


v10: Callable[[int, Callable[[], None]], None | None] = _arrow96

def retry_fn(x: int) -> Callable[[Callable[[], None]], None | None]:
    return v10(x)


def _arrow97(v: Callable[[], None]) -> Callable[[], None]:
    return closure11(None, v)


v11: Callable[[Callable[[], None], None], None] = _arrow97

def memoize(x: Callable[[], None]) -> Callable[[], None]:
    return v11(x)


