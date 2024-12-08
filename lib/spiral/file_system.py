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
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.result import FSharpResult_2
from fable_modules.fable_library.string_ import (trim_end, trim_start, to_text, interpolate, concat, pad_left, replace)
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


def _expr286() -> TypeInfo:
    return class_type("File_system.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr286

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


class IPathDirname(Protocol):
    @abstractmethod
    def dirname(self, path: str) -> str:
        ...


def _expr287() -> TypeInfo:
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


US0_reflection = _expr287

def _expr288() -> TypeInfo:
    return record_type("File_system.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr288

def _expr289() -> TypeInfo:
    return record_type("File_system.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr289

def _expr290() -> TypeInfo:
    return record_type("File_system.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr290

def _expr291() -> TypeInfo:
    return record_type("File_system.Mut3", [], Mut3, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: str

Mut3_reflection = _expr291

def _expr292() -> TypeInfo:
    return record_type("File_system.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr292

def _expr293() -> TypeInfo:
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


US1_reflection = _expr293

def _expr294() -> TypeInfo:
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


US2_reflection = _expr294

def _expr295() -> TypeInfo:
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


US3_reflection = _expr295

def _expr296() -> TypeInfo:
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


US4_reflection = _expr296

def _expr297() -> TypeInfo:
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


US5_reflection = _expr297

def _expr298() -> TypeInfo:
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


US7_reflection = _expr298

def _expr299() -> TypeInfo:
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


US8_reflection = _expr299

def _expr300() -> TypeInfo:
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


US6_reflection = _expr300

def _expr301() -> TypeInfo:
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


US9_reflection = _expr301

def _expr302() -> TypeInfo:
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


US10_reflection = _expr302

def _expr303() -> TypeInfo:
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


US11_reflection = _expr303

def _expr304() -> TypeInfo:
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


US12_reflection = _expr304

def _expr305() -> TypeInfo:
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


US13_reflection = _expr305

def _expr306() -> TypeInfo:
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


US14_reflection = _expr306

def _expr307() -> TypeInfo:
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


US15_reflection = _expr307

def method3(v0_1: str) -> str:
    return v0_1


def method4(__unit: None=None) -> str:
    return ""


def closure1(unit_var: None, v0_1: str) -> US5:
    return US5(0, v0_1)


def method5(__unit: None=None) -> Callable[[str], US5]:
    def _arrow308(v: str) -> US5:
        return closure1(None, v)

    return _arrow308


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
    def _arrow309(__unit: None=None) -> US1:
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




    return (US1(0, v6.fields[0]) if (v6.tag == 0) else _arrow309(), US2(1) if (method2("AUTOMATION") != "True") else US2(0, from_value(ticks_1(now()), False)))


def closure2(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None]:
    pattern_input: tuple[US1, US2] = method1()
    _v1: tuple[US1, US2] = (pattern_input[0], pattern_input[1])
    v132: US2 = _v1[1]
    v131: US1 = _v1[0]
    def v138(v: str, v0_1: Any=v0_1) -> None:
        closure2(None, v)

    return (Mut0(int64(1)), Mut1(v138), Mut2(True), Mut3(""), Mut4(v131.fields[0] if (v131.tag == 0) else v0_1), v132.fields[0] if (v132.tag == 0) else None)


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


def method10(v0_1: US0) -> bool:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
    v35_1: US0 = pattern_input[4].l0
    if pattern_input[2].l0 == False:
        return False

    else: 
        class ObjectExpr310:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        class ObjectExpr311:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        return find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr310())) >= find(v35_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr311()))



def closure5(unit_var: None, v0_1: int64) -> US2:
    return US2(0, v0_1)


def method12(__unit: None=None) -> Callable[[int64], US2]:
    def _arrow312(v: int64) -> US2:
        return closure5(None, v)

    return _arrow312


def method13(__unit: None=None) -> str:
    return "hh:mm:ss"


def method14(__unit: None=None) -> str:
    return "HH:mm:ss"


def method11(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None=None) -> str:
    v453: US2 = default_arg(map(method12(), v5), US2(1))
    v550: Any
    if v453.tag == 0:
        v510: Any = create(op_subtraction(from_value(ticks_1(now()), False), v453.fields[0]))
        v550 = create_1(1, 1, 1, hours(v510), minutes(v510), seconds(v510), milliseconds(v510))

    else: 
        v550 = now()

    v551: str = method14()
    return to_string(v550, "M-d-y hh:mm:ss tt" if (v551 == "") else v551)


def method17(__unit: None=None) -> str:
    return ""


def closure6(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def method16(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method17())
    v8: None
    closure6(v2_1, ("" + str(v0_1)) + "", None)
    v8 = None
    return v2_1.l0


def method18(__unit: None=None) -> str:
    return "\u001b[0m"


def method15(__unit: None=None) -> str:
    v2_1: str = "Debug".lower()
    return ("\u001b[94m" + method16(v2_1[0])) + method18()


def method19(v0_1: str) -> str:
    raise Exception(((("file_system.get_file_name / target: " + str(US4(4, US3(0)))) + " / path: ") + v0_1) + "")


def method21(v0_1: str, v1_1: str) -> str:
    v3: Mut3 = Mut3(method17())
    v10: None
    closure6(v3, "{ ", None)
    v10 = None
    v19_1: None
    closure6(v3, "ex", None)
    v19_1 = None
    v28_1: None
    closure6(v3, " = ", None)
    v28_1 = None
    v36: None
    closure6(v3, v0_1, None)
    v36 = None
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


def method22(v0_1: str) -> str:
    return trim_end(trim_start(v0_1, *to_array(empty())), *to_array(of_array([" ", "/"])))


def method20(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str, v9: str) -> str:
    v10: str = method21(v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "file_system.delete_directory_async") + " / ") + v10) + "")


def closure7(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure9(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure8(unit_var: None, v0_1: str) -> None:
    v3: None
    closure9(v0_1, None)
    v3 = None


def method23(v0_1: str) -> None:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
    v37: None
    closure7(pattern_input[0], None)
    v37 = None
    closure8(None, v0_1)
    pattern_input[1].l0(v0_1)


def closure4(v0_1: str, v1_1: str, unit_var: None) -> None:
    if method10(US0(1)):
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
        method23(method20(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method11(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method15(), v1_1, method19(v0_1)))



def method6(v0_1: str, v1_1: int64) -> Async[int64]:
    def _arrow318(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[int64]:
        def _arrow313(__unit: None=None) -> Async[int64]:
            method7(True, v0_1)
            return singleton.Return(v1_1)

        def _arrow317(_arg: Exception) -> Async[int64]:
            v113: bool = op_modulus(v1_1, int64(100)) == int64(0)
            def _arrow314(__unit: None=None) -> Async[None]:
                v141: None
                closure4(v0_1, to_text(interpolate("%A%P()", [_arg])), None)
                v141 = None
                return singleton.Zero()

            def _arrow316(__unit: None=None) -> Async[int64]:
                v192: Async[None] = sleep(10)
                def _arrow315(__unit: None=None) -> Async[int64]:
                    v203: Async[int64] = method6(v0_1, op_addition(v1_1, int64(1)))
                    return singleton.ReturnFrom(v203)

                return singleton.Bind(v192, _arrow315)

            return singleton.Combine(_arrow314() if v113 else singleton.Zero(), singleton.Delay(_arrow316))

        return singleton.TryWith(singleton.Delay(_arrow313), _arrow317)

    return singleton.Delay(_arrow318)


def closure3(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def method26(v0_1: str, v1_1: int64, v2_1: str) -> str:
    v4: Mut3 = Mut3(method17())
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


def method25(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str, v9: int64, v10: str) -> str:
    v11: str = method26(v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "file_system.wait_for_file_access") + " / ") + v11) + "")


def closure12(v0_1: str, v1_1: int64, v2_1: str, unit_var: None) -> None:
    if method10(US0(1)):
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
        method23(method25(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, method11(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1), method15(), method19(v0_1), v1_1, v2_1))



def method24(v0_1: str, v1_1: US8, v2_1: US7, v3: int64) -> Async[int64]:
    def _arrow325(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3) -> Async[int64]:
        def _arrow320(__unit: None=None) -> Async[int64]:
            def _arrow319(_arg: Any) -> Async[int64]:
                return singleton.Return(v3)

            return singleton.Using(None, _arrow319)

        def _arrow324(_arg_1: Exception) -> Async[int64]:
            v203: bool = (op_modulus(v3, int64(100)) == int64(0)) if (v3 > int64(0)) else False
            def _arrow321(__unit: None=None) -> Async[None]:
                v231: None
                closure12(v0_1, v3, to_text(interpolate("%A%P()", [_arg_1])), None)
                v231 = None
                return singleton.Zero()

            def _arrow323(__unit: None=None) -> Async[int64]:
                v282: Async[None] = sleep(10)
                def _arrow322(__unit: None=None) -> Async[int64]:
                    v293: Async[int64] = method24(v0_1, v1_1, v2_1, op_addition(v3, int64(1)))
                    return singleton.ReturnFrom(v293)

                return singleton.Bind(v282, _arrow322)

            return singleton.Combine(_arrow321() if v203 else singleton.Zero(), singleton.Delay(_arrow323))

        return singleton.TryWith(singleton.Delay(_arrow320), _arrow324)

    return singleton.Delay(_arrow325)


def closure11(v0_1: US6, v1_1: str) -> Async[int64]:
    return None


def closure10(unit_var: None, v0_1: US6) -> Callable[[str], Async[int64]]:
    def _arrow326(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure11(v0_1, v)

    return _arrow326


def method27(v0_1: str, v1_1: int64) -> Async[int64]:
    def _arrow333(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[int64]:
        def _arrow328(__unit: None=None) -> Async[int64]:
            def _arrow327(_arg: Any) -> Async[int64]:
                return singleton.Return(v1_1)

            return singleton.Using(None, _arrow327)

        def _arrow332(_arg_1: Exception) -> Async[int64]:
            v173: bool = (op_modulus(v1_1, int64(100)) == int64(0)) if (v1_1 > int64(0)) else False
            def _arrow329(__unit: None=None) -> Async[None]:
                v201: None
                closure12(v0_1, v1_1, to_text(interpolate("%A%P()", [_arg_1])), None)
                v201 = None
                return singleton.Zero()

            def _arrow331(__unit: None=None) -> Async[int64]:
                v252: Async[None] = sleep(10)
                def _arrow330(__unit: None=None) -> Async[int64]:
                    v263: Async[int64] = method27(v0_1, op_addition(v1_1, int64(1)))
                    return singleton.ReturnFrom(v263)

                return singleton.Bind(v252, _arrow330)

            return singleton.Combine(_arrow329() if v173 else singleton.Zero(), singleton.Delay(_arrow331))

        return singleton.TryWith(singleton.Delay(_arrow328), _arrow332)

    return singleton.Delay(_arrow333)


def closure13(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def closure14(unit_var: None, v0_1: str) -> Async[str]:
    return None


def method29(v0_1: str) -> bool:
    return None


def method30(v0_1: Vec_1[uint8]) -> Vec_1[uint8]:
    return v0_1


def method28(v0_1: str, v1_1: str) -> bool:
    return None


def closure16(v0_1: str, v1_1: str) -> bool:
    return method28(v0_1, v1_1)


def closure15(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow334(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure16(v0_1, v)

    return _arrow334


def closure18(v0_1: str, v1_1: str) -> Async[None]:
    return None


def closure17(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow335(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure18(v0_1, v)

    return _arrow335


def closure20(v0_1: str, v1_1: str) -> Async[None]:
    def _arrow339(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[None]:
        def _arrow338(_arg: bool) -> Async[None]:
            v557: bool = _arg == False
            def _arrow336(__unit: None=None) -> Async[None]:
                return singleton.Zero()

            def _arrow337(__unit: None=None) -> Async[None]:
                return singleton.Zero()

            return singleton.Combine(singleton.Bind(None, _arrow336) if v557 else singleton.Zero(), singleton.Delay(_arrow337))

        return singleton.Bind(None, _arrow338)

    return singleton.Delay(_arrow339)


def closure19(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow340(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure20(v0_1, v)

    return _arrow340


def method32(__unit: None=None) -> str:
    v2_1: str = "Warning".lower()
    return ("\u001b[93m" + method16(v2_1[0])) + method18()


def method34(v0_1: str, v1_1: str) -> str:
    v3: Mut3 = Mut3(method17())
    v10: None
    closure6(v3, "{ ", None)
    v10 = None
    v19_1: None
    closure6(v3, "path", None)
    v19_1 = None
    v28_1: None
    closure6(v3, " = ", None)
    v28_1 = None
    v36: None
    closure6(v3, v0_1, None)
    v36 = None
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


def method33(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str, v9: str) -> str:
    v10: str = method34(v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "delete_file_async") + " / ") + v10) + "")


def closure22(v0_1: str, v1_1: Exception, unit_var: None) -> None:
    if method10(US0(3)):
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
        method23(method33(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method11(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method32(), method19(v0_1), to_text(interpolate("%A%P()", [v1_1]))))



def method31(v0_1: str, v1_1: int64) -> Async[int64]:
    def _arrow346(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[int64]:
        def _arrow341(__unit: None=None) -> Async[int64]:
            return singleton.Return(v1_1)

        def _arrow345(_arg: Exception) -> Async[int64]:
            v117: bool = op_modulus(v1_1, int64(100)) == int64(0)
            def _arrow342(__unit: None=None) -> Async[None]:
                v120: None
                closure22(v0_1, _arg, None)
                v120 = None
                return singleton.Zero()

            def _arrow344(__unit: None=None) -> Async[int64]:
                v196: Async[None] = sleep(10)
                def _arrow343(__unit: None=None) -> Async[int64]:
                    v207: Async[int64] = method31(v0_1, op_addition(v1_1, int64(1)))
                    return singleton.ReturnFrom(v207)

                return singleton.Bind(v196, _arrow343)

            return singleton.Combine(_arrow342() if v117 else singleton.Zero(), singleton.Delay(_arrow344))

        return singleton.TryWith(singleton.Delay(_arrow341), _arrow345)

    return singleton.Delay(_arrow346)


def closure21(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def method37(v0_1: str, v1_1: str, v2_1: Exception) -> str:
    v4: Mut3 = Mut3(method17())
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
    v134: None
    closure6(v4, to_text(interpolate("%A%P()", [v2_1])), None)
    v134 = None
    v143: None
    closure6(v4, " }", None)
    v143 = None
    return v4.l0


def method36(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str, v9: str, v10: Exception) -> str:
    v11: str = method37(v8, v9, v10)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "move_file_async") + " / ") + v11) + "")


def closure25(v0_1: str, v1_1: str, v2_1: Exception, unit_var: None) -> None:
    if method10(US0(3)):
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
        method23(method36(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1, method11(v21_1, v22_1, v23_1, v24_1, v25_1, v26_1), method32(), method19(v1_1), method19(v0_1), v2_1))



def method35(v0_1: str, v1_1: str, v2_1: int64) -> Async[int64]:
    def _arrow352(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> Async[int64]:
        def _arrow347(__unit: None=None) -> Async[int64]:
            return singleton.Return(v2_1)

        def _arrow351(_arg: Exception) -> Async[int64]:
            v89: bool = op_modulus(v2_1, int64(100)) == int64(0)
            def _arrow348(__unit: None=None) -> Async[None]:
                v92: None
                closure25(v0_1, v1_1, _arg, None)
                v92 = None
                return singleton.Zero()

            def _arrow350(__unit: None=None) -> Async[int64]:
                v144: Async[None] = sleep(10)
                def _arrow349(__unit: None=None) -> Async[int64]:
                    v155: Async[int64] = method35(v0_1, v1_1, op_addition(v2_1, int64(1)))
                    return singleton.ReturnFrom(v155)

                return singleton.Bind(v144, _arrow349)

            return singleton.Combine(_arrow348() if v89 else singleton.Zero(), singleton.Delay(_arrow350))

        return singleton.TryWith(singleton.Delay(_arrow347), _arrow351)

    return singleton.Delay(_arrow352)


def closure24(v0_1: str, v1_1: str) -> Async[int64]:
    return None


def closure23(unit_var: None, v0_1: str) -> Callable[[str], Async[int64]]:
    def _arrow353(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure24(v0_1, v)

    return _arrow353


def method39(v0_1: int64) -> int64:
    return v0_1


def closure27(unit_var: None, v0_1: int64) -> US9:
    return US9(0, v0_1)


def method41(__unit: None=None) -> Callable[[int64], US9]:
    def _arrow354(v: int64) -> US9:
        return closure27(None, v)

    return _arrow354


def closure28(unit_var: None, v0_1: Exception) -> US9:
    return US9(1, v0_1)


def method42(__unit: None=None) -> Callable[[Exception], US9]:
    def _arrow355(v: Exception) -> US9:
        return closure28(None, v)

    return _arrow355


def method43(__unit: None=None) -> str:
    v2_1: str = "Verbose".lower()
    return ("\u001b[90m" + method16(v2_1[0])) + method18()


def method45(v0_1: int) -> str:
    v2_1: Mut3 = Mut3(method17())
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


def method44(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: int) -> str:
    v9: str = method45(v8)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "async.run_with_timeout_async") + " / ") + v9) + "")


def closure29(v0_1: int, unit_var: None) -> None:
    if method10(US0(0)):
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
        method23(method44(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, method11(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1), method43(), v0_1))



def method46(__unit: None=None) -> str:
    v2_1: str = "Critical".lower()
    return ("\u001b[91m" + method16(v2_1[0])) + method18()


def method48(v0_1: int, v1_1: str) -> str:
    v3: Mut3 = Mut3(method17())
    v10: None
    closure6(v3, "{ ", None)
    v10 = None
    v19_1: None
    closure6(v3, "timeout", None)
    v19_1 = None
    v28_1: None
    closure6(v3, " = ", None)
    v28_1 = None
    v36: None
    closure6(v3, ("" + str(v0_1)) + "", None)
    v36 = None
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


def method47(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: int, v9: str) -> str:
    v10: str = method48(v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "async.run_with_timeout_async**") + " / ") + v10) + "")


def closure30(v0_1: int, v1_1: Exception, unit_var: None) -> None:
    if method10(US0(4)):
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
        method23(method47(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method11(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method46(), v0_1, to_text(interpolate("%A%P()", [v1_1]))))



def method40(v0_1: int, v1_1: Async[int64]) -> Async[US2]:
    def _arrow363(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[US2]:
        v12852: Async[Async[int64]] = start_child(v1_1, v0_1)
        def _arrow362(_arg: Async[int64]) -> Async[US2]:
            v12871: Async[Any] = catch_async(_arg)
            def _arrow357(__unit: None=None) -> Async[US9]:
                def _arrow356(_arg_1: Any) -> Async[US9]:
                    return singleton.Return(None)

                return singleton.Bind(v12871, _arrow356)

            _v12921: Async[US9] = singleton.Delay(_arrow357)
            def _arrow359(__unit: None=None) -> Async[US10]:
                def _arrow358(_arg_2: US9) -> Async[US10]:
                    v13036: US9 = _arg_2
                    v13042: US10 = US10(1, v13036.fields[0]) if (v13036.tag == 1) else US10(0, v13036.fields[0])
                    return singleton.Return(v13042)

                return singleton.Bind(_v12921, _arrow358)

            _v13035: Async[US10] = singleton.Delay(_arrow359)
            def _arrow361(__unit: None=None) -> Async[US2]:
                def _arrow360(_arg_3: US10) -> Async[US2]:
                    v13205: US10 = _arg_3
                    v13329: US2
                    if v13205.tag == 0:
                        v13329 = US2(0, v13205.fields[0])

                    else: 
                        v13208: Exception = v13205.fields[0]
                        v13209: str = to_text(interpolate("%A%P()", [v13208]))
                        if v13209.find("System.TimeoutException") >= 0:
                            v13218: None
                            closure29(v0_1, None)
                            v13218 = None
                            v13329 = US2(1)

                        else: 
                            v13261: None
                            closure30(v0_1, v13208, None)
                            v13261 = None
                            v13329 = US2(1)


                    return singleton.Return(v13329)

                return singleton.Bind(_v13035, _arrow360)

            _v13204: Async[US2] = singleton.Delay(_arrow361)
            return singleton.ReturnFrom(_v13204)

        return singleton.Bind(v12852, _arrow362)

    return singleton.Delay(_arrow363)


def method50(v0_1: int64, v1_1: str) -> str:
    v3: Mut3 = Mut3(method17())
    v10: None
    closure6(v3, "{ ", None)
    v10 = None
    v19_1: None
    closure6(v3, "retry", None)
    v19_1 = None
    v28_1: None
    closure6(v3, " = ", None)
    v28_1 = None
    v36: None
    closure6(v3, ("" + str(v0_1)) + "", None)
    v36 = None
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


def method49(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: int64, v9: str) -> str:
    v10: str = method50(v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "file_system.read_all_text_retry_async") + " / ") + v10) + "")


def closure31(v0_1: int64, v1_1: str, unit_var: None) -> None:
    if method10(US0(1)):
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
        method23(method49(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method11(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method15(), v0_1, v1_1))



def method38(v0_1: str, v1_1: int64) -> Async[str | None]:
    def _arrow371(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Async[str | None]:
        v227: int64 = method39(v1_1)
        def _arrow369(__unit: None=None) -> Async[str | None]:
            v228: bool = v227 > int64(0)
            def _arrow365(__unit: None=None) -> Async[None]:
                v270: Async[None] = ignore(method40(1000, None))
                def _arrow364(__unit: None=None) -> Async[None]:
                    return singleton.Zero()

                return singleton.Bind(v270, _arrow364)

            def _arrow368(__unit: None=None) -> Async[str | None]:
                def _arrow367(__unit: None=None) -> Async[str | None]:
                    def _arrow366(_arg_1: str) -> Async[str | None]:
                        return singleton.Return(_arg_1)

                    return singleton.Bind(None, _arrow366)

                _v342: Async[str | None] = singleton.Delay(_arrow367)
                return singleton.ReturnFrom(_v342)

            return singleton.Combine(_arrow365() if v228 else singleton.Zero(), singleton.Delay(_arrow368))

        def _arrow370(_arg_2: Exception) -> Async[str | None]:
            if (v227 == int64(0)) != True:
                v395: None
                closure31(v227, to_text(interpolate("%A%P()", [_arg_2])), None)
                v395 = None
                return singleton.Return(None)

            else: 
                v437: Async[str | None] = method38(v0_1, op_addition(v227, int64(1)))
                return singleton.ReturnFrom(v437)


        return singleton.TryWith(singleton.Delay(_arrow369), _arrow370)

    return singleton.Delay(_arrow371)


def closure26(unit_var: None, v0_1: str) -> Async[str | None]:
    return None


def closure33(unit_var: None, v0_1: chrono_date_time_1[chrono_utc]) -> US11:
    return US11(0, v0_1)


def method53(__unit: None=None) -> Callable[[chrono_date_time_1[chrono_utc]], US11]:
    def _arrow372(v: chrono_date_time_1[chrono_utc]) -> US11:
        return closure33(None, v)

    return _arrow372


def method54(__unit: None=None) -> str:
    return "hh:mm"


def method55(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method56(__unit: None=None) -> str:
    return "hhmm"


def method52(v0_1: str, v1_1: Any) -> str:
    v1075: str = method55()
    v1080: str = to_string(v1_1, "M-d-y hh:mm:ss tt" if (v1075 == "") else v1075)
    v1261: Any
    raise Exception(("date_time.get_utc_offset / target: " + str(US4(4, US3(0)))) + "")
    v1274: uint8 = uint8(1) if (hours(v1261) > 0) else uint8(0)
    v1275: str = method56()
    v1299: str = ((("" + str(v1274)) + "") + to_string_1(v1261, "c", {})) + ""
    v1301: str = str(v0_1)
    v1306: int = (len(v1080) + len(v1299)) or 0
    v1325: int = (len(v1301) - 1) or 0
    return parse(concat(v1080, v1299, *v1301[v1306:v1325 + 1]))


def method58(__unit: None=None) -> str:
    raise Exception(("file_system.get_temp_path / target: " + str(US4(4, US3(0)))) + "")


def method59(__unit: None=None) -> str:
    return "!create_temp_path_"


def method62(v0_1: str) -> str:
    return v0_1


def method61(v0_1: str, v1_1: str) -> tuple[str, str]:
    return (v1_1, method62(v0_1))


def method60(v0_1: str, v1_1: str) -> str:
    raise Exception(((((("file_system.(</>) / target: " + str(US4(4, US3(0)))) + " / a: ") + v0_1) + " / b: ") + v1_1) + "")


def method64(__unit: None=None) -> str:
    return "CARGO_PKG_NAME"


def method63(__unit: None=None) -> str:
    raise Exception(("env.get_entry_assembly_name / target: " + str(US4(4, US3(0)))) + "")


def method57(v0_1: str) -> str:
    return method60(method60(method60(method58(), method59()), method63()), str(v0_1))


def method51(__unit: None=None) -> str:
    v74: Any = now()
    return method57(method52(new_guid(), v74))


def closure32(unit_var: None, unit_var_1: None) -> str:
    return method51()


def method66(v0_1: str) -> str:
    return v0_1


def closure35(unit_var: None, v0_1: std_io_error) -> std_string_string:
    return None


def method67(__unit: None=None) -> Callable[[std_io_error], std_string_string]:
    def _arrow373(v: std_io_error) -> std_string_string:
        return closure35(None, v)

    return _arrow373


def closure36(unit_var: None, unit_var_1: None) -> US12:
    return US12(0)


def method68(__unit: None=None) -> Callable[[], US12]:
    def _arrow374(__unit: None=None) -> US12:
        return closure36(None, None)

    return _arrow374


def closure37(unit_var: None, v0_1: std_string_string) -> US12:
    return US12(1, v0_1)


def method69(__unit: None=None) -> Callable[[std_string_string], US12]:
    def _arrow375(v: std_string_string) -> US12:
        return closure37(None, v)

    return _arrow375


def method71(v0_1: str, v1_1: std_string_string) -> str:
    v3: Mut3 = Mut3(method17())
    v10: None
    closure6(v3, "{ ", None)
    v10 = None
    v19_1: None
    closure6(v3, "dir", None)
    v19_1 = None
    v28_1: None
    closure6(v3, " = ", None)
    v28_1 = None
    v36: None
    closure6(v3, v0_1, None)
    v36 = None
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


def method70(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str, v9: std_string_string) -> str:
    v10: str = method71(v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "file_system.create_dir") + " / ") + v10) + "")


def closure38(v0_1: str, v1_1: std_string_string, unit_var: None) -> None:
    if method10(US0(4)):
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
        method23(method70(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method11(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method46(), v0_1, v1_1))



def method73(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method17())
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


def method72(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str) -> str:
    v9: str = method73(v8)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "file_system.create_dir") + " / ") + v9) + "")


