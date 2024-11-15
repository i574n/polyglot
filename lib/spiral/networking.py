from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.async_ import (cancellation_token, await_task, start_child, catch_async, sleep)
from fable_modules.fable_library.async_builder import (singleton, CancellationToken, Async)
from fable_modules.fable_library.date import (ticks as ticks_1, now, to_string, create as create_1)
from fable_modules.fable_library.list import (to_array, empty, of_array)
from fable_modules.fable_library.long import (from_value, op_subtraction, op_addition, op_modulus)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_3, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type, class_type, int32_type)
from fable_modules.fable_library.string_ import (trim_end, trim_start, to_text, interpolate)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare, IDisposable)

TraceState_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr129() -> TypeInfo:
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


US0_reflection = _expr129

def _expr130() -> TypeInfo:
    return record_type("Networking.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr130

def _expr131() -> TypeInfo:
    return record_type("Networking.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr131

def _expr132() -> TypeInfo:
    return record_type("Networking.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr132

def _expr133() -> TypeInfo:
    return record_type("Networking.Mut3", [], Mut3, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: str

Mut3_reflection = _expr133

def _expr134() -> TypeInfo:
    return record_type("Networking.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr134

def _expr135() -> TypeInfo:
    return union_type("Networking.US1", [], US1, lambda: [[("f0_0", US0_reflection())], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr135

def _expr136() -> TypeInfo:
    return union_type("Networking.US2", [], US2, lambda: [[("f0_0", int64_type)], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr136

def _expr137() -> TypeInfo:
    return union_type("Networking.US3", [], US3, lambda: [[], [], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1", "US3_2"]


US3_reflection = _expr137

def _expr138() -> TypeInfo:
    return union_type("Networking.US4", [], US4, lambda: [[("f0_0", US3_reflection())], [("f1_0", US3_reflection())], [("f2_0", US3_reflection())], [("f3_0", US3_reflection())], [("f4_0", US3_reflection())]])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1", "US4_2", "US4_3", "US4_4"]


US4_reflection = _expr138

def _expr139() -> TypeInfo:
    return union_type("Networking.US5", [], US5, lambda: [[("f0_0", string_type)], []])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr139

def _expr140() -> TypeInfo:
    return union_type("Networking.US6", [], US6, lambda: [[("f0_0", bool_type)], []])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1"]


US6_reflection = _expr140

def _expr141() -> TypeInfo:
    return union_type("Networking.US7", [], US7, lambda: [[("f0_0", bool_type)], [("f1_0", class_type("System.Exception"))]])


class US7(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US7_0", "US7_1"]


US7_reflection = _expr141

def _expr142() -> TypeInfo:
    return union_type("Networking.US8", [], US8, lambda: [[("f0_0", bool_type)], [("f1_0", class_type("System.Exception"))]])


class US8(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US8_0", "US8_1"]


US8_reflection = _expr142

def _expr143() -> TypeInfo:
    return union_type("Networking.US9", [], US9, lambda: [[("f0_0", int32_type)], []])


class US9(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US9_0", "US9_1"]


US9_reflection = _expr143

def method3(__unit: None=None) -> str:
    return ""


def closure1(unit_var: None, v0_1: str) -> US5:
    return US5(0, v0_1)


def method4(__unit: None=None) -> Callable[[str], US5]:
    def _arrow144(v: str) -> US5:
        return closure1(None, v)

    return _arrow144


def method2(v0_1: str) -> str:
    v28: IOsEnviron = os
    v30: Any = v28.environ
    _v34: (str | None) | None = None
    x: str | None = v30.get(v0_1)
    _v34 = some(x)
    v39: str | None
    if _v34 is None:
        raise Exception("optionm\'.of_obj / _v34=None")

    else: 
        v39 = value_3(_v34)

    v55: US5 = default_arg(map(method4(), v39), US5(1))
    if v55.tag == 0:
        return v55.fields[0]

    else: 
        return ""



def method1(__unit: None=None) -> tuple[US1, US2]:
    v1_1: str = method2("TRACE_LEVEL")
    v6: US1 = US1(0, US0(0)) if ("Verbose" == v1_1) else US1(1)
    def _arrow145(__unit: None=None) -> US1:
        v13: US1 = US1(0, US0(1)) if ("Debug" == v1_1) else US1(1)
        if v13.tag == 0:
            return US1(0, v13.fields[0])

        else: 
            v20: US1 = US1(0, US0(2)) if ("Info" == v1_1) else US1(1)
            if v20.tag == 0:
                return US1(0, v20.fields[0])

            else: 
                v27: US1 = US1(0, US0(3)) if ("Warning" == v1_1) else US1(1)
                if v27.tag == 0:
                    return US1(0, v27.fields[0])

                else: 
                    v34: US1 = US1(0, US0(4)) if ("Critical" == v1_1) else US1(1)
                    return US1(0, v34.fields[0]) if (v34.tag == 0) else US1(1)




    return (US1(0, v6.fields[0]) if (v6.tag == 0) else _arrow145(), US2(1) if (method2("AUTOMATION") != "True") else US2(0, from_value(ticks_1(now()), False)))


def closure2(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None]:
    pattern_input: tuple[US1, US2] = method1()
    _v1: tuple[US1, US2] = (pattern_input[0], pattern_input[1])
    v132: US2 = _v1[1]
    v131: US1 = _v1[0]
    def v138(v: str, v0_1: Any=v0_1) -> None:
        closure2(None, v)

    return (Mut0(int64(1)), Mut1(v138), Mut2(True), Mut3(""), Mut4(v131.fields[0] if (v131.tag == 0) else v0_1), v132.fields[0] if (v132.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = method0(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def method6(v0_1: US0) -> bool:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v35: US0 = pattern_input[4].l0
    if pattern_input[2].l0 == False:
        return False

    else: 
        class ObjectExpr146:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        class ObjectExpr147:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        return find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr146())) >= find(v35, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr147()))



def closure6(unit_var: None, v0_1: int64) -> US2:
    return US2(0, v0_1)


def method8(__unit: None=None) -> Callable[[int64], US2]:
    def _arrow148(v: int64) -> US2:
        return closure6(None, v)

    return _arrow148


def method9(__unit: None=None) -> str:
    return "hh:mm:ss"


def method10(__unit: None=None) -> str:
    return "HH:mm:ss"


def method7(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None=None) -> str:
    v408: US2 = default_arg(map(method8(), v5), US2(1))
    def _arrow149(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4, v5: Any=v5) -> Any:
        v466: Any = create(op_subtraction(from_value(ticks_1(now()), False), v408.fields[0]))
        return create_1(1, 1, 1, hours(v466), minutes(v466), seconds(v466), milliseconds(v466))

    return to_string(_arrow149() if (v408.tag == 0) else now(), method10())


def method13(__unit: None=None) -> str:
    return ""


def closure7(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def method12(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method13())
    v8: None
    closure7(v2_1, ("" + str(v0_1)) + "", None)
    v8 = None
    return v2_1.l0


def method14(__unit: None=None) -> str:
    return "\u001b[0m"


def method11(__unit: None=None) -> str:
    v2_1: str = "Verbose".lower()
    return ("\u001b[90m" + method12(v2_1[0])) + method14()


def method16(v0_1: int, v1_1: str) -> str:
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


def method17(v0_1: str) -> str:
    return trim_end(trim_start(v0_1, *to_array(empty())), *to_array(of_array([" ", "/"])))


def method15(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: int, v9: str) -> str:
    v10: str = method16(v8, v9)
    return method17(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "networking.test_port_open") + " / ") + v10) + "")


def closure8(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure10(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure9(unit_var: None, v0_1: str) -> None:
    v3: None
    closure10(v0_1, None)
    v3 = None


def method18(v0_1: str) -> None:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    closure8(pattern_input[0], None)
    v37 = None
    closure9(None, v0_1)
    pattern_input[1].l0(v0_1)


def closure5(v0_1: int, v1_1: str, unit_var: None) -> None:
    if method6(US0(0)):
        v6: None
        closure0(None, None)
        v6 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut4 = pattern_input[4]
        v23: Mut3 = pattern_input[3]
        v22: Mut2 = pattern_input[2]
        v21: Mut1 = pattern_input[1]
        v20: Mut0 = pattern_input[0]
        method18(method15(v20, v21, v22, v23, v24, v25, method7(v20, v21, v22, v23, v24, v25), method11(), v0_1, v1_1))



def method5(v0_1: str, v1_1: int) -> Async[bool]:
    def _arrow155(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[bool]:
        v183: Async[CancellationToken] = cancellation_token()
        def _arrow154(_arg: CancellationToken) -> Async[bool]:
            def _arrow153(_arg_1: IDisposable) -> Async[bool]:
                def _arrow151(__unit: None=None) -> Async[bool]:
                    v272: Async[None] = await_task(None)
                    def _arrow150(__unit: None=None) -> Async[bool]:
                        return singleton.Return(True)

                    return singleton.Bind(v272, _arrow150)

                def _arrow152(_arg_3: Exception) -> Async[bool]:
                    v310: None
                    closure5(v1_1, to_text(interpolate("%A%P()", [_arg_3])), None)
                    v310 = None
                    return singleton.Return(False)

                return singleton.TryWith(singleton.Delay(_arrow151), _arrow152)

            return singleton.Using(None, _arrow153)

        return singleton.Bind(v183, _arrow154)

    return singleton.Delay(_arrow155)


def closure4(v0_1: str, v1_1: int) -> Async[bool]:
    return method5(v0_1, v1_1)


def closure3(unit_var: None, v0_1: str) -> Callable[[int], Async[bool]]:
    def _arrow156(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[bool]:
        return closure4(v0_1, v)

    return _arrow156


def closure14(unit_var: None, v0_1: bool) -> US7:
    return US7(0, v0_1)


def method21(__unit: None=None) -> Callable[[bool], US7]:
    def _arrow157(v: bool) -> US7:
        return closure14(None, v)

    return _arrow157


def closure15(unit_var: None, v0_1: Exception) -> US7:
    return US7(1, v0_1)


def method22(__unit: None=None) -> Callable[[Exception], US7]:
    def _arrow158(v: Exception) -> US7:
        return closure15(None, v)

    return _arrow158


def method24(v0_1: int) -> str:
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


def method23(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: int) -> str:
    v9: str = method24(v8)
    return method17(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "async.run_with_timeout_async") + " / ") + v9) + "")


def closure16(v0_1: int, unit_var: None) -> None:
    if method6(US0(0)):
        v5: None
        closure0(None, None)
        v5 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v24: int64 | None = pattern_input[5]
        v23: Mut4 = pattern_input[4]
        v22: Mut3 = pattern_input[3]
        v21: Mut2 = pattern_input[2]
        v20: Mut1 = pattern_input[1]
        v19_1: Mut0 = pattern_input[0]
        method18(method23(v19_1, v20, v21, v22, v23, v24, method7(v19_1, v20, v21, v22, v23, v24), method11(), v0_1))



def method25(__unit: None=None) -> str:
    v2_1: str = "Critical".lower()
    return ("\u001b[91m" + method12(v2_1[0])) + method14()


def method27(v0_1: int, v1_1: str) -> str:
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


def method26(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: int, v9: str) -> str:
    v10: str = method27(v8, v9)
    return method17(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "async.run_with_timeout_async**") + " / ") + v10) + "")


def closure17(v0_1: int, v1_1: Exception, unit_var: None) -> None:
    if method6(US0(4)):
        v6: None
        closure0(None, None)
        v6 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut4 = pattern_input[4]
        v23: Mut3 = pattern_input[3]
        v22: Mut2 = pattern_input[2]
        v21: Mut1 = pattern_input[1]
        v20: Mut0 = pattern_input[0]
        method18(method26(v20, v21, v22, v23, v24, v25, method7(v20, v21, v22, v23, v24, v25), method25(), v0_1, to_text(interpolate("%A%P()", [v1_1]))))



def method20(v0_1: int, v1_1: Async[bool]) -> Async[US6]:
    def _arrow166(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[US6]:
        v12744: Async[Async[bool]] = start_child(v1_1, v0_1)
        def _arrow165(_arg: Async[bool]) -> Async[US6]:
            v12763: Async[Any] = catch_async(_arg)
            def _arrow160(__unit: None=None) -> Async[US7]:
                def _arrow159(_arg_1: Any) -> Async[US7]:
                    return singleton.Return(None)

                return singleton.Bind(v12763, _arrow159)

            _v12813: Async[US7] = singleton.Delay(_arrow160)
            def _arrow162(__unit: None=None) -> Async[US8]:
                def _arrow161(_arg_2: US7) -> Async[US8]:
                    v12928: US7 = _arg_2
                    v12934: US8 = US8(1, v12928.fields[0]) if (v12928.tag == 1) else US8(0, v12928.fields[0])
                    return singleton.Return(v12934)

                return singleton.Bind(_v12813, _arrow161)

            _v12927: Async[US8] = singleton.Delay(_arrow162)
            def _arrow164(__unit: None=None) -> Async[US6]:
                def _arrow163(_arg_3: US8) -> Async[US6]:
                    v13097: US8 = _arg_3
                    v13221: US6
                    if v13097.tag == 0:
                        v13221 = US6(0, v13097.fields[0])

                    else: 
                        v13100: Exception = v13097.fields[0]
                        v13101: str = to_text(interpolate("%A%P()", [v13100]))
                        if v13101.find("System.TimeoutException") >= 0:
                            v13110: None
                            closure16(v0_1, None)
                            v13110 = None
                            v13221 = US6(1)

                        else: 
                            v13153: None
                            closure17(v0_1, v13100, None)
                            v13153 = None
                            v13221 = US6(1)


                    return singleton.Return(v13221)

                return singleton.Bind(_v12927, _arrow163)

            _v13096: Async[US6] = singleton.Delay(_arrow164)
            return singleton.ReturnFrom(_v13096)

        return singleton.Bind(v12744, _arrow165)

    return singleton.Delay(_arrow166)


def method19(v0_1: int, v1_1: str, v2_1: int) -> Async[bool]:
    def _arrow168(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> Async[bool]:
        v23: Async[US6] = method20(v0_1, method5(v1_1, v2_1))
        def _arrow167(_arg: US6) -> Async[bool]:
            v24: US6 = _arg
            v27: bool = v24.fields[0] if (v24.tag == 0) else False
            return singleton.Return(v27)

        return singleton.Bind(v23, _arrow167)

    return singleton.Delay(_arrow168)


def closure13(v0_1: int, v1_1: str, v2_1: int) -> Async[bool]:
    return method19(v0_1, v1_1, v2_1)


def closure12(v0_1: int, v1_1: str) -> Callable[[int], Async[bool]]:
    def _arrow169(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[bool]:
        return closure13(v0_1, v1_1, v)

    return _arrow169


def closure11(unit_var: None, v0_1: int) -> Callable[[str, int], Async[bool]]:
    def _arrow170(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[bool]]:
        return closure12(v0_1, v)

    return _arrow170


def closure22(unit_var: None, v0_1: int) -> US9:
    return US9(0, v0_1)


def method30(__unit: None=None) -> Callable[[int], US9]:
    def _arrow171(v: int) -> US9:
        return closure22(None, v)

    return _arrow171


def method32(v0_1: int, v1_1: int64, v2_1: int | None, v3: bool) -> str:
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
    v135: None
    closure7(v5, ("" + to_text(interpolate("%A%P()", [v2_1]))) + "", None)
    v135 = None
    v143: None
    closure7(v5, ("" + "; ") + "", None)
    v143 = None
    v152: None
    closure7(v5, ("" + "status") + "", None)
    v152 = None
    v160: None
    closure7(v5, ("" + " = ") + "", None)
    v160 = None
    v171: None
    closure7(v5, ("" + ("true" if v3 else "false")) + "", None)
    v171 = None
    v180: None
    closure7(v5, ("" + " }") + "", None)
    v180 = None
    return v5.l0


def method31(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: int, v9: int64, v10: int | None, v11: bool) -> str:
    v12: str = method32(v8, v9, v10, v11)
    return method17(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "networking.wait_for_port_access") + " / ") + v12) + "")


def closure23(v0_1: int | None, v1_1: bool, v2_1: int, v3: int64, unit_var: None) -> None:
    if method6(US0(0)):
        v8: None
        closure0(None, None)
        v8 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        v27: int64 | None = pattern_input[5]
        v26: Mut4 = pattern_input[4]
        v25: Mut3 = pattern_input[3]
        v24: Mut2 = pattern_input[2]
        v23: Mut1 = pattern_input[1]
        v22: Mut0 = pattern_input[0]
        method18(method31(v22, v23, v24, v25, v26, v27, method7(v22, v23, v24, v25, v26, v27), method11(), v2_1, v3, v0_1, v1_1))



def method29(v0_1: int | None, v1_1: bool, v2_1: str, v3: int, v4: int64) -> Async[int64]:
    def _arrow176(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> Async[int64]:
        v121: US9 = default_arg(map(method30(), v0_1), US9(1))
        v129: Async[bool] = method19(v121.fields[0], v2_1, v3) if (v121.tag == 0) else method5(v2_1, v3)
        def _arrow175(_arg: bool) -> Async[int64]:
            if _arg == v1_1:
                return singleton.Return(v4)

            else: 
                v133: bool = op_modulus(v4, int64(100)) == int64(0)
                def _arrow172(__unit: None=None) -> Async[None]:
                    v136: None
                    closure23(v0_1, v1_1, v3, v4, None)
                    v136 = None
                    return singleton.Zero()

                def _arrow174(__unit: None=None) -> Async[int64]:
                    v186: Async[None] = sleep(10)
                    def _arrow173(__unit: None=None) -> Async[int64]:
                        v197: Async[int64] = method29(v0_1, v1_1, v2_1, v3, op_addition(v4, int64(1)))
                        return singleton.ReturnFrom(v197)

                    return singleton.Bind(v186, _arrow173)

                return singleton.Combine(_arrow172() if v133 else singleton.Zero(), singleton.Delay(_arrow174))


        return singleton.Bind(v129, _arrow175)

    return singleton.Delay(_arrow176)


def method28(v0_1: int | None, v1_1: bool, v2_1: str, v3: int) -> Async[int64]:
    return method29(v0_1, v1_1, v2_1, v3, int64(1))


def closure21(v0_1: int | None, v1_1: bool, v2_1: str, v3: int) -> Async[int64]:
    return method28(v0_1, v1_1, v2_1, v3)


def closure20(v0_1: int | None, v1_1: bool, v2_1: str) -> Callable[[int], Async[int64]]:
    def _arrow177(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> Async[int64]:
        return closure21(v0_1, v1_1, v2_1, v)

    return _arrow177


def closure19(v0_1: int | None, v1_1: bool) -> Callable[[str, int], Async[int64]]:
    def _arrow178(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Callable[[int], Async[int64]]:
        return closure20(v0_1, v1_1, v)

    return _arrow178


def closure18(unit_var: None, v0_1: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    def _arrow179(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str, int], Async[int64]]:
        return closure19(v0_1, v)

    return _arrow179


def method34(v0_1: int | None, v1_1: str, v2_1: int) -> Async[int]:
    def _arrow181(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> Async[int]:
        v55: US9 = default_arg(map(method30(), v0_1), US9(1))
        v63: Async[bool] = method19(v55.fields[0], v1_1, v2_1) if (v55.tag == 0) else method5(v1_1, v2_1)
        def _arrow180(_arg: bool) -> Async[int]:
            if _arg == False:
                return singleton.Return(v2_1)

            else: 
                v67: Async[int] = method34(v0_1, v1_1, v2_1 + 1)
                return singleton.ReturnFrom(v67)


        return singleton.Bind(v63, _arrow180)

    return singleton.Delay(_arrow181)


def method33(v0_1: int | None, v1_1: str, v2_1: int) -> Async[int]:
    return method34(v0_1, v1_1, v2_1)


def closure26(v0_1: int | None, v1_1: str, v2_1: int) -> Async[int]:
    return method33(v0_1, v1_1, v2_1)


def closure25(v0_1: int | None, v1_1: str) -> Callable[[int], Async[int]]:
    def _arrow182(v: int, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[int]:
        return closure26(v0_1, v1_1, v)

    return _arrow182


def closure24(unit_var: None, v0_1: int | None=None) -> Callable[[str, int], Async[int]]:
    def _arrow183(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[int]]:
        return closure25(v0_1, v)

    return _arrow183


v0: None = None

def _arrow184(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow184

def _expr185():
    v1(None)
    return v0


v2: None = _expr185()

def _arrow186(v: str) -> Callable[[int], Async[bool]]:
    return closure3(None, v)


v16: Callable[[str, int], Async[bool]] = _arrow186

def test_port_open(x: str) -> Callable[[int], Async[bool]]:
    return v16(x)


def _arrow187(v: int) -> Callable[[str, int], Async[bool]]:
    return closure11(None, v)


v17: Callable[[int, str, int], Async[bool]] = _arrow187

def test_port_open_timeout(x: int) -> Callable[[str, int], Async[bool]]:
    return v17(x)


def _arrow188(v: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return closure18(None, v)


v18: Callable[[int | None, bool, str, int], Async[int64]] = _arrow188

def wait_for_port_access(x: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return v18(x)


def _arrow189(v: int | None=None) -> Callable[[str, int], Async[int]]:
    return closure24(None, v)


v19: Callable[[int | None, str, int], Async[int]] = _arrow189

def get_available_port(x: int | None=None) -> Callable[[str, int], Async[int]]:
    return v19(x)


