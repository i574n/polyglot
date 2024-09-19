from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.async_builder import Async
from fable_modules.fable_library.date import (ticks as ticks_1, now, to_string, create as create_1)
from fable_modules.fable_library.guid import (parse, new_guid)
from fable_modules.fable_library.list import (to_array, empty, of_array, singleton)
from fable_modules.fable_library.long import (op_addition, op_subtraction)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_3, default_arg)
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.result import FSharpResult_2
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, to_text, interpolate, replace)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds, to_string as to_string_1)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef, uint8)
from fable_modules.fable_library.util import (create_atom, IDisposable, ignore, to_enumerable, compare)

TraceState_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


class IFsExistsSync(Protocol):
    @abstractmethod
    def exists_sync(self, path: str) -> bool:
        ...


class IPathJoin(Protocol):
    @abstractmethod
    def join(self, paths: Array[str]) -> str:
        ...


def _expr259() -> TypeInfo:
    return class_type("File_system.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr259

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


class IPathDirname(Protocol):
    @abstractmethod
    def dirname(self, path: str) -> str:
        ...


def _expr260() -> TypeInfo:
    return union_type("File_system.US0", [], US0, lambda: [[], [], [], [], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1", "US0_2", "US0_3", "US0_4"]


US0_reflection = _expr260

def _expr261() -> TypeInfo:
    return record_type("File_system.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr261

def _expr262() -> TypeInfo:
    return record_type("File_system.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr262

def _expr263() -> TypeInfo:
    return record_type("File_system.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr263

def _expr264() -> TypeInfo:
    return record_type("File_system.Mut3", [], Mut3, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: str

Mut3_reflection = _expr264

def _expr265() -> TypeInfo:
    return record_type("File_system.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr265

def _expr266() -> TypeInfo:
    return union_type("File_system.US1", [], US1, lambda: [[("f0_0", string_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr266

def _expr267() -> TypeInfo:
    return union_type("File_system.US2", [], US2, lambda: [[("f0_0", US0_reflection())], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr267

def _expr268() -> TypeInfo:
    return union_type("File_system.US3", [], US3, lambda: [[("f0_0", int64_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr268

def _expr269() -> TypeInfo:
    return union_type("File_system.US4", [], US4, lambda: [[], [], []])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1", "US4_2"]


US4_reflection = _expr269

def _expr270() -> TypeInfo:
    return union_type("File_system.US5", [], US5, lambda: [[("f0_0", US4_reflection())], [("f1_0", US4_reflection())], [("f2_0", US4_reflection())], [("f3_0", US4_reflection())], [("f4_0", US4_reflection())]])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1", "US5_2", "US5_3", "US5_4"]


US5_reflection = _expr270

def _expr271() -> TypeInfo:
    return union_type("File_system.US7", [], US7, lambda: [[], [], []])


class US7(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US7_0", "US7_1", "US7_2"]


US7_reflection = _expr271

def _expr272() -> TypeInfo:
    return union_type("File_system.US8", [], US8, lambda: [[], [], [], [], []])


class US8(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US8_0", "US8_1", "US8_2", "US8_3", "US8_4"]


US8_reflection = _expr272

def _expr273() -> TypeInfo:
    return union_type("File_system.US6", [], US6, lambda: [[("f0_0", US7_reflection()), ("f0_1", US8_reflection())], []])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1"]


US6_reflection = _expr273

def _expr274() -> TypeInfo:
    return union_type("File_system.US9", [], US9, lambda: [[("f0_0", int64_type)], [("f1_0", class_type("System.Exception"))]])


class US9(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US9_0", "US9_1"]


US9_reflection = _expr274

def _expr275() -> TypeInfo:
    return union_type("File_system.US10", [], US10, lambda: [[("f0_0", int64_type)], [("f1_0", class_type("System.Exception"))]])


class US10(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US10_0", "US10_1"]


US10_reflection = _expr275

def _expr276() -> TypeInfo:
    return union_type("File_system.US11", [], US11, lambda: [[("f0_0", class_type("File_system.chrono_DateTime`1", [class_type("File_system.chrono_Utc")]))], []])


class US11(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US11_0", "US11_1"]


US11_reflection = _expr276

def _expr277() -> TypeInfo:
    return union_type("File_system.US12", [], US12, lambda: [[], [("f1_0", class_type("File_system.std_string_String"))]])


class US12(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US12_0", "US12_1"]


US12_reflection = _expr277

def _expr278() -> TypeInfo:
    return union_type("File_system.US13", [], US13, lambda: [[("f0_0", string_type)], [("f1_0", string_type)]])


class US13(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US13_0", "US13_1"]


US13_reflection = _expr278

def method1(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method3(__unit: None=None) -> str:
    return ""


def closure1(v0_1: FSharpRef[US1 | None], v1_1: US1 | None=None) -> FSharpRef[US1 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure2(v0_1: str | None, v1_1: Callable[[US1 | None], FSharpRef[US1 | None]], unit_var: None) -> None:
    def _arrow279(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US1 | None:
        x: str = v0_1
        def x_1(__unit: None=None) -> US1:
            return US1(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow279()))


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
        v61 = value_3(_v56)

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
    def _arrow280(__unit: None=None, v0_1: Any=v0_1) -> US2:
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




    _v1: tuple[US2, US3] = (US2(0, v178.fields[0]) if (v178.tag == 0) else _arrow280(), US3(0, ticks_1(now())) if (method2(method4()) == "True") else US3(1))
    v295: US3 = _v1[1]
    v294: US2 = _v1[0]
    def v360(v: str, v0_1: Any=v0_1) -> None:
        closure3(None, v)

    return (Mut0(int64(0)), Mut1(v360), Mut2(True), Mut3(""), Mut4(v294.fields[0] if (v294.tag == 0) else v0_1), v295.fields[0] if (v295.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = method0(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def method7(v0_1: str) -> str:
    return v0_1


def method8(v0_1: str) -> bool:
    return None


def method6(v0_1: bool, v1_1: str) -> None:
    pass


def closure6(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure7(v0_1: FSharpRef[US3 | None], v1_1: US3 | None=None) -> FSharpRef[US3 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure8(v0_1: int64 | None, v1_1: Callable[[US3 | None], FSharpRef[US3 | None]], unit_var: None) -> None:
    def _arrow281(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US3 | None:
        x: int64 = v0_1
        def x_1(__unit: None=None) -> US3:
            return US3(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow281()))


def method9(__unit: None=None) -> str:
    return "hh:mm:ss"


def method10(__unit: None=None) -> str:
    return "HH:mm:ss"


def method11(__unit: None=None) -> str:
    return "\u001b[0m"


def method12(v0_1: str) -> str:
    raise Exception(((("file_system.get_file_name / target: " + str(US5(4, US4(0)))) + " / path: ") + v0_1) + "")


def method13(__unit: None=None) -> str:
    return ""


def closure9(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def closure11(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure10(unit_var: None, v0_1: str) -> None:
    v3: None
    closure11(v0_1, None)
    v3 = None


def closure5(v0_1: str, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr282:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr282()))):
        v77: None
        closure6(pattern_input[0], None)
        v77 = None
        v81: None
        v3(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v360, v)

        closure8(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow283(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow283() if (v380.tag == 0) else now(), method10())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method11()
        v637: int64 = pattern_input_2[0].l0
        v638: str = method12(v0_1)
        v640: Mut3 = Mut3(method13())
        v647: None
        closure9(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure9(v640, ("" + "ex") + "", None)
        v656 = None
        v665: None
        closure9(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure9(v640, ("" + v1_1) + "", None)
        v673 = None
        v682: None
        closure9(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure9(v640, ("" + "path") + "", None)
        v691 = None
        v699: None
        closure9(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure9(v640, ("" + v638) + "", None)
        v707 = None
        v716: None
        closure9(v640, ("" + " }") + "", None)
        v716 = None
        v758: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "file_system.delete_directory_async") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v758)
        pattern_input[1].l0(v758)



def method5(v0_1: str, v1_1: int64) -> Async[int64]:
    return None


def closure4(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def closure14(v0_1: str, v1_1: int64, v2_1: str, unit_var: None) -> None:
    def v4(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v5: None
    v4(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr284:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr284()))):
        v78: None
        closure6(pattern_input[0], None)
        v78 = None
        v82: None
        v4(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v361, v)

        closure8(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow285(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow285() if (v381.tag == 0) else now(), method10())
        v627: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method11()
        v638: int64 = pattern_input_2[0].l0
        v639: str = method12(v0_1)
        v641: Mut3 = Mut3(method13())
        v648: None
        closure9(v641, ("" + "{ ") + "", None)
        v648 = None
        v657: None
        closure9(v641, ("" + "path") + "", None)
        v657 = None
        v666: None
        closure9(v641, ("" + " = ") + "", None)
        v666 = None
        v674: None
        closure9(v641, ("" + v639) + "", None)
        v674 = None
        v683: None
        closure9(v641, ("" + "; ") + "", None)
        v683 = None
        v692: None
        closure9(v641, ("" + "retry") + "", None)
        v692 = None
        v700: None
        closure9(v641, ("" + " = ") + "", None)
        v700 = None
        v708: None
        closure9(v641, ("" + str(v1_1)) + "", None)
        v708 = None
        v716: None
        closure9(v641, ("" + "; ") + "", None)
        v716 = None
        v725: None
        closure9(v641, ("" + "ex") + "", None)
        v725 = None
        v733: None
        closure9(v641, ("" + " = ") + "", None)
        v733 = None
        v741: None
        closure9(v641, ("" + v2_1) + "", None)
        v741 = None
        v750: None
        closure9(v641, ("" + " }") + "", None)
        v750 = None
        v792: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "file_system.wait_for_file_access") + " / ") + v641.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v792)
        pattern_input[1].l0(v792)



def method14(v0_1: str, v1_1: US8, v2_1: US7, v3: int64) -> Async[int64]:
    return None


def closure13(v0_1: US6, v1_1: str) -> Async[int64]:
    return None


def closure12(unit_var: None, v0_1: US6) -> Callable[[str], Async[int64]]:
    def _arrow286(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure13(v0_1, v)

    return _arrow286


def method15(v0_1: str, v1_1: int64) -> Async[int64]:
    return None


def closure15(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def closure16(unit_var: None, v0_1: str) -> Async[str]:
    return None


def method17(v0_1: str) -> bool:
    return None


def method18(v0_1: Vec_1[uint8]) -> Vec_1[uint8]:
    return v0_1


def method16(v0_1: str, v1_1: str) -> bool:
    return None


def closure18(v0_1: str, v1_1: str) -> bool:
    return method16(v0_1, v1_1)


def closure17(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow287(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure18(v0_1, v)

    return _arrow287


def closure20(v0_1: str, v1_1: str) -> Async[None]:
    return None


def closure19(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow288(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure20(v0_1, v)

    return _arrow288


def closure22(v0_1: str, v1_1: str) -> Async[None]:
    return None


def closure21(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow289(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure22(v0_1, v)

    return _arrow289


def closure24(v0_1: str, v1_1: Exception, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr290:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr290()))):
        v77: None
        closure6(pattern_input[0], None)
        v77 = None
        v81: None
        v3(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v360, v)

        closure8(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow291(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow291() if (v380.tag == 0) else now(), method10())
        v626: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method11()
        v637: int64 = pattern_input_2[0].l0
        v638: str = method12(v0_1)
        v652: str = to_text(interpolate("%A%P()", [v1_1]))
        v662: Mut3 = Mut3(method13())
        v669: None
        closure9(v662, ("" + "{ ") + "", None)
        v669 = None
        v678: None
        closure9(v662, ("" + "path") + "", None)
        v678 = None
        v687: None
        closure9(v662, ("" + " = ") + "", None)
        v687 = None
        v695: None
        closure9(v662, ("" + v638) + "", None)
        v695 = None
        v704: None
        closure9(v662, ("" + "; ") + "", None)
        v704 = None
        v713: None
        closure9(v662, ("" + "ex") + "", None)
        v713 = None
        v721: None
        closure9(v662, ("" + " = ") + "", None)
        v721 = None
        v729: None
        closure9(v662, ("" + v652) + "", None)
        v729 = None
        v738: None
        closure9(v662, ("" + " }") + "", None)
        v738 = None
        v780: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "delete_file_async") + " / ") + v662.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v780)
        pattern_input[1].l0(v780)



def method19(v0_1: str, v1_1: int64) -> Async[int64]:
    return None


def closure23(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def closure27(v0_1: str, v1_1: str, v2_1: Exception, unit_var: None) -> None:
    def v4(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v5: None
    v4(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v38: None
    v4(None)
    v38 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v70: US0 = pattern_input_1[4].l0
    class ObjectExpr292:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v70, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr292()))):
        v78: None
        closure6(pattern_input[0], None)
        v78 = None
        v82: None
        v4(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v361: FSharpRef[US3 | None] = FSharpRef(None)
        v366: None
        def v363(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v361, v)

        closure8(pattern_input_2[5], v363, None)
        v366 = None
        v381: US3 = default_arg(_v361.contents, US3(1))
        def _arrow293(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v395: Any = create(op_subtraction(ticks_1(now()), v381.fields[0]))
            return create_1(1, 1, 1, hours(v395), minutes(v395), seconds(v395), milliseconds(v395))

        v426: str = to_string(_arrow293() if (v381.tag == 0) else now(), method10())
        v627: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method11()
        v638: int64 = pattern_input_2[0].l0
        v639: str = method12(v1_1)
        v640: str = method12(v0_1)
        v642: Mut3 = Mut3(method13())
        v649: None
        closure9(v642, ("" + "{ ") + "", None)
        v649 = None
        v658: None
        closure9(v642, ("" + "old_path") + "", None)
        v658 = None
        v667: None
        closure9(v642, ("" + " = ") + "", None)
        v667 = None
        v675: None
        closure9(v642, ("" + v639) + "", None)
        v675 = None
        v684: None
        closure9(v642, ("" + "; ") + "", None)
        v684 = None
        v693: None
        closure9(v642, ("" + "new_path") + "", None)
        v693 = None
        v701: None
        closure9(v642, ("" + " = ") + "", None)
        v701 = None
        v709: None
        closure9(v642, ("" + v640) + "", None)
        v709 = None
        v717: None
        closure9(v642, ("" + "; ") + "", None)
        v717 = None
        v726: None
        closure9(v642, ("" + "ex") + "", None)
        v726 = None
        v734: None
        closure9(v642, ("" + " = ") + "", None)
        v734 = None
        v769: None
        closure9(v642, ("" + to_text(interpolate("%A%P()", [v2_1]))) + "", None)
        v769 = None
        v778: None
        closure9(v642, ("" + " }") + "", None)
        v778 = None
        v820: str = trim_end(trim_start(((((((((("" + v426) + " ") + v627) + " #") + str(v638)) + " ") + "move_file_async") + " / ") + v642.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v820)
        pattern_input[1].l0(v820)



def method20(v0_1: str, v1_1: str, v2_1: int64) -> Async[int64]:
    return None


def closure26(v0_1: str, v1_1: str) -> Async[int64]:
    return None


def closure25(unit_var: None, v0_1: str) -> Callable[[str], Async[int64]]:
    def _arrow294(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure26(v0_1, v)

    return _arrow294


def closure29(unit_var: None, v0_1: int64) -> US9:
    return US9(0, v0_1)


def closure30(unit_var: None, v0_1: Exception) -> US9:
    return US9(1, v0_1)


def closure31(unit_var: None, unit_var_1: None) -> None:
    def v1_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure0(None, None)

    v2_1: None
    v1_1(None)
    v2_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v35_1: None
    v1_1(None)
    v35_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v67: US0 = pattern_input_1[4].l0
    class ObjectExpr295:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v67, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr295()))):
        v75: None
        closure6(pattern_input[0], None)
        v75 = None
        v79: None
        v1_1(None)
        v79 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v358: FSharpRef[US3 | None] = FSharpRef(None)
        v363: None
        def v360(v: US3 | None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> FSharpRef[US3 | None]:
            return closure7(_v358, v)

        closure8(pattern_input_2[5], v360, None)
        v363 = None
        v378: US3 = default_arg(_v358.contents, US3(1))
        def _arrow296(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> Any:
            v392: Any = create(op_subtraction(ticks_1(now()), v378.fields[0]))
            return create_1(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))

        v423: str = to_string(_arrow296() if (v378.tag == 0) else now(), method10())
        v624: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method11()
        v635: int64 = pattern_input_2[0].l0
        v637: Mut3 = Mut3(method13())
        v644: None
        closure9(v637, ("" + "{ ") + "", None)
        v644 = None
        v653: None
        closure9(v637, ("" + "timeout") + "", None)
        v653 = None
        v662: None
        closure9(v637, ("" + " = ") + "", None)
        v662 = None
        v670: None
        closure9(v637, ("" + str(1000)) + "", None)
        v670 = None
        v679: None
        closure9(v637, ("" + " }") + "", None)
        v679 = None
        v741: str = trim_end(trim_start(((((((((("" + v423) + " ") + v624) + " #") + str(v635)) + " ") + "async.run_with_timeout_async") + " / ") + v637.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v741)
        pattern_input[1].l0(v741)



def closure32(v0_1: Exception, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: None
    v2_1(None)
    v36 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v68: US0 = pattern_input_1[4].l0
    class ObjectExpr297:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (4 >= find(v68, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr297()))):
        v76: None
        closure6(pattern_input[0], None)
        v76 = None
        v80: None
        v2_1(None)
        v80 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v359: FSharpRef[US3 | None] = FSharpRef(None)
        v364: None
        def v361(v: US3 | None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v359, v)

        closure8(pattern_input_2[5], v361, None)
        v364 = None
        v379: US3 = default_arg(_v359.contents, US3(1))
        def _arrow298(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v393: Any = create(op_subtraction(ticks_1(now()), v379.fields[0]))
            return create_1(1, 1, 1, hours(v393), minutes(v393), seconds(v393), milliseconds(v393))

        v424: str = to_string(_arrow298() if (v379.tag == 0) else now(), method10())
        v625: str = ("\u001b[91m" + pad_left("Critical".lower(), 7, " ")) + method11()
        v636: int64 = pattern_input_2[0].l0
        v650: str = to_text(interpolate("%A%P()", [v0_1]))
        v660: Mut3 = Mut3(method13())
        v667: None
        closure9(v660, ("" + "{ ") + "", None)
        v667 = None
        v676: None
        closure9(v660, ("" + "timeout") + "", None)
        v676 = None
        v685: None
        closure9(v660, ("" + " = ") + "", None)
        v685 = None
        v693: None
        closure9(v660, ("" + str(1000)) + "", None)
        v693 = None
        v702: None
        closure9(v660, ("" + "; ") + "", None)
        v702 = None
        v711: None
        closure9(v660, ("" + "ex") + "", None)
        v711 = None
        v719: None
        closure9(v660, ("" + " = ") + "", None)
        v719 = None
        v727: None
        closure9(v660, ("" + v650) + "", None)
        v727 = None
        v736: None
        closure9(v660, ("" + " }") + "", None)
        v736 = None
        v798: str = trim_end(trim_start(((((((((("" + v424) + " ") + v625) + " #") + str(v636)) + " ") + "async.run_with_timeout_async**") + " / ") + v660.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v798)
        pattern_input[1].l0(v798)



def closure33(v0_1: int64, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr299:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr299()))):
        v77: None
        closure6(pattern_input[0], None)
        v77 = None
        v81: None
        v3(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v360, v)

        closure8(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow300(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow300() if (v380.tag == 0) else now(), method10())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method11()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method13())
        v646: None
        closure9(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure9(v639, ("" + "retry") + "", None)
        v655 = None
        v664: None
        closure9(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure9(v639, ("" + str(v0_1)) + "", None)
        v672 = None
        v681: None
        closure9(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure9(v639, ("" + "ex") + "", None)
        v690 = None
        v698: None
        closure9(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure9(v639, ("" + v1_1) + "", None)
        v706 = None
        v715: None
        closure9(v639, ("" + " }") + "", None)
        v715 = None
        v777: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "read_all_text_retry_async") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v777)
        pattern_input[1].l0(v777)



def method21(v0_1: str, v1_1: int64) -> Async[str | None]:
    return None


def closure28(unit_var: None, v0_1: str) -> Async[str | None]:
    return None


def closure35(v0_1: FSharpRef[US11 | None], v1_1: US11 | None=None) -> FSharpRef[US11 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure36(v0_1: chrono_date_time_1[chrono_utc] | None, v1_1: Callable[[US11 | None], FSharpRef[US11 | None]], unit_var: None) -> None:
    def _arrow301(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US11 | None:
        x: chrono_date_time_1[chrono_utc] = v0_1
        def x_1(__unit: None=None) -> US11:
            return US11(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow301()))


def method24(__unit: None=None) -> str:
    return "hh:mm"


def method25(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method26(__unit: None=None) -> str:
    return "hhmm"


def method23(v0_1: str, v1_1: Any) -> str:
    v438: str = to_string(v1_1, method25())
    v507: Any
    raise Exception(("date_time.get_utc_offset / target: " + str(US5(4, US4(0)))) + "")
    v518: uint8 = uint8(1) if (hours(v507) > 0) else uint8(0)
    v519: str = method26()
    v530: str = ((("" + str(v518)) + "") + to_string_1(v507, "c", {})) + ""
    v532: str = str(v0_1)
    return parse(((((("" + v438) + "") + v530) + "") + v532[len(v438) + len(v530):len(v532)]) + "")


def method28(__unit: None=None) -> str:
    raise Exception(("file_system.get_temp_path / target: " + str(US5(4, US4(0)))) + "")


def method29(__unit: None=None) -> str:
    return "!create_temp_path_"


def method32(v0_1: str) -> str:
    return v0_1


def method31(v0_1: str, v1_1: str) -> tuple[str, str]:
    return (v1_1, method32(v0_1))


def method30(v0_1: str, v1_1: str) -> str:
    raise Exception(((((("file_system.(</>) / target: " + str(US5(4, US4(0)))) + " / a: ") + v0_1) + " / b: ") + v1_1) + "")


def method34(__unit: None=None) -> str:
    return "CARGO_PKG_NAME"


def method33(__unit: None=None) -> str:
    raise Exception(("env.get_entry_assembly_name / target: " + str(US5(4, US4(0)))) + "")


def method27(v0_1: str) -> str:
    return method30(method30(method30(method28(), method29()), method33()), str(v0_1))


def method22(__unit: None=None) -> str:
    v31_1: Any = now()
    return method27(method23(new_guid(), v31_1))


def closure34(unit_var: None, unit_var_1: None) -> str:
    return method22()


def method36(v0_1: str) -> str:
    return v0_1


def closure38(unit_var: None, v0_1: std_io_error) -> std_string_string:
    return None


def method37(__unit: None=None) -> Callable[[std_io_error], std_string_string]:
    def _arrow302(v: std_io_error) -> std_string_string:
        return closure38(None, v)

    return _arrow302


def closure39(unit_var: None, unit_var_1: None) -> US12:
    return US12(0)


def closure40(unit_var: None, v0_1: std_string_string) -> US12:
    return US12(1, v0_1)


def closure41(v0_1: str, v1_1: std_string_string, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr303:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (4 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr303()))):
        v77: None
        closure6(pattern_input[0], None)
        v77 = None
        v81: None
        v3(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v360, v)

        closure8(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow304(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow304() if (v380.tag == 0) else now(), method10())
        v626: str = ("\u001b[91m" + pad_left("Critical".lower(), 7, " ")) + method11()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method13())
        v646: None
        closure9(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure9(v639, ("" + "dir") + "", None)
        v655 = None
        v664: None
        closure9(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure9(v639, ("" + v0_1) + "", None)
        v672 = None
        v681: None
        closure9(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure9(v639, ("" + "error") + "", None)
        v690 = None
        v698: None
        closure9(v639, ("" + " = ") + "", None)
        v698 = None
        v733: None
        closure9(v639, ("" + to_text(interpolate("%A%P()", [v1_1]))) + "", None)
        v733 = None
        v742: None
        closure9(v639, ("" + " }") + "", None)
        v742 = None
        v784: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "file_system.create_dir") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v784)
        pattern_input[1].l0(v784)



def closure42(v0_1: str, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: None
    v2_1(None)
    v36 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v68: US0 = pattern_input_1[4].l0
    class ObjectExpr305:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v68, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr305()))):
        v76: None
        closure6(pattern_input[0], None)
        v76 = None
        v80: None
        v2_1(None)
        v80 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v359: FSharpRef[US3 | None] = FSharpRef(None)
        v364: None
        def v361(v: US3 | None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v359, v)

        closure8(pattern_input_2[5], v361, None)
        v364 = None
        v379: US3 = default_arg(_v359.contents, US3(1))
        def _arrow306(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v393: Any = create(op_subtraction(ticks_1(now()), v379.fields[0]))
            return create_1(1, 1, 1, hours(v393), minutes(v393), seconds(v393), milliseconds(v393))

        v424: str = to_string(_arrow306() if (v379.tag == 0) else now(), method10())
        v625: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method11()
        v636: int64 = pattern_input_2[0].l0
        v638: Mut3 = Mut3(method13())
        v645: None
        closure9(v638, ("" + "{ ") + "", None)
        v645 = None
        v654: None
        closure9(v638, ("" + "dir") + "", None)
        v654 = None
        v663: None
        closure9(v638, ("" + " = ") + "", None)
        v663 = None
        v671: None
        closure9(v638, ("" + v0_1) + "", None)
        v671 = None
        v680: None
        closure9(v638, ("" + " }") + "", None)
        v680 = None
        v722: str = trim_end(trim_start(((((((((("" + v424) + " ") + v625) + " #") + str(v636)) + " ") + "file_system.create_dir") + " / ") + v638.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v722)
        pattern_input[1].l0(v722)



def closure43(v0_1: str, unit_var: None) -> None:
    method6(True, v0_1)


def method38(v0_1: str) -> Callable[[], None]:
    def _arrow307(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure43(v0_1, None)

    return _arrow307


def method39(v0_1: str) -> Callable[[], None]:
    def _arrow308(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure43(v0_1, None)

    return _arrow308


def closure44(v0_1: str, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v37: None
    v3(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr309:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr309()))):
        v77: None
        closure6(pattern_input[0], None)
        v77 = None
        v81: None
        v3(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v360, v)

        closure8(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow310(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow310() if (v380.tag == 0) else now(), method10())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method11()
        v637: int64 = pattern_input_2[0].l0
        v639: Mut3 = Mut3(method13())
        v646: None
        closure9(v639, ("" + "{ ") + "", None)
        v646 = None
        v655: None
        closure9(v639, ("" + "dir") + "", None)
        v655 = None
        v664: None
        closure9(v639, ("" + " = ") + "", None)
        v664 = None
        v672: None
        closure9(v639, ("" + v0_1) + "", None)
        v672 = None
        v681: None
        closure9(v639, ("" + "; ") + "", None)
        v681 = None
        v690: None
        closure9(v639, ("" + "result") + "", None)
        v690 = None
        v698: None
        closure9(v639, ("" + " = ") + "", None)
        v698 = None
        v706: None
        closure9(v639, ("" + v1_1) + "", None)
        v706 = None
        v715: None
        closure9(v639, ("" + " }") + "", None)
        v715 = None
        v757: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "file_system.create_dir") + " / ") + v639.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v757)
        pattern_input[1].l0(v757)



def closure45(v0_1: str, unit_var: None) -> None:
    pass


def method40(v0_1: str) -> Callable[[], None]:
    def _arrow311(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure45(v0_1, None)

    return _arrow311


def method41(v0_1: str) -> Callable[[], None]:
    def _arrow312(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure45(v0_1, None)

    return _arrow312


def method35(v0_1: str) -> IDisposable:
    v2647: bool = None
    if v2647 == False:
        v2681: None
        closure44(v0_1, to_text(interpolate("%A%P()", [{
            "CreationTime": None,
            "Exists": v2647
        }])), None)
        v2681 = None

    v3518: Callable[[], None] = method41(v0_1)
    class ObjectExpr313(IDisposable):
        def Dispose(self, __unit: None=None, v0_1: Any=v0_1) -> None:
            v3518(None)

    return ObjectExpr313()


def closure37(unit_var: None, unit_var_1: None) -> tuple[str, IDisposable]:
    v0_1: str = method22()
    return (v0_1, method35(v0_1))


def method42(v0_1: str) -> str:
    v56: str = pad_left(v0_1, 32, "0")
    return parse(((((((((("" + v56[0:7 + 1]) + "-") + v56[8:11 + 1]) + "-") + v56[12:15 + 1]) + "-") + v56[16:19 + 1]) + "-") + v56[20:31 + 1]) + "")


def closure46(unit_var: None, v0_1: str) -> tuple[str, IDisposable]:
    v2_1: str = method27(method42(v0_1))
    return (v2_1, method35(v2_1))


def closure47(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def method44(v0_1: str) -> str:
    return v0_1


def method43(v0_1: str) -> str:
    if v0_1 == "":
        return ""

    else: 
        v30_1: str = None
        def _arrow314(__unit: None=None, v0_1: Any=v0_1) -> str:
            _arg: str = v30_1[0]
            return _arg.lower()

        return replace(((("" + _arrow314()) + "") + v30_1[1:len(v30_1)]) + "", "\\", "/")



def closure48(unit_var: None, v0_1: str) -> str:
    return method43(v0_1)


def closure49(unit_var: None, v0_1: str) -> str:
    return ("file:///" + trim_start(v0_1, *to_array(singleton("/")))) + ""


def method47(v0_1: str) -> str | None:
    v85: US1 = None
    if v85.tag == 0:
        return v85.fields[0]

    else: 
        return None



def closure51(unit_var: None, v0_1: str) -> str | None:
    return method47(v0_1)


def method46(__unit: None=None) -> Callable[[str], str | None]:
    def _arrow315(v: str) -> str | None:
        return closure51(None, v)

    return _arrow315


def method48(v0_1_mut: str, v1_1_mut: str, v2_1_mut: str) -> US13:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if method8(method30(v2_1, v0_1)):
            return US13(0, v2_1)

        else: 
            v7: str | None = method46()(v2_1)
            _v8: FSharpRef[US1 | None] = FSharpRef(None)
            v13: None
            def v10(v: US1 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> FSharpRef[US1 | None]:
                return closure1(_v8, v)

            closure2(v7, v10, None)
            v13 = None
            v28_1: US1 = default_arg(_v8.contents, US1(1))
            if v28_1.tag == 0:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v28_1.fields[0]
                continue

            else: 
                return US13(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v2_1) + "\')")


        break


def method45(v0_1: str, v1_1: str) -> US13:
    if method8(method30(v1_1, v0_1)):
        return US13(0, v1_1)

    else: 
        v6: str | None = method46()(v1_1)
        _v7: FSharpRef[US1 | None] = FSharpRef(None)
        v12: None
        def v9(v: US1 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> FSharpRef[US1 | None]:
            return closure1(_v7, v)

        closure2(v6, v9, None)
        v12 = None
        v27_1: US1 = default_arg(_v7.contents, US1(1))
        if v27_1.tag == 0:
            return method48(v0_1, v1_1, v27_1.fields[0])

        else: 
            return US13(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v1_1) + "\')")




def closure52(v0_1: str, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v36: None
    v2_1(None)
    v36 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    v68: US0 = pattern_input_1[4].l0
    class ObjectExpr316:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v68, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr316()))):
        v76: None
        closure6(pattern_input[0], None)
        v76 = None
        v80: None
        v2_1(None)
        v80 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
        _v359: FSharpRef[US3 | None] = FSharpRef(None)
        v364: None
        def v361(v: US3 | None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v359, v)

        closure8(pattern_input_2[5], v361, None)
        v364 = None
        v379: US3 = default_arg(_v359.contents, US3(1))
        def _arrow317(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v393: Any = create(op_subtraction(ticks_1(now()), v379.fields[0]))
            return create_1(1, 1, 1, hours(v393), minutes(v393), seconds(v393), milliseconds(v393))

        v424: str = to_string(_arrow317() if (v379.tag == 0) else now(), method10())
        v625: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method11()
        v636: int64 = pattern_input_2[0].l0
        v638: Mut3 = Mut3(method13())
        v645: None
        closure9(v638, ("" + "{ ") + "", None)
        v645 = None
        v654: None
        closure9(v638, ("" + "error") + "", None)
        v654 = None
        v663: None
        closure9(v638, ("" + " = ") + "", None)
        v663 = None
        v671: None
        closure9(v638, ("" + v0_1) + "", None)
        v671 = None
        v680: None
        closure9(v638, ("" + " }") + "", None)
        v680 = None
        v722: str = trim_end(trim_start(((((((((("" + v424) + " ") + v625) + " #") + str(v636)) + " ") + "file_system.get_workspace_root") + " / ") + v638.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v722)
        pattern_input[1].l0(v722)



def method49(__unit: None=None) -> str:
    return None


def closure50(unit_var: None, unit_var_1: None) -> str:
    v4: US13 = method45(method30("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral")
    v806: US1
    if v4.tag == 0:
        v806 = US1(0, v4.fields[0])

    else: 
        v10: None
        closure52(v4.fields[0], None)
        v10 = None
        v806 = US1(1)

    v1615: US1
    if v806.tag == 0:
        v1615 = US1(0, v806.fields[0])

    else: 
        v809: str = method49()
        v811: US13 = method45(method30("polyglot", ".devcontainer"), v809)
        if v811.tag == 0:
            v1615 = US1(0, v811.fields[0])

        else: 
            v817: None
            closure52(v811.fields[0], None)
            v817 = None
            v1615 = US1(1)


    def _arrow318(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
        raise Exception("Option does not have a value.")

    return method30(v1615.fields[0] if (v1615.tag == 0) else _arrow318(), "polyglot")


def method50(v0_1: str) -> None:
    pass


def closure54(unit_var: None, v0_1: str) -> None:
    method50(v0_1)


def closure53(unit_var: None, v0_1: bool) -> None:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_3(TraceState_trace_state())
    def _arrow319(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure54(None, v)

    def _arrow320(v_1: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure3(None, v_1)

    v37: Callable[[str], None] = _arrow319 if v0_1 else _arrow320
    pattern_input[1].l0 = v37


def method52(v0_1: str) -> str:
    return None


def method51(v0_1: str, v1_1: str) -> None:
    if method8(v0_1) == False:
        v4: IDisposable = method35(v0_1)

    v5: str = method52(v1_1)
    if method8(v5) == False:
        v8: IDisposable = method35(v5)

    def _arrow321(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> bool:
        v18_1: FSharpResult_2[std_path_path_buf, std_io_error] = FSharpResult_2()
        return True

    if _arrow321() if method8(v1_1) else False:
        method6(True, v1_1)

    if method8(v1_1) == False:
        pass



def closure56(v0_1: str, v1_1: str) -> None:
    method51(v0_1, v1_1)


def closure55(unit_var: None, v0_1: str) -> Callable[[str], None]:
    def _arrow322(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure56(v0_1, v)

    return _arrow322


def closure58(v0_1: str, v1_1: str) -> str:
    return method30(v0_1, v1_1)


def closure57(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow323(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure58(v0_1, v)

    return _arrow323


v0: None = None

def _arrow324(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow324

def _expr325():
    v1(None)
    return v0


v2: None = _expr325()

def _arrow326(v: str) -> Async[int64]:
    return closure4(None, v)


v16: Callable[[str], Async[int64]] = _arrow326

def delete_directory_async(x: str) -> Async[int64]:
    return v16(x)


def _arrow327(v: US6) -> Callable[[str], Async[int64]]:
    return closure12(None, v)


v17: Callable[[US6, str], Async[int64]] = _arrow327

def wait_for_file_access(x: US6) -> Callable[[str], Async[int64]]:
    return v17(x)


def _arrow328(v: str) -> Async[int64]:
    return closure15(None, v)


v18: Callable[[str], Async[int64]] = _arrow328

def wait_for_file_access_read(x: str) -> Async[int64]:
    return v18(x)


def _arrow329(v: str) -> Async[str]:
    return closure16(None, v)


v19: Callable[[str], Async[str]] = _arrow329

def read_all_text_async(x: str) -> Async[str]:
    return v19(x)


def _arrow330(v: str) -> Callable[[str], bool]:
    return closure17(None, v)


v20: Callable[[str, str], bool] = _arrow330

def file_exists_content(x: str) -> Callable[[str], bool]:
    return v20(x)


def _arrow331(v: str) -> Callable[[str], Async[None]]:
    return closure19(None, v)


v21: Callable[[str, str], Async[None]] = _arrow331

def write_all_text_async(x: str) -> Callable[[str], Async[None]]:
    return v21(x)


def _arrow332(v: str) -> Callable[[str], Async[None]]:
    return closure21(None, v)


v22: Callable[[str, str], Async[None]] = _arrow332

def write_all_text_exists(x: str) -> Callable[[str], Async[None]]:
    return v22(x)


def _arrow333(v: str) -> Async[int64]:
    return closure23(None, v)


v23: Callable[[str], Async[int64]] = _arrow333

def delete_file_async(x: str) -> Async[int64]:
    return v23(x)


def _arrow334(v: str) -> Callable[[str], Async[int64]]:
    return closure25(None, v)


v24: Callable[[str, str], Async[int64]] = _arrow334

def move_file_async(x: str) -> Callable[[str], Async[int64]]:
    return v24(x)


def _arrow335(v: str) -> Async[str | None]:
    return closure28(None, v)


v25: Callable[[str], Async[str | None]] = _arrow335

def read_all_text_retry_async(x: str) -> Async[str | None]:
    return v25(x)


def _arrow336(__unit: None=None) -> str:
    return closure34(None, None)


v26: Callable[[], str] = _arrow336

def create_temp_path(__unit: None=None) -> str:
    return v26(None)


def _arrow337(__unit: None=None) -> tuple[str, IDisposable]:
    return closure37(None, None)


v27: Callable[[], tuple[str, IDisposable]] = _arrow337

def create_temp_dir(__unit: None=None) -> tuple[str, IDisposable]:
    return v27(None)


def _arrow338(v: str) -> tuple[str, IDisposable]:
    return closure46(None, v)


v28: Callable[[str], tuple[str, IDisposable]] = _arrow338

def create_temp_dir_0027(x: str) -> tuple[str, IDisposable]:
    return v28(x)


def _arrow339(__unit: None=None) -> str:
    return closure47(None, None)


v29: Callable[[], str] = _arrow339

def get_source_directory(__unit: None=None) -> str:
    return v29(None)


def _arrow340(v: str) -> str:
    return closure48(None, v)


v30: Callable[[str], str] = _arrow340

def normalize_path(x: str) -> str:
    return v30(x)


def _arrow341(v: str) -> str:
    return closure49(None, v)


v31: Callable[[str], str] = _arrow341

def new_file_uri(x: str) -> str:
    return v31(x)


def _arrow342(__unit: None=None) -> str:
    return closure50(None, None)


v32: Callable[[], str] = _arrow342

def get_workspace_root(__unit: None=None) -> str:
    return v32(None)


def _arrow343(v: bool) -> None:
    closure53(None, v)


v33: Callable[[bool], None] = _arrow343

def init_trace_file(x: bool) -> None:
    v33(x)


def _arrow344(v: str) -> Callable[[str], None]:
    return closure55(None, v)


v34: Callable[[str, str], None] = _arrow344

def link_directory(x: str) -> Callable[[str], None]:
    return v34(x)


def _arrow345(v: str) -> Callable[[str], str]:
    return closure57(None, v)


v35: Callable[[str, str], str] = _arrow345

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v35(x)


