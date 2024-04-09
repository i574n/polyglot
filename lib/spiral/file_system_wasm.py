from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from typing import (Protocol, Any)
from fable_modules.fable_library.async_builder import Async
from fable_modules.fable_library.option import (value, some, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, class_type, string_type)
from fable_modules.fable_library.types import (Array, Union, FSharpRef, int64)
from fable_modules.fable_library.util import (IDisposable, create_atom)

class IFsExistsSync(Protocol):
    @abstractmethod
    def exists_sync(self, path: str) -> bool:
        ...


class IPathJoin(Protocol):
    @abstractmethod
    def join(self, paths: Array[str]) -> str:
        ...


class IPathDirname(Protocol):
    @abstractmethod
    def dirname(self, path: str) -> str:
        ...


def _expr65() -> TypeInfo:
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


US1_reflection = _expr65

def _expr66() -> TypeInfo:
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


US2_reflection = _expr66

def _expr67() -> TypeInfo:
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


US0_reflection = _expr67

def _expr68() -> TypeInfo:
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


US3_reflection = _expr68

def _expr69() -> TypeInfo:
    return union_type("File_system.US4", [], US4, lambda: [[("f0_0", int64_type)], [("f1_0", class_type("System.Exception"))]])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1"]


US4_reflection = _expr69

def _expr70() -> TypeInfo:
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


US5_reflection = _expr70

def _expr71() -> TypeInfo:
    return union_type("File_system.US6", [], US6, lambda: [[("f0_0", string_type)], []])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1"]


US6_reflection = _expr71

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


def method3(v0_1: str, v1: str) -> str:
    return ((((("path: " + closure2(None, v0_1)) + " / ex: ") + v1) + " / ") + closure3(None, None)) + ""


def closure6(v0_1: str, v1: str, unit_var: None) -> str:
    return method3(v0_1, v1)


def method2(v0_1: str, v1: US2, v2: US1, v3: int64) -> Async[int64]:
    _v4: Async[int64] | None = None
    _v4 = None
    return value(_v4)


def closure5(v0_1: US0, v1: str) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value(_v2)


