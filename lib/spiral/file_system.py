from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.async_builder import Async
from fable_modules.fable_library.date import (ticks as ticks_2, now, to_string, create as create_1)
from fable_modules.fable_library.guid import (parse, new_guid)
from fable_modules.fable_library.list import (to_array, empty, of_array, singleton)
from fable_modules.fable_library.long import (op_addition, op_subtraction)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_3, default_arg)
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.string_ import (to_text, interpolate, pad_left, trim_end, trim_start, replace)
from fable_modules.fable_library.time_span import (hours, to_string as to_string_1, create, minutes, seconds, milliseconds)
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


def _expr205() -> TypeInfo:
    return class_type("File_system.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr205

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


class IPathDirname(Protocol):
    @abstractmethod
    def dirname(self, path: str) -> str:
        ...


def _expr206() -> TypeInfo:
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


US0_reflection = _expr206

def _expr207() -> TypeInfo:
    return record_type("File_system.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr207

def _expr208() -> TypeInfo:
    return record_type("File_system.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr208

def _expr209() -> TypeInfo:
    return record_type("File_system.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr209

def _expr210() -> TypeInfo:
    return record_type("File_system.Mut3", [], Mut3, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: US0

Mut3_reflection = _expr210

def _expr211() -> TypeInfo:
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


US1_reflection = _expr211

def _expr212() -> TypeInfo:
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


US2_reflection = _expr212

def _expr213() -> TypeInfo:
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


US3_reflection = _expr213

def _expr214() -> TypeInfo:
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


US4_reflection = _expr214

def _expr215() -> TypeInfo:
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


US5_reflection = _expr215

def _expr216() -> TypeInfo:
    return record_type("File_system.Mut4", [], Mut4, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: str

Mut4_reflection = _expr216

def _expr217() -> TypeInfo:
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


US7_reflection = _expr217

def _expr218() -> TypeInfo:
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


US8_reflection = _expr218

def _expr219() -> TypeInfo:
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


US6_reflection = _expr219

def _expr220() -> TypeInfo:
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


US9_reflection = _expr220

def _expr221() -> TypeInfo:
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


US10_reflection = _expr221

def _expr222() -> TypeInfo:
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


US11_reflection = _expr222

def _expr223() -> TypeInfo:
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


US12_reflection = _expr223

def _expr224() -> TypeInfo:
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


US13_reflection = _expr224

def method1(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method3(__unit: None=None) -> str:
    return ""


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
    x_4: US1 | None
    if v61 is None:
        x_4 = None

    else: 
        x_2: str = v61
        def x_3(__unit: None=None, v0_1: Any=v0_1) -> US1:
            return US1(0, x_2)

        x_4 = x_3(None)

    _v64.contents = x_4
    v79: US1 = default_arg(_v64.contents, US1(1))
    if v79.tag == 0:
        return v79.fields[0]

    else: 
        return ""



def method4(__unit: None=None) -> str:
    return "AUTOMATION"


def closure0(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
    v173: str = method2(method1())
    v178: US2 = US2(0, US0(0)) if ("Verbose" == v173) else US2(1)
    def _arrow225(__unit: None=None, v0_1: Any=v0_1) -> US2:
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




    _v1: tuple[US2, US3] = (US2(0, v178.fields[0]) if (v178.tag == 0) else _arrow225(), US3(0, ticks_2(now())) if (method2(method4()) == "True") else US3(1))
    v295: US3 = _v1[1]
    v294: US2 = _v1[0]
    def v365(v: str, v0_1: Any=v0_1) -> None:
        closure0(None, v)

    return (Mut0(int64(0)), Mut1(v365), Mut2(True), Mut3(v294.fields[0] if (v294.tag == 0) else v0_1), v295.fields[0] if (v295.tag == 0) else None)


def method7(v0_1: str) -> str:
    return v0_1


def method8(v0_1: str) -> bool:
    return None


def method6(v0_1: bool, v1: str) -> None:
    pass


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


def closure2(unit_var: None, unit_var_1: None) -> str:
    return "file_system.delete_directory_async"


def method5(v0_1: str, v1: int64) -> Async[int64]:
    return None


def closure1(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def closure5(unit_var: None, unit_var_1: None) -> str:
    return "file_system.wait_for_file_access"


def method14(v0_1: str, v1: US8, v2: US7, v3: int64) -> Async[int64]:
    return None


def closure4(v0_1: US6, v1: str) -> Async[int64]:
    return None


def closure3(unit_var: None, v0_1: US6) -> Callable[[str], Async[int64]]:
    def _arrow226(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure4(v0_1, v)

    return _arrow226


def method15(v0_1: str, v1: int64) -> Async[int64]:
    return None


def closure6(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def closure7(unit_var: None, v0_1: str) -> Async[str]:
    return None


def method17(v0_1: str) -> bool:
    return None


def method18(v0_1: Vec_1[uint8]) -> Vec_1[uint8]:
    return v0_1


def method16(v0_1: str, v1: str) -> bool:
    return None


def closure9(v0_1: str, v1: str) -> bool:
    return method16(v0_1, v1)


def closure8(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow227(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure9(v0_1, v)

    return _arrow227


def closure11(v0_1: str, v1: str) -> Async[None]:
    return None


def closure10(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow228(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure11(v0_1, v)

    return _arrow228


def closure13(v0_1: str, v1: str) -> Async[None]:
    return None


def closure12(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow229(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure13(v0_1, v)

    return _arrow229


def closure15(unit_var: None, unit_var_1: None) -> str:
    return "delete_file_async"


def method19(v0_1: str, v1: int64) -> Async[int64]:
    return None


def closure14(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def closure18(unit_var: None, unit_var_1: None) -> str:
    return "move_file_async"


def method20(v0_1: str, v1: str, v2: int64) -> Async[int64]:
    return None


def closure17(v0_1: str, v1: str) -> Async[int64]:
    return None


def closure16(unit_var: None, v0_1: str) -> Callable[[str], Async[int64]]:
    def _arrow230(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure17(v0_1, v)

    return _arrow230


def closure20(unit_var: None, v0_1: int64) -> US9:
    return US9(0, v0_1)


def closure21(unit_var: None, v0_1: Exception) -> US9:
    return US9(1, v0_1)


def closure22(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async"


def closure23(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async**"


def closure24(unit_var: None, unit_var_1: None) -> str:
    return "read_all_text_retry_async"


def method21(v0_1: str, v1: int64) -> Async[str | None]:
    return None


def closure19(unit_var: None, v0_1: str) -> Async[str | None]:
    return None


def method24(__unit: None=None) -> str:
    return "hh:mm"


def method25(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method26(__unit: None=None) -> str:
    return "hhmm"


def method23(v0_1: str, v1: Any) -> str:
    v428: str = to_string(v1, method25())
    v497: Any
    raise Exception(("date_time.get_utc_offset / target: " + str(US5(4, US4(0)))) + "")
    v508: uint8 = uint8(1) if (hours(v497) > 0) else uint8(0)
    v509: str = method26()
    v520: str = ((("" + str(v508)) + "") + to_string_1(v497, "c", {})) + ""
    v522: str = str(v0_1)
    return parse(((((("" + v428) + "") + v520) + "") + v522[len(v428) + len(v520):len(v522)]) + "")


def method28(__unit: None=None) -> str:
    raise Exception(("file_system.get_temp_path / target: " + str(US5(4, US4(0)))) + "")


def method29(__unit: None=None) -> str:
    return "!create_temp_path_"


def method32(v0_1: str) -> str:
    return v0_1


def method31(v0_1: str, v1: str) -> tuple[str, str]:
    return (v1, method32(v0_1))


def method30(v0_1: str, v1: str) -> str:
    raise Exception(((((("file_system.(</>) / target: " + str(US5(4, US4(0)))) + " / a: ") + v0_1) + " / b: ") + v1) + "")


def method34(__unit: None=None) -> str:
    return "CARGO_PKG_NAME"


def method33(__unit: None=None) -> str:
    raise Exception(("env.get_entry_assembly_name / target: " + str(US5(4, US4(0)))) + "")


def method27(v0_1: str) -> str:
    return method30(method30(method30(method28(), method29()), method33()), str(v0_1))


def method22(__unit: None=None) -> str:
    v31: Any = now()
    return method27(method23(new_guid(), v31))


def closure25(unit_var: None, unit_var_1: None) -> str:
    return method22()


def method36(v0_1: str) -> str:
    return v0_1


def closure27(unit_var: None, v0_1: std_io_error) -> std_string_string:
    return None


def method37(__unit: None=None) -> Callable[[std_io_error], std_string_string]:
    def _arrow231(v: std_io_error) -> std_string_string:
        return closure27(None, v)

    return _arrow231


def closure28(unit_var: None, unit_var_1: None) -> US12:
    return US12(0)


def closure29(unit_var: None, v0_1: std_string_string) -> US12:
    return US12(1, v0_1)


def closure30(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_dir"


def closure31(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_dir"


def closure32(v0_1: str, unit_var: None) -> None:
    method6(True, v0_1)


def method38(v0_1: str) -> Callable[[], None]:
    def _arrow232(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure32(v0_1, None)

    return _arrow232


def method39(v0_1: str) -> Callable[[], None]:
    def _arrow233(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure32(v0_1, None)

    return _arrow233


def closure33(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_dir"


def closure34(v0_1: str, unit_var: None) -> None:
    pass


def method40(v0_1: str) -> Callable[[], None]:
    def _arrow234(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure34(v0_1, None)

    return _arrow234


def method41(v0_1: str) -> Callable[[], None]:
    def _arrow235(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure34(v0_1, None)

    return _arrow235


def method35(v0_1: str) -> IDisposable:
    v2251: bool = None
    if v2251 == False:
        v2280: str = to_text(interpolate("%A%P()", [{
            "CreationTime": None,
            "Exists": v2251
        }]))
        if State_trace_state() is None:
            pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
            State_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4]))

        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        v2295: Mut0 = pattern_input_1[0]
        if State_trace_state() is None:
            pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
            State_trace_state((pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4]))

        pattern_input_3: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        v2337: US0 = pattern_input_3[3].l0
        class ObjectExpr236:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        if False if (pattern_input_3[2].l0 == False) else (1 >= find(v2337, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr236()))):
            v2344: int64 = op_addition(v2295.l0, int64(1))
            v2295.l0 = v2344
            if State_trace_state() is None:
                pattern_input_4: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
                State_trace_state((pattern_input_4[0], pattern_input_4[1], pattern_input_4[2], pattern_input_4[3], pattern_input_4[4]))

            pattern_input_5: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
            v2361: int64 | None = pattern_input_5[4]
            _v2599: FSharpRef[US3 | None] = FSharpRef(None)
            x_3: US3 | None
            if v2361 is None:
                x_3 = None

            else: 
                x_1: int64 = v2361
                def x_2(__unit: None=None, v0_1: Any=v0_1) -> US3:
                    return US3(0, x_1)

                x_3 = x_2(None)

            _v2599.contents = x_3
            v2614: US3 = default_arg(_v2599.contents, US3(1))
            def _arrow237(__unit: None=None, v0_1: Any=v0_1) -> Any:
                v2628: Any = create(op_subtraction(ticks_2(now()), v2614.fields[0]))
                return create_1(1, 1, 1, hours(v2628), minutes(v2628), seconds(v2628), milliseconds(v2628))

            v2659: str = to_string(_arrow237() if (v2614.tag == 0) else now(), method10())
            v2850: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method11()
            v2861: int64 = pattern_input_5[0].l0
            v2863: Mut4 = Mut4(method13())
            v2869: str = v2863.l0 + (("" + "{ ") + "")
            v2863.l0 = v2869
            v2875: str = v2863.l0 + (("" + "dir") + "")
            v2863.l0 = v2875
            v2881: str = v2863.l0 + (("" + " = ") + "")
            v2863.l0 = v2881
            v2886: str = v2863.l0 + (("" + v0_1) + "")
            v2863.l0 = v2886
            v2892: str = v2863.l0 + (("" + "; ") + "")
            v2863.l0 = v2892
            v2898: str = v2863.l0 + (("" + "result") + "")
            v2863.l0 = v2898
            v2903: str = v2863.l0 + (("" + " = ") + "")
            v2863.l0 = v2903
            v2908: str = v2863.l0 + (("" + v2280) + "")
            v2863.l0 = v2908
            v2914: str = v2863.l0 + (("" + " }") + "")
            v2863.l0 = v2914
            v2915: str = v2863.l0
            v2954: str = trim_end(trim_start(((((((((("" + v2659) + " ") + v2850) + " #") + str(v2861)) + " ") + closure33(None, None)) + " / ") + v2915) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
            print(v2954)
            pattern_input_1[1].l0(v2954)


    v2986: Callable[[], None] = method41(v0_1)
    class ObjectExpr238(IDisposable):
        def Dispose(self, __unit: None=None, v0_1: Any=v0_1) -> None:
            v2986(None)

    return ObjectExpr238()


def closure26(unit_var: None, unit_var_1: None) -> tuple[str, IDisposable]:
    v0_1: str = method22()
    return (v0_1, method35(v0_1))


def method42(v0_1: str) -> str:
    v56: str = pad_left(v0_1, 32, "0")
    return parse(((((((((("" + v56[0:7 + 1]) + "-") + v56[8:11 + 1]) + "-") + v56[12:15 + 1]) + "-") + v56[16:19 + 1]) + "-") + v56[20:31 + 1]) + "")


def closure35(unit_var: None, v0_1: str) -> tuple[str, IDisposable]:
    v2: str = method27(method42(v0_1))
    return (v2, method35(v2))


def closure36(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def method44(v0_1: str) -> str:
    return v0_1


def method43(v0_1: str) -> str:
    if v0_1 == "":
        return ""

    else: 
        v30_1: str = None
        def _arrow239(__unit: None=None, v0_1: Any=v0_1) -> str:
            _arg: str = v30_1[0]
            return _arg.lower()

        return replace(((("" + _arrow239()) + "") + v30_1[1:len(v30_1)]) + "", "\\", "/")



def closure37(unit_var: None, v0_1: str) -> str:
    return method43(v0_1)


def closure38(unit_var: None, v0_1: str) -> str:
    return ("file:///" + trim_start(v0_1, *to_array(singleton("/")))) + ""


def method47(v0_1: str) -> str | None:
    v85: US1 = None
    if v85.tag == 0:
        return v85.fields[0]

    else: 
        return None



def closure40(unit_var: None, v0_1: str) -> str | None:
    return method47(v0_1)


def method46(__unit: None=None) -> Callable[[str], str | None]:
    def _arrow240(v: str) -> str | None:
        return closure40(None, v)

    return _arrow240


def method48(v0_1_mut: str, v1_mut: str, v2_mut: str) -> US13:
    while True:
        (v0_1, v1, v2) = (v0_1_mut, v1_mut, v2_mut)
        if method8(method30(v2, v0_1)):
            return US13(0, v2)

        else: 
            v7: str | None = method46()(v2)
            _v8: FSharpRef[US1 | None] = FSharpRef(None)
            x_2: US1 | None
            if v7 is None:
                x_2 = None

            else: 
                x: str = v7
                def x_1(__unit: None=None, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2) -> US1:
                    return US1(0, x)

                x_2 = x_1(None)

            _v8.contents = x_2
            v23_1: US1 = default_arg(_v8.contents, US1(1))
            if v23_1.tag == 0:
                v0_1_mut = v0_1
                v1_mut = v1
                v2_mut = v23_1.fields[0]
                continue

            else: 
                return US13(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1) + "\' (until \'") + v2) + "\')")


        break


def method45(v0_1: str, v1: str) -> US13:
    if method8(method30(v1, v0_1)):
        return US13(0, v1)

    else: 
        v6: str | None = method46()(v1)
        _v7: FSharpRef[US1 | None] = FSharpRef(None)
        x_2: US1 | None
        if v6 is None:
            x_2 = None

        else: 
            x: str = v6
            def x_1(__unit: None=None, v0_1: Any=v0_1, v1: Any=v1) -> US1:
                return US1(0, x)

            x_2 = x_1(None)

        _v7.contents = x_2
        v22_1: US1 = default_arg(_v7.contents, US1(1))
        if v22_1.tag == 0:
            return method48(v0_1, v1, v22_1.fields[0])

        else: 
            return US13(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1) + "\' (until \'") + v1) + "\')")




def closure41(unit_var: None, unit_var_1: None) -> str:
    return "file_system.get_workspace_root"


def method49(__unit: None=None) -> str:
    return None


def closure39(unit_var: None, unit_var_1: None) -> str:
    v4: US13 = method45(method30("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral")
    v682: US1
    if v4.tag == 0:
        v682 = US1(0, v4.fields[0])

    else: 
        if State_trace_state() is None:
            pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
            State_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4]))

        pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        v20_1: Mut0 = pattern_input_1[0]
        if State_trace_state() is None:
            pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
            State_trace_state((pattern_input_2[0], pattern_input_2[1], pattern_input_2[2], pattern_input_2[3], pattern_input_2[4]))

        pattern_input_3: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        v62: US0 = pattern_input_3[3].l0
        class ObjectExpr241:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        if False if (pattern_input_3[2].l0 == False) else (3 >= find(v62, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr241()))):
            v69: int64 = op_addition(v20_1.l0, int64(1))
            v20_1.l0 = v69
            if State_trace_state() is None:
                pattern_input_4: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
                State_trace_state((pattern_input_4[0], pattern_input_4[1], pattern_input_4[2], pattern_input_4[3], pattern_input_4[4]))

            pattern_input_5: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
            v86: int64 | None = pattern_input_5[4]
            _v324: FSharpRef[US3 | None] = FSharpRef(None)
            x_3: US3 | None
            if v86 is None:
                x_3 = None

            else: 
                x_1: int64 = v86
                def x_2(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> US3:
                    return US3(0, x_1)

                x_3 = x_2(None)

            _v324.contents = x_3
            v339: US3 = default_arg(_v324.contents, US3(1))
            def _arrow242(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> Any:
                v353: Any = create(op_subtraction(ticks_2(now()), v339.fields[0]))
                return create_1(1, 1, 1, hours(v353), minutes(v353), seconds(v353), milliseconds(v353))

            v384: str = to_string(_arrow242() if (v339.tag == 0) else now(), method10())
            v575: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method11()
            v586: int64 = pattern_input_5[0].l0
            v588: Mut4 = Mut4(method13())
            v594: str = v588.l0 + (("" + "{ ") + "")
            v588.l0 = v594
            v600: str = v588.l0 + (("" + "error") + "")
            v588.l0 = v600
            v606: str = v588.l0 + (("" + " = ") + "")
            v588.l0 = v606
            v611: str = v588.l0 + (("" + v4.fields[0]) + "")
            v588.l0 = v611
            v617: str = v588.l0 + (("" + " }") + "")
            v588.l0 = v617
            v618: str = v588.l0
            v657: str = trim_end(trim_start(((((((((("" + v384) + " ") + v575) + " #") + str(v586)) + " ") + closure41(None, None)) + " / ") + v618) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
            print(v657)
            pattern_input_1[1].l0(v657)

        v682 = US1(1)

    v1367: US1
    if v682.tag == 0:
        v1367 = US1(0, v682.fields[0])

    else: 
        v685: str = method49()
        v687: US13 = method45(method30("polyglot", ".devcontainer"), v685)
        if v687.tag == 0:
            v1367 = US1(0, v687.fields[0])

        else: 
            if State_trace_state() is None:
                pattern_input_6: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
                State_trace_state((pattern_input_6[0], pattern_input_6[1], pattern_input_6[2], pattern_input_6[3], pattern_input_6[4]))

            pattern_input_7: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
            v703: Mut0 = pattern_input_7[0]
            if State_trace_state() is None:
                pattern_input_8: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
                State_trace_state((pattern_input_8[0], pattern_input_8[1], pattern_input_8[2], pattern_input_8[3], pattern_input_8[4]))

            pattern_input_9: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
            v745: US0 = pattern_input_9[3].l0
            class ObjectExpr243:
                @property
                def Compare(self) -> Callable[[US0, US0], int]:
                    return compare

            if False if (pattern_input_9[2].l0 == False) else (3 >= find(v745, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr243()))):
                v752: int64 = op_addition(v703.l0, int64(1))
                v703.l0 = v752
                if State_trace_state() is None:
                    pattern_input_10: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
                    State_trace_state((pattern_input_10[0], pattern_input_10[1], pattern_input_10[2], pattern_input_10[3], pattern_input_10[4]))

                pattern_input_11: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
                v769: int64 | None = pattern_input_11[4]
                _v1007: FSharpRef[US3 | None] = FSharpRef(None)
                x_7: US3 | None
                if v769 is None:
                    x_7 = None

                else: 
                    x_5: int64 = v769
                    def x_6(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> US3:
                        return US3(0, x_5)

                    x_7 = x_6(None)

                _v1007.contents = x_7
                v1022: US3 = default_arg(_v1007.contents, US3(1))
                def _arrow244(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> Any:
                    v1036: Any = create(op_subtraction(ticks_2(now()), v1022.fields[0]))
                    return create_1(1, 1, 1, hours(v1036), minutes(v1036), seconds(v1036), milliseconds(v1036))

                v1067: str = to_string(_arrow244() if (v1022.tag == 0) else now(), method10())
                v1258: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method11()
                v1269: int64 = pattern_input_11[0].l0
                v1271: Mut4 = Mut4(method13())
                v1277: str = v1271.l0 + (("" + "{ ") + "")
                v1271.l0 = v1277
                v1283: str = v1271.l0 + (("" + "error") + "")
                v1271.l0 = v1283
                v1289: str = v1271.l0 + (("" + " = ") + "")
                v1271.l0 = v1289
                v1294: str = v1271.l0 + (("" + v687.fields[0]) + "")
                v1271.l0 = v1294
                v1300: str = v1271.l0 + (("" + " }") + "")
                v1271.l0 = v1300
                v1301: str = v1271.l0
                v1340: str = trim_end(trim_start(((((((((("" + v1067) + " ") + v1258) + " #") + str(v1269)) + " ") + closure41(None, None)) + " / ") + v1301) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
                print(v1340)
                pattern_input_7[1].l0(v1340)

            v1367 = US1(1)


    def _arrow245(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
        raise Exception("Option does not have a value.")

    return method30(v1367.fields[0] if (v1367.tag == 0) else _arrow245(), "polyglot")


def method50(v0_1: str) -> None:
    pass


def closure43(unit_var: None, v0_1: str) -> None:
    method50(v0_1)


def closure42(unit_var: None, v0_1: bool) -> None:
    if State_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
        State_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4]))

    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    def _arrow246(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure43(None, v)

    def _arrow247(v_1: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure0(None, v_1)

    v30_1: Callable[[str], None] = _arrow246 if v0_1 else _arrow247
    pattern_input_1[1].l0 = v30_1


def closure45(v0_1: str, v1: str) -> str:
    return method30(v0_1, v1)


def closure44(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow248(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure45(v0_1, v)

    return _arrow248


v0: bool = State_trace_state() is None


if v0:
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
    State_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4]))


def _arrow249(v: str) -> Async[int64]:
    return closure1(None, v)


v12: Callable[[str], Async[int64]] = _arrow249

def delete_directory_async(x: str) -> Async[int64]:
    return v12(x)


def _arrow250(v: US6) -> Callable[[str], Async[int64]]:
    return closure3(None, v)


v13: Callable[[US6, str], Async[int64]] = _arrow250

def wait_for_file_access(x: US6) -> Callable[[str], Async[int64]]:
    return v13(x)


def _arrow251(v: str) -> Async[int64]:
    return closure6(None, v)


v14: Callable[[str], Async[int64]] = _arrow251

def wait_for_file_access_read(x: str) -> Async[int64]:
    return v14(x)


def _arrow252(v: str) -> Async[str]:
    return closure7(None, v)


v15: Callable[[str], Async[str]] = _arrow252

def read_all_text_async(x: str) -> Async[str]:
    return v15(x)


def _arrow253(v: str) -> Callable[[str], bool]:
    return closure8(None, v)


v16: Callable[[str, str], bool] = _arrow253

def file_exists_content(x: str) -> Callable[[str], bool]:
    return v16(x)


def _arrow254(v: str) -> Callable[[str], Async[None]]:
    return closure10(None, v)


v17: Callable[[str, str], Async[None]] = _arrow254

def write_all_text_async(x: str) -> Callable[[str], Async[None]]:
    return v17(x)


def _arrow255(v: str) -> Callable[[str], Async[None]]:
    return closure12(None, v)


v18: Callable[[str, str], Async[None]] = _arrow255

def write_all_text_exists(x: str) -> Callable[[str], Async[None]]:
    return v18(x)


def _arrow256(v: str) -> Async[int64]:
    return closure14(None, v)


v19: Callable[[str], Async[int64]] = _arrow256

def delete_file_async(x: str) -> Async[int64]:
    return v19(x)


def _arrow257(v: str) -> Callable[[str], Async[int64]]:
    return closure16(None, v)


v20: Callable[[str, str], Async[int64]] = _arrow257

def move_file_async(x: str) -> Callable[[str], Async[int64]]:
    return v20(x)


def _arrow258(v: str) -> Async[str | None]:
    return closure19(None, v)


v21: Callable[[str], Async[str | None]] = _arrow258

def read_all_text_retry_async(x: str) -> Async[str | None]:
    return v21(x)


def _arrow259(__unit: None=None) -> str:
    return closure25(None, None)


v22: Callable[[], str] = _arrow259

def create_temp_path(__unit: None=None) -> str:
    return v22(None)


def _arrow260(__unit: None=None) -> tuple[str, IDisposable]:
    return closure26(None, None)


v23: Callable[[], tuple[str, IDisposable]] = _arrow260

def create_temp_dir(__unit: None=None) -> tuple[str, IDisposable]:
    return v23(None)


def _arrow261(v: str) -> tuple[str, IDisposable]:
    return closure35(None, v)


v24: Callable[[str], tuple[str, IDisposable]] = _arrow261

def create_temp_dir_0027(x: str) -> tuple[str, IDisposable]:
    return v24(x)


def _arrow262(__unit: None=None) -> str:
    return closure36(None, None)


v25: Callable[[], str] = _arrow262

def get_source_directory(__unit: None=None) -> str:
    return v25(None)


def _arrow263(v: str) -> str:
    return closure37(None, v)


v26: Callable[[str], str] = _arrow263

def normalize_path(x: str) -> str:
    return v26(x)


def _arrow264(v: str) -> str:
    return closure38(None, v)


v27: Callable[[str], str] = _arrow264

def new_file_uri(x: str) -> str:
    return v27(x)


def _arrow265(__unit: None=None) -> str:
    return closure39(None, None)


v28: Callable[[], str] = _arrow265

def get_workspace_root(__unit: None=None) -> str:
    return v28(None)


def _arrow266(v: bool) -> None:
    closure42(None, v)


v29: Callable[[bool], None] = _arrow266

def init_trace_file(x: bool) -> None:
    v29(x)


def _arrow267(v: str) -> Callable[[str], str]:
    return closure44(None, v)


v30: Callable[[str, str], str] = _arrow267

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v30(x)


