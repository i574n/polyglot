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
from fable_modules.fable_library.long import (op_subtraction, op_addition)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_4, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.result import FSharpResult_2
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, to_text, interpolate, replace)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds, to_string as to_string_1)
from fable_modules.fable_library.types import (int64, Array, Union, Record, uint8, to_string as to_string_2)
from fable_modules.fable_library.util import (create_atom, IDisposable, to_enumerable, compare)

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


def _expr250() -> TypeInfo:
    return class_type("File_system.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr250

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


class IPathDirname(Protocol):
    @abstractmethod
    def dirname(self, path: str) -> str:
        ...


def _expr251() -> TypeInfo:
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


US0_reflection = _expr251

def _expr252() -> TypeInfo:
    return record_type("File_system.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr252

def _expr253() -> TypeInfo:
    return record_type("File_system.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr253

def _expr254() -> TypeInfo:
    return record_type("File_system.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr254

def _expr255() -> TypeInfo:
    return record_type("File_system.Mut3", [], Mut3, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: str

Mut3_reflection = _expr255

def _expr256() -> TypeInfo:
    return record_type("File_system.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr256

def _expr257() -> TypeInfo:
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


US1_reflection = _expr257

def _expr258() -> TypeInfo:
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


US2_reflection = _expr258

def _expr259() -> TypeInfo:
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


US3_reflection = _expr259

def _expr260() -> TypeInfo:
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


US4_reflection = _expr260

def _expr261() -> TypeInfo:
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


US5_reflection = _expr261

def _expr262() -> TypeInfo:
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


US7_reflection = _expr262

def _expr263() -> TypeInfo:
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


US8_reflection = _expr263

def _expr264() -> TypeInfo:
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


US6_reflection = _expr264

def _expr265() -> TypeInfo:
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


US9_reflection = _expr265

def _expr266() -> TypeInfo:
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


US10_reflection = _expr266

def _expr267() -> TypeInfo:
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


US11_reflection = _expr267

def _expr268() -> TypeInfo:
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


US12_reflection = _expr268

def _expr269() -> TypeInfo:
    return union_type("File_system.US13", [], US13, lambda: [[("f0_0", class_type("File_system.std_path_PathBuf"))], [("f1_0", string_type)]])


class US13(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US13_0", "US13_1"]


US13_reflection = _expr269

def _expr270() -> TypeInfo:
    return union_type("File_system.US14", [], US14, lambda: [[("f0_0", class_type("File_system.std_path_PathBuf"))], []])


class US14(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US14_0", "US14_1"]


US14_reflection = _expr270

def _expr271() -> TypeInfo:
    return union_type("File_system.US15", [], US15, lambda: [[("f0_0", string_type)], [("f1_0", string_type)]])


class US15(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US15_0", "US15_1"]


US15_reflection = _expr271

def method1(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method3(__unit: None=None) -> str:
    return ""


def closure1(unit_var: None, v0_1: str) -> US1:
    return US1(0, v0_1)


def method4(__unit: None=None) -> Callable[[str], US1]:
    def _arrow272(v: str) -> US1:
        return closure1(None, v)

    return _arrow272


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
        v61 = value_4(_v56)

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
    def _arrow273(__unit: None=None, v0_1: Any=v0_1) -> US2:
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




    _v1: tuple[US2, US3] = (US2(0, v235.fields[0]) if (v235.tag == 0) else _arrow273(), US3(0, ticks_1(now())) if (method2(method5()) == "True") else US3(1))
    v352: US3 = _v1[1]
    v351: US2 = _v1[0]
    def v417(v: str, v0_1: Any=v0_1) -> None:
        closure2(None, v)

    return (Mut0(int64(1)), Mut1(v417), Mut2(True), Mut3(""), Mut4(v351.fields[0] if (v351.tag == 0) else v0_1), v352.fields[0] if (v352.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = method0(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def method8(v0_1: str) -> str:
    return v0_1


def method9(v0_1: str) -> bool:
    return None


def method7(v0_1: bool, v1_1: str) -> None:
    pass


def closure5(unit_var: None, v0_1: int64) -> US3:
    return US3(0, v0_1)


def method11(__unit: None=None) -> Callable[[int64], US3]:
    def _arrow274(v: int64) -> US3:
        return closure5(None, v)

    return _arrow274


def method12(__unit: None=None) -> str:
    return "hh:mm:ss"


def method13(__unit: None=None) -> str:
    return "HH:mm:ss"


def method10(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None=None) -> str:
    v238: US3 = default_arg(map(method11(), v5), US3(1))
    def _arrow275(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4, v5: Any=v5) -> Any:
        v252: Any = create(op_subtraction(ticks_1(now()), v238.fields[0]))
        return create_1(1, 1, 1, hours(v252), minutes(v252), seconds(v252), milliseconds(v252))

    return to_string(_arrow275() if (v238.tag == 0) else now(), method13())


def method15(__unit: None=None) -> str:
    return "\u001b[0m"


def method14(__unit: None=None) -> str:
    return ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method15()


def method16(v0_1: str) -> str:
    raise Exception(((("file_system.get_file_name / target: " + str(US5(4, US4(0)))) + " / path: ") + v0_1) + "")


def method18(__unit: None=None) -> str:
    return ""


def closure6(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def method17(v0_1: str, v1_1: str) -> str:
    v3: Mut3 = Mut3(method18())
    v10: None
    closure6(v3, ("" + "{ ") + "", None)
    v10 = None
    v19_1: None
    closure6(v3, ("" + "ex") + "", None)
    v19_1 = None
    v28_1: None
    closure6(v3, ("" + " = ") + "", None)
    v28_1 = None
    v36: None
    closure6(v3, ("" + v0_1) + "", None)
    v36 = None
    v45: None
    closure6(v3, ("" + "; ") + "", None)
    v45 = None
    v54: None
    closure6(v3, ("" + "path") + "", None)
    v54 = None
    v62: None
    closure6(v3, ("" + " = ") + "", None)
    v62 = None
    v70: None
    closure6(v3, ("" + v1_1) + "", None)
    v70 = None
    v79: None
    closure6(v3, ("" + " }") + "", None)
    v79 = None
    return v3.l0


def method19(v0_1: str, v1_1: str, v2_1: int64, v3: str) -> str:
    return trim_end(trim_start(((((((((("" + v0_1) + " ") + v1_1) + " #") + str(v2_1)) + " ") + "file_system.delete_directory_async") + " / ") + v3) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def closure7(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure9(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure8(unit_var: None, v0_1: str) -> None:
    v3: None
    closure9(v0_1, None)
    v3 = None


def method20(v0_1: str, v1_1: Mut0, v2_1: Mut1, v3: Mut2, v4: Mut3, v5: Mut4, v6: int64 | None=None) -> None:
    v9: None
    closure7(v1_1, None)
    v9 = None
    closure8(None, v0_1)
    v2_1.l0(v0_1)


def closure4(v0_1: str, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr276:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr276()))):
        v43: None
        v3(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v80: str = method19(method10(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method14(), v57.l0, method17(v1_1, method16(v0_1)))
        v82: None
        v3(None)
        v82 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        method20(v80, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method6(v0_1: str, v1_1: int64) -> Async[int64]:
    return None


def closure3(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def method22(v0_1: str, v1_1: int64, v2_1: str) -> str:
    v4: Mut3 = Mut3(method18())
    v11: None
    closure6(v4, ("" + "{ ") + "", None)
    v11 = None
    v20_1: None
    closure6(v4, ("" + "path") + "", None)
    v20_1 = None
    v29_1: None
    closure6(v4, ("" + " = ") + "", None)
    v29_1 = None
    v37: None
    closure6(v4, ("" + v0_1) + "", None)
    v37 = None
    v46: None
    closure6(v4, ("" + "; ") + "", None)
    v46 = None
    v55: None
    closure6(v4, ("" + "retry") + "", None)
    v55 = None
    v63: None
    closure6(v4, ("" + " = ") + "", None)
    v63 = None
    v71: None
    closure6(v4, ("" + str(v1_1)) + "", None)
    v71 = None
    v79: None
    closure6(v4, ("" + "; ") + "", None)
    v79 = None
    v88: None
    closure6(v4, ("" + "ex") + "", None)
    v88 = None
    v96: None
    closure6(v4, ("" + " = ") + "", None)
    v96 = None
    v104: None
    closure6(v4, ("" + v2_1) + "", None)
    v104 = None
    v113: None
    closure6(v4, ("" + " }") + "", None)
    v113 = None
    return v4.l0


def method23(v0_1: str, v1_1: str, v2_1: int64, v3: str) -> str:
    return trim_end(trim_start(((((((((("" + v0_1) + " ") + v1_1) + " #") + str(v2_1)) + " ") + "file_system.wait_for_file_access") + " / ") + v3) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def closure12(v0_1: str, v1_1: int64, v2_1: str, unit_var: None) -> None:
    def v4(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v5: None
    v4(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr277:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr277()))):
        v44: None
        v4(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v81: str = method23(method10(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method14(), v58.l0, method22(method16(v0_1), v1_1, v2_1))
        v83: None
        v4(None)
        v83 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        method20(v81, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method21(v0_1: str, v1_1: US8, v2_1: US7, v3: int64) -> Async[int64]:
    return None


def closure11(v0_1: US6, v1_1: str) -> Async[int64]:
    return None


def closure10(unit_var: None, v0_1: US6) -> Callable[[str], Async[int64]]:
    def _arrow278(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure11(v0_1, v)

    return _arrow278


def method24(v0_1: str, v1_1: int64) -> Async[int64]:
    return None


def closure13(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def closure14(unit_var: None, v0_1: str) -> Async[str]:
    return None


def method26(v0_1: str) -> bool:
    return None


def method27(v0_1: Vec_1[uint8]) -> Vec_1[uint8]:
    return v0_1


def method25(v0_1: str, v1_1: str) -> bool:
    return None


def closure16(v0_1: str, v1_1: str) -> bool:
    return method25(v0_1, v1_1)


def closure15(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow279(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure16(v0_1, v)

    return _arrow279


def closure18(v0_1: str, v1_1: str) -> Async[None]:
    return None


def closure17(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow280(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure18(v0_1, v)

    return _arrow280


def closure20(v0_1: str, v1_1: str) -> Async[None]:
    return None


def closure19(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow281(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure20(v0_1, v)

    return _arrow281


def method29(__unit: None=None) -> str:
    return ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method15()


def method30(v0_1: str, v1_1: str) -> str:
    v3: Mut3 = Mut3(method18())
    v10: None
    closure6(v3, ("" + "{ ") + "", None)
    v10 = None
    v19_1: None
    closure6(v3, ("" + "path") + "", None)
    v19_1 = None
    v28_1: None
    closure6(v3, ("" + " = ") + "", None)
    v28_1 = None
    v36: None
    closure6(v3, ("" + v0_1) + "", None)
    v36 = None
    v45: None
    closure6(v3, ("" + "; ") + "", None)
    v45 = None
    v54: None
    closure6(v3, ("" + "ex") + "", None)
    v54 = None
    v62: None
    closure6(v3, ("" + " = ") + "", None)
    v62 = None
    v70: None
    closure6(v3, ("" + v1_1) + "", None)
    v70 = None
    v79: None
    closure6(v3, ("" + " }") + "", None)
    v79 = None
    return v3.l0


def method31(v0_1: str, v1_1: str, v2_1: int64, v3: str) -> str:
    return trim_end(trim_start(((((((((("" + v0_1) + " ") + v1_1) + " #") + str(v2_1)) + " ") + "delete_file_async") + " / ") + v3) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def closure22(v0_1: str, v1_1: Exception, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr282:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (3 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr282()))):
        v43: None
        v3(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v102: str = method31(method10(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method29(), v57.l0, method30(method16(v0_1), to_text(interpolate("%A%P()", [v1_1]))))
        v104: None
        v3(None)
        v104 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        method20(v102, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method28(v0_1: str, v1_1: int64) -> Async[int64]:
    return None


def closure21(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def method33(v0_1: str, v1_1: str, v2_1: Exception) -> str:
    v4: Mut3 = Mut3(method18())
    v11: None
    closure6(v4, ("" + "{ ") + "", None)
    v11 = None
    v20_1: None
    closure6(v4, ("" + "old_path") + "", None)
    v20_1 = None
    v29_1: None
    closure6(v4, ("" + " = ") + "", None)
    v29_1 = None
    v37: None
    closure6(v4, ("" + v0_1) + "", None)
    v37 = None
    v46: None
    closure6(v4, ("" + "; ") + "", None)
    v46 = None
    v55: None
    closure6(v4, ("" + "new_path") + "", None)
    v55 = None
    v63: None
    closure6(v4, ("" + " = ") + "", None)
    v63 = None
    v71: None
    closure6(v4, ("" + v1_1) + "", None)
    v71 = None
    v79: None
    closure6(v4, ("" + "; ") + "", None)
    v79 = None
    v88: None
    closure6(v4, ("" + "ex") + "", None)
    v88 = None
    v96: None
    closure6(v4, ("" + " = ") + "", None)
    v96 = None
    v131: None
    closure6(v4, ("" + to_text(interpolate("%A%P()", [v2_1]))) + "", None)
    v131 = None
    v140: None
    closure6(v4, ("" + " }") + "", None)
    v140 = None
    return v4.l0


def method34(v0_1: str, v1_1: str, v2_1: int64, v3: str) -> str:
    return trim_end(trim_start(((((((((("" + v0_1) + " ") + v1_1) + " #") + str(v2_1)) + " ") + "move_file_async") + " / ") + v3) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def closure25(v0_1: str, v1_1: str, v2_1: Exception, unit_var: None) -> None:
    def v4(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v5: None
    v4(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
    v37: US0 = pattern_input[4].l0
    class ObjectExpr283:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (3 >= find(v37, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr283()))):
        v44: None
        v4(None)
        v44 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        v58: Mut0 = pattern_input_1[0]
        v82: str = method34(method10(v58, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method29(), v58.l0, method33(method16(v1_1), method16(v0_1), v2_1))
        v84: None
        v4(None)
        v84 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        method20(v82, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method32(v0_1: str, v1_1: str, v2_1: int64) -> Async[int64]:
    return None


def closure24(v0_1: str, v1_1: str) -> Async[int64]:
    return None


def closure23(unit_var: None, v0_1: str) -> Callable[[str], Async[int64]]:
    def _arrow284(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure24(v0_1, v)

    return _arrow284


def closure27(unit_var: None, v0_1: int64) -> US9:
    return US9(0, v0_1)


def closure28(unit_var: None, v0_1: Exception) -> US9:
    return US9(1, v0_1)


def method36(__unit: None=None) -> str:
    return ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method15()


def method37(v0_1: int) -> str:
    v2_1: Mut3 = Mut3(method18())
    v9: None
    closure6(v2_1, ("" + "{ ") + "", None)
    v9 = None
    v18_1: None
    closure6(v2_1, ("" + "timeout") + "", None)
    v18_1 = None
    v27_1: None
    closure6(v2_1, ("" + " = ") + "", None)
    v27_1 = None
    v35_1: None
    closure6(v2_1, ("" + str(v0_1)) + "", None)
    v35_1 = None
    v44: None
    closure6(v2_1, ("" + " }") + "", None)
    v44 = None
    return v2_1.l0


def method38(v0_1: str, v1_1: str, v2_1: str, v3: int64, v4: str) -> str:
    return trim_end(trim_start(((((((((("" + v0_1) + " ") + v1_1) + " #") + str(v3)) + " ") + v2_1) + " / ") + v4) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def closure29(unit_var: None, unit_var_1: None) -> None:
    def v1_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure0(None, None)

    v2_1: None
    v1_1(None)
    v2_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
    v34_1: US0 = pattern_input[4].l0
    class ObjectExpr285:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (0 >= find(v34_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr285()))):
        v41: None
        v1_1(None)
        v41 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        v55: Mut0 = pattern_input_1[0]
        v82: str = method38(method10(v55, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method36(), "async.run_with_timeout_async", v55.l0, method37(1000))
        v84: None
        v1_1(None)
        v84 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        method20(v82, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method39(__unit: None=None) -> str:
    return ("\u001b[91m" + pad_left("Critical".lower(), 7, " ")) + method15()


def method40(v0_1: int, v1_1: str) -> str:
    v3: Mut3 = Mut3(method18())
    v10: None
    closure6(v3, ("" + "{ ") + "", None)
    v10 = None
    v19_1: None
    closure6(v3, ("" + "timeout") + "", None)
    v19_1 = None
    v28_1: None
    closure6(v3, ("" + " = ") + "", None)
    v28_1 = None
    v36: None
    closure6(v3, ("" + str(v0_1)) + "", None)
    v36 = None
    v45: None
    closure6(v3, ("" + "; ") + "", None)
    v45 = None
    v54: None
    closure6(v3, ("" + "ex") + "", None)
    v54 = None
    v62: None
    closure6(v3, ("" + " = ") + "", None)
    v62 = None
    v70: None
    closure6(v3, ("" + v1_1) + "", None)
    v70 = None
    v79: None
    closure6(v3, ("" + " }") + "", None)
    v79 = None
    return v3.l0


def closure30(v0_1: Exception, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
    v35_1: US0 = pattern_input[4].l0
    class ObjectExpr286:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (4 >= find(v35_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr286()))):
        v42: None
        v2_1(None)
        v42 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        v56: Mut0 = pattern_input_1[0]
        v105: str = method38(method10(v56, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method39(), "async.run_with_timeout_async**", v56.l0, method40(1000, to_text(interpolate("%A%P()", [v0_1]))))
        v107: None
        v2_1(None)
        v107 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        method20(v105, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method41(v0_1: int64, v1_1: str) -> str:
    v3: Mut3 = Mut3(method18())
    v10: None
    closure6(v3, ("" + "{ ") + "", None)
    v10 = None
    v19_1: None
    closure6(v3, ("" + "retry") + "", None)
    v19_1 = None
    v28_1: None
    closure6(v3, ("" + " = ") + "", None)
    v28_1 = None
    v36: None
    closure6(v3, ("" + str(v0_1)) + "", None)
    v36 = None
    v45: None
    closure6(v3, ("" + "; ") + "", None)
    v45 = None
    v54: None
    closure6(v3, ("" + "ex") + "", None)
    v54 = None
    v62: None
    closure6(v3, ("" + " = ") + "", None)
    v62 = None
    v70: None
    closure6(v3, ("" + v1_1) + "", None)
    v70 = None
    v79: None
    closure6(v3, ("" + " }") + "", None)
    v79 = None
    return v3.l0


def closure31(v0_1: int64, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr287:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr287()))):
        v43: None
        v3(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v83: str = method38(method10(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method14(), "read_all_text_retry_async", v57.l0, method41(v0_1, v1_1))
        v85: None
        v3(None)
        v85 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        method20(v83, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method35(v0_1: str, v1_1: int64) -> Async[str | None]:
    return None


def closure26(unit_var: None, v0_1: str) -> Async[str | None]:
    return None


def closure33(unit_var: None, v0_1: chrono_date_time_1[chrono_utc]) -> US11:
    return US11(0, v0_1)


def method44(__unit: None=None) -> Callable[[chrono_date_time_1[chrono_utc]], US11]:
    def _arrow288(v: chrono_date_time_1[chrono_utc]) -> US11:
        return closure33(None, v)

    return _arrow288


def method45(__unit: None=None) -> str:
    return "hh:mm"


def method46(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method47(__unit: None=None) -> str:
    return "hhmm"


def method43(v0_1: str, v1_1: Any) -> str:
    v424: str = to_string(v1_1, method46())
    v493: Any
    raise Exception(("date_time.get_utc_offset / target: " + str(US5(4, US4(0)))) + "")
    v504: uint8 = uint8(1) if (hours(v493) > 0) else uint8(0)
    v505: str = method47()
    v516: str = ((("" + str(v504)) + "") + to_string_1(v493, "c", {})) + ""
    v518: str = str(v0_1)
    return parse(((((("" + v424) + "") + v516) + "") + v518[len(v424) + len(v516):len(v518)]) + "")


def method49(__unit: None=None) -> str:
    raise Exception(("file_system.get_temp_path / target: " + str(US5(4, US4(0)))) + "")


def method50(__unit: None=None) -> str:
    return "!create_temp_path_"


def method53(v0_1: str) -> str:
    return v0_1


def method52(v0_1: str, v1_1: str) -> tuple[str, str]:
    return (v1_1, method53(v0_1))


def method51(v0_1: str, v1_1: str) -> str:
    raise Exception(((((("file_system.(</>) / target: " + str(US5(4, US4(0)))) + " / a: ") + v0_1) + " / b: ") + v1_1) + "")


def method55(__unit: None=None) -> str:
    return "CARGO_PKG_NAME"


def method54(__unit: None=None) -> str:
    raise Exception(("env.get_entry_assembly_name / target: " + str(US5(4, US4(0)))) + "")


def method48(v0_1: str) -> str:
    return method51(method51(method51(method49(), method50()), method54()), str(v0_1))


def method42(__unit: None=None) -> str:
    v31_1: Any = now()
    return method48(method43(new_guid(), v31_1))


def closure32(unit_var: None, unit_var_1: None) -> str:
    return method42()


def method57(v0_1: str) -> str:
    return v0_1


def closure35(unit_var: None, v0_1: std_io_error) -> std_string_string:
    return None


def method58(__unit: None=None) -> Callable[[std_io_error], std_string_string]:
    def _arrow289(v: std_io_error) -> std_string_string:
        return closure35(None, v)

    return _arrow289


def closure36(unit_var: None, unit_var_1: None) -> US12:
    return US12(0)


def closure37(unit_var: None, v0_1: std_string_string) -> US12:
    return US12(1, v0_1)


def method59(v0_1: str, v1_1: std_string_string) -> str:
    v3: Mut3 = Mut3(method18())
    v10: None
    closure6(v3, ("" + "{ ") + "", None)
    v10 = None
    v19_1: None
    closure6(v3, ("" + "dir") + "", None)
    v19_1 = None
    v28_1: None
    closure6(v3, ("" + " = ") + "", None)
    v28_1 = None
    v36: None
    closure6(v3, ("" + v0_1) + "", None)
    v36 = None
    v45: None
    closure6(v3, ("" + "; ") + "", None)
    v45 = None
    v54: None
    closure6(v3, ("" + "error") + "", None)
    v54 = None
    v62: None
    closure6(v3, ("" + " = ") + "", None)
    v62 = None
    v97: None
    closure6(v3, ("" + to_text(interpolate("%A%P()", [v1_1]))) + "", None)
    v97 = None
    v106: None
    closure6(v3, ("" + " }") + "", None)
    v106 = None
    return v3.l0


def method60(v0_1: str, v1_1: str, v2_1: int64, v3: str) -> str:
    return trim_end(trim_start(((((((((("" + v0_1) + " ") + v1_1) + " #") + str(v2_1)) + " ") + "file_system.create_dir") + " / ") + v3) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def closure38(v0_1: str, v1_1: std_string_string, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr290:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (4 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr290()))):
        v43: None
        v3(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v79: str = method60(method10(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method39(), v57.l0, method59(v0_1, v1_1))
        v81: None
        v3(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        method20(v79, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method61(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method18())
    v9: None
    closure6(v2_1, ("" + "{ ") + "", None)
    v9 = None
    v18_1: None
    closure6(v2_1, ("" + "dir") + "", None)
    v18_1 = None
    v27_1: None
    closure6(v2_1, ("" + " = ") + "", None)
    v27_1 = None
    v35_1: None
    closure6(v2_1, ("" + v0_1) + "", None)
    v35_1 = None
    v44: None
    closure6(v2_1, ("" + " }") + "", None)
    v44 = None
    return v2_1.l0


def closure39(v0_1: str, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
    v35_1: US0 = pattern_input[4].l0
    class ObjectExpr291:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (0 >= find(v35_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr291()))):
        v42: None
        v2_1(None)
        v42 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        v56: Mut0 = pattern_input_1[0]
        v78: str = method60(method10(v56, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method36(), v56.l0, method61(v0_1))
        v80: None
        v2_1(None)
        v80 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        method20(v78, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure40(v0_1: str, unit_var: None) -> None:
    method7(True, v0_1)


def method62(v0_1: str) -> Callable[[], None]:
    def _arrow292(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure40(v0_1, None)

    return _arrow292


def method63(v0_1: str) -> Callable[[], None]:
    def _arrow293(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure40(v0_1, None)

    return _arrow293


def method64(v0_1: str, v1_1: str) -> str:
    v3: Mut3 = Mut3(method18())
    v10: None
    closure6(v3, ("" + "{ ") + "", None)
    v10 = None
    v19_1: None
    closure6(v3, ("" + "dir") + "", None)
    v19_1 = None
    v28_1: None
    closure6(v3, ("" + " = ") + "", None)
    v28_1 = None
    v36: None
    closure6(v3, ("" + v0_1) + "", None)
    v36 = None
    v45: None
    closure6(v3, ("" + "; ") + "", None)
    v45 = None
    v54: None
    closure6(v3, ("" + "result") + "", None)
    v54 = None
    v62: None
    closure6(v3, ("" + " = ") + "", None)
    v62 = None
    v70: None
    closure6(v3, ("" + v1_1) + "", None)
    v70 = None
    v79: None
    closure6(v3, ("" + " }") + "", None)
    v79 = None
    return v3.l0


def closure41(v0_1: str, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
    v36: US0 = pattern_input[4].l0
    class ObjectExpr294:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (1 >= find(v36, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr294()))):
        v43: None
        v3(None)
        v43 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        v57: Mut0 = pattern_input_1[0]
        v79: str = method60(method10(v57, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method14(), v57.l0, method64(v0_1, v1_1))
        v81: None
        v3(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        method20(v79, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def closure42(v0_1: str, unit_var: None) -> None:
    pass


def method65(v0_1: str) -> Callable[[], None]:
    def _arrow295(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure42(v0_1, None)

    return _arrow295


def method66(v0_1: str) -> Callable[[], None]:
    def _arrow296(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure42(v0_1, None)

    return _arrow296


def method56(v0_1: str) -> IDisposable:
    v517: bool = None
    if v517 == False:
        v551: None
        closure41(v0_1, to_text(interpolate("%A%P()", [{
            "CreationTime": None,
            "Exists": v517
        }])), None)
        v551 = None

    v672: Callable[[], None] = method66(v0_1)
    class ObjectExpr297(IDisposable):
        def Dispose(self, __unit: None=None, v0_1: Any=v0_1) -> None:
            v672(None)

    return ObjectExpr297()


def closure34(unit_var: None, unit_var_1: None) -> tuple[str, IDisposable]:
    v0_1: str = method42()
    return (v0_1, method56(v0_1))


def method67(v0_1: str) -> str:
    v56: str = pad_left(v0_1, 32, "0")
    return parse(((((((((("" + v56[0:7 + 1]) + "-") + v56[8:11 + 1]) + "-") + v56[12:15 + 1]) + "-") + v56[16:19 + 1]) + "-") + v56[20:31 + 1]) + "")


def closure43(unit_var: None, v0_1: str) -> tuple[str, IDisposable]:
    v2_1: str = method48(method67(v0_1))
    return (v2_1, method56(v2_1))


def closure44(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def method70(v0_1: std_io_error) -> str:
    v2_1: Mut3 = Mut3(method18())
    v35_1: None
    closure6(v2_1, ("" + to_text(interpolate("%A%P()", [v0_1]))) + "", None)
    v35_1 = None
    return v2_1.l0


def closure46(unit_var: None, v0_1: std_io_error) -> str:
    return method70(v0_1)


def method69(__unit: None=None) -> Callable[[std_io_error], str]:
    def _arrow298(v: std_io_error) -> str:
        return closure46(None, v)

    return _arrow298


def closure47(unit_var: None, v0_1: std_path_path_buf) -> US13:
    return US13(0, v0_1)


def closure48(unit_var: None, v0_1: str) -> US13:
    return US13(1, v0_1)


def method72(v0_1: str) -> str:
    return None


def method71(v0_1: str) -> str | None:
    v51: US1 = None
    if v51.tag == 0:
        return v51.fields[0]

    else: 
        return None



def closure49(unit_var: None, v0_1: std_path_path_buf) -> US14:
    return US14(0, v0_1)


def method73(__unit: None=None) -> Callable[[std_path_path_buf], US14]:
    def _arrow299(v: std_path_path_buf) -> US14:
        return closure49(None, v)

    return _arrow299


def method74(v0_1: str) -> str:
    return v0_1


def method68(v0_1: str) -> str:
    if v0_1 == "":
        return ""

    else: 
        v13132: FSharpResult_2[std_path_path_buf, std_io_error] = FSharpResult_2()
        v13143: std_path_path_buf | None = None if (v13132.tag == 1) else v13132.fields[0]
        v13161: US14 = default_arg(map(method73(), v13143), US14(1))
        def _arrow300(__unit: None=None, v0_1: Any=v0_1) -> str:
            v13187: str = to_string_2(v13161.fields[0])
            return v0_1 if (v13187 == "") else v13187

        if (_arrow300() if (v13161.tag == 0) else v0_1) == "":
            return ""

        else: 
            v13234: str = None
            def _arrow301(__unit: None=None, v0_1: Any=v0_1) -> str:
                _arg: str = v13234[0]
                return _arg.lower()

            return replace(((("" + _arrow301()) + "") + v13234[1:len(v13234)]) + "", "\\", "/")




def closure45(unit_var: None, v0_1: str) -> str:
    return method68(v0_1)


def closure50(unit_var: None, v0_1: str) -> str:
    return ("file:///" + trim_start(v0_1, *to_array(singleton("/")))) + ""


def closure52(unit_var: None, v0_1: str) -> str | None:
    return method71(v0_1)


def method76(__unit: None=None) -> Callable[[str], str | None]:
    def _arrow302(v: str) -> str | None:
        return closure52(None, v)

    return _arrow302


def method77(v0_1_mut: str, v1_1_mut: str, v2_1_mut: str) -> US15:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if method9(method51(v2_1, v0_1)):
            return US15(0, v2_1)

        else: 
            v7: str | None = method76()(v2_1)
            v21_1: US1 = default_arg(map(method4(), v7), US1(1))
            if v21_1.tag == 0:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v21_1.fields[0]
                continue

            else: 
                return US15(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v2_1) + "\')")


        break


def method75(v0_1: str, v1_1: str) -> US15:
    if method9(method51(v1_1, v0_1)):
        return US15(0, v1_1)

    else: 
        v6: str | None = method76()(v1_1)
        v20_1: US1 = default_arg(map(method4(), v6), US1(1))
        if v20_1.tag == 0:
            return method77(v0_1, v1_1, v20_1.fields[0])

        else: 
            return US15(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v1_1) + "\')")




def method78(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method18())
    v9: None
    closure6(v2_1, ("" + "{ ") + "", None)
    v9 = None
    v18_1: None
    closure6(v2_1, ("" + "error") + "", None)
    v18_1 = None
    v27_1: None
    closure6(v2_1, ("" + " = ") + "", None)
    v27_1 = None
    v35_1: None
    closure6(v2_1, ("" + v0_1) + "", None)
    v35_1 = None
    v44: None
    closure6(v2_1, ("" + " }") + "", None)
    v44 = None
    return v2_1.l0


def method79(v0_1: str, v1_1: str, v2_1: int64, v3: str) -> str:
    return trim_end(trim_start(((((((((("" + v0_1) + " ") + v1_1) + " #") + str(v2_1)) + " ") + "file_system.get_workspace_root") + " / ") + v3) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def closure53(v0_1: str, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
    v35_1: US0 = pattern_input[4].l0
    class ObjectExpr303:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input[2].l0 == False) else (3 >= find(v35_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr303()))):
        v42: None
        v2_1(None)
        v42 = None
        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        v56: Mut0 = pattern_input_1[0]
        v78: str = method79(method10(v56, pattern_input_1[1], pattern_input_1[2], pattern_input_1[3], pattern_input_1[4], pattern_input_1[5]), method29(), v56.l0, method78(v0_1))
        v80: None
        v2_1(None)
        v80 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
        method20(v78, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4], pattern_input_2[5])



def method80(__unit: None=None) -> str:
    return None


def closure51(unit_var: None, unit_var_1: None) -> str:
    v4: US15 = method75(method51("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral")
    v124: US1
    if v4.tag == 0:
        v124 = US1(0, v4.fields[0])

    else: 
        v10: None
        closure53(v4.fields[0], None)
        v10 = None
        v124 = US1(1)

    v251: US1
    if v124.tag == 0:
        v251 = US1(0, v124.fields[0])

    else: 
        v127: str = method80()
        v129: US15 = method75(method51("polyglot", ".devcontainer"), v127)
        if v129.tag == 0:
            v251 = US1(0, v129.fields[0])

        else: 
            v135: None
            closure53(v129.fields[0], None)
            v135 = None
            v251 = US1(1)


    def _arrow304(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
        raise Exception("Option does not have a value.")

    return method51(v251.fields[0] if (v251.tag == 0) else _arrow304(), "polyglot")


def method81(v0_1: str) -> None:
    pass


def closure55(unit_var: None, v0_1: str) -> None:
    method81(v0_1)


def closure54(unit_var: None, v0_1: bool) -> None:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_4(TraceState_trace_state())
    def _arrow305(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure55(None, v)

    def _arrow306(v_1: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure2(None, v_1)

    v37: Callable[[str], None] = _arrow305 if v0_1 else _arrow306
    pattern_input[1].l0 = v37


def method82(v0_1: str, v1_1: str) -> None:
    if method9(v0_1) == False:
        v4: IDisposable = method56(v0_1)

    v5: str = method72(v1_1)
    if method9(v5) == False:
        v8: IDisposable = method56(v5)

    def _arrow307(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> bool:
        v8855: FSharpResult_2[std_path_path_buf, std_io_error] = FSharpResult_2()
        return True

    if _arrow307() if method9(v1_1) else False:
        method7(True, v1_1)

    if method9(v1_1) == False:
        pass



def closure57(v0_1: str, v1_1: str) -> None:
    method82(v0_1, v1_1)


def closure56(unit_var: None, v0_1: str) -> Callable[[str], None]:
    def _arrow308(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure57(v0_1, v)

    return _arrow308


def closure59(v0_1: str, v1_1: str) -> str:
    return method51(v0_1, v1_1)


def closure58(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow309(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure59(v0_1, v)

    return _arrow309


v0: None = None

def _arrow310(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow310

def _expr311():
    v1(None)
    return v0


v2: None = _expr311()

def _arrow312(v: str) -> Async[int64]:
    return closure3(None, v)


v16: Callable[[str], Async[int64]] = _arrow312

def delete_directory_async(x: str) -> Async[int64]:
    return v16(x)


def _arrow313(v: US6) -> Callable[[str], Async[int64]]:
    return closure10(None, v)


v17: Callable[[US6, str], Async[int64]] = _arrow313

def wait_for_file_access(x: US6) -> Callable[[str], Async[int64]]:
    return v17(x)


def _arrow314(v: str) -> Async[int64]:
    return closure13(None, v)


v18: Callable[[str], Async[int64]] = _arrow314

def wait_for_file_access_read(x: str) -> Async[int64]:
    return v18(x)


def _arrow315(v: str) -> Async[str]:
    return closure14(None, v)


v19: Callable[[str], Async[str]] = _arrow315

def read_all_text_async(x: str) -> Async[str]:
    return v19(x)


def _arrow316(v: str) -> Callable[[str], bool]:
    return closure15(None, v)


v20: Callable[[str, str], bool] = _arrow316

def file_exists_content(x: str) -> Callable[[str], bool]:
    return v20(x)


def _arrow317(v: str) -> Callable[[str], Async[None]]:
    return closure17(None, v)


v21: Callable[[str, str], Async[None]] = _arrow317

def write_all_text_async(x: str) -> Callable[[str], Async[None]]:
    return v21(x)


def _arrow318(v: str) -> Callable[[str], Async[None]]:
    return closure19(None, v)


v22: Callable[[str, str], Async[None]] = _arrow318

def write_all_text_exists(x: str) -> Callable[[str], Async[None]]:
    return v22(x)


def _arrow319(v: str) -> Async[int64]:
    return closure21(None, v)


v23: Callable[[str], Async[int64]] = _arrow319

def delete_file_async(x: str) -> Async[int64]:
    return v23(x)


def _arrow320(v: str) -> Callable[[str], Async[int64]]:
    return closure23(None, v)


v24: Callable[[str, str], Async[int64]] = _arrow320

def move_file_async(x: str) -> Callable[[str], Async[int64]]:
    return v24(x)


def _arrow321(v: str) -> Async[str | None]:
    return closure26(None, v)


v25: Callable[[str], Async[str | None]] = _arrow321

def read_all_text_retry_async(x: str) -> Async[str | None]:
    return v25(x)


def _arrow322(__unit: None=None) -> str:
    return closure32(None, None)


v26: Callable[[], str] = _arrow322

def create_temp_path(__unit: None=None) -> str:
    return v26(None)


def _arrow323(__unit: None=None) -> tuple[str, IDisposable]:
    return closure34(None, None)


v27: Callable[[], tuple[str, IDisposable]] = _arrow323

def create_temp_dir(__unit: None=None) -> tuple[str, IDisposable]:
    return v27(None)


def _arrow324(v: str) -> tuple[str, IDisposable]:
    return closure43(None, v)


v28: Callable[[str], tuple[str, IDisposable]] = _arrow324

def create_temp_dir_0027(x: str) -> tuple[str, IDisposable]:
    return v28(x)


def _arrow325(__unit: None=None) -> str:
    return closure44(None, None)


v29: Callable[[], str] = _arrow325

def get_source_directory(__unit: None=None) -> str:
    return v29(None)


def _arrow326(v: str) -> str:
    return closure45(None, v)


v30: Callable[[str], str] = _arrow326

def normalize_path(x: str) -> str:
    return v30(x)


def _arrow327(v: str) -> str:
    return closure50(None, v)


v31: Callable[[str], str] = _arrow327

def new_file_uri(x: str) -> str:
    return v31(x)


def _arrow328(__unit: None=None) -> str:
    return closure51(None, None)


v32: Callable[[], str] = _arrow328

def get_workspace_root(__unit: None=None) -> str:
    return v32(None)


def _arrow329(v: bool) -> None:
    closure54(None, v)


v33: Callable[[bool], None] = _arrow329

def init_trace_file(x: bool) -> None:
    v33(x)


def _arrow330(v: str) -> Callable[[str], None]:
    return closure56(None, v)


v34: Callable[[str, str], None] = _arrow330

def link_directory(x: str) -> Callable[[str], None]:
    return v34(x)


def _arrow331(v: str) -> Callable[[str], str]:
    return closure58(None, v)


v35: Callable[[str, str], str] = _arrow331

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v35(x)


