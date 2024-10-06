from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.array_ import fill
from fable_modules.fable_library.async_builder import (Async, CancellationToken)
from fable_modules.fable_library.date import (ticks as ticks_1, now, to_string, create as create_1)
from fable_modules.fable_library.list import (to_array, empty, of_array, FSharpList, fold_back, cons, item, length)
from fable_modules.fable_library.long import (op_subtraction, op_addition)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_12, default_arg, map)
from fable_modules.fable_library.range import range_big_int
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type, char_type, class_type, int32_type, tuple_type, option_type, array_type)
from fable_modules.fable_library.result import FSharpResult_2
from fable_modules.fable_library.seq import (delay, map as map_1)
from fable_modules.fable_library.string_ import (trim_end, trim_start, to_text, interpolate, replicate, join)
from fable_modules.fable_library.system_text import (StringBuilder__Clear, StringBuilder__Append_Z721C83C5, StringBuilder__ctor_Z721C83C5)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record)
from fable_modules.fable_library.util import (create_atom, to_enumerable, compare, uncurry2, IEnumerable_1)

TraceState_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr180() -> TypeInfo:
    return union_type("Runtime.US0", [], US0, lambda: [[], [], [], [], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1", "US0_2", "US0_3", "US0_4"]


US0_reflection = _expr180

def _expr181() -> TypeInfo:
    return record_type("Runtime.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr181

def _expr182() -> TypeInfo:
    return record_type("Runtime.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr182

def _expr183() -> TypeInfo:
    return record_type("Runtime.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr183

def _expr184() -> TypeInfo:
    return record_type("Runtime.Mut3", [], Mut3, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: str

Mut3_reflection = _expr184

def _expr185() -> TypeInfo:
    return record_type("Runtime.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr185

def _expr186() -> TypeInfo:
    return union_type("Runtime.US1", [], US1, lambda: [[("f0_0", string_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr186

def _expr187() -> TypeInfo:
    return union_type("Runtime.US2", [], US2, lambda: [[("f0_0", US0_reflection())], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr187

def _expr188() -> TypeInfo:
    return union_type("Runtime.US3", [], US3, lambda: [[("f0_0", int64_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr188

def _expr189() -> TypeInfo:
    return union_type("Runtime.US4", [], US4, lambda: [[("f0_0", string_type), ("f0_1", US1_reflection())], [("f1_0", string_type)]])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1"]


US4_reflection = _expr189

def _expr190() -> TypeInfo:
    return union_type("Runtime.US5", [], US5, lambda: [[("f0_0", char_type), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr190

def _expr191() -> TypeInfo:
    return record_type("Runtime.Mut5", [], Mut5, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut5(Record):
    l0: int

Mut5_reflection = _expr191

def _expr192() -> TypeInfo:
    return union_type("Runtime.UH0", [], UH0, lambda: [[], [("Item1", char_type), ("Item2", UH0_reflection())]])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr192

def _expr193() -> TypeInfo:
    return union_type("Runtime.UH1", [], UH1, lambda: [[], [("Item1", lambda_type(tuple_type(string_type, class_type("System.Text.StringBuilder"), int32_type, int32_type), US5_reflection())), ("Item2", UH1_reflection())]])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr193

def _expr194() -> TypeInfo:
    return union_type("Runtime.US6", [], US6, lambda: [[("f0_0", string_type), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1"]


US6_reflection = _expr194

def _expr195() -> TypeInfo:
    return union_type("Runtime.US7", [], US7, lambda: [[("f0_0", char_type)], []])


class US7(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US7_0", "US7_1"]


US7_reflection = _expr195

def _expr196() -> TypeInfo:
    return union_type("Runtime.US8", [], US8, lambda: [[("f0_0", string_type), ("f0_1", class_type("System.Text.StringBuilder")), ("f0_2", int32_type), ("f0_3", int32_type)], [("f1_0", string_type)]])


class US8(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US8_0", "US8_1"]


US8_reflection = _expr196

def _expr197() -> TypeInfo:
    return union_type("Runtime.US9", [], US9, lambda: [[("f0_0", string_type), ("f0_1", US1_reflection()), ("f0_2", string_type), ("f0_3", class_type("System.Text.StringBuilder")), ("f0_4", int32_type), ("f0_5", int32_type)], [("f1_0", string_type)]])


class US9(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US9_0", "US9_1"]


US9_reflection = _expr197

def _expr198() -> TypeInfo:
    return union_type("Runtime.US10", [], US10, lambda: [[("f0_0", US7_reflection()), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US10(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US10_0", "US10_1"]


US10_reflection = _expr198

def _expr199() -> TypeInfo:
    return union_type("Runtime.US11", [], US11, lambda: [[("f0_0", US1_reflection()), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US11(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US11_0", "US11_1"]


US11_reflection = _expr199

def _expr200() -> TypeInfo:
    return union_type("Runtime.US12", [], US12, lambda: [[("f0_0", lambda_type(tuple_type(int32_type, string_type, bool_type), class_type("Microsoft.FSharp.Control.FSharpAsync`1", [unit_type])))], []])


class US12(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US12_0", "US12_1"]


US12_reflection = _expr200

def _expr201() -> TypeInfo:
    return union_type("Runtime.US13", [], US13, lambda: [[("f0_0", class_type("System.Threading.CancellationToken"))], []])


class US13(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US13_0", "US13_1"]


US13_reflection = _expr201

def _expr202() -> TypeInfo:
    return record_type("Runtime.Heap0", [], Heap0, lambda: [("l0", string_type), ("l1", option_type(class_type("System.Threading.CancellationToken"))), ("l2", array_type(tuple_type(string_type, string_type))), ("l3", option_type(lambda_type(tuple_type(int32_type, string_type, bool_type), class_type("Microsoft.FSharp.Control.FSharpAsync`1", [unit_type])))), ("l4", option_type(lambda_type(class_type("Runtime.std_sync_Arc`1", [class_type("Runtime.std_sync_Mutex`1", [class_type("Runtime.std_process_ChildStdin")])]), unit_type))), ("l5", bool_type), ("l6", option_type(string_type))])


@dataclass(eq = False, repr = False, slots = True)
class Heap0(Record):
    l0: str
    l1: CancellationToken | None
    l2: Array[tuple[str, str]]
    l3: Callable[[tuple[int, str, bool]], Async[None]] | None
    l4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None
    l5: bool
    l6: str | None

Heap0_reflection = _expr202

def _expr203() -> TypeInfo:
    return union_type("Runtime.US14", [], US14, lambda: [[("f0_0", array_type(string_type))], [("f1_0", string_type)]])


class US14(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US14_0", "US14_1"]


US14_reflection = _expr203

def _expr204() -> TypeInfo:
    return union_type("Runtime.UH2", [], UH2, lambda: [[], [("Item1", string_type), ("Item2", UH2_reflection())]])


class UH2(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH2_0", "UH2_1"]


UH2_reflection = _expr204

def _expr205() -> TypeInfo:
    return union_type("Runtime.US15", [], US15, lambda: [[("f0_0", UH2_reflection()), ("f0_1", string_type), ("f0_2", class_type("System.Text.StringBuilder")), ("f0_3", int32_type), ("f0_4", int32_type)], [("f1_0", string_type)]])


class US15(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US15_0", "US15_1"]


US15_reflection = _expr205

def _expr206() -> TypeInfo:
    return union_type("Runtime.UH3", [], UH3, lambda: [[], [("Item1", lambda_type(tuple_type(string_type, class_type("System.Text.StringBuilder"), int32_type, int32_type), US6_reflection())), ("Item2", UH3_reflection())]])


class UH3(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH3_0", "UH3_1"]


UH3_reflection = _expr206

def method1(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method3(__unit: None=None) -> str:
    return ""


def closure1(unit_var: None, v0_1: str) -> US1:
    return US1(0, v0_1)


def method4(__unit: None=None) -> Callable[[str], US1]:
    def _arrow207(v: str) -> US1:
        return closure1(None, v)

    return _arrow207


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
        v61 = value_12(_v56)

    v77: US1 = default_arg(map(method4(), v61), US1(1))
    if v77.tag == 0:
        return v77.fields[0]

    else: 
        return ""



def method5(__unit: None=None) -> str:
    return "AUTOMATION"


def closure2(unit_var: None, v0_1: str) -> None:
    pass


def method0(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None]:
    v230: str = method2(method1())
    v235: US2 = US2(0, US0(0)) if ("Verbose" == v230) else US2(1)
    def _arrow208(__unit: None=None, v0_1: Any=v0_1) -> US2:
        v242: US2 = US2(0, US0(1)) if ("Debug" == v230) else US2(1)
        if v242.tag == 0:
            return US2(0, v242.fields[0])

        else: 
            v249: US2 = US2(0, US0(2)) if ("Info" == v230) else US2(1)
            if v249.tag == 0:
                return US2(0, v249.fields[0])

            else: 
                v256: US2 = US2(0, US0(3)) if ("Warning" == v230) else US2(1)
                if v256.tag == 0:
                    return US2(0, v256.fields[0])

                else: 
                    v263: US2 = US2(0, US0(4)) if ("Critical" == v230) else US2(1)
                    return US2(0, v263.fields[0]) if (v263.tag == 0) else US2(1)




    _v1: tuple[US2, US3] = (US2(0, v235.fields[0]) if (v235.tag == 0) else _arrow208(), US3(0, ticks_1(now())) if (method2(method5()) == "True") else US3(1))
    v352: US3 = _v1[1]
    v351: US2 = _v1[0]
    def v417(v: str, v0_1: Any=v0_1) -> None:
        closure2(None, v)

    return (Mut0(int64(1)), Mut1(v417), Mut2(True), Mut3(""), Mut4(v351.fields[0] if (v351.tag == 0) else v0_1), v352.fields[0] if (v352.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = method0(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def method6(v0_1: US0) -> bool:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v35: US0 = pattern_input[4].l0
    if pattern_input[2].l0 == False:
        return False

    else: 
        class ObjectExpr209:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        class ObjectExpr210:
            @property
            def Compare(self) -> Callable[[US0, US0], int]:
                return compare

        return find(v0_1, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr209())) >= find(v35, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr210()))



def closure6(unit_var: None, v0_1: int64) -> US3:
    return US3(0, v0_1)


def method8(__unit: None=None) -> Callable[[int64], US3]:
    def _arrow211(v: int64) -> US3:
        return closure6(None, v)

    return _arrow211


def method9(__unit: None=None) -> str:
    return "hh:mm:ss"


def method10(__unit: None=None) -> str:
    return "HH:mm:ss"


def method7(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None=None) -> str:
    v238: US3 = default_arg(map(method8(), v5), US3(1))
    def _arrow212(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4, v5: Any=v5) -> Any:
        v252: Any = create(op_subtraction(ticks_1(now()), v238.fields[0]))
        return create_1(1, 1, 1, hours(v252), minutes(v252), seconds(v252), milliseconds(v252))

    return to_string(_arrow212() if (v238.tag == 0) else now(), method10())


def method13(__unit: None=None) -> str:
    return ""


def closure7(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def method12(v0_1: str) -> str:
    v2_1: Mut3 = Mut3(method13())
    v8: None
    closure7(v2_1, ("" + str(v0_1)) + "", None)
    v8 = None
    return v2_1.l0


def method14(__unit: None=None) -> str:
    return "\u001b[0m"


def method11(__unit: None=None) -> str:
    v2_1: str = "Warning".lower()
    return ("\u001b[93m" + method12(v2_1[0])) + method14()


def method16(__unit: None=None) -> str:
    v1_1: Mut3 = Mut3(method13())
    return v1_1.l0


def method17(v0_1: str) -> str:
    return trim_end(trim_start(v0_1, *to_array(empty())), *to_array(of_array([" ", "/"])))


def method15(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str) -> str:
    v8: str = method16()
    return method17(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "runtime.current_process_kill / exiting... 3") + " / ") + v8) + "")


def closure8(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure10(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure9(unit_var: None, v0_1: str) -> None:
    v3: None
    closure10(v0_1, None)
    v3 = None


def method18(v0_1: str) -> None:
    v3: None
    closure0(None, None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v37: None
    closure8(pattern_input[0], None)
    v37 = None
    closure9(None, v0_1)
    pattern_input[1].l0(v0_1)


def closure5(unit_var: None, unit_var_1: None) -> None:
    if method6(US0(3)):
        v4: None
        closure0(None, None)
        v4 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        v23: int64 | None = pattern_input[5]
        v22: Mut4 = pattern_input[4]
        v21: Mut3 = pattern_input[3]
        v20_1: Mut2 = pattern_input[2]
        v19_1: Mut1 = pattern_input[1]
        v18_1: Mut0 = pattern_input[0]
        method18(method15(v18_1, v19_1, v20_1, v21, v22, v23, method7(v18_1, v19_1, v20_1, v21, v22, v23), method11()))



def method19(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str) -> str:
    v8: str = method16()
    return method17(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "runtime.current_process_kill / exiting... 2") + " / ") + v8) + "")


def closure11(unit_var: None, unit_var_1: None) -> None:
    if method6(US0(3)):
        v4: None
        closure0(None, None)
        v4 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        v23: int64 | None = pattern_input[5]
        v22: Mut4 = pattern_input[4]
        v21: Mut3 = pattern_input[3]
        v20_1: Mut2 = pattern_input[2]
        v19_1: Mut1 = pattern_input[1]
        v18_1: Mut0 = pattern_input[0]
        method18(method19(v18_1, v19_1, v20_1, v21, v22, v23, method7(v18_1, v19_1, v20_1, v21, v22, v23), method11()))



def method20(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str) -> str:
    v8: str = method16()
    return method17(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "runtime.current_process_kill / exiting... 1") + " / ") + v8) + "")


def closure12(unit_var: None, unit_var_1: None) -> None:
    if method6(US0(3)):
        v4: None
        closure0(None, None)
        v4 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        v23: int64 | None = pattern_input[5]
        v22: Mut4 = pattern_input[4]
        v21: Mut3 = pattern_input[3]
        v20_1: Mut2 = pattern_input[2]
        v19_1: Mut1 = pattern_input[1]
        v18_1: Mut0 = pattern_input[0]
        method18(method20(v18_1, v19_1, v20_1, v21, v22, v23, method7(v18_1, v19_1, v20_1, v21, v22, v23), method11()))



def closure4(unit_var: None, unit_var_1: None) -> None:
    pass


def closure3(unit_var: None, unit_var_1: None) -> None:
    pass


def method23(v0_1: int, v1_1: Mut5) -> bool:
    return v1_1.l0 < v0_1


def closure16(v0_1: str, v1_1: UH0) -> UH0:
    return UH0(1, v0_1, v1_1)


def closure15(unit_var: None, v0_1: str) -> Callable[[UH0], UH0]:
    def _arrow213(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure16(v0_1, v)

    return _arrow213


def method24(__unit: None=None) -> Callable[[str, UH0], UH0]:
    def _arrow214(v: str) -> Callable[[UH0], UH0]:
        return closure15(None, v)

    return _arrow214


def method25(v0_1_mut: UH0, v1_1_mut: Any, v2_1_mut: int, v3_mut: int) -> tuple[Any, int, int]:
    while True:
        (v0_1, v1_1, v2_1, v3) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut)
        if v0_1.tag == 0:
            return (v1_1, v2_1, v3)

        else: 
            v4: str = v0_1.fields[0]
            v6: bool = "\n" == v4
            pattern_input: tuple[int, int] = ((v2_1 + 1, 1)) if v6 else ((v2_1, v3 + 1))
            v0_1_mut = v0_1.fields[1]
            def _arrow215(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3) -> Any:
                v12: Any = StringBuilder__Clear(v1_1)
                return v1_1

            def _arrow216(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3) -> Any:
                v18_1: Any = StringBuilder__Append_Z721C83C5(v1_1, v4)
                return v1_1

            v1_1_mut = _arrow215() if v6 else _arrow216()
            v2_1_mut = pattern_input[0]
            v3_mut = pattern_input[1]
            continue

        break


def closure14(unit_var: None, _arg: tuple[str, Any, int, int]) -> US5:
    v3: int = _arg[3] or 0
    v2_1: int = _arg[2] or 0
    v1_1: Any = _arg[1]
    v0_1: str = _arg[0]
    if "" == v0_1:
        return US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v1_1, v2_1, v3)])))

    else: 
        v7: str = v0_1[0]
        if v7 == "\"":
            v10: int = len(v0_1) or 0
            v15: str = v0_1[1:v10 + 1]
            v17_1: str = v7
            v20_1: int = len(v17_1) or 0
            v21: Array[str] = fill([0] * v20_1, 0, v20_1, "")
            v22: Mut5 = Mut5(0)
            while method23(v20_1, v22):
                v24: int = v22.l0 or 0
                v25: str = v17_1[v24]
                v21[v24] = v25
                v26: int = (v24 + 1) or 0
                v22.l0 = v26 or 0
            v27: FSharpList[str] = of_array(v21)
            pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v27, UH0(0)), v1_1, v2_1, v3)
            return US5(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v43: int = len(v0_1) or 0
            v46: int = (v0_1.find("\n") - 1) or 0
            v48: int = (v43 if (-2 == v46) else v46) or 0
            return US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\"")) + "\' / line: ") + str(v2_1)) + " / col: ") + str(v3)) + "\n") + str(v1_1)) + "") + v0_1[0:v48 + 1]) + "")) + "\n") + (replicate(v3 - 1, " ") + "^")) + "\n")




def closure17(unit_var: None, _arg: tuple[str, Any, int, int]) -> US5:
    v3: int = _arg[3] or 0
    v2_1: int = _arg[2] or 0
    v1_1: Any = _arg[1]
    v0_1: str = _arg[0]
    if "" == v0_1:
        return US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v1_1, v2_1, v3)])))

    else: 
        v7: str = v0_1[0]
        if v7 == "\'":
            v10: int = len(v0_1) or 0
            v15: str = v0_1[1:v10 + 1]
            v17_1: str = v7
            v20_1: int = len(v17_1) or 0
            v21: Array[str] = fill([0] * v20_1, 0, v20_1, "")
            v22: Mut5 = Mut5(0)
            while method23(v20_1, v22):
                v24: int = v22.l0 or 0
                v25: str = v17_1[v24]
                v21[v24] = v25
                v26: int = (v24 + 1) or 0
                v22.l0 = v26 or 0
            v27: FSharpList[str] = of_array(v21)
            pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v27, UH0(0)), v1_1, v2_1, v3)
            return US5(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v43: int = len(v0_1) or 0
            v46: int = (v0_1.find("\n") - 1) or 0
            v48: int = (v43 if (-2 == v46) else v46) or 0
            return US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\'")) + "\' / line: ") + str(v2_1)) + " / col: ") + str(v3)) + "\n") + str(v1_1)) + "") + v0_1[0:v48 + 1]) + "")) + "\n") + (replicate(v3 - 1, " ") + "^")) + "\n")




def method26(v0_1_mut: str, v1_1_mut: Any, v2_1_mut: UH1) -> US5:
    while True:
        (v0_1, v1_1, v2_1) = (v0_1_mut, v1_1_mut, v2_1_mut)
        if v2_1.tag == 0:
            return US5(1, "choice / no parsers succeeded")

        else: 
            v7: US5 = v2_1.fields[0]((v0_1, v1_1, 1, 1))
            if v7.tag == 0:
                return v7

            else: 
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1.fields[1]
                continue


        break


def method27(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(2):
            return False

        else: 
            v11: US7
            if v1_1 == int64(0):
                v11 = US7(0, "\"")

            else: 
                v5: int64 = op_subtraction(v1_1, int64(1))
                if v5 == int64(0):
                    v11 = US7(0, "\'")

                else: 
                    v8: int64 = op_subtraction(v5, int64(1))
                    v11 = US7(1)


            def _arrow217(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v11.fields[0] if (v11.tag == 0) else _arrow217()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def method28(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US6:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v70: US5
        if "" == v1_1:
            v70 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'"])), (v2_1, v3, v4)])))

        else: 
            v19_1: str = v1_1[0]
            v21: int = len(v1_1) or 0
            v26: str = v1_1[1:v21 + 1]
            if method27(v19_1, int64(0)) == False:
                v31: str = v19_1
                v34: int = len(v31) or 0
                v35: Array[str] = fill([0] * v34, 0, v34, "")
                v36: Mut5 = Mut5(0)
                while method23(v34, v36):
                    v38: int = v36.l0 or 0
                    v39: str = v31[v38]
                    v35[v38] = v39
                    v40: int = (v38 + 1) or 0
                    v36.l0 = v40 or 0
                v41: FSharpList[str] = of_array(v35)
                pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v41, UH0(0)), v2_1, v3, v4)
                v70 = US5(0, v19_1, v26, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v70 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v19_1, to_array(of_array(["\"", "\'"])), (v2_1, v3, v4)])))


        v82: US5
        if v70.tag == 0:
            v71: str = v70.fields[0]
            v82 = US5(0, "/" if ("\\" == v71) else v71, v70.fields[1], v70.fields[2], v70.fields[3], v70.fields[4])

        else: 
            v82 = US5(1, v70.fields[0])

        if v82.tag == 0:
            v0_1_mut = v0_1 + v82.fields[0]
            v1_1_mut = v82.fields[1]
            v2_1_mut = v82.fields[2]
            v3_mut = v82.fields[3]
            v4_mut = v82.fields[4]
            continue

        else: 
            return US6(0, v0_1, v1_1, v2_1, v3, v4)

        break


def method29(v0_1_mut: str, v1_1_mut: Any, v2_1_mut: int, v3_mut: int, v4_mut: UH1) -> US5:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        if v4.tag == 0:
            return US5(1, "choice / no parsers succeeded")

        else: 
            v9: US5 = v4.fields[0]((v0_1, v1_1, v2_1, v3))
            if v9.tag == 0:
                return v9

            else: 
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_mut = v3
                v4_mut = v4.fields[1]
                continue


        break


def method30(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(3):
            return False

        else: 
            v15: US7
            if v1_1 == int64(0):
                v15 = US7(0, "\"")

            else: 
                v5: int64 = op_subtraction(v1_1, int64(1))
                if v5 == int64(0):
                    v15 = US7(0, "\'")

                else: 
                    v8: int64 = op_subtraction(v5, int64(1))
                    if v8 == int64(0):
                        v15 = US7(0, " ")

                    else: 
                        v11: int64 = op_subtraction(v8, int64(1))
                        v15 = US7(1)



            def _arrow218(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v15.fields[0] if (v15.tag == 0) else _arrow218()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def method31(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US6:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v76: US5
        if "" == v1_1:
            v76 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'", " "])), (v2_1, v3, v4)])))

        else: 
            v22: str = v1_1[0]
            v24: int = len(v1_1) or 0
            v29: str = v1_1[1:v24 + 1]
            if method30(v22, int64(0)) == False:
                v34: str = v22
                v37: int = len(v34) or 0
                v38: Array[str] = fill([0] * v37, 0, v37, "")
                v39: Mut5 = Mut5(0)
                while method23(v37, v39):
                    v41: int = v39.l0 or 0
                    v42: str = v34[v41]
                    v38[v41] = v42
                    v43: int = (v41 + 1) or 0
                    v39.l0 = v43 or 0
                v44: FSharpList[str] = of_array(v38)
                pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v44, UH0(0)), v2_1, v3, v4)
                v76 = US5(0, v22, v29, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v76 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v22, to_array(of_array(["\"", "\'", " "])), (v2_1, v3, v4)])))


        v88: US5
        if v76.tag == 0:
            v77: str = v76.fields[0]
            v88 = US5(0, "/" if ("\\" == v77) else v77, v76.fields[1], v76.fields[2], v76.fields[3], v76.fields[4])

        else: 
            v88 = US5(1, v76.fields[0])

        if v88.tag == 0:
            v0_1_mut = v0_1 + v88.fields[0]
            v1_1_mut = v88.fields[1]
            v2_1_mut = v88.fields[2]
            v3_mut = v88.fields[3]
            v4_mut = v88.fields[4]
            continue

        else: 
            return US6(0, v0_1, v1_1, v2_1, v3, v4)

        break


def method32(v0_1_mut: str, v1_1_mut: int) -> int:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= len(v0_1):
            return v1_1

        elif v0_1[v1_1] == " ":
            v0_1_mut = v0_1
            v1_1_mut = v1_1 + 1
            continue

        else: 
            return v1_1

        break


def method33(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US6:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v42: US5
        if "" == v1_1:
            v42 = US5(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v2_1, v3, v4)])))

        else: 
            v8: str = v1_1[0]
            v10: int = len(v1_1) or 0
            v15: str = v1_1[1:v10 + 1]
            v17_1: str = v8
            v20_1: int = len(v17_1) or 0
            v21: Array[str] = fill([0] * v20_1, 0, v20_1, "")
            v22: Mut5 = Mut5(0)
            while method23(v20_1, v22):
                v24: int = v22.l0 or 0
                v25: str = v17_1[v24]
                v21[v24] = v25
                v26: int = (v24 + 1) or 0
                v22.l0 = v26 or 0
            v27: FSharpList[str] = of_array(v21)
            pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v27, UH0(0)), v2_1, v3, v4)
            v42 = US5(0, v8, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        if v42.tag == 0:
            v0_1_mut = v0_1 + v42.fields[0]
            v1_1_mut = v42.fields[1]
            v2_1_mut = v42.fields[2]
            v3_mut = v42.fields[3]
            v4_mut = v42.fields[4]
            continue

        else: 
            return US6(0, v0_1, v1_1, v2_1, v3, v4)

        break


def method22(v0_1: str) -> US4:
    _v0: (str | None) | None = None
    _v0 = some(v0_1)
    def _arrow219(__unit: None=None, v0_1: Any=v0_1) -> str | None:
        raise Exception("optionm\'.of_obj / _v0=None")

    v7: str = default_arg(_arrow219() if (_v0 is None) else value_12(_v0), "")
    v11: Any = StringBuilder__ctor_Z721C83C5("")
    def v12(_arg10: tuple[str, Any, int, int], v0_1: Any=v0_1) -> US5:
        return closure14(None, _arg10)

    def v13(_arg10_1: tuple[str, Any, int, int], v0_1: Any=v0_1) -> US5:
        return closure17(None, _arg10_1)

    v17_1: US5 = method26(v7, v11, UH1(1, v12, UH1(1, v13, UH1(0))))
    v153: US6
    if v17_1.tag == 0:
        v22: int = v17_1.fields[4] or 0
        v21: int = v17_1.fields[3] or 0
        v20_1: Any = v17_1.fields[2]
        v19_1: str = v17_1.fields[1]
        v88: US5
        if "" == v19_1:
            v88 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'"])), (v20_1, v21, v22)])))

        else: 
            v37: str = v19_1[0]
            v39: int = len(v19_1) or 0
            v44: str = v19_1[1:v39 + 1]
            if method27(v37, int64(0)) == False:
                v49: str = v37
                v52: int = len(v49) or 0
                v53: Array[str] = fill([0] * v52, 0, v52, "")
                v54: Mut5 = Mut5(0)
                while method23(v52, v54):
                    v56: int = v54.l0 or 0
                    v57: str = v49[v56]
                    v53[v56] = v57
                    v58: int = (v56 + 1) or 0
                    v54.l0 = v58 or 0
                v59: FSharpList[str] = of_array(v53)
                pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v59, UH0(0)), v20_1, v21, v22)
                v88 = US5(0, v37, v44, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v88 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v37, to_array(of_array(["\"", "\'"])), (v20_1, v21, v22)])))


        v100: US5
        if v88.tag == 0:
            v89: str = v88.fields[0]
            v100 = US5(0, "/" if ("\\" == v89) else v89, v88.fields[1], v88.fields[2], v88.fields[3], v88.fields[4])

        else: 
            v100 = US5(1, v88.fields[0])

        v114: US6 = method28(v100.fields[0], v100.fields[1], v100.fields[2], v100.fields[3], v100.fields[4]) if (v100.tag == 0) else US6(1, v100.fields[0])
        v124: US6 = US6(0, v114.fields[0], v114.fields[1], v114.fields[2], v114.fields[3], v114.fields[4]) if (v114.tag == 0) else US6(0, "", v19_1, v20_1, v21, v22)
        if v124.tag == 0:
            v129: int = v124.fields[4] or 0
            v128: int = v124.fields[3] or 0
            v127: Any = v124.fields[2]
            v126: str = v124.fields[1]
            v133: US5 = method29(v126, v127, v128, v129, UH1(1, v12, UH1(1, v13, UH1(0))))
            v153 = US6(0, v124.fields[0], v133.fields[1], v133.fields[2], v133.fields[3], v133.fields[4]) if (v133.tag == 0) else US6(1, to_text(interpolate("between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v133.fields[0], (v7, v11, 1, 1), (v19_1, v20_1, v21, v22), (v126, v127, v128, v129)])))

        else: 
            v153 = US6(1, "between / expected content")


    else: 
        v153 = US6(1, v17_1.fields[0])

    v303: US6
    if v153.tag == 0:
        v303 = v153

    else: 
        v233: US5
        if "" == v7:
            v233 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'", " "])), (v11, 1, 1)])))

        else: 
            v177: str = v7[0]
            v179: int = len(v7) or 0
            v184: str = v7[1:v179 + 1]
            if method30(v177, int64(0)) == False:
                v189: str = v177
                v192: int = len(v189) or 0
                v193: Array[str] = fill([0] * v192, 0, v192, "")
                v194: Mut5 = Mut5(0)
                while method23(v192, v194):
                    v196: int = v194.l0 or 0
                    v197: str = v189[v196]
                    v193[v196] = v197
                    v198: int = (v196 + 1) or 0
                    v194.l0 = v198 or 0
                v199: FSharpList[str] = of_array(v193)
                pattern_input_1: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v199, UH0(0)), v11, 1, 1)
                v233 = US5(0, v177, v184, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])

            else: 
                v233 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v177, to_array(of_array(["\"", "\'", " "])), (v11, 1, 1)])))


        v245: US5
        if v233.tag == 0:
            v234: str = v233.fields[0]
            v245 = US5(0, "/" if ("\\" == v234) else v234, v233.fields[1], v233.fields[2], v233.fields[3], v233.fields[4])

        else: 
            v245 = US5(1, v233.fields[0])

        v259: US6 = method31(v245.fields[0], v245.fields[1], v245.fields[2], v245.fields[3], v245.fields[4]) if (v245.tag == 0) else US6(1, v245.fields[0])
        if v259.tag == 0:
            v303 = v259

        else: 
            v271: US8 = US8(0, v7, v11, 1, 1) if (len(v7) == 0) else US8(1, to_text(interpolate("parsing.eof / expected end of input / input: %A%P()", [v7])))
            v280: US6 = US6(0, "", v271.fields[0], v271.fields[1], v271.fields[2], v271.fields[3]) if (v271.tag == 0) else US6(1, v271.fields[0])
            if v280.tag == 0:
                v282: str = v280.fields[1]
                v287: int = method32(v282, 0) or 0
                v289: int = len(v282) or 0
                v303 = US6(0, v280.fields[0], v282[v287:v289 + 1], v280.fields[2], v280.fields[3], v280.fields[4])

            else: 
                v303 = US6(1, v280.fields[0])



    v471: US9
    if v303.tag == 0:
        v308: int = v303.fields[4] or 0
        v307: int = v303.fields[3] or 0
        v306: Any = v303.fields[2]
        v305: str = v303.fields[1]
        v372: US5
        if "" == v305:
            v372 = US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v306, v307, v308)])))

        else: 
            v312: str = v305[0]
            if v312 == " ":
                v315: int = len(v305) or 0
                v320: str = v305[1:v315 + 1]
                v322: str = v312
                v325: int = len(v322) or 0
                v326: Array[str] = fill([0] * v325, 0, v325, "")
                v327: Mut5 = Mut5(0)
                while method23(v325, v327):
                    v329: int = v327.l0 or 0
                    v330: str = v322[v329]
                    v326[v329] = v330
                    v331: int = (v329 + 1) or 0
                    v327.l0 = v331 or 0
                v332: FSharpList[str] = of_array(v326)
                pattern_input_2: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v332, UH0(0)), v306, v307, v308)
                v372 = US5(0, v312, v320, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2])

            else: 
                v348: int = len(v305) or 0
                v351: int = (v305.find("\n") - 1) or 0
                v353: int = (v348 if (-2 == v351) else v351) or 0
                v372 = US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str(" ")) + "\' / line: ") + str(v307)) + " / col: ") + str(v308)) + "\n") + str(v306)) + "") + v305[0:v353 + 1]) + "")) + "\n") + (replicate(v308 - 1, " ") + "^")) + "\n")


        v384: US10 = US10(0, US7(0, v372.fields[0]), v372.fields[1], v372.fields[2], v372.fields[3], v372.fields[4]) if (v372.tag == 0) else US10(0, US7(1), v305, v306, v307, v308)
        v445: US6
        if v384.tag == 0:
            v389: int = v384.fields[4] or 0
            v388: int = v384.fields[3] or 0
            v387: Any = v384.fields[2]
            v386: str = v384.fields[1]
            v427: US5
            if "" == v386:
                v427 = US5(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v387, v388, v389)])))

            else: 
                v393: str = v386[0]
                v395: int = len(v386) or 0
                v400: str = v386[1:v395 + 1]
                v402: str = v393
                v405: int = len(v402) or 0
                v406: Array[str] = fill([0] * v405, 0, v405, "")
                v407: Mut5 = Mut5(0)
                while method23(v405, v407):
                    v409: int = v407.l0 or 0
                    v410: str = v402[v409]
                    v406[v409] = v410
                    v411: int = (v409 + 1) or 0
                    v407.l0 = v411 or 0
                v412: FSharpList[str] = of_array(v406)
                pattern_input_3: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v412, UH0(0)), v387, v388, v389)
                v427 = US5(0, v393, v400, pattern_input_3[0], pattern_input_3[1], pattern_input_3[2])

            v445 = method33(v427.fields[0], v427.fields[1], v427.fields[2], v427.fields[3], v427.fields[4]) if (v427.tag == 0) else US6(1, v427.fields[0])

        else: 
            v445 = US6(1, v384.fields[0])

        v457: US11 = US11(0, US1(0, v445.fields[0]), v445.fields[1], v445.fields[2], v445.fields[3], v445.fields[4]) if (v445.tag == 0) else US11(0, US1(1), v305, v306, v307, v308)
        v471 = US9(0, v303.fields[0], v457.fields[0], v457.fields[1], v457.fields[2], v457.fields[3], v457.fields[4]) if (v457.tag == 0) else US9(1, v457.fields[0])

    else: 
        v471 = US9(1, v303.fields[0])

    if v471.tag == 0:
        return US4(0, v471.fields[0], v471.fields[1])

    else: 
        return US4(1, v471.fields[0])



