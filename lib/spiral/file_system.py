from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
from typing import (Protocol, Any)
from fable_modules.fable_library.async_builder import Async
from fable_modules.fable_library.long import op_addition
from fable_modules.fable_library.option import (value, some, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, bool_type, class_type, string_type)
from fable_modules.fable_library.string_ import (trim_end, trim_start)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, equals, compare, IDisposable)

class IFsExistsSync(Protocol):
    @abstractmethod
    def exists_sync(self, path: str) -> bool:
        ...


State_trace_state: tuple[Mut0, Mut1, Mut1, Mut2, int64 | None] | None = create_atom(None)

class IPathJoin(Protocol):
    @abstractmethod
    def join(self, paths: Array[str]) -> str:
        ...


class IPathDirname(Protocol):
    @abstractmethod
    def dirname(self, path: str) -> str:
        ...


def _expr81() -> TypeInfo:
    return union_type("File_system.US1", [], US1, lambda: [[], [], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1", "US1_2"]


US1_reflection = _expr81

def _expr82() -> TypeInfo:
    return union_type("File_system.US2", [], US2, lambda: [[], [], [], [], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1", "US2_2", "US2_3", "US2_4"]


US2_reflection = _expr82

def _expr83() -> TypeInfo:
    return union_type("File_system.US0", [], US0, lambda: [[("f0_0", US1_reflection()), ("f0_1", US2_reflection())], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1"]


US0_reflection = _expr83

def _expr84() -> TypeInfo:
    return union_type("File_system.US3", [], US3, lambda: [[], [], [], [], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1", "US3_2", "US3_3", "US3_4"]


US3_reflection = _expr84

def _expr85() -> TypeInfo:
    return record_type("File_system.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr85

def _expr86() -> TypeInfo:
    return record_type("File_system.Mut1", [], Mut1, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: bool

Mut1_reflection = _expr86

def _expr87() -> TypeInfo:
    return record_type("File_system.Mut2", [], Mut2, lambda: [("l0", US3_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: US3

Mut2_reflection = _expr87

def _expr88() -> TypeInfo:
    return union_type("File_system.US4", [], US4, lambda: [[("f0_0", int64_type)], []])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1"]


US4_reflection = _expr88

def _expr89() -> TypeInfo:
    return union_type("File_system.US5", [], US5, lambda: [[("f0_0", int64_type)], []])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr89

def _expr90() -> TypeInfo:
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


US6_reflection = _expr90

def _expr91() -> TypeInfo:
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


US7_reflection = _expr91

def _expr92() -> TypeInfo:
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


US8_reflection = _expr92

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



def US1__get_IsUS1_2(this: FSharpRef[US1], unit_arg: None) -> bool:
    if this.tag == 2:
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



def US2__get_IsUS2_2(this: FSharpRef[US2], unit_arg: None) -> bool:
    if this.tag == 2:
        return True

    else: 
        return False



def US2__get_IsUS2_3(this: FSharpRef[US2], unit_arg: None) -> bool:
    if this.tag == 3:
        return True

    else: 
        return False



def US2__get_IsUS2_4(this: FSharpRef[US2], unit_arg: None) -> bool:
    if this.tag == 4:
        return True

    else: 
        return False



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



def US3__get_IsUS3_3(this: FSharpRef[US3], unit_arg: None) -> bool:
    if this.tag == 3:
        return True

    else: 
        return False



def US3__get_IsUS3_4(this: FSharpRef[US3], unit_arg: None) -> bool:
    if this.tag == 4:
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



def closure2(unit_var: None, v0_1: str) -> str:
    _v1: str | None = None
    _v1 = None
    return value(_v1)


def closure3(unit_var: None, unit_var_1: None) -> str:
    return ""


def method1(v0_1: str, v1: str) -> str:
    return ((((("path: " + closure2(None, v0_1)) + " / ex: ") + v1) + " / ") + closure3(None, None)) + ""


def closure1(v0_1: str, v1: str, unit_var: None) -> str:
    return method1(v0_1, v1)


def method0(v0_1: str, v1: int64) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value(_v2)


def closure0(unit_var: None, v0_1: str) -> Async[int64]:
    _v1: Async[int64] | None = None
    _v1 = None
    return value(_v1)


def method3(v0_1: str, v1: int64, v2: str) -> str:
    return ((((((("path: " + closure2(None, v0_1)) + " / retry: ") + str(v1)) + " / ex: ") + v2) + " / ") + closure3(None, None)) + ""


def closure6(v0_1: str, v1: int64, v2: str, unit_var: None) -> str:
    return method3(v0_1, v1, v2)


def method2(v0_1: str, v1: US2, v2: US1, v3: int64) -> Async[int64]:
    _v4: Async[int64] | None = None
    _v4 = None
    return value(_v4)


def closure5(v0_1: US0, v1: str) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value(_v2)


def closure4(unit_var: None, v0_1: US0) -> Callable[[str], Async[int64]]:
    def _arrow93(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure5(v0_1, v)

    return _arrow93


def method4(v0_1: str, v1: int64) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value(_v2)


def closure7(unit_var: None, v0_1: str) -> Async[int64]:
    _v1: Async[int64] | None = None
    _v1 = None
    return value(_v1)


def closure8(unit_var: None, v0_1: str) -> Async[str]:
    _v1: Async[str] | None = None
    _v1 = None
    return value(_v1)


def method5(v0_1: str) -> str:
    return v0_1


def closure10(v0_1: str, v1: str) -> Async[bool]:
    _v2: Async[bool] | None = None
    _v2 = None
    return value(_v2)


def closure9(unit_var: None, v0_1: str) -> Callable[[str], Async[bool]]:
    def _arrow94(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[bool]:
        return closure10(v0_1, v)

    return _arrow94


def closure12(v0_1: str, v1: str) -> Async[None]:
    _v2: Async[None] | None = None
    _v2 = None
    return value(_v2)


def closure11(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow95(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure12(v0_1, v)

    return _arrow95


def closure14(v0_1: str, v1: str) -> Async[None]:
    _v2: Async[None] | None = None
    _v2 = None
    return value(_v2)


def closure13(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow96(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure14(v0_1, v)

    return _arrow96


def closure16(unit_var: None, unit_var_1: None) -> str:
    return "delete_file_async"


def method8(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def method9(v0_1: int64 | None=None) -> int64 | None:
    return v0_1


def closure17(unit_var: None, unit_var_1: None) -> tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]:
    v0_1: Mut1 = Mut1(True)
    v1: Mut0 = Mut0(int64(0))
    v3: Mut2 = Mut2(US3(0))
    v4: Mut1 = Mut1(False)
    _v5: (int64 | None) | None = None
    x: int64 | None = method9(None)
    _v5 = some(x)
    return (v1, v4, v0_1, v3, value(_v5))


def closure19(unit_var: None, v0_1: int64) -> US5:
    return US5(0, v0_1)


def method10(__unit: None=None) -> Callable[[int64], US5]:
    def _arrow97(v: int64) -> US5:
        return closure19(None, v)

    return _arrow97


def method11(__unit: None=None) -> str:
    return ""


def closure18(v0_1: US3, v1: Callable[[], str], v2: Callable[[], str], unit_var: None) -> str:
    if equals(State_trace_state(), None):
        State_trace_state(closure17(None, None))

    pattern_input: tuple[Mut0, Mut1, Mut1, Mut2, int64 | None] = value(State_trace_state())
    _v9: str | None = None
    _v9 = None
    v60: str = value(_v9)
    v61: int64 = pattern_input[0].l0
    v71: str = "Debug" if (v0_1.tag == 1) else ("Info" if (v0_1.tag == 2) else ("Verbose" if (v0_1.tag == 0) else ("Warning" if (v0_1.tag == 3) else "Critical")))
    return trim_end(trim_start(((((((((("" + v60) + " #") + str(v61)) + " [") + v71.lower()) + "] ") + v1(None)) + " / ") + v2(None)) + ""), " ", "/")


def method7(v0_1: US3, v1: Callable[[], str], v2: Callable[[], str]) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2) -> tuple[Mut0, Mut1, Mut1, Mut2, int64 | None]:
        return closure17(None, None)

    if equals(State_trace_state(), None):
        State_trace_state(v3(None))

    v4: Mut0 = value(State_trace_state())[0]
    if equals(State_trace_state(), None):
        State_trace_state(v3(None))

    pattern_input_1: tuple[Mut0, Mut1, Mut1, Mut2, int64 | None] = value(State_trace_state())
    v14_1: US3 = pattern_input_1[3].l0
    if (compare(v0_1, v14_1) >= 0) if pattern_input_1[2].l0 else False:
        v19: int64 = op_addition(v4.l0, int64(1))
        v4.l0 = v19
        v21: str = ("" + closure18(v0_1, v1, v2, None)) + ""
        _v22: None | None = None
        _v22 = some(None)
        value(_v22)



def method6(v0_1: str, v1: int64) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value(_v2)


def closure15(unit_var: None, v0_1: str) -> Async[int64]:
    _v1: Async[int64] | None = None
    _v1 = None
    return value(_v1)


def closure22(unit_var: None, unit_var_1: None) -> str:
    return "move_file_async"


def method13(v0_1: str, v1: str, v2: Exception) -> str:
    _v3: str | None = None
    _v3 = None
    v10: str = value(_v3)
    def v11_1(v: str, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2) -> str:
        return closure2(None, v)

    return ((((((("old_path: " + v11_1(v1)) + " / new_path: ") + v11_1(v0_1)) + " / ex: ") + v10) + " / ") + closure3(None, None)) + ""


def closure23(v0_1: str, v1: str, v2: Exception, unit_var: None) -> str:
    return method13(v0_1, v1, v2)


def method12(v0_1: str, v1: str, v2: int64) -> Async[int64]:
    _v3: Async[int64] | None = None
    _v3 = None
    return value(_v3)


def closure21(v0_1: str, v1: str) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value(_v2)


def closure20(unit_var: None, v0_1: str) -> Callable[[str], Async[int64]]:
    def _arrow98(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure21(v0_1, v)

    return _arrow98


def closure25(unit_var: None, v0_1: int64) -> US6:
    return US6(0, v0_1)


def closure26(unit_var: None, v0_1: Exception) -> US6:
    return US6(1, v0_1)


def closure27(unit_var: None, unit_var_1: None) -> str:
    return "run_with_timeout_async"


def closure28(unit_var: None, unit_var_1: None) -> str:
    return ((("timeout: " + str(1000)) + " / ") + closure3(None, None)) + ""


def closure29(v0_1: str, unit_var: None) -> str:
    return ("run_with_timeout_async** / ex: " + v0_1) + ""


def closure30(unit_var: None, unit_var_1: None) -> str:
    return "read_all_text_retry_async"


def method15(v0_1: int64, v1: str) -> str:
    return ((((("retry: " + str(v0_1)) + " / ex: ") + v1) + " / ") + closure3(None, None)) + ""


def closure31(v0_1: int64, v1: str, unit_var: None) -> str:
    return method15(v0_1, v1)


def method14(v0_1: str, v1: int64) -> Async[str | None]:
    _v2: Async[str | None] | None = None
    _v2 = None
    return value(_v2)


def closure24(unit_var: None, v0_1: str) -> Async[str | None]:
    _v1: Async[str | None] | None = None
    _v1 = None
    return value(_v1)


def closure33(unit_var: None, unit_var_1: None) -> str:
    _v0_1: str | None = None
    _v0_1 = None
    return value(_v0_1)


def closure32(unit_var: None, unit_var_1: None) -> str:
    _v0_1: str | None = None
    _v0_1 = None
    return value(_v0_1)


def closure35(v0_1: str, v1: str, unit_var: None) -> str:
    return ((((("temp_folder: " + v0_1) + " / result: ") + v1) + " ") + closure3(None, None)) + ""


def closure36(v0_1: str, unit_var: None) -> None:
    _v1: Async[int64] | None = None
    _v1 = None
    v9: Async[int64] = value(_v1)
    _v10: Async[None] | None = None
    _v10 = None
    v18: Async[None] = value(_v10)
    _v19: None | None = None
    _v19 = some(None)
    value(_v19)


def closure34(unit_var: None, unit_var_1: None) -> tuple[str, IDisposable]:
    _v0_1: tuple[str, IDisposable] | None = None
    pattern_input: tuple[str, IDisposable] = (None, None)
    _v0_1 = (pattern_input[0], pattern_input[1])
    pattern_input_1: tuple[str, IDisposable] = value(_v0_1)
    return (pattern_input_1[0], pattern_input_1[1])


def closure37(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def closure41(unit_var: None, v0_1: str) -> bool:
    _v1: bool | None = None
    _v1 = False
    return value(_v1)


def closure42(unit_var: None, v0_1: str) -> bool:
    _v1: bool | None = None
    _v1 = False
    return value(_v1)


def closure43(unit_var: None, v0_1: str) -> str | None:
    _v1: US8 | None = None
    x: US8 = US8()
    _v1 = x
    v41: US8 = value(_v1)
    if v41.tag == 0:
        return v41.fields[0]

    else: 
        return None



def method17(__unit: None=None) -> Callable[[str], str | None]:
    def _arrow99(v: str) -> str | None:
        return closure43(None, v)

    return _arrow99


def closure44(unit_var: None, v0_1: str) -> US8:
    return US8(0, v0_1)


def method18(__unit: None=None) -> Callable[[str], US8]:
    def _arrow100(v: str) -> US8:
        return closure44(None, v)

    return _arrow100


def method19(v0_1_mut: str, v1_mut: bool, v2_mut: str, v3_mut: str) -> str:
    while True:
        (v0_1, v1, v2, v3) = (v0_1_mut, v1_mut, v2_mut, v3_mut)
        _v4: str | None = None
        _v4 = None
        def _arrow101(v: str, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2, v3: Any=v3) -> bool:
            return closure41(None, v)

        def _arrow102(v_1: str, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2, v3: Any=v3) -> bool:
            return closure42(None, v_1)

        if (_arrow101 if v1 else _arrow102)(value(_v4)):
            return v3

        else: 
            v37: str | None = method17()(v3)
            v40: US8 = default_arg(map(method18(), v37), US8(1))
            if v40.tag == 0:
                v0_1_mut = v0_1
                v1_mut = v1
                v2_mut = v2
                v3_mut = v40.fields[0]
                continue

            else: 
                raise Exception(((((((("No parent for " + ("file" if v1 else "dir")) + " \'") + v0_1) + "\' at \'") + v2) + "\' (until \'") + v3) + "\')")


        break


def method16(v0_1: str, v1: bool, v2: str) -> str:
    _v3: str | None = None
    _v3 = None
    def _arrow103(v: str, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2) -> bool:
        return closure41(None, v)

    def _arrow104(v_1: str, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2) -> bool:
        return closure42(None, v_1)

    if (_arrow103 if v1 else _arrow104)(value(_v3)):
        return v2

    else: 
        v36: str | None = method17()(v2)
        v39: US8 = default_arg(map(method18(), v36), US8(1))
        if v39.tag == 0:
            return method19(v0_1, v1, v2, v39.fields[0])

        else: 
            raise Exception(((((((("No parent for " + ("file" if v1 else "dir")) + " \'") + v0_1) + "\' at \'") + v2) + "\' (until \'") + v2) + "\')")




def closure40(v0_1: str, v1: bool, v2: str) -> str:
    return method16(v0_1, v1, v2)


def closure39(v0_1: str, v1: bool) -> Callable[[str], str]:
    def _arrow105(v: str, v0_1: Any=v0_1, v1: Any=v1) -> str:
        return closure40(v0_1, v1, v)

    return _arrow105


def closure38(unit_var: None, v0_1: str) -> Callable[[bool, str], str]:
    def _arrow106(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure39(v0_1, v)

    return _arrow106


def closure46(v0_1: str, v1: str) -> str:
    _v2: str | None = None
    _v2 = None
    return value(_v2)


def closure45(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow107(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure46(v0_1, v)

    return _arrow107


v0: None | None = None

_v0: None | None = create_atom(v0)

_v0(some(None))

value(_v0())

def _arrow108(__unit: None=None) -> str:
    return closure32(None, None)


v11: Callable[[], str] = _arrow108

def create_temp_directory_name(__unit: None=None) -> str:
    return v11(None)


def _arrow109(__unit: None=None) -> tuple[str, IDisposable]:
    return closure34(None, None)


v12: Callable[[], tuple[str, IDisposable]] = _arrow109

def create_temp_directory(__unit: None=None) -> tuple[str, IDisposable]:
    return v12(None)


def _arrow110(__unit: None=None) -> str:
    return closure37(None, None)


v13: Callable[[], str] = _arrow110

def get_source_directory(__unit: None=None) -> str:
    return v13(None)


def _arrow111(v: str) -> Callable[[bool, str], str]:
    return closure38(None, v)


v14: Callable[[str, bool, str], str] = _arrow111

def find_parent(x: str) -> Callable[[bool, str], str]:
    return v14(x)


def _arrow112(v: str) -> Callable[[str], str]:
    return closure45(None, v)


v15: Callable[[str, str], str] = _arrow112

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v15(x)