def closure39(v0_1: str, unit_var: None) -> None:
    if method10(US0(0)):
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
        method23(method72(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, method11(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1), method43(), v0_1))



def closure40(v0_1: str, unit_var: None) -> None:
    method7(True, v0_1)


def method74(v0_1: str) -> Callable[[], None]:
    def _arrow376(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure40(v0_1, None)

    return _arrow376


def method75(v0_1: str) -> Callable[[], None]:
    def _arrow377(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure40(v0_1, None)

    return _arrow377


def method77(v0_1: str, v1_1: str) -> str:
    v3: Mut3 = Mut3(method17())
    v10: None
    closure6(v3, "{ ", None)
    v10 = None
    v19_1: None
    closure6(v3, "dir", None)
    v19_1 = None
    v28_1: None
    closure6(v3, " = ", None)
    v28_1 = None
    v36: None
    closure6(v3, v0_1, None)
    v36 = None
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


def method76(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str, v9: str) -> str:
    v10: str = method77(v8, v9)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "file_system.create_dir") + " / ") + v10) + "")


def closure41(v0_1: str, v1_1: str, unit_var: None) -> None:
    if method10(US0(1)):
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
        method23(method76(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1, method11(v20_1, v21_1, v22_1, v23_1, v24_1, v25_1), method15(), v0_1, v1_1))



