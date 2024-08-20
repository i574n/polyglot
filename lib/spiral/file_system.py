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
    class ObjectExpr282:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr282()))):
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
        def _arrow283(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v382: Any = create(op_subtraction(ticks_1(now()), v368.fields[0]))
            return create_1(1, 1, 1, hours(v382), minutes(v382), seconds(v382), milliseconds(v382))

        v413: str = to_string(_arrow283() if (v368.tag == 0) else now(), method10())
        v614: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method11()
        v625: int64 = pattern_input_2[0].l0
        v626: str = method12(v0_1)
        v628: Mut4 = Mut4(method13())
        v635: None
        closure9(v628, ("" + "{ ") + "", None)
        v635 = None
        v644: None
        closure9(v628, ("" + "ex") + "", None)
        v644 = None
        v653: None
        closure9(v628, ("" + " = ") + "", None)
        v653 = None
        v661: None
        closure9(v628, ("" + v1_1) + "", None)
        v661 = None
        v670: None
        closure9(v628, ("" + "; ") + "", None)
        v670 = None
        v679: None
        closure9(v628, ("" + "path") + "", None)
        v679 = None
        v687: None
        closure9(v628, ("" + " = ") + "", None)
        v687 = None
        v695: None
        closure9(v628, ("" + v626) + "", None)
        v695 = None
        v704: None
        closure9(v628, ("" + " }") + "", None)
        v704 = None
        v707: str = v628.l0
        v746: str = trim_end(trim_start(((((((((("" + v413) + " ") + v614) + " #") + str(v625)) + " ") + closure10(None, None)) + " / ") + v707) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v746)
        pattern_input[1].l0(v746)



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
    class ObjectExpr284:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v62, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr284()))):
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
        def _arrow285(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v383: Any = create(op_subtraction(ticks_1(now()), v369.fields[0]))
            return create_1(1, 1, 1, hours(v383), minutes(v383), seconds(v383), milliseconds(v383))

        v414: str = to_string(_arrow285() if (v369.tag == 0) else now(), method10())
        v615: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method11()
        v626: int64 = pattern_input_2[0].l0
        v627: str = method12(v0_1)
        v629: Mut4 = Mut4(method13())
        v636: None
        closure9(v629, ("" + "{ ") + "", None)
        v636 = None
        v645: None
        closure9(v629, ("" + "path") + "", None)
        v645 = None
        v654: None
        closure9(v629, ("" + " = ") + "", None)
        v654 = None
        v662: None
        closure9(v629, ("" + v627) + "", None)
        v662 = None
        v671: None
        closure9(v629, ("" + "; ") + "", None)
        v671 = None
        v680: None
        closure9(v629, ("" + "retry") + "", None)
        v680 = None
        v688: None
        closure9(v629, ("" + " = ") + "", None)
        v688 = None
        v696: None
        closure9(v629, ("" + str(v1_1)) + "", None)
        v696 = None
        v704: None
        closure9(v629, ("" + "; ") + "", None)
        v704 = None
        v713: None
        closure9(v629, ("" + "ex") + "", None)
        v713 = None
        v721: None
        closure9(v629, ("" + " = ") + "", None)
        v721 = None
        v729: None
        closure9(v629, ("" + v2_1) + "", None)
        v729 = None
        v738: None
        closure9(v629, ("" + " }") + "", None)
        v738 = None
        v741: str = v629.l0
        v780: str = trim_end(trim_start(((((((((("" + v414) + " ") + v615) + " #") + str(v626)) + " ") + closure16(None, None)) + " / ") + v741) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v780)
        pattern_input[1].l0(v780)



def method14(v0_1: str, v1_1: US8, v2_1: US7, v3: int64) -> Async[int64]:
    return None


def closure14(v0_1: US6, v1_1: str) -> Async[int64]:
    return None


def closure13(unit_var: None, v0_1: US6) -> Callable[[str], Async[int64]]:
    def _arrow286(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure14(v0_1, v)

    return _arrow286


def method15(v0_1: str, v1_1: int64) -> Async[int64]:
    return None


def closure17(unit_var: None, v0_1: str) -> Async[int64]:
    return None


def closure18(unit_var: None, v0_1: str) -> Async[str]:
    return None


def method17(v0_1: str) -> bool:
    return None


def method18(v0_1: Vec_1[uint8]) -> Vec_1[uint8]:
    return v0_1


def method16(v0_1: str, v1_1: str) -> bool:
    return None


def closure20(v0_1: str, v1_1: str) -> bool:
    return method16(v0_1, v1_1)


def closure19(unit_var: None, v0_1: str) -> Callable[[str], bool]:
    def _arrow287(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> bool:
        return closure20(v0_1, v)

    return _arrow287


def closure22(v0_1: str, v1_1: str) -> Async[None]:
    return None


def closure21(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow288(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure22(v0_1, v)

    return _arrow288


def closure24(v0_1: str, v1_1: str) -> Async[None]:
    return None


def closure23(unit_var: None, v0_1: str) -> Callable[[str], Async[None]]:
    def _arrow289(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[None]:
        return closure24(v0_1, v)

    return _arrow289


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
    class ObjectExpr290:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr290()))):
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
        def _arrow291(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v382: Any = create(op_subtraction(ticks_1(now()), v368.fields[0]))
            return create_1(1, 1, 1, hours(v382), minutes(v382), seconds(v382), milliseconds(v382))

        v413: str = to_string(_arrow291() if (v368.tag == 0) else now(), method10())
        v614: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method11()
        v625: int64 = pattern_input_2[0].l0
        v626: str = method12(v0_1)
        v640: str = to_text(interpolate("%A%P()", [v1_1]))
        v650: Mut4 = Mut4(method13())
        v657: None
        closure9(v650, ("" + "{ ") + "", None)
        v657 = None
        v666: None
        closure9(v650, ("" + "path") + "", None)
        v666 = None
        v675: None
        closure9(v650, ("" + " = ") + "", None)
        v675 = None
        v683: None
        closure9(v650, ("" + v626) + "", None)
        v683 = None
        v692: None
        closure9(v650, ("" + "; ") + "", None)
        v692 = None
        v701: None
        closure9(v650, ("" + "ex") + "", None)
        v701 = None
        v709: None
        closure9(v650, ("" + " = ") + "", None)
        v709 = None
        v717: None
        closure9(v650, ("" + v640) + "", None)
        v717 = None
        v726: None
        closure9(v650, ("" + " }") + "", None)
        v726 = None
        v729: str = v650.l0
        v768: str = trim_end(trim_start(((((((((("" + v413) + " ") + v614) + " #") + str(v625)) + " ") + closure27(None, None)) + " / ") + v729) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v768)
        pattern_input[1].l0(v768)



def method19(v0_1: str, v1_1: int64) -> Async[int64]:
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
    class ObjectExpr292:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v62, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr292()))):
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
        def _arrow293(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, unit_var: Any=unit_var) -> Any:
            v383: Any = create(op_subtraction(ticks_1(now()), v369.fields[0]))
            return create_1(1, 1, 1, hours(v383), minutes(v383), seconds(v383), milliseconds(v383))

        v414: str = to_string(_arrow293() if (v369.tag == 0) else now(), method10())
        v615: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method11()
        v626: int64 = pattern_input_2[0].l0
        v627: str = method12(v1_1)
        v628: str = method12(v0_1)
        v630: Mut4 = Mut4(method13())
        v637: None
        closure9(v630, ("" + "{ ") + "", None)
        v637 = None
        v646: None
        closure9(v630, ("" + "old_path") + "", None)
        v646 = None
        v655: None
        closure9(v630, ("" + " = ") + "", None)
        v655 = None
        v663: None
        closure9(v630, ("" + v627) + "", None)
        v663 = None
        v672: None
        closure9(v630, ("" + "; ") + "", None)
        v672 = None
        v681: None
        closure9(v630, ("" + "new_path") + "", None)
        v681 = None
        v689: None
        closure9(v630, ("" + " = ") + "", None)
        v689 = None
        v697: None
        closure9(v630, ("" + v628) + "", None)
        v697 = None
        v705: None
        closure9(v630, ("" + "; ") + "", None)
        v705 = None
        v714: None
        closure9(v630, ("" + "ex") + "", None)
        v714 = None
        v722: None
        closure9(v630, ("" + " = ") + "", None)
        v722 = None
        v757: None
        closure9(v630, ("" + to_text(interpolate("%A%P()", [v2_1]))) + "", None)
        v757 = None
        v766: None
        closure9(v630, ("" + " }") + "", None)
        v766 = None
        v769: str = v630.l0
        v808: str = trim_end(trim_start(((((((((("" + v414) + " ") + v615) + " #") + str(v626)) + " ") + closure31(None, None)) + " / ") + v769) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v808)
        pattern_input[1].l0(v808)



def method20(v0_1: str, v1_1: str, v2_1: int64) -> Async[int64]:
    return None


def closure29(v0_1: str, v1_1: str) -> Async[int64]:
    return None


def closure28(unit_var: None, v0_1: str) -> Callable[[str], Async[int64]]:
    def _arrow294(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[int64]:
        return closure29(v0_1, v)

    return _arrow294


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
    class ObjectExpr295:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v59, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr295()))):
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
        def _arrow296(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> Any:
            v380: Any = create(op_subtraction(ticks_1(now()), v366.fields[0]))
            return create_1(1, 1, 1, hours(v380), minutes(v380), seconds(v380), milliseconds(v380))

        v411: str = to_string(_arrow296() if (v366.tag == 0) else now(), method10())
        v612: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method11()
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
    class ObjectExpr297:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (4 >= find(v60, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr297()))):
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
        def _arrow298(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v381: Any = create(op_subtraction(ticks_1(now()), v367.fields[0]))
            return create_1(1, 1, 1, hours(v381), minutes(v381), seconds(v381), milliseconds(v381))

        v412: str = to_string(_arrow298() if (v367.tag == 0) else now(), method10())
        v613: str = ("\u001b[91m" + pad_left("Critical".lower(), 7, " ")) + method11()
        v624: int64 = pattern_input_2[0].l0
        v638: str = to_text(interpolate("%A%P()", [v0_1]))
        v648: Mut4 = Mut4(method13())
        v655: None
        closure9(v648, ("" + "{ ") + "", None)
        v655 = None
        v664: None
        closure9(v648, ("" + "timeout") + "", None)
        v664 = None
        v673: None
        closure9(v648, ("" + " = ") + "", None)
        v673 = None
        v681: None
        closure9(v648, ("" + str(1000)) + "", None)
        v681 = None
        v690: None
        closure9(v648, ("" + "; ") + "", None)
        v690 = None
        v699: None
        closure9(v648, ("" + "ex") + "", None)
        v699 = None
        v707: None
        closure9(v648, ("" + " = ") + "", None)
        v707 = None
        v715: None
        closure9(v648, ("" + v638) + "", None)
        v715 = None
        v724: None
        closure9(v648, ("" + " }") + "", None)
        v724 = None
        v727: str = v648.l0
        v766: str = trim_end(trim_start(((((((((("" + v412) + " ") + v613) + " #") + str(v624)) + " ") + closure38(None, None)) + " / ") + v727) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v766)
        pattern_input[1].l0(v766)



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
    class ObjectExpr299:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr299()))):
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
        def _arrow300(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v382: Any = create(op_subtraction(ticks_1(now()), v368.fields[0]))
            return create_1(1, 1, 1, hours(v382), minutes(v382), seconds(v382), milliseconds(v382))

        v413: str = to_string(_arrow300() if (v368.tag == 0) else now(), method10())
        v614: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method11()
        v625: int64 = pattern_input_2[0].l0
        v627: Mut4 = Mut4(method13())
        v634: None
        closure9(v627, ("" + "{ ") + "", None)
        v634 = None
        v643: None
        closure9(v627, ("" + "retry") + "", None)
        v643 = None
        v652: None
        closure9(v627, ("" + " = ") + "", None)
        v652 = None
        v660: None
        closure9(v627, ("" + str(v0_1)) + "", None)
        v660 = None
        v669: None
        closure9(v627, ("" + "; ") + "", None)
        v669 = None
        v678: None
        closure9(v627, ("" + "ex") + "", None)
        v678 = None
        v686: None
        closure9(v627, ("" + " = ") + "", None)
        v686 = None
        v694: None
        closure9(v627, ("" + v1_1) + "", None)
        v694 = None
        v703: None
        closure9(v627, ("" + " }") + "", None)
        v703 = None
        v706: str = v627.l0
        v745: str = trim_end(trim_start(((((((((("" + v413) + " ") + v614) + " #") + str(v625)) + " ") + closure40(None, None)) + " / ") + v706) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v745)
        pattern_input[1].l0(v745)



def method21(v0_1: str, v1_1: int64) -> Async[str | None]:
    return None


def closure32(unit_var: None, v0_1: str) -> Async[str | None]:
    return None


def closure42(v0_1: FSharpRef[US11 | None], v1_1: US11 | None=None) -> FSharpRef[US11 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure43(v0_1: chrono_date_time_1[chrono_utc] | None, v1_1: Callable[[US11 | None], FSharpRef[US11 | None]], unit_var: None) -> None:
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
    v438: str = to_string(v1_1, method25())
    v507: Any
    raise Exception(("date_time.get_utc_offset / target: " + str(US5(4, US4(0)))) + "")
    v518: uint8 = uint8(1) if (hours(v507) > 0) else uint8(0)
    v519: str = method26()
    v530: str = ((("" + str(v518)) + "") + to_string_1(v507, "c", {})) + ""
    v532: str = str(v0_1)
    return parse(((((("" + v438) + "") + v530) + "") + v532[len(v438) + len(v530):len(v532)]) + "")


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
    v31_1: Any = now()
    return method27(method23(new_guid(), v31_1))


def closure41(unit_var: None, unit_var_1: None) -> str:
    return method22()


def method36(v0_1: str) -> str:
    return v0_1


def closure45(unit_var: None, v0_1: std_io_error) -> std_string_string:
    return None


def method37(__unit: None=None) -> Callable[[std_io_error], std_string_string]:
    def _arrow302(v: std_io_error) -> std_string_string:
        return closure45(None, v)

    return _arrow302


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
    class ObjectExpr303:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (4 >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr303()))):
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
        def _arrow304(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v382: Any = create(op_subtraction(ticks_1(now()), v368.fields[0]))
            return create_1(1, 1, 1, hours(v382), minutes(v382), seconds(v382), milliseconds(v382))

        v413: str = to_string(_arrow304() if (v368.tag == 0) else now(), method10())
        v614: str = ("\u001b[91m" + pad_left("Critical".lower(), 7, " ")) + method11()
        v625: int64 = pattern_input_2[0].l0
        v627: Mut4 = Mut4(method13())
        v634: None
        closure9(v627, ("" + "{ ") + "", None)
        v634 = None
        v643: None
        closure9(v627, ("" + "dir") + "", None)
        v643 = None
        v652: None
        closure9(v627, ("" + " = ") + "", None)
        v652 = None
        v660: None
        closure9(v627, ("" + v0_1) + "", None)
        v660 = None
        v669: None
        closure9(v627, ("" + "; ") + "", None)
        v669 = None
        v678: None
        closure9(v627, ("" + "error") + "", None)
        v678 = None
        v686: None
        closure9(v627, ("" + " = ") + "", None)
        v686 = None
        v721: None
        closure9(v627, ("" + to_text(interpolate("%A%P()", [v1_1]))) + "", None)
        v721 = None
        v730: None
        closure9(v627, ("" + " }") + "", None)
        v730 = None
        v733: str = v627.l0
        v772: str = trim_end(trim_start(((((((((("" + v413) + " ") + v614) + " #") + str(v625)) + " ") + closure49(None, None)) + " / ") + v733) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v772)
        pattern_input[1].l0(v772)



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
    class ObjectExpr305:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v60, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr305()))):
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
        def _arrow306(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v381: Any = create(op_subtraction(ticks_1(now()), v367.fields[0]))
            return create_1(1, 1, 1, hours(v381), minutes(v381), seconds(v381), milliseconds(v381))

        v412: str = to_string(_arrow306() if (v367.tag == 0) else now(), method10())
        v613: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method11()
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


def method38(v0_1: str) -> Callable[[], None]:
    def _arrow307(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure52(v0_1, None)

    return _arrow307


def method39(v0_1: str) -> Callable[[], None]:
    def _arrow308(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure52(v0_1, None)

    return _arrow308


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
    class ObjectExpr309:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v61, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr309()))):
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
        def _arrow310(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v382: Any = create(op_subtraction(ticks_1(now()), v368.fields[0]))
            return create_1(1, 1, 1, hours(v382), minutes(v382), seconds(v382), milliseconds(v382))

        v413: str = to_string(_arrow310() if (v368.tag == 0) else now(), method10())
        v614: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method11()
        v625: int64 = pattern_input_2[0].l0
        v627: Mut4 = Mut4(method13())
        v634: None
        closure9(v627, ("" + "{ ") + "", None)
        v634 = None
        v643: None
        closure9(v627, ("" + "dir") + "", None)
        v643 = None
        v652: None
        closure9(v627, ("" + " = ") + "", None)
        v652 = None
        v660: None
        closure9(v627, ("" + v0_1) + "", None)
        v660 = None
        v669: None
        closure9(v627, ("" + "; ") + "", None)
        v669 = None
        v678: None
        closure9(v627, ("" + "result") + "", None)
        v678 = None
        v686: None
        closure9(v627, ("" + " = ") + "", None)
        v686 = None
        v694: None
        closure9(v627, ("" + v1_1) + "", None)
        v694 = None
        v703: None
        closure9(v627, ("" + " }") + "", None)
        v703 = None
        v706: str = v627.l0
        v745: str = trim_end(trim_start(((((((((("" + v413) + " ") + v614) + " #") + str(v625)) + " ") + closure54(None, None)) + " / ") + v706) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v745)
        pattern_input[1].l0(v745)



def closure55(v0_1: str, unit_var: None) -> None:
    pass


def method40(v0_1: str) -> Callable[[], None]:
    def _arrow311(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure55(v0_1, None)

    return _arrow311


def method41(v0_1: str) -> Callable[[], None]:
    def _arrow312(__unit: None=None, v0_1: Any=v0_1) -> None:
        closure55(v0_1, None)

    return _arrow312


def method35(v0_1: str) -> IDisposable:
    v2467: bool = None
    if v2467 == False:
        v2501: None
        closure53(v0_1, to_text(interpolate("%A%P()", [{
            "CreationTime": None,
            "Exists": v2467
        }])), None)
        v2501 = None

    v3278: Callable[[], None] = method41(v0_1)
    class ObjectExpr313(IDisposable):
        def Dispose(self, __unit: None=None, v0_1: Any=v0_1) -> None:
            v3278(None)

    return ObjectExpr313()


def closure44(unit_var: None, unit_var_1: None) -> tuple[str, IDisposable]:
    v0_1: str = method22()
    return (v0_1, method35(v0_1))


def method42(v0_1: str) -> str:
    v56: str = pad_left(v0_1, 32, "0")
    return parse(((((((((("" + v56[0:7 + 1]) + "-") + v56[8:11 + 1]) + "-") + v56[12:15 + 1]) + "-") + v56[16:19 + 1]) + "-") + v56[20:31 + 1]) + "")


def closure56(unit_var: None, v0_1: str) -> tuple[str, IDisposable]:
    v2_1: str = method27(method42(v0_1))
    return (v2_1, method35(v2_1))


def closure57(unit_var: None, unit_var_1: None) -> str:
    return "C:\\home\\git\\polyglot\\lib\\spiral"


def method44(v0_1: str) -> str:
    return v0_1


def method43(v0_1: str) -> str:
    if v0_1 == "":
        return ""

    else: 
        v30_1: str = None
        def _arrow314(__unit: None=None, v0_1: Any=v0_1) -> str:
            _arg: str = v30_1[0]
            return _arg.lower()

        return replace(((("" + _arrow314()) + "") + v30_1[1:len(v30_1)]) + "", "\\", "/")



def closure58(unit_var: None, v0_1: str) -> str:
    return method43(v0_1)


def closure59(unit_var: None, v0_1: str) -> str:
    return ("file:///" + trim_start(v0_1, *to_array(singleton("/")))) + ""


def method47(v0_1: str) -> str | None:
    v85: US1 = None
    if v85.tag == 0:
        return v85.fields[0]

    else: 
        return None



def closure61(unit_var: None, v0_1: str) -> str | None:
    return method47(v0_1)


def method46(__unit: None=None) -> Callable[[str], str | None]:
    def _arrow315(v: str) -> str | None:
        return closure61(None, v)

    return _arrow315


def method48(v0_1_mut: str, v1_1_mut: str, v2_1_mut: str) -> US13:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if method8(method30(v2_1, v0_1)):
            return US13(0, v2_1)

        else: 
            v7: str | None = method46()(v2_1)
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


def method45(v0_1: str, v1_1: str) -> US13:
    if method8(method30(v1_1, v0_1)):
        return US13(0, v1_1)

    else: 
        v6: str | None = method46()(v1_1)
        _v7: FSharpRef[US1 | None] = FSharpRef(None)
        v12: None
        def v9(v: US1 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> FSharpRef[US1 | None]:
            return closure1(_v7, v)

        closure2(v6, v9, None)
        v12 = None
        v27_1: US1 = default_arg(_v7.contents, US1(1))
        if v27_1.tag == 0:
            return method48(v0_1, v1_1, v27_1.fields[0])

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
    class ObjectExpr316:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v60, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr316()))):
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
        def _arrow317(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v381: Any = create(op_subtraction(ticks_1(now()), v367.fields[0]))
            return create_1(1, 1, 1, hours(v381), minutes(v381), seconds(v381), milliseconds(v381))

        v412: str = to_string(_arrow317() if (v367.tag == 0) else now(), method10())
        v613: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method11()
        v624: int64 = pattern_input_2[0].l0
        v626: Mut4 = Mut4(method13())
        v633: None
        closure9(v626, ("" + "{ ") + "", None)
        v633 = None
        v642: None
        closure9(v626, ("" + "error") + "", None)
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
        v710: str = trim_end(trim_start(((((((((("" + v412) + " ") + v613) + " #") + str(v624)) + " ") + closure63(None, None)) + " / ") + v671) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure11(None, v710)
        pattern_input[1].l0(v710)



def method49(__unit: None=None) -> str:
    return None


def closure60(unit_var: None, unit_var_1: None) -> str:
    v4: US13 = method45(method30("polyglot", ".devcontainer"), "C:\\home\\git\\polyglot\\lib\\spiral")
    v746: US1
    if v4.tag == 0:
        v746 = US1(0, v4.fields[0])

    else: 
        v10: None
        closure62(v4.fields[0], None)
        v10 = None
        v746 = US1(1)

    v1495: US1
    if v746.tag == 0:
        v1495 = US1(0, v746.fields[0])

    else: 
        v749: str = method49()
        v751: US13 = method45(method30("polyglot", ".devcontainer"), v749)
        if v751.tag == 0:
            v1495 = US1(0, v751.fields[0])

        else: 
            v757: None
            closure62(v751.fields[0], None)
            v757 = None
            v1495 = US1(1)


    def _arrow318(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> str:
        raise Exception("Option does not have a value.")

    return method30(v1495.fields[0] if (v1495.tag == 0) else _arrow318(), "polyglot")


def method50(v0_1: str) -> None:
    pass


def closure65(unit_var: None, v0_1: str) -> None:
    method50(v0_1)


def closure64(unit_var: None, v0_1: bool) -> None:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = value_3(State_trace_state())
    def _arrow319(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure65(None, v)

    def _arrow320(v_1: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> None:
        closure3(None, v_1)

    v33_1: Callable[[str], None] = _arrow319 if v0_1 else _arrow320
    pattern_input[1].l0 = v33_1


def closure67(v0_1: str, v1_1: str) -> str:
    return method30(v0_1, v1_1)


def closure66(unit_var: None, v0_1: str) -> Callable[[str], str]:
    def _arrow321(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> str:
        return closure67(v0_1, v)

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


v15: Callable[[str], Async[int64]] = _arrow324

def delete_directory_async(x: str) -> Async[int64]:
    return v15(x)


def _arrow325(v: US6) -> Callable[[str], Async[int64]]:
    return closure13(None, v)


v16: Callable[[US6, str], Async[int64]] = _arrow325

def wait_for_file_access(x: US6) -> Callable[[str], Async[int64]]:
    return v16(x)


def _arrow326(v: str) -> Async[int64]:
    return closure17(None, v)


v17: Callable[[str], Async[int64]] = _arrow326

def wait_for_file_access_read(x: str) -> Async[int64]:
    return v17(x)


def _arrow327(v: str) -> Async[str]:
    return closure18(None, v)


v18: Callable[[str], Async[str]] = _arrow327

def read_all_text_async(x: str) -> Async[str]:
    return v18(x)


def _arrow328(v: str) -> Callable[[str], bool]:
    return closure19(None, v)


v19: Callable[[str, str], bool] = _arrow328

def file_exists_content(x: str) -> Callable[[str], bool]:
    return v19(x)


def _arrow329(v: str) -> Callable[[str], Async[None]]:
    return closure21(None, v)


v20: Callable[[str, str], Async[None]] = _arrow329

def write_all_text_async(x: str) -> Callable[[str], Async[None]]:
    return v20(x)


def _arrow330(v: str) -> Callable[[str], Async[None]]:
    return closure23(None, v)


v21: Callable[[str, str], Async[None]] = _arrow330

def write_all_text_exists(x: str) -> Callable[[str], Async[None]]:
    return v21(x)


def _arrow331(v: str) -> Async[int64]:
    return closure25(None, v)


v22: Callable[[str], Async[int64]] = _arrow331

def delete_file_async(x: str) -> Async[int64]:
    return v22(x)


def _arrow332(v: str) -> Callable[[str], Async[int64]]:
    return closure28(None, v)


v23: Callable[[str, str], Async[int64]] = _arrow332

def move_file_async(x: str) -> Callable[[str], Async[int64]]:
    return v23(x)


def _arrow333(v: str) -> Async[str | None]:
    return closure32(None, v)


v24: Callable[[str], Async[str | None]] = _arrow333

def read_all_text_retry_async(x: str) -> Async[str | None]:
    return v24(x)


def _arrow334(__unit: None=None) -> str:
    return closure41(None, None)


v25: Callable[[], str] = _arrow334

def create_temp_path(__unit: None=None) -> str:
    return v25(None)


def _arrow335(__unit: None=None) -> tuple[str, IDisposable]:
    return closure44(None, None)


v26: Callable[[], tuple[str, IDisposable]] = _arrow335

def create_temp_dir(__unit: None=None) -> tuple[str, IDisposable]:
    return v26(None)


def _arrow336(v: str) -> tuple[str, IDisposable]:
    return closure56(None, v)


v27: Callable[[str], tuple[str, IDisposable]] = _arrow336

def create_temp_dir_0027(x: str) -> tuple[str, IDisposable]:
    return v27(x)


def _arrow337(__unit: None=None) -> str:
    return closure57(None, None)


v28: Callable[[], str] = _arrow337

def get_source_directory(__unit: None=None) -> str:
    return v28(None)


def _arrow338(v: str) -> str:
    return closure58(None, v)


v29: Callable[[str], str] = _arrow338

def normalize_path(x: str) -> str:
    return v29(x)


def _arrow339(v: str) -> str:
    return closure59(None, v)


v30: Callable[[str], str] = _arrow339

def new_file_uri(x: str) -> str:
    return v30(x)


def _arrow340(__unit: None=None) -> str:
    return closure60(None, None)


v31: Callable[[], str] = _arrow340

def get_workspace_root(__unit: None=None) -> str:
    return v31(None)


def _arrow341(v: bool) -> None:
    closure64(None, v)


v32: Callable[[bool], None] = _arrow341

def init_trace_file(x: bool) -> None:
    v32(x)


def _arrow342(v: str) -> Callable[[str], str]:
    return closure66(None, v)


v33: Callable[[str, str], str] = _arrow342

def op_less_divide_greater(x: str) -> Callable[[str], str]:
    return v33(x)


