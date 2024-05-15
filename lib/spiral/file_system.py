from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
from typing import (Protocol, Any)
from fable_modules.fable_library.async_builder import Async
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_3, default_arg)
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, int64_type, record_type, bool_type, string_type, unit_type, lambda_type)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, to_text, interpolate, replace)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
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


def _expr127() -> TypeInfo:
    return class_type("File_system.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr127

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


class IPathDirname(Protocol):
    @abstractmethod
    def dirname(self, path: str) -> str:
        ...


def _expr128() -> TypeInfo:
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


US0_reflection = _expr128

def _expr129() -> TypeInfo:
    return record_type("File_system.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr129

def _expr130() -> TypeInfo:
    return record_type("File_system.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr130

def _expr131() -> TypeInfo:
    return record_type("File_system.Mut2", [], Mut2, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US0

Mut2_reflection = _expr131

def _expr132() -> TypeInfo:
    return record_type("File_system.Mut3", [], Mut3, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: Callable[[str], None]

Mut3_reflection = _expr132

def _expr133() -> TypeInfo:
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


US1_reflection = _expr133

def _expr134() -> TypeInfo:
    return union_type("File_system.US3", [], US3, lambda: [[], [], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1", "US3_2"]


US3_reflection = _expr134

def _expr135() -> TypeInfo:
    return union_type("File_system.US4", [], US4, lambda: [[], [], [], [], []])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1", "US4_2", "US4_3", "US4_4"]


US4_reflection = _expr135

def _expr136() -> TypeInfo:
    return union_type("File_system.US2", [], US2, lambda: [[("f0_0", US3_reflection()), ("f0_1", US4_reflection())], []])


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
    return union_type("File_system.US5", [], US5, lambda: [[("f0_0", int64_type)], [("f1_0", class_type("System.Exception"))]])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr137

def _expr138() -> TypeInfo:
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


US6_reflection = _expr138

def _expr139() -> TypeInfo:
    return union_type("File_system.US7", [], US7, lambda: [[("f0_0", class_type("File_system.chrono_DateTime`1", [class_type("File_system.chrono_Utc")]))], []])


class US7(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US7_0", "US7_1"]


US7_reflection = _expr139

def _expr140() -> TypeInfo:
    return union_type("File_system.US8", [], US8, lambda: [[("f0_0", string_type)], []])


class US8(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US8_0", "US8_1"]


US8_reflection = _expr140

def _expr141() -> TypeInfo:
    return union_type("File_system.US9", [], US9, lambda: [[], [("f1_0", class_type("File_system.std_string_String"))]])


class US9(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US9_0", "US9_1"]


US9_reflection = _expr141

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



def US3__get_IsUS3_2(this: FSharpRef[US3], unit_arg: None) -> bool:
    if this.tag == 2:
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



def US4__get_IsUS4_3(this: FSharpRef[US4], unit_arg: None) -> bool:
    if this.tag == 3:
        return True

    else: 
        return False



def US4__get_IsUS4_4(this: FSharpRef[US4], unit_arg: None) -> bool:
    if this.tag == 4:
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



def closure1(unit_var: None, v0_1: str) -> None:
    pass


def method0(__unit: None=None) -> str:
    return ""


def method1(__unit: None=None) -> str:
    return "AUTOMATION"


def closure0(unit_var: None, v0_1: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    v1_1: Mut1 = Mut1(True)
    v2_1: Mut0 = Mut0(int64(0))
    v3_1: Mut2 = Mut2(v0_1)
    def v4_1(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure1(None, v)

    v5_1: Mut3 = Mut3(v4_1)
    _v6: (int64 | None) | None = None
    _v6 = some(None)
    return (v2_1, v1_1, v3_1, value_3(_v6), v5_1)


def method3(v0_1: str) -> str:
    return v0_1


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


def method5(__unit: None=None) -> str:
    return ""


def closure7(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str], unit_var: None) -> str:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_3(State_trace_state())
    _v10: str | None = None
    x: str = method5()
    _v10 = x
    v67: str = value_3(_v10)
    v68: int64 = pattern_input[0].l0
    v78: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    _v81: str | None = None
    x_1: str = pad_left(v78.lower(), 7, " ")
    _v81 = x_1
    return trim_end(trim_start(((((((((("" + v67) + " ") + value_3(_v81)) + " #") + str(v68)) + " ") + v1_1(None)) + " / ") + v2_1(None)) + ""), " ", "/")


def method6(v0_1: US0, v1_1: Callable[[], str]) -> None:
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
    class ObjectExpr142:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    class ObjectExpr143:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[1].l0 == False) else (find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr142())) >= find(v15_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr143()))):
        v23: int64 = op_addition(v4_1.l0, int64(1))
        v4_1.l0 = v23
        v24: str = ("" + v1_1(None)) + ""
        _v25: None | None = None
        print(v24)
        _v25 = some(None)
        value_3(_v25)
        pattern_input[4].l0(v24)



def method4(v0_1: US0, v1_1: Callable[[], str], v2_1: Callable[[], str]) -> None:
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


def closure10(unit_var: None, unit_var_1: None) -> str:
    return "file_system.wait_for_file_access"


def closure11(v0_1: str, v1_1: int64, v2_1: str, unit_var: None) -> str:
    return ((((((("path: " + closure5(None, v0_1)) + " / retry: ") + str(v1_1)) + " / ex: ") + v2_1) + " / ") + closure6(None, None)) + ""


def method7(v0_1: str, v1_1: US4, v2_1: US3, v3_1: int64) -> Async[int64]:
    _v4: Async[int64] | None = None
    _v4 = None
    return value_3(_v4)


def closure9(v0_1: US2, v1_1: str) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value_3(_v2)


def closure8(unit_var: None, v0_1: US2) -> Callable[[str], Async[int64]]:
    def _arrow144(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure9(v0_1, v)

    return _arrow144


def method8(v0_1: str, v1_1: int64) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value_3(_v2)


def closure12(unit_var: None, v0_1: str) -> Async[int64]:
    _v1: Async[int64] | None = None
    _v1 = None
    return value_3(_v1)


def closure13(unit_var: None, v0_1: str) -> Async[str]:
    _v1: Async[str] | None = None
    _v1 = None
    return value_3(_v1)


def closure15(v0_1: str, v1_1: str) -> Async[bool]:
    _v2: Async[bool] | None = None
    _v2 = None
    return value_3(_v2)


def closure14(unit_var: None, v0_1: str) -> Callable[[str], Async[bool]]:
    def _arrow145(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[bool]:
        return closure15(v0_1, v)

    return _arrow145


def closure17(v0_1: str, v1_1: str) -> Async[None]:
    _v2: Async[None] | None = None
    _v2 = None
    return value_3(_v2)


def closure16(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow146(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure17(v0_1, v)

    return _arrow146


def closure19(v0_1: str, v1_1: str) -> Async[None]:
    _v2: Async[None] | None = None
    _v2 = None
    return value_3(_v2)


def closure18(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow147(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure19(v0_1, v)

    return _arrow147


def closure21(unit_var: None, unit_var_1: None) -> str:
    return "delete_file_async"


def closure22(v0_1: str, v1_1: Exception, unit_var: None) -> str:
    _v2: str | None = None
    x: str = to_text(interpolate("%A%P()", [v1_1]))
    _v2 = x
    v9_1: str = value_3(_v2)
    return ((((("path: " + closure5(None, v0_1)) + " / ex: ") + v9_1) + " / ") + closure6(None, None)) + ""


def method9(v0_1: str, v1_1: int64) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value_3(_v2)


def closure20(unit_var: None, v0_1: str) -> Async[int64]:
    _v1: Async[int64] | None = None
    _v1 = None
    return value_3(_v1)


def closure25(unit_var: None, unit_var_1: None) -> str:
    return "move_file_async"


def closure26(v0_1: str, v1_1: str, v2_1: Exception, unit_var: None) -> str:
    _v3: str | None = None
    x: str = to_text(interpolate("%A%P()", [v2_1]))
    _v3 = x
    v10_1: str = value_3(_v3)
    def v11_1(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> str:
        return closure5(None, v)

    return ((((((("old_path: " + v11_1(v1_1)) + " / new_path: ") + v11_1(v0_1)) + " / ex: ") + v10_1) + " / ") + closure6(None, None)) + ""


def method10(v0_1: str, v1_1: str, v2_1: int64) -> Async[int64]:
    _v3: Async[int64] | None = None
    _v3 = None
    return value_3(_v3)


def closure24(v0_1: str, v1_1: str) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value_3(_v2)


def closure23(unit_var: None, v0_1: str) -> Callable[[str], Async[int64]]:
    def _arrow148(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure24(v0_1, v)

    return _arrow148


def closure28(unit_var: None, v0_1: int64) -> US5:
    return US5(0, v0_1)


def closure29(unit_var: None, v0_1: Exception) -> US5:
    return US5(1, v0_1)


def closure30(unit_var: None, unit_var_1: None) -> str:
    return "run_with_timeout_async"


def closure31(unit_var: None, unit_var_1: None) -> str:
    return ((("timeout: " + str(1000)) + " / ") + closure6(None, None)) + ""


def closure32(v0_1: str, unit_var: None) -> str:
    return ("run_with_timeout_async** / ex: " + v0_1) + ""


def closure33(unit_var: None, unit_var_1: None) -> str:
    return "read_all_text_retry_async"


def method12(v0_1: int64, v1_1: str) -> str:
    return ((((("retry: " + str(v0_1)) + " / ex: ") + v1_1) + " / ") + closure6(None, None)) + ""


def closure34(v0_1: int64, v1_1: str, unit_var: None) -> str:
    return method12(v0_1, v1_1)


def method11(v0_1: str, v1_1: int64) -> Async[str | None]:
    _v2: Async[str | None] | None = None
    _v2 = None
    return value_3(_v2)


def closure27(unit_var: None, v0_1: str) -> Async[str | None]:
    _v1: Async[str | None] | None = None
    _v1 = None
    return value_3(_v1)


def method13(__unit: None=None) -> str:
    return "CARGO_PKG_NAME"


def method15(v0_1: str) -> str:
    return v0_1


def method16(v0_1: str) -> str:
    return v0_1


def method14(v0_1: str, v1_1: str) -> str:
    _v2: str | None = None
    _v2 = None
    return value_3(_v2)


def method18(v0_1: chrono_DateTime_1[chrono_Utc]) -> chrono_DateTime_1[chrono_Utc]:
    return v0_1


def method19(v0_1: chrono_DateTime_1[chrono_Local]) -> chrono_DateTime_1[chrono_Local]:
    return v0_1


def method20(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method21(__unit: None=None) -> str:
    return "hhmm"


def method17(v0_1: str, v1_1: Any) -> str:
    _v2: str | None = None
    _v2 = None
    return value_3(_v2)


def closure35(unit_var: None, unit_var_1: None) -> str:
    _v0: str | None = None
    _v0 = None
    return value_3(_v0)


def method22(v0_1: str) -> str:
    return v0_1


def closure37(unit_var: None, v0_1: std_io_Error) -> std_string_String:
    _v1: std_string_String | None = None
    _v1 = None
    return value_3(_v1)


def method23(__unit: None=None) -> Callable[[std_io_Error], std_string_String]:
    def _arrow149(v: std_io_Error) -> std_string_String:
        return closure37(None, v)

    return _arrow149


def closure38(unit_var: None, unit_var_1: None) -> US9:
    return US9(0)


def closure39(unit_var: None, v0_1: std_string_String) -> US9:
    return US9(1, v0_1)


def closure40(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_directory"


def closure41(v0_1: str, v1_1: std_string_String, unit_var: None) -> str:
    return ((((("dir: " + v0_1) + " / error: ") + str(v1_1)) + " / ") + closure6(None, None)) + ""


def closure42(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_directory"


def closure43(v0_1: str, unit_var: None) -> str:
    return ((("dir: " + v0_1) + " / ") + closure6(None, None)) + ""


def closure44(v0_1: str, unit_var: None) -> None:
    _v1: None | None = None
    _v1 = some(None)
    value_3(_v1)


def method24(v0_1: str) -> Callable[[], None]:
    def _arrow150(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure44(v0_1, None)

    return _arrow150


def closure45(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_directory"


def closure46(v0_1: str, v1_1: str, unit_var: None) -> str:
    return ((((("dir: " + v0_1) + " / result: ") + v1_1) + " ") + closure6(None, None)) + ""


def closure47(v0_1: str, unit_var: None) -> None:
    _v1: Async[int64] | None = None
    _v1 = None
    v9_1: Async[int64] = value_3(_v1)
    _v10: Async[None] | None = None
    _v10 = None
    v18_1: Async[None] = value_3(_v10)
    _v19: None | None = None
    _v19 = some(None)
    value_3(_v19)


def method25(v0_1: str) -> Callable[[], None]:
    def _arrow151(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure47(v0_1, None)

    return _arrow151


def closure36(unit_var: None, unit_var_1: None) -> tuple[str, IDisposable]:
    _v0: str | None = None
    _v0 = None
    v134: str = value_3(_v0)
    _v135: IDisposable | None = None
    _v135 = None
    return (v134, value_3(_v135))


def closure48(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def closure52(unit_var: None, v0_1: str) -> bool:
    _v1: bool | None = None
    _v1 = None
    return value_3(_v1)


def closure53(unit_var: None, v0_1: str) -> bool:
    _v1: bool | None = None
    _v1 = None
    return value_3(_v1)


def closure54(unit_var: None, v0_1: str) -> str | None:
    _v1: US8 | None = None
    _v1 = None
    v51: US8 = value_3(_v1)
    if v51.tag == 0:
        return v51.fields[0]

    else: 
        return None



def method27(__unit: None=None) -> Callable[[str], str | None]:
    def _arrow152(v: str) -> str | None:
        return closure54(None, v)

    return _arrow152


def method28(v0_1_mut: str, v1_1_mut: bool, v2_1_mut: str, v3_1_mut: str) -> str:
    while True:
        (v0_1, v1_1, v2_1, v3_1) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_1_mut)
        def _arrow153(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1) -> bool:
            return closure52(None, v)

        def _arrow154(v_1: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1) -> bool:
            return closure53(None, v_1)

        if (_arrow153 if v1_1 else _arrow154)(method14(v3_1, v0_1)):
            return v3_1

        else: 
            v10_1: str | None = method27()(v3_1)
            _v11: FSharpRef[US8 | None] = FSharpRef(None)
            x_2: US8 | None
            if v10_1 is None:
                x_2 = None

            else: 
                x: str = v10_1
                def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3_1: Any=v3_1) -> US8:
                    return US8(0, x)

                x_2 = x_1(None)

            _v11.contents = x_2
            v16_1: US8 = default_arg(_v11.contents, US8(1))
            if v16_1.tag == 0:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_1_mut = v16_1.fields[0]
                continue

            else: 
                raise Exception(((((((("No parent for " + ("file" if v1_1 else "dir")) + " \'") + v0_1) + "\' at \'") + v2_1) + "\' (until \'") + v3_1) + "\')")


        break


def method26(v0_1: str, v1_1: bool, v2_1: str) -> str:
    def _arrow155(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> bool:
        return closure52(None, v)

    def _arrow156(v_1: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> bool:
        return closure53(None, v_1)

    if (_arrow155 if v1_1 else _arrow156)(method14(v2_1, v0_1)):
        return v2_1

    else: 
        v9_1: str | None = method27()(v2_1)
        _v10: FSharpRef[US8 | None] = FSharpRef(None)
        x_2: US8 | None
        if v9_1 is None:
            x_2 = None

        else: 
            x: str = v9_1
            def x_1(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> US8:
                return US8(0, x)

            x_2 = x_1(None)

        _v10.contents = x_2
        v15_1: US8 = default_arg(_v10.contents, US8(1))
        if v15_1.tag == 0:
            return method28(v0_1, v1_1, v2_1, v15_1.fields[0])

        else: 
            raise Exception(((((((("No parent for " + ("file" if v1_1 else "dir")) + " \'") + v0_1) + "\' at \'") + v2_1) + "\' (until \'") + v2_1) + "\')")




def closure51(v0_1: str, v1_1: bool, v2_1: str) -> str:
    return method26(v0_1, v1_1, v2_1)


def closure50(v0_1: str, v1_1: bool) -> Callable[[str], str]:
    def _arrow157(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
        return closure51(v0_1, v1_1, v)

    return _arrow157


def closure49(unit_var: None, v0_1: str) -> Callable[[bool, str], str]:
    def _arrow158(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure50(v0_1, v)

    return _arrow158


def method29(v0_1: str) -> str:
    return v0_1


def method30(__unit: None=None) -> str:
    return ""


def method31(__unit: None=None) -> str:
    return "^\\\\\\\\\\?\\\\"


def method32(__unit: None=None) -> str:
    return ""


def closure55(unit_var: None, v0_1: str) -> str:
    _v1: str | None = None
    _v1 = None
    v29: str = value_3(_v1)
    def _arrow159(__unit: None=None, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        _arg: str = v29[0]
        return _arg.lower()

    return replace(((("" + _arrow159()) + "") + v29[1:len(v29)]) + "", "\\", "/")


def closure56(unit_var: None, v0_1: str) -> str:
    return ("file:///" + trim_start(v0_1, "/")) + ""


def method34(v0_1_mut: str, v1_1_mut: str, v2_1_mut: str) -> str:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        v3_1: str = method14(v2_1, v0_1)
        _v4: bool | None = None
        _v4 = None
        if value_3(_v4):
            return v2_1

        else: 
            v27: str | None = method27()(v2_1)
            _v28: FSharpRef[US8 | None] = FSharpRef(None)
            x_3: US8 | None
            if v27 is None:
                x_3 = None

            else: 
                x_1: str = v27
                def x_2(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> US8:
                    return US8(0, x_1)

                x_3 = x_2(None)

            _v28.contents = x_3
            v33: US8 = default_arg(_v28.contents, US8(1))
            if v33.tag == 0:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v33.fields[0]
                continue

            else: 
                raise Exception(((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v2_1) + "\')")


        break


def method33(v0_1: str, v1_1: str) -> str:
    v2_1: str = method14(v1_1, v0_1)
    _v3: bool | None = None
    _v3 = None
    if value_3(_v3):
        return v1_1

    else: 
        v26: str | None = method27()(v1_1)
        _v27: FSharpRef[US8 | None] = FSharpRef(None)
        x_3: US8 | None
        if v26 is None:
            x_3 = None

        else: 
            x_1: str = v26
            def x_2(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> US8:
                return US8(0, x_1)

            x_3 = x_2(None)

        _v27.contents = x_3
        v32: US8 = default_arg(_v27.contents, US8(1))
        if v32.tag == 0:
            return method34(v0_1, v1_1, v32.fields[0])

        else: 
            raise Exception(((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v1_1) + "\')")




def closure57(unit_var: None, unit_var_1: None) -> str:
    return method14(method33(method14("polyglot", ".paket"), "C:\\home\\git\\polyglot\\lib\\spiral"), "polyglot")


def method35(v0_1: str) -> None:
    _v1: None | None = None
    _v1 = some(None)
    value_3(_v1)


def closure59(unit_var: None, v0_1: str) -> None:
    method35(v0_1)


def closure58(unit_var: None, v0_1: bool) -> None:
    if State_trace_state() is None:
        State_trace_state(closure0(None, US0(0)))

    pattern_input: tuple[Mut0, Mut1, Mut2, int64 | None, Mut3] = value_3(State_trace_state())
    def _arrow160(v_1: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure59(None, v_1)

    def _arrow161(v_2: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure1(None, v_2)

    v10_1: Callable[[str], None] = _arrow160 if v0_1 else _arrow161
    pattern_input[4].l0 = v10_1


def closure61(v0_1: str, v1_1: str) -> str:
    return method14(v0_1, v1_1)


def closure60(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow162(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure61(v0_1, v)

    return _arrow162


def _arrow163(v: US0) -> tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]:
    return closure0(None, v)


v0: Callable[[US0], tuple[Mut0, Mut1, Mut2, int64 | None, Mut3]] = _arrow163

v1: US0 = US0(0)


if State_trace_state() is None:
    State_trace_state(v0(v1))


def _arrow164(v: str) -> Async[int64]:
    return closure2(None, v)


v2: Callable[[str], Async[int64]] = _arrow164

def delete_directory_async(x: str) -> Async[int64]:
    return v2(x)


def _arrow165(v: US2) -> Callable[[str], Async[int64]]:
    return closure8(None, v)


v3: Callable[[US2, str], Async[int64]] = _arrow165

def wait_for_file_access(x: US2) -> Callable[[str], Async[int64]]:
    return v3(x)


def _arrow166(v: str) -> Async[int64]:
    return closure12(None, v)


v4: Callable[[str], Async[int64]] = _arrow166

def wait_for_file_access_read(x: str) -> Async[int64]:
    return v4(x)


def _arrow167(v: str) -> Async[str]:
    return closure13(None, v)


v5: Callable[[str], Async[str]] = _arrow167

def read_all_text_async(x: str) -> Async[str]:
    return v5(x)


def _arrow168(v: str) -> Callable[[str], Async[bool]]:
    return closure14(None, v)


v6: Callable[[str, str], Async[bool]] = _arrow168

def file_exists_content(x: str) -> Callable[[str], Async[bool]]:
    return v6(x)


def _arrow169(v: str) -> Callable[[str], Async[None]]:
    return closure16(None, v)


v7: Callable[[str, str], Async[None]] = _arrow169

def write_all_text_async(x: str) -> Callable[[str], Async[None]]:
    return v7(x)


def _arrow170(v: str) -> Callable[[str], Async[None]]:
    return closure18(None, v)


v8: Callable[[str, str], Async[None]] = _arrow170

def write_all_text_exists(x: str) -> Callable[[str], Async[None]]:
    return v8(x)


def _arrow171(v: str) -> Async[int64]:
    return closure20(None, v)


v9: Callable[[str], Async[int64]] = _arrow171

def delete_file_async(x: str) -> Async[int64]:
    return v9(x)


def _arrow172(v: str) -> Callable[[str], Async[int64]]:
    return closure23(None, v)


v10: Callable[[str, str], Async[int64]] = _arrow172

def move_file_async(x: str) -> Callable[[str], Async[int64]]:
    return v10(x)


def _arrow173(v: str) -> Async[str | None]:
    return closure27(None, v)


v11: Callable[[str], Async[str | None]] = _arrow173

def read_all_text_retry_async(x: str) -> Async[str | None]:
    return v11(x)


def _arrow174(__unit: None=None) -> str:
    return closure35(None, None)


v12: Callable[[], str] = _arrow174

def create_temp_directory_name(__unit: None=None) -> str:
    return v12(None)


def _arrow175(__unit: None=None) -> tuple[str, IDisposable]:
    return closure36(None, None)


v13: Callable[[], tuple[str, IDisposable]] = _arrow175

def create_temp_directory(__unit: None=None) -> tuple[str, IDisposable]:
    return v13(None)


def _arrow176(__unit: None=None) -> str:
    return closure48(None, None)


v14: Callable[[], str] = _arrow176

def get_source_directory(__unit: None=None) -> str:
    return v14(None)


def _arrow177(v: str) -> Callable[[bool, str], str]:
    return closure49(None, v)


v15: Callable[[str, bool, str], str] = _arrow177

def find_parent(x: str) -> Callable[[bool, str], str]:
    return v15(x)


def _arrow178(v: str) -> str:
    return closure55(None, v)


v16: Callable[[str], str] = _arrow178

def normalize_path(x: str) -> str:
    return v16(x)


def _arrow179(v: str) -> str:
    return closure56(None, v)


v17: Callable[[str], str] = _arrow179

def new_file_uri(x: str) -> str:
    return v17(x)


def _arrow180(__unit: None=None) -> str:
    return closure57(None, None)


v18: Callable[[], str] = _arrow180

def get_workspace_root(__unit: None=None) -> str:
    return v18(None)


def _arrow181(v: bool) -> None:
    closure58(None, v)


v19: Callable[[bool], None] = _arrow181

def init_trace_file(x: bool) -> None:
    v19(x)


def _arrow182(v: str) -> Callable[[str], str]:
    return closure60(None, v)


v20: Callable[[str, str], str] = _arrow182

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v20(x)


