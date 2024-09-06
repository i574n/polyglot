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
from fable_modules.fable_library.long import (op_addition, op_subtraction)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_3, default_arg)
from fable_modules.fable_library.reflection import (TypeInfo, class_type, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type)
from fable_modules.fable_library.string_ import (to_text, interpolate, split, pad_left, trim_end, trim_start, replace)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds, to_string as to_string_1)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef, uint8)
from fable_modules.fable_library.util import (create_atom, IDisposable, ignore, to_enumerable, compare)

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


def _expr277() -> TypeInfo:
    return class_type("File_system.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr277

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


class IPathDirname(Protocol):
    @abstractmethod
    def dirname(self, path: str) -> str:
        ...


def _expr278() -> TypeInfo:
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


US0_reflection = _expr278

def _expr279() -> TypeInfo:
    return record_type("File_system.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr279

def _expr280() -> TypeInfo:
    return record_type("File_system.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr280

def _expr281() -> TypeInfo:
    return record_type("File_system.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr281

def _expr282() -> TypeInfo:
    return record_type("File_system.Mut3", [], Mut3, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: US0

Mut3_reflection = _expr282

def _expr283() -> TypeInfo:
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


US1_reflection = _expr283

def _expr284() -> TypeInfo:
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


US2_reflection = _expr284

def _expr285() -> TypeInfo:
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


US3_reflection = _expr285

def _expr286() -> TypeInfo:
    return record_type("File_system.Mut4", [], Mut4, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: str

Mut4_reflection = _expr286

def _expr287() -> TypeInfo:
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


US4_reflection = _expr287

def _expr288() -> TypeInfo:
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


US5_reflection = _expr288

def _expr289() -> TypeInfo:
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


US7_reflection = _expr289

def _expr290() -> TypeInfo:
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


US8_reflection = _expr290

def _expr291() -> TypeInfo:
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


US6_reflection = _expr291

def _expr292() -> TypeInfo:
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


US9_reflection = _expr292

def _expr293() -> TypeInfo:
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


US10_reflection = _expr293

def _expr294() -> TypeInfo:
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


US11_reflection = _expr294

def _expr295() -> TypeInfo:
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


US12_reflection = _expr295

def _expr296() -> TypeInfo:
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


US13_reflection = _expr296

def method1(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method3(__unit: None=None) -> str:
    return ""


def closure1(v0_1: FSharpRef[US1 | None], v1_1: US1 | None=None) -> FSharpRef[US1 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure2(v0_1: str | None, v1_1: Callable[[US1 | None], FSharpRef[US1 | None]], unit_var: None) -> None:
    def _arrow297(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US1 | None:
        x: str = v0_1
        def x_1(__unit: None=None) -> US1:
            return US1(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow297()))


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
    v69: None
    def v66(v: US1 | None=None, v0_1: Any=v0_1) -> FSharpRef[US1 | None]:
        return closure1(_v64, v)

    closure2(v61, v66, None)
    v69 = None
    v84: US1 = default_arg(_v64.contents, US1(1))
    if v84.tag == 0:
        return v84.fields[0]

    else: 
        return ""



def method4(__unit: None=None) -> str:
    return "AUTOMATION"


def closure3(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
    v173: str = method2(method1())
    v178: US2 = US2(0, US0(0)) if ("Verbose" == v173) else US2(1)
    def _arrow298(__unit: None=None, v0_1: Any=v0_1) -> US2:
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




    _v1: tuple[US2, US3] = (US2(0, v178.fields[0]) if (v178.tag == 0) else _arrow298(), US3(0, ticks_1(now())) if (method2(method4()) == "True") else US3(1))
    v295: US3 = _v1[1]
    v294: US2 = _v1[0]
    def v365(v: str, v0_1: Any=v0_1) -> None:
        closure3(None, v)

    return (Mut0(int64(0)), Mut1(v365), Mut2(True), Mut3(v294.fields[0] if (v294.tag == 0) else v0_1), v295.fields[0] if (v295.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if State_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
        State_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4]))



def method7(v0_1: str) -> str:
    return v0_1


def method8(v0_1: str) -> bool:
    return None


def method6(v0_1: bool, v1_1: str) -> None:
    pass


def closure6(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure7(v0_1: FSharpRef[US3 | None], v1_1: US3 | None=None) -> FSharpRef[US3 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure8(v0_1: int64 | None, v1_1: Callable[[US3 | None], FSharpRef[US3 | None]], unit_var: None) -> None:
    def _arrow299(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US3 | None:
        x: int64 = v0_1
        def x_1(__unit: None=None) -> US3:
            return US3(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow299()))


def method9(__unit: None=None) -> str:
    return "hh:mm:ss"


def method10(__unit: None=None) -> str:
    return "HH:mm:ss"


def method11(__unit: None=None) -> str:
    return "("


def method12(__unit: None=None) -> str:
    return " "


def method13(__unit: None=None) -> str:
    return ""


def closure9(v0_1: Mut4, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def method14(__unit: None=None) -> str:
    return "\u001b[0m"


def method15(v0_1: str) -> str:
    raise Exception(((("file_system.get_file_name / target: " + str(US5(4, US4(0)))) + " / path: ") + v0_1) + "")


def closure10(unit_var: None, unit_var_1: None) -> str:
    return "file_system.delete_directory_async"


def closure12(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure11(unit_var: None, v0_1: str) -> None:
    v3: None
    closure12(v0_1, None)
    v3 = None


def closure5(v0_1: str, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v33_1: None
    v3(None)
    v33_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v61: US0 = pattern_input_1[3].l0
    class ObjectExpr300:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr300()))):
        v69: None
        closure6(pattern_input[0], None)
        v69 = None
        v73: None
        v3(None)
        v73 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v348: FSharpRef[US3 | None] = FSharpRef(None)
        v353: None
        def v350(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v348, v)

        closure8(pattern_input_2[4], v350, None)
        v353 = None
        v368: US3 = default_arg(_v348.contents, US3(1))
        def _arrow301(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v382: Any = create(op_subtraction(ticks_1(now()), v368.fields[0]))
            return create_1(1, 1, 1, hours(v382), minutes(v382), seconds(v382), milliseconds(v382))

        v413: str = to_string(_arrow301() if (v368.tag == 0) else now(), method10())
        v559: str = method12()
        v567: Mut4 = Mut4(method13())
        v578: None
        closure9(v567, ("" + to_text(interpolate("%A%P()", [US0(0)]))) + "", None)
        v578 = None
        v582: Array[str] = split(v567.l0, [v559], None, 0)
        v585: str = v582[0]
        v589: Mut4 = Mut4(method13())
        v600: None
        closure9(v589, ("" + to_text(interpolate("%A%P()", [US0(1)]))) + "", None)
        v600 = None
        v603: str = v589.l0
        v610: US1 = US1(0, "Verbose") if (v603.find(v585) == 0) else US1(1)
        v616: US1 = US1(0, v610.fields[0]) if (v610.tag == 0) else US1(0, "Debug")
        v620: str
        if v616.tag == 0:
            v620 = v616.fields[0]

        else: 
            raise Exception("Option does not have a value.")

        v680: str = ("\u001b[94m" + pad_left(v620.lower(), 7, " ")) + method14()
        v691: int64 = pattern_input_2[0].l0
        v692: str = method15(v0_1)
        v694: Mut4 = Mut4(method13())
        v701: None
        closure9(v694, ("" + "{ ") + "", None)
        v701 = None
        v710: None
        closure9(v694, ("" + "ex") + "", None)
        v710 = None
        v719: None
        closure9(v694, ("" + " = ") + "", None)
        v719 = None
        v727: None
        closure9(v694, ("" + v1_1) + "", None)
        v727 = None
        v736: None
        closure9(v694, ("" + "; ") + "", None)
        v736 = None
        v745: None
        closure9(v694, ("" + "path") + "", None)
        v745 = None
        v753: None
        closure9(v694, ("" + " = ") + "", None)
        v753 = None
        v761: None
        closure9(v694, ("" + v692) + "", None)
        v761 = None
        v770: None
        closure9(v694, ("" + " }") + "", None)
        v770 = None
        v773: str = v694.l0
        v812: str = trim_end(trim_start(((((((((("" + v413) + " ") + v680) + " #") + str(v691)) + " ") + closure10(None, None)) + " / ") + v773) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v812)
        pattern_input[1].l0(v812)



def method5(v0_1: str, v1_1: int64) -> Async[int64]:
    return None


def closure4(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def closure16(unit_var: None, unit_var_1: None) -> str:
    return "file_system.wait_for_file_access"


def closure15(v0_1: str, v1_1: int64, v2_1: str, unit_var: None) -> None:
    def v4(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v5: None
    v4(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v34: None
    v4(None)
    v34 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v62: US0 = pattern_input_1[3].l0
    class ObjectExpr302:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v62, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr302()))):
        v70: None
        closure6(pattern_input[0], None)
        v70 = None
        v74: None
        v4(None)
        v74 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v349: FSharpRef[US3 | None] = FSharpRef(None)
        v354: None
        def v351(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v349, v)

        closure8(pattern_input_2[4], v351, None)
        v354 = None
        v369: US3 = default_arg(_v349.contents, US3(1))
        def _arrow303(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v383: Any = create(op_subtraction(ticks_1(now()), v369.fields[0]))
            return create_1(1, 1, 1, hours(v383), minutes(v383), seconds(v383), milliseconds(v383))

        v414: str = to_string(_arrow303() if (v369.tag == 0) else now(), method10())
        v560: str = method12()
        v568: Mut4 = Mut4(method13())
        v579: None
        closure9(v568, ("" + to_text(interpolate("%A%P()", [US0(0)]))) + "", None)
        v579 = None
        v583: Array[str] = split(v568.l0, [v560], None, 0)
        v586: str = v583[0]
        v590: Mut4 = Mut4(method13())
        v601: None
        closure9(v590, ("" + to_text(interpolate("%A%P()", [US0(1)]))) + "", None)
        v601 = None
        v604: str = v590.l0
        v611: US1 = US1(0, "Verbose") if (v604.find(v586) == 0) else US1(1)
        v617: US1 = US1(0, v611.fields[0]) if (v611.tag == 0) else US1(0, "Debug")
        v621: str
        if v617.tag == 0:
            v621 = v617.fields[0]

        else: 
            raise Exception("Option does not have a value.")

        v681: str = ("\u001b[94m" + pad_left(v621.lower(), 7, " ")) + method14()
        v692: int64 = pattern_input_2[0].l0
        v693: str = method15(v0_1)
        v695: Mut4 = Mut4(method13())
        v702: None
        closure9(v695, ("" + "{ ") + "", None)
        v702 = None
        v711: None
        closure9(v695, ("" + "path") + "", None)
        v711 = None
        v720: None
        closure9(v695, ("" + " = ") + "", None)
        v720 = None
        v728: None
        closure9(v695, ("" + v693) + "", None)
        v728 = None
        v737: None
        closure9(v695, ("" + "; ") + "", None)
        v737 = None
        v746: None
        closure9(v695, ("" + "retry") + "", None)
        v746 = None
        v754: None
        closure9(v695, ("" + " = ") + "", None)
        v754 = None
        v762: None
        closure9(v695, ("" + str(v1_1)) + "", None)
        v762 = None
        v770: None
        closure9(v695, ("" + "; ") + "", None)
        v770 = None
        v779: None
        closure9(v695, ("" + "ex") + "", None)
        v779 = None
        v787: None
        closure9(v695, ("" + " = ") + "", None)
        v787 = None
        v795: None
        closure9(v695, ("" + v2_1) + "", None)
        v795 = None
        v804: None
        closure9(v695, ("" + " }") + "", None)
        v804 = None
        v807: str = v695.l0
        v846: str = trim_end(trim_start(((((((((("" + v414) + " ") + v681) + " #") + str(v692)) + " ") + closure16(None, None)) + " / ") + v807) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v846)
        pattern_input[1].l0(v846)



def method16(v0_1: str, v1_1: US8, v2_1: US7, v3: int64) -> Async[int64]:
    return None


def closure14(v0_1: US6, v1_1: str) -> Async[int64]:
    return None


def closure13(unit_var: None, v0_1: US6) -> Callable[[str], Async[int64]]:
    def _arrow304(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure14(v0_1, v)

    return _arrow304


def method17(v0_1: str, v1_1: int64) -> Async[int64]:
    return None


def closure17(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def closure18(unit_var: None, v0_1: str) -> Async[str]:
    return None


def method19(v0_1: str) -> bool:
    return None


def method20(v0_1: Vec_1[uint8]) -> Vec_1[uint8]:
    return v0_1


def method18(v0_1: str, v1_1: str) -> bool:
    return None


def closure20(v0_1: str, v1_1: str) -> bool:
    return method18(v0_1, v1_1)


def closure19(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow305(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure20(v0_1, v)

    return _arrow305


def closure22(v0_1: str, v1_1: str) -> Async[None]:
    return None


def closure21(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow306(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure22(v0_1, v)

    return _arrow306


def closure24(v0_1: str, v1_1: str) -> Async[None]:
    return None


def closure23(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow307(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure24(v0_1, v)

    return _arrow307


def closure27(unit_var: None, unit_var_1: None) -> str:
    return "delete_file_async"


def closure26(v0_1: str, v1_1: Exception, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v33_1: None
    v3(None)
    v33_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v61: US0 = pattern_input_1[3].l0
    class ObjectExpr308:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr308()))):
        v69: None
        closure6(pattern_input[0], None)
        v69 = None
        v73: None
        v3(None)
        v73 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v348: FSharpRef[US3 | None] = FSharpRef(None)
        v353: None
        def v350(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v348, v)

        closure8(pattern_input_2[4], v350, None)
        v353 = None
        v368: US3 = default_arg(_v348.contents, US3(1))
        def _arrow309(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v382: Any = create(op_subtraction(ticks_1(now()), v368.fields[0]))
            return create_1(1, 1, 1, hours(v382), minutes(v382), seconds(v382), milliseconds(v382))

        v413: str = to_string(_arrow309() if (v368.tag == 0) else now(), method10())
        v559: str = method12()
        v567: Mut4 = Mut4(method13())
        v578: None
        closure9(v567, ("" + to_text(interpolate("%A%P()", [US0(0)]))) + "", None)
        v578 = None
        v582: Array[str] = split(v567.l0, [v559], None, 0)
        v585: str = v582[0]
        v589: Mut4 = Mut4(method13())
        v600: None
        closure9(v589, ("" + to_text(interpolate("%A%P()", [US0(3)]))) + "", None)
        v600 = None
        v603: str = v589.l0
        v610: US1 = US1(0, "Verbose") if (v603.find(v585) == 0) else US1(1)
        v738: US1
        if v610.tag == 0:
            v738 = US1(0, v610.fields[0])

        else: 
            v618: str = method12()
            v626: Mut4 = Mut4(method13())
            v637: None
            closure9(v626, ("" + to_text(interpolate("%A%P()", [US0(1)]))) + "", None)
            v637 = None
            v641: Array[str] = split(v626.l0, [v618], None, 0)
            v644: str = v641[0]
            v648: Mut4 = Mut4(method13())
            v659: None
            closure9(v648, ("" + to_text(interpolate("%A%P()", [US0(3)]))) + "", None)
            v659 = None
            v662: str = v648.l0
            v669: US1 = US1(0, "Debug") if (v662.find(v644) == 0) else US1(1)
            if v669.tag == 0:
                v738 = US1(0, v669.fields[0])

            else: 
                v677: str = method12()
                v685: Mut4 = Mut4(method13())
                v696: None
                closure9(v685, ("" + to_text(interpolate("%A%P()", [US0(2)]))) + "", None)
                v696 = None
                v700: Array[str] = split(v685.l0, [v677], None, 0)
                v703: str = v700[0]
                v707: Mut4 = Mut4(method13())
                v718: None
                closure9(v707, ("" + to_text(interpolate("%A%P()", [US0(3)]))) + "", None)
                v718 = None
                v721: str = v707.l0
                v728: US1 = US1(0, "Info") if (v721.find(v703) == 0) else US1(1)
                v738 = US1(0, v728.fields[0]) if (v728.tag == 0) else US1(0, "Warning")


        v742: str
        if v738.tag == 0:
            v742 = v738.fields[0]

        else: 
            raise Exception("Option does not have a value.")

        v802: str = ("\u001b[93m" + pad_left(v742.lower(), 7, " ")) + method14()
        v813: int64 = pattern_input_2[0].l0
        v814: str = method15(v0_1)
        v828: str = to_text(interpolate("%A%P()", [v1_1]))
        v838: Mut4 = Mut4(method13())
        v845: None
        closure9(v838, ("" + "{ ") + "", None)
        v845 = None
        v854: None
        closure9(v838, ("" + "path") + "", None)
        v854 = None
        v863: None
        closure9(v838, ("" + " = ") + "", None)
        v863 = None
        v871: None
        closure9(v838, ("" + v814) + "", None)
        v871 = None
        v880: None
        closure9(v838, ("" + "; ") + "", None)
        v880 = None
        v889: None
        closure9(v838, ("" + "ex") + "", None)
        v889 = None
        v897: None
        closure9(v838, ("" + " = ") + "", None)
        v897 = None
        v905: None
        closure9(v838, ("" + v828) + "", None)
        v905 = None
        v914: None
        closure9(v838, ("" + " }") + "", None)
        v914 = None
        v917: str = v838.l0
        v956: str = trim_end(trim_start(((((((((("" + v413) + " ") + v802) + " #") + str(v813)) + " ") + closure27(None, None)) + " / ") + v917) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v956)
        pattern_input[1].l0(v956)



def method21(v0_1: str, v1_1: int64) -> Async[int64]:
    return None


def closure25(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def closure31(unit_var: None, unit_var_1: None) -> str:
    return "move_file_async"


def closure30(v0_1: str, v1_1: str, v2_1: Exception, unit_var: None) -> None:
    def v4(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v5: None
    v4(None)
    v5 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v34: None
    v4(None)
    v34 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v62: US0 = pattern_input_1[3].l0
    class ObjectExpr310:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v62, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr310()))):
        v70: None
        closure6(pattern_input[0], None)
        v70 = None
        v74: None
        v4(None)
        v74 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v349: FSharpRef[US3 | None] = FSharpRef(None)
        v354: None
        def v351(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v349, v)

        closure8(pattern_input_2[4], v351, None)
        v354 = None
        v369: US3 = default_arg(_v349.contents, US3(1))
        def _arrow311(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v383: Any = create(op_subtraction(ticks_1(now()), v369.fields[0]))
            return create_1(1, 1, 1, hours(v383), minutes(v383), seconds(v383), milliseconds(v383))

        v414: str = to_string(_arrow311() if (v369.tag == 0) else now(), method10())
        v560: str = method12()
        v568: Mut4 = Mut4(method13())
        v579: None
        closure9(v568, ("" + to_text(interpolate("%A%P()", [US0(0)]))) + "", None)
        v579 = None
        v583: Array[str] = split(v568.l0, [v560], None, 0)
        v586: str = v583[0]
        v590: Mut4 = Mut4(method13())
        v601: None
        closure9(v590, ("" + to_text(interpolate("%A%P()", [US0(3)]))) + "", None)
        v601 = None
        v604: str = v590.l0
        v611: US1 = US1(0, "Verbose") if (v604.find(v586) == 0) else US1(1)
        v739: US1
        if v611.tag == 0:
            v739 = US1(0, v611.fields[0])

        else: 
            v619: str = method12()
            v627: Mut4 = Mut4(method13())
            v638: None
            closure9(v627, ("" + to_text(interpolate("%A%P()", [US0(1)]))) + "", None)
            v638 = None
            v642: Array[str] = split(v627.l0, [v619], None, 0)
            v645: str = v642[0]
            v649: Mut4 = Mut4(method13())
            v660: None
            closure9(v649, ("" + to_text(interpolate("%A%P()", [US0(3)]))) + "", None)
            v660 = None
            v663: str = v649.l0
            v670: US1 = US1(0, "Debug") if (v663.find(v645) == 0) else US1(1)
            if v670.tag == 0:
                v739 = US1(0, v670.fields[0])

            else: 
                v678: str = method12()
                v686: Mut4 = Mut4(method13())
                v697: None
                closure9(v686, ("" + to_text(interpolate("%A%P()", [US0(2)]))) + "", None)
                v697 = None
                v701: Array[str] = split(v686.l0, [v678], None, 0)
                v704: str = v701[0]
                v708: Mut4 = Mut4(method13())
                v719: None
                closure9(v708, ("" + to_text(interpolate("%A%P()", [US0(3)]))) + "", None)
                v719 = None
                v722: str = v708.l0
                v729: US1 = US1(0, "Info") if (v722.find(v704) == 0) else US1(1)
                v739 = US1(0, v729.fields[0]) if (v729.tag == 0) else US1(0, "Warning")


        v743: str
        if v739.tag == 0:
            v743 = v739.fields[0]

        else: 
            raise Exception("Option does not have a value.")

        v803: str = ("\u001b[93m" + pad_left(v743.lower(), 7, " ")) + method14()
        v814: int64 = pattern_input_2[0].l0
        v815: str = method15(v1_1)
        v816: str = method15(v0_1)
        v818: Mut4 = Mut4(method13())
        v825: None
        closure9(v818, ("" + "{ ") + "", None)
        v825 = None
        v834: None
        closure9(v818, ("" + "old_path") + "", None)
        v834 = None
        v843: None
        closure9(v818, ("" + " = ") + "", None)
        v843 = None
        v851: None
        closure9(v818, ("" + v815) + "", None)
        v851 = None
        v860: None
        closure9(v818, ("" + "; ") + "", None)
        v860 = None
        v869: None
        closure9(v818, ("" + "new_path") + "", None)
        v869 = None
        v877: None
        closure9(v818, ("" + " = ") + "", None)
        v877 = None
        v885: None
        closure9(v818, ("" + v816) + "", None)
        v885 = None
        v893: None
        closure9(v818, ("" + "; ") + "", None)
        v893 = None
        v902: None
        closure9(v818, ("" + "ex") + "", None)
        v902 = None
        v910: None
        closure9(v818, ("" + " = ") + "", None)
        v910 = None
        v945: None
        closure9(v818, ("" + to_text(interpolate("%A%P()", [v2_1]))) + "", None)
        v945 = None
        v954: None
        closure9(v818, ("" + " }") + "", None)
        v954 = None
        v957: str = v818.l0
        v996: str = trim_end(trim_start(((((((((("" + v414) + " ") + v803) + " #") + str(v814)) + " ") + closure31(None, None)) + " / ") + v957) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v996)
        pattern_input[1].l0(v996)



def method22(v0_1: str, v1_1: str, v2_1: int64) -> Async[int64]:
    return None


def closure29(v0_1: str, v1_1: str) -> Async[int64]:
    return None


def closure28(unit_var: None, v0_1: str) -> Callable[[str], Async[int64]]:
    def _arrow312(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure29(v0_1, v)

    return _arrow312


def closure33(unit_var: None, v0_1: int64) -> US9:
    return US9(0, v0_1)


def closure34(unit_var: None, v0_1: Exception) -> US9:
    return US9(1, v0_1)


def closure36(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async"


def closure35(unit_var: None, unit_var_1: None) -> None:
    def v1_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure0(None, None)

    v2_1: None
    v1_1(None)
    v2_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v31_1: None
    v1_1(None)
    v31_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v59: US0 = pattern_input_1[3].l0
    class ObjectExpr313:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v59, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr313()))):
        v67: None
        closure6(pattern_input[0], None)
        v67 = None
        v71: None
        v1_1(None)
        v71 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v346: FSharpRef[US3 | None] = FSharpRef(None)
        v351: None
        def v348(v: US3 | None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> FSharpRef[US3 | None]:
            return closure7(_v346, v)

        closure8(pattern_input_2[4], v348, None)
        v351 = None
        v366: US3 = default_arg(_v346.contents, US3(1))
        def _arrow314(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> Any:
            v380: Any = create(op_subtraction(ticks_1(now()), v366.fields[0]))
            return create_1(1, 1, 1, hours(v380), minutes(v380), seconds(v380), milliseconds(v380))

        v411: str = to_string(_arrow314() if (v366.tag == 0) else now(), method10())
        v612: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method14()
        v623: int64 = pattern_input_2[0].l0
        v625: Mut4 = Mut4(method13())
        v632: None
        closure9(v625, ("" + "{ ") + "", None)
        v632 = None
        v641: None
        closure9(v625, ("" + "timeout") + "", None)
        v641 = None
        v650: None
        closure9(v625, ("" + " = ") + "", None)
        v650 = None
        v658: None
        closure9(v625, ("" + str(1000)) + "", None)
        v658 = None
        v667: None
        closure9(v625, ("" + " }") + "", None)
        v667 = None
        v670: str = v625.l0
        v709: str = trim_end(trim_start(((((((((("" + v411) + " ") + v612) + " #") + str(v623)) + " ") + closure36(None, None)) + " / ") + v670) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v709)
        pattern_input[1].l0(v709)



def closure38(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async**"


def closure37(v0_1: Exception, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v32_1: None
    v2_1(None)
    v32_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v60: US0 = pattern_input_1[3].l0
    class ObjectExpr315:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (4 >= find(v60, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr315()))):
        v68: None
        closure6(pattern_input[0], None)
        v68 = None
        v72: None
        v2_1(None)
        v72 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v347: FSharpRef[US3 | None] = FSharpRef(None)
        v352: None
        def v349(v: US3 | None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v347, v)

        closure8(pattern_input_2[4], v349, None)
        v352 = None
        v367: US3 = default_arg(_v347.contents, US3(1))
        def _arrow316(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v381: Any = create(op_subtraction(ticks_1(now()), v367.fields[0]))
            return create_1(1, 1, 1, hours(v381), minutes(v381), seconds(v381), milliseconds(v381))

        v412: str = to_string(_arrow316() if (v367.tag == 0) else now(), method10())
        v558: str = method12()
        v566: Mut4 = Mut4(method13())
        v577: None
        closure9(v566, ("" + to_text(interpolate("%A%P()", [US0(0)]))) + "", None)
        v577 = None
        v581: Array[str] = split(v566.l0, [v558], None, 0)
        v584: str = v581[0]
        v588: Mut4 = Mut4(method13())
        v599: None
        closure9(v588, ("" + to_text(interpolate("%A%P()", [US0(4)]))) + "", None)
        v599 = None
        v602: str = v588.l0
        v609: US1 = US1(0, "Verbose") if (v602.find(v584) == 0) else US1(1)
        v798: US1
        if v609.tag == 0:
            v798 = US1(0, v609.fields[0])

        else: 
            v617: str = method12()
            v625: Mut4 = Mut4(method13())
            v636: None
            closure9(v625, ("" + to_text(interpolate("%A%P()", [US0(1)]))) + "", None)
            v636 = None
            v640: Array[str] = split(v625.l0, [v617], None, 0)
            v643: str = v640[0]
            v647: Mut4 = Mut4(method13())
            v658: None
            closure9(v647, ("" + to_text(interpolate("%A%P()", [US0(4)]))) + "", None)
            v658 = None
            v661: str = v647.l0
            v668: US1 = US1(0, "Debug") if (v661.find(v643) == 0) else US1(1)
            if v668.tag == 0:
                v798 = US1(0, v668.fields[0])

            else: 
                v676: str = method12()
                v684: Mut4 = Mut4(method13())
                v695: None
                closure9(v684, ("" + to_text(interpolate("%A%P()", [US0(2)]))) + "", None)
                v695 = None
                v699: Array[str] = split(v684.l0, [v676], None, 0)
                v702: str = v699[0]
                v706: Mut4 = Mut4(method13())
                v717: None
                closure9(v706, ("" + to_text(interpolate("%A%P()", [US0(4)]))) + "", None)
                v717 = None
                v720: str = v706.l0
                v727: US1 = US1(0, "Info") if (v720.find(v702) == 0) else US1(1)
                if v727.tag == 0:
                    v798 = US1(0, v727.fields[0])

                else: 
                    v735: str = method12()
                    v743: Mut4 = Mut4(method13())
                    v754: None
                    closure9(v743, ("" + to_text(interpolate("%A%P()", [US0(3)]))) + "", None)
                    v754 = None
                    v758: Array[str] = split(v743.l0, [v735], None, 0)
                    v761: str = v758[0]
                    v765: Mut4 = Mut4(method13())
                    v776: None
                    closure9(v765, ("" + to_text(interpolate("%A%P()", [US0(4)]))) + "", None)
                    v776 = None
                    v779: str = v765.l0
                    v786: US1 = US1(0, "Warning") if (v779.find(v761) == 0) else US1(1)
                    v798 = US1(0, v786.fields[0]) if (v786.tag == 0) else US1(0, "Critical")



        v802: str
        if v798.tag == 0:
            v802 = v798.fields[0]

        else: 
            raise Exception("Option does not have a value.")

        v862: str = ("\u001b[91m" + pad_left(v802.lower(), 7, " ")) + method14()
        v873: int64 = pattern_input_2[0].l0
        v887: str = to_text(interpolate("%A%P()", [v0_1]))
        v897: Mut4 = Mut4(method13())
        v904: None
        closure9(v897, ("" + "{ ") + "", None)
        v904 = None
        v913: None
        closure9(v897, ("" + "timeout") + "", None)
        v913 = None
        v922: None
        closure9(v897, ("" + " = ") + "", None)
        v922 = None
        v930: None
        closure9(v897, ("" + str(1000)) + "", None)
        v930 = None
        v939: None
        closure9(v897, ("" + "; ") + "", None)
        v939 = None
        v948: None
        closure9(v897, ("" + "ex") + "", None)
        v948 = None
        v956: None
        closure9(v897, ("" + " = ") + "", None)
        v956 = None
        v964: None
        closure9(v897, ("" + v887) + "", None)
        v964 = None
        v973: None
        closure9(v897, ("" + " }") + "", None)
        v973 = None
        v976: str = v897.l0
        v1015: str = trim_end(trim_start(((((((((("" + v412) + " ") + v862) + " #") + str(v873)) + " ") + closure38(None, None)) + " / ") + v976) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v1015)
        pattern_input[1].l0(v1015)



def closure40(unit_var: None, unit_var_1: None) -> str:
    return "read_all_text_retry_async"


def closure39(v0_1: int64, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v33_1: None
    v3(None)
    v33_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v61: US0 = pattern_input_1[3].l0
    class ObjectExpr317:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr317()))):
        v69: None
        closure6(pattern_input[0], None)
        v69 = None
        v73: None
        v3(None)
        v73 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v348: FSharpRef[US3 | None] = FSharpRef(None)
        v353: None
        def v350(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v348, v)

        closure8(pattern_input_2[4], v350, None)
        v353 = None
        v368: US3 = default_arg(_v348.contents, US3(1))
        def _arrow318(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v382: Any = create(op_subtraction(ticks_1(now()), v368.fields[0]))
            return create_1(1, 1, 1, hours(v382), minutes(v382), seconds(v382), milliseconds(v382))

        v413: str = to_string(_arrow318() if (v368.tag == 0) else now(), method10())
        v559: str = method12()
        v567: Mut4 = Mut4(method13())
        v578: None
        closure9(v567, ("" + to_text(interpolate("%A%P()", [US0(0)]))) + "", None)
        v578 = None
        v582: Array[str] = split(v567.l0, [v559], None, 0)
        v585: str = v582[0]
        v589: Mut4 = Mut4(method13())
        v600: None
        closure9(v589, ("" + to_text(interpolate("%A%P()", [US0(1)]))) + "", None)
        v600 = None
        v603: str = v589.l0
        v610: US1 = US1(0, "Verbose") if (v603.find(v585) == 0) else US1(1)
        v616: US1 = US1(0, v610.fields[0]) if (v610.tag == 0) else US1(0, "Debug")
        v620: str
        if v616.tag == 0:
            v620 = v616.fields[0]

        else: 
            raise Exception("Option does not have a value.")

        v680: str = ("\u001b[94m" + pad_left(v620.lower(), 7, " ")) + method14()
        v691: int64 = pattern_input_2[0].l0
        v693: Mut4 = Mut4(method13())
        v700: None
        closure9(v693, ("" + "{ ") + "", None)
        v700 = None
        v709: None
        closure9(v693, ("" + "retry") + "", None)
        v709 = None
        v718: None
        closure9(v693, ("" + " = ") + "", None)
        v718 = None
        v726: None
        closure9(v693, ("" + str(v0_1)) + "", None)
        v726 = None
        v735: None
        closure9(v693, ("" + "; ") + "", None)
        v735 = None
        v744: None
        closure9(v693, ("" + "ex") + "", None)
        v744 = None
        v752: None
        closure9(v693, ("" + " = ") + "", None)
        v752 = None
        v760: None
        closure9(v693, ("" + v1_1) + "", None)
        v760 = None
        v769: None
        closure9(v693, ("" + " }") + "", None)
        v769 = None
        v772: str = v693.l0
        v811: str = trim_end(trim_start(((((((((("" + v413) + " ") + v680) + " #") + str(v691)) + " ") + closure40(None, None)) + " / ") + v772) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v811)
        pattern_input[1].l0(v811)



def method23(v0_1: str, v1_1: int64) -> Async[str | None]:
    return None


def closure32(unit_var: None, v0_1: str) -> Async[str | None]:
    return None


def closure42(v0_1: FSharpRef[US11 | None], v1_1: US11 | None=None) -> FSharpRef[US11 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure43(v0_1: chrono_date_time_1[chrono_utc] | None, v1_1: Callable[[US11 | None], FSharpRef[US11 | None]], unit_var: None) -> None:
    def _arrow319(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US11 | None:
        x: chrono_date_time_1[chrono_utc] = v0_1
        def x_1(__unit: None=None) -> US11:
            return US11(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow319()))


def method26(__unit: None=None) -> str:
    return "hh:mm"


def method27(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method28(__unit: None=None) -> str:
    return "hhmm"


def method25(v0_1: str, v1_1: Any) -> str:
    v438: str = to_string(v1_1, method27())
    v507: Any
    raise Exception(("date_time.get_utc_offset / target: " + str(US5(4, US4(0)))) + "")
    v518: uint8 = uint8(1) if (hours(v507) > 0) else uint8(0)
    v519: str = method28()
    v530: str = ((("" + str(v518)) + "") + to_string_1(v507, "c", {})) + ""
    v532: str = str(v0_1)
    return parse(((((("" + v438) + "") + v530) + "") + v532[len(v438) + len(v530):len(v532)]) + "")


def method30(__unit: None=None) -> str:
    raise Exception(("file_system.get_temp_path / target: " + str(US5(4, US4(0)))) + "")


def method31(__unit: None=None) -> str:
    return "!create_temp_path_"


def method34(v0_1: str) -> str:
    return v0_1


def method33(v0_1: str, v1_1: str) -> tuple[str, str]:
    return (v1_1, method34(v0_1))


def method32(v0_1: str, v1_1: str) -> str:
    raise Exception(((((("file_system.(</>) / target: " + str(US5(4, US4(0)))) + " / a: ") + v0_1) + " / b: ") + v1_1) + "")


def method36(__unit: None=None) -> str:
    return "CARGO_PKG_NAME"


def method35(__unit: None=None) -> str:
    raise Exception(("env.get_entry_assembly_name / target: " + str(US5(4, US4(0)))) + "")


def method29(v0_1: str) -> str:
    return method32(method32(method32(method30(), method31()), method35()), str(v0_1))


def method24(__unit: None=None) -> str:
    v31_1: Any = now()
    return method29(method25(new_guid(), v31_1))


def closure41(unit_var: None, unit_var_1: None) -> str:
    return method24()


def method38(v0_1: str) -> str:
    return v0_1


def closure45(unit_var: None, v0_1: std_io_error) -> std_string_string:
    return None


def method39(__unit: None=None) -> Callable[[std_io_error], std_string_string]:
    def _arrow320(v: std_io_error) -> std_string_string:
        return closure45(None, v)

    return _arrow320


def closure46(unit_var: None, unit_var_1: None) -> US12:
    return US12(0)


def closure47(unit_var: None, v0_1: std_string_string) -> US12:
    return US12(1, v0_1)


def closure49(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_dir"


def closure48(v0_1: str, v1_1: std_string_string, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v33_1: None
    v3(None)
    v33_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v61: US0 = pattern_input_1[3].l0
    class ObjectExpr321:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (4 >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr321()))):
        v69: None
        closure6(pattern_input[0], None)
        v69 = None
        v73: None
        v3(None)
        v73 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v348: FSharpRef[US3 | None] = FSharpRef(None)
        v353: None
        def v350(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v348, v)

        closure8(pattern_input_2[4], v350, None)
        v353 = None
        v368: US3 = default_arg(_v348.contents, US3(1))
        def _arrow322(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v382: Any = create(op_subtraction(ticks_1(now()), v368.fields[0]))
            return create_1(1, 1, 1, hours(v382), minutes(v382), seconds(v382), milliseconds(v382))

        v413: str = to_string(_arrow322() if (v368.tag == 0) else now(), method10())
        v559: str = method12()
        v567: Mut4 = Mut4(method13())
        v578: None
        closure9(v567, ("" + to_text(interpolate("%A%P()", [US0(0)]))) + "", None)
        v578 = None
        v582: Array[str] = split(v567.l0, [v559], None, 0)
        v585: str = v582[0]
        v589: Mut4 = Mut4(method13())
        v600: None
        closure9(v589, ("" + to_text(interpolate("%A%P()", [US0(4)]))) + "", None)
        v600 = None
        v603: str = v589.l0
        v610: US1 = US1(0, "Verbose") if (v603.find(v585) == 0) else US1(1)
        v799: US1
        if v610.tag == 0:
            v799 = US1(0, v610.fields[0])

        else: 
            v618: str = method12()
            v626: Mut4 = Mut4(method13())
            v637: None
            closure9(v626, ("" + to_text(interpolate("%A%P()", [US0(1)]))) + "", None)
            v637 = None
            v641: Array[str] = split(v626.l0, [v618], None, 0)
            v644: str = v641[0]
            v648: Mut4 = Mut4(method13())
            v659: None
            closure9(v648, ("" + to_text(interpolate("%A%P()", [US0(4)]))) + "", None)
            v659 = None
            v662: str = v648.l0
            v669: US1 = US1(0, "Debug") if (v662.find(v644) == 0) else US1(1)
            if v669.tag == 0:
                v799 = US1(0, v669.fields[0])

            else: 
                v677: str = method12()
                v685: Mut4 = Mut4(method13())
                v696: None
                closure9(v685, ("" + to_text(interpolate("%A%P()", [US0(2)]))) + "", None)
                v696 = None
                v700: Array[str] = split(v685.l0, [v677], None, 0)
                v703: str = v700[0]
                v707: Mut4 = Mut4(method13())
                v718: None
                closure9(v707, ("" + to_text(interpolate("%A%P()", [US0(4)]))) + "", None)
                v718 = None
                v721: str = v707.l0
                v728: US1 = US1(0, "Info") if (v721.find(v703) == 0) else US1(1)
                if v728.tag == 0:
                    v799 = US1(0, v728.fields[0])

                else: 
                    v736: str = method12()
                    v744: Mut4 = Mut4(method13())
                    v755: None
                    closure9(v744, ("" + to_text(interpolate("%A%P()", [US0(3)]))) + "", None)
                    v755 = None
                    v759: Array[str] = split(v744.l0, [v736], None, 0)
                    v762: str = v759[0]
                    v766: Mut4 = Mut4(method13())
                    v777: None
                    closure9(v766, ("" + to_text(interpolate("%A%P()", [US0(4)]))) + "", None)
                    v777 = None
                    v780: str = v766.l0
                    v787: US1 = US1(0, "Warning") if (v780.find(v762) == 0) else US1(1)
                    v799 = US1(0, v787.fields[0]) if (v787.tag == 0) else US1(0, "Critical")



        v803: str
        if v799.tag == 0:
            v803 = v799.fields[0]

        else: 
            raise Exception("Option does not have a value.")

        v863: str = ("\u001b[91m" + pad_left(v803.lower(), 7, " ")) + method14()
        v874: int64 = pattern_input_2[0].l0
        v876: Mut4 = Mut4(method13())
        v883: None
        closure9(v876, ("" + "{ ") + "", None)
        v883 = None
        v892: None
        closure9(v876, ("" + "dir") + "", None)
        v892 = None
        v901: None
        closure9(v876, ("" + " = ") + "", None)
        v901 = None
        v909: None
        closure9(v876, ("" + v0_1) + "", None)
        v909 = None
        v918: None
        closure9(v876, ("" + "; ") + "", None)
        v918 = None
        v927: None
        closure9(v876, ("" + "error") + "", None)
        v927 = None
        v935: None
        closure9(v876, ("" + " = ") + "", None)
        v935 = None
        v970: None
        closure9(v876, ("" + to_text(interpolate("%A%P()", [v1_1]))) + "", None)
        v970 = None
        v979: None
        closure9(v876, ("" + " }") + "", None)
        v979 = None
        v982: str = v876.l0
        v1021: str = trim_end(trim_start(((((((((("" + v413) + " ") + v863) + " #") + str(v874)) + " ") + closure49(None, None)) + " / ") + v982) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v1021)
        pattern_input[1].l0(v1021)



def closure51(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_dir"


def closure50(v0_1: str, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v32_1: None
    v2_1(None)
    v32_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v60: US0 = pattern_input_1[3].l0
    class ObjectExpr323:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v60, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr323()))):
        v68: None
        closure6(pattern_input[0], None)
        v68 = None
        v72: None
        v2_1(None)
        v72 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v347: FSharpRef[US3 | None] = FSharpRef(None)
        v352: None
        def v349(v: US3 | None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v347, v)

        closure8(pattern_input_2[4], v349, None)
        v352 = None
        v367: US3 = default_arg(_v347.contents, US3(1))
        def _arrow324(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v381: Any = create(op_subtraction(ticks_1(now()), v367.fields[0]))
            return create_1(1, 1, 1, hours(v381), minutes(v381), seconds(v381), milliseconds(v381))

        v412: str = to_string(_arrow324() if (v367.tag == 0) else now(), method10())
        v613: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method14()
        v624: int64 = pattern_input_2[0].l0
        v626: Mut4 = Mut4(method13())
        v633: None
        closure9(v626, ("" + "{ ") + "", None)
        v633 = None
        v642: None
        closure9(v626, ("" + "dir") + "", None)
        v642 = None
        v651: None
        closure9(v626, ("" + " = ") + "", None)
        v651 = None
        v659: None
        closure9(v626, ("" + v0_1) + "", None)
        v659 = None
        v668: None
        closure9(v626, ("" + " }") + "", None)
        v668 = None
        v671: str = v626.l0
        v710: str = trim_end(trim_start(((((((((("" + v412) + " ") + v613) + " #") + str(v624)) + " ") + closure51(None, None)) + " / ") + v671) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v710)
        pattern_input[1].l0(v710)



def closure52(v0_1: str, unit_var: None) -> None:
    method6(True, v0_1)


def method40(v0_1: str) -> Callable[[], None]:
    def _arrow325(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure52(v0_1, None)

    return _arrow325


def method41(v0_1: str) -> Callable[[], None]:
    def _arrow326(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure52(v0_1, None)

    return _arrow326


def closure54(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_dir"


def closure53(v0_1: str, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v33_1: None
    v3(None)
    v33_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v61: US0 = pattern_input_1[3].l0
    class ObjectExpr327:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr327()))):
        v69: None
        closure6(pattern_input[0], None)
        v69 = None
        v73: None
        v3(None)
        v73 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v348: FSharpRef[US3 | None] = FSharpRef(None)
        v353: None
        def v350(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v348, v)

        closure8(pattern_input_2[4], v350, None)
        v353 = None
        v368: US3 = default_arg(_v348.contents, US3(1))
        def _arrow328(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v382: Any = create(op_subtraction(ticks_1(now()), v368.fields[0]))
            return create_1(1, 1, 1, hours(v382), minutes(v382), seconds(v382), milliseconds(v382))

        v413: str = to_string(_arrow328() if (v368.tag == 0) else now(), method10())
        v559: str = method12()
        v567: Mut4 = Mut4(method13())
        v578: None
        closure9(v567, ("" + to_text(interpolate("%A%P()", [US0(0)]))) + "", None)
        v578 = None
        v582: Array[str] = split(v567.l0, [v559], None, 0)
        v585: str = v582[0]
        v589: Mut4 = Mut4(method13())
        v600: None
        closure9(v589, ("" + to_text(interpolate("%A%P()", [US0(1)]))) + "", None)
        v600 = None
        v603: str = v589.l0
        v610: US1 = US1(0, "Verbose") if (v603.find(v585) == 0) else US1(1)
        v616: US1 = US1(0, v610.fields[0]) if (v610.tag == 0) else US1(0, "Debug")
        v620: str
        if v616.tag == 0:
            v620 = v616.fields[0]

        else: 
            raise Exception("Option does not have a value.")

        v680: str = ("\u001b[94m" + pad_left(v620.lower(), 7, " ")) + method14()
        v691: int64 = pattern_input_2[0].l0
        v693: Mut4 = Mut4(method13())
        v700: None
        closure9(v693, ("" + "{ ") + "", None)
        v700 = None
        v709: None
        closure9(v693, ("" + "dir") + "", None)
        v709 = None
        v718: None
        closure9(v693, ("" + " = ") + "", None)
        v718 = None
        v726: None
        closure9(v693, ("" + v0_1) + "", None)
        v726 = None
        v735: None
        closure9(v693, ("" + "; ") + "", None)
        v735 = None
        v744: None
        closure9(v693, ("" + "result") + "", None)
        v744 = None
        v752: None
        closure9(v693, ("" + " = ") + "", None)
        v752 = None
        v760: None
        closure9(v693, ("" + v1_1) + "", None)
        v760 = None
        v769: None
        closure9(v693, ("" + " }") + "", None)
        v769 = None
        v772: str = v693.l0
        v811: str = trim_end(trim_start(((((((((("" + v413) + " ") + v680) + " #") + str(v691)) + " ") + closure54(None, None)) + " / ") + v772) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v811)
        pattern_input[1].l0(v811)



def closure55(v0_1: str, unit_var: None) -> None:
    pass


def method42(v0_1: str) -> Callable[[], None]:
    def _arrow329(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure55(v0_1, None)

    return _arrow329


def method43(v0_1: str) -> Callable[[], None]:
    def _arrow330(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure55(v0_1, None)

    return _arrow330


def method37(v0_1: str) -> IDisposable:
    v2782: bool = None
    if v2782 == False:
        v2816: None
        closure53(v0_1, to_text(interpolate("%A%P()", [{
            "CreationTime": None,
            "Exists": v2782
        }])), None)
        v2816 = None

    v3659: Callable[[], None] = method43(v0_1)
    class ObjectExpr331(IDisposable):
        def Dispose(self, __unit: None=None, v0_1: Any=v0_1) -> None:
            v3659(None)

    return ObjectExpr331()


def closure44(unit_var: None, unit_var_1: None) -> tuple[str, IDisposable]:
    v0_1: str = method24()
    return (v0_1, method37(v0_1))


def method44(v0_1: str) -> str:
    v56: str = pad_left(v0_1, 32, "0")
    return parse(((((((((("" + v56[0:7 + 1]) + "-") + v56[8:11 + 1]) + "-") + v56[12:15 + 1]) + "-") + v56[16:19 + 1]) + "-") + v56[20:31 + 1]) + "")


def closure56(unit_var: None, v0_1: str) -> tuple[str, IDisposable]:
    v2_1: str = method29(method44(v0_1))
    return (v2_1, method37(v2_1))


def closure57(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def method46(v0_1: str) -> str:
    return v0_1


def method45(v0_1: str) -> str:
    if v0_1 == "":
        return ""

    else: 
        v30_1: str = None
        def _arrow332(__unit: None=None, v0_1: Any=v0_1) -> str:
            _arg: str = v30_1[0]
            return _arg.lower()

        return replace(((("" + _arrow332()) + "") + v30_1[1:len(v30_1)]) + "", "\\", "/")



def closure58(unit_var: None, v0_1: str) -> str:
    return method45(v0_1)


def closure59(unit_var: None, v0_1: str) -> str:
    return ("file:///" + trim_start(v0_1, *to_array(singleton("/")))) + ""


def method49(v0_1: str) -> str | None:
    v85: US1 = None
    if v85.tag == 0:
        return v85.fields[0]

    else: 
        return None



def closure61(unit_var: None, v0_1: str) -> str | None:
    return method49(v0_1)


def method48(__unit: None=None) -> Callable[[str], str | None]:
    def _arrow333(v: str) -> str | None:
        return closure61(None, v)

    return _arrow333


def method50(v0_1_mut: str, v1_1_mut: str, v2_1_mut: str) -> US13:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if method8(method32(v2_1, v0_1)):
            return US13(0, v2_1)

        else: 
            v7: str | None = method48()(v2_1)
            _v8: FSharpRef[US1 | None] = FSharpRef(None)
            v13: None
            def v10(v: US1 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> FSharpRef[US1 | None]:
                return closure1(_v8, v)

            closure2(v7, v10, None)
            v13 = None
            v28_1: US1 = default_arg(_v8.contents, US1(1))
            if v28_1.tag == 0:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v28_1.fields[0]
                continue

            else: 
                return US13(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v2_1) + "\')")


        break


def method47(v0_1: str, v1_1: str) -> US13:
    if method8(method32(v1_1, v0_1)):
        return US13(0, v1_1)

    else: 
        v6: str | None = method48()(v1_1)
        _v7: FSharpRef[US1 | None] = FSharpRef(None)
        v12: None
        def v9(v: US1 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> FSharpRef[US1 | None]:
            return closure1(_v7, v)

        closure2(v6, v9, None)
        v12 = None
        v27_1: US1 = default_arg(_v7.contents, US1(1))
        if v27_1.tag == 0:
            return method50(v0_1, v1_1, v27_1.fields[0])

        else: 
            return US13(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v1_1) + "\')")




def closure63(unit_var: None, unit_var_1: None) -> str:
    return "file_system.get_workspace_root"


def closure62(v0_1: str, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v32_1: None
    v2_1(None)
    v32_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v60: US0 = pattern_input_1[3].l0
    class ObjectExpr334:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v60, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr334()))):
        v68: None
        closure6(pattern_input[0], None)
        v68 = None
        v72: None
        v2_1(None)
        v72 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v347: FSharpRef[US3 | None] = FSharpRef(None)
        v352: None
        def v349(v: US3 | None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v347, v)

        closure8(pattern_input_2[4], v349, None)
        v352 = None
        v367: US3 = default_arg(_v347.contents, US3(1))
        def _arrow335(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v381: Any = create(op_subtraction(ticks_1(now()), v367.fields[0]))
            return create_1(1, 1, 1, hours(v381), minutes(v381), seconds(v381), milliseconds(v381))

        v412: str = to_string(_arrow335() if (v367.tag == 0) else now(), method10())
        v558: str = method12()
        v566: Mut4 = Mut4(method13())
        v577: None
        closure9(v566, ("" + to_text(interpolate("%A%P()", [US0(0)]))) + "", None)
        v577 = None
        v581: Array[str] = split(v566.l0, [v558], None, 0)
        v584: str = v581[0]
        v588: Mut4 = Mut4(method13())
        v599: None
        closure9(v588, ("" + to_text(interpolate("%A%P()", [US0(3)]))) + "", None)
        v599 = None
        v602: str = v588.l0
        v609: US1 = US1(0, "Verbose") if (v602.find(v584) == 0) else US1(1)
        v737: US1
        if v609.tag == 0:
            v737 = US1(0, v609.fields[0])

        else: 
            v617: str = method12()
            v625: Mut4 = Mut4(method13())
            v636: None
            closure9(v625, ("" + to_text(interpolate("%A%P()", [US0(1)]))) + "", None)
            v636 = None
            v640: Array[str] = split(v625.l0, [v617], None, 0)
            v643: str = v640[0]
            v647: Mut4 = Mut4(method13())
            v658: None
            closure9(v647, ("" + to_text(interpolate("%A%P()", [US0(3)]))) + "", None)
            v658 = None
            v661: str = v647.l0
            v668: US1 = US1(0, "Debug") if (v661.find(v643) == 0) else US1(1)
            if v668.tag == 0:
                v737 = US1(0, v668.fields[0])

            else: 
                v676: str = method12()
                v684: Mut4 = Mut4(method13())
                v695: None
                closure9(v684, ("" + to_text(interpolate("%A%P()", [US0(2)]))) + "", None)
                v695 = None
                v699: Array[str] = split(v684.l0, [v676], None, 0)
                v702: str = v699[0]
                v706: Mut4 = Mut4(method13())
                v717: None
                closure9(v706, ("" + to_text(interpolate("%A%P()", [US0(3)]))) + "", None)
                v717 = None
                v720: str = v706.l0
                v727: US1 = US1(0, "Info") if (v720.find(v702) == 0) else US1(1)
                v737 = US1(0, v727.fields[0]) if (v727.tag == 0) else US1(0, "Warning")


        v741: str
        if v737.tag == 0:
            v741 = v737.fields[0]

        else: 
            raise Exception("Option does not have a value.")

        v801: str = ("\u001b[93m" + pad_left(v741.lower(), 7, " ")) + method14()
        v812: int64 = pattern_input_2[0].l0
        v814: Mut4 = Mut4(method13())
        v821: None
        closure9(v814, ("" + "{ ") + "", None)
        v821 = None
        v830: None
        closure9(v814, ("" + "error") + "", None)
        v830 = None
        v839: None
        closure9(v814, ("" + " = ") + "", None)
        v839 = None
        v847: None
        closure9(v814, ("" + v0_1) + "", None)
        v847 = None
        v856: None
        closure9(v814, ("" + " }") + "", None)
        v856 = None
        v859: str = v814.l0
        v898: str = trim_end(trim_start(((((((((("" + v412) + " ") + v801) + " #") + str(v812)) + " ") + closure63(None, None)) + " / ") + v859) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v898)
        pattern_input[1].l0(v898)



def method51(__unit: None=None) -> str:
    return None


def closure60(unit_var: None, unit_var_1: None) -> str:
    v4: US13 = method47(method32("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral")
    v934: US1
    if v4.tag == 0:
        v934 = US1(0, v4.fields[0])

    else: 
        v10: None
        closure62(v4.fields[0], None)
        v10 = None
        v934 = US1(1)

    v1871: US1
    if v934.tag == 0:
        v1871 = US1(0, v934.fields[0])

    else: 
        v937: str = method51()
        v939: US13 = method47(method32("polyglot", ".devcontainer"), v937)
        if v939.tag == 0:
            v1871 = US1(0, v939.fields[0])

        else: 
            v945: None
            closure62(v939.fields[0], None)
            v945 = None
            v1871 = US1(1)


    def _arrow336(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
        raise Exception("Option does not have a value.")

    return method32(v1871.fields[0] if (v1871.tag == 0) else _arrow336(), "polyglot")


def method52(v0_1: str) -> None:
    pass


def closure65(unit_var: None, v0_1: str) -> None:
    method52(v0_1)


def closure64(unit_var: None, v0_1: bool) -> None:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    def _arrow337(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure65(None, v)

    def _arrow338(v_1: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure3(None, v_1)

    v33_1: Callable[[str], None] = _arrow337 if v0_1 else _arrow338
    pattern_input[1].l0 = v33_1


def closure67(v0_1: str, v1_1: str) -> str:
    return method32(v0_1, v1_1)


def closure66(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow339(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure67(v0_1, v)

    return _arrow339


v0: None = None

def _arrow340(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow340

def _expr341():
    v1(None)
    return v0


v2: None = _expr341()

def _arrow342(v: str) -> Async[int64]:
    return closure4(None, v)


v15: Callable[[str], Async[int64]] = _arrow342

def delete_directory_async(x: str) -> Async[int64]:
    return v15(x)


def _arrow343(v: US6) -> Callable[[str], Async[int64]]:
    return closure13(None, v)


v16: Callable[[US6, str], Async[int64]] = _arrow343

def wait_for_file_access(x: US6) -> Callable[[str], Async[int64]]:
    return v16(x)


def _arrow344(v: str) -> Async[int64]:
    return closure17(None, v)


v17: Callable[[str], Async[int64]] = _arrow344

def wait_for_file_access_read(x: str) -> Async[int64]:
    return v17(x)


def _arrow345(v: str) -> Async[str]:
    return closure18(None, v)


v18: Callable[[str], Async[str]] = _arrow345

def read_all_text_async(x: str) -> Async[str]:
    return v18(x)


def _arrow346(v: str) -> Callable[[str], bool]:
    return closure19(None, v)


v19: Callable[[str, str], bool] = _arrow346

def file_exists_content(x: str) -> Callable[[str], bool]:
    return v19(x)


def _arrow347(v: str) -> Callable[[str], Async[None]]:
    return closure21(None, v)


v20: Callable[[str, str], Async[None]] = _arrow347

def write_all_text_async(x: str) -> Callable[[str], Async[None]]:
    return v20(x)


def _arrow348(v: str) -> Callable[[str], Async[None]]:
    return closure23(None, v)


v21: Callable[[str, str], Async[None]] = _arrow348

def write_all_text_exists(x: str) -> Callable[[str], Async[None]]:
    return v21(x)


def _arrow349(v: str) -> Async[int64]:
    return closure25(None, v)


v22: Callable[[str], Async[int64]] = _arrow349

def delete_file_async(x: str) -> Async[int64]:
    return v22(x)


def _arrow350(v: str) -> Callable[[str], Async[int64]]:
    return closure28(None, v)


v23: Callable[[str, str], Async[int64]] = _arrow350

def move_file_async(x: str) -> Callable[[str], Async[int64]]:
    return v23(x)


def _arrow351(v: str) -> Async[str | None]:
    return closure32(None, v)


v24: Callable[[str], Async[str | None]] = _arrow351

def read_all_text_retry_async(x: str) -> Async[str | None]:
    return v24(x)


def _arrow352(__unit: None=None) -> str:
    return closure41(None, None)


v25: Callable[[], str] = _arrow352

def create_temp_path(__unit: None=None) -> str:
    return v25(None)


def _arrow353(__unit: None=None) -> tuple[str, IDisposable]:
    return closure44(None, None)


v26: Callable[[], tuple[str, IDisposable]] = _arrow353

def create_temp_dir(__unit: None=None) -> tuple[str, IDisposable]:
    return v26(None)


def _arrow354(v: str) -> tuple[str, IDisposable]:
    return closure56(None, v)


v27: Callable[[str], tuple[str, IDisposable]] = _arrow354

def create_temp_dir_0027(x: str) -> tuple[str, IDisposable]:
    return v27(x)


def _arrow355(__unit: None=None) -> str:
    return closure57(None, None)


v28: Callable[[], str] = _arrow355

def get_source_directory(__unit: None=None) -> str:
    return v28(None)


def _arrow356(v: str) -> str:
    return closure58(None, v)


v29: Callable[[str], str] = _arrow356

def normalize_path(x: str) -> str:
    return v29(x)


def _arrow357(v: str) -> str:
    return closure59(None, v)


v30: Callable[[str], str] = _arrow357

def new_file_uri(x: str) -> str:
    return v30(x)


def _arrow358(__unit: None=None) -> str:
    return closure60(None, None)


v31: Callable[[], str] = _arrow358

def get_workspace_root(__unit: None=None) -> str:
    return v31(None)


def _arrow359(v: bool) -> None:
    closure64(None, v)


v32: Callable[[bool], None] = _arrow359

def init_trace_file(x: bool) -> None:
    v32(x)


def _arrow360(v: str) -> Callable[[str], str]:
    return closure66(None, v)


v33: Callable[[str, str], str] = _arrow360

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v33(x)