def method34(__unit: None=None) -> str:
    v2_1: str = "Debug".lower()
    return ("\u001b[94m" + method12(v2_1[0])) + method14()


def method36(v0_1: str, v1_1: US1, v2_1: str, v3: CancellationToken | None, v4: Array[tuple[str, str]], v5: Callable[[tuple[int, str, bool]], Async[None]] | None, v6: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v7: bool, v8: str | None=None) -> str:
    v10: Mut3 = Mut3(method13())
    v17_1: None
    closure7(v10, ("" + "{ ") + "", None)
    v17_1 = None
    v26: None
    closure7(v10, ("" + "file_name") + "", None)
    v26 = None
    v35: None
    closure7(v10, ("" + " = ") + "", None)
    v35 = None
    v43: None
    closure7(v10, ("" + v0_1) + "", None)
    v43 = None
    v52: None
    closure7(v10, ("" + "; ") + "", None)
    v52 = None
    v61: None
    closure7(v10, ("" + "arguments") + "", None)
    v61 = None
    v69: None
    closure7(v10, ("" + " = ") + "", None)
    v69 = None
    v80: None
    closure7(v10, ("" + to_text(interpolate("%A%P()", [v1_1]))) + "", None)
    v80 = None
    v88: None
    closure7(v10, ("" + "; ") + "", None)
    v88 = None
    v97: None
    closure7(v10, ("" + "options") + "", None)
    v97 = None
    v105: None
    closure7(v10, ("" + " = ") + "", None)
    v105 = None
    v113: None
    closure7(v10, ("" + "{ ") + "", None)
    v113 = None
    v122: None
    closure7(v10, ("" + "command") + "", None)
    v122 = None
    v130: None
    closure7(v10, ("" + " = ") + "", None)
    v130 = None
    v138: None
    closure7(v10, ("" + v2_1) + "", None)
    v138 = None
    v146: None
    closure7(v10, ("" + "; ") + "", None)
    v146 = None
    v155: None
    closure7(v10, ("" + "cancellation_token") + "", None)
    v155 = None
    v163: None
    closure7(v10, ("" + " = ") + "", None)
    v163 = None
    v198: None
    closure7(v10, ("" + to_text(interpolate("%A%P()", [v3]))) + "", None)
    v198 = None
    v206: None
    closure7(v10, ("" + "; ") + "", None)
    v206 = None
    v215: None
    closure7(v10, ("" + "environment_variables") + "", None)
    v215 = None
    v223: None
    closure7(v10, ("" + " = ") + "", None)
    v223 = None
    v234: None
    closure7(v10, ("" + to_text(interpolate("%A%P()", [v4]))) + "", None)
    v234 = None
    v242: None
    closure7(v10, ("" + "; ") + "", None)
    v242 = None
    v251: None
    closure7(v10, ("" + "on_line") + "", None)
    v251 = None
    v259: None
    closure7(v10, ("" + " = ") + "", None)
    v259 = None
    v294: None
    closure7(v10, ("" + to_text(interpolate("%A%P()", [v5]))) + "", None)
    v294 = None
    v302: None
    closure7(v10, ("" + "; ") + "", None)
    v302 = None
    v311: None
    closure7(v10, ("" + "stdin") + "", None)
    v311 = None
    v319: None
    closure7(v10, ("" + " = ") + "", None)
    v319 = None
    v354: None
    closure7(v10, ("" + to_text(interpolate("%A%P()", [v6]))) + "", None)
    v354 = None
    v362: None
    closure7(v10, ("" + "; ") + "", None)
    v362 = None
    v371: None
    closure7(v10, ("" + "trace") + "", None)
    v371 = None
    v379: None
    closure7(v10, ("" + " = ") + "", None)
    v379 = None
    v390: None
    closure7(v10, ("" + ("true" if v7 else "false")) + "", None)
    v390 = None
    v398: None
    closure7(v10, ("" + "; ") + "", None)
    v398 = None
    v407: None
    closure7(v10, ("" + "working_directory") + "", None)
    v407 = None
    v415: None
    closure7(v10, ("" + " = ") + "", None)
    v415 = None
    v450: None
    closure7(v10, ("" + to_text(interpolate("%A%P()", [v8]))) + "", None)
    v450 = None
    v459: None
    closure7(v10, ("" + " }") + "", None)
    v459 = None
    v467: None
    closure7(v10, ("" + " }") + "", None)
    v467 = None
    return v10.l0


