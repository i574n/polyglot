from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.async_builder import Async
from fable_modules.fable_library.date import (ticks as ticks_1, now, to_string, create as create_1)
from fable_modules.fable_library.guid import (parse, new_guid)
from fable_modules.fable_library.long import (op_subtraction, op_addition)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_4, default_arg)
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


def _expr209() -> TypeInfo:
    return class_type("File_system.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr209

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


class IPathDirname(Protocol):
    @abstractmethod
    def dirname(self, path: str) -> str:
        ...


def _expr210() -> TypeInfo:
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


US0_reflection = _expr210

def _expr211() -> TypeInfo:
    return record_type("File_system.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr211

def _expr212() -> TypeInfo:
    return record_type("File_system.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr212

def _expr213() -> TypeInfo:
    return record_type("File_system.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr213

def _expr214() -> TypeInfo:
    return record_type("File_system.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr214

def _expr215() -> TypeInfo:
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


US1_reflection = _expr215

def _expr216() -> TypeInfo:
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


US2_reflection = _expr216

def _expr217() -> TypeInfo:
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


US3_reflection = _expr217

def _expr218() -> TypeInfo:
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


US4_reflection = _expr218

def _expr219() -> TypeInfo:
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


US5_reflection = _expr219

def _expr220() -> TypeInfo:
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


US7_reflection = _expr220

def _expr221() -> TypeInfo:
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


US8_reflection = _expr221

def _expr222() -> TypeInfo:
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


US6_reflection = _expr222

def _expr223() -> TypeInfo:
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


US9_reflection = _expr223

def _expr224() -> TypeInfo:
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


US10_reflection = _expr224

def _expr225() -> TypeInfo:
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


US11_reflection = _expr225

def _expr226() -> TypeInfo:
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


US12_reflection = _expr226

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



def method0(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method2(__unit: None=None) -> str:
    return ""


def method1(v0_1: str) -> str:
    _v1: str | None = None
    v50: IOsEnviron = os
    v52: Any = v50.environ
    x: str = v52.get(v0_1)
    _v1 = x
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
        value_4(_v2)



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


def closure7(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_4(State_trace_state())
    v8_1: int64 | None = pattern_input[3]
    _v10: str | None = None
    _v93: FSharpRef[US1 | None] = FSharpRef(None)
    x_2: US1 | None
    if v8_1 is None:
        x_2 = None

    else: 
        x: int64 = v8_1
        def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> US1:
            return US1(0, x)

        x_2 = x_1(None)

    _v93.contents = x_2
    v98: US1 = default_arg(_v93.contents, US1(1))
    def _arrow227(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
        v105: Any = create(op_subtraction(ticks_1(now()), v98.fields[0]))
        return create_1(1, 1, 1, hours(v105), minutes(v105), seconds(v105), milliseconds(v105))

    x_3: str = to_string(_arrow227() if (v98.tag == 0) else now(), method12())
    _v10 = x_3
    v147: str
    if _v10 is None:
        raise Exception("base.run_target / _v10=None")

    else: 
        v147 = _v10

    v154: US3 = US3(0, "Verbose") if (True if (v0_1.tag == 0) else False) else US3(1)
    v203: US3
    if v154.tag == 0:
        v203 = US3(0, v154.fields[0])

    else: 
        v163: US3 = US3(0, "Debug") if (True if (v0_1.tag == 1) else False) else US3(1)
        if v163.tag == 0:
            v203 = US3(0, v163.fields[0])

        else: 
            v172: US3 = US3(0, "Info") if (True if (v0_1.tag == 2) else False) else US3(1)
            if v172.tag == 0:
                v203 = US3(0, v172.fields[0])

            else: 
                v181: US3 = US3(0, "Warning") if (True if (v0_1.tag == 3) else False) else US3(1)
                if v181.tag == 0:
                    v203 = US3(0, v181.fields[0])

                else: 
                    v190: US3 = US3(0, "Critical") if (True if (v0_1.tag == 4) else False) else US3(1)
                    v203 = US3(0, v190.fields[0]) if (v190.tag == 0) else US3(1)




    v207: str
    if v203.tag == 0:
        v207 = v203.fields[0]

    else: 
        raise Exception("Option does not have a value.")

    _v211: str | None = None
    x_5: str = pad_left(v207.lower(), 7, " ")
    _v211 = x_5
    def _arrow228(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> str:
        raise Exception("base.run_target / _v211=None")

    return trim_end(trim_start(((((((((("" + v147) + " ") + (_arrow228() if (_v211 is None) else _v211)) + " #") + str(pattern_input[0].l0)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method13(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(v: US0, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
        return closure0(None, v)

    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_4(State_trace_state())
    v4_1: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(US0(0)))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_4(State_trace_state())
    v15_1: US0 = pattern_input_1[2].l0
    class ObjectExpr229:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr230:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr229())) >= find(v15_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr230()))):
        v23: int64 = op_addition(v4_1.l0, int64(1))
        v4_1.l0 = v23
        v24: str = ("" + v1_1(None)) + ""
        _v25: None | None = None
        print(v24)
        _v25 = some(None)
        if _v25 is None:
            raise Exception("base.run_target / _v25=None")

        else: 
            value_4(_v25)

        pattern_input[4].l0(v24)



def method9(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure7(v0_1, v1_1, v2_1, None)

    method13(v0_1, v3_1)


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


def method14(v0_1: str, v1_1: US8, v2_1: US7, v3_1: int64) -> Async[int64]:
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
    def _arrow231(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure9(v0_1, v)

    return _arrow231


def method15(v0_1: str, v1_1: int64) -> Async[int64]:
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



def method16(v0_1: str) -> bool:
    _v1: bool | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def closure15(v0_1: str, v1_1: str) -> Async[bool]:
    _v2: Async[bool] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure14(unit_var: None, v0_1: str) -> Callable[[str], Async[bool]]:
    def _arrow232(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[bool]:
        return closure15(v0_1, v)

    return _arrow232


def closure17(v0_1: str, v1_1: str) -> Async[None]:
    _v2: Async[None] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure16(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow233(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure17(v0_1, v)

    return _arrow233


def closure19(v0_1: str, v1_1: str) -> Async[None]:
    _v2: Async[None] | None = None
    _v2 = None
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def closure18(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow234(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure19(v0_1, v)

    return _arrow234


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


def method17(v0_1: str, v1_1: int64) -> Async[int64]:
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


def method18(v0_1: str, v1_1: str, v2_1: int64) -> Async[int64]:
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
    def _arrow235(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure24(v0_1, v)

    return _arrow235


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


def method20(v0_1: int64, v1_1: str) -> str:
    return ((((("retry: " + str(v0_1)) + " / ex: ") + v1_1) + " / ") + closure6(None, None)) + ""


def closure34(v0_1: int64, v1_1: str, unit_var: None) -> str:
    return method20(v0_1, v1_1)


def method19(v0_1: str, v1_1: int64) -> Async[str | None]:
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



def method23(v0_1: chrono_DateTime_1[chrono_Utc]) -> chrono_DateTime_1[chrono_Utc]:
    return v0_1


def method24(v0_1: chrono_DateTime_1[chrono_Local]) -> chrono_DateTime_1[chrono_Local]:
    return v0_1


def method25(__unit: None=None) -> str:
    return "hh:mm"


def method26(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method27(__unit: None=None) -> str:
    return "hhmm"


def method22(v0_1: str, v1_1: Any) -> str:
    _v2: str | None = None
    v259: str = to_string(v1_1, method26())
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
    v301: str = method27()
    _v302: str | None = None
    x_4: str = to_string_1(v296, "c", {})
    _v302 = x_4
    def _arrow236(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        raise Exception("base.run_target / _v302=None")

    v310: str = ((("" + str(v300)) + "") + (_arrow236() if (_v302 is None) else _v302)) + ""
    v312: str = str(v0_1)
    x_6: str = parse(((((("" + v259) + "") + v310) + "") + v312[len(v259) + len(v310):len(v312)]) + "")
    _v2 = x_6
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def method29(__unit: None=None) -> str:
    _v0: str | None = None
    x: str
    raise Exception(("file_system.get_temp_path / target: " + str(US5(4, US4(0)))) + "")
    _v0 = x
    if _v0 is None:
        raise Exception("base.run_target / _v0=None")

    else: 
        return _v0



def method30(__unit: None=None) -> str:
    return "!create_temp_path_"


def method33(v0_1: str) -> str:
    return v0_1


def method32(v0_1: str, v1_1: str) -> tuple[str, str]:
    return (v1_1, method33(v0_1))


def method31(v0_1: str, v1_1: str) -> str:
    _v2: str | None = None
    x: str
    raise Exception(((((("file_system.(</>) / target: " + str(US5(4, US4(0)))) + " / a: ") + v0_1) + " / b: ") + v1_1) + "")
    _v2 = x
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        return _v2



def method35(__unit: None=None) -> str:
    return "CARGO_PKG_NAME"


def method34(__unit: None=None) -> str:
    _v0: str | None = None
    x: str
    raise Exception(("env.get_entry_assembly_name / target: " + str(US5(4, US4(0)))) + "")
    _v0 = x
    if _v0 is None:
        raise Exception("base.run_target / _v0=None")

    else: 
        return _v0



def method28(v0_1: str) -> str:
    _v1: str | None = None
    x: str = method31(method31(method31(method29(), method30()), method34()), str(v0_1))
    _v1 = x
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method21(__unit: None=None) -> str:
    _v0: str | None = None
    v17_1: Any = now()
    x: str = method28(method22(new_guid(), v17_1))
    _v0 = x
    if _v0 is None:
        raise Exception("base.run_target / _v0=None")

    else: 
        return _v0



def closure35(unit_var: None, unit_var_1: None) -> str:
    return method21()


def method37(v0_1: str) -> str:
    return v0_1


def closure37(unit_var: None, v0_1: std_io_Error) -> std_string_String:
    _v1: std_string_String | None = None
    _v1 = None
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def method38(__unit: None=None) -> Callable[[std_io_Error], std_string_String]:
    def _arrow237(v: std_io_Error) -> std_string_String:
        return closure37(None, v)

    return _arrow237


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


def method39(v0_1: str) -> Callable[[], None]:
    def _arrow238(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure44(v0_1, None)

    return _arrow238


def method40(v0_1: str) -> Callable[[], None]:
    def _arrow239(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure44(v0_1, None)

    return _arrow239


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
        value_4(_v19)



def method41(v0_1: str) -> Callable[[], None]:
    def _arrow240(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure47(v0_1, None)

    return _arrow240


def method42(v0_1: str) -> Callable[[], None]:
    def _arrow241(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure47(v0_1, None)

    return _arrow241


def method36(v0_1: str) -> IDisposable:
    _v1: IDisposable | None = None
    _v75: Any | None = None
    _v75 = None
    v83: Any
    if _v75 is None:
        raise Exception("base.run_target / _v75=None")

    else: 
        v83 = _v75

    _v84: bool | None = None
    _v84 = None
    v91: bool
    if _v84 is None:
        raise Exception("base.run_target / _v84=None")

    else: 
        v91 = _v84

    if v91 == False:
        _v93: Any | None = None
        _v93 = None
        def _arrow242(__unit: None=None, v0_1: Any=v0_1) -> Any:
            raise Exception("base.run_target / _v93=None")

        v102: str = to_text(interpolate("%A%P()", [{
            "CreationTime": _arrow242() if (_v93 is None) else _v93,
            "Exists": v91
        }]))
        def v104(__unit: None=None, v0_1: Any=v0_1) -> str:
            return closure45(None, None)

        def v105(__unit: None=None, v0_1: Any=v0_1) -> str:
            return closure46(v0_1, v102, None)

        method9(US0(1), v104, v105)

    _v106: IDisposable | None = None
    _v106 = None
    x_8: IDisposable
    if _v106 is None:
        raise Exception("base.run_target / _v106=None")

    else: 
        x_8 = _v106

    _v1 = x_8
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def closure36(unit_var: None, unit_var_1: None) -> tuple[str, IDisposable]:
    v0_1: str = method21()
    return (v0_1, method36(v0_1))


def method43(v0_1: str) -> str:
    _v1: str | None = None
    v9_1: str = pad_left(v0_1, 32, "0")
    x: str = parse(((((((((("" + v9_1[0:7 + 1]) + "-") + v9_1[8:11 + 1]) + "-") + v9_1[12:15 + 1]) + "-") + v9_1[16:19 + 1]) + "-") + v9_1[20:31 + 1]) + "")
    _v1 = x
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        return _v1



def closure48(unit_var: None, v0_1: str) -> tuple[str, IDisposable]:
    v2_1: str = method28(method43(v0_1))
    return (v2_1, method36(v2_1))


def closure49(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def closure53(unit_var: None, v0_1: str) -> bool:
    return method16(v0_1)


def closure54(unit_var: None, v0_1: str) -> bool:
    return method7(v0_1)


def method46(v0_1: str) -> str | None:
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



def closure55(unit_var: None, v0_1: str) -> str | None:
    return method46(v0_1)


def method45(__unit: None=None) -> Callable[[str], str | None]:
    def _arrow244(v: str) -> str | None:
        return closure55(None, v)

    return _arrow244


def method47(v0_1_mut: str, v1_1_mut: bool, v2_1_mut: str, v3_1_mut: str) -> str:
    while True:
        (v0_1, v1_1, v2_1, v3_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut)
        def _arrow245(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1) -> bool:
            return closure53(None, v)

        def _arrow246(v_1: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1) -> bool:
            return closure54(None, v_1)

        if (_arrow245 if v1_1 else _arrow246)(method31(v3_1, v0_1)):
            return v3_1

        else: 
            v10_1: str | None = method45()(v3_1)
            _v11: FSharpRef[US3 | None] = FSharpRef(None)
            x_2: US3 | None
            if v10_1 is None:
                x_2 = None

            else: 
                x: str = v10_1
                def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1) -> US3:
                    return US3(0, x)

                x_2 = x_1(None)

            _v11.contents = x_2
            v16_1: US3 = default_arg(_v11.contents, US3(1))
            if v16_1.tag == 0:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v16_1.fields[0]
                continue

            else: 
                raise Exception(((((((("No parent for " + ("file" if v1_1 else "dir")) + " \'") + v0_1) + "\' at \'") + v2_1) + "\' (until \'") + v3_1) + "\')")


        break


def method44(v0_1: str, v1_1: bool, v2_1: str) -> str:
    def _arrow247(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> bool:
        return closure53(None, v)

    def _arrow248(v_1: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> bool:
        return closure54(None, v_1)

    if (_arrow247 if v1_1 else _arrow248)(method31(v2_1, v0_1)):
        return v2_1

    else: 
        v9_1: str | None = method45()(v2_1)
        _v10: FSharpRef[US3 | None] = FSharpRef(None)
        x_2: US3 | None
        if v9_1 is None:
            x_2 = None

        else: 
            x: str = v9_1
            def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> US3:
                return US3(0, x)

            x_2 = x_1(None)

        _v10.contents = x_2
        v15_1: US3 = default_arg(_v10.contents, US3(1))
        if v15_1.tag == 0:
            return method47(v0_1, v1_1, v2_1, v15_1.fields[0])

        else: 
            raise Exception(((((((("No parent for " + ("file" if v1_1 else "dir")) + " \'") + v0_1) + "\' at \'") + v2_1) + "\' (until \'") + v2_1) + "\')")




def closure52(v0_1: str, v1_1: bool, v2_1: str) -> str:
    return method44(v0_1, v1_1, v2_1)


def closure51(v0_1: str, v1_1: bool) -> Callable[[str], str]:
    def _arrow249(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure52(v0_1, v1_1, v)

    return _arrow249


def closure50(unit_var: None, v0_1: str) -> Callable[[bool, str], str]:
    def _arrow250(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure51(v0_1, v)

    return _arrow250


def method49(__unit: None=None) -> str:
    return ""


def method50(v0_1: str) -> str:
    return v0_1


def method51(__unit: None=None) -> str:
    return "^\\\\\\\\\\?\\\\"


def method48(v0_1: str) -> str:
    v1_1: str = method49()
    _v2: str | None = None
    _v2 = None
    v21_1: str
    if _v2 is None:
        raise Exception("base.run_target / _v2=None")

    else: 
        v21_1 = _v2

    def _arrow251(__unit: None=None, v0_1: Any=v0_1) -> str:
        _arg: str = v21_1[0]
        return _arg.lower()

    return replace(((("" + _arrow251()) + "") + v21_1[1:len(v21_1)]) + "", "\\", "/")


def closure56(unit_var: None, v0_1: str) -> str:
    return method48(v0_1)


def closure57(unit_var: None, v0_1: str) -> str:
    return ("file:///" + trim_start(v0_1, "/")) + ""


def method53(v0_1_mut: str, v1_1_mut: str, v2_1_mut: str) -> str:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if method7(method31(v2_1, v0_1)):
            return v2_1

        else: 
            v6_1: str | None = method45()(v2_1)
            _v7: FSharpRef[US3 | None] = FSharpRef(None)
            x_2: US3 | None
            if v6_1 is None:
                x_2 = None

            else: 
                x: str = v6_1
                def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> US3:
                    return US3(0, x)

                x_2 = x_1(None)

            _v7.contents = x_2
            v12_1: US3 = default_arg(_v7.contents, US3(1))
            if v12_1.tag == 0:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v12_1.fields[0]
                continue

            else: 
                raise Exception(((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v2_1) + "\')")


        break


def method52(v0_1: str, v1_1: str) -> str:
    if method7(method31(v1_1, v0_1)):
        return v1_1

    else: 
        v5_1: str | None = method45()(v1_1)
        _v6: FSharpRef[US3 | None] = FSharpRef(None)
        x_2: US3 | None
        if v5_1 is None:
            x_2 = None

        else: 
            x: str = v5_1
            def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> US3:
                return US3(0, x)

            x_2 = x_1(None)

        _v6.contents = x_2
        v11_1: US3 = default_arg(_v6.contents, US3(1))
        if v11_1.tag == 0:
            return method53(v0_1, v1_1, v11_1.fields[0])

        else: 
            raise Exception(((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v1_1) + "\')")




def closure58(unit_var: None, unit_var_1: None) -> str:
    return method31(method52(method31("polyglot", ".paket"), "C:\\home\\git\\polyglot\\lib\\spiral"), "polyglot")


def method54(v0_1: str) -> None:
    _v1: None | None = None
    _v1 = some(None)
    if _v1 is None:
        raise Exception("base.run_target / _v1=None")

    else: 
        value_4(_v1)



def closure60(unit_var: None, v0_1: str) -> None:
    method54(v0_1)


def closure59(unit_var: None, v0_1: bool) -> None:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_4(State_trace_state())
    def _arrow253(v_1: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure60(None, v_1)

    def _arrow254(v_2: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure1(None, v_2)

    v10_1: Callable[[str], None] = _arrow253 if v0_1 else _arrow254
    pattern_input[4].l0 = v10_1


def closure62(v0_1: str, v1_1: str) -> str:
    return method31(v0_1, v1_1)


def closure61(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow256(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure62(v0_1, v)

    return _arrow256


def _arrow258(v: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, v)


v0: Callable[[US0], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow258

v1: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v0(v1))


def _arrow262(v: str) -> Async[int64]:
    return closure2(None, v)


v2: Callable[[str], Async[int64]] = _arrow262

def delete_directory_async(x: str) -> Async[int64]:
    return v2(x)


def _arrow265(v: US6) -> Callable[[str], Async[int64]]:
    return closure8(None, v)


v3: Callable[[US6, str], Async[int64]] = _arrow265

def wait_for_file_access(x: US6) -> Callable[[str], Async[int64]]:
    return v3(x)


def _arrow266(v: str) -> Async[int64]:
    return closure12(None, v)


v4: Callable[[str], Async[int64]] = _arrow266

def wait_for_file_access_read(x: str) -> Async[int64]:
    return v4(x)


def _arrow267(v: str) -> Async[str]:
    return closure13(None, v)


v5: Callable[[str], Async[str]] = _arrow267

def read_all_text_async(x: str) -> Async[str]:
    return v5(x)


def _arrow268(v: str) -> Callable[[str], Async[bool]]:
    return closure14(None, v)


v6: Callable[[str, str], Async[bool]] = _arrow268

def file_exists_content(x: str) -> Callable[[str], Async[bool]]:
    return v6(x)


def _arrow269(v: str) -> Callable[[str], Async[None]]:
    return closure16(None, v)


v7: Callable[[str, str], Async[None]] = _arrow269

def write_all_text_async(x: str) -> Callable[[str], Async[None]]:
    return v7(x)


def _arrow270(v: str) -> Callable[[str], Async[None]]:
    return closure18(None, v)


v8: Callable[[str, str], Async[None]] = _arrow270

def write_all_text_exists(x: str) -> Callable[[str], Async[None]]:
    return v8(x)


def _arrow271(v: str) -> Async[int64]:
    return closure20(None, v)


v9: Callable[[str], Async[int64]] = _arrow271

def delete_file_async(x: str) -> Async[int64]:
    return v9(x)


def _arrow272(v: str) -> Callable[[str], Async[int64]]:
    return closure23(None, v)


v10: Callable[[str, str], Async[int64]] = _arrow272

def move_file_async(x: str) -> Callable[[str], Async[int64]]:
    return v10(x)


def _arrow273(v: str) -> Async[str | None]:
    return closure27(None, v)


v11: Callable[[str], Async[str | None]] = _arrow273

def read_all_text_retry_async(x: str) -> Async[str | None]:
    return v11(x)


def _arrow274(__unit: None=None) -> str:
    return closure35(None, None)


v12: Callable[[], str] = _arrow274

def create_temp_path(__unit: None=None) -> str:
    return v12(None)


def _arrow275(__unit: None=None) -> tuple[str, IDisposable]:
    return closure36(None, None)


v13: Callable[[], tuple[str, IDisposable]] = _arrow275

def create_temp_dir(__unit: None=None) -> tuple[str, IDisposable]:
    return v13(None)


def _arrow276(v: str) -> tuple[str, IDisposable]:
    return closure48(None, v)


v14: Callable[[str], tuple[str, IDisposable]] = _arrow276

def create_temp_dir_0027(x: str) -> tuple[str, IDisposable]:
    return v14(x)


def _arrow277(__unit: None=None) -> str:
    return closure49(None, None)


v15: Callable[[], str] = _arrow277

def get_source_directory(__unit: None=None) -> str:
    return v15(None)


def _arrow278(v: str) -> Callable[[bool, str], str]:
    return closure50(None, v)


v16: Callable[[str, bool, str], str] = _arrow278

def find_parent(x: str) -> Callable[[bool, str], str]:
    return v16(x)


def _arrow279(v: str) -> str:
    return closure56(None, v)


v17: Callable[[str], str] = _arrow279

def normalize_path(x: str) -> str:
    return v17(x)


def _arrow280(v: str) -> str:
    return closure57(None, v)


v18: Callable[[str], str] = _arrow280

def new_file_uri(x: str) -> str:
    return v18(x)


def _arrow281(__unit: None=None) -> str:
    return closure58(None, None)


v19: Callable[[], str] = _arrow281

def get_workspace_root(__unit: None=None) -> str:
    return v19(None)


def _arrow282(v: bool) -> None:
    closure59(None, v)


v20: Callable[[bool], None] = _arrow282

def init_trace_file(x: bool) -> None:
    v20(x)


def _arrow283(v: str) -> Callable[[str], str]:
    return closure61(None, v)


v21: Callable[[str, str], str] = _arrow283

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v21(x)