def closure42(v0_1: str, unit_var: None) -> None:
    run_synchronously(ignore(None))


def method78(v0_1: str) -> Callable[[], None]:
    def _arrow378(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure42(v0_1, None)

    return _arrow378


def method79(v0_1: str) -> Callable[[], None]:
    def _arrow379(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure42(v0_1, None)

    return _arrow379


def method65(v0_1: str) -> IDisposable:
    v321: bool = None
    if v321 == False:
        v358: None
        closure41(v0_1, to_text(interpolate("%A%P()", [{
            "CreationTime": None,
            "Exists": v321
        }])), None)
        v358 = None

    v407: Callable[[], None] = method79(v0_1)
    class ObjectExpr380(IDisposable):
        def Dispose(self, __unit: None=None, v0_1: Any=v0_1) -> None:
            v407(None)

    return ObjectExpr380()


def closure34(unit_var: None, unit_var_1: None) -> tuple[str, IDisposable]:
    v0_1: str = method51()
    return (v0_1, method65(v0_1))


def method80(v0_1: str) -> str:
    v416: str = pad_left(v0_1, 32, "0")
    v444: int = (8 - 1) or 0
    v463: int = (12 - 1) or 0
    v482: int = (16 - 1) or 0
    v501: int = (20 - 1) or 0
    v520: int = (32 - 1) or 0
    return parse(((((((((("" + v416[0:v444 + 1]) + "-") + v416[8:v463 + 1]) + "-") + v416[12:v482 + 1]) + "-") + v416[16:v501 + 1]) + "-") + v416[20:v520 + 1]) + "")


def closure43(unit_var: None, v0_1: str) -> tuple[str, IDisposable]:
    v2_1: str = method57(method80(v0_1))
    return (v2_1, method65(v2_1))


def closure44(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def method85(v0_1: std_io_error) -> str:
    v2_1: Mut3 = Mut3(method17())
    v38: None
    closure6(v2_1, to_text(interpolate("%A%P()", [v0_1])), None)
    v38 = None
    return v2_1.l0


def closure46(unit_var: None, v0_1: std_io_error) -> str:
    return method85(v0_1)


def method84(__unit: None=None) -> Callable[[std_io_error], str]:
    def _arrow381(v: std_io_error) -> str:
        return closure46(None, v)

    return _arrow381


def closure47(unit_var: None, v0_1: std_path_path_buf) -> US13:
    return US13(0, v0_1)


def method86(__unit: None=None) -> Callable[[std_path_path_buf], US13]:
    def _arrow382(v: std_path_path_buf) -> US13:
        return closure47(None, v)

    return _arrow382


def closure48(unit_var: None, v0_1: str) -> US13:
    return US13(1, v0_1)


def method87(__unit: None=None) -> Callable[[str], US13]:
    def _arrow383(v: str) -> US13:
        return closure48(None, v)

    return _arrow383


def method90(v0_1: str) -> str | None:
    return None


def method91(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method17())
    v8: None
    closure6(v2_1, v0_1, None)
    v8 = None
    return v2_1.l0


def method89(v0_1: str, v1_1: Callable[[uint8, str], FSharpResult_2[std_path_path_buf, std_io_error]], v2_1: uint8, v3: str, v4: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    v5: str = method19(v4)
    v6: str | None = method90(v4)
    v20_1: US5 = default_arg(map(method5(), v6), US5(1))
    v24_1: str = method91(v3)
    if v2_1 >= uint8(11):
        return FSharpResult_2(1, ((((((("file_system.read_link / path: " + v0_1) + " / n: ") + str(v2_1)) + " / path\': ") + v4) + " / name: ") + v5) + "")

    elif v20_1.tag == 0:
        if v4 != "":
            v72: FSharpResult_2[std_path_path_buf, std_io_error] = v1_1(v2_1 + uint8(1), v20_1.fields[0])
            v73: Callable[[std_io_error], str] = method84()
            v85: FSharpResult_2[std_path_path_buf, str] = FSharpResult_2(1, v73(v72.fields[0])) if (v72.tag == 1) else FSharpResult_2(0, v72.fields[0])
            v88: Callable[[std_path_path_buf], US13] = method86()
            v89: Callable[[str], US13] = method87()
            v90: US13 = v89(v85.fields[0]) if (v85.tag == 1) else v88(v85.fields[0])
            if v90.tag == 0:
                return FSharpResult_2(0, method60(to_string_2(v90.fields[0]), v5))

            else: 
                return FSharpResult_2(1, ((((("file_system.read_link / error\': " + v90.fields[0]) + " / error: ") + v24_1) + " / name: ") + v5) + "")


        else: 
            return FSharpResult_2(1, ((((((("file_system.read_link / run / The file or directory is not a reparse point. / path: " + v0_1) + " / error: ") + v24_1) + " / path\': ") + v4) + " / name: ") + v5) + "")


    else: 
        return FSharpResult_2(1, ((((((("file_system.read_link / run / The file or directory is not a reparse point. / path: " + v0_1) + " / error: ") + v24_1) + " / path\': ") + v4) + " / name: ") + v5) + "")



def method88(v0_1: str, v1_1: uint8, v2_1: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    return None


def closure50(v0_1: str, v1_1: uint8, v2_1: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    return method88(v0_1, v1_1, v2_1)


def closure49(v0_1: str, v1_1: uint8) -> Callable[[str], FSharpResult_2[std_path_path_buf, std_io_error]]:
    def _arrow384(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> FSharpResult_2[std_path_path_buf, std_io_error]:
        return closure50(v0_1, v1_1, v)

    return _arrow384


def method92(v0_1: str, v1_1: Callable[[uint8, str], FSharpResult_2[std_path_path_buf, std_io_error]], v2_1: uint8, v3: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    v4: str = method19(v0_1)
    v5: str | None = method90(v0_1)
    v19_1: US5 = default_arg(map(method5(), v5), US5(1))
    v23_1: str = method91(v3)
    if v2_1 >= uint8(11):
        return FSharpResult_2(1, ((((((("file_system.read_link / path: " + v0_1) + " / n: ") + str(v2_1)) + " / path\': ") + v0_1) + " / name: ") + v4) + "")

    elif v19_1.tag == 0:
        if v0_1 != "":
            v71: FSharpResult_2[std_path_path_buf, std_io_error] = v1_1(v2_1 + uint8(1), v19_1.fields[0])
            v72: Callable[[std_io_error], str] = method84()
            v84: FSharpResult_2[std_path_path_buf, str] = FSharpResult_2(1, v72(v71.fields[0])) if (v71.tag == 1) else FSharpResult_2(0, v71.fields[0])
            v87: Callable[[std_path_path_buf], US13] = method86()
            v88: Callable[[str], US13] = method87()
            v89: US13 = v88(v84.fields[0]) if (v84.tag == 1) else v87(v84.fields[0])
            if v89.tag == 0:
                return FSharpResult_2(0, method60(to_string_2(v89.fields[0]), v4))

            else: 
                return FSharpResult_2(1, ((((("file_system.read_link / error\': " + v89.fields[0]) + " / error: ") + v23_1) + " / name: ") + v4) + "")


        else: 
            return FSharpResult_2(1, ((((((("file_system.read_link / run / The file or directory is not a reparse point. / path: " + v0_1) + " / error: ") + v23_1) + " / path\': ") + v0_1) + " / name: ") + v4) + "")


    else: 
        return FSharpResult_2(1, ((((((("file_system.read_link / run / The file or directory is not a reparse point. / path: " + v0_1) + " / error: ") + v23_1) + " / path\': ") + v0_1) + " / name: ") + v4) + "")



def method83(v0_1: str, v1_1: uint8) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    return None


def method95(v0_1: str, v1_1: Callable[[uint8, str], FSharpResult_2[std_path_path_buf, std_io_error]], v2_1: uint8, v3: std_io_error, v4: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    v5: str = method19(v4)
    v6: str | None = method90(v4)
    v20_1: US5 = default_arg(map(method5(), v6), US5(1))
    v24_1: str = method85(v3)
    if v2_1 >= uint8(11):
        return FSharpResult_2(1, ((((((("file_system.read_link / path: " + v0_1) + " / n: ") + str(v2_1)) + " / path\': ") + v4) + " / name: ") + v5) + "")

    elif v20_1.tag == 0:
        if v4 != "":
            v72: FSharpResult_2[std_path_path_buf, std_io_error] = v1_1(v2_1 + uint8(1), v20_1.fields[0])
            v73: Callable[[std_io_error], str] = method84()
            v85: FSharpResult_2[std_path_path_buf, str] = FSharpResult_2(1, v73(v72.fields[0])) if (v72.tag == 1) else FSharpResult_2(0, v72.fields[0])
            v88: Callable[[std_path_path_buf], US13] = method86()
            v89: Callable[[str], US13] = method87()
            v90: US13 = v89(v85.fields[0]) if (v85.tag == 1) else v88(v85.fields[0])
            if v90.tag == 0:
                return FSharpResult_2(0, method60(to_string_2(v90.fields[0]), v5))

            else: 
                return FSharpResult_2(1, ((((("file_system.read_link / error\': " + v90.fields[0]) + " / error: ") + v24_1) + " / name: ") + v5) + "")


        else: 
            return FSharpResult_2(1, ((((((("file_system.read_link / run / The file or directory is not a reparse point. / path: " + v0_1) + " / error: ") + v24_1) + " / path\': ") + v4) + " / name: ") + v5) + "")


    else: 
        return FSharpResult_2(1, ((((((("file_system.read_link / run / The file or directory is not a reparse point. / path: " + v0_1) + " / error: ") + v24_1) + " / path\': ") + v4) + " / name: ") + v5) + "")



def method94(v0_1: str, v1_1: uint8, v2_1: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    v99: bool = None
    if v99:
        return FSharpResult_2(0, None)

    else: 
        def v197(v: uint8, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> Callable[[str], FSharpResult_2[std_path_path_buf, std_io_error]]:
            return closure51(v0_1, v)

        return method95(v0_1, uncurry2(v197), v1_1, ((((((("file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: " + v0_1) + " / result: ") + str(v99)) + " / path\': ") + v2_1) + " / n: ") + str(v1_1)) + "", v2_1)



def closure52(v0_1: str, v1_1: uint8, v2_1: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    return method94(v0_1, v1_1, v2_1)


def closure51(v0_1: str, v1_1: uint8) -> Callable[[str], FSharpResult_2[std_path_path_buf, std_io_error]]:
    def _arrow385(v: str, v0_1: Any=v0_1, v1_1: Any=v1_1) -> FSharpResult_2[std_path_path_buf, std_io_error]:
        return closure52(v0_1, v1_1, v)

    return _arrow385


def method96(v0_1: str, v1_1: Callable[[uint8, str], FSharpResult_2[std_path_path_buf, std_io_error]], v2_1: uint8, v3: std_io_error) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    v4: str = method19(v0_1)
    v5: str | None = method90(v0_1)
    v19_1: US5 = default_arg(map(method5(), v5), US5(1))
    v23_1: str = method85(v3)
    if v2_1 >= uint8(11):
        return FSharpResult_2(1, ((((((("file_system.read_link / path: " + v0_1) + " / n: ") + str(v2_1)) + " / path\': ") + v0_1) + " / name: ") + v4) + "")

    elif v19_1.tag == 0:
        if v0_1 != "":
            v71: FSharpResult_2[std_path_path_buf, std_io_error] = v1_1(v2_1 + uint8(1), v19_1.fields[0])
            v72: Callable[[std_io_error], str] = method84()
            v84: FSharpResult_2[std_path_path_buf, str] = FSharpResult_2(1, v72(v71.fields[0])) if (v71.tag == 1) else FSharpResult_2(0, v71.fields[0])
            v87: Callable[[std_path_path_buf], US13] = method86()
            v88: Callable[[str], US13] = method87()
            v89: US13 = v88(v84.fields[0]) if (v84.tag == 1) else v87(v84.fields[0])
            if v89.tag == 0:
                return FSharpResult_2(0, method60(to_string_2(v89.fields[0]), v4))

            else: 
                return FSharpResult_2(1, ((((("file_system.read_link / error\': " + v89.fields[0]) + " / error: ") + v23_1) + " / name: ") + v4) + "")


        else: 
            return FSharpResult_2(1, ((((((("file_system.read_link / run / The file or directory is not a reparse point. / path: " + v0_1) + " / error: ") + v23_1) + " / path\': ") + v0_1) + " / name: ") + v4) + "")


    else: 
        return FSharpResult_2(1, ((((((("file_system.read_link / run / The file or directory is not a reparse point. / path: " + v0_1) + " / error: ") + v23_1) + " / path\': ") + v0_1) + " / name: ") + v4) + "")



def method93(v0_1: str, v1_1: uint8) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    v98: bool = None
    if v98:
        return FSharpResult_2(0, None)

    else: 
        def v196(v: uint8, v0_1: Any=v0_1, v1_1: Any=v1_1) -> Callable[[str], FSharpResult_2[std_path_path_buf, std_io_error]]:
            return closure51(v0_1, v)

        return method96(v0_1, uncurry2(v196), v1_1, ((((((("file_system.read_link / Fsharp / The file or directory is not a reparse point. / path: " + v0_1) + " / result: ") + str(v98)) + " / path\': ") + v0_1) + " / n: ") + str(v1_1)) + "")



def method82(v0_1: str) -> FSharpResult_2[std_path_path_buf, std_io_error]:
    return FSharpResult_2()


def closure53(unit_var: None, v0_1: std_path_path_buf) -> US14:
    return US14(0, v0_1)


def method97(__unit: None=None) -> Callable[[std_path_path_buf], US14]:
    def _arrow386(v: std_path_path_buf) -> US14:
        return closure53(None, v)

    return _arrow386


def method99(v0_1: str) -> str:
    return v0_1


def method98(v0_1: str, v1_1: str, v2_1: str) -> str:
    return None


def method81(v0_1: str) -> str:
    if v0_1 == "":
        return ""

    else: 
        v3: FSharpResult_2[std_path_path_buf, std_io_error] = method82(v0_1)
        v12: std_path_path_buf | None = None if (v3.tag == 1) else v3.fields[0]
        v31_1: US14 = default_arg(map(method97(), v12), US14(1))
        v66: str
        if v31_1.tag == 0:
            v60: str = to_string_2(v31_1.fields[0])
            v66 = v0_1 if (v60 == "") else v60

        else: 
            v66 = v0_1

        if v66 == "":
            return ""

        else: 
            v71: str = method98("^\\\\\\\\\\?\\\\", "", v66)
            def _arrow387(__unit: None=None, v0_1: Any=v0_1) -> str:
                _arg: str = v71[0]
                return _arg.lower()

            return replace(concat(_arrow387(), *v71[1:len(v71)]), "\\", "/")




def closure45(unit_var: None, v0_1: str) -> str:
    return method81(v0_1)


def closure54(unit_var: None, v0_1: str) -> str:
    return concat("file:///", *trim_start(v0_1, *to_array(singleton_1("/"))))


def closure56(unit_var: None, v0_1: str) -> str | None:
    return method90(v0_1)


def method101(__unit: None=None) -> Callable[[str], str | None]:
    def _arrow388(v: str) -> str | None:
        return closure56(None, v)

    return _arrow388


def method102(v0_1_mut: str, v1_1_mut: str, v2_1_mut: str) -> US15:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if method9(method60(v2_1, v0_1)):
            return US15(0, v2_1)

        else: 
            v7: str | None = method101()(v2_1)
            v21_1: US5 = default_arg(map(method5(), v7), US5(1))
            if v21_1.tag == 0:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v21_1.fields[0]
                continue

            else: 
                return US15(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v2_1) + "\')")


        break


def method100(v0_1: str, v1_1: str) -> US15:
    if method9(method60(v1_1, v0_1)):
        return US15(0, v1_1)

    else: 
        v6: str | None = method101()(v1_1)
        v20_1: US5 = default_arg(map(method5(), v6), US5(1))
        if v20_1.tag == 0:
            return method102(v0_1, v1_1, v20_1.fields[0])

        else: 
            return US15(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v1_1) + "\')")




def method104(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method17())
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


def method103(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str) -> str:
    v9: str = method104(v8)
    return method22(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "file_system.get_workspace_root") + " / ") + v9) + "")


def closure57(v0_1: str, unit_var: None) -> None:
    if method10(US0(3)):
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
        method23(method103(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1, method11(v19_1, v20_1, v21_1, v22_1, v23_1, v24_1), method32(), v0_1))



def method105(__unit: None=None) -> str:
    return None


def closure55(unit_var: None, unit_var_1: None) -> str:
    v4: US15 = method100(method60("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral")
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
        v55: str = method105()
        v57: US15 = method100(method60("polyglot", ".devcontainer"), v55)
        if v57.tag == 0:
            v107 = US5(0, v57.fields[0])

        else: 
            v63: None
            closure57(v57.fields[0], None)
            v63 = None
            v107 = US5(1)


    def _arrow389(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
        raise Exception("Option does not have a value.")

    return method60(v107.fields[0] if (v107.tag == 0) else _arrow389(), "polyglot")


def method106(v0_1: str) -> None:
    pass


def closure59(unit_var: None, v0_1: str) -> None:
    method106(v0_1)


def closure58(unit_var: None, v0_1: bool) -> None:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_10(TraceState_trace_state())
    def _arrow390(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure59(None, v)

    def _arrow391(v_1: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure2(None, v_1)

    v37: Callable[[str], None] = _arrow390 if v0_1 else _arrow391
    pattern_input[1].l0 = v37


def method107(v0_1: str, v1_1: str) -> None:
    if method9(v0_1) == False:
        v4: IDisposable = method65(v0_1)

    v7: str = default_arg(method90(v1_1), "")
    if method9(v7) == False:
        v12: IDisposable = method65(v7)

    def _arrow392(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> bool:
        v14: FSharpResult_2[std_path_path_buf, std_io_error] = method82(v1_1)
        return True

    if _arrow392() if method9(v1_1) else False:
        method7(True, v1_1)

    if method9(v1_1) == False:
        pass



def closure61(v0_1: str, v1_1: str) -> None:
    method107(v0_1, v1_1)


def closure60(unit_var: None, v0_1: str) -> Callable[[str], None]:
    def _arrow393(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure61(v0_1, v)

    return _arrow393


def closure63(v0_1: str, v1_1: str) -> str:
    return method60(v0_1, v1_1)


def closure62(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow394(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure63(v0_1, v)

    return _arrow394


v0: None = None

def _arrow395(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow395

def _expr396():
    v1(None)
    return v0


v2: None = _expr396()

def _arrow397(v: str) -> Async[int64]:
    return closure3(None, v)


v16: Callable[[str], Async[int64]] = _arrow397

def delete_directory_async(x: str) -> Async[int64]:
    return v16(x)


def _arrow398(v: US6) -> Callable[[str], Async[int64]]:
    return closure10(None, v)


v17: Callable[[US6, str], Async[int64]] = _arrow398

def wait_for_file_access(x: US6) -> Callable[[str], Async[int64]]:
    return v17(x)


def _arrow399(v: str) -> Async[int64]:
    return closure13(None, v)


v18: Callable[[str], Async[int64]] = _arrow399

def wait_for_file_access_read(x: str) -> Async[int64]:
    return v18(x)


def _arrow400(v: str) -> Async[str]:
    return closure14(None, v)


v19: Callable[[str], Async[str]] = _arrow400

def read_all_text_async(x: str) -> Async[str]:
    return v19(x)


def _arrow401(v: str) -> Callable[[str], bool]:
    return closure15(None, v)


v20: Callable[[str, str], bool] = _arrow401

def file_exists_content(x: str) -> Callable[[str], bool]:
    return v20(x)


def _arrow402(v: str) -> Callable[[str], Async[None]]:
    return closure17(None, v)


v21: Callable[[str, str], Async[None]] = _arrow402

def write_all_text_async(x: str) -> Callable[[str], Async[None]]:
    return v21(x)


def _arrow403(v: str) -> Callable[[str], Async[None]]:
    return closure19(None, v)


v22: Callable[[str, str], Async[None]] = _arrow403

def write_all_text_exists(x: str) -> Callable[[str], Async[None]]:
    return v22(x)


def _arrow404(v: str) -> Async[int64]:
    return closure21(None, v)


v23: Callable[[str], Async[int64]] = _arrow404

def delete_file_async(x: str) -> Async[int64]:
    return v23(x)


def _arrow405(v: str) -> Callable[[str], Async[int64]]:
    return closure23(None, v)


v24: Callable[[str, str], Async[int64]] = _arrow405

def move_file_async(x: str) -> Callable[[str], Async[int64]]:
    return v24(x)


def _arrow406(v: str) -> Async[str | None]:
    return closure26(None, v)


v25: Callable[[str], Async[str | None]] = _arrow406

def read_all_text_retry_async(x: str) -> Async[str | None]:
    return v25(x)


def _arrow407(__unit: None=None) -> str:
    return closure32(None, None)


v26: Callable[[], str] = _arrow407

def create_temp_path(__unit: None=None) -> str:
    return v26(None)


def _arrow408(__unit: None=None) -> tuple[str, IDisposable]:
    return closure34(None, None)


v27: Callable[[], tuple[str, IDisposable]] = _arrow408

def create_temp_dir(__unit: None=None) -> tuple[str, IDisposable]:
    return v27(None)


def _arrow409(v: str) -> tuple[str, IDisposable]:
    return closure43(None, v)


v28: Callable[[str], tuple[str, IDisposable]] = _arrow409

def create_temp_dir_0027(x: str) -> tuple[str, IDisposable]:
    return v28(x)


def _arrow410(__unit: None=None) -> str:
    return closure44(None, None)


v29: Callable[[], str] = _arrow410

def get_source_directory(__unit: None=None) -> str:
    return v29(None)


def _arrow411(v: str) -> str:
    return closure45(None, v)


v30: Callable[[str], str] = _arrow411

def normalize_path(x: str) -> str:
    return v30(x)


def _arrow412(v: str) -> str:
    return closure54(None, v)


v31: Callable[[str], str] = _arrow412

def new_file_uri(x: str) -> str:
    return v31(x)


def _arrow413(__unit: None=None) -> str:
    return closure55(None, None)


v32: Callable[[], str] = _arrow413

def get_workspace_root(__unit: None=None) -> str:
    return v32(None)


def _arrow414(v: bool) -> None:
    closure58(None, v)


v33: Callable[[bool], None] = _arrow414

def init_trace_file(x: bool) -> None:
    v33(x)


def _arrow415(v: str) -> Callable[[str], None]:
    return closure60(None, v)


v34: Callable[[str, str], None] = _arrow415

def link_directory(x: str) -> Callable[[str], None]:
    return v34(x)


def _arrow416(v: str) -> Callable[[str], str]:
    return closure62(None, v)


v35: Callable[[str, str], str] = _arrow416

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v35(x)