def method35(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str, v9: US1, v10: str, v11: CancellationToken | None, v12: Array[tuple[str, str]], v13: Callable[[tuple[int, str, bool]], Async[None]] | None, v14: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v15: bool, v16_1: str | None=None) -> str:
    v17_1: str = method36(v8, v9, v10, v11, v12, v13, v14, v15, v16_1)
    return method17(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "runtime.execute_with_options_async") + " / ") + v17_1) + "")


def closure18(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None, v7: US1, v8: str, unit_var: None) -> None:
    if method6(US0(1)):
        v13: None
        closure0(None, None)
        v13 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        v32: int64 | None = pattern_input[5]
        v31: Mut4 = pattern_input[4]
        v30: Mut3 = pattern_input[3]
        v29: Mut2 = pattern_input[2]
        v28: Mut1 = pattern_input[1]
        v27: Mut0 = pattern_input[0]
        method18(method35(v27, v28, v29, v30, v31, v32, method7(v27, v28, v29, v30, v31, v32), method34(), v8, v7, v0_1, v1_1, v2_1, v3, v4, v5, v6))



def closure20(unit_var: None, v0_1: Callable[[tuple[int, str, bool]], Async[None]]) -> US12:
    return US12(0, v0_1)


def method37(__unit: None=None) -> Callable[[Callable[[tuple[int, str, bool]], Async[None]]], US12]:
    def _arrow220(v: Callable[[tuple[int, str, bool]], Async[None]]) -> US12:
        return closure20(None, v)

    return _arrow220


