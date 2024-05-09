from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
from typing import (Protocol, Any)
from fable_modules.fable_library.async_builder import Async
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_3, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, class_type, int64_type, record_type, bool_type, union_type, string_type, unit_type, lambda_type)
from fable_modules.fable_library.string_ import (pad_right, trim_end, trim_start, to_text, interpolate, replace)
from fable_modules.fable_library.types import (int64, Array, Record, Union, FSharpRef)
from fable_modules.fable_library.util import (create_atom, IDisposable, to_enumerable, compare)

State_trace_state: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] | None = create_atom(None)

class IFsExistsSync(Protocol):
    @abstractmethod
    def exists_sync(self, path: str) -> bool:
        ...


class IPathJoin(Protocol):
    @abstractmethod
    def join(self, paths: Array[str]) -> str:
        ...


def _expr161() -> TypeInfo:
    return class_type("File_system.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr161

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


class IPathDirname(Protocol):
    @abstractmethod
    def dirname(self, path: str) -> str:
        ...


def _expr162() -> TypeInfo:
    return record_type("File_system.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr162

def _expr163() -> TypeInfo:
    return record_type("File_system.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr163

def _expr164() -> TypeInfo:
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


US0_reflection = _expr164

def _expr165() -> TypeInfo:
    return record_type("File_system.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr165

def _expr166() -> TypeInfo:
    return record_type("File_system.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr166

def _expr167() -> TypeInfo:
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


US1_reflection = _expr167

def _expr168() -> TypeInfo:
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


US2_reflection = _expr168

def _expr169() -> TypeInfo:
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


US4_reflection = _expr169

def _expr170() -> TypeInfo:
    return union_type("File_system.US5", [], US5, lambda: [[], [], [], [], []])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1", "US5_2", "US5_3", "US5_4"]


US5_reflection = _expr170

def _expr171() -> TypeInfo:
    return union_type("File_system.US3", [], US3, lambda: [[("f0_0", US4_reflection()), ("f0_1", US5_reflection())], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr171

def _expr172() -> TypeInfo:
    return union_type("File_system.US6", [], US6, lambda: [[("f0_0", int64_type)], [("f1_0", class_type("System.Exception"))]])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1"]


US6_reflection = _expr172

def _expr173() -> TypeInfo:
    return union_type("File_system.US7", [], US7, lambda: [[("f0_0", int64_type)], [("f1_0", class_type("System.Exception"))]])


class US7(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US7_0", "US7_1"]


US7_reflection = _expr173

def _expr174() -> TypeInfo:
    return union_type("File_system.US8", [], US8, lambda: [[("f0_0", class_type("File_system.chrono_DateTime`1", [class_type("File_system.chrono_Utc")]))], []])


class US8(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US8_0", "US8_1"]


US8_reflection = _expr174

def _expr175() -> TypeInfo:
    return union_type("File_system.US9", [], US9, lambda: [[("f0_0", string_type)], []])


class US9(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US9_0", "US9_1"]


US9_reflection = _expr175

def _expr176() -> TypeInfo:
    return union_type("File_system.US10", [], US10, lambda: [[], [("f1_0", class_type("File_system.std_string_String"))]])


class US10(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US10_0", "US10_1"]


US10_reflection = _expr176

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



def closure1(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def method1(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def closure0(unit_var: None, unit_var_1: None) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    v0_1: Mut1 = Mut1(True)
    v1_1: Mut0 = Mut0(int64(0))
    v3_1: Mut2 = Mut2(US0(0))
    def v4_1(v: str, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure1(None, v)

    v5_1: Mut3 = Mut3(v4_1)
    _v6: (int64 | None) | None = None
    x: int64 | None = method1(None)
    _v6 = some(x)
    return (v1_1, v0_1, v3_1, value_3(_v6), v5_1)


def closure3(unit_var: None, unit_var_1: None) -> str:
    return "file_system.delete_directory_async"


def closure5(unit_var: None, v0_1: str) -> str:
    _v1: str | None = None
    _v1 = None
    return value_3(_v1)


def closure6(unit_var: None, unit_var_1: None) -> str:
    return ""


def closure4(v0_1: str, v1_1: str, unit_var: None) -> str:
    return ((((("path: " + closure5(None, v0_1)) + " / ex: ") + v1_1) + " / ") + closure6(None, None)) + ""


def closure8(unit_var: None, v0_1: int64) -> US2:
    return US2(0, v0_1)


def method4(__unit: None=None) -> Callable[[int64], US2]:
    def _arrow177(v: int64) -> US2:
        return closure8(None, v)

    return _arrow177


def method5(__unit: None=None) -> str:
    return ""


def closure7(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, None))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_3(State_trace_state())
    _v9: str | None = None
    x: str = method5()
    _v9 = x
    v61: str = value_3(_v9)
    v62: int64 = pattern_input[0].l0
    v72: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    _v75: str | None = None
    x_1: str = pad_right(v72.lower(), 7, " ")
    _v75 = x_1
    return trim_end(trim_start(((((((((("" + v61) + " ") + value_3(_v75)) + " #") + str(v62)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method6(v0_1: US0, v1_1: Callable[[], str]) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
        return closure0(None, None)

    if State_trace_state() is None:
        State_trace_state(v2_1(None))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_3(State_trace_state())
    v3_1: Mut0 = pattern_input[0]
    if State_trace_state() is None:
        State_trace_state(v2_1(None))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_3(State_trace_state())
    v13_1: US0 = pattern_input_1[2].l0
    class ObjectExpr178:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr179:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr178())) >= find(v13_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr179()))):
        v21: int64 = op_addition(v3_1.l0, int64(1))
        v3_1.l0 = v21
        v22: str = ("" + v1_1(None)) + ""
        _v23: None | None = None
        print(v22)
        _v23 = some(None)
        value_3(_v23)
        pattern_input[4].l0(v22)



def method3(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
    def v3_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure7(v0_1, v1_1, v2_1, None)

    method6(v0_1, v3_1)


def method2(v0_1: str, v1_1: int64) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value_3(_v2)


def closure2(unit_var: None, v0_1: str) -> Async[int64]:
    _v1: Async[int64] | None = None
    _v1 = None
    return value_3(_v1)


def closure11(unit_var: None, unit_var_1: None) -> str:
    return "file_system.wait_for_file_access"


def closure12(v0_1: str, v1_1: int64, v2_1: str, unit_var: None) -> str:
    return ((((((("path: " + closure5(None, v0_1)) + " / retry: ") + str(v1_1)) + " / ex: ") + v2_1) + " / ") + closure6(None, None)) + ""


def method7(v0_1: str, v1_1: US5, v2_1: US4, v3_1: int64) -> Async[int64]:
    _v4: Async[int64] | None = None
    _v4 = None
    return value_3(_v4)


def closure10(v0_1: US3, v1_1: str) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value_3(_v2)


def closure9(unit_var: None, v0_1: US3) -> Callable[[str], Async[int64]]:
    def _arrow180(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure10(v0_1, v)

    return _arrow180


def method8(v0_1: str, v1_1: int64) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value_3(_v2)


def closure13(unit_var: None, v0_1: str) -> Async[int64]:
    _v1: Async[int64] | None = None
    _v1 = None
    return value_3(_v1)


def closure14(unit_var: None, v0_1: str) -> Async[str]:
    _v1: Async[str] | None = None
    _v1 = None
    return value_3(_v1)


def method9(v0_1: str) -> str:
    return v0_1


def closure16(v0_1: str, v1_1: str) -> Async[bool]:
    _v2: Async[bool] | None = None
    _v2 = None
    return value_3(_v2)


def closure15(unit_var: None, v0_1: str) -> Callable[[str], Async[bool]]:
    def _arrow181(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[bool]:
        return closure16(v0_1, v)

    return _arrow181


def closure18(v0_1: str, v1_1: str) -> Async[None]:
    _v2: Async[None] | None = None
    _v2 = None
    return value_3(_v2)


def closure17(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow182(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure18(v0_1, v)

    return _arrow182


def closure20(v0_1: str, v1_1: str) -> Async[None]:
    _v2: Async[None] | None = None
    _v2 = None
    return value_3(_v2)


def closure19(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow183(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure20(v0_1, v)

    return _arrow183


def closure22(unit_var: None, unit_var_1: None) -> str:
    return "delete_file_async"


def closure23(v0_1: str, v1_1: Exception, unit_var: None) -> str:
    _v2: str | None = None
    x: str = to_text(interpolate("%A%P()", [v1_1]))
    _v2 = x
    v10_1: str = value_3(_v2)
    return ((((("path: " + closure5(None, v0_1)) + " / ex: ") + v10_1) + " / ") + closure6(None, None)) + ""


def method10(v0_1: str, v1_1: int64) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value_3(_v2)


def closure21(unit_var: None, v0_1: str) -> Async[int64]:
    _v1: Async[int64] | None = None
    _v1 = None
    return value_3(_v1)


def closure26(unit_var: None, unit_var_1: None) -> str:
    return "move_file_async"


def closure27(v0_1: str, v1_1: str, v2_1: Exception, unit_var: None) -> str:
    _v3: str | None = None
    x: str = to_text(interpolate("%A%P()", [v2_1]))
    _v3 = x
    v11_1: str = value_3(_v3)
    def v12_1(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> str:
        return closure5(None, v)

    return ((((((("old_path: " + v12_1(v1_1)) + " / new_path: ") + v12_1(v0_1)) + " / ex: ") + v11_1) + " / ") + closure6(None, None)) + ""


def method11(v0_1: str, v1_1: str, v2_1: int64) -> Async[int64]:
    _v3: Async[int64] | None = None
    _v3 = None
    return value_3(_v3)


def closure25(v0_1: str, v1_1: str) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value_3(_v2)


def closure24(unit_var: None, v0_1: str) -> Callable[[str], Async[int64]]:
    def _arrow184(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure25(v0_1, v)

    return _arrow184


def closure29(unit_var: None, v0_1: int64) -> US6:
    return US6(0, v0_1)


def closure30(unit_var: None, v0_1: Exception) -> US6:
    return US6(1, v0_1)


def closure31(unit_var: None, unit_var_1: None) -> str:
    return "run_with_timeout_async"


def closure32(unit_var: None, unit_var_1: None) -> str:
    return ((("timeout: " + str(1000)) + " / ") + closure6(None, None)) + ""


def closure33(v0_1: str, unit_var: None) -> str:
    return ("run_with_timeout_async** / ex: " + v0_1) + ""


def closure34(unit_var: None, unit_var_1: None) -> str:
    return "read_all_text_retry_async"


def method13(v0_1: int64, v1_1: str) -> str:
    return ((((("retry: " + str(v0_1)) + " / ex: ") + v1_1) + " / ") + closure6(None, None)) + ""


def closure35(v0_1: int64, v1_1: str, unit_var: None) -> str:
    return method13(v0_1, v1_1)


def method12(v0_1: str, v1_1: int64) -> Async[str | None]:
    _v2: Async[str | None] | None = None
    _v2 = None
    return value_3(_v2)


def closure28(unit_var: None, v0_1: str) -> Async[str | None]:
    _v1: Async[str | None] | None = None
    _v1 = None
    return value_3(_v1)


def method14(v0_1: str) -> str:
    return v0_1


def method15(v0_1: str) -> str:
    return v0_1


def closure37(unit_var: None, v0_1: chrono_DateTime_1[chrono_Utc]) -> US8:
    return US8(0, v0_1)


def method16(__unit: None=None) -> Callable[[chrono_DateTime_1[chrono_Utc]], US8]:
    def _arrow185(v: chrono_DateTime_1[chrono_Utc]) -> US8:
        return closure37(None, v)

    return _arrow185


def method17(v0_1: chrono_DateTime_1[chrono_Utc]) -> chrono_DateTime_1[chrono_Utc]:
    return v0_1


def method18(v0_1: chrono_DateTime_1[chrono_Local]) -> chrono_DateTime_1[chrono_Local]:
    return v0_1


def method19(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method20(__unit: None=None) -> str:
    return "hhmm"


def closure36(unit_var: None, unit_var_1: None) -> str:
    _v0: str | None = None
    _v0 = None
    return value_3(_v0)


def method21(v0_1: str) -> str:
    return v0_1


def closure39(unit_var: None, v0_1: std_io_Error) -> std_string_String:
    _v1: std_string_String | None = None
    _v1 = None
    return value_3(_v1)


def method22(__unit: None=None) -> Callable[[std_io_Error], std_string_String]:
    def _arrow186(v: std_io_Error) -> std_string_String:
        return closure39(None, v)

    return _arrow186


def closure40(unit_var: None, unit_var_1: None) -> US10:
    return US10(0)


def closure41(unit_var: None, v0_1: std_string_String) -> US10:
    return US10(1, v0_1)


def closure42(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_directory"


def closure43(v0_1: str, v1_1: std_string_String, unit_var: None) -> str:
    return ((((("dir: " + v0_1) + " / error: ") + str(v1_1)) + " / ") + closure6(None, None)) + ""


def closure44(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_directory"


def closure45(v0_1: str, unit_var: None) -> str:
    return ((("dir: " + v0_1) + " / ") + closure6(None, None)) + ""


def closure46(v0_1: str, unit_var: None) -> None:
    _v1: None | None = None
    _v1 = some(None)
    value_3(_v1)


def method23(v0_1: str) -> Callable[[], None]:
    def _arrow187(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure46(v0_1, None)

    return _arrow187


def closure47(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_directory"


def closure48(v0_1: str, v1_1: str, unit_var: None) -> str:
    return ((((("dir: " + v0_1) + " / result: ") + v1_1) + " ") + closure6(None, None)) + ""


def closure49(v0_1: str, unit_var: None) -> None:
    _v1: Async[int64] | None = None
    _v1 = None
    v10_1: Async[int64] = value_3(_v1)
    _v11: Async[None] | None = None
    _v11 = None
    v20: Async[None] = value_3(_v11)
    _v21: None | None = None
    _v21 = some(None)
    value_3(_v21)


def method24(v0_1: str) -> Callable[[], None]:
    def _arrow188(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure49(v0_1, None)

    return _arrow188


def closure38(unit_var: None, unit_var_1: None) -> tuple[str, IDisposable]:
    _v0: str | None = None
    _v0 = None
    v534: str = value_3(_v0)
    _v535: IDisposable | None = None
    _v535 = None
    return (v534, value_3(_v535))


def closure50(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def closure54(unit_var: None, v0_1: str) -> bool:
    _v1: bool | None = None
    _v1 = None
    return value_3(_v1)


def closure55(unit_var: None, v0_1: str) -> bool:
    _v1: bool | None = None
    _v1 = None
    return value_3(_v1)


def closure56(unit_var: None, v0_1: str) -> str | None:
    _v1: US9 | None = None
    _v1 = None
    v55: US9 = value_3(_v1)
    if v55.tag == 0:
        return v55.fields[0]

    else:
        return None



def method26(__unit: None=None) -> Callable[[str], str | None]:
    def _arrow189(v: str) -> str | None:
        return closure56(None, v)

    return _arrow189


def closure57(unit_var: None, v0_1: str) -> US9:
    return US9(0, v0_1)


def method27(__unit: None=None) -> Callable[[str], US9]:
    def _arrow190(v: str) -> US9:
        return closure57(None, v)

    return _arrow190


def method28(v0_1_mut: str, v1_1_mut: bool, v2_1_mut: str, v3_1_mut: str) -> str:
    while True:
        (v0_1, v1_1, v2_1, v3_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut)
        _v4: str | None = None
        _v4 = None
        def _arrow191(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1) -> bool:
            return closure54(None, v)

        def _arrow192(v_1: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1) -> bool:
            return closure55(None, v_1)

        if (_arrow191 if v1_1 else _arrow192)(value_3(_v4)):
            return v3_1

        else:
            v52: str | None = method26()(v3_1)
            v55: US9 = default_arg(map(method27(), v52), US9(1))
            if v55.tag == 0:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v55.fields[0]
                continue

            else:
                raise Exception(((((((("No parent for " + ("file" if v1_1 else "dir")) + " \'") + v0_1) + "\' at \'") + v2_1) + "\' (until \'") + v3_1) + "\')")


        break


def method25(v0_1: str, v1_1: bool, v2_1: str) -> str:
    _v3: str | None = None
    _v3 = None
    def _arrow193(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> bool:
        return closure54(None, v)

    def _arrow194(v_1: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> bool:
        return closure55(None, v_1)

    if (_arrow193 if v1_1 else _arrow194)(value_3(_v3)):
        return v2_1

    else:
        v51: str | None = method26()(v2_1)
        v54: US9 = default_arg(map(method27(), v51), US9(1))
        if v54.tag == 0:
            return method28(v0_1, v1_1, v2_1, v54.fields[0])

        else:
            raise Exception(((((((("No parent for " + ("file" if v1_1 else "dir")) + " \'") + v0_1) + "\' at \'") + v2_1) + "\' (until \'") + v2_1) + "\')")




def closure53(v0_1: str, v1_1: bool, v2_1: str) -> str:
    return method25(v0_1, v1_1, v2_1)


def closure52(v0_1: str, v1_1: bool) -> Callable[[str], str]:
    def _arrow195(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure53(v0_1, v1_1, v)

    return _arrow195


def closure51(unit_var: None, v0_1: str) -> Callable[[bool, str], str]:
    def _arrow196(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure52(v0_1, v)

    return _arrow196


def method29(__unit: None=None) -> str:
    return "^\\\\\\\\\\?\\\\"


def method30(v0_1: str) -> str:
    return v0_1


def method31(__unit: None=None) -> str:
    return ""


def closure58(unit_var: None, v0_1: str) -> str:
    _v1: bool | None = None
    _v1 = None
    if value_3(_v1) == False:
        return v0_1

    else:
        _v14: str | None = None
        _v14 = None
        v32: str = value_3(_v14)
        def _arrow197(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
            _arg: str = v32[0]
            return _arg.lower()

        return replace(((("" + _arrow197()) + "") + v32[1:len(v32)]) + "", "\\", "/")



def closure59(unit_var: None, v0_1: str) -> str:
    return ("file:///" + trim_start(v0_1, "/")) + ""


def method32(__unit: None=None) -> str:
    return "polyglot"


def method33(__unit: None=None) -> str:
    return ".paket"


def method34(__unit: None=None) -> str:
    return "polyglot"


def method35(__unit: None=None) -> str:
    return ".paket"


def method37(v0_1_mut: str, v1_1_mut: str, v2_1_mut: str) -> str:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        _v3: str | None = None
        _v3 = None
        v45: str = value_3(_v3)
        _v46: bool | None = None
        _v46 = None
        if value_3(_v46):
            return v2_1

        else:
            v71: str | None = method26()(v2_1)
            v74: US9 = default_arg(map(method27(), v71), US9(1))
            if v74.tag == 0:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v74.fields[0]
                continue

            else:
                raise Exception(((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v2_1) + "\')")


        break


def method36(v0_1: str, v1_1: str) -> str:
    _v2: str | None = None
    _v2 = None
    v44: str = value_3(_v2)
    _v45: bool | None = None
    _v45 = None
    if value_3(_v45):
        return v1_1

    else:
        v70: str | None = method26()(v1_1)
        v73: US9 = default_arg(map(method27(), v70), US9(1))
        if v73.tag == 0:
            return method37(v0_1, v1_1, v73.fields[0])

        else:
            raise Exception(((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v1_1) + "\')")




def method38(__unit: None=None) -> str:
    return "polyglot"


def closure60(unit_var: None, unit_var_1: None) -> str:
    _v1: str | None = None
    _v1 = None
    v46: str = method36(value_3(_v1), "C:\\home\\git\\polyglot\\lib\\spiral")
    _v47: str | None = None
    _v47 = None
    return value_3(_v47)


def method40(__unit: None=None) -> str:
    return "target/polyglot/trace"


def method41(__unit: None=None) -> str:
    return "target/polyglot/trace"


def method39(v0_1: str) -> None:
    _v1: None | None = None
    _v1 = some(None)
    value_3(_v1)


def closure62(unit_var: None, v0_1: str) -> None:
    method39(v0_1)


def closure61(unit_var: None, v0_1: bool) -> None:
    if State_trace_state() is None:
        State_trace_state(closure0(None, None))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_3(State_trace_state())
    def _arrow198(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure62(None, v)

    def _arrow199(v_1: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure1(None, v_1)

    v9_1: Callable[[str], None] = _arrow198 if v0_1 else _arrow199
    pattern_input[4].l0 = v9_1


def closure64(v0_1: str, v1_1: str) -> str:
    _v2: str | None = None
    _v2 = None
    return value_3(_v2)


def closure63(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow200(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure64(v0_1, v)

    return _arrow200


def _arrow201(__unit: None=None) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, None)


v0: Callable[[], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow201


if State_trace_state() is None:
    State_trace_state(v0(None))


def _arrow202(v: str) -> Async[int64]:
    return closure2(None, v)


v1: Callable[[str], Async[int64]] = _arrow202

def delete_directory_async(x: str) -> Async[int64]:
    return v1(x)


def _arrow203(v: US3) -> Callable[[str], Async[int64]]:
    return closure9(None, v)


v2: Callable[[US3, str], Async[int64]] = _arrow203

def wait_for_file_access(x: US3) -> Callable[[str], Async[int64]]:
    return v2(x)


def _arrow204(v: str) -> Async[int64]:
    return closure13(None, v)


v3: Callable[[str], Async[int64]] = _arrow204

def wait_for_file_access_read(x: str) -> Async[int64]:
    return v3(x)


def _arrow205(v: str) -> Async[str]:
    return closure14(None, v)


v4: Callable[[str], Async[str]] = _arrow205

def read_all_text_async(x: str) -> Async[str]:
    return v4(x)


def _arrow206(v: str) -> Callable[[str], Async[bool]]:
    return closure15(None, v)


v5: Callable[[str, str], Async[bool]] = _arrow206

def file_exists_content(x: str) -> Callable[[str], Async[bool]]:
    return v5(x)


def _arrow207(v: str) -> Callable[[str], Async[None]]:
    return closure17(None, v)


v6: Callable[[str, str], Async[None]] = _arrow207

def write_all_text_async(x: str) -> Callable[[str], Async[None]]:
    return v6(x)


def _arrow208(v: str) -> Callable[[str], Async[None]]:
    return closure19(None, v)


v7: Callable[[str, str], Async[None]] = _arrow208

def write_all_text_exists(x: str) -> Callable[[str], Async[None]]:
    return v7(x)


def _arrow209(v: str) -> Async[int64]:
    return closure21(None, v)


v8: Callable[[str], Async[int64]] = _arrow209

def delete_file_async(x: str) -> Async[int64]:
    return v8(x)


def _arrow210(v: str) -> Callable[[str], Async[int64]]:
    return closure24(None, v)


v9: Callable[[str, str], Async[int64]] = _arrow210

def move_file_async(x: str) -> Callable[[str], Async[int64]]:
    return v9(x)


def _arrow211(v: str) -> Async[str | None]:
    return closure28(None, v)


v10: Callable[[str], Async[str | None]] = _arrow211

def read_all_text_retry_async(x: str) -> Async[str | None]:
    return v10(x)


def _arrow212(__unit: None=None) -> str:
    return closure36(None, None)


v11: Callable[[], str] = _arrow212

def create_temp_directory_name(__unit: None=None) -> str:
    return v11(None)


def _arrow213(__unit: None=None) -> tuple[str, IDisposable]:
    return closure38(None, None)


v12: Callable[[], tuple[str, IDisposable]] = _arrow213

def create_temp_directory(__unit: None=None) -> tuple[str, IDisposable]:
    return v12(None)


def _arrow214(__unit: None=None) -> str:
    return closure50(None, None)


v13: Callable[[], str] = _arrow214

def get_source_directory(__unit: None=None) -> str:
    return v13(None)


def _arrow215(v: str) -> Callable[[bool, str], str]:
    return closure51(None, v)


v14: Callable[[str, bool, str], str] = _arrow215

def find_parent(x: str) -> Callable[[bool, str], str]:
    return v14(x)


def _arrow216(v: str) -> str:
    return closure58(None, v)


v15: Callable[[str], str] = _arrow216

def normalize_path(x: str) -> str:
    return v15(x)


def _arrow217(v: str) -> str:
    return closure59(None, v)


v16: Callable[[str], str] = _arrow217

def new_file_uri(x: str) -> str:
    return v16(x)


def _arrow218(__unit: None=None) -> str:
    return closure60(None, None)


v17: Callable[[], str] = _arrow218

def get_workspace_root(__unit: None=None) -> str:
    return v17(None)


def _arrow219(v: bool) -> None:
    closure61(None, v)


v18: Callable[[bool], None] = _arrow219

def init_trace_file(x: bool) -> None:
    v18(x)


def _arrow220(v: str) -> Callable[[str], str]:
    return closure63(None, v)


v19: Callable[[str, str], str] = _arrow220

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v19(x)
