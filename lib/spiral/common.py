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
from fable_modules.fable_library.option import (some, value as value_1, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.string_ import (pad_left, to_text, interpolate, trim_end, trim_start)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, IDisposable, to_enumerable, compare, Lazy)

TraceState_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] | None = create_atom(None)

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
    return record_type("Common.Mut3", [], Mut3, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: str

Mut3_reflection = _expr27

def _expr28() -> TypeInfo:
    return record_type("Common.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr28

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

def method1(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method3(__unit: None=None) -> str:
    return ""


def closure1(unit_var: None, v0_1: str) -> US1:
    return US1(0, v0_1)


def method4(__unit: None=None) -> Callable[[str], US1]:
    def _arrow34(v: str) -> US1:
        return closure1(None, v)

    return _arrow34


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
    def _arrow39(__unit: None=None, v0_1: Any=v0_1) -> US2:
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




    _v1: tuple[US2, US3] = (US2(0, v235.fields[0]) if (v235.tag == 0) else _arrow39(), US3(0, ticks_1(now())) if (method2(method5()) == "True") else US3(1))
    v352: US3 = _v1[1]
    v351: US2 = _v1[0]
    def v417(v: str, v0_1: Any=v0_1) -> None:
        closure2(None, v)

    return (Mut0(int64(1)), Mut1(v417), Mut2(True), Mut3(""), Mut4(v351.fields[0] if (v351.tag == 0) else v0_1), v352.fields[0] if (v352.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = method0(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def method6(v0_1: Callable[[], None]) -> Callable[[], None]:
    return v0_1


def method7(v0_1: Callable[[], None]) -> Callable[[], None]:
    return v0_1


def closure3(unit_var: None, v0_1: Callable[[], None]) -> IDisposable:
    v10: Callable[[], None] = method7(v0_1)
    class ObjectExpr43(IDisposable):
        def Dispose(self, __unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
            v10(None)

    return ObjectExpr43()


def closure6(unit_var: None, v0_1: US4) -> US5:
    return US5(0, v0_1)


def closure7(v0_1: int, v1_1: Callable[[], None], v2_1: int, unit_var: None) -> US4:
    if v2_1 < v0_1:
        v1_1(None)
        return US4(0)

    else: 
        return US4(1)



def closure10(unit_var: None, v0_1: int64) -> US3:
    return US3(0, v0_1)


def method10(__unit: None=None) -> Callable[[int64], US3]:
    def _arrow45(v: int64) -> US3:
        return closure10(None, v)

    return _arrow45


def method11(__unit: None=None) -> str:
    return "hh:mm:ss"


def method12(__unit: None=None) -> str:
    return "HH:mm:ss"


def method9(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None=None) -> str:
    v238: US3 = default_arg(map(method10(), v5), US3(1))
    def _arrow52(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4, v5: Any=v5) -> Any:
        v252: Any = create(op_subtraction(ticks_1(now()), v238.fields[0]))
        return create_1(1, 1, 1, hours(v252), minutes(v252), seconds(v252), milliseconds(v252))

    return to_string(_arrow52() if (v238.tag == 0) else now(), method12())


def method14(__unit: None=None) -> str:
    return "\u001b[0m"


def method13(__unit: None=None) -> str:
    return ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method14()


def method16(__unit: None=None) -> str:
    return ""


def closure11(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def method15(v0_1: int, v1_1: Exception) -> str:
    v3: Mut3 = Mut3(method16())
    v10: None
    closure11(v3, ("" + "{ ") + "", None)
    v10 = None
    v19: None
    closure11(v3, ("" + "retry") + "", None)
    v19 = None
    v28: None
    closure11(v3, ("" + " = ") + "", None)
    v28 = None
    v36: None
    closure11(v3, ("" + str(v0_1)) + "", None)
    v36 = None
    v45: None
    closure11(v3, ("" + "; ") + "", None)
    v45 = None
    v54: None
    closure11(v3, ("" + "ex") + "", None)
    v54 = None
    v62: None
    closure11(v3, ("" + " = ") + "", None)
    v62 = None
    v97: None
    closure11(v3, ("" + to_text(interpolate("%A%P()", [v1_1]))) + "", None)
    v97 = None
    v106: None
    closure11(v3, ("" + " }") + "", None)
    v106 = None
    return v3.l0


def method17(v0_1: str, v1_1: str, v2_1: int64, v3: str) -> str:
    return trim_end(trim_start(((((((((("" + v0_1) + " ") + v1_1) + " #") + str(v2_1)) + " ") + "common.retry_fn") + " / ") + v3) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def closure12(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure14(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure13(unit_var: None, v0_1: str) -> None:
    v3: None
    closure14(v0_1, None)
    v3 = None


def method18(v0_1: str, v1_1: Mut0, v2_1: Mut1, v3: Mut2, v4: Mut3, v5: Mut4, v6: int64 | None=None) -> None:
    v9: None
    closure12(v1_1, None)
    v9 = None
    closure13(None, v0_1)
    v2_1.l0(v0_1)


def closure9(v0_1: int, v1_1: Exception, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr69:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (3 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr69()))):
        v43: None
        v3(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v79: str = method17(method9(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method13(), v57.l0, method15(v0_1, v1_1))
        v81: None
        v3(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_1(TraceState_trace_state())
        method18(v79, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure8(v0_1: int, v1_1: Exception) -> US5:
    v4: None
    closure9(v0_1, v1_1, None)
    v4 = None
    return US5(1)


def method8(v0_1_mut: int, v1_1_mut: Callable[[], None], v2_1_mut: int) -> US4:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        result: FSharpRef[US5] = FSharpRef(US5(1))
        try: 
            result.contents = closure6(None, closure7(v0_1, v1_1, v2_1, None))

        except Exception as ex:
            result.contents = closure8(v2_1, ex)

        v7: US5 = result.contents
        if v7.tag == 0:
            return v7.fields[0]

        else: 
            v0_1_mut = v0_1
            v1_1_mut = v1_1
            v2_1_mut = v2_1 + 1
            continue

        break


def closure5(v0_1: int, v1_1: Callable[[], None]) -> None | None:
    v3: US4 = method8(v0_1, v1_1, 0)
    if v3.tag == 0:
        return some(None)

    else: 
        return None



def closure4(unit_var: None, v0_1: int) -> Callable[[Callable[[], None]], None | None]:
    def _arrow70(v: Callable[[], None], unit_var: Any=unit_var, v0_1: Any=v0_1) -> None | None:
        return closure5(v0_1, v)

    return _arrow70


def method19(v0_1: Callable[[], None]) -> Callable[[], None]:
    return v0_1


def closure16(v0_1: Any, unit_var: None) -> None:
    v0_1.Value


def closure15(unit_var: None, v0_1: Callable[[], None]) -> Callable[[], None]:
    v1_1: Callable[[], None] = method19(v0_1)
    def _arrow71(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        v1_1(None)

    v2_1: Any = Lazy(_arrow71)
    def _arrow72(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure16(v2_1, None)

    return _arrow72


v0: None = None

def _arrow73(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow73

def _expr74():
    v1(None)
    return v0


v2: None = _expr74()

def _arrow75(v: Callable[[], None]) -> IDisposable:
    return closure3(None, v)


v16: Callable[[Callable[[], None]], IDisposable] = _arrow75

def new_disposable(x: Callable[[], None]) -> IDisposable:
    return v16(x)


def _arrow76(v: int) -> Callable[[Callable[[], None]], None | None]:
    return closure4(None, v)


v17: Callable[[int, Callable[[], None]], None | None] = _arrow76

def retry_fn(x: int) -> Callable[[Callable[[], None]], None | None]:
    return v17(x)


def _arrow77(v: Callable[[], None]) -> Callable[[], None]:
    return closure15(None, v)


v18: Callable[[Callable[[], None], None], None] = _arrow77

def memoize(x: Callable[[], None]) -> Callable[[], None]:
    return v18(x)