def method38(__unit: None=None) -> str:
    v2_1: str = "Verbose".lower()
    return ("\u001b[90m" + method12(v2_1[0])) + method14()


def method39(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: str) -> str:
    v9: str = method16()
    return method17(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + v8) + " / ") + v9) + "")


def closure21(v0_1: str, unit_var: None) -> None:
    if method6(US0(0)):
        v5: None
        closure0(None, None)
        v5 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        v24: int64 | None = pattern_input[5]
        v23: Mut4 = pattern_input[4]
        v22: Mut3 = pattern_input[3]
        v21: Mut2 = pattern_input[2]
        v20_1: Mut1 = pattern_input[1]
        v19_1: Mut0 = pattern_input[0]
        method18("" if (v0_1 == "") else method39(v19_1, v20_1, v21, v22, v23, v24, method7(v19_1, v20_1, v21, v22, v23, v24), method38(), v0_1))



def closure19(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None, v7: None, v8: Any, v9: None) -> None:
    pass


def closure22(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None, v7: None, v8: Any, v9: None) -> None:
    pass


def closure23(unit_var: None, v0_1: CancellationToken) -> US13:
    return US13(0, v0_1)


def method40(__unit: None=None) -> Callable[[CancellationToken], US13]:
    def _arrow221(v: CancellationToken) -> US13:
        return closure23(None, v)

    return _arrow221