def closure4(unit_var: None, v0_1: US0) -> Callable[[str], Async[int64]]:
    def _arrow72(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure5(v0_1, v)

    return _arrow72


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
    def _arrow73(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[bool]:
        return closure10(v0_1, v)

    return _arrow73


def closure12(v0_1: str, v1: str) -> Async[None]:
    _v2: Async[None] | None = None
    _v2 = None
    return value(_v2)


def closure11(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow74(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure12(v0_1, v)

    return _arrow74


def closure14(v0_1: str, v1: str) -> Async[None]:
    _v2: Async[None] | None = None
    _v2 = None
    return value(_v2)


def closure13(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow75(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure14(v0_1, v)

    return _arrow75


def method6(v0_1: str, v1: int64) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value(_v2)


def closure15(unit_var: None, v0_1: str) -> Async[int64]:
    _v1: Async[int64] | None = None
    _v1 = None
    return value(_v1)


def method8(v0_1: str, v1: str, v2: Exception) -> str:
    _v3: str | None = None
    _v3 = None
    v9: str = value(_v3)
    def v10(v: str, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2) -> str:
        return closure2(None, v)

    return ((((((("old_path: " + v10(v1)) + " / new_path: ") + v10(v0_1)) + " / ex: ") + v9) + " / ") + closure3(None, None)) + ""


def closure18(v0_1: str, v1: str, v2: Exception, unit_var: None) -> str:
    return method8(v0_1, v1, v2)


def method7(v0_1: str, v1: str, v2: int64) -> Async[int64]:
    _v3: Async[int64] | None = None
    _v3 = None
    return value(_v3)


def closure17(v0_1: str, v1: str) -> Async[int64]:
    _v2: Async[int64] | None = None
    _v2 = None
    return value(_v2)


def closure16(unit_var: None, v0_1: str) -> Callable[[str], Async[int64]]:
    def _arrow76(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure17(v0_1, v)

    return _arrow76


def closure20(unit_var: None, v0_1: int64) -> US4:
    return US4(0, v0_1)


def closure21(unit_var: None, v0_1: Exception) -> US4:
    return US4(1, v0_1)


def closure22(unit_var: None, unit_var_1: None) -> str:
    return ((("timeout: " + str(1000)) + " / ") + closure3(None, None)) + ""


def method10(v0_1: int64, v1: str) -> str:
    return ((((("retry: " + str(v0_1)) + " / ex: ") + v1) + " / ") + closure3(None, None)) + ""


def closure23(v0_1: int64, v1: str, unit_var: None) -> str:
    return method10(v0_1, v1)


def method9(v0_1: str, v1: int64) -> Async[str | None]:
    _v2: Async[str | None] | None = None
    _v2 = None
    return value(_v2)


def closure19(unit_var: None, v0_1: str) -> Async[str | None]:
    _v1: Async[str | None] | None = None
    _v1 = None
    return value(_v1)


def closure25(unit_var: None, unit_var_1: None) -> str:
    _v0_1: str | None = None
    _v0_1 = None
    return value(_v0_1)


def closure24(unit_var: None, unit_var_1: None) -> str:
    _v0_1: str | None = None
    _v0_1 = None
    return value(_v0_1)


def closure27(v0_1: str, v1: str, unit_var: None) -> str:
    return ((((("temp_folder: " + v0_1) + " / result: ") + v1) + " ") + closure3(None, None)) + ""


def closure28(v0_1: str, unit_var: None) -> None:
    _v1: Async[int64] | None = None
    _v1 = None
    v8: Async[int64] = value(_v1)
    _v9: Async[None] | None = None
    _v9 = None
    v16: Async[None] = value(_v9)
    _v17: None | None = None
    _v17 = some(None)
    value(_v17)


def closure26(unit_var: None, unit_var_1: None) -> tuple[str, IDisposable]:
    _v0_1: tuple[str, IDisposable] | None = None
    _v0_1 = (None, None)
    pattern_input: tuple[str, IDisposable] = value(_v0_1)
    return (pattern_input[0], pattern_input[1])


def closure29(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def closure33(unit_var: None, v0_1: str) -> bool:
    _v1: bool | None = None
    _v1 = False
    return value(_v1)


def closure34(unit_var: None, v0_1: str) -> bool:
    _v1: bool | None = None
    _v1 = False
    return value(_v1)


def closure35(unit_var: None, v0_1: str) -> str | None:
    _v1: US6 | None = None
    x: US6 = US6()
    _v1 = x
    v39: US6 = value(_v1)
    if v39.tag == 0:
        return v39.fields[0]

    else: 
        return None



def method12(__unit: None=None) -> Callable[[str], str | None]:
    def _arrow77(v: str) -> str | None:
        return closure35(None, v)

    return _arrow77


def closure36(unit_var: None, v0_1: str) -> US6:
    return US6(0, v0_1)


def method13(__unit: None=None) -> Callable[[str], US6]:
    def _arrow78(v: str) -> US6:
        return closure36(None, v)

    return _arrow78


def method14(v0_1_mut: str, v1_mut: bool, v2_mut: str, v3_mut: str) -> str:
    while True:
        (v0_1, v1, v2, v3) = (v0_1_mut, v1_mut, v2_mut, v3_mut)
        _v4: str | None = None
        _v4 = None
        def _arrow79(v: str, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2, v3: Any=v3) -> bool:
            return closure33(None, v)

        def _arrow80(v_1: str, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2, v3: Any=v3) -> bool:
            return closure34(None, v_1)

        if (_arrow79 if v1 else _arrow80)(value(_v4)):
            return v3

        else: 
            v36: str | None = method12()(v3)
            v39: US6 = default_arg(map(method13(), v36), US6(1))
            if v39.tag == 0:
                v0_1_mut = v0_1
                v1_mut = v1
                v2_mut = v2
                v3_mut = v39.fields[0]
                continue

            else: 
                raise Exception(((((("No parent for " + ("file" if v1 else "dir")) + " \'") + v0_1) + "\' at \'") + v2) + "\'")


        break


def method11(v0_1: str, v1: bool, v2: str) -> str:
    _v3: str | None = None
    _v3 = None
    def _arrow81(v: str, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2) -> bool:
        return closure33(None, v)

    def _arrow82(v_1: str, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2) -> bool:
        return closure34(None, v_1)

    if (_arrow81 if v1 else _arrow82)(value(_v3)):
        return v2

    else: 
        v35: str | None = method12()(v2)
        v38: US6 = default_arg(map(method13(), v35), US6(1))
        if v38.tag == 0:
            return method14(v0_1, v1, v2, v38.fields[0])

        else: 
            raise Exception(((((("No parent for " + ("file" if v1 else "dir")) + " \'") + v0_1) + "\' at \'") + v2) + "\'")




def closure32(v0_1: str, v1: bool, v2: str) -> str:
    return method11(v0_1, v1, v2)


def closure31(v0_1: str, v1: bool) -> Callable[[str], str]:
    def _arrow83(v: str, v0_1: Any=v0_1, v1: Any=v1) -> str:
        return closure32(v0_1, v1, v)

    return _arrow83


def closure30(unit_var: None, v0_1: str) -> Callable[[bool, str], str]:
    def _arrow84(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str], str]:
        return closure31(v0_1, v)

    return _arrow84


def closure38(v0_1: str, v1: str) -> str:
    _v2: str | None = None
    _v2 = None
    return value(_v2)


def closure37(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow85(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure38(v0_1, v)

    return _arrow85


v0: None | None = None

_v0: None | None = create_atom(v0)

_v0(some(None))

value(_v0())

def _arrow86(__unit: None=None) -> str:
    return closure24(None, None)


v11: Callable[[], str] = _arrow86

def create_temp_directory_name(__unit: None=None) -> str:
    return v11(None)


def _arrow87(__unit: None=None) -> tuple[str, IDisposable]:
    return closure26(None, None)


v12: Callable[[], tuple[str, IDisposable]] = _arrow87

def create_temp_directory(__unit: None=None) -> tuple[str, IDisposable]:
    return v12(None)


def _arrow88(__unit: None=None) -> str:
    return closure29(None, None)


v13: Callable[[], str] = _arrow88

def get_source_directory(__unit: None=None) -> str:
    return v13(None)


def _arrow89(v: str) -> Callable[[bool, str], str]:
    return closure30(None, v)


v14: Callable[[str, bool, str], str] = _arrow89

def find_parent(x: str) -> Callable[[bool, str], str]:
    return v14(x)


def _arrow90(v: str) -> Callable[[str], str]:
    return closure37(None, v)


v15: Callable[[str, str], str] = _arrow90

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v15(x)


