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
from fable_modules.fable_library.option import (some, value as value_3, default_arg)
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, to_text, interpolate, replace)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds, to_string as to_string_1)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef, uint8)
from fable_modules.fable_library.util import (create_atom, IDisposable, to_enumerable, compare)

State_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] | None = create_atom(None)

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


def _expr238() -> TypeInfo:
    return class_type("File_system.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr238

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


class IPathDirname(Protocol):
    @abstractmethod
    def dirname(self, path: str) -> str:
        ...


def _expr239() -> TypeInfo:
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


US0_reflection = _expr239

def _expr240() -> TypeInfo:
    return record_type("File_system.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr240

def _expr241() -> TypeInfo:
    return record_type("File_system.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr241

def _expr242() -> TypeInfo:
    return record_type("File_system.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr242

def _expr243() -> TypeInfo:
    return record_type("File_system.Mut3", [], Mut3, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: US0

Mut3_reflection = _expr243

def _expr244() -> TypeInfo:
    return union_type("File_system.US1", [], US1, lambda: [[("f0_0", US0_reflection())], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr244

def _expr245() -> TypeInfo:
    return union_type("File_system.US2", [], US2, lambda: [[("f0_0", int64_type)], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr245

def _expr246() -> TypeInfo:
    return union_type("File_system.US3", [], US3, lambda: [[("f0_0", string_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr246

def _expr247() -> TypeInfo:
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


US4_reflection = _expr247

def _expr248() -> TypeInfo:
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


US5_reflection = _expr248

def _expr249() -> TypeInfo:
    return record_type("File_system.Mut4", [], Mut4, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: str

Mut4_reflection = _expr249

def _expr250() -> TypeInfo:
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


US7_reflection = _expr250

def _expr251() -> TypeInfo:
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


US8_reflection = _expr251

def _expr252() -> TypeInfo:
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


US6_reflection = _expr252

def _expr253() -> TypeInfo:
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


US9_reflection = _expr253

def _expr254() -> TypeInfo:
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


US10_reflection = _expr254

def _expr255() -> TypeInfo:
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


US11_reflection = _expr255

def _expr256() -> TypeInfo:
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


US12_reflection = _expr256

def _expr257() -> TypeInfo:
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


US13_reflection = _expr257

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
        v57 = value_3(_v54)

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


def closure0(unit_var: None, v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
    _v1: tuple[US1, US2] | None = None
    v133: str = method1(method0())
    v139: US1 = US1(0, US0(0)) if ("Verbose" == v133) else US1(1)
    def _arrow258(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> US1:
        v147: US1 = US1(0, US0(1)) if ("Debug" == v133) else US1(1)
        if v147.tag == 0:
            return US1(0, v147.fields[0])

        else: 
            v155: US1 = US1(0, US0(2)) if ("Info" == v133) else US1(1)
            if v155.tag == 0:
                return US1(0, v155.fields[0])

            else: 
                v163: US1 = US1(0, US0(3)) if ("Warning" == v133) else US1(1)
                if v163.tag == 0:
                    return US1(0, v163.fields[0])

                else: 
                    v171: US1 = US1(0, US0(4)) if ("Critical" == v133) else US1(1)
                    return US1(0, v171.fields[0]) if (v171.tag == 0) else US1(1)




    x: tuple[US1, US2] = (US1(0, v139.fields[0]) if (v139.tag == 0) else _arrow258(), US2(0, ticks_1(now())) if (method1(method3()) == "True") else US2(1))
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

    return (Mut0(int64(0)), Mut1(v266), Mut2(True), Mut3(v258.fields[0] if (v258.tag == 0) else v0_1), v259.fields[0] if (v259.tag == 0) else None)


def method6(v0_1: str) -> str:
    return v0_1


def method7(v0_1: str) -> bool:
    _v1: bool | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method5(v0_1: bool, v1_1: str) -> None:
    _v2: None | None = None
    _v2 = some(None)
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        value_3(_v2)



def closure3(unit_var: None, unit_var_1: None) -> str:
    return "file_system.delete_directory_async"


def method8(v0_1: str) -> str:
    _v1: str | None = None
    x: str
    raise Exception(((("file_system.get_file_name / target: " + str(US5(4, US4(0)))) + " / path: ") + v0_1) + "")
    _v1 = x
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def closure4(v0_1: str, v1_1: str, unit_var: None) -> tuple[str, str]:
    return (v1_1, method8(v0_1))


def method10(__unit: None=None) -> str:
    return "hh:mm:ss"


def method11(__unit: None=None) -> str:
    return ""


def method12(__unit: None=None) -> str:
    return "HH:mm:ss"


def method13(__unit: None=None) -> str:
    return "\u001b[0m"


def method15(v0_1: Mut4, v1_1: str) -> None:
    v4_1: str = v0_1.l0 + (("" + v1_1) + "")
    v0_1.l0 = v4_1


def method16(v0_1: Mut4) -> None:
    pass


def method14(v0_1: Mut4, v1_1: str, v2_1: str) -> None:
    method15(v0_1, "{ ")
    method16(v0_1)
    method15(v0_1, "ex")
    method15(v0_1, " = ")
    method15(v0_1, v1_1)
    method15(v0_1, "; ")
    method15(v0_1, "path")
    method15(v0_1, " = ")
    method15(v0_1, v2_1)
    method15(v0_1, " }")


def closure5(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[str, str]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v9_1: int64 | None = pattern_input[4]
    _v10: str | None = None
    _v96: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v9_1 is None:
        x_2 = None

    else: 
        x: int64 = v9_1
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US2 = default_arg(_v96.contents, US2(1))
    def _arrow259(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow259() if (v101.tag == 0) else now(), method12())
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
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method13()
    _v216 = x_5
    v328: str
    if _v216 is None:
        raise Exception("base.run_target / _v216=None")

    else: 
        v328 = _v216

    v329: int64 = pattern_input[0].l0
    pattern_input_1: tuple[str, str] = v2_1(None)
    v333: Mut4 = Mut4("")
    method14(v333, pattern_input_1[0], pattern_input_1[1])
    v334: str = v333.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v334) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method17(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(v: US0, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
        return closure0(None, v)

    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v4_1: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v15_1: US0 = pattern_input_1[3].l0
    class ObjectExpr260:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr261:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr260())) >= find(v15_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr261()))):
        v23: int64 = op_addition(v4_1.l0, int64(1))
        v4_1.l0 = v23
        v24: str = ("" + v1_1(None)) + ""
        _v25: None | None = None
        print(v24)
        _v25 = some(None)
        if _v25 is None:
            raise Exception("base.run_target / _v25=None")

        else: 
            value_3(_v25)

        pattern_input[1].l0(v24)



def method9(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[str, str]]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure5(v0_1, v1_1, v2_1, None)

    method17(v0_1, v3_1)


def method4(v0_1: str, v1_1: int64) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure2(unit_var: None, v0_1: str) -> Async[int64]:
    _v1: Async[int64] | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def closure8(unit_var: None, unit_var_1: None) -> str:
    return "file_system.wait_for_file_access"


def closure9(v0_1: str, v1_1: int64, v2_1: str, unit_var: None) -> tuple[str, int64, str]:
    return (method8(v0_1), v1_1, v2_1)


def method21(v0_1: Mut4, v1_1: int64) -> None:
    v4_1: str = v0_1.l0 + (("" + str(v1_1)) + "")
    v0_1.l0 = v4_1


def method20(v0_1: Mut4, v1_1: str, v2_1: int64, v3_1: str) -> None:
    method15(v0_1, "{ ")
    method16(v0_1)
    method15(v0_1, "path")
    method15(v0_1, " = ")
    method15(v0_1, v1_1)
    method15(v0_1, "; ")
    method15(v0_1, "retry")
    method15(v0_1, " = ")
    method21(v0_1, v2_1)
    method15(v0_1, "; ")
    method15(v0_1, "ex")
    method15(v0_1, " = ")
    method15(v0_1, v3_1)
    method15(v0_1, " }")


def closure10(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[str, int64, str]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v9_1: int64 | None = pattern_input[4]
    _v10: str | None = None
    _v96: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v9_1 is None:
        x_2 = None

    else: 
        x: int64 = v9_1
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US2 = default_arg(_v96.contents, US2(1))
    def _arrow262(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow262() if (v101.tag == 0) else now(), method12())
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
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method13()
    _v216 = x_5
    v328: str
    if _v216 is None:
        raise Exception("base.run_target / _v216=None")

    else: 
        v328 = _v216

    v329: int64 = pattern_input[0].l0
    pattern_input_1: tuple[str, int64, str] = v2_1(None)
    v334: Mut4 = Mut4("")
    method20(v334, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])
    v335: str = v334.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v335) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method19(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[str, int64, str]]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure10(v0_1, v1_1, v2_1, None)

    method17(v0_1, v3_1)


def method18(v0_1: str, v1_1: US8, v2_1: US7, v3_1: int64) -> Async[int64]:
    _v4: Async[int64] | None = None
    _v4 = None
    if _v4 is None:
        raise Exception("base.run_target / _v4=None")

    else: 
        return _v4



def closure7(v0_1: US6, v1_1: str) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure6(unit_var: None, v0_1: US6) -> Callable[[str], Async[int64]]:
    def _arrow263(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure7(v0_1, v)

    return _arrow263


def method22(v0_1: str, v1_1: int64) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure11(unit_var: None, v0_1: str) -> Async[int64]:
    _v1: Async[int64] | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def closure12(unit_var: None, v0_1: str) -> Async[str]:
    _v1: Async[str] | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method24(v0_1: str) -> bool:
    _v1: bool | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method25(v0_1: Vec_1[uint8]) -> Vec_1[uint8]:
    return v0_1


def method23(v0_1: str, v1_1: str) -> bool:
    _v2: bool | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure14(v0_1: str, v1_1: str) -> bool:
    return method23(v0_1, v1_1)


def closure13(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow264(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure14(v0_1, v)

    return _arrow264


def closure16(v0_1: str, v1_1: str) -> Async[None]:
    _v2: Async[None] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure15(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow265(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure16(v0_1, v)

    return _arrow265


def closure18(v0_1: str, v1_1: str) -> Async[None]:
    _v2: Async[None] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure17(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow266(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure18(v0_1, v)

    return _arrow266


def closure20(unit_var: None, unit_var_1: None) -> str:
    return "delete_file_async"


def closure21(v0_1: str, v1_1: Exception, unit_var: None) -> tuple[str, str]:
    v2_1: str = method8(v0_1)
    _v3: str | None = None
    x: str = to_text(interpolate("%A%P()", [v1_1]))
    _v3 = x
    def _arrow267(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> str:
        raise Exception("base.run_target / _v3=None")

    return (v2_1, _arrow267() if (_v3 is None) else _v3)


def method28(v0_1: Mut4, v1_1: str, v2_1: str) -> None:
    method15(v0_1, "{ ")
    method16(v0_1)
    method15(v0_1, "path")
    method15(v0_1, " = ")
    method15(v0_1, v1_1)
    method15(v0_1, "; ")
    method15(v0_1, "ex")
    method15(v0_1, " = ")
    method15(v0_1, v2_1)
    method15(v0_1, " }")


def closure22(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[str, str]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v9_1: int64 | None = pattern_input[4]
    _v10: str | None = None
    _v96: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v9_1 is None:
        x_2 = None

    else: 
        x: int64 = v9_1
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US2 = default_arg(_v96.contents, US2(1))
    def _arrow268(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow268() if (v101.tag == 0) else now(), method12())
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
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method13()
    _v216 = x_5
    v328: str
    if _v216 is None:
        raise Exception("base.run_target / _v216=None")

    else: 
        v328 = _v216

    v329: int64 = pattern_input[0].l0
    pattern_input_1: tuple[str, str] = v2_1(None)
    v333: Mut4 = Mut4("")
    method28(v333, pattern_input_1[0], pattern_input_1[1])
    v334: str = v333.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v334) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method27(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[str, str]]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure22(v0_1, v1_1, v2_1, None)

    method17(v0_1, v3_1)


def method26(v0_1: str, v1_1: int64) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure19(unit_var: None, v0_1: str) -> Async[int64]:
    _v1: Async[int64] | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def closure25(unit_var: None, unit_var_1: None) -> str:
    return "move_file_async"


def closure26(v0_1: str, v1_1: str, v2_1: Exception, unit_var: None) -> tuple[str, str, Exception]:
    return (method8(v1_1), method8(v0_1), v2_1)


def method32(v0_1: Mut4, v1_1: Exception) -> None:
    method15(v0_1, to_text(interpolate("%A%P()", [v1_1])))


def method31(v0_1: Mut4, v1_1: str, v2_1: str, v3_1: Exception) -> None:
    method15(v0_1, "{ ")
    method16(v0_1)
    method15(v0_1, "old_path")
    method15(v0_1, " = ")
    method15(v0_1, v1_1)
    method15(v0_1, "; ")
    method15(v0_1, "new_path")
    method15(v0_1, " = ")
    method15(v0_1, v2_1)
    method15(v0_1, "; ")
    method15(v0_1, "ex")
    method15(v0_1, " = ")
    method32(v0_1, v3_1)
    method15(v0_1, " }")


def closure27(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[str, str, Exception]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v9_1: int64 | None = pattern_input[4]
    _v10: str | None = None
    _v96: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v9_1 is None:
        x_2 = None

    else: 
        x: int64 = v9_1
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US2 = default_arg(_v96.contents, US2(1))
    def _arrow269(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow269() if (v101.tag == 0) else now(), method12())
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
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method13()
    _v216 = x_5
    v328: str
    if _v216 is None:
        raise Exception("base.run_target / _v216=None")

    else: 
        v328 = _v216

    v329: int64 = pattern_input[0].l0
    pattern_input_1: tuple[str, str, Exception] = v2_1(None)
    v334: Mut4 = Mut4("")
    method31(v334, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])
    v335: str = v334.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v335) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method30(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[str, str, Exception]]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure27(v0_1, v1_1, v2_1, None)

    method17(v0_1, v3_1)


def method29(v0_1: str, v1_1: str, v2_1: int64) -> Async[int64]:
    _v3: Async[int64] | None = None
    _v3 = None
    if _v3 is None:
        raise Exception("base.run_target / _v3=None")

    else: 
        return _v3



def closure24(v0_1: str, v1_1: str) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure23(unit_var: None, v0_1: str) -> Callable[[str], Async[int64]]:
    def _arrow270(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure24(v0_1, v)

    return _arrow270


def closure29(unit_var: None, v0_1: int64) -> US9:
    return US9(0, v0_1)


def closure30(unit_var: None, v0_1: Exception) -> US9:
    return US9(1, v0_1)


def closure31(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async"


def closure32(unit_var: None, unit_var_1: None) -> int:
    return 1000


def method36(v0_1: Mut4, v1_1: int) -> None:
    v4_1: str = v0_1.l0 + (("" + str(v1_1)) + "")
    v0_1.l0 = v4_1


def method35(v0_1: Mut4, v1_1: int) -> None:
    method15(v0_1, "{ ")
    method16(v0_1)
    method15(v0_1, "timeout")
    method15(v0_1, " = ")
    method36(v0_1, v1_1)
    method15(v0_1, " }")


def closure33(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], int], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v9_1: int64 | None = pattern_input[4]
    _v10: str | None = None
    _v96: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v9_1 is None:
        x_2 = None

    else: 
        x: int64 = v9_1
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US2 = default_arg(_v96.contents, US2(1))
    def _arrow271(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow271() if (v101.tag == 0) else now(), method12())
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
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method13()
    _v216 = x_5
    v328: str
    if _v216 is None:
        raise Exception("base.run_target / _v216=None")

    else: 
        v328 = _v216

    v329: int64 = pattern_input[0].l0
    v332: Mut4 = Mut4("")
    method35(v332, v2_1(None))
    v333: str = v332.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v333) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method34(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], int]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure33(v0_1, v1_1, v2_1, None)

    method17(v0_1, v3_1)


def closure34(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async**"


def closure35(v0_1: Exception, unit_var: None) -> tuple[int, str]:
    _v1: str | None = None
    x: str = to_text(interpolate("%A%P()", [v0_1]))
    _v1 = x
    def _arrow272(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> str:
        raise Exception("base.run_target / _v1=None")

    return (1000, _arrow272() if (_v1 is None) else _v1)


def method38(v0_1: Mut4, v1_1: int, v2_1: str) -> None:
    method15(v0_1, "{ ")
    method16(v0_1)
    method15(v0_1, "timeout")
    method15(v0_1, " = ")
    method36(v0_1, v1_1)
    method15(v0_1, "; ")
    method15(v0_1, "ex")
    method15(v0_1, " = ")
    method15(v0_1, v2_1)
    method15(v0_1, " }")


def closure36(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[int, str]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v9_1: int64 | None = pattern_input[4]
    _v10: str | None = None
    _v96: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v9_1 is None:
        x_2 = None

    else: 
        x: int64 = v9_1
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US2 = default_arg(_v96.contents, US2(1))
    def _arrow273(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow273() if (v101.tag == 0) else now(), method12())
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
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method13()
    _v216 = x_5
    v328: str
    if _v216 is None:
        raise Exception("base.run_target / _v216=None")

    else: 
        v328 = _v216

    v329: int64 = pattern_input[0].l0
    pattern_input_1: tuple[int, str] = v2_1(None)
    v333: Mut4 = Mut4("")
    method38(v333, pattern_input_1[0], pattern_input_1[1])
    v334: str = v333.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v334) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method37(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[int, str]]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure36(v0_1, v1_1, v2_1, None)

    method17(v0_1, v3_1)


def closure37(unit_var: None, unit_var_1: None) -> str:
    return "read_all_text_retry_async"


def closure38(v0_1: int64, v1_1: str, unit_var: None) -> tuple[int64, str]:
    return (v0_1, v1_1)


def method40(v0_1: Mut4, v1_1: int64, v2_1: str) -> None:
    method15(v0_1, "{ ")
    method16(v0_1)
    method15(v0_1, "retry")
    method15(v0_1, " = ")
    method21(v0_1, v1_1)
    method15(v0_1, "; ")
    method15(v0_1, "ex")
    method15(v0_1, " = ")
    method15(v0_1, v2_1)
    method15(v0_1, " }")


def closure39(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[int64, str]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v9_1: int64 | None = pattern_input[4]
    _v10: str | None = None
    _v96: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v9_1 is None:
        x_2 = None

    else: 
        x: int64 = v9_1
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US2 = default_arg(_v96.contents, US2(1))
    def _arrow274(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow274() if (v101.tag == 0) else now(), method12())
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
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method13()
    _v216 = x_5
    v328: str
    if _v216 is None:
        raise Exception("base.run_target / _v216=None")

    else: 
        v328 = _v216

    v329: int64 = pattern_input[0].l0
    pattern_input_1: tuple[int64, str] = v2_1(None)
    v333: Mut4 = Mut4("")
    method40(v333, pattern_input_1[0], pattern_input_1[1])
    v334: str = v333.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v334) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method39(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[int64, str]]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure39(v0_1, v1_1, v2_1, None)

    method17(v0_1, v3_1)


def method33(v0_1: str, v1_1: int64) -> Async[str | None]:
    _v2: Async[str | None] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure28(unit_var: None, v0_1: str) -> Async[str | None]:
    _v1: Async[str | None] | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method43(v0_1: chrono_date_time_1[chrono_utc]) -> chrono_date_time_1[chrono_utc]:
    return v0_1


def method44(v0_1: chrono_date_time_1[chrono_local]) -> chrono_date_time_1[chrono_local]:
    return v0_1


def method45(__unit: None=None) -> str:
    return "hh:mm"


def method46(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method47(__unit: None=None) -> str:
    return "hhmm"


def method42(v0_1: str, v1_1: Any) -> str:
    _v2: str | None = None
    v259: str = to_string(v1_1, method46())
    _v260: Any | None = None
    _v260 = None
    v268: Any
    if _v260 is None:
        raise Exception("base.run_target / _v260=None")

    else: 
        v268 = _v260

    _v269: Any | None = None
    x_2: Any
    raise Exception(("date_time.get_utc_offset / target: " + str(US5(4, US4(0)))) + "")
    _v269 = x_2
    v296: Any
    if _v269 is None:
        raise Exception("base.run_target / _v269=None")

    else: 
        v296 = _v269

    v300: uint8 = uint8(1) if (hours(v296) > 0) else uint8(0)
    v301: str = method47()
    _v302: str | None = None
    x_4: str = to_string_1(v296, "c", {})
    _v302 = x_4
    def _arrow275(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        raise Exception("base.run_target / _v302=None")

    v310: str = ((("" + str(v300)) + "") + (_arrow275() if (_v302 is None) else _v302)) + ""
    v312: str = str(v0_1)
    x_6: str = parse(((((("" + v259) + "") + v310) + "") + v312[len(v259) + len(v310):len(v312)]) + "")
    _v2 = x_6
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def method49(__unit: None=None) -> str:
    _v0: str | None = None
    x: str
    raise Exception(("file_system.get_temp_path / target: " + str(US5(4, US4(0)))) + "")
    _v0 = x
    if _v0 is None:
        raise Exception("base.run_target / _v0=None")

    else: 
        return _v0



def method50(__unit: None=None) -> str:
    return "!create_temp_path_"


def method53(v0_1: str) -> str:
    return v0_1


def method52(v0_1: str, v1_1: str) -> tuple[str, str]:
    return (v1_1, method53(v0_1))


def method51(v0_1: str, v1_1: str) -> str:
    _v2: str | None = None
    x: str
    raise Exception(((((("file_system.(</>) / target: " + str(US5(4, US4(0)))) + " / a: ") + v0_1) + " / b: ") + v1_1) + "")
    _v2 = x
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def method55(__unit: None=None) -> str:
    return "CARGO_PKG_NAME"


def method54(__unit: None=None) -> str:
    _v0: str | None = None
    x: str
    raise Exception(("env.get_entry_assembly_name / target: " + str(US5(4, US4(0)))) + "")
    _v0 = x
    if _v0 is None:
        raise Exception("base.run_target / _v0=None")

    else: 
        return _v0



def method48(v0_1: str) -> str:
    _v1: str | None = None
    x: str = method51(method51(method51(method49(), method50()), method54()), str(v0_1))
    _v1 = x
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method41(__unit: None=None) -> str:
    _v0: str | None = None
    v17_1: Any = now()
    x: str = method48(method42(new_guid(), v17_1))
    _v0 = x
    if _v0 is None:
        raise Exception("base.run_target / _v0=None")

    else: 
        return _v0



def closure40(unit_var: None, unit_var_1: None) -> str:
    return method41()


def method57(v0_1: str) -> str:
    return v0_1


def closure42(unit_var: None, v0_1: std_io_error) -> std_string_string:
    _v1: std_string_string | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method58(__unit: None=None) -> Callable[[std_io_error], std_string_string]:
    def _arrow276(v: std_io_error) -> std_string_string:
        return closure42(None, v)

    return _arrow276


def closure43(unit_var: None, unit_var_1: None) -> US12:
    return US12(0)


def closure44(unit_var: None, v0_1: std_string_string) -> US12:
    return US12(1, v0_1)


def closure45(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_dir"


def closure46(v0_1: str, v1_1: std_string_string, unit_var: None) -> tuple[str, std_string_string]:
    return (v0_1, v1_1)


def method61(v0_1: Mut4, v1_1: std_string_string) -> None:
    method15(v0_1, to_text(interpolate("%A%P()", [v1_1])))


def method60(v0_1: Mut4, v1_1: str, v2_1: std_string_string) -> None:
    method15(v0_1, "{ ")
    method16(v0_1)
    method15(v0_1, "dir")
    method15(v0_1, " = ")
    method15(v0_1, v1_1)
    method15(v0_1, "; ")
    method15(v0_1, "error")
    method15(v0_1, " = ")
    method61(v0_1, v2_1)
    method15(v0_1, " }")


def closure47(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[str, std_string_string]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v9_1: int64 | None = pattern_input[4]
    _v10: str | None = None
    _v96: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v9_1 is None:
        x_2 = None

    else: 
        x: int64 = v9_1
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US2 = default_arg(_v96.contents, US2(1))
    def _arrow277(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow277() if (v101.tag == 0) else now(), method12())
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
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method13()
    _v216 = x_5
    v328: str
    if _v216 is None:
        raise Exception("base.run_target / _v216=None")

    else: 
        v328 = _v216

    v329: int64 = pattern_input[0].l0
    pattern_input_1: tuple[str, std_string_string] = v2_1(None)
    v333: Mut4 = Mut4("")
    method60(v333, pattern_input_1[0], pattern_input_1[1])
    v334: str = v333.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v334) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method59(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[str, std_string_string]]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure47(v0_1, v1_1, v2_1, None)

    method17(v0_1, v3_1)


def closure48(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_dir"


def closure49(v0_1: str, unit_var: None) -> str:
    return v0_1


def method63(v0_1: Mut4, v1_1: str) -> None:
    method15(v0_1, "{ ")
    method16(v0_1)
    method15(v0_1, "dir")
    method15(v0_1, " = ")
    method15(v0_1, v1_1)
    method15(v0_1, " }")


def closure50(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v9_1: int64 | None = pattern_input[4]
    _v10: str | None = None
    _v96: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v9_1 is None:
        x_2 = None

    else: 
        x: int64 = v9_1
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US2 = default_arg(_v96.contents, US2(1))
    def _arrow278(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow278() if (v101.tag == 0) else now(), method12())
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
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method13()
    _v216 = x_5
    v328: str
    if _v216 is None:
        raise Exception("base.run_target / _v216=None")

    else: 
        v328 = _v216

    v329: int64 = pattern_input[0].l0
    v332: Mut4 = Mut4("")
    method63(v332, v2_1(None))
    v333: str = v332.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v333) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method62(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure50(v0_1, v1_1, v2_1, None)

    method17(v0_1, v3_1)


def closure51(v0_1: str, unit_var: None) -> None:
    method5(True, v0_1)


def method64(v0_1: str) -> Callable[[], None]:
    def _arrow279(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure51(v0_1, None)

    return _arrow279


def method65(v0_1: str) -> Callable[[], None]:
    def _arrow280(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure51(v0_1, None)

    return _arrow280


def closure52(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_dir"


def closure53(v0_1: str, v1_1: str, unit_var: None) -> tuple[str, str]:
    return (v0_1, v1_1)


def method67(v0_1: Mut4, v1_1: str, v2_1: str) -> None:
    method15(v0_1, "{ ")
    method16(v0_1)
    method15(v0_1, "dir")
    method15(v0_1, " = ")
    method15(v0_1, v1_1)
    method15(v0_1, "; ")
    method15(v0_1, "result")
    method15(v0_1, " = ")
    method15(v0_1, v2_1)
    method15(v0_1, " }")


def closure54(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[str, str]], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v9_1: int64 | None = pattern_input[4]
    _v10: str | None = None
    _v96: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v9_1 is None:
        x_2 = None

    else: 
        x: int64 = v9_1
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US2 = default_arg(_v96.contents, US2(1))
    def _arrow281(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow281() if (v101.tag == 0) else now(), method12())
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
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method13()
    _v216 = x_5
    v328: str
    if _v216 is None:
        raise Exception("base.run_target / _v216=None")

    else: 
        v328 = _v216

    v329: int64 = pattern_input[0].l0
    pattern_input_1: tuple[str, str] = v2_1(None)
    v333: Mut4 = Mut4("")
    method67(v333, pattern_input_1[0], pattern_input_1[1])
    v334: str = v333.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v334) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method66(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], tuple[str, str]]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure54(v0_1, v1_1, v2_1, None)

    method17(v0_1, v3_1)


def closure55(v0_1: str, unit_var: None) -> None:
    _v1: Async[int64] | None = None
    _v1 = None
    v9_1: Async[int64]
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        v9_1 = _v1

    _v10: Async[None] | None = None
    _v10 = None
    v18_1: Async[None]
    if _v10 is None:
        raise Exception("base.run_target / _v10=None")

    else: 
        v18_1 = _v10

    _v19: None | None = None
    _v19 = some(None)
    if _v19 is None:
        raise Exception("base.run_target / _v19=None")

    else: 
        value_3(_v19)



def method68(v0_1: str) -> Callable[[], None]:
    def _arrow282(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure55(v0_1, None)

    return _arrow282


def method69(v0_1: str) -> Callable[[], None]:
    def _arrow283(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure55(v0_1, None)

    return _arrow283


def method56(v0_1: str) -> IDisposable:
    _v1: IDisposable | None = None
    _v79: Any | None = None
    _v79 = None
    v87: Any
    if _v79 is None:
        raise Exception("base.run_target / _v79=None")

    else: 
        v87 = _v79

    _v88: bool | None = None
    _v88 = None
    v95: bool
    if _v88 is None:
        raise Exception("base.run_target / _v88=None")

    else: 
        v95 = _v88

    if v95 == False:
        _v97: Any | None = None
        _v97 = None
        def _arrow284(__unit: None=None, v0_1: Any=v0_1) -> Any:
            raise Exception("base.run_target / _v97=None")

        v106: str = to_text(interpolate("%A%P()", [{
            "CreationTime": _arrow284() if (_v97 is None) else _v97,
            "Exists": v95
        }]))
        def v108(__unit: None=None, v0_1: Any=v0_1) -> str:
            return closure52(None, None)

        def v109(__unit: None=None, v0_1: Any=v0_1) -> tuple[str, str]:
            return closure53(v0_1, v106, None)

        method66(US0(1), v108, v109)

    _v110: IDisposable | None = None
    v119: Callable[[], None] = method69(v0_1)
    class ObjectExpr285(IDisposable):
        def Dispose(self, __unit: None=None, v0_1: Any=v0_1) -> None:
            v119(None)

    x_6: IDisposable = ObjectExpr285()
    _v110 = x_6
    x_8: IDisposable
    if _v110 is None:
        raise Exception("base.run_target / _v110=None")

    else: 
        x_8 = _v110

    _v1 = x_8
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def closure41(unit_var: None, unit_var_1: None) -> tuple[str, IDisposable]:
    v0_1: str = method41()
    return (v0_1, method56(v0_1))


def method70(v0_1: str) -> str:
    _v1: str | None = None
    v9_1: str = pad_left(v0_1, 32, "0")
    x: str = parse(((((((((("" + v9_1[0:7 + 1]) + "-") + v9_1[8:11 + 1]) + "-") + v9_1[12:15 + 1]) + "-") + v9_1[16:19 + 1]) + "-") + v9_1[20:31 + 1]) + "")
    _v1 = x
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def closure56(unit_var: None, v0_1: str) -> tuple[str, IDisposable]:
    v2_1: str = method48(method70(v0_1))
    return (v2_1, method56(v2_1))


def closure57(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def method72(__unit: None=None) -> str:
    return ""


def method73(v0_1: str) -> str:
    return v0_1


def method74(__unit: None=None) -> str:
    return "^\\\\\\\\\\?\\\\"


def method71(v0_1: str) -> str:
    if v0_1 == "":
        return ""

    else: 
        v4_1: str = method72()
        _v5: str | None = None
        _v5 = None
        v24: str
        if _v5 is None:
            raise Exception("base.run_target / _v5=None")

        else: 
            v24 = _v5

        def _arrow286(__unit: None=None, v0_1: Any=v0_1) -> str:
            _arg: str = v24[0]
            return _arg.lower()

        return replace(((("" + _arrow286()) + "") + v24[1:len(v24)]) + "", "\\", "/")



def closure58(unit_var: None, v0_1: str) -> str:
    return method71(v0_1)


def closure59(unit_var: None, v0_1: str) -> str:
    return ("file:///" + trim_start(v0_1, *to_array(singleton("/")))) + ""


def method77(v0_1: str) -> str | None:
    _v1: US3 | None = None
    _v1 = None
    v51: US3
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        v51 = _v1

    if v51.tag == 0:
        return v51.fields[0]

    else: 
        return None



def closure61(unit_var: None, v0_1: str) -> str | None:
    return method77(v0_1)


def method76(__unit: None=None) -> Callable[[str], str | None]:
    def _arrow287(v: str) -> str | None:
        return closure61(None, v)

    return _arrow287


def method78(v0_1_mut: str, v1_1_mut: str, v2_1_mut: str) -> US13:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if method7(method51(v2_1, v0_1)):
            return US13(0, v2_1)

        else: 
            v7_1: str | None = method76()(v2_1)
            _v8: FSharpRef[US3 | None] = FSharpRef(None)
            x_2: US3 | None
            if v7_1 is None:
                x_2 = None

            else: 
                x: str = v7_1
                def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> US3:
                    return US3(0, x)

                x_2 = x_1(None)

            _v8.contents = x_2
            v13_1: US3 = default_arg(_v8.contents, US3(1))
            if v13_1.tag == 0:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v13_1.fields[0]
                continue

            else: 
                return US13(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v2_1) + "\')")


        break


def method75(v0_1: str, v1_1: str) -> US13:
    if method7(method51(v1_1, v0_1)):
        return US13(0, v1_1)

    else: 
        v6_1: str | None = method76()(v1_1)
        _v7: FSharpRef[US3 | None] = FSharpRef(None)
        x_2: US3 | None
        if v6_1 is None:
            x_2 = None

        else: 
            x: str = v6_1
            def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> US3:
                return US3(0, x)

            x_2 = x_1(None)

        _v7.contents = x_2
        v12_1: US3 = default_arg(_v7.contents, US3(1))
        if v12_1.tag == 0:
            return method78(v0_1, v1_1, v12_1.fields[0])

        else: 
            return US13(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v1_1) + "\')")




def closure62(unit_var: None, unit_var_1: None) -> str:
    return "file_system.get_workspace_root"


def closure63(v0_1: str, unit_var: None) -> str:
    return v0_1


def method80(v0_1: Mut4, v1_1: str) -> None:
    method15(v0_1, "{ ")
    method16(v0_1)
    method15(v0_1, "error")
    method15(v0_1, " = ")
    method15(v0_1, v1_1)
    method15(v0_1, " }")


def closure64(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v9_1: int64 | None = pattern_input[4]
    _v10: str | None = None
    _v96: FSharpRef[US2 | None] = FSharpRef(None)
    x_2: US2 | None
    if v9_1 is None:
        x_2 = None

    else: 
        x: int64 = v9_1
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US2:
            return US2(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US2 = default_arg(_v96.contents, US2(1))
    def _arrow288(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow288() if (v101.tag == 0) else now(), method12())
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
    x_5: str = (("\u001b[94m" if (v0_1.tag == 1) else ("\u001b[92m" if (v0_1.tag == 2) else ("\u001b[90m" if (v0_1.tag == 0) else ("\u001b[93m" if (v0_1.tag == 3) else "\u001b[91m")))) + v215) + method13()
    _v216 = x_5
    v328: str
    if _v216 is None:
        raise Exception("base.run_target / _v216=None")

    else: 
        v328 = _v216

    v329: int64 = pattern_input[0].l0
    v332: Mut4 = Mut4("")
    method80(v332, v2_1(None))
    v333: str = v332.l0
    return trim_end(trim_start(((((((((("" + v152) + " ") + v328) + " #") + str(v329)) + " ") + v1_1(None)) + " / ") + v333) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method79(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure64(v0_1, v1_1, v2_1, None)

    method17(v0_1, v3_1)


def method81(__unit: None=None) -> str:
    _v0: str | None = None
    _v0 = None
    if _v0 is None:
        raise Exception("base.run_target / _v0=None")

    else: 
        return _v0



def closure60(unit_var: None, unit_var_1: None) -> str:
    v4_1: US13 = method75(method51("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral")
    v13_1: US3
    if v4_1.tag == 0:
        v13_1 = US3(0, v4_1.fields[0])

    else: 
        def v9_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
            return closure62(None, None)

        def v10_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
            return closure63(v4_1.fields[0], None)

        method79(US0(3), v9_1, v10_1)
        v13_1 = US3(1)

    v29: US3
    if v13_1.tag == 0:
        v29 = US3(0, v13_1.fields[0])

    else: 
        v16_1: str = method81()
        v18_1: US13 = method75(method51("polyglot", ".devcontainer"), v16_1)
        if v18_1.tag == 0:
            v29 = US3(0, v18_1.fields[0])

        else: 
            def v23(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
                return closure62(None, None)

            def v24(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
                return closure63(v18_1.fields[0], None)

            method79(US0(3), v23, v24)
            v29 = US3(1)


    def _arrow289(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
        raise Exception("Option does not have a value.")

    return method51(v29.fields[0] if (v29.tag == 0) else _arrow289(), "polyglot")


def method82(v0_1: str) -> None:
    _v1: None | None = None
    _v1 = some(None)
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        value_3(_v1)



def closure66(unit_var: None, v0_1: str) -> None:
    method82(v0_1)


def closure65(unit_var: None, v0_1: bool) -> None:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    def _arrow290(v_1: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure66(None, v_1)

    def _arrow291(v_2: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure1(None, v_2)

    v10_1: Callable[[str], None] = _arrow290 if v0_1 else _arrow291
    pattern_input[1].l0 = v10_1


def closure68(v0_1: str, v1_1: str) -> str:
    return method51(v0_1, v1_1)


def closure67(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow292(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure68(v0_1, v)

    return _arrow292


def _arrow293(v: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
    return closure0(None, v)


v0: Callable[[US0], tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]] = _arrow293

v1: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v0(v1))


def _arrow294(v: str) -> Async[int64]:
    return closure2(None, v)


v2: Callable[[str], Async[int64]] = _arrow294

def delete_directory_async(x: str) -> Async[int64]:
    return v2(x)


def _arrow295(v: US6) -> Callable[[str], Async[int64]]:
    return closure6(None, v)


v3: Callable[[US6, str], Async[int64]] = _arrow295

def wait_for_file_access(x: US6) -> Callable[[str], Async[int64]]:
    return v3(x)


def _arrow296(v: str) -> Async[int64]:
    return closure11(None, v)


v4: Callable[[str], Async[int64]] = _arrow296

def wait_for_file_access_read(x: str) -> Async[int64]:
    return v4(x)


def _arrow297(v: str) -> Async[str]:
    return closure12(None, v)


v5: Callable[[str], Async[str]] = _arrow297

def read_all_text_async(x: str) -> Async[str]:
    return v5(x)


def _arrow298(v: str) -> Callable[[str], bool]:
    return closure13(None, v)


v6: Callable[[str, str], bool] = _arrow298

def file_exists_content(x: str) -> Callable[[str], bool]:
    return v6(x)


def _arrow299(v: str) -> Callable[[str], Async[None]]:
    return closure15(None, v)


v7: Callable[[str, str], Async[None]] = _arrow299

def write_all_text_async(x: str) -> Callable[[str], Async[None]]:
    return v7(x)


def _arrow300(v: str) -> Callable[[str], Async[None]]:
    return closure17(None, v)


v8: Callable[[str, str], Async[None]] = _arrow300

def write_all_text_exists(x: str) -> Callable[[str], Async[None]]:
    return v8(x)


def _arrow301(v: str) -> Async[int64]:
    return closure19(None, v)


v9: Callable[[str], Async[int64]] = _arrow301

def delete_file_async(x: str) -> Async[int64]:
    return v9(x)


def _arrow302(v: str) -> Callable[[str], Async[int64]]:
    return closure23(None, v)


v10: Callable[[str, str], Async[int64]] = _arrow302

def move_file_async(x: str) -> Callable[[str], Async[int64]]:
    return v10(x)


def _arrow303(v: str) -> Async[str | None]:
    return closure28(None, v)


v11: Callable[[str], Async[str | None]] = _arrow303

def read_all_text_retry_async(x: str) -> Async[str | None]:
    return v11(x)


def _arrow304(__unit: None=None) -> str:
    return closure40(None, None)


v12: Callable[[], str] = _arrow304

def create_temp_path(__unit: None=None) -> str:
    return v12(None)


def _arrow305(__unit: None=None) -> tuple[str, IDisposable]:
    return closure41(None, None)


v13: Callable[[], tuple[str, IDisposable]] = _arrow305

def create_temp_dir(__unit: None=None) -> tuple[str, IDisposable]:
    return v13(None)


def _arrow306(v: str) -> tuple[str, IDisposable]:
    return closure56(None, v)


v14: Callable[[str], tuple[str, IDisposable]] = _arrow306

def create_temp_dir_0027(x: str) -> tuple[str, IDisposable]:
    return v14(x)


def _arrow307(__unit: None=None) -> str:
    return closure57(None, None)


v15: Callable[[], str] = _arrow307

def get_source_directory(__unit: None=None) -> str:
    return v15(None)


def _arrow308(v: str) -> str:
    return closure58(None, v)


v16: Callable[[str], str] = _arrow308

def normalize_path(x: str) -> str:
    return v16(x)


def _arrow309(v: str) -> str:
    return closure59(None, v)


v17: Callable[[str], str] = _arrow309

def new_file_uri(x: str) -> str:
    return v17(x)


def _arrow310(__unit: None=None) -> str:
    return closure60(None, None)


v18: Callable[[], str] = _arrow310

def get_workspace_root(__unit: None=None) -> str:
    return v18(None)


def _arrow311(v: bool) -> None:
    closure65(None, v)


v19: Callable[[bool], None] = _arrow311

def init_trace_file(x: bool) -> None:
    v19(x)


def _arrow312(v: str) -> Callable[[str], str]:
    return closure67(None, v)


v20: Callable[[str, str], str] = _arrow312

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v20(x)