def closure24(v0_1: None, unit_var: None) -> None:
    if None == False:
        pass



def method42(v0_1: Any) -> str:
    v2_1: Mut3 = Mut3(method13())
    v9: None
    closure7(v2_1, ("" + "{ ") + "", None)
    v9 = None
    v18_1: None
    closure7(v2_1, ("" + "ex") + "", None)
    v18_1 = None
    v27: None
    closure7(v2_1, ("" + " = ") + "", None)
    v27 = None
    v62: None
    closure7(v2_1, ("" + to_text(interpolate("%A%P()", [v0_1]))) + "", None)
    v62 = None
    v71: None
    closure7(v2_1, ("" + " }") + "", None)
    v71 = None
    return v2_1.l0


def method41(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: Any) -> str:
    v9: str = method42(v8)
    return method17(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "runtime.execute_with_options_async / WaitForExitAsync") + " / ") + v9) + "")


def closure25(v0_1: Any, unit_var: None) -> None:
    if method6(US0(3)):
        v5: None
        closure0(None, None)
        v5 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        v24: int64 | None = pattern_input[5]
        v23: Mut4 = pattern_input[4]
        v22: Mut3 = pattern_input[3]
        v21: Mut2 = pattern_input[2]
        v20_1: Mut1 = pattern_input[1]
        v19_1: Mut0 = pattern_input[0]
        method18(method41(v19_1, v20_1, v21, v22, v23, v24, method7(v19_1, v20_1, v21, v22, v23, v24), method11(), v0_1))



