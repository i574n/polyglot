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
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, int64_type, record_type, bool_type, string_type, unit_type, lambda_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, to_text, interpolate, replace)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds, to_string as to_string_1)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef, uint8)
from fable_modules.fable_library.util import (create_atom, IDisposable, to_enumerable, compare)

State_trace_state: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] | None = create_atom(None)

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


def _expr212() -> TypeInfo:
    return class_type("File_system.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr212

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


class IPathDirname(Protocol):
    @abstractmethod
    def dirname(self, path: str) -> str:
        ...


def _expr213() -> TypeInfo:
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


US0_reflection = _expr213

def _expr214() -> TypeInfo:
    return record_type("File_system.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr214

def _expr215() -> TypeInfo:
    return record_type("File_system.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr215

def _expr216() -> TypeInfo:
    return record_type("File_system.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr216

def _expr217() -> TypeInfo:
    return record_type("File_system.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr217

def _expr218() -> TypeInfo:
    return union_type("File_system.US1", [], US1, lambda: [[("f0_0", int64_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr218

def _expr219() -> TypeInfo:
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


US2_reflection = _expr219

def _expr220() -> TypeInfo:
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


US3_reflection = _expr220

def _expr221() -> TypeInfo:
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


US4_reflection = _expr221

def _expr222() -> TypeInfo:
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


US5_reflection = _expr222

def _expr223() -> TypeInfo:
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


US7_reflection = _expr223

def _expr224() -> TypeInfo:
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


US8_reflection = _expr224

def _expr225() -> TypeInfo:
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


US6_reflection = _expr225

def _expr226() -> TypeInfo:
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


US9_reflection = _expr226

def _expr227() -> TypeInfo:
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


US10_reflection = _expr227

def _expr228() -> TypeInfo:
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


US11_reflection = _expr228

def _expr229() -> TypeInfo:
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


US12_reflection = _expr229

def _expr230() -> TypeInfo:
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


US13_reflection = _expr230

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



def US4__get_IsUS4_2(this: FSharpRef[US4], unit_arg: None) -> bool:
    if this.tag == 2:
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



def US5__get_IsUS5_2(this: FSharpRef[US5], unit_arg: None) -> bool:
    if this.tag == 2:
        return True

    else: 
        return False



def US5__get_IsUS5_3(this: FSharpRef[US5], unit_arg: None) -> bool:
    if this.tag == 3:
        return True

    else: 
        return False



def US5__get_IsUS5_4(this: FSharpRef[US5], unit_arg: None) -> bool:
    if this.tag == 4:
        return True

    else: 
        return False



def US7__get_IsUS7_0(this: FSharpRef[US7], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US7__get_IsUS7_1(this: FSharpRef[US7], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US7__get_IsUS7_2(this: FSharpRef[US7], unit_arg: None) -> bool:
    if this.tag == 2:
        return True

    else: 
        return False



def US8__get_IsUS8_0(this: FSharpRef[US8], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US8__get_IsUS8_1(this: FSharpRef[US8], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US8__get_IsUS8_2(this: FSharpRef[US8], unit_arg: None) -> bool:
    if this.tag == 2:
        return True

    else: 
        return False



def US8__get_IsUS8_3(this: FSharpRef[US8], unit_arg: None) -> bool:
    if this.tag == 3:
        return True

    else: 
        return False



def US8__get_IsUS8_4(this: FSharpRef[US8], unit_arg: None) -> bool:
    if this.tag == 4:
        return True

    else: 
        return False



def US6__get_IsUS6_0(this: FSharpRef[US6], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US6__get_IsUS6_1(this: FSharpRef[US6], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US9__get_IsUS9_0(this: FSharpRef[US9], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US9__get_IsUS9_1(this: FSharpRef[US9], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US10__get_IsUS10_0(this: FSharpRef[US10], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US10__get_IsUS10_1(this: FSharpRef[US10], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US11__get_IsUS11_0(this: FSharpRef[US11], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US11__get_IsUS11_1(this: FSharpRef[US11], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US12__get_IsUS12_0(this: FSharpRef[US12], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US12__get_IsUS12_1(this: FSharpRef[US12], unit_arg: None) -> bool:
    if this.tag == 1:
        return True

    else: 
        return False



def US13__get_IsUS13_0(this: FSharpRef[US13], unit_arg: None) -> bool:
    if this.tag == 0:
        return True

    else: 
        return False



def US13__get_IsUS13_1(this: FSharpRef[US13], unit_arg: None) -> bool:
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



def closure5(unit_var: None, v0_1: str) -> str:
    return method8(v0_1)


def closure6(unit_var: None, unit_var_1: None) -> str:
    return ""


def closure4(v0_1: str, v1_1: str, unit_var: None) -> str:
    return ((((("path: " + closure5(None, v0_1)) + " / ex: ") + v1_1) + " / ") + closure6(None, None)) + ""


def method10(__unit: None=None) -> str:
    return "hh:mm:ss"


def method11(__unit: None=None) -> str:
    return ""


def method12(__unit: None=None) -> str:
    return "HH:mm:ss"


def method13(__unit: None=None) -> str:
    return "\u001b[0m"


def closure7(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_3(State_trace_state())
    v8_1: int64 | None = pattern_input[3]
    _v10: str | None = None
    _v96: FSharpRef[US1 | None] = FSharpRef(None)
    x_2: US1 | None
    if v8_1 is None:
        x_2 = None

    else: 
        x: int64 = v8_1
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US1:
            return US1(0, x)

        x_2 = x_1(None)

    _v96.contents = x_2
    v101: US1 = default_arg(_v96.contents, US1(1))
    def _arrow231(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v108: Any = create(op_subtraction(ticks_1(now()), v101.fields[0]))
        return create_1(1, 1, 1, hours(v108), minutes(v108), seconds(v108), milliseconds(v108))

    x_3: str = to_string(_arrow231() if (v101.tag == 0) else now(), method12())
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
    def _arrow232(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> str:
        raise Exception("base.run_target / _v216=None")

    return trim_end(trim_start(((((((((("" + v152) + " ") + (_arrow232() if (_v216 is None) else _v216)) + " #") + str(pattern_input[0].l0)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))


def method14(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(v: US0, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
        return closure0(None, v)

    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_3(State_trace_state())
    v4_1: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_3(State_trace_state())
    v15_1: US0 = pattern_input_1[2].l0
    class ObjectExpr233:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr234:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr233())) >= find(v15_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr234()))):
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

        pattern_input[4].l0(v24)



def method9(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure7(v0_1, v1_1, v2_1, None)

    method14(v0_1, v3_1)


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



def closure10(unit_var: None, unit_var_1: None) -> str:
    return "file_system.wait_for_file_access"


def closure11(v0_1: str, v1_1: int64, v2_1: str, unit_var: None) -> str:
    return ((((((("path: " + closure5(None, v0_1)) + " / retry: ") + str(v1_1)) + " / ex: ") + v2_1) + " / ") + closure6(None, None)) + ""


def method15(v0_1: str, v1_1: US8, v2_1: US7, v3_1: int64) -> Async[int64]:
    _v4: Async[int64] | None = None
    _v4 = None
    if _v4 is None:
        raise Exception("base.run_target / _v4=None")

    else: 
        return _v4



def closure9(v0_1: US6, v1_1: str) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure8(unit_var: None, v0_1: US6) -> Callable[[str], Async[int64]]:
    def _arrow235(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure9(v0_1, v)

    return _arrow235


def method16(v0_1: str, v1_1: int64) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure12(unit_var: None, v0_1: str) -> Async[int64]:
    _v1: Async[int64] | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def closure13(unit_var: None, v0_1: str) -> Async[str]:
    _v1: Async[str] | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method18(v0_1: str) -> bool:
    _v1: bool | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method19(v0_1: Vec_1[uint8]) -> Vec_1[uint8]:
    return v0_1


def method17(v0_1: str, v1_1: str) -> bool:
    _v2: bool | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure15(v0_1: str, v1_1: str) -> bool:
    return method17(v0_1, v1_1)


def closure14(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow236(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure15(v0_1, v)

    return _arrow236


def closure17(v0_1: str, v1_1: str) -> Async[None]:
    _v2: Async[None] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure16(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow237(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure17(v0_1, v)

    return _arrow237


def closure19(v0_1: str, v1_1: str) -> Async[None]:
    _v2: Async[None] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure18(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow238(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure19(v0_1, v)

    return _arrow238


def closure21(unit_var: None, unit_var_1: None) -> str:
    return "delete_file_async"


def closure22(v0_1: str, v1_1: Exception, unit_var: None) -> str:
    _v2: str | None = None
    x: str = to_text(interpolate("%A%P()", [v1_1]))
    _v2 = x
    v9_1: str
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        v9_1 = _v2

    return ((((("path: " + closure5(None, v0_1)) + " / ex: ") + v9_1) + " / ") + closure6(None, None)) + ""


def method20(v0_1: str, v1_1: int64) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure20(unit_var: None, v0_1: str) -> Async[int64]:
    _v1: Async[int64] | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def closure25(unit_var: None, unit_var_1: None) -> str:
    return "move_file_async"


def closure26(v0_1: str, v1_1: str, v2_1: Exception, unit_var: None) -> str:
    _v3: str | None = None
    x: str = to_text(interpolate("%A%P()", [v2_1]))
    _v3 = x
    v10_1: str
    if _v3 is None:
        raise Exception("base.run_target / _v3=None")

    else: 
        v10_1 = _v3

    def v11_1(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> str:
        return closure5(None, v)

    return ((((((("old_path: " + v11_1(v1_1)) + " / new_path: ") + v11_1(v0_1)) + " / ex: ") + v10_1) + " / ") + closure6(None, None)) + ""


def method21(v0_1: str, v1_1: str, v2_1: int64) -> Async[int64]:
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
    def _arrow239(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure24(v0_1, v)

    return _arrow239


def closure28(unit_var: None, v0_1: int64) -> US9:
    return US9(0, v0_1)


def closure29(unit_var: None, v0_1: Exception) -> US9:
    return US9(1, v0_1)


def closure30(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async"


def closure31(unit_var: None, unit_var_1: None) -> str:
    return ((("timeout: " + str(1000)) + " / ") + closure6(None, None)) + ""


def closure32(v0_1: str, unit_var: None) -> str:
    return ("async.run_with_timeout_async** / ex: " + v0_1) + ""


def closure33(unit_var: None, unit_var_1: None) -> str:
    return "read_all_text_retry_async"


def method23(v0_1: int64, v1_1: str) -> str:
    return ((((("retry: " + str(v0_1)) + " / ex: ") + v1_1) + " / ") + closure6(None, None)) + ""


def closure34(v0_1: int64, v1_1: str, unit_var: None) -> str:
    return method23(v0_1, v1_1)


def method22(v0_1: str, v1_1: int64) -> Async[str | None]:
    _v2: Async[str | None] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure27(unit_var: None, v0_1: str) -> Async[str | None]:
    _v1: Async[str | None] | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method26(v0_1: chrono_DateTime_1[chrono_Utc]) -> chrono_DateTime_1[chrono_Utc]:
    return v0_1


def method27(v0_1: chrono_DateTime_1[chrono_Local]) -> chrono_DateTime_1[chrono_Local]:
    return v0_1


def method28(__unit: None=None) -> str:
    return "hh:mm"


def method29(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method30(__unit: None=None) -> str:
    return "hhmm"


def method25(v0_1: str, v1_1: Any) -> str:
    _v2: str | None = None
    v259: str = to_string(v1_1, method29())
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
    v301: str = method30()
    _v302: str | None = None
    x_4: str = to_string_1(v296, "c", {})
    _v302 = x_4
    def _arrow240(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        raise Exception("base.run_target / _v302=None")

    v310: str = ((("" + str(v300)) + "") + (_arrow240() if (_v302 is None) else _v302)) + ""
    v312: str = str(v0_1)
    x_6: str = parse(((((("" + v259) + "") + v310) + "") + v312[len(v259) + len(v310):len(v312)]) + "")
    _v2 = x_6
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def method32(__unit: None=None) -> str:
    _v0: str | None = None
    x: str
    raise Exception(("file_system.get_temp_path / target: " + str(US5(4, US4(0)))) + "")
    _v0 = x
    if _v0 is None:
        raise Exception("base.run_target / _v0=None")

    else: 
        return _v0



def method33(__unit: None=None) -> str:
    return "!create_temp_path_"


def method36(v0_1: str) -> str:
    return v0_1


def method35(v0_1: str, v1_1: str) -> tuple[str, str]:
    return (v1_1, method36(v0_1))


def method34(v0_1: str, v1_1: str) -> str:
    _v2: str | None = None
    x: str
    raise Exception(((((("file_system.(</>) / target: " + str(US5(4, US4(0)))) + " / a: ") + v0_1) + " / b: ") + v1_1) + "")
    _v2 = x
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def method38(__unit: None=None) -> str:
    return "CARGO_PKG_NAME"


def method37(__unit: None=None) -> str:
    _v0: str | None = None
    x: str
    raise Exception(("env.get_entry_assembly_name / target: " + str(US5(4, US4(0)))) + "")
    _v0 = x
    if _v0 is None:
        raise Exception("base.run_target / _v0=None")

    else: 
        return _v0



def method31(v0_1: str) -> str:
    _v1: str | None = None
    x: str = method34(method34(method34(method32(), method33()), method37()), str(v0_1))
    _v1 = x
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method24(__unit: None=None) -> str:
    _v0: str | None = None
    v17_1: Any = now()
    x: str = method31(method25(new_guid(), v17_1))
    _v0 = x
    if _v0 is None:
        raise Exception("base.run_target / _v0=None")

    else: 
        return _v0



def closure35(unit_var: None, unit_var_1: None) -> str:
    return method24()


def method40(v0_1: str) -> str:
    return v0_1


def closure37(unit_var: None, v0_1: std_io_Error) -> std_string_String:
    _v1: std_string_String | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method41(__unit: None=None) -> Callable[[std_io_Error], std_string_String]:
    def _arrow241(v: std_io_Error) -> std_string_String:
        return closure37(None, v)

    return _arrow241


def closure38(unit_var: None, unit_var_1: None) -> US12:
    return US12(0)


def closure39(unit_var: None, v0_1: std_string_String) -> US12:
    return US12(1, v0_1)


def closure40(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_dir"


def closure41(v0_1: str, v1_1: std_string_String, unit_var: None) -> str:
    return ((((("dir: " + v0_1) + " / error: ") + str(v1_1)) + " / ") + closure6(None, None)) + ""


def closure42(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_dir"


def closure43(v0_1: str, unit_var: None) -> str:
    return ((("dir: " + v0_1) + " / ") + closure6(None, None)) + ""


def closure44(v0_1: str, unit_var: None) -> None:
    method5(True, v0_1)


def method42(v0_1: str) -> Callable[[], None]:
    def _arrow242(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure44(v0_1, None)

    return _arrow242


def method43(v0_1: str) -> Callable[[], None]:
    def _arrow243(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure44(v0_1, None)

    return _arrow243


def closure45(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_dir"


def closure46(v0_1: str, v1_1: str, unit_var: None) -> str:
    return ((((("dir: " + v0_1) + " / result: ") + v1_1) + " ") + closure6(None, None)) + ""


def closure47(v0_1: str, unit_var: None) -> None:
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



def method44(v0_1: str) -> Callable[[], None]:
    def _arrow244(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure47(v0_1, None)

    return _arrow244


def method45(v0_1: str) -> Callable[[], None]:
    def _arrow245(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure47(v0_1, None)

    return _arrow245


def method39(v0_1: str) -> IDisposable:
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
        def _arrow246(__unit: None=None, v0_1: Any=v0_1) -> Any:
            raise Exception("base.run_target / _v97=None")

        v106: str = to_text(interpolate("%A%P()", [{
            "CreationTime": _arrow246() if (_v97 is None) else _v97,
            "Exists": v95
        }]))
        def v108(__unit: None=None, v0_1: Any=v0_1) -> str:
            return closure45(None, None)

        def v109(__unit: None=None, v0_1: Any=v0_1) -> str:
            return closure46(v0_1, v106, None)

        method9(US0(1), v108, v109)

    _v110: IDisposable | None = None
    v119: Callable[[], None] = method45(v0_1)
    class ObjectExpr247(IDisposable):
        def Dispose(self, __unit: None=None, v0_1: Any=v0_1) -> None:
            v119(None)

    x_6: IDisposable = ObjectExpr247()
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



def closure36(unit_var: None, unit_var_1: None) -> tuple[str, IDisposable]:
    v0_1: str = method24()
    return (v0_1, method39(v0_1))


def method46(v0_1: str) -> str:
    _v1: str | None = None
    v9_1: str = pad_left(v0_1, 32, "0")
    x: str = parse(((((((((("" + v9_1[0:7 + 1]) + "-") + v9_1[8:11 + 1]) + "-") + v9_1[12:15 + 1]) + "-") + v9_1[16:19 + 1]) + "-") + v9_1[20:31 + 1]) + "")
    _v1 = x
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def closure48(unit_var: None, v0_1: str) -> tuple[str, IDisposable]:
    v2_1: str = method31(method46(v0_1))
    return (v2_1, method39(v2_1))


def closure49(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def method48(__unit: None=None) -> str:
    return ""


def method49(v0_1: str) -> str:
    return v0_1


def method50(__unit: None=None) -> str:
    return "^\\\\\\\\\\?\\\\"


def method47(v0_1: str) -> str:
    v1_1: str = method48()
    _v2: str | None = None
    _v2 = None
    v21: str
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        v21 = _v2

    def _arrow248(__unit: None=None, v0_1: Any=v0_1) -> str:
        _arg: str = v21[0]
        return _arg.lower()

    return replace(((("" + _arrow248()) + "") + v21[1:len(v21)]) + "", "\\", "/")


def closure50(unit_var: None, v0_1: str) -> str:
    return method47(v0_1)


def closure51(unit_var: None, v0_1: str) -> str:
    return ("file:///" + trim_start(v0_1, *to_array(singleton("/")))) + ""


def method53(v0_1: str) -> str | None:
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



def closure53(unit_var: None, v0_1: str) -> str | None:
    return method53(v0_1)


def method52(__unit: None=None) -> Callable[[str], str | None]:
    def _arrow249(v: str) -> str | None:
        return closure53(None, v)

    return _arrow249


def method54(v0_1_mut: str, v1_1_mut: str, v2_1_mut: str) -> US13:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if method7(method34(v2_1, v0_1)):
            return US13(0, v2_1)

        else: 
            v7_1: str | None = method52()(v2_1)
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


def method51(v0_1: str, v1_1: str) -> US13:
    if method7(method34(v1_1, v0_1)):
        return US13(0, v1_1)

    else: 
        v6_1: str | None = method52()(v1_1)
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
            return method54(v0_1, v1_1, v12_1.fields[0])

        else: 
            return US13(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v1_1) + "\')")




def closure54(unit_var: None, unit_var_1: None) -> str:
    return "file_system.get_workspace_root"


def closure55(v0_1: str, unit_var: None) -> str:
    return ((("error: " + v0_1) + " / ") + closure6(None, None)) + ""


def method55(__unit: None=None) -> str:
    _v0: str | None = None
    _v0 = None
    if _v0 is None:
        raise Exception("base.run_target / _v0=None")

    else: 
        return _v0



def closure52(unit_var: None, unit_var_1: None) -> str:
    v4_1: US13 = method51(method34("polyglot", ".paket"), "C:\\home\\git\\polyglot\\lib\\spiral")
    v13_1: US3
    if v4_1.tag == 0:
        v13_1 = US3(0, v4_1.fields[0])

    else: 
        def v9_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
            return closure54(None, None)

        def v10_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
            return closure55(v4_1.fields[0], None)

        method9(US0(3), v9_1, v10_1)
        v13_1 = US3(1)

    v29: US3
    if v13_1.tag == 0:
        v29 = US3(0, v13_1.fields[0])

    else: 
        v16_1: str = method55()
        v18_1: US13 = method51(method34("polyglot", ".paket"), v16_1)
        if v18_1.tag == 0:
            v29 = US3(0, v18_1.fields[0])

        else: 
            def v23(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
                return closure54(None, None)

            def v24(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
                return closure55(v18_1.fields[0], None)

            method9(US0(3), v23, v24)
            v29 = US3(1)


    def _arrow250(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
        raise Exception("Option does not have a value.")

    return method34(v29.fields[0] if (v29.tag == 0) else _arrow250(), "polyglot")


def method56(v0_1: str) -> None:
    _v1: None | None = None
    _v1 = some(None)
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        value_3(_v1)



def closure57(unit_var: None, v0_1: str) -> None:
    method56(v0_1)


def closure56(unit_var: None, v0_1: bool) -> None:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_3(State_trace_state())
    def _arrow251(v_1: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure57(None, v_1)

    def _arrow252(v_2: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure1(None, v_2)

    v10_1: Callable[[str], None] = _arrow251 if v0_1 else _arrow252
    pattern_input[4].l0 = v10_1


def closure59(v0_1: str, v1_1: str) -> str:
    return method34(v0_1, v1_1)


def closure58(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow253(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure59(v0_1, v)

    return _arrow253


def _arrow254(v: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, v)


v0: Callable[[US0], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow254

v1: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v0(v1))


def _arrow255(v: str) -> Async[int64]:
    return closure2(None, v)


v2: Callable[[str], Async[int64]] = _arrow255

def delete_directory_async(x: str) -> Async[int64]:
    return v2(x)


def _arrow256(v: US6) -> Callable[[str], Async[int64]]:
    return closure8(None, v)


v3: Callable[[US6, str], Async[int64]] = _arrow256

def wait_for_file_access(x: US6) -> Callable[[str], Async[int64]]:
    return v3(x)


def _arrow257(v: str) -> Async[int64]:
    return closure12(None, v)


v4: Callable[[str], Async[int64]] = _arrow257

def wait_for_file_access_read(x: str) -> Async[int64]:
    return v4(x)


def _arrow258(v: str) -> Async[str]:
    return closure13(None, v)


v5: Callable[[str], Async[str]] = _arrow258

def read_all_text_async(x: str) -> Async[str]:
    return v5(x)


def _arrow259(v: str) -> Callable[[str], bool]:
    return closure14(None, v)


v6: Callable[[str, str], bool] = _arrow259

def file_exists_content(x: str) -> Callable[[str], bool]:
    return v6(x)


def _arrow260(v: str) -> Callable[[str], Async[None]]:
    return closure16(None, v)


v7: Callable[[str, str], Async[None]] = _arrow260

def write_all_text_async(x: str) -> Callable[[str], Async[None]]:
    return v7(x)


def _arrow261(v: str) -> Callable[[str], Async[None]]:
    return closure18(None, v)


v8: Callable[[str, str], Async[None]] = _arrow261

def write_all_text_exists(x: str) -> Callable[[str], Async[None]]:
    return v8(x)


def _arrow262(v: str) -> Async[int64]:
    return closure20(None, v)


v9: Callable[[str], Async[int64]] = _arrow262

def delete_file_async(x: str) -> Async[int64]:
    return v9(x)


def _arrow263(v: str) -> Callable[[str], Async[int64]]:
    return closure23(None, v)


v10: Callable[[str, str], Async[int64]] = _arrow263

def move_file_async(x: str) -> Callable[[str], Async[int64]]:
    return v10(x)


def _arrow264(v: str) -> Async[str | None]:
    return closure27(None, v)


v11: Callable[[str], Async[str | None]] = _arrow264

def read_all_text_retry_async(x: str) -> Async[str | None]:
    return v11(x)


def _arrow265(__unit: None=None) -> str:
    return closure35(None, None)


v12: Callable[[], str] = _arrow265

def create_temp_path(__unit: None=None) -> str:
    return v12(None)


def _arrow266(__unit: None=None) -> tuple[str, IDisposable]:
    return closure36(None, None)


v13: Callable[[], tuple[str, IDisposable]] = _arrow266

def create_temp_dir(__unit: None=None) -> tuple[str, IDisposable]:
    return v13(None)


def _arrow267(v: str) -> tuple[str, IDisposable]:
    return closure48(None, v)


v14: Callable[[str], tuple[str, IDisposable]] = _arrow267

def create_temp_dir_0027(x: str) -> tuple[str, IDisposable]:
    return v14(x)


def _arrow268(__unit: None=None) -> str:
    return closure49(None, None)


v15: Callable[[], str] = _arrow268

def get_source_directory(__unit: None=None) -> str:
    return v15(None)


def _arrow269(v: str) -> str:
    return closure50(None, v)


v16: Callable[[str], str] = _arrow269

def normalize_path(x: str) -> str:
    return v16(x)


def _arrow270(v: str) -> str:
    return closure51(None, v)


v17: Callable[[str], str] = _arrow270

def new_file_uri(x: str) -> str:
    return v17(x)


def _arrow271(__unit: None=None) -> str:
    return closure52(None, None)


v18: Callable[[], str] = _arrow271

def get_workspace_root(__unit: None=None) -> str:
    return v18(None)


def _arrow272(v: bool) -> None:
    closure56(None, v)


v19: Callable[[bool], None] = _arrow272

def init_trace_file(x: bool) -> None:
    v19(x)


def _arrow273(v: str) -> Callable[[str], str]:
    return closure58(None, v)


v20: Callable[[str, str], str] = _arrow273

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v20(x)


