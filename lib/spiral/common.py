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
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, int64_type, record_type, bool_type, string_type, unit_type, lambda_type)
from fable_modules.fable_library.string_ import (to_text, interpolate, pad_left, trim_end, trim_start)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, IDisposable, to_enumerable, compare, Lazy)

State_trace_state: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] | None = create_atom(None)

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
    return record_type("Common.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr14

def _expr15() -> TypeInfo:
    return record_type("Common.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr15

def _expr16() -> TypeInfo:
    return record_type("Common.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr16

def _expr17() -> TypeInfo:
    return union_type("Common.US1", [], US1, lambda: [[("f0_0", int64_type)], []])


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

def US0__get_IsUS0_0(this: FSharpRef[US0], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US0__get_IsUS0_1(this: FSharpRef[US0], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US0__get_IsUS0_2(this: FSharpRef[US0], unit_arg: None) -> bool:
    if this.tag == 2:
        return True

    else: 
        return False



def US0__get_IsUS0_3(this: FSharpRef[US0], unit_arg: None) -> bool:
    if this.tag == 3:
        return True

    else: 
        return False



def US0__get_IsUS0_4(this: FSharpRef[US0], unit_arg: None) -> bool:
    if this.tag == 4:
        return True

    else: 
        return False



def US1__get_IsUS1_0(this: FSharpRef[US1], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US1__get_IsUS1_1(this: FSharpRef[US1], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US2__get_IsUS2_0(this: FSharpRef[US2], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US2__get_IsUS2_1(this: FSharpRef[US2], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US3__get_IsUS3_0(this: FSharpRef[US3], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US3__get_IsUS3_1(this: FSharpRef[US3], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US4__get_IsUS4_0(this: FSharpRef[US4], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US4__get_IsUS4_1(this: FSharpRef[US4], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US5__get_IsUS5_0(this: FSharpRef[US5], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US5__get_IsUS5_1(this: FSharpRef[US5], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



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
        v57 = value(_v54)

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


def closure0(unit_var: None, v0_1: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    _v1: tuple[US1, US2] | None = None
    v133: str = method1(method0())
    v139: US2 = US2(0, US0(0)) if ("Verbose" == v133) else US2(1)
    v184: US2
    if v139.tag == 0:
        v184 = US2(0, v139.fields[0])

    else: 
        v147: US2 = US2(0, US0(1)) if ("Debug" == v133) else US2(1)
        if v147.tag == 0:
            v184 = US2(0, v147.fields[0])

        else: 
            v155: US2 = US2(0, US0(2)) if ("Info" == v133) else US2(1)
            if v155.tag == 0:
                v184 = US2(0, v155.fields[0])

            else: 
                v163: US2 = US2(0, US0(3)) if ("Warning" == v133) else US2(1)
                if v163.tag == 0:
                    v184 = US2(0, v163.fields[0])

                else: 
                    v171: US2 = US2(0, US0(4)) if ("Critical" == v133) else US2(1)
                    v184 = US2(0, v171.fields[0]) if (v171.tag == 0) else US2(1)




    x: tuple[US1, US2] = (US1(0, ticks_1(now())) if (method1(method3()) == "True") else US1(1), v184)
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

    v267: Mut3 = Mut3(v266)
    return (Mut0(int64(0)), Mut1(True), Mut2(v259.fields[0] if (v259.tag == 0) else v0_1), v258.fields[0] if (v258.tag == 0) else None, v267)


def method4(v0_1: Callable[[], None]) -> Callable[[], None]:
    return v0_1


def method5(v0_1: Callable[[], None]) -> Callable[[], None]:
    return v0_1


def closure2(unit_var: None, v0_1: Callable[[], None]) -> IDisposable:
    _v1: IDisposable | None = None
    v10: Callable[[], None] = method5(v0_1)
    class ObjectExpr36(IDisposable):
        def Dispose(self, __unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
            v10(None)

    x: IDisposable = ObjectExpr36()
    _v1 = x
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def closure5(v0_1: int, v1_1: Callable[[], None], v2_1: int, unit_var: None) -> US4:
    if v2_1 < v0_1:
        v1_1(None)
        return US4(0)

    else: 
        return US4(1)



def closure6(unit_var: None, v0_1: US4) -> US5:
    return US5(0, v0_1)


def closure8(unit_var: None, unit_var_1: None) -> str:
    return "common.retry_fn"


def closure10(unit_var: None, unit_var_1: None) -> str:
    return ""


def closure9(v0_1: int, v1_1: Exception, unit_var: None) -> str:
    return to_text(interpolate("retry: %P() / ex: %A%P() / %P()", [v0_1, v1_1, closure10(None, None)]))


def method8(__unit: None=None) -> str:
    return "hh:mm:ss"


def method9(__unit: None=None) -> str:
    return ""


def method10(__unit: None=None) -> str:
    return "HH:mm:ss"


def method11(__unit: None=None) -> str:
    return "\u001b[0m"


def closure11(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    v8: int64 | None = pattern_input[3]
    _v10: str | None = None
    _v96: FSharpRef[US1 | None] = FSharpRef(None)
    x_2: US1 | None
    if v8 is None:
        x_2 = None

    else: 
        x: int64 = v8
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US1:
            return US1(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US1 = default_arg(_v96.contents, US1(1))
    def _arrow40(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow40() if (v101.tag == 0) else now(), method10())
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
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method11()
    _v216 = x_5
    def _arrow47(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> str:
        raise Exception("base.run_target / _v216=None")

    return trim_end(trim_start(((((((((("" + v152) + " ") + (_arrow47() if (_v216 is None) else _v216)) + " #") + str(pattern_input[0].l0)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method12(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(v: US0, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
        return closure0(None, v)

    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    v4_1: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value(State_trace_state())
    v15: US0 = pattern_input_1[2].l0
    class ObjectExpr62:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr64:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr62())) >= find(v15, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr64()))):
        v23: int64 = op_addition(v4_1.l0, int64(1))
        v4_1.l0 = v23
        v24: str = ("" + v1_1(None)) + ""
        _v25: None | None = None
        print(v24)
        _v25 = some(None)
        if _v25 is None:
            raise Exception("base.run_target / _v25=None")

        else: 
            value(_v25)

        pattern_input[4].l0(v24)



def method7(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure11(v0_1, v1_1, v2_1, None)

    method12(v0_1, v3_1)


def closure7(v0_1: int, v1_1: Exception) -> US5:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure8(None, None)

    def v4_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure9(v0_1, v1_1, None)

    method7(US0(3), v3_1, v4_1)
    return US5(1)


def method6(v0_1_mut: int, v1_1_mut: Callable[[], None], v2_1_mut: int) -> US4:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        v6: US5
        try: 
            v6 = closure6(None, closure5(v0_1, v1_1, v2_1, None))

        except Exception as ex:
            v6 = closure7(v2_1, ex)

        if v6.tag == 0:
            return v6.fields[0]

        else: 
            v0_1_mut = v0_1
            v1_1_mut = v1_1
            v2_1_mut = v2_1 + 1
            continue

        break


def closure4(v0_1: int, v1_1: Callable[[], None]) -> None | None:
    v3_1: US4 = method6(v0_1, v1_1, 0)
    if v3_1.tag == 0:
        return some(None)

    else: 
        return None



def closure3(unit_var: None, v0_1: int) -> Callable[[Callable[[], None]], None | None]:
    def _arrow68(v: Callable[[], None], unit_var: Any=unit_var, v0_1: Any=v0_1) -> None | None:
        return closure4(v0_1, v)

    return _arrow68


def method13(v0_1: Callable[[], None]) -> Callable[[], None]:
    return v0_1


def closure13(v0_1: Any, unit_var: None) -> None:
    v0_1.Value


def closure12(unit_var: None, v0_1: Callable[[], None]) -> Callable[[], None]:
    v1_1: Callable[[], None] = method13(v0_1)
    def _arrow69(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        v1_1(None)

    v2_1: Any = Lazy(_arrow69)
    def _arrow70(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure13(v2_1, None)

    return _arrow70


def _arrow71(v: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, v)


v0: Callable[[US0], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow71

v1: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v0(v1))


def _arrow72(v: Callable[[], None]) -> IDisposable:
    return closure2(None, v)


v2: Callable[[Callable[[], None]], IDisposable] = _arrow72

def new_disposable(x: Callable[[], None]) -> IDisposable:
    return v2(x)


def _arrow73(v: int) -> Callable[[Callable[[], None]], None | None]:
    return closure3(None, v)


v3: Callable[[int, Callable[[], None]], None | None] = _arrow73

def retry_fn(x: int) -> Callable[[Callable[[], None]], None | None]:
    return v3(x)


def _arrow74(v: Callable[[], None]) -> Callable[[], None]:
    return closure12(None, v)


v4: Callable[[Callable[[], None], None], None] = _arrow74

def memoize(x: Callable[[], None]) -> Callable[[], None]:
    return v4(x)