def method44(v0_1: int, v1_1: int) -> str:
    v3: Mut3 = Mut3(method13())
    v10: None
    closure7(v3, ("" + "{ ") + "", None)
    v10 = None
    v19_1: None
    closure7(v3, ("" + "exit_code") + "", None)
    v19_1 = None
    v28: None
    closure7(v3, ("" + " = ") + "", None)
    v28 = None
    v36: None
    closure7(v3, ("" + str(v0_1)) + "", None)
    v36 = None
    v45: None
    closure7(v3, ("" + "; ") + "", None)
    v45 = None
    v54: None
    closure7(v3, ("" + "output_length") + "", None)
    v54 = None
    v62: None
    closure7(v3, ("" + " = ") + "", None)
    v62 = None
    v70: None
    closure7(v3, ("" + str(v1_1)) + "", None)
    v70 = None
    v79: None
    closure7(v3, ("" + " }") + "", None)
    v79 = None
    return v3.l0


def method43(v0_1: Mut0, v1_1: Mut1, v2_1: Mut2, v3: Mut3, v4: Mut4, v5: int64 | None, v6: str, v7: str, v8: int, v9: int) -> str:
    v10: str = method44(v8, v9)
    return method17(((((((((("" + v6) + " ") + v7) + " #") + str(v0_1.l0)) + " ") + "runtime.execute_with_options_async") + " / ") + v10) + "")


def closure26(v0_1: int, v1_1: str, unit_var: None) -> None:
    if method6(US0(1)):
        v6: None
        closure0(None, None)
        v6 = None
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        v25: int64 | None = pattern_input[5]
        v24: Mut4 = pattern_input[4]
        v23: Mut3 = pattern_input[3]
        v22: Mut2 = pattern_input[2]
        v21: Mut1 = pattern_input[1]
        v20_1: Mut0 = pattern_input[0]
        method18(method43(v20_1, v21, v22, v23, v24, v25, method7(v20_1, v21, v22, v23, v24, v25), method34(), v0_1, len(v1_1)))



def method21(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None=None) -> Async[tuple[int, str]]:
    return None


def closure13(unit_var: None, v0_1: str) -> Async[tuple[int, str]]:
    return method21(v0_1, None, [], None, None, True, None)


def closure27(unit_var: None, _arg: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return method21(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6])


def closure28(unit_var: None, v0_1: Callable[[Heap0], Heap0]) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]:
    v8: Heap0 = v0_1(Heap0("", None, [], None, None, True, None))
    return (v8.l0, v8.l1, v8.l2, v8.l3, v8.l4, v8.l5, v8.l6)


def method47(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(4):
            return False

        else: 
            v19_1: US7
            if v1_1 == int64(0):
                v19_1 = US7(0, "\\")

            else: 
                v5: int64 = op_subtraction(v1_1, int64(1))
                if v5 == int64(0):
                    v19_1 = US7(0, "`")

                else: 
                    v8: int64 = op_subtraction(v5, int64(1))
                    if v8 == int64(0):
                        v19_1 = US7(0, "\"")

                    else: 
                        v11: int64 = op_subtraction(v8, int64(1))
                        if v11 == int64(0):
                            v19_1 = US7(0, " ")

                        else: 
                            v14: int64 = op_subtraction(v11, int64(1))
                            v19_1 = US7(1)




            def _arrow222(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v19_1.fields[0] if (v19_1.tag == 0) else _arrow222()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def method48(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US6:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v82: US5
        if "" == v1_1:
            v82 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3, v4)])))

        else: 
            v25: str = v1_1[0]
            v27: int = len(v1_1) or 0
            v32: str = v1_1[1:v27 + 1]
            if method47(v25, int64(0)) == False:
                v37: str = v25
                v40: int = len(v37) or 0
                v41: Array[str] = fill([0] * v40, 0, v40, "")
                v42: Mut5 = Mut5(0)
                while method23(v40, v42):
                    v44: int = v42.l0 or 0
                    v45: str = v37[v44]
                    v41[v44] = v45
                    v46: int = (v44 + 1) or 0
                    v42.l0 = v46 or 0
                v47: FSharpList[str] = of_array(v41)
                pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v47, UH0(0)), v2_1, v3, v4)
                v82 = US5(0, v25, v32, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v82 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v25, to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3, v4)])))


        if v82.tag == 0:
            v0_1_mut = v0_1 + v82.fields[0]
            v1_1_mut = v82.fields[1]
            v2_1_mut = v82.fields[2]
            v3_mut = v82.fields[3]
            v4_mut = v82.fields[4]
            continue

        else: 
            return US6(0, v0_1, v1_1, v2_1, v3, v4)

        break


def method50(v0_1_mut: str, v1_1_mut: int64) -> bool:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= int64(3):
            return False

        else: 
            v15: US7
            if v1_1 == int64(0):
                v15 = US7(0, "\\")

            else: 
                v5: int64 = op_subtraction(v1_1, int64(1))
                if v5 == int64(0):
                    v15 = US7(0, "`")

                else: 
                    v8: int64 = op_subtraction(v5, int64(1))
                    if v8 == int64(0):
                        v15 = US7(0, "\"")

                    else: 
                        v11: int64 = op_subtraction(v8, int64(1))
                        v15 = US7(1)



            def _arrow223(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v15.fields[0] if (v15.tag == 0) else _arrow223()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def closure30(unit_var: None, _arg: tuple[str, Any, int, int]) -> US6:
    v3: int = _arg[3] or 0
    v2_1: int = _arg[2] or 0
    v1_1: Any = _arg[1]
    v0_1: str = _arg[0]
    v67: US5
    if "" == v0_1:
        v67 = US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v1_1, v2_1, v3)])))

    else: 
        v7: str = v0_1[0]
        if v7 == "\\":
            v10: int = len(v0_1) or 0
            v15: str = v0_1[1:v10 + 1]
            v17_1: str = v7
            v20_1: int = len(v17_1) or 0
            v21: Array[str] = fill([0] * v20_1, 0, v20_1, "")
            v22: Mut5 = Mut5(0)
            while method23(v20_1, v22):
                v24: int = v22.l0 or 0
                v25: str = v17_1[v24]
                v21[v24] = v25
                v26: int = (v24 + 1) or 0
                v22.l0 = v26 or 0
            v27: FSharpList[str] = of_array(v21)
            pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v27, UH0(0)), v1_1, v2_1, v3)
            v67 = US5(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v43: int = len(v0_1) or 0
            v46: int = (v0_1.find("\n") - 1) or 0
            v48: int = (v43 if (-2 == v46) else v46) or 0
            v67 = US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\\")) + "\' / line: ") + str(v2_1)) + " / col: ") + str(v3)) + "\n") + str(v1_1)) + "") + v0_1[0:v48 + 1]) + "")) + "\n") + (replicate(v3 - 1, " ") + "^")) + "\n")


    v114: US5
    if v67.tag == 0:
        v72: int = v67.fields[4] or 0
        v71: int = v67.fields[3] or 0
        v70: Any = v67.fields[2]
        v69: str = v67.fields[1]
        if "" == v69:
            v114 = US5(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v70, v71, v72)])))

        else: 
            v76: str = v69[0]
            v78: int = len(v69) or 0
            v83: str = v69[1:v78 + 1]
            v85: str = v76
            v88: int = len(v85) or 0
            v89: Array[str] = fill([0] * v88, 0, v88, "")
            v90: Mut5 = Mut5(0)
            while method23(v88, v90):
                v92: int = v90.l0 or 0
                v93: str = v85[v92]
                v89[v92] = v93
                v94: int = (v92 + 1) or 0
                v90.l0 = v94 or 0
            v95: FSharpList[str] = of_array(v89)
            pattern_input_1: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v95, UH0(0)), v70, v71, v72)
            v114 = US5(0, v76, v83, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])


    else: 
        v114 = US5(1, v67.fields[0])

    if v114.tag == 0:
        return US6(0, ((("" + str("\\")) + "") + str(v114.fields[0])) + "", v114.fields[1], v114.fields[2], v114.fields[3], v114.fields[4])

    else: 
        return US6(1, v114.fields[0])



