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
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, to_text, interpolate, replace)
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


def _expr259() -> TypeInfo:
    return class_type("File_system.Disposable", None, Disposable)


class Disposable(IDisposable):
    def __init__(self, f: Callable[[], None]) -> None:
        self.f: Callable[[], None] = f

    def Dispose(self, __unit: None=None) -> None:
        _: Disposable = self
        _.f(None)


Disposable_reflection = _expr259

def Disposable__ctor_3A5B6456(f: Callable[[], None]) -> Disposable:
    return Disposable(f)


class IPathDirname(Protocol):
    @abstractmethod
    def dirname(self, path: str) -> str:
        ...


def _expr260() -> TypeInfo:
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


US0_reflection = _expr260

def _expr261() -> TypeInfo:
    return record_type("File_system.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr261

def _expr262() -> TypeInfo:
    return record_type("File_system.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr262

def _expr263() -> TypeInfo:
    return record_type("File_system.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr263

def _expr264() -> TypeInfo:
    return record_type("File_system.Mut3", [], Mut3, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: US0

Mut3_reflection = _expr264

def _expr265() -> TypeInfo:
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


US1_reflection = _expr265

def _expr266() -> TypeInfo:
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


US2_reflection = _expr266

def _expr267() -> TypeInfo:
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


US3_reflection = _expr267

def _expr268() -> TypeInfo:
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


US4_reflection = _expr268

def _expr269() -> TypeInfo:
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


US5_reflection = _expr269

def _expr270() -> TypeInfo:
    return record_type("File_system.Mut4", [], Mut4, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: str

Mut4_reflection = _expr270

def _expr271() -> TypeInfo:
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


US7_reflection = _expr271

def _expr272() -> TypeInfo:
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


US8_reflection = _expr272

def _expr273() -> TypeInfo:
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


US6_reflection = _expr273

def _expr274() -> TypeInfo:
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


US9_reflection = _expr274

def _expr275() -> TypeInfo:
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


US10_reflection = _expr275

def _expr276() -> TypeInfo:
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


US11_reflection = _expr276

def _expr277() -> TypeInfo:
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


US12_reflection = _expr277

def _expr278() -> TypeInfo:
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


US13_reflection = _expr278

def method1(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method3(__unit: None=None) -> str:
    return ""


def closure1(v0_1: FSharpRef[US1 | None], v1_1: US1 | None=None) -> FSharpRef[US1 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure2(v0_1: str | None, v1_1: Callable[[US1 | None], FSharpRef[US1 | None]], unit_var: None) -> None:
    def _arrow279(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US1 | None:
        x: str = v0_1
        def x_1(__unit: None=None) -> US1:
            return US1(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow279()))


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
    v82: US1 = default_arg(_v64.contents, US1(1))
    if v82.tag == 0:
        return v82.fields[0]

    else: 
        return ""



def method4(__unit: None=None) -> str:
    return "AUTOMATION"


def closure3(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, int64 | None]:
    v173: str = method2(method1())
    v178: US2 = US2(0, US0(0)) if ("Verbose" == v173) else US2(1)
    def _arrow280(__unit: None=None, v0_1: Any=v0_1) -> US2:
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




    _v1: tuple[US2, US3] = (US2(0, v178.fields[0]) if (v178.tag == 0) else _arrow280(), US3(0, ticks_1(now())) if (method2(method4()) == "True") else US3(1))
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
    def _arrow281(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US3 | None:
        x: int64 = v0_1
        def x_1(__unit: None=None) -> US3:
            return US3(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow281()))


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


def closure9(v0_1: Mut4, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def closure10(unit_var: None, unit_var_1: None) -> str:
    return "file_system.delete_directory_async"


def closure5(v0_1: str, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v23_1: None
    v3(None)
    v23_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v41: US0 = pattern_input_1[3].l0
    class ObjectExpr282:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v41, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr282()))):
        v49: None
        closure6(pattern_input[0], None)
        v49 = None
        v51: None
        v3(None)
        v51 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v308: FSharpRef[US3 | None] = FSharpRef(None)
        v313: None
        def v310(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v308, v)

        closure8(pattern_input_2[4], v310, None)
        v313 = None
        v326: US3 = default_arg(_v308.contents, US3(1))
        def _arrow283(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v340: Any = create(op_subtraction(ticks_1(now()), v326.fields[0]))
            return create_1(1, 1, 1, hours(v340), minutes(v340), seconds(v340), milliseconds(v340))

        v371: str = to_string(_arrow283() if (v326.tag == 0) else now(), method10())
        v568: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method11()
        v579: int64 = pattern_input_2[0].l0
        v580: str = method12(v0_1)
        v582: Mut4 = Mut4(method13())
        v589: None
        closure9(v582, ("" + "{ ") + "", None)
        v589 = None
        v596: None
        closure9(v582, ("" + "ex") + "", None)
        v596 = None
        v603: None
        closure9(v582, ("" + " = ") + "", None)
        v603 = None
        v609: None
        closure9(v582, ("" + v1_1) + "", None)
        v609 = None
        v616: None
        closure9(v582, ("" + "; ") + "", None)
        v616 = None
        v623: None
        closure9(v582, ("" + "path") + "", None)
        v623 = None
        v629: None
        closure9(v582, ("" + " = ") + "", None)
        v629 = None
        v635: None
        closure9(v582, ("" + v580) + "", None)
        v635 = None
        v642: None
        closure9(v582, ("" + " }") + "", None)
        v642 = None
        v643: str = v582.l0
        v682: str = trim_end(trim_start(((((((((("" + v371) + " ") + v568) + " #") + str(v579)) + " ") + closure10(None, None)) + " / ") + v643) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v682)
        pattern_input[1].l0(v682)



def method5(v0_1: str, v1_1: int64) -> Async[int64]:
    return None


def closure4(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def closure14(unit_var: None, unit_var_1: None) -> str:
    return "file_system.wait_for_file_access"


def closure13(v0_1: str, v1_1: int64, v2_1: str, unit_var: None) -> None:
    def v4(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v5_1: None
    v4(None)
    v5_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v24: None
    v4(None)
    v24 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v42: US0 = pattern_input_1[3].l0
    class ObjectExpr284:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v42, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr284()))):
        v50: None
        closure6(pattern_input[0], None)
        v50 = None
        v52: None
        v4(None)
        v52 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v309: FSharpRef[US3 | None] = FSharpRef(None)
        v314: None
        def v311(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v309, v)

        closure8(pattern_input_2[4], v311, None)
        v314 = None
        v327: US3 = default_arg(_v309.contents, US3(1))
        def _arrow285(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v341: Any = create(op_subtraction(ticks_1(now()), v327.fields[0]))
            return create_1(1, 1, 1, hours(v341), minutes(v341), seconds(v341), milliseconds(v341))

        v372: str = to_string(_arrow285() if (v327.tag == 0) else now(), method10())
        v569: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method11()
        v580: int64 = pattern_input_2[0].l0
        v581: str = method12(v0_1)
        v583: Mut4 = Mut4(method13())
        v590: None
        closure9(v583, ("" + "{ ") + "", None)
        v590 = None
        v597: None
        closure9(v583, ("" + "path") + "", None)
        v597 = None
        v604: None
        closure9(v583, ("" + " = ") + "", None)
        v604 = None
        v610: None
        closure9(v583, ("" + v581) + "", None)
        v610 = None
        v617: None
        closure9(v583, ("" + "; ") + "", None)
        v617 = None
        v624: None
        closure9(v583, ("" + "retry") + "", None)
        v624 = None
        v630: None
        closure9(v583, ("" + " = ") + "", None)
        v630 = None
        v636: None
        closure9(v583, ("" + str(v1_1)) + "", None)
        v636 = None
        v642: None
        closure9(v583, ("" + "; ") + "", None)
        v642 = None
        v649: None
        closure9(v583, ("" + "ex") + "", None)
        v649 = None
        v655: None
        closure9(v583, ("" + " = ") + "", None)
        v655 = None
        v661: None
        closure9(v583, ("" + v2_1) + "", None)
        v661 = None
        v668: None
        closure9(v583, ("" + " }") + "", None)
        v668 = None
        v669: str = v583.l0
        v708: str = trim_end(trim_start(((((((((("" + v372) + " ") + v569) + " #") + str(v580)) + " ") + closure14(None, None)) + " / ") + v669) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v708)
        pattern_input[1].l0(v708)



def method14(v0_1: str, v1_1: US8, v2_1: US7, v3: int64) -> Async[int64]:
    return None


def closure12(v0_1: US6, v1_1: str) -> Async[int64]:
    return None


def closure11(unit_var: None, v0_1: US6) -> Callable[[str], Async[int64]]:
    def _arrow286(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure12(v0_1, v)

    return _arrow286


def method15(v0_1: str, v1_1: int64) -> Async[int64]:
    return None


def closure15(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def closure16(unit_var: None, v0_1: str) -> Async[str]:
    return None


def method17(v0_1: str) -> bool:
    return None


def method18(v0_1: Vec_1[uint8]) -> Vec_1[uint8]:
    return v0_1


def method16(v0_1: str, v1_1: str) -> bool:
    return None


def closure18(v0_1: str, v1_1: str) -> bool:
    return method16(v0_1, v1_1)


def closure17(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow287(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure18(v0_1, v)

    return _arrow287


def closure20(v0_1: str, v1_1: str) -> Async[None]:
    return None


def closure19(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow288(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure20(v0_1, v)

    return _arrow288


def closure22(v0_1: str, v1_1: str) -> Async[None]:
    return None


def closure21(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow289(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure22(v0_1, v)

    return _arrow289


def closure25(unit_var: None, unit_var_1: None) -> str:
    return "delete_file_async"


def closure24(v0_1: str, v1_1: Exception, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v23_1: None
    v3(None)
    v23_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v41: US0 = pattern_input_1[3].l0
    class ObjectExpr290:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v41, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr290()))):
        v49: None
        closure6(pattern_input[0], None)
        v49 = None
        v51: None
        v3(None)
        v51 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v308: FSharpRef[US3 | None] = FSharpRef(None)
        v313: None
        def v310(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v308, v)

        closure8(pattern_input_2[4], v310, None)
        v313 = None
        v326: US3 = default_arg(_v308.contents, US3(1))
        def _arrow291(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v340: Any = create(op_subtraction(ticks_1(now()), v326.fields[0]))
            return create_1(1, 1, 1, hours(v340), minutes(v340), seconds(v340), milliseconds(v340))

        v371: str = to_string(_arrow291() if (v326.tag == 0) else now(), method10())
        v568: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method11()
        v579: int64 = pattern_input_2[0].l0
        v580: str = method12(v0_1)
        v594: str = to_text(interpolate("%A%P()", [v1_1]))
        v604: Mut4 = Mut4(method13())
        v611: None
        closure9(v604, ("" + "{ ") + "", None)
        v611 = None
        v618: None
        closure9(v604, ("" + "path") + "", None)
        v618 = None
        v625: None
        closure9(v604, ("" + " = ") + "", None)
        v625 = None
        v631: None
        closure9(v604, ("" + v580) + "", None)
        v631 = None
        v638: None
        closure9(v604, ("" + "; ") + "", None)
        v638 = None
        v645: None
        closure9(v604, ("" + "ex") + "", None)
        v645 = None
        v651: None
        closure9(v604, ("" + " = ") + "", None)
        v651 = None
        v657: None
        closure9(v604, ("" + v594) + "", None)
        v657 = None
        v664: None
        closure9(v604, ("" + " }") + "", None)
        v664 = None
        v665: str = v604.l0
        v704: str = trim_end(trim_start(((((((((("" + v371) + " ") + v568) + " #") + str(v579)) + " ") + closure25(None, None)) + " / ") + v665) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v704)
        pattern_input[1].l0(v704)



def method19(v0_1: str, v1_1: int64) -> Async[int64]:
    return None


def closure23(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def closure29(unit_var: None, unit_var_1: None) -> str:
    return "move_file_async"


def closure28(v0_1: str, v1_1: str, v2_1: Exception, unit_var: None) -> None:
    def v4(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v5_1: None
    v4(None)
    v5_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v24: None
    v4(None)
    v24 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v42: US0 = pattern_input_1[3].l0
    class ObjectExpr292:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v42, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr292()))):
        v50: None
        closure6(pattern_input[0], None)
        v50 = None
        v52: None
        v4(None)
        v52 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v309: FSharpRef[US3 | None] = FSharpRef(None)
        v314: None
        def v311(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v309, v)

        closure8(pattern_input_2[4], v311, None)
        v314 = None
        v327: US3 = default_arg(_v309.contents, US3(1))
        def _arrow293(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v341: Any = create(op_subtraction(ticks_1(now()), v327.fields[0]))
            return create_1(1, 1, 1, hours(v341), minutes(v341), seconds(v341), milliseconds(v341))

        v372: str = to_string(_arrow293() if (v327.tag == 0) else now(), method10())
        v569: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method11()
        v580: int64 = pattern_input_2[0].l0
        v581: str = method12(v1_1)
        v582: str = method12(v0_1)
        v584: Mut4 = Mut4(method13())
        v591: None
        closure9(v584, ("" + "{ ") + "", None)
        v591 = None
        v598: None
        closure9(v584, ("" + "old_path") + "", None)
        v598 = None
        v605: None
        closure9(v584, ("" + " = ") + "", None)
        v605 = None
        v611: None
        closure9(v584, ("" + v581) + "", None)
        v611 = None
        v618: None
        closure9(v584, ("" + "; ") + "", None)
        v618 = None
        v625: None
        closure9(v584, ("" + "new_path") + "", None)
        v625 = None
        v631: None
        closure9(v584, ("" + " = ") + "", None)
        v631 = None
        v637: None
        closure9(v584, ("" + v582) + "", None)
        v637 = None
        v643: None
        closure9(v584, ("" + "; ") + "", None)
        v643 = None
        v650: None
        closure9(v584, ("" + "ex") + "", None)
        v650 = None
        v656: None
        closure9(v584, ("" + " = ") + "", None)
        v656 = None
        v689: None
        closure9(v584, ("" + to_text(interpolate("%A%P()", [v2_1]))) + "", None)
        v689 = None
        v696: None
        closure9(v584, ("" + " }") + "", None)
        v696 = None
        v697: str = v584.l0
        v736: str = trim_end(trim_start(((((((((("" + v372) + " ") + v569) + " #") + str(v580)) + " ") + closure29(None, None)) + " / ") + v697) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v736)
        pattern_input[1].l0(v736)



def method20(v0_1: str, v1_1: str, v2_1: int64) -> Async[int64]:
    return None


def closure27(v0_1: str, v1_1: str) -> Async[int64]:
    return None


def closure26(unit_var: None, v0_1: str) -> Callable[[str], Async[int64]]:
    def _arrow294(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure27(v0_1, v)

    return _arrow294


def closure31(unit_var: None, v0_1: int64) -> US9:
    return US9(0, v0_1)


def closure32(unit_var: None, v0_1: Exception) -> US9:
    return US9(1, v0_1)


def closure34(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async"


def closure33(unit_var: None, unit_var_1: None) -> None:
    def v1_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure0(None, None)

    v2_1: None
    v1_1(None)
    v2_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v21_1: None
    v1_1(None)
    v21_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v39: US0 = pattern_input_1[3].l0
    class ObjectExpr295:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v39, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr295()))):
        v47: None
        closure6(pattern_input[0], None)
        v47 = None
        v49: None
        v1_1(None)
        v49 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v306: FSharpRef[US3 | None] = FSharpRef(None)
        v311: None
        def v308(v: US3 | None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> FSharpRef[US3 | None]:
            return closure7(_v306, v)

        closure8(pattern_input_2[4], v308, None)
        v311 = None
        v324: US3 = default_arg(_v306.contents, US3(1))
        def _arrow296(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> Any:
            v338: Any = create(op_subtraction(ticks_1(now()), v324.fields[0]))
            return create_1(1, 1, 1, hours(v338), minutes(v338), seconds(v338), milliseconds(v338))

        v369: str = to_string(_arrow296() if (v324.tag == 0) else now(), method10())
        v566: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method11()
        v577: int64 = pattern_input_2[0].l0
        v579: Mut4 = Mut4(method13())
        v586: None
        closure9(v579, ("" + "{ ") + "", None)
        v586 = None
        v593: None
        closure9(v579, ("" + "timeout") + "", None)
        v593 = None
        v600: None
        closure9(v579, ("" + " = ") + "", None)
        v600 = None
        v606: None
        closure9(v579, ("" + str(1000)) + "", None)
        v606 = None
        v613: None
        closure9(v579, ("" + " }") + "", None)
        v613 = None
        v614: str = v579.l0
        v653: str = trim_end(trim_start(((((((((("" + v369) + " ") + v566) + " #") + str(v577)) + " ") + closure34(None, None)) + " / ") + v614) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v653)
        pattern_input[1].l0(v653)



def closure36(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async**"


def closure35(v0_1: Exception, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v22_1: None
    v2_1(None)
    v22_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v40: US0 = pattern_input_1[3].l0
    class ObjectExpr297:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (4 >= find(v40, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr297()))):
        v48: None
        closure6(pattern_input[0], None)
        v48 = None
        v50: None
        v2_1(None)
        v50 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v307: FSharpRef[US3 | None] = FSharpRef(None)
        v312: None
        def v309(v: US3 | None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v307, v)

        closure8(pattern_input_2[4], v309, None)
        v312 = None
        v325: US3 = default_arg(_v307.contents, US3(1))
        def _arrow298(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v339: Any = create(op_subtraction(ticks_1(now()), v325.fields[0]))
            return create_1(1, 1, 1, hours(v339), minutes(v339), seconds(v339), milliseconds(v339))

        v370: str = to_string(_arrow298() if (v325.tag == 0) else now(), method10())
        v567: str = ("\u001b[91m" + pad_left("Critical".lower(), 7, " ")) + method11()
        v578: int64 = pattern_input_2[0].l0
        v592: str = to_text(interpolate("%A%P()", [v0_1]))
        v602: Mut4 = Mut4(method13())
        v609: None
        closure9(v602, ("" + "{ ") + "", None)
        v609 = None
        v616: None
        closure9(v602, ("" + "timeout") + "", None)
        v616 = None
        v623: None
        closure9(v602, ("" + " = ") + "", None)
        v623 = None
        v629: None
        closure9(v602, ("" + str(1000)) + "", None)
        v629 = None
        v636: None
        closure9(v602, ("" + "; ") + "", None)
        v636 = None
        v643: None
        closure9(v602, ("" + "ex") + "", None)
        v643 = None
        v649: None
        closure9(v602, ("" + " = ") + "", None)
        v649 = None
        v655: None
        closure9(v602, ("" + v592) + "", None)
        v655 = None
        v662: None
        closure9(v602, ("" + " }") + "", None)
        v662 = None
        v663: str = v602.l0
        v702: str = trim_end(trim_start(((((((((("" + v370) + " ") + v567) + " #") + str(v578)) + " ") + closure36(None, None)) + " / ") + v663) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v702)
        pattern_input[1].l0(v702)



def closure38(unit_var: None, unit_var_1: None) -> str:
    return "read_all_text_retry_async"


def closure37(v0_1: int64, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v23_1: None
    v3(None)
    v23_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v41: US0 = pattern_input_1[3].l0
    class ObjectExpr299:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v41, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr299()))):
        v49: None
        closure6(pattern_input[0], None)
        v49 = None
        v51: None
        v3(None)
        v51 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v308: FSharpRef[US3 | None] = FSharpRef(None)
        v313: None
        def v310(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v308, v)

        closure8(pattern_input_2[4], v310, None)
        v313 = None
        v326: US3 = default_arg(_v308.contents, US3(1))
        def _arrow300(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v340: Any = create(op_subtraction(ticks_1(now()), v326.fields[0]))
            return create_1(1, 1, 1, hours(v340), minutes(v340), seconds(v340), milliseconds(v340))

        v371: str = to_string(_arrow300() if (v326.tag == 0) else now(), method10())
        v568: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method11()
        v579: int64 = pattern_input_2[0].l0
        v581: Mut4 = Mut4(method13())
        v588: None
        closure9(v581, ("" + "{ ") + "", None)
        v588 = None
        v595: None
        closure9(v581, ("" + "retry") + "", None)
        v595 = None
        v602: None
        closure9(v581, ("" + " = ") + "", None)
        v602 = None
        v608: None
        closure9(v581, ("" + str(v0_1)) + "", None)
        v608 = None
        v615: None
        closure9(v581, ("" + "; ") + "", None)
        v615 = None
        v622: None
        closure9(v581, ("" + "ex") + "", None)
        v622 = None
        v628: None
        closure9(v581, ("" + " = ") + "", None)
        v628 = None
        v634: None
        closure9(v581, ("" + v1_1) + "", None)
        v634 = None
        v641: None
        closure9(v581, ("" + " }") + "", None)
        v641 = None
        v642: str = v581.l0
        v681: str = trim_end(trim_start(((((((((("" + v371) + " ") + v568) + " #") + str(v579)) + " ") + closure38(None, None)) + " / ") + v642) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v681)
        pattern_input[1].l0(v681)



def method21(v0_1: str, v1_1: int64) -> Async[str | None]:
    return None


def closure30(unit_var: None, v0_1: str) -> Async[str | None]:
    return None


def closure40(v0_1: FSharpRef[US11 | None], v1_1: US11 | None=None) -> FSharpRef[US11 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure41(v0_1: chrono_date_time_1[chrono_utc] | None, v1_1: Callable[[US11 | None], FSharpRef[US11 | None]], unit_var: None) -> None:
    def _arrow301(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US11 | None:
        x: chrono_date_time_1[chrono_utc] = v0_1
        def x_1(__unit: None=None) -> US11:
            return US11(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow301()))


def method24(__unit: None=None) -> str:
    return "hh:mm"


def method25(__unit: None=None) -> str:
    return "yyyyMMdd-HHmm-ssff-ffff-f"


def method26(__unit: None=None) -> str:
    return "hhmm"


def method23(v0_1: str, v1_1: Any) -> str:
    v434: str = to_string(v1_1, method25())
    v503: Any
    raise Exception(("date_time.get_utc_offset / target: " + str(US5(4, US4(0)))) + "")
    v514: uint8 = uint8(1) if (hours(v503) > 0) else uint8(0)
    v515: str = method26()
    v526: str = ((("" + str(v514)) + "") + to_string_1(v503, "c", {})) + ""
    v528: str = str(v0_1)
    return parse(((((("" + v434) + "") + v526) + "") + v528[len(v434) + len(v526):len(v528)]) + "")


def method28(__unit: None=None) -> str:
    raise Exception(("file_system.get_temp_path / target: " + str(US5(4, US4(0)))) + "")


def method29(__unit: None=None) -> str:
    return "!create_temp_path_"


def method32(v0_1: str) -> str:
    return v0_1


def method31(v0_1: str, v1_1: str) -> tuple[str, str]:
    return (v1_1, method32(v0_1))


def method30(v0_1: str, v1_1: str) -> str:
    raise Exception(((((("file_system.(</>) / target: " + str(US5(4, US4(0)))) + " / a: ") + v0_1) + " / b: ") + v1_1) + "")


def method34(__unit: None=None) -> str:
    return "CARGO_PKG_NAME"


def method33(__unit: None=None) -> str:
    raise Exception(("env.get_entry_assembly_name / target: " + str(US5(4, US4(0)))) + "")


def method27(v0_1: str) -> str:
    return method30(method30(method30(method28(), method29()), method33()), str(v0_1))


def method22(__unit: None=None) -> str:
    v31: Any = now()
    return method27(method23(new_guid(), v31))


def closure39(unit_var: None, unit_var_1: None) -> str:
    return method22()


def method36(v0_1: str) -> str:
    return v0_1


def closure43(unit_var: None, v0_1: std_io_error) -> std_string_string:
    return None


def method37(__unit: None=None) -> Callable[[std_io_error], std_string_string]:
    def _arrow302(v: std_io_error) -> std_string_string:
        return closure43(None, v)

    return _arrow302


def closure44(unit_var: None, unit_var_1: None) -> US12:
    return US12(0)


def closure45(unit_var: None, v0_1: std_string_string) -> US12:
    return US12(1, v0_1)


def closure47(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_dir"


def closure46(v0_1: str, v1_1: std_string_string, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v23_1: None
    v3(None)
    v23_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v41: US0 = pattern_input_1[3].l0
    class ObjectExpr303:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (4 >= find(v41, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr303()))):
        v49: None
        closure6(pattern_input[0], None)
        v49 = None
        v51: None
        v3(None)
        v51 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v308: FSharpRef[US3 | None] = FSharpRef(None)
        v313: None
        def v310(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v308, v)

        closure8(pattern_input_2[4], v310, None)
        v313 = None
        v326: US3 = default_arg(_v308.contents, US3(1))
        def _arrow304(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v340: Any = create(op_subtraction(ticks_1(now()), v326.fields[0]))
            return create_1(1, 1, 1, hours(v340), minutes(v340), seconds(v340), milliseconds(v340))

        v371: str = to_string(_arrow304() if (v326.tag == 0) else now(), method10())
        v568: str = ("\u001b[91m" + pad_left("Critical".lower(), 7, " ")) + method11()
        v579: int64 = pattern_input_2[0].l0
        v581: Mut4 = Mut4(method13())
        v588: None
        closure9(v581, ("" + "{ ") + "", None)
        v588 = None
        v595: None
        closure9(v581, ("" + "dir") + "", None)
        v595 = None
        v602: None
        closure9(v581, ("" + " = ") + "", None)
        v602 = None
        v608: None
        closure9(v581, ("" + v0_1) + "", None)
        v608 = None
        v615: None
        closure9(v581, ("" + "; ") + "", None)
        v615 = None
        v622: None
        closure9(v581, ("" + "error") + "", None)
        v622 = None
        v628: None
        closure9(v581, ("" + " = ") + "", None)
        v628 = None
        v661: None
        closure9(v581, ("" + to_text(interpolate("%A%P()", [v1_1]))) + "", None)
        v661 = None
        v668: None
        closure9(v581, ("" + " }") + "", None)
        v668 = None
        v669: str = v581.l0
        v708: str = trim_end(trim_start(((((((((("" + v371) + " ") + v568) + " #") + str(v579)) + " ") + closure47(None, None)) + " / ") + v669) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v708)
        pattern_input[1].l0(v708)



def closure49(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_dir"


def closure48(v0_1: str, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v22_1: None
    v2_1(None)
    v22_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v40: US0 = pattern_input_1[3].l0
    class ObjectExpr305:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v40, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr305()))):
        v48: None
        closure6(pattern_input[0], None)
        v48 = None
        v50: None
        v2_1(None)
        v50 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v307: FSharpRef[US3 | None] = FSharpRef(None)
        v312: None
        def v309(v: US3 | None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v307, v)

        closure8(pattern_input_2[4], v309, None)
        v312 = None
        v325: US3 = default_arg(_v307.contents, US3(1))
        def _arrow306(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v339: Any = create(op_subtraction(ticks_1(now()), v325.fields[0]))
            return create_1(1, 1, 1, hours(v339), minutes(v339), seconds(v339), milliseconds(v339))

        v370: str = to_string(_arrow306() if (v325.tag == 0) else now(), method10())
        v567: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method11()
        v578: int64 = pattern_input_2[0].l0
        v580: Mut4 = Mut4(method13())
        v587: None
        closure9(v580, ("" + "{ ") + "", None)
        v587 = None
        v594: None
        closure9(v580, ("" + "dir") + "", None)
        v594 = None
        v601: None
        closure9(v580, ("" + " = ") + "", None)
        v601 = None
        v607: None
        closure9(v580, ("" + v0_1) + "", None)
        v607 = None
        v614: None
        closure9(v580, ("" + " }") + "", None)
        v614 = None
        v615: str = v580.l0
        v654: str = trim_end(trim_start(((((((((("" + v370) + " ") + v567) + " #") + str(v578)) + " ") + closure49(None, None)) + " / ") + v615) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v654)
        pattern_input[1].l0(v654)



def closure50(v0_1: str, unit_var: None) -> None:
    method6(True, v0_1)


def method38(v0_1: str) -> Callable[[], None]:
    def _arrow307(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure50(v0_1, None)

    return _arrow307


def method39(v0_1: str) -> Callable[[], None]:
    def _arrow308(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure50(v0_1, None)

    return _arrow308


def closure52(unit_var: None, unit_var_1: None) -> str:
    return "file_system.create_dir"


def closure51(v0_1: str, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v23_1: None
    v3(None)
    v23_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v41: US0 = pattern_input_1[3].l0
    class ObjectExpr309:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v41, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr309()))):
        v49: None
        closure6(pattern_input[0], None)
        v49 = None
        v51: None
        v3(None)
        v51 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v308: FSharpRef[US3 | None] = FSharpRef(None)
        v313: None
        def v310(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v308, v)

        closure8(pattern_input_2[4], v310, None)
        v313 = None
        v326: US3 = default_arg(_v308.contents, US3(1))
        def _arrow310(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v340: Any = create(op_subtraction(ticks_1(now()), v326.fields[0]))
            return create_1(1, 1, 1, hours(v340), minutes(v340), seconds(v340), milliseconds(v340))

        v371: str = to_string(_arrow310() if (v326.tag == 0) else now(), method10())
        v568: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method11()
        v579: int64 = pattern_input_2[0].l0
        v581: Mut4 = Mut4(method13())
        v588: None
        closure9(v581, ("" + "{ ") + "", None)
        v588 = None
        v595: None
        closure9(v581, ("" + "dir") + "", None)
        v595 = None
        v602: None
        closure9(v581, ("" + " = ") + "", None)
        v602 = None
        v608: None
        closure9(v581, ("" + v0_1) + "", None)
        v608 = None
        v615: None
        closure9(v581, ("" + "; ") + "", None)
        v615 = None
        v622: None
        closure9(v581, ("" + "result") + "", None)
        v622 = None
        v628: None
        closure9(v581, ("" + " = ") + "", None)
        v628 = None
        v634: None
        closure9(v581, ("" + v1_1) + "", None)
        v634 = None
        v641: None
        closure9(v581, ("" + " }") + "", None)
        v641 = None
        v642: str = v581.l0
        v681: str = trim_end(trim_start(((((((((("" + v371) + " ") + v568) + " #") + str(v579)) + " ") + closure52(None, None)) + " / ") + v642) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v681)
        pattern_input[1].l0(v681)



def closure53(v0_1: str, unit_var: None) -> None:
    pass


def method40(v0_1: str) -> Callable[[], None]:
    def _arrow311(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure53(v0_1, None)

    return _arrow311


def method41(v0_1: str) -> Callable[[], None]:
    def _arrow312(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure53(v0_1, None)

    return _arrow312


def method35(v0_1: str) -> IDisposable:
    v173: bool = None
    if v173 == False:
        v207: None
        closure51(v0_1, to_text(interpolate("%A%P()", [{
            "CreationTime": None,
            "Exists": v173
        }])), None)
        v207 = None

    v217: Callable[[], None] = method41(v0_1)
    class ObjectExpr313(IDisposable):
        def Dispose(self, __unit: None=None, v0_1: Any=v0_1) -> None:
            v217(None)

    return ObjectExpr313()


def closure42(unit_var: None, unit_var_1: None) -> tuple[str, IDisposable]:
    v0_1: str = method22()
    return (v0_1, method35(v0_1))


def method42(v0_1: str) -> str:
    v56: str = pad_left(v0_1, 32, "0")
    return parse(((((((((("" + v56[0:7 + 1]) + "-") + v56[8:11 + 1]) + "-") + v56[12:15 + 1]) + "-") + v56[16:19 + 1]) + "-") + v56[20:31 + 1]) + "")


def closure54(unit_var: None, v0_1: str) -> tuple[str, IDisposable]:
    v2_1: str = method27(method42(v0_1))
    return (v2_1, method35(v2_1))


def closure55(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def method44(v0_1: str) -> str:
    return v0_1


def method43(v0_1: str) -> str:
    if v0_1 == "":
        return ""

    else: 
        v30: str = None
        def _arrow314(__unit: None=None, v0_1: Any=v0_1) -> str:
            _arg: str = v30[0]
            return _arg.lower()

        return replace(((("" + _arrow314()) + "") + v30[1:len(v30)]) + "", "\\", "/")



def closure56(unit_var: None, v0_1: str) -> str:
    return method43(v0_1)


def closure57(unit_var: None, v0_1: str) -> str:
    return ("file:///" + trim_start(v0_1, *to_array(singleton("/")))) + ""


def method47(v0_1: str) -> str | None:
    v85: US1 = None
    if v85.tag == 0:
        return v85.fields[0]

    else: 
        return None



def closure59(unit_var: None, v0_1: str) -> str | None:
    return method47(v0_1)


def method46(__unit: None=None) -> Callable[[str], str | None]:
    def _arrow315(v: str) -> str | None:
        return closure59(None, v)

    return _arrow315


def method48(v0_1_mut: str, v1_1_mut: str, v2_1_mut: str) -> US13:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if method8(method30(v2_1, v0_1)):
            return US13(0, v2_1)

        else: 
            v7_1: str | None = method46()(v2_1)
            _v8: FSharpRef[US1 | None] = FSharpRef(None)
            v13_1: None
            def v10_1(v: US1 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1) -> FSharpRef[US1 | None]:
                return closure1(_v8, v)

            closure2(v7_1, v10_1, None)
            v13_1 = None
            v26: US1 = default_arg(_v8.contents, US1(1))
            if v26.tag == 0:
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v26.fields[0]
                continue

            else: 
                return US13(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v2_1) + "\')")


        break


def method45(v0_1: str, v1_1: str) -> US13:
    if method8(method30(v1_1, v0_1)):
        return US13(0, v1_1)

    else: 
        v6_1: str | None = method46()(v1_1)
        _v7: FSharpRef[US1 | None] = FSharpRef(None)
        v12_1: None
        def v9_1(v: US1 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> FSharpRef[US1 | None]:
            return closure1(_v7, v)

        closure2(v6_1, v9_1, None)
        v12_1 = None
        v25: US1 = default_arg(_v7.contents, US1(1))
        if v25.tag == 0:
            return method48(v0_1, v1_1, v25.fields[0])

        else: 
            return US13(1, ((((((("No parent for " + "dir") + " \'") + v0_1) + "\' at \'") + v1_1) + "\' (until \'") + v1_1) + "\')")




def closure61(unit_var: None, unit_var_1: None) -> str:
    return "file_system.get_workspace_root"


def closure60(v0_1: str, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v22_1: None
    v2_1(None)
    v22_1 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    v40: US0 = pattern_input_1[3].l0
    class ObjectExpr316:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v40, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr316()))):
        v48: None
        closure6(pattern_input[0], None)
        v48 = None
        v50: None
        v2_1(None)
        v50 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
        _v307: FSharpRef[US3 | None] = FSharpRef(None)
        v312: None
        def v309(v: US3 | None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure7(_v307, v)

        closure8(pattern_input_2[4], v309, None)
        v312 = None
        v325: US3 = default_arg(_v307.contents, US3(1))
        def _arrow317(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v339: Any = create(op_subtraction(ticks_1(now()), v325.fields[0]))
            return create_1(1, 1, 1, hours(v339), minutes(v339), seconds(v339), milliseconds(v339))

        v370: str = to_string(_arrow317() if (v325.tag == 0) else now(), method10())
        v567: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method11()
        v578: int64 = pattern_input_2[0].l0
        v580: Mut4 = Mut4(method13())
        v587: None
        closure9(v580, ("" + "{ ") + "", None)
        v587 = None
        v594: None
        closure9(v580, ("" + "error") + "", None)
        v594 = None
        v601: None
        closure9(v580, ("" + " = ") + "", None)
        v601 = None
        v607: None
        closure9(v580, ("" + v0_1) + "", None)
        v607 = None
        v614: None
        closure9(v580, ("" + " }") + "", None)
        v614 = None
        v615: str = v580.l0
        v654: str = trim_end(trim_start(((((((((("" + v370) + " ") + v567) + " #") + str(v578)) + " ") + closure61(None, None)) + " / ") + v615) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        print(v654)
        pattern_input[1].l0(v654)



def method49(__unit: None=None) -> str:
    return None


def closure58(unit_var: None, unit_var_1: None) -> str:
    v4: US13 = method45(method30("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral")
    v13_1: US1
    if v4.tag == 0:
        v13_1 = US1(0, v4.fields[0])

    else: 
        v10_1: None
        closure60(v4.fields[0], None)
        v10_1 = None
        v13_1 = US1(1)

    v29: US1
    if v13_1.tag == 0:
        v29 = US1(0, v13_1.fields[0])

    else: 
        v16_1: str = method49()
        v18_1: US13 = method45(method30("polyglot", ".devcontainer"), v16_1)
        if v18_1.tag == 0:
            v29 = US1(0, v18_1.fields[0])

        else: 
            v24: None
            closure60(v18_1.fields[0], None)
            v24 = None
            v29 = US1(1)


    def _arrow318(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
        raise Exception("Option does not have a value.")

    return method30(v29.fields[0] if (v29.tag == 0) else _arrow318(), "polyglot")


def method50(v0_1: str) -> None:
    pass


def closure63(unit_var: None, v0_1: str) -> None:
    method50(v0_1)


def closure62(unit_var: None, v0_1: bool) -> None:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    def _arrow319(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure63(None, v)

    def _arrow320(v_1: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure3(None, v_1)

    v23_1: Callable[[str], None] = _arrow319 if v0_1 else _arrow320
    pattern_input[1].l0 = v23_1


def closure65(v0_1: str, v1_1: str) -> str:
    return method30(v0_1, v1_1)


def closure64(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow321(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure65(v0_1, v)

    return _arrow321


v0: None = None

def _arrow322(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow322

def _expr323():
    v1(None)
    return v0


v2: None = _expr323()

def _arrow324(v: str) -> Async[int64]:
    return closure4(None, v)


v5: Callable[[str], Async[int64]] = _arrow324

def delete_directory_async(x: str) -> Async[int64]:
    return v5(x)


def _arrow325(v: US6) -> Callable[[str], Async[int64]]:
    return closure11(None, v)


v6: Callable[[US6, str], Async[int64]] = _arrow325

def wait_for_file_access(x: US6) -> Callable[[str], Async[int64]]:
    return v6(x)


def _arrow326(v: str) -> Async[int64]:
    return closure15(None, v)


v7: Callable[[str], Async[int64]] = _arrow326

def wait_for_file_access_read(x: str) -> Async[int64]:
    return v7(x)


def _arrow327(v: str) -> Async[str]:
    return closure16(None, v)


v8: Callable[[str], Async[str]] = _arrow327

def read_all_text_async(x: str) -> Async[str]:
    return v8(x)


def _arrow328(v: str) -> Callable[[str], bool]:
    return closure17(None, v)


v9: Callable[[str, str], bool] = _arrow328

def file_exists_content(x: str) -> Callable[[str], bool]:
    return v9(x)


def _arrow329(v: str) -> Callable[[str], Async[None]]:
    return closure19(None, v)


v10: Callable[[str, str], Async[None]] = _arrow329

def write_all_text_async(x: str) -> Callable[[str], Async[None]]:
    return v10(x)


def _arrow330(v: str) -> Callable[[str], Async[None]]:
    return closure21(None, v)


v11: Callable[[str, str], Async[None]] = _arrow330

def write_all_text_exists(x: str) -> Callable[[str], Async[None]]:
    return v11(x)


def _arrow331(v: str) -> Async[int64]:
    return closure23(None, v)


v12: Callable[[str], Async[int64]] = _arrow331

def delete_file_async(x: str) -> Async[int64]:
    return v12(x)


def _arrow332(v: str) -> Callable[[str], Async[int64]]:
    return closure26(None, v)


v13: Callable[[str, str], Async[int64]] = _arrow332

def move_file_async(x: str) -> Callable[[str], Async[int64]]:
    return v13(x)


def _arrow333(v: str) -> Async[str | None]:
    return closure30(None, v)


v14: Callable[[str], Async[str | None]] = _arrow333

def read_all_text_retry_async(x: str) -> Async[str | None]:
    return v14(x)


def _arrow334(__unit: None=None) -> str:
    return closure39(None, None)


v15: Callable[[], str] = _arrow334

def create_temp_path(__unit: None=None) -> str:
    return v15(None)


def _arrow335(__unit: None=None) -> tuple[str, IDisposable]:
    return closure42(None, None)


v16: Callable[[], tuple[str, IDisposable]] = _arrow335

def create_temp_dir(__unit: None=None) -> tuple[str, IDisposable]:
    return v16(None)


def _arrow336(v: str) -> tuple[str, IDisposable]:
    return closure54(None, v)


v17: Callable[[str], tuple[str, IDisposable]] = _arrow336

def create_temp_dir_0027(x: str) -> tuple[str, IDisposable]:
    return v17(x)


def _arrow337(__unit: None=None) -> str:
    return closure55(None, None)


v18: Callable[[], str] = _arrow337

def get_source_directory(__unit: None=None) -> str:
    return v18(None)


def _arrow338(v: str) -> str:
    return closure56(None, v)


v19: Callable[[str], str] = _arrow338

def normalize_path(x: str) -> str:
    return v19(x)


def _arrow339(v: str) -> str:
    return closure57(None, v)


v20: Callable[[str], str] = _arrow339

def new_file_uri(x: str) -> str:
    return v20(x)


def _arrow340(__unit: None=None) -> str:
    return closure58(None, None)


v21: Callable[[], str] = _arrow340

def get_workspace_root(__unit: None=None) -> str:
    return v21(None)


def _arrow341(v: bool) -> None:
    closure62(None, v)


v22: Callable[[bool], None] = _arrow341

def init_trace_file(x: bool) -> None:
    v22(x)


def _arrow342(v: str) -> Callable[[str], str]:
    return closure64(None, v)


v23: Callable[[str, str], str] = _arrow342

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v23(x)


