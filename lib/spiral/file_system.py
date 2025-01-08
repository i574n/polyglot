from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.async_ import (sleep, start_child, catch_async, ignore, run_synchronously)
from fable_modules.fable_library.async_builder import (singleton, Async)
from fable_modules.fable_library.date import (ticks as ticks_1, now, create as create_1, to_string)
from fable_modules.fable_library.guid import (parse, new_guid)
from fable_modules.fable_library.list import (to_array, empty, of_array, singleton as singleton_1)
from fable_modules.fable_library.long import (from_value, op_subtraction, op_addition, op_modulus)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_10, default_arg, map)
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type, enum_type)
from fable_modules.fable_library.result import FSharpResult_2
from fable_modules.fable_library.string_ import (trim_end, trim_start, to_text, interpolate, concat, replace)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds, to_string as to_string_1)
from fable_modules.fable_library.types import (int64, Array, Union, Record, uint8, to_string as to_string_2)
from fable_modules.fable_library.util import (create_atom, IDisposable, to_enumerable, compare, uncurry2)

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


def _expr284() -> TypeInfo:
    return class_type("File_system.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr284

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


class IPathDirname(Protocol):
    @abstractmethod
    def dirname(self, path: str) -> str:
        ...


def _expr285() -> TypeInfo:
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


US0_reflection = _expr285

def _expr286() -> TypeInfo:
    return record_type("File_system.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr286

def _expr287() -> TypeInfo:
    return record_type("File_system.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr287

def _expr288() -> TypeInfo:
    return record_type("File_system.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr288

def _expr289() -> TypeInfo:
    return record_type("File_system.Mut3", [], Mut3, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: str

Mut3_reflection = _expr289

def _expr290() -> TypeInfo:
    return record_type("File_system.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr290

def _expr291() -> TypeInfo:
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


US1_reflection = _expr291

def _expr292() -> TypeInfo:
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


US2_reflection = _expr292

def _expr293() -> TypeInfo:
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


US3_reflection = _expr293

def _expr294() -> TypeInfo:
    return union_type("File_system.US4", [], US4, lambda: [[("f0_0", US3_reflection())], [("f1_0", US3_reflection())], [("f2_0", US3_reflection())], [("f3_0", US3_reflection())], [("f4_0", US3_reflection())]])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1", "US4_2", "US4_3", "US4_4"]


US4_reflection = _expr294

def _expr295() -> TypeInfo:
    return union_type("File_system.US5", [], US5, lambda: [[("f0_0", string_type)], []])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr295

def _expr296() -> TypeInfo:
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


US7_reflection = _expr296

def _expr297() -> TypeInfo:
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


US8_reflection = _expr297

def _expr298() -> TypeInfo:
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


US6_reflection = _expr298

def _expr299() -> TypeInfo:
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


US9_reflection = _expr299

def _expr300() -> TypeInfo:
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


US10_reflection = _expr300

def _expr301() -> TypeInfo:
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


US11_reflection = _expr301

def _expr302() -> TypeInfo:
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


US12_reflection = _expr302

def _expr303() -> TypeInfo:
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


US13_reflection = _expr303

def _expr304() -> TypeInfo:
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


US14_reflection = _expr304

def _expr305() -> TypeInfo:
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


US15_reflection = _expr305

def method3(v0_1: str) -> str:
    return v0_1


def method4(__unit: None=None) -> str:
    return ""


def closure1(unit_var: None, v0_1: str) -> US5:
    return US5(0, v0_1)


def method5(__unit: None=None) -> Callable[[str], US5]:
    def _arrow306(v: str) -> US5:
        return closure1(None, v)

    return _arrow306


def method2(v0_1: str) -> str:
    v29_1: IOsEnviron = os
    v31_1: Any = v29.environ
    _v35: (str | None) | None = None
    x: str | None = v31.get(v0_1)
    _v35 = some(x)
    v40: str | None
    if _v35 is None:
        raise Exception("optionm\'.of_obj / _v35=None")

    else: 
        v40 = value_10(_v35)

    v56: US5 = default_arg(map(method5(), v40), US5(1))
    if v56.tag == 0:
        return v56.fields[0]

    else: 
        return ""



def method1(__unit: None=None) -> tuple[US1, US2]:
    v1_1: str = method2("TRACE_LEVEL")
    v6: US1 = US1(0, US0(0)) if ("Verbose" == v1_1) else US1(1)
    def _arrow307(__unit: None=None) -> US1:
        v13: US1 = US1(0, US0(1)) if ("Debug" == v1_1) else US1(1)
        if v13.tag == 0:
            return US1(0, v13.fields[0])

        else: 
            v20_1: US1 = US1(0, US0(2)) if ("Info" == v1_1) else US1(1)
            if v20_1.tag == 0:
                return US1(0, v20_1.fields[0])

            else: 
                v27_1: US1 = US1(0, US0(3)) if ("Warning" == v1_1) else US1(1)
                if v27_1.tag == 0:
                    return US1(0, v27_1.fields[0])

                else: 
                    v34_1: US1 = US1(0, US0(4)) if ("Critical" == v1_1) else US1(1)
                    return US1(0, v34_1.fields[0]) if (v34_1.tag == 0) else US1(1)




    return (US1(0, v6.fields[0]) if (v6.tag == 0) else _arrow307(), US2(1) if (method2("AUTOMATION") != "True") else US2(0, from_value(ticks_1(now()), False)))


def closure2(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None]:
    pattern_input: tuple[US1, US2] = method1()
    _run_target_args_0027_v1: tuple[US1, US2] = (pattern_input[0], pattern_input[1])
    v132: US2 = _run_target_args_0027_v1[1]
    v131: US1 = _run_target_args_0027_v1[0]
    def v138(v: str, v0_1: Any=v0_1) -> None:
        closure2(None, v)

    return (Mut0(int64(1)), Mut1(v138), Mut2(True), Mut3(""), Mut4(v131.fields[0] if (v131.tag == 0) else v0_1), v132.fields[0] if (v132.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = method0(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def method10(v0_1: str) -> bool:
    return None


def method9(v0_1: bool, v1_1: str) -> None:
    pass


def method11(v0_1: US0) -> bool:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
    v35_1: US0 = pattern_input[4].l0
    if pattern_input[2].l0 == False:
        return False

    else: 
        class ObjectExpr308:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        class ObjectExpr309:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        return find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr308())) >= find(v35_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr309()))



def closure5(unit_var: None, v0_1: int64) -> US2:
    return US2(0, v0_1)


def method13(__unit: None=None) -> Callable[[int64], US2]:
    def _arrow310(v: int64) -> US2:
        return closure5(None, v)

    return _arrow310


def method14(__unit: None=None) -> str:
    return "hh:mm:ss"


def method15(__unit: None=None) -> str:
    return "HH:mm:ss"


def method12(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None=None) -> str:
    v453: US2 = default_arg(map(method13(), v5), US2(1))
    v550: Any
    if v453.tag == 0:
        v510: Any = create(op_subtraction(from_value(ticks_1(now()), False), v453.fields[0]))
        v550 = create_1(1, 1, 1, hours(v510), minutes(v510), seconds(v510), milliseconds(v510))

    else: 
        v550 = now()

    v551: str = method15()
    return to_string(v550, "M-d-y hh:mm:ss tt" if (v551 == "") else v551)


def method18(__unit: None=None) -> str:
    return ""


def closure6(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def method17(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method18())
    v8: None
    closure6(v2_1, ("" + str(v0_1)) + "", None)
    v8 = None
    return v2_1.l0


def method19(__unit: None=None) -> str:
    return "\u001b[0m"


def method16(__unit: None=None) -> str:
    v2_1: str = "Debug".lower()
    return ("\u001b[94m" + method17(v2_1[0])) + method19()


def method20(v0_1: str) -> str:
    raise Exception(((("file_system.get_file_name / target: " + str(US4(4, US3(0)))) + " / path: ") + v0_1) + "")


def method22(v0_1: str, v1_1: str) -> str:
    v3: Mut3 = Mut3(method18())
    v10: None
    closure6(v3, "{ ", None)
    v10 = None
    v19_1: None
    closure6(v3, "ex", None)
    v19_1 = None
    v28_1: None
    closure6(v3, " = ", None)
    v28_1 = None
    v36_1: None
    closure6(v3, v0_1, None)
    v36_1 = None
    v45: None
    closure6(v3, "; ", None)
    v45 = None
    v54: None
    closure6(v3, "path", None)
    v54 = None
    v62: None
    closure6(v3, " = ", None)
    v62 = None
    v70: None
    closure6(v3, v1_1, None)
    v70 = None
    v79: None
    closure6(v3, " }", None)
    v79 = None
    return v3.l0


def method23(v0_1: str) -> str:
    return trim_end(trim_start(v0_1, *to_array(empty())), *to_array(of_array([" ", "/"])))


def method21(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str, v9: str) -> str:
    v10: str = method22(v8, v9)
    return method23(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "file_system.delete_directory_async") + " / ") + v10) + "")


def closure7(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure9(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure8(unit_var: None, v0_1: str) -> None:
    v3: None
    closure9(v0_1, None)
    v3 = None


def method24(v0_1: str) -> None:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
    v37: None
    closure7(pattern_input[0], None)
    v37 = None
    closure8(None, v0_1)
    pattern_input[1].l0(v0_1)


def closure4(v0_1: str, v1_1: Exception, unit_var: None) -> None:
    if method11(US0(1)):
        v6: None
        closure0(None, None)
        v6 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
        v25_1: int64 | None = pattern_input[5]
        v24_1: Mut4 = pattern_input[4]
        v23_1: Mut3 = pattern_input[3]
        v22_1: Mut2 = pattern_input[2]
        v21_1: Mut1 = pattern_input[1]
        v20_1: Mut0 = pattern_input[0]
        method24(method21(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method12(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method16(), to_text(interpolate("%A%P()", [v1_1])), method20(v0_1)))



def method8(v0_1: str, v1_1: int64) -> Async[int64]:
    def _arrow316(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[int64]:
        def _arrow311(__unit: None=None) -> Async[int64]:
            method9(True, v0_1)
            return singleton.Return(v1_1)

        def _arrow315(_arg: Exception) -> Async[int64]:
            v1519: bool = op_modulus(v1_1, int64(100)) == int64(0)
            def _arrow312(__unit: None=None) -> Async[None]:
                v1522: None
                closure4(v0_1, _arg, None)
                v1522 = None
                return singleton.Zero()

            def _arrow314(__unit: None=None) -> Async[int64]:
                v1598: Async[None] = sleep(10)
                def _arrow313(__unit: None=None) -> Async[int64]:
                    v1607: Async[int64] = method7(v0_1, op_addition(v1_1, int64(1)))
                    return singleton.ReturnFrom(v1607)

                return singleton.Bind(v1598, _arrow313)

            return singleton.Combine(_arrow312() if v1519 else singleton.Zero(), singleton.Delay(_arrow314))

        return singleton.TryWith(singleton.Delay(_arrow311), _arrow315)

    return singleton.Delay(_arrow316)


def method7(v0_1: str, v1_1: int64) -> Async[int64]:
    return None


def method6(v0_1: str) -> Async[int64]:
    return method7(v0_1, int64(0))


def closure3(unit_var: None, v0_1: str) -> Async[int64]:
    return method6(v0_1)


def method29(v0_1: str, v1_1: int64, v2_1: str) -> str:
    v4: Mut3 = Mut3(method18())
    v11: None
    closure6(v4, "{ ", None)
    v11 = None
    v20_1: None
    closure6(v4, "path", None)
    v20_1 = None
    v29_1: None
    closure6(v4, " = ", None)
    v29_1 = None
    v37: None
    closure6(v4, v0_1, None)
    v37 = None
    v46: None
    closure6(v4, "; ", None)
    v46 = None
    v55: None
    closure6(v4, "retry", None)
    v55 = None
    v63: None
    closure6(v4, " = ", None)
    v63 = None
    v71: None
    closure6(v4, ("" + str(v1_1)) + "", None)
    v71 = None
    v79: None
    closure6(v4, "; ", None)
    v79 = None
    v88: None
    closure6(v4, "ex", None)
    v88 = None
    v96: None
    closure6(v4, " = ", None)
    v96 = None
    v104: None
    closure6(v4, v2_1, None)
    v104 = None
    v113: None
    closure6(v4, " }", None)
    v113 = None
    return v4.l0


def method28(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str, v9: int64, v10: str) -> str:
    v11: str = method29(v8, v9, v10)
    return method23(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "file_system.wait_for_file_access") + " / ") + v11) + "")


def closure12(v0_1: str, v1_1: int64, v2_1: Exception, unit_var: None) -> None:
    if method11(US0(1)):
        v7: None
        closure0(None, None)
        v7 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
        v26_1: int64 | None = pattern_input[5]
        v25_1: Mut4 = pattern_input[4]
        v24_1: Mut3 = pattern_input[3]
        v23_1: Mut2 = pattern_input[2]
        v22_1: Mut1 = pattern_input[1]
        v21_1: Mut0 = pattern_input[0]
        method24(method28(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, method12(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1), method16(), method20(v0_1), v1_1, to_text(interpolate("%A%P()", [v2_1]))))



def method27(v0_1: US6, v1_1: str, v2_1: int64, v3: US8, v4: US7) -> Async[int64]:
    def _arrow323(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> Async[int64]:
        def _arrow318(__unit: None=None) -> Async[int64]:
            def _arrow317(_arg: Any) -> Async[int64]:
                return singleton.Return(v2_1)

            return singleton.Using(None, _arrow317)

        def _arrow322(_arg_1: Exception) -> Async[int64]:
            v2312: bool = (op_modulus(v2_1, int64(100)) == int64(0)) if (v2_1 > int64(0)) else False
            def _arrow319(__unit: None=None) -> Async[None]:
                v2315: None
                closure12(v1_1, v2_1, _arg_1, None)
                v2315 = None
                return singleton.Zero()

            def _arrow321(__unit: None=None) -> Async[int64]:
                v2391: Async[None] = sleep(10)
                def _arrow320(__unit: None=None) -> Async[int64]:
                    v2400: Async[int64] = method26(v0_1, v1_1, op_addition(v2_1, int64(1)))
                    return singleton.ReturnFrom(v2400)

                return singleton.Bind(v2391, _arrow320)

            return singleton.Combine(_arrow319() if v2312 else singleton.Zero(), singleton.Delay(_arrow321))

        return singleton.TryWith(singleton.Delay(_arrow318), _arrow322)

    return singleton.Delay(_arrow323)


def method26(v0_1: US6, v1_1: str, v2_1: int64) -> Async[int64]:
    return None


def method25(v0_1: US6, v1_1: str) -> Async[int64]:
    return method26(v0_1, v1_1, int64(0))


def closure11(v0_1: US6, v1_1: str) -> Async[int64]:
    return method25(v0_1, v1_1)


def closure10(unit_var: None, v0_1: US6) -> Callable[[str], Async[int64]]:
    def _arrow324(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure11(v0_1, v)

    return _arrow324


def method30(v0_1: str) -> Async[int64]:
    return method25(US6(0, US7(0), US8(1)), v0_1)


def closure13(unit_var: None, v0_1: str) -> Async[int64]:
    return method30(v0_1)


def method31(v0_1: str) -> Async[str]:
    return None


def closure14(unit_var: None, v0_1: str) -> Async[str]:
    return method31(v0_1)


def method33(v0_1: str) -> bool:
    return None


def method34(v0_1: Vec_1[uint8]) -> Vec_1[uint8]:
    return v0_1


def method32(v0_1: str, v1_1: str) -> bool:
    return None


def closure16(v0_1: str, v1_1: str) -> bool:
    return method32(v0_1, v1_1)


def closure15(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow325(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure16(v0_1, v)

    return _arrow325


def method35(v0_1: str, v1_1: str) -> Async[None]:
    return None


def closure18(v0_1: str, v1_1: str) -> Async[None]:
    return method35(v0_1, v1_1)


def closure17(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow326(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure18(v0_1, v)

    return _arrow326


def method39(v0_1: str, v1_1: str) -> Async[bool]:
    def _arrow328(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[bool]:
        if method33(v0_1) == False:
            return singleton.Return(False)

        else: 
            v61: Async[str] = method31(v0_1)
            def _arrow327(_arg: str) -> Async[bool]:
                v63: bool = v1_1 == _arg
                return singleton.Return(v63)

            return singleton.Bind(v61, _arrow327)


    return singleton.Delay(_arrow328)


def method38(v0_1: str, v1_1: str) -> Async[bool]:
    return None


def method37(v0_1: str, v1_1: str) -> Async[None]:
    def _arrow333(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[None]:
        v51: Async[bool] = method38(v0_1, v1_1)
        def _arrow332(_arg: bool) -> Async[None]:
            v53: bool = _arg == False
            def _arrow330(__unit: None=None) -> Async[None]:
                v54: Async[None] = method35(v0_1, v1_1)
                def _arrow329(__unit: None=None) -> Async[None]:
                    return singleton.Zero()

                return singleton.Bind(v54, _arrow329)

            def _arrow331(__unit: None=None) -> Async[None]:
                return singleton.Zero()

            return singleton.Combine(_arrow330() if v53 else singleton.Zero(), singleton.Delay(_arrow331))

        return singleton.Bind(v51, _arrow332)

    return singleton.Delay(_arrow333)


def method36(v0_1: str, v1_1: str) -> Async[None]:
    return method37(v0_1, v1_1)


def closure20(v0_1: str, v1_1: str) -> Async[None]:
    return method36(v0_1, v1_1)


def closure19(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow334(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure20(v0_1, v)

    return _arrow334


def method43(__unit: None=None) -> str:
    v2_1: str = "Warning".lower()
    return ("\u001b[93m" + method17(v2_1[0])) + method19()


def method45(v0_1: str, v1_1: str) -> str:
    v3: Mut3 = Mut3(method18())
    v10: None
    closure6(v3, "{ ", None)
    v10 = None
    v19_1: None
    closure6(v3, "path", None)
    v19_1 = None
    v28_1: None
    closure6(v3, " = ", None)
    v28_1 = None
    v36_1: None
    closure6(v3, v0_1, None)
    v36_1 = None
    v45: None
    closure6(v3, "; ", None)
    v45 = None
    v54: None
    closure6(v3, "ex", None)
    v54 = None
    v62: None
    closure6(v3, " = ", None)
    v62 = None
    v70: None
    closure6(v3, v1_1, None)
    v70 = None
    v79: None
    closure6(v3, " }", None)
    v79 = None
    return v3.l0


def method44(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str, v9: str) -> str:
    v10: str = method45(v8, v9)
    return method23(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "delete_file_async") + " / ") + v10) + "")


def closure22(v0_1: str, v1_1: Exception, unit_var: None) -> None:
    if method11(US0(3)):
        v6: None
        closure0(None, None)
        v6 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
        v25_1: int64 | None = pattern_input[5]
        v24_1: Mut4 = pattern_input[4]
        v23_1: Mut3 = pattern_input[3]
        v22_1: Mut2 = pattern_input[2]
        v21_1: Mut1 = pattern_input[1]
        v20_1: Mut0 = pattern_input[0]
        method24(method44(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method12(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method43(), method20(v0_1), to_text(interpolate("%A%P()", [v1_1]))))



def method42(v0_1: str, v1_1: int64) -> Async[int64]:
    def _arrow340(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[int64]:
        def _arrow335(__unit: None=None) -> Async[int64]:
            return singleton.Return(v1_1)

        def _arrow339(_arg: Exception) -> Async[int64]:
            v1555: bool = op_modulus(v1_1, int64(100)) == int64(0)
            def _arrow336(__unit: None=None) -> Async[None]:
                v1558: None
                closure22(v0_1, _arg, None)
                v1558 = None
                return singleton.Zero()

            def _arrow338(__unit: None=None) -> Async[int64]:
                v1634: Async[None] = sleep(10)
                def _arrow337(__unit: None=None) -> Async[int64]:
                    v1643: Async[int64] = method41(v0_1, op_addition(v1_1, int64(1)))
                    return singleton.ReturnFrom(v1643)

                return singleton.Bind(v1634, _arrow337)

            return singleton.Combine(_arrow336() if v1555 else singleton.Zero(), singleton.Delay(_arrow338))

        return singleton.TryWith(singleton.Delay(_arrow335), _arrow339)

    return singleton.Delay(_arrow340)


def method41(v0_1: str, v1_1: int64) -> Async[int64]:
    return None


def method40(v0_1: str) -> Async[int64]:
    return method41(v0_1, int64(0))


def closure21(unit_var: None, v0_1: str) -> Async[int64]:
    return method40(v0_1)


def method49(v0_1: str, v1_1: str) -> None:
    pass


def method51(v0_1: str, v1_1: str, v2_1: str) -> str:
    v4: Mut3 = Mut3(method18())
    v11: None
    closure6(v4, "{ ", None)
    v11 = None
    v20_1: None
    closure6(v4, "old_path", None)
    v20_1 = None
    v29_1: None
    closure6(v4, " = ", None)
    v29_1 = None
    v37: None
    closure6(v4, v0_1, None)
    v37 = None
    v46: None
    closure6(v4, "; ", None)
    v46 = None
    v55: None
    closure6(v4, "new_path", None)
    v55 = None
    v63: None
    closure6(v4, " = ", None)
    v63 = None
    v71: None
    closure6(v4, v1_1, None)
    v71 = None
    v79: None
    closure6(v4, "; ", None)
    v79 = None
    v88: None
    closure6(v4, "ex", None)
    v88 = None
    v96: None
    closure6(v4, " = ", None)
    v96 = None
    v104: None
    closure6(v4, v2_1, None)
    v104 = None
    v113: None
    closure6(v4, " }", None)
    v113 = None
    return v4.l0


def method50(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str, v9: str, v10: str) -> str:
    v11: str = method51(v8, v9, v10)
    return method23(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "move_file_async") + " / ") + v11) + "")


def closure25(v0_1: str, v1_1: str, v2_1: Exception, unit_var: None) -> None:
    if method11(US0(3)):
        v7: None
        closure0(None, None)
        v7 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
        v26_1: int64 | None = pattern_input[5]
        v25_1: Mut4 = pattern_input[4]
        v24_1: Mut3 = pattern_input[3]
        v23_1: Mut2 = pattern_input[2]
        v22_1: Mut1 = pattern_input[1]
        v21_1: Mut0 = pattern_input[0]
        method24(method50(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, method12(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1), method43(), method20(v1_1), method20(v0_1), to_text(interpolate("%A%P()", [v2_1]))))



def method48(v0_1: str, v1_1: str, v2_1: int64) -> Async[int64]:
    def _arrow346(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> Async[int64]:
        def _arrow341(__unit: None=None) -> Async[int64]:
            method49(v0_1, v1_1)
            return singleton.Return(v2_1)

        def _arrow345(_arg: Exception) -> Async[int64]:
            v1494: bool = op_modulus(v2_1, int64(100)) == int64(0)
            def _arrow342(__unit: None=None) -> Async[None]:
                v1497: None
                closure25(v0_1, v1_1, _arg, None)
                v1497 = None
                return singleton.Zero()

            def _arrow344(__unit: None=None) -> Async[int64]:
                v1574: Async[None] = sleep(10)
                def _arrow343(__unit: None=None) -> Async[int64]:
                    v1583: Async[int64] = method47(v0_1, v1_1, op_addition(v2_1, int64(1)))
                    return singleton.ReturnFrom(v1583)

                return singleton.Bind(v1574, _arrow343)

            return singleton.Combine(_arrow342() if v1494 else singleton.Zero(), singleton.Delay(_arrow344))

        return singleton.TryWith(singleton.Delay(_arrow341), _arrow345)

    return singleton.Delay(_arrow346)


def method47(v0_1: str, v1_1: str, v2_1: int64) -> Async[int64]:
    return None


def method46(v0_1: str, v1_1: str) -> Async[int64]:
    return method47(v0_1, v1_1, int64(0))


def closure24(v0_1: str, v1_1: str) -> Async[int64]:
    return method46(v0_1, v1_1)


def closure23(unit_var: None, v0_1: str) -> Callable[[str], Async[int64]]:
    def _arrow347(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure24(v0_1, v)

    return _arrow347


def closure27(unit_var: None, v0_1: int64) -> US9:
    return US9(0, v0_1)


def method58(__unit: None=None) -> Callable[[int64], US9]:
    def _arrow348(v: int64) -> US9:
        return closure27(None, v)

    return _arrow348


def closure28(unit_var: None, v0_1: Exception) -> US9:
    return US9(1, v0_1)


def method59(__unit: None=None) -> Callable[[Exception], US9]:
    def _arrow349(v: Exception) -> US9:
        return closure28(None, v)

    return _arrow349


def method57(v0_1: Async[Any]) -> Async[US9]:
    def _arrow351(__unit: None=None, v0_1: Any=v0_1) -> Async[US9]:
        def _arrow350(_arg: Any) -> Async[US9]:
            return singleton.Return(None)

        return singleton.Bind(v0_1, _arrow350)

    return singleton.Delay(_arrow351)


def method60(v0_1: Async[US9]) -> Async[US10]:
    def _arrow353(__unit: None=None, v0_1: Any=v0_1) -> Async[US10]:
        def _arrow352(_arg: US9) -> Async[US10]:
            v74: US9 = _arg
            v80: US10 = US10(1, v74.fields[0]) if (v74.tag == 1) else US10(0, v74.fields[0])
            return singleton.Return(v80)

        return singleton.Bind(v0_1, _arrow352)

    return singleton.Delay(_arrow353)


def method62(__unit: None=None) -> str:
    v2_1: str = "Verbose".lower()
    return ("\u001b[90m" + method17(v2_1[0])) + method19()


def method64(v0_1: int) -> str:
    v2_1: Mut3 = Mut3(method18())
    v9: None
    closure6(v2_1, "{ ", None)
    v9 = None
    v18_1: None
    closure6(v2_1, "timeout", None)
    v18_1 = None
    v27_1: None
    closure6(v2_1, " = ", None)
    v27_1 = None
    v35_1: None
    closure6(v2_1, ("" + str(v0_1)) + "", None)
    v35_1 = None
    v44: None
    closure6(v2_1, " }", None)
    v44 = None
    return v2_1.l0


def method63(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: int) -> str:
    v9: str = method64(v8)
    return method23(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "async.run_with_timeout_async") + " / ") + v9) + "")


def closure29(v0_1: int, unit_var: None) -> None:
    if method11(US0(0)):
        v5: None
        closure0(None, None)
        v5 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
        v24_1: int64 | None = pattern_input[5]
        v23_1: Mut4 = pattern_input[4]
        v22_1: Mut3 = pattern_input[3]
        v21_1: Mut2 = pattern_input[2]
        v20_1: Mut1 = pattern_input[1]
        v19_1: Mut0 = pattern_input[0]
        method24(method63(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, method12(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1), method62(), v0_1))



def method65(__unit: None=None) -> str:
    v2_1: str = "Critical".lower()
    return ("\u001b[91m" + method17(v2_1[0])) + method19()


def method67(v0_1: int, v1_1: str) -> str:
    v3: Mut3 = Mut3(method18())
    v10: None
    closure6(v3, "{ ", None)
    v10 = None
    v19_1: None
    closure6(v3, "timeout", None)
    v19_1 = None
    v28_1: None
    closure6(v3, " = ", None)
    v28_1 = None
    v36_1: None
    closure6(v3, ("" + str(v0_1)) + "", None)
    v36_1 = None
    v45: None
    closure6(v3, "; ", None)
    v45 = None
    v54: None
    closure6(v3, "ex", None)
    v54 = None
    v62: None
    closure6(v3, " = ", None)
    v62 = None
    v70: None
    closure6(v3, v1_1, None)
    v70 = None
    v79: None
    closure6(v3, " }", None)
    v79 = None
    return v3.l0


def method66(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: int, v9: str) -> str:
    v10: str = method67(v8, v9)
    return method23(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "async.run_with_timeout_async**") + " / ") + v10) + "")


def closure30(v0_1: int, v1_1: Exception, unit_var: None) -> None:
    if method11(US0(4)):
        v6: None
        closure0(None, None)
        v6 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
        v25_1: int64 | None = pattern_input[5]
        v24_1: Mut4 = pattern_input[4]
        v23_1: Mut3 = pattern_input[3]
        v22_1: Mut2 = pattern_input[2]
        v21_1: Mut1 = pattern_input[1]
        v20_1: Mut0 = pattern_input[0]
        method24(method66(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method12(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method65(), v0_1, to_text(interpolate("%A%P()", [v1_1]))))



def method61(v0_1: int, v1_1: Async[US10]) -> Async[US2]:
    def _arrow355(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[US2]:
        def _arrow354(_arg: US10) -> Async[US2]:
            v1019: US10 = _arg
            v1143: US2
            if v1019.tag == 0:
                v1143 = US2(0, v1019.fields[0])

            else: 
                v1022: Exception = v1019.fields[0]
                v1023: str = to_text(interpolate("%A%P()", [v1022]))
                if v1023.find("System.TimeoutException") >= 0:
                    v1032: None
                    closure29(v0_1, None)
                    v1032 = None
                    v1143 = US2(1)

                else: 
                    v1075: None
                    closure30(v0_1, v1022, None)
                    v1075 = None
                    v1143 = US2(1)


            return singleton.Return(v1143)

        return singleton.Bind(v1_1, _arrow354)

    return singleton.Delay(_arrow355)


def method56(v0_1: Async[int64], v1_1: int) -> Async[US2]:
    def _arrow357(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[US2]:
        v398: Async[Async[int64]] = start_child(v0_1, v1_1)
        def _arrow356(_arg: Async[int64]) -> Async[US2]:
            v432: Async[US2] = method61(v1_1, method60(method57(catch_async(_arg))))
            return singleton.ReturnFrom(v432)

        return singleton.Bind(v398, _arrow356)

    return singleton.Delay(_arrow357)


def method55(v0_1: int, v1_1: Async[int64]) -> Async[US2]:
    return method56(v1_1, v0_1)


def method68(v0_1: Async[str]) -> Async[str | None]:
    def _arrow359(__unit: None=None, v0_1: Any=v0_1) -> Async[str | None]:
        def _arrow358(_arg: str) -> Async[str | None]:
            return singleton.Return(_arg)

        return singleton.Bind(v0_1, _arrow358)

    return singleton.Delay(_arrow359)


def method70(v0_1: int64, v1_1: str) -> str:
    v3: Mut3 = Mut3(method18())
    v10: None
    closure6(v3, "{ ", None)
    v10 = None
    v19_1: None
    closure6(v3, "retry", None)
    v19_1 = None
    v28_1: None
    closure6(v3, " = ", None)
    v28_1 = None
    v36_1: None
    closure6(v3, ("" + str(v0_1)) + "", None)
    v36_1 = None
    v45: None
    closure6(v3, "; ", None)
    v45 = None
    v54: None
    closure6(v3, "ex", None)
    v54 = None
    v62: None
    closure6(v3, " = ", None)
    v62 = None
    v70: None
    closure6(v3, v1_1, None)
    v70 = None
    v79: None
    closure6(v3, " }", None)
    v79 = None
    return v3.l0


def method69(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: int64, v9: str) -> str:
    v10: str = method70(v8, v9)
    return method23(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "file_system.read_all_text_retry_async") + " / ") + v10) + "")


def closure31(v0_1: int64, v1_1: Exception, unit_var: None) -> None:
    if method11(US0(1)):
        v6: None
        closure0(None, None)
        v6 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
        v25_1: int64 | None = pattern_input[5]
        v24_1: Mut4 = pattern_input[4]
        v23_1: Mut3 = pattern_input[3]
        v22_1: Mut2 = pattern_input[2]
        v21_1: Mut1 = pattern_input[1]
        v20_1: Mut0 = pattern_input[0]
        method24(method69(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method12(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method16(), v0_1, to_text(interpolate("%A%P()", [v1_1]))))



def method54(v0_1: str, v1_1: int64) -> Async[str | None]:
    def _arrow365(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[str | None]:
        def _arrow363(__unit: None=None) -> Async[str | None]:
            v1675: bool = v1_1 > int64(0)
            def _arrow361(__unit: None=None) -> Async[None]:
                v1692: Async[None] = ignore(method55(1000, method30(v0_1)))
                def _arrow360(__unit: None=None) -> Async[None]:
                    return singleton.Zero()

                return singleton.Bind(v1692, _arrow360)

            def _arrow362(__unit: None=None) -> Async[str | None]:
                v1703: Async[str | None] = method68(method31(v0_1))
                return singleton.ReturnFrom(v1703)

            return singleton.Combine(_arrow361() if v1675 else singleton.Zero(), singleton.Delay(_arrow362))

        def _arrow364(_arg_1: Exception) -> Async[str | None]:
            if (v1_1 == int64(0)) != True:
                v1738: None
                closure31(v1_1, _arg_1, None)
                v1738 = None
                return singleton.Return(None)

            else: 
                v1805: Async[str | None] = method53(v0_1, op_addition(v1_1, int64(1)))
                return singleton.ReturnFrom(v1805)


        return singleton.TryWith(singleton.Delay(_arrow363), _arrow364)

    return singleton.Delay(_arrow365)


def method53(v0_1: str, v1_1: int64) -> Async[str | None]:
    return method54(v0_1, v1_1)


def method52(v0_1: str) -> Async[str | None]:
    return method53(v0_1, int64(0))


def closure26(unit_var: None, v0_1: str) -> Async[str | None]:
    return method52(v0_1)


def closure33(unit_var: None, v0_1: chrono_date_time_1[chrono_utc]) -> US11:
    return US11(0, v0_1)


def method73(__unit: None=None) -> Callable[[chrono_date_time_1[chrono_utc]], US11]:
    def _arrow366(v: chrono_date_time_1[chrono_utc]) -> US11:
        return closure33(None, v)

    return _arrow366


def method74(__unit: None=None) -> str:
    return "hh:mm"


def method75(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method76(__unit: None=None) -> str:
    return "hhmm"


def method72(v0_1: str, v1_1: Any) -> str:
    v1075: str = method75()
    v1080: str = to_string(v1_1, "M-d-y hh:mm:ss tt" if (v1075 == "") else v1075)
    v1261: Any
    raise Exception(("date_time.get_utc_offset / target: " + str(US4(4, US3(0)))) + "")
    v1274: uint8 = uint8(1) if (hours(v1261) > 0) else uint8(0)
    v1275: str = method76()
    v1299: str = ((("" + str(v1274)) + "") + to_string_1(v1261, "c", {})) + ""
    v1301: str = str(v0_1)
    v1306: int = (len(v1080) + len(v1299)) or 0
    v1325: int = (len(v1301) - 1) or 0
    return parse(concat(v1080, v1299, *v1301[v1306:v1325 + 1]))


def method78(__unit: None=None) -> str:
    raise Exception(("file_system.get_temp_path / target: " + str(US4(4, US3(0)))) + "")


def method79(__unit: None=None) -> str:
    return "!create_temp_path_"


def method80(v0_1: str, v1_1: str) -> str:
    raise Exception(((((("file_system.(</>) / target: " + str(US4(4, US3(0)))) + " / a: ") + v0_1) + " / b: ") + v1_1) + "")


def method82(__unit: None=None) -> str:
    return "CARGO_PKG_NAME"


def method81(__unit: None=None) -> str:
    raise Exception(("env.get_entry_assembly_name / target: " + str(US4(4, US3(0)))) + "")


def method77(v0_1: str) -> str:
    return method80(method80(method80(method78(), method79()), method81()), str(v0_1))


def method71(__unit: None=None) -> str:
    v74: Any = now()
    return method77(method72(new_guid(), v74))


def closure32(unit_var: None, unit_var_1: None) -> str:
    return method71()


def closure35(unit_var: None, v0_1: std_io_error) -> std_string_string:
    return None


def method84(__unit: None=None) -> Callable[[std_io_error], std_string_string]:
    def _arrow367(v: std_io_error) -> std_string_string:
        return closure35(None, v)

    return _arrow367


def closure36(unit_var: None, unit_var_1: None) -> US12:
    return US12(0)


def method85(__unit: None=None) -> Callable[[], US12]:
    def _arrow368(__unit: None=None) -> US12:
        return closure36(None, None)

    return _arrow368


def closure37(unit_var: None, v0_1: std_string_string) -> US12:
    return US12(1, v0_1)


def method86(__unit: None=None) -> Callable[[std_string_string], US12]:
    def _arrow369(v: std_string_string) -> US12:
        return closure37(None, v)

    return _arrow369


def method88(v0_1: str, v1_1: std_string_string) -> str:
    v3: Mut3 = Mut3(method18())
    v10: None
    closure6(v3, "{ ", None)
    v10 = None
    v19_1: None
    closure6(v3, "dir", None)
    v19_1 = None
    v28_1: None
    closure6(v3, " = ", None)
    v28_1 = None
    v36_1: None
    closure6(v3, v0_1, None)
    v36_1 = None
    v45: None
    closure6(v3, "; ", None)
    v45 = None
    v54: None
    closure6(v3, "error", None)
    v54 = None
    v62: None
    closure6(v3, " = ", None)
    v62 = None
    v100: None
    closure6(v3, to_text(interpolate("%A%P()", [v1_1])), None)
    v100 = None
    v109: None
    closure6(v3, " }", None)
    v109 = None
    return v3.l0


def method87(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str, v9: std_string_string) -> str:
    v10: str = method88(v8, v9)
    return method23(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "file_system.create_dir") + " / ") + v10) + "")


def closure38(v0_1: str, v1_1: std_string_string, unit_var: None) -> None:
    if method11(US0(4)):
        v6: None
        closure0(None, None)
        v6 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
        v25_1: int64 | None = pattern_input[5]
        v24_1: Mut4 = pattern_input[4]
        v23_1: Mut3 = pattern_input[3]
        v22_1: Mut2 = pattern_input[2]
        v21_1: Mut1 = pattern_input[1]
        v20_1: Mut0 = pattern_input[0]
        method24(method87(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method12(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method65(), v0_1, v1_1))



def method90(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method18())
    v9: None
    closure6(v2_1, "{ ", None)
    v9 = None
    v18_1: None
    closure6(v2_1, "dir", None)
    v18_1 = None
    v27_1: None
    closure6(v2_1, " = ", None)
    v27_1 = None
    v35_1: None
    closure6(v2_1, v0_1, None)
    v35_1 = None
    v44: None
    closure6(v2_1, " }", None)
    v44 = None
    return v2_1.l0


def method89(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str) -> str:
    v9: str = method90(v8)
    return method23(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "file_system.create_dir") + " / ") + v9) + "")


def closure39(v0_1: str, unit_var: None) -> None:
    if method11(US0(0)):
        v5: None
        closure0(None, None)
        v5 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
        v24_1: int64 | None = pattern_input[5]
        v23_1: Mut4 = pattern_input[4]
        v22_1: Mut3 = pattern_input[3]
        v21_1: Mut2 = pattern_input[2]
        v20_1: Mut1 = pattern_input[1]
        v19_1: Mut0 = pattern_input[0]
        method24(method89(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, method12(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1), method62(), v0_1))



def closure40(v0_1: str, unit_var: None) -> None:
    method9(True, v0_1)


def method91(v0_1: str) -> Callable[[], None]:
    def _arrow370(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure40(v0_1, None)

    return _arrow370


def method92(v0_1: str) -> Callable[[], None]:
    def _arrow371(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure40(v0_1, None)

    return _arrow371


def method93(v0_1: str) -> bool:
    return None


def method95(v0_1: str, v1_1: str) -> str:
    v3: Mut3 = Mut3(method18())
    v10: None
    closure6(v3, "{ ", None)
    v10 = None
    v19_1: None
    closure6(v3, "dir", None)
    v19_1 = None
    v28_1: None
    closure6(v3, " = ", None)
    v28_1 = None
    v36_1: None
    closure6(v3, v0_1, None)
    v36_1 = None
    v45: None
    closure6(v3, "; ", None)
    v45 = None
    v54: None
    closure6(v3, "result", None)
    v54 = None
    v62: None
    closure6(v3, " = ", None)
    v62 = None
    v70: None
    closure6(v3, v1_1, None)
    v70 = None
    v79: None
    closure6(v3, " }", None)
    v79 = None
    return v3.l0


def method94(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str, v9: str) -> str:
    v10: str = method95(v8, v9)
    return method23(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "file_system.create_dir") + " / ") + v10) + "")


def closure41(v0_1: str, v1_1: str, unit_var: None) -> None:
    if method11(US0(1)):
        v6: None
        closure0(None, None)
        v6 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
        v25_1: int64 | None = pattern_input[5]
        v24_1: Mut4 = pattern_input[4]
        v23_1: Mut3 = pattern_input[3]
        v22_1: Mut2 = pattern_input[2]
        v21_1: Mut1 = pattern_input[1]
        v20_1: Mut0 = pattern_input[0]
        method24(method94(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method12(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method16(), v0_1, v1_1))



def closure42(v0_1: str, unit_var: None) -> None:
    run_synchronously(ignore(method6(v0_1)))


def method96(v0_1: str) -> Callable[[], None]:
    def _arrow372(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure42(v0_1, None)

    return _arrow372


def method97(v0_1: str) -> Callable[[], None]:
    def _arrow373(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure42(v0_1, None)

    return _arrow373


def method83(v0_1: str) -> IDisposable:
    v251: bool = method93(v0_1)
    v273: bool = None
    if v273 == False:
        v311: None
        closure41(v0_1, to_text(interpolate("%A%P()", [{
            "CreationTime": None,
            "Exists": v273
        }])), None)
        v311 = None

    v360: Callable[[], None] = method97(v0_1)
    class ObjectExpr374(IDisposable):
        def Dispose(self, __unit: None=None, v0_1: Any=v0_1) -> None:
            v360(None)

    return ObjectExpr374()


def closure34(unit_var: None, unit_var_1: None) -> tuple[str, IDisposable]:
    v0_1: str = method71()
    return (v0_1, method83(v0_1))


def closure44(v0_1: int, v1_1: str, v2_1: int, v3: str) -> str:
    if v2_1 >= v0_1:
        return v3

    else: 
        return method99(v0_1, v1_1, v2_1 + 1)(v3 + v1_1)



def method99(v0_1: int, v1_1: str, v2_1: int) -> Callable[[str], str]:
    def _arrow375(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> str:
        return closure44(v0_1, v1_1, v2_1, v)

    return _arrow375


def method98(v0_1: str) -> str:
    v11: str = method99(32 - len(v0_1), "0", 0)("") + v0_1
    v399: int = (8 - 1) or 0
    v418: int = (12 - 1) or 0
    v437: int = (16 - 1) or 0
    v456: int = (20 - 1) or 0
    v475: int = (32 - 1) or 0
    return parse(((((((((("" + v11[0:v399 + 1]) + "-") + v11[8:v418 + 1]) + "-") + v11[12:v437 + 1]) + "-") + v11[16:v456 + 1]) + "-") + v11[20:v475 + 1]) + "")


def closure43(unit_var: None, v0_1: str) -> tuple[str, IDisposable]:
    v2_1: str = method77(method98(v0_1))
    return (v2_1, method83(v2_1))


def closure45(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def method104(v0_1: std_io_error) -> str:
    v2_1: Mut3 = Mut3(method18())
    v38: None
    closure6(v2_1, to_text(interpolate("%A%P()", [v0_1])), None)
    v38 = None
    return v2_1.l0


def closure47(unit_var: None, v0_1: std_io_error) -> str:
    return method104(v0_1)


def method103(__unit: None=None) -> Callable[[std_io_error], str]:
    def _arrow376(v: std_io_error) -> str:
        return closure47(None, v)

    return _arrow376


def closure48(unit_var: None, v0_1: std_path_path_buf) -> US13:
    return US13(0, v0_1)


def method105(__unit: None=None) -> Callable[[std_path_path_buf], US13]:
    def _arrow377(v: std_path_path_buf) -> US13:
        return closure48(None, v)

    return _arrow377


def closure49(unit_var: None, v0_1: str) -> US13:
    return US13(1, v0_1)


def method106(__unit: None=None) -> Callable[[str], US13]:
    def _arrow378(v: str) -> US13:
        return closure49(None, v)

    return _arrow378


def method109(v0_1: str) -> str | None:
    return None


def method110(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method18())
    v8: None
    closure6(v2_1, v0_1, None)
    v8 = None
    return v2_1.l0


def method108(v0_1: str, v1_1: Callable[[uint8, str], FSharpResult_2[std_path_path_buf, std_io_error]], v2_1: uint8, v3: str, v4: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    v5: str = method20(v4)
    v6: str | None = method109(v4)
    v20_1: US5 = default_arg(map(method5(), v6), US5(1))
    v24_1: str = method110(v3)
    if v2_1 >= uint8(11):
        return FSharpResult_2(1, "file_system.read_link / " + (((((((("path: " + v0_1) + " / n: ") + str(v2_1)) + " / path\': ") + v4) + " / name: ") + v5) + ""))

    elif v20_1.tag == 0:
        if v4 != "":
            v74: FSharpResult_2[std_path_path_buf, std_io_error] = v1_1(v2_1 + uint8(1), v20_1.fields[0])
            v75: Callable[[std_io_error], str] = method103()
            v87: FSharpResult_2[std_path_path_buf, str] = FSharpResult_2(1, v75(v74.fields[0])) if (v74.tag == 1) else FSharpResult_2(0, v74.fields[0])
            v90: Callable[[std_path_path_buf], US13] = method105()
            v91: Callable[[str], US13] = method106()
            v92: US13 = v91(v87.fields[0]) if (v87.tag == 1) else v90(v87.fields[0])
            if v92.tag == 0:
                return FSharpResult_2(0, method80(to_string_2(v92.fields[0]), v5))

            else: 
                return FSharpResult_2(1, "file_system.read_link / " + (((((("error\': " + v92.fields[0]) + " / error: ") + v24_1) + " / name: ") + v5) + ""))


        else: 
            return FSharpResult_2(1, "file_system.read_link / run / The file or directory is not a reparse point. / " + (((((((("path: " + v0_1) + " / error: ") + v24_1) + " / path\': ") + v4) + " / name: ") + v5) + ""))


    else: 
        return FSharpResult_2(1, "file_system.read_link / run / The file or directory is not a reparse point. / " + (((((((("path: " + v0_1) + " / error: ") + v24_1) + " / path\': ") + v4) + " / name: ") + v5) + ""))



def method107(v0_1: str, v1_1: uint8, v2_1: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    return None


def closure51(v0_1: str, v1_1: uint8, v2_1: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    return method107(v0_1, v1_1, v2_1)


def closure50(v0_1: str, v1_1: uint8) -> Callable[[str], FSharpResult_2[std_path_path_buf, std_io_error]]:
    def _arrow379(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> FSharpResult_2[std_path_path_buf, std_io_error]:
        return closure51(v0_1, v1_1, v)

    return _arrow379


def method111(v0_1: str, v1_1: Callable[[uint8, str], FSharpResult_2[std_path_path_buf, std_io_error]], v2_1: uint8, v3: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    v4: str = method20(v0_1)
    v5: str | None = method109(v0_1)
    v19_1: US5 = default_arg(map(method5(), v5), US5(1))
    v23_1: str = method110(v3)
    if v2_1 >= uint8(11):
        return FSharpResult_2(1, "file_system.read_link / " + (((((((("path: " + v0_1) + " / n: ") + str(v2_1)) + " / path\': ") + v0_1) + " / name: ") + v4) + ""))

    elif v19_1.tag == 0:
        if v0_1 != "":
            v73: FSharpResult_2[std_path_path_buf, std_io_error] = v1_1(v2_1 + uint8(1), v19_1.fields[0])
            v74: Callable[[std_io_error], str] = method103()
            v86: FSharpResult_2[std_path_path_buf, str] = FSharpResult_2(1, v74(v73.fields[0])) if (v73.tag == 1) else FSharpResult_2(0, v73.fields[0])
            v89: Callable[[std_path_path_buf], US13] = method105()
            v90: Callable[[str], US13] = method106()
            v91: US13 = v90(v86.fields[0]) if (v86.tag == 1) else v89(v86.fields[0])
            if v91.tag == 0:
                return FSharpResult_2(0, method80(to_string_2(v91.fields[0]), v4))

            else: 
                return FSharpResult_2(1, "file_system.read_link / " + (((((("error\': " + v91.fields[0]) + " / error: ") + v23_1) + " / name: ") + v4) + ""))


        else: 
            return FSharpResult_2(1, "file_system.read_link / run / The file or directory is not a reparse point. / " + (((((((("path: " + v0_1) + " / error: ") + v23_1) + " / path\': ") + v0_1) + " / name: ") + v4) + ""))


    else: 
        return FSharpResult_2(1, "file_system.read_link / run / The file or directory is not a reparse point. / " + (((((((("path: " + v0_1) + " / error: ") + v23_1) + " / path\': ") + v0_1) + " / name: ") + v4) + ""))



def method102(v0_1: str, v1_1: uint8) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    return None


def method113(v0_1: bool) -> enum_type("System.IO.FileAttributes", int, [("None", 0.0), ("ReadOnly", 1.0), ("Hidden", 2.0), ("System", 4.0), ("Directory", 16.0), ("Archive", 32.0), ("Device", 64.0), ("Normal", 128.0), ("Temporary", 256.0), ("SparseFile", 512.0), ("ReparsePoint", 1024.0), ("Compressed", 2048.0), ("Offline", 4096.0), ("NotContentIndexed", 8192.0), ("Encrypted", 16384.0), ("IntegrityStream", 32768.0), ("NoScrubData", 131072.0)]):
    return None


def method114(__unit: None=None) -> enum_type("System.IO.FileAttributes", int, [("None", 0.0), ("ReadOnly", 1.0), ("Hidden", 2.0), ("System", 4.0), ("Directory", 16.0), ("Archive", 32.0), ("Device", 64.0), ("Normal", 128.0), ("Temporary", 256.0), ("SparseFile", 512.0), ("ReparsePoint", 1024.0), ("Compressed", 2048.0), ("Offline", 4096.0), ("NotContentIndexed", 8192.0), ("Encrypted", 16384.0), ("IntegrityStream", 32768.0), ("NoScrubData", 131072.0)]):
    return None


def method115(v0_1: enum_type("System.IO.FileAttributes", int, [("None", 0.0), ("ReadOnly", 1.0), ("Hidden", 2.0), ("System", 4.0), ("Directory", 16.0), ("Archive", 32.0), ("Device", 64.0), ("Normal", 128.0), ("Temporary", 256.0), ("SparseFile", 512.0), ("ReparsePoint", 1024.0), ("Compressed", 2048.0), ("Offline", 4096.0), ("NotContentIndexed", 8192.0), ("Encrypted", 16384.0), ("IntegrityStream", 32768.0), ("NoScrubData", 131072.0)]), v1_1: enum_type("System.IO.FileAttributes", int, [("None", 0.0), ("ReadOnly", 1.0), ("Hidden", 2.0), ("System", 4.0), ("Directory", 16.0), ("Archive", 32.0), ("Device", 64.0), ("Normal", 128.0), ("Temporary", 256.0), ("SparseFile", 512.0), ("ReparsePoint", 1024.0), ("Compressed", 2048.0), ("Offline", 4096.0), ("NotContentIndexed", 8192.0), ("Encrypted", 16384.0), ("IntegrityStream", 32768.0), ("NoScrubData", 131072.0)])) -> bool:
    return None


def method117(v0_1: str, v1_1: Callable[[uint8, str], FSharpResult_2[std_path_path_buf, std_io_error]], v2_1: uint8, v3: std_io_error, v4: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    v5: str = method20(v4)
    v6: str | None = method109(v4)
    v20_1: US5 = default_arg(map(method5(), v6), US5(1))
    v24_1: str = method104(v3)
    if v2_1 >= uint8(11):
        return FSharpResult_2(1, "file_system.read_link / " + (((((((("path: " + v0_1) + " / n: ") + str(v2_1)) + " / path\': ") + v4) + " / name: ") + v5) + ""))

    elif v20_1.tag == 0:
        if v4 != "":
            v74: FSharpResult_2[std_path_path_buf, std_io_error] = v1_1(v2_1 + uint8(1), v20_1.fields[0])
            v75: Callable[[std_io_error], str] = method103()
            v87: FSharpResult_2[std_path_path_buf, str] = FSharpResult_2(1, v75(v74.fields[0])) if (v74.tag == 1) else FSharpResult_2(0, v74.fields[0])
            v90: Callable[[std_path_path_buf], US13] = method105()
            v91: Callable[[str], US13] = method106()
            v92: US13 = v91(v87.fields[0]) if (v87.tag == 1) else v90(v87.fields[0])
            if v92.tag == 0:
                return FSharpResult_2(0, method80(to_string_2(v92.fields[0]), v5))

            else: 
                return FSharpResult_2(1, "file_system.read_link / " + (((((("error\': " + v92.fields[0]) + " / error: ") + v24_1) + " / name: ") + v5) + ""))


        else: 
            return FSharpResult_2(1, "file_system.read_link / run / The file or directory is not a reparse point. / " + (((((((("path: " + v0_1) + " / error: ") + v24_1) + " / path\': ") + v4) + " / name: ") + v5) + ""))


    else: 
        return FSharpResult_2(1, "file_system.read_link / run / The file or directory is not a reparse point. / " + (((((((("path: " + v0_1) + " / error: ") + v24_1) + " / path\': ") + v4) + " / name: ") + v5) + ""))



def method116(v0_1: str, v1_1: uint8, v2_1: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    v30_1: enum_type("System.IO.FileAttributes", int, [("None", 0.0), ("ReadOnly", 1.0), ("Hidden", 2.0), ("System", 4.0), ("Directory", 16.0), ("Archive", 32.0), ("Device", 64.0), ("Normal", 128.0), ("Temporary", 256.0), ("SparseFile", 512.0), ("ReparsePoint", 1024.0), ("Compressed", 2048.0), ("Offline", 4096.0), ("NotContentIndexed", 8192.0), ("Encrypted", 16384.0), ("IntegrityStream", 32768.0), ("NoScrubData", 131072.0)]) = method113(None) or 0
    v32_1: bool = method115(method114(), v30_1)
    if v32_1:
        return FSharpResult_2(0, None)

    else: 
        def v132(v: uint8, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> Callable[[str], FSharpResult_2[std_path_path_buf, std_io_error]]:
            return closure52(v0_1, v)

        return method117(v0_1, uncurry2(v132), v1_1, "file_system.read_link / Fsharp / The file or directory is not a reparse point. / " + (((((((("path: " + v0_1) + " / result: ") + str(v32_1)) + " / path\': ") + v2_1) + " / n: ") + str(v1_1)) + ""), v2_1)



def closure53(v0_1: str, v1_1: uint8, v2_1: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    return method116(v0_1, v1_1, v2_1)


def closure52(v0_1: str, v1_1: uint8) -> Callable[[str], FSharpResult_2[std_path_path_buf, std_io_error]]:
    def _arrow380(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> FSharpResult_2[std_path_path_buf, std_io_error]:
        return closure53(v0_1, v1_1, v)

    return _arrow380


def method118(v0_1: str, v1_1: Callable[[uint8, str], FSharpResult_2[std_path_path_buf, std_io_error]], v2_1: uint8, v3: std_io_error) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    v4: str = method20(v0_1)
    v5: str | None = method109(v0_1)
    v19_1: US5 = default_arg(map(method5(), v5), US5(1))
    v23_1: str = method104(v3)
    if v2_1 >= uint8(11):
        return FSharpResult_2(1, "file_system.read_link / " + (((((((("path: " + v0_1) + " / n: ") + str(v2_1)) + " / path\': ") + v0_1) + " / name: ") + v4) + ""))

    elif v19_1.tag == 0:
        if v0_1 != "":
            v73: FSharpResult_2[std_path_path_buf, std_io_error] = v1_1(v2_1 + uint8(1), v19_1.fields[0])
            v74: Callable[[std_io_error], str] = method103()
            v86: FSharpResult_2[std_path_path_buf, str] = FSharpResult_2(1, v74(v73.fields[0])) if (v73.tag == 1) else FSharpResult_2(0, v73.fields[0])
            v89: Callable[[std_path_path_buf], US13] = method105()
            v90: Callable[[str], US13] = method106()
            v91: US13 = v90(v86.fields[0]) if (v86.tag == 1) else v89(v86.fields[0])
            if v91.tag == 0:
                return FSharpResult_2(0, method80(to_string_2(v91.fields[0]), v4))

            else: 
                return FSharpResult_2(1, "file_system.read_link / " + (((((("error\': " + v91.fields[0]) + " / error: ") + v23_1) + " / name: ") + v4) + ""))


        else: 
            return FSharpResult_2(1, "file_system.read_link / run / The file or directory is not a reparse point. / " + (((((((("path: " + v0_1) + " / error: ") + v23_1) + " / path\': ") + v0_1) + " / name: ") + v4) + ""))


    else: 
        return FSharpResult_2(1, "file_system.read_link / run / The file or directory is not a reparse point. / " + (((((((("path: " + v0_1) + " / error: ") + v23_1) + " / path\': ") + v0_1) + " / name: ") + v4) + ""))



def method112(v0_1: str, v1_1: uint8) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    v29_1: enum_type("System.IO.FileAttributes", int, [("None", 0.0), ("ReadOnly", 1.0), ("Hidden", 2.0), ("System", 4.0), ("Directory", 16.0), ("Archive", 32.0), ("Device", 64.0), ("Normal", 128.0), ("Temporary", 256.0), ("SparseFile", 512.0), ("ReparsePoint", 1024.0), ("Compressed", 2048.0), ("Offline", 4096.0), ("NotContentIndexed", 8192.0), ("Encrypted", 16384.0), ("IntegrityStream", 32768.0), ("NoScrubData", 131072.0)]) = method113(None) or 0
    v31_1: bool = method115(method114(), v29_1)
    if v31_1:
        return FSharpResult_2(0, None)

    else: 
        def v131(v: uint8, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Callable[[str], FSharpResult_2[std_path_path_buf, std_io_error]]:
            return closure52(v0_1, v)

        return method118(v0_1, uncurry2(v131), v1_1, "file_system.read_link / Fsharp / The file or directory is not a reparse point. / " + (((((((("path: " + v0_1) + " / result: ") + str(v31_1)) + " / path\': ") + v0_1) + " / n: ") + str(v1_1)) + ""))



def method101(v0_1: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    return FSharpResult_2()


def closure54(unit_var: None, v0_1: std_path_path_buf) -> US14:
    return US14(0, v0_1)


def method119(__unit: None=None) -> Callable[[std_path_path_buf], US14]:
    def _arrow381(v: std_path_path_buf) -> US14:
        return closure54(None, v)

    return _arrow381


def method121(v0_1: str) -> str:
    return v0_1


def method120(v0_1: str, v1_1: str, v2_1: str) -> str:
    return None


def method100(v0_1: str) -> str:
    if v0_1 == "":
        return ""

    else: 
        v3: FSharpResult_2[std_path_path_buf, std_io_error] = method101(v0_1)
        v12: std_path_path_buf | None = None if (v3.tag == 1) else v3.fields[0]
        v31_1: US14 = default_arg(map(method119(), v12), US14(1))
        v66: str
        if v31_1.tag == 0:
            v60: str = to_string_2(v31_1.fields[0])
            v66 = v0_1 if (v60 == "") else v60

        else: 
            v66 = v0_1

        if v66 == "":
            return ""

        else: 
            v71: str = method120("^\\\\\\\\\\?\\\\", "", v66)
            def _arrow382(__unit: None=None, v0_1: Any=v0_1) -> str:
                _arg: str = v71[0]
                return _arg.lower()

            return replace(concat(_arrow382(), *v71[1:len(v71)]), "\\", "/")




def closure46(unit_var: None, v0_1: str) -> str:
    return method100(v0_1)


def closure55(unit_var: None, v0_1: str) -> str:
    return concat("file:///", *trim_start(v0_1, *to_array(singleton_1("/"))))


def method123(v0_1_mut: str, v1_1_mut: str, v2_1_mut: str) -> US15:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if method10(method80(v2_1, v0_1)):
            return US15(0, v2_1)

        else: 
            v6: str | None = method109(v2_1)
            v20_1: US5 = default_arg(map(method5(), v6), US5(1))
            if v20_1.tag == 0:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v20_1.fields[0]
                continue

            else: 
                return US15(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v2_1) + "\')")


        break


def method122(v0_1: str, v1_1: str) -> US15:
    if method10(method80(v1_1, v0_1)):
        return US15(0, v1_1)

    else: 
        v5: str | None = method109(v1_1)
        v19_1: US5 = default_arg(map(method5(), v5), US5(1))
        if v19_1.tag == 0:
            return method123(v0_1, v1_1, v19_1.fields[0])

        else: 
            return US15(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v1_1) + "\')")




def method125(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method18())
    v9: None
    closure6(v2_1, "{ ", None)
    v9 = None
    v18_1: None
    closure6(v2_1, "error", None)
    v18_1 = None
    v27_1: None
    closure6(v2_1, " = ", None)
    v27_1 = None
    v35_1: None
    closure6(v2_1, v0_1, None)
    v35_1 = None
    v44: None
    closure6(v2_1, " }", None)
    v44 = None
    return v2_1.l0


def method124(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str) -> str:
    v9: str = method125(v8)
    return method23(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "file_system.get_workspace_root") + " / ") + v9) + "")


def closure57(v0_1: str, unit_var: None) -> None:
    if method11(US0(3)):
        v5: None
        closure0(None, None)
        v5 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
        v24_1: int64 | None = pattern_input[5]
        v23_1: Mut4 = pattern_input[4]
        v22_1: Mut3 = pattern_input[3]
        v21_1: Mut2 = pattern_input[2]
        v20_1: Mut1 = pattern_input[1]
        v19_1: Mut0 = pattern_input[0]
        method24(method124(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, method12(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1), method43(), v0_1))



def method126(__unit: None=None) -> str:
    return None


def closure56(unit_var: None, unit_var_1: None) -> str:
    v4: US15 = method122(method80("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral")
    v52: US5
    if v4.tag == 0:
        v52 = US5(0, v4.fields[0])

    else: 
        v10: None
        closure57(v4.fields[0], None)
        v10 = None
        v52 = US5(1)

    v107: US5
    if v52.tag == 0:
        v107 = US5(0, v52.fields[0])

    else: 
        v55: str = method126()
        v57: US15 = method122(method80("polyglot", ".devcontainer"), v55)
        if v57.tag == 0:
            v107 = US5(0, v57.fields[0])

        else: 
            v63: None
            closure57(v57.fields[0], None)
            v63 = None
            v107 = US5(1)


    def _arrow383(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
        raise Exception("Option does not have a value.")

    return method80(v107.fields[0] if (v107.tag == 0) else _arrow383(), "polyglot")


def closure59(v0_1: Exception, unit_var: None) -> Exception:
    return v0_1


def method127(v0_1: str) -> None:
    pass


def closure58(unit_var: None, v0_1: str) -> None:
    method127(v0_1)


def closure60(unit_var: None, v0_1: bool) -> None:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
    def _arrow384(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure58(None, v)

    def _arrow385(v_1: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure2(None, v_1)

    v37: Callable[[str], None] = _arrow384 if v0_1 else _arrow385
    pattern_input[1].l0 = v37


def method128(v0_1: str, v1_1: str) -> None:
    if method10(v0_1) == False:
        v4: IDisposable = method83(v0_1)

    v7: str = default_arg(method109(v1_1), "")
    if method10(v7) == False:
        v12: IDisposable = method83(v7)

    def _arrow386(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> bool:
        v14: FSharpResult_2[std_path_path_buf, std_io_error] = method101(v1_1)
        return True

    if _arrow386() if method10(v1_1) else False:
        method9(True, v1_1)

    if method10(v1_1) == False:
        pass



def closure62(v0_1: str, v1_1: str) -> None:
    method128(v0_1, v1_1)


def closure61(unit_var: None, v0_1: str) -> Callable[[str], None]:
    def _arrow387(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure62(v0_1, v)

    return _arrow387


def closure64(v0_1: str, v1_1: str) -> str:
    return method80(v0_1, v1_1)


def closure63(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow388(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure64(v0_1, v)

    return _arrow388


v0: None = None

def _arrow389(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow389

def _expr390():
    v1(None)
    return v0


v2: None = _expr390()

def _arrow391(v: str) -> Async[int64]:
    return closure3(None, v)


v16: Callable[[str], Async[int64]] = _arrow391

def delete_directory_async(x: str) -> Async[int64]:
    return v16(x)


def _arrow392(v: US6) -> Callable[[str], Async[int64]]:
    return closure10(None, v)


v17: Callable[[US6, str], Async[int64]] = _arrow392

def wait_for_file_access(x: US6) -> Callable[[str], Async[int64]]:
    return v17(x)


def _arrow393(v: str) -> Async[int64]:
    return closure13(None, v)


v18: Callable[[str], Async[int64]] = _arrow393

def wait_for_file_access_read(x: str) -> Async[int64]:
    return v18(x)


def _arrow394(v: str) -> Async[str]:
    return closure14(None, v)


v19: Callable[[str], Async[str]] = _arrow394

def read_all_text_async(x: str) -> Async[str]:
    return v19(x)


def _arrow395(v: str) -> Callable[[str], bool]:
    return closure15(None, v)


v20: Callable[[str, str], bool] = _arrow395

def file_exists_content(x: str) -> Callable[[str], bool]:
    return v20(x)


def _arrow396(v: str) -> Callable[[str], Async[None]]:
    return closure17(None, v)


v21: Callable[[str, str], Async[None]] = _arrow396

def write_all_text_async(x: str) -> Callable[[str], Async[None]]:
    return v21(x)


def _arrow397(v: str) -> Callable[[str], Async[None]]:
    return closure19(None, v)


v22: Callable[[str, str], Async[None]] = _arrow397

def write_all_text_exists(x: str) -> Callable[[str], Async[None]]:
    return v22(x)


def _arrow398(v: str) -> Async[int64]:
    return closure21(None, v)


v23: Callable[[str], Async[int64]] = _arrow398

def delete_file_async(x: str) -> Async[int64]:
    return v23(x)


def _arrow399(v: str) -> Callable[[str], Async[int64]]:
    return closure23(None, v)


v24: Callable[[str, str], Async[int64]] = _arrow399

def move_file_async(x: str) -> Callable[[str], Async[int64]]:
    return v24(x)


def _arrow400(v: str) -> Async[str | None]:
    return closure26(None, v)


v25: Callable[[str], Async[str | None]] = _arrow400

def read_all_text_retry_async(x: str) -> Async[str | None]:
    return v25(x)


def _arrow401(__unit: None=None) -> str:
    return closure32(None, None)


v26: Callable[[], str] = _arrow401

def create_temp_path(__unit: None=None) -> str:
    return v26(None)


def _arrow402(__unit: None=None) -> tuple[str, IDisposable]:
    return closure34(None, None)


v27: Callable[[], tuple[str, IDisposable]] = _arrow402

def create_temp_dir(__unit: None=None) -> tuple[str, IDisposable]:
    return v27(None)


def _arrow403(v: str) -> tuple[str, IDisposable]:
    return closure43(None, v)


v28: Callable[[str], tuple[str, IDisposable]] = _arrow403

def create_temp_dir_0027(x: str) -> tuple[str, IDisposable]:
    return v28(x)


def _arrow404(__unit: None=None) -> str:
    return closure45(None, None)


v29: Callable[[], str] = _arrow404

def get_source_directory(__unit: None=None) -> str:
    return v29(None)


def _arrow405(v: str) -> str:
    return closure46(None, v)


v30: Callable[[str], str] = _arrow405

def normalize_path(x: str) -> str:
    return v30(x)


def _arrow406(v: str) -> str:
    return closure55(None, v)


v31: Callable[[str], str] = _arrow406

def new_file_uri(x: str) -> str:
    return v31(x)


def _arrow407(__unit: None=None) -> str:
    return closure56(None, None)


v32: Callable[[], str] = _arrow407

def get_workspace_root(__unit: None=None) -> str:
    return v32(None)


def _arrow408(v: str) -> None:
    closure58(None, v)


v33: Callable[[str], None] = _arrow408

def trace_file(x: str) -> None:
    v33(x)


def _arrow409(v: bool) -> None:
    closure60(None, v)


v34: Callable[[bool], None] = _arrow409

def init_trace_file(x: bool) -> None:
    v34(x)


def _arrow410(v: str) -> Callable[[str], None]:
    return closure61(None, v)


v35: Callable[[str, str], None] = _arrow410

def link_directory(x: str) -> Callable[[str], None]:
    return v35(x)


def _arrow411(v: str) -> Callable[[str], str]:
    return closure63(None, v)


v36: Callable[[str, str], str] = _arrow411

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v36(x)