def closure31(unit_var: None, _arg: tuple[str, Any, int, int]) -> US6:
    v3: int = _arg[3] or 0
    v2_1: int = _arg[2] or 0
    v1_1: Any = _arg[1]
    v0_1: str = _arg[0]
    v67: US5
    if "" == v0_1:
        v67 = US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v1_1, v2_1, v3)])))

    else: 
        v7: str = v0_1[0]
        if v7 == "`":
            v10: int = len(v0_1) or 0
            v15: str = v0_1[1:v10 + 1]
            v17_1: str = v7
            v20_1: int = len(v17_1) or 0
            v21: Array[str] = fill([0] * v20_1, 0, v20_1, "")
            v22: Mut5 = Mut5(0)
            while method23(v20_1, v22):
                v24: int = v22.l0 or 0
                v25: str = v17_1[v24]
                v21[v24] = v25
                v26: int = (v24 + 1) or 0
                v22.l0 = v26 or 0
            v27: FSharpList[str] = of_array(v21)
            pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v27, UH0(0)), v1_1, v2_1, v3)
            v67 = US5(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v43: int = len(v0_1) or 0
            v46: int = (v0_1.find("\n") - 1) or 0
            v48: int = (v43 if (-2 == v46) else v46) or 0
            v67 = US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("`")) + "\' / line: ") + str(v2_1)) + " / col: ") + str(v3)) + "\n") + str(v1_1)) + "") + v0_1[0:v48 + 1]) + "")) + "\n") + (replicate(v3 - 1, " ") + "^")) + "\n")


    v114: US5
    if v67.tag == 0:
        v72: int = v67.fields[4] or 0
        v71: int = v67.fields[3] or 0
        v70: Any = v67.fields[2]
        v69: str = v67.fields[1]
        if "" == v69:
            v114 = US5(1, to_text(interpolate("parsing.any_char / unexpected end of input / s: %A%P()", [(v70, v71, v72)])))

        else: 
            v76: str = v69[0]
            v78: int = len(v69) or 0
            v83: str = v69[1:v78 + 1]
            v85: str = v76
            v88: int = len(v85) or 0
            v89: Array[str] = fill([0] * v88, 0, v88, "")
            v90: Mut5 = Mut5(0)
            while method23(v88, v90):
                v92: int = v90.l0 or 0
                v93: str = v85[v92]
                v89[v92] = v93
                v94: int = (v92 + 1) or 0
                v90.l0 = v94 or 0
            v95: FSharpList[str] = of_array(v89)
            pattern_input_1: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v95, UH0(0)), v70, v71, v72)
            v114 = US5(0, v76, v83, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])


    else: 
        v114 = US5(1, v67.fields[0])

    if v114.tag == 0:
        return US6(0, ((("" + str("`")) + "") + str(v114.fields[0])) + "", v114.fields[1], v114.fields[2], v114.fields[3], v114.fields[4])

    else: 
        return US6(1, v114.fields[0])



def method51(v0_1_mut: str, v1_1_mut: Any, v2_1_mut: int, v3_mut: int, v4_mut: UH3) -> US6:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        if v4.tag == 0:
            return US6(1, "choice / no parsers succeeded")

        else: 
            v9: US6 = v4.fields[0]((v0_1, v1_1, v2_1, v3))
            if v9.tag == 0:
                return v9

            else: 
                v0_1_mut = v0_1
                v1_1_mut = v1_1
                v2_1_mut = v2_1
                v3_mut = v3
                v4_mut = v4.fields[1]
                continue


        break


def method52(v0_1_mut: UH2, v1_1_mut: UH2) -> UH2:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v0_1.tag == 0:
            return v1_1

        else: 
            v0_1_mut = v0_1.fields[1]
            v1_1_mut = UH2(1, v0_1.fields[0], v1_1)
            continue

        break


def method49(v0_1_mut: UH2, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US15:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v76: US5
        if "" == v1_1:
            v76 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\""])), (v2_1, v3, v4)])))

        else: 
            v22: str = v1_1[0]
            v24: int = len(v1_1) or 0
            v29: str = v1_1[1:v24 + 1]
            if method50(v22, int64(0)) == False:
                v34: str = v22
                v37: int = len(v34) or 0
                v38: Array[str] = fill([0] * v37, 0, v37, "")
                v39: Mut5 = Mut5(0)
                while method23(v37, v39):
                    v41: int = v39.l0 or 0
                    v42: str = v34[v41]
                    v38[v41] = v42
                    v43: int = (v41 + 1) or 0
                    v39.l0 = v43 or 0
                v44: FSharpList[str] = of_array(v38)
                pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v44, UH0(0)), v2_1, v3, v4)
                v76 = US5(0, v22, v29, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v76 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v22, to_array(of_array(["\\", "`", "\""])), (v2_1, v3, v4)])))


        v90: US6 = US6(0, v76.fields[0], v76.fields[1], v76.fields[2], v76.fields[3], v76.fields[4]) if (v76.tag == 0) else US6(1, v76.fields[0])
        def v97(_arg10: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> US6:
            return closure30(None, _arg10)

        def v98(_arg10_1: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> US6:
            return closure31(None, _arg10_1)

        v104: US6 = v90 if (v90.tag == 0) else method51(v1_1, v2_1, v3, v4, UH3(1, v97, UH3(1, v98, UH3(0))))
        if v104.tag == 0:
            v0_1_mut = UH2(1, v104.fields[0], v0_1)
            v1_1_mut = v104.fields[1]
            v2_1_mut = v104.fields[2]
            v3_mut = v104.fields[3]
            v4_mut = v104.fields[4]
            continue

        else: 
            return US15(0, method52(v0_1, UH2(0)), v1_1, v2_1, v3, v4)

        break


def method53(v0_1: UH2, v1_1: FSharpList[str]) -> FSharpList[str]:
    if v0_1.tag == 0:
        return v1_1

    else: 
        return cons(v0_1.fields[0], method53(v0_1.fields[1], v1_1))



def method54(v0_1_mut: UH2, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US15:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v76: US5
        if "" == v1_1:
            v76 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\""])), (v2_1, v3, v4)])))

        else: 
            v22: str = v1_1[0]
            v24: int = len(v1_1) or 0
            v29: str = v1_1[1:v24 + 1]
            if method50(v22, int64(0)) == False:
                v34: str = v22
                v37: int = len(v34) or 0
                v38: Array[str] = fill([0] * v37, 0, v37, "")
                v39: Mut5 = Mut5(0)
                while method23(v37, v39):
                    v41: int = v39.l0 or 0
                    v42: str = v34[v41]
                    v38[v41] = v42
                    v43: int = (v41 + 1) or 0
                    v39.l0 = v43 or 0
                v44: FSharpList[str] = of_array(v38)
                pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v44, UH0(0)), v2_1, v3, v4)
                v76 = US5(0, v22, v29, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v76 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v22, to_array(of_array(["\\", "`", "\""])), (v2_1, v3, v4)])))


        v90: US6 = US6(0, v76.fields[0], v76.fields[1], v76.fields[2], v76.fields[3], v76.fields[4]) if (v76.tag == 0) else US6(1, v76.fields[0])
        if v90.tag == 0:
            v0_1_mut = UH2(1, v90.fields[0], v0_1)
            v1_1_mut = v90.fields[1]
            v2_1_mut = v90.fields[2]
            v3_mut = v90.fields[3]
            v4_mut = v90.fields[4]
            continue

        else: 
            return US15(0, method52(v0_1, UH2(0)), v1_1, v2_1, v3, v4)

        break


def method55(v0_1_mut: str, v1_1_mut: int) -> int:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v1_1 >= len(v0_1):
            return v1_1

        elif v0_1[v1_1] == " ":
            v0_1_mut = v0_1
            v1_1_mut = v1_1 + 1
            continue

        else: 
            return v1_1

        break


def method46(v0_1_mut: UH2, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US15:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v5: bool = "" == v1_1
        v82: US5
        if v5:
            v82 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3, v4)])))

        else: 
            v25: str = v1_1[0]
            v27: int = len(v1_1) or 0
            v32: str = v1_1[1:v27 + 1]
            if method47(v25, int64(0)) == False:
                v37: str = v25
                v40: int = len(v37) or 0
                v41: Array[str] = fill([0] * v40, 0, v40, "")
                v42: Mut5 = Mut5(0)
                while method23(v40, v42):
                    v44: int = v42.l0 or 0
                    v45: str = v37[v44]
                    v41[v44] = v45
                    v46: int = (v44 + 1) or 0
                    v42.l0 = v46 or 0
                v47: FSharpList[str] = of_array(v41)
                pattern_input: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v47, UH0(0)), v2_1, v3, v4)
                v82 = US5(0, v25, v32, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v82 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v25, to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3, v4)])))


        v96: US6 = method48(v82.fields[0], v82.fields[1], v82.fields[2], v82.fields[3], v82.fields[4]) if (v82.tag == 0) else US6(1, v82.fields[0])
        v341: US6
        if v96.tag == 0:
            v341 = v96

        else: 
            v165: US5
            if v5:
                v165 = US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v2_1, v3, v4)])))

            else: 
                v105: str = v1_1[0]
                if v105 == "\"":
                    v108: int = len(v1_1) or 0
                    v113: str = v1_1[1:v108 + 1]
                    v115: str = v105
                    v118: int = len(v115) or 0
                    v119: Array[str] = fill([0] * v118, 0, v118, "")
                    v120: Mut5 = Mut5(0)
                    while method23(v118, v120):
                        v122: int = v120.l0 or 0
                        v123: str = v115[v122]
                        v119[v122] = v123
                        v124: int = (v122 + 1) or 0
                        v120.l0 = v124 or 0
                    v125: FSharpList[str] = of_array(v119)
                    pattern_input_1: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v125, UH0(0)), v2_1, v3, v4)
                    v165 = US5(0, v105, v113, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])

                else: 
                    v141: int = len(v1_1) or 0
                    v144: int = (v1_1.find("\n") - 1) or 0
                    v146: int = (v141 if (-2 == v144) else v144) or 0
                    v165 = US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\"")) + "\' / line: ") + str(v3)) + " / col: ") + str(v4)) + "\n") + str(v2_1)) + "") + v1_1[0:v146 + 1]) + "")) + "\n") + (replicate(v4 - 1, " ") + "^")) + "\n")


            v282: US6
            if v165.tag == 0:
                v170: int = v165.fields[4] or 0
                v169: int = v165.fields[3] or 0
                v168: Any = v165.fields[2]
                v167: str = v165.fields[1]
                v172: US15 = method49(UH2(0), v167, v168, v169, v170)
                v193: US6
                if v172.tag == 0:
                    v179: FSharpList[str] = method53(v172.fields[0], empty())
                    def _arrow225(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> IEnumerable_1[str]:
                        def _arrow224(i: int) -> str:
                            return item(i, v179)

                        return map_1(_arrow224, range_big_int(0, 1, length(v179) - 1))

                    v193 = US6(0, join("", delay(_arrow225)), v172.fields[1], v172.fields[2], v172.fields[3], v172.fields[4])

                else: 
                    v193 = US6(1, v172.fields[0])

                if v193.tag == 0:
                    v198: int = v193.fields[4] or 0
                    v197: int = v193.fields[3] or 0
                    v196: Any = v193.fields[2]
                    v195: str = v193.fields[1]
                    v262: US5
                    if "" == v195:
                        v262 = US5(1, to_text(interpolate("parsing.p_char / unexpected end of input / s: %A%P()", [(v196, v197, v198)])))

                    else: 
                        v202: str = v195[0]
                        if v202 == "\"":
                            v205: int = len(v195) or 0
                            v210: str = v195[1:v205 + 1]
                            v212: str = v202
                            v215: int = len(v212) or 0
                            v216: Array[str] = fill([0] * v215, 0, v215, "")
                            v217: Mut5 = Mut5(0)
                            while method23(v215, v217):
                                v219: int = v217.l0 or 0
                                v220: str = v212[v219]
                                v216[v219] = v220
                                v221: int = (v219 + 1) or 0
                                v217.l0 = v221 or 0
                            v222: FSharpList[str] = of_array(v216)
                            pattern_input_2: tuple[Any, int, int] = method25(fold_back(uncurry2(method24()), v222, UH0(0)), v196, v197, v198)
                            v262 = US5(0, v202, v210, pattern_input_2[0], pattern_input_2[1], pattern_input_2[2])

                        else: 
                            v238: int = len(v195) or 0
                            v241: int = (v195.find("\n") - 1) or 0
                            v243: int = (v238 if (-2 == v241) else v241) or 0
                            v262 = US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\"")) + "\' / line: ") + str(v197)) + " / col: ") + str(v198)) + "\n") + str(v196)) + "") + v195[0:v243 + 1]) + "")) + "\n") + (replicate(v198 - 1, " ") + "^")) + "\n")


                    v282 = US6(0, v193.fields[0], v262.fields[1], v262.fields[2], v262.fields[3], v262.fields[4]) if (v262.tag == 0) else US6(1, to_text(interpolate("between / expected closing delimiter / e: %A%P() / input: %A%P() / rest1: %A%P() / rest2: %A%P()", [v262.fields[0], (v1_1, v2_1, v3, v4), (v167, v168, v169, v170), (v195, v196, v197, v198)])))

                else: 
                    v282 = US6(1, "between / expected content")


            else: 
                v282 = US6(1, v165.fields[0])

            if v282.tag == 0:
                v341 = v282

            else: 
                def v289(_arg10: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> US6:
                    return closure30(None, _arg10)

                def v290(_arg10_1: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> US6:
                    return closure31(None, _arg10_1)

                v294: US6 = method51(v1_1, v2_1, v3, v4, UH3(1, v289, UH3(1, v290, UH3(0))))
                v305: US6 = US6(0, "", v294.fields[1], v294.fields[2], v294.fields[3], v294.fields[4]) if (v294.tag == 0) else US6(1, v294.fields[0])
                v316: US15 = method54(UH2(0), v305.fields[1], v305.fields[2], v305.fields[3], v305.fields[4]) if (v305.tag == 0) else US15(1, v305.fields[0])
                if v316.tag == 0:
                    v323: FSharpList[str] = method53(v316.fields[0], empty())
                    def _arrow227(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> IEnumerable_1[str]:
                        def _arrow226(i_1: int) -> str:
                            return item(i_1, v323)

                        return map_1(_arrow226, range_big_int(0, 1, length(v323) - 1))

                    v341 = US6(0, join("", delay(_arrow227)), v316.fields[1], v316.fields[2], v316.fields[3], v316.fields[4])

                else: 
                    v341 = US6(1, v316.fields[0])



        if v341.tag == 0:
            v350: int = v341.fields[4] or 0
            v349: int = v341.fields[3] or 0
            v348: Any = v341.fields[2]
            v347: str = v341.fields[1]
            v346: str = v341.fields[0]
            v352: int = method55(v347, 0) or 0
            v364: US8
            if 0 == v352:
                v364 = US8(1, "spaces1 / expected at least one space")

            else: 
                v357: int = len(v347) or 0
                v364 = US8(0, v347[v352:v357 + 1], v348, v349, v350)

            if v364.tag == 0:
                v0_1_mut = UH2(1, v346, v0_1)
                v1_1_mut = v364.fields[0]
                v2_1_mut = v364.fields[1]
                v3_mut = v364.fields[2]
                v4_mut = v364.fields[3]
                continue

            else: 
                return US15(0, method52(v0_1, UH2(1, v346, UH2(0))), v347, v348, v349, v350)


        else: 
            return US15(0, method52(v0_1, UH2(0)), v1_1, v2_1, v3, v4)

        break


def method45(v0_1: str) -> US14:
    _v0: (str | None) | None = None
    _v0 = some(v0_1)
    def _arrow228(__unit: None=None, v0_1: Any=v0_1) -> str | None:
        raise Exception("optionm\'.of_obj / _v0=None")

    v15: US15 = method46(UH2(0), default_arg(_arrow228() if (_v0 is None) else value_12(_v0), ""), StringBuilder__ctor_Z721C83C5(""), 1, 1)
    if v15.tag == 0:
        return US14(0, to_array(method53(v15.fields[0], empty())))

    else: 
        return US14(1, v15.fields[0])



def closure29(unit_var: None, v0_1: str) -> FSharpResult_2[Array[str], str]:
    v1_1: US14 = method45(v0_1)
    if v1_1.tag == 0:
        return FSharpResult_2(0, v1_1.fields[0])

    else: 
        return FSharpResult_2(1, v1_1.fields[0])



v0: None = None

def _arrow229(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow229

def _expr230():
    v1(None)
    return v0


v2: None = _expr230()

def _arrow231(__unit: None=None) -> None:
    closure3(None, None)


v16: Callable[[], None] = _arrow231

def current_process_kill(__unit: None=None) -> None:
    v16(None)


def _arrow232(v: str) -> Async[tuple[int, str]]:
    return closure13(None, v)


v17: Callable[[str], Async[tuple[int, str]]] = _arrow232

def execute_async(x: str) -> Async[tuple[int, str]]:
    return v17(x)


def _arrow233(_arg10: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return closure27(None, _arg10)


v18: Callable[[tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]], Async[tuple[int, str]]] = _arrow233

def execute_with_options_async(x: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return v18(x)


def _arrow234(v: Callable[[Heap0], Heap0]) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]:
    return closure28(None, v)


v19: Callable[[Callable[[Heap0], Heap0]], tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]] = _arrow234

def execution_options(x: Callable[[Heap0], Heap0]) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]:
    return v19(x)


def _arrow235(v: str) -> FSharpResult_2[Array[str], str]:
    return closure29(None, v)


v20: Callable[[str], FSharpResult_2[Array[str], str]] = _arrow235

def split_args(x: str) -> FSharpResult_2[Array[str], str]:
    return v20(x)


