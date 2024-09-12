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
from fable_modules.fable_library.long import (op_addition, op_subtraction)
from fable_modules.fable_library.map import (find, of_seq)
from fable_modules.fable_library.option import (some, value as value_12, default_arg)
from fable_modules.fable_library.range import range_big_int
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type, char_type, class_type, int32_type, tuple_type, option_type, array_type)
from fable_modules.fable_library.result import FSharpResult_2
from fable_modules.fable_library.seq import (delay, map)
from fable_modules.fable_library.string_ import (pad_left, trim_end, trim_start, to_text, interpolate, replicate, join)
from fable_modules.fable_library.system_text import (StringBuilder__Clear, StringBuilder__Append_Z721C83C5, StringBuilder__ctor_Z721C83C5)
from fable_modules.fable_library.time_span import (create, hours, minutes, seconds, milliseconds)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import (create_atom, ignore, to_enumerable, compare, uncurry2, IEnumerable_1)

TraceState_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr192() -> TypeInfo:
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


US0_reflection = _expr192

def _expr193() -> TypeInfo:
    return record_type("Runtime.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr193

def _expr194() -> TypeInfo:
    return record_type("Runtime.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr194

def _expr195() -> TypeInfo:
    return record_type("Runtime.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr195

def _expr196() -> TypeInfo:
    return record_type("Runtime.Mut3", [], Mut3, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: str

Mut3_reflection = _expr196

def _expr197() -> TypeInfo:
    return record_type("Runtime.Mut4", [], Mut4, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: US0

Mut4_reflection = _expr197

def _expr198() -> TypeInfo:
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


US1_reflection = _expr198

def _expr199() -> TypeInfo:
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


US2_reflection = _expr199

def _expr200() -> TypeInfo:
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


US3_reflection = _expr200

def _expr201() -> TypeInfo:
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


US4_reflection = _expr201

def _expr202() -> TypeInfo:
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


US5_reflection = _expr202

def _expr203() -> TypeInfo:
    return record_type("Runtime.Mut5", [], Mut5, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut5(Record):
    l0: int

Mut5_reflection = _expr203

def _expr204() -> TypeInfo:
    return union_type("Runtime.UH0", [], UH0, lambda: [[], [("Item1", char_type), ("Item2", UH0_reflection())]])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr204

def _expr205() -> TypeInfo:
    return union_type("Runtime.UH1", [], UH1, lambda: [[], [("Item1", lambda_type(tuple_type(string_type, class_type("System.Text.StringBuilder"), int32_type, int32_type), US5_reflection())), ("Item2", UH1_reflection())]])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr205

def _expr206() -> TypeInfo:
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


US6_reflection = _expr206

def _expr207() -> TypeInfo:
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


US7_reflection = _expr207

def _expr208() -> TypeInfo:
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


US8_reflection = _expr208

def _expr209() -> TypeInfo:
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


US9_reflection = _expr209

def _expr210() -> TypeInfo:
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


US10_reflection = _expr210

def _expr211() -> TypeInfo:
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


US11_reflection = _expr211

def _expr212() -> TypeInfo:
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


US12_reflection = _expr212

def _expr213() -> TypeInfo:
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


US13_reflection = _expr213

def _expr214() -> TypeInfo:
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

Heap0_reflection = _expr214

def _expr215() -> TypeInfo:
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


US14_reflection = _expr215

def _expr216() -> TypeInfo:
    return union_type("Runtime.UH2", [], UH2, lambda: [[], [("Item1", string_type), ("Item2", UH2_reflection())]])


class UH2(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH2_0", "UH2_1"]


UH2_reflection = _expr216

def _expr217() -> TypeInfo:
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


US15_reflection = _expr217

def _expr218() -> TypeInfo:
    return union_type("Runtime.UH3", [], UH3, lambda: [[], [("Item1", lambda_type(tuple_type(string_type, class_type("System.Text.StringBuilder"), int32_type, int32_type), US6_reflection())), ("Item2", UH3_reflection())]])


class UH3(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["UH3_0", "UH3_1"]


UH3_reflection = _expr218

def method1(__unit: None=None) -> str:
    return "TRACE_LEVEL"


def method3(__unit: None=None) -> str:
    return ""


def closure1(v0_1: FSharpRef[US1 | None], v1_1: US1 | None=None) -> FSharpRef[US1 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure2(v0_1: str | None, v1_1: Callable[[US1 | None], FSharpRef[US1 | None]], unit_var: None) -> None:
    def _arrow219(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US1 | None:
        x: str = v0_1
        def x_1(__unit: None=None) -> US1:
            return US1(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow219()))


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


def method0(v0_1: US0) -> tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None]:
    v173: str = method2(method1())
    v178: US2 = US2(0, US0(0)) if ("Verbose" == v173) else US2(1)
    def _arrow220(__unit: None=None, v0_1: Any=v0_1) -> US2:
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




    _v1: tuple[US2, US3] = (US2(0, v178.fields[0]) if (v178.tag == 0) else _arrow220(), US3(0, ticks_1(now())) if (method2(method4()) == "True") else US3(1))
    v295: US3 = _v1[1]
    v294: US2 = _v1[0]
    def v360(v: str, v0_1: Any=v0_1) -> None:
        closure3(None, v)

    return (Mut0(int64(0)), Mut1(v360), Mut2(True), Mut3(""), Mut4(v294.fields[0] if (v294.tag == 0) else v0_1), v295.fields[0] if (v295.tag == 0) else None)


def closure0(unit_var: None, unit_var_1: None) -> None:
    if TraceState_trace_state() is None:
        pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = method0(US0(0))
        TraceState_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4], pattern_input[5]))



def closure7(v0_1: Mut0, unit_var: None) -> None:
    v2_1: int64 = op_addition(v0_1.l0, int64(1))
    v0_1.l0 = v2_1


def closure8(v0_1: FSharpRef[US3 | None], v1_1: US3 | None=None) -> FSharpRef[US3 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure9(v0_1: int64 | None, v1_1: Callable[[US3 | None], FSharpRef[US3 | None]], unit_var: None) -> None:
    def _arrow221(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US3 | None:
        x: int64 = v0_1
        def x_1(__unit: None=None) -> US3:
            return US3(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow221()))


def method5(__unit: None=None) -> str:
    return "hh:mm:ss"


def method6(__unit: None=None) -> str:
    return "HH:mm:ss"


def method7(__unit: None=None) -> str:
    return "\u001b[0m"


def method8(__unit: None=None) -> str:
    return ""


def closure11(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def closure10(unit_var: None, v0_1: str) -> None:
    v3: None
    closure11(v0_1, None)
    v3 = None


def closure6(unit_var: None, unit_var_1: None) -> None:
    def v1_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure0(None, None)

    v2_1: None
    v1_1(None)
    v2_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v35: None
    v1_1(None)
    v35 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v67: US0 = pattern_input_1[4].l0
    class ObjectExpr222:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v67, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr222()))):
        v75: None
        closure7(pattern_input[0], None)
        v75 = None
        v79: None
        v1_1(None)
        v79 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        _v358: FSharpRef[US3 | None] = FSharpRef(None)
        v363: None
        def v360(v: US3 | None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> FSharpRef[US3 | None]:
            return closure8(_v358, v)

        closure9(pattern_input_2[5], v360, None)
        v363 = None
        v378: US3 = default_arg(_v358.contents, US3(1))
        def _arrow223(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> Any:
            v392: Any = create(op_subtraction(ticks_1(now()), v378.fields[0]))
            return create_1(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))

        v423: str = to_string(_arrow223() if (v378.tag == 0) else now(), method6())
        v624: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method7()
        v635: int64 = pattern_input_2[0].l0
        v637: Mut3 = Mut3(method8())
        v677: str = trim_end(trim_start(((((((((("" + v423) + " ") + v624) + " #") + str(v635)) + " ") + "runtime.current_process_kill / exiting... 3") + " / ") + v637.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v677)
        pattern_input[1].l0(v677)



def closure12(unit_var: None, unit_var_1: None) -> None:
    def v1_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure0(None, None)

    v2_1: None
    v1_1(None)
    v2_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v35: None
    v1_1(None)
    v35 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v67: US0 = pattern_input_1[4].l0
    class ObjectExpr224:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v67, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr224()))):
        v75: None
        closure7(pattern_input[0], None)
        v75 = None
        v79: None
        v1_1(None)
        v79 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        _v358: FSharpRef[US3 | None] = FSharpRef(None)
        v363: None
        def v360(v: US3 | None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> FSharpRef[US3 | None]:
            return closure8(_v358, v)

        closure9(pattern_input_2[5], v360, None)
        v363 = None
        v378: US3 = default_arg(_v358.contents, US3(1))
        def _arrow225(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> Any:
            v392: Any = create(op_subtraction(ticks_1(now()), v378.fields[0]))
            return create_1(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))

        v423: str = to_string(_arrow225() if (v378.tag == 0) else now(), method6())
        v624: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method7()
        v635: int64 = pattern_input_2[0].l0
        v637: Mut3 = Mut3(method8())
        v677: str = trim_end(trim_start(((((((((("" + v423) + " ") + v624) + " #") + str(v635)) + " ") + "runtime.current_process_kill / exiting... 2") + " / ") + v637.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v677)
        pattern_input[1].l0(v677)



def closure13(unit_var: None, unit_var_1: None) -> None:
    def v1_1(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> None:
        closure0(None, None)

    v2_1: None
    v1_1(None)
    v2_1 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v35: None
    v1_1(None)
    v35 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v67: US0 = pattern_input_1[4].l0
    class ObjectExpr226:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v67, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr226()))):
        v75: None
        closure7(pattern_input[0], None)
        v75 = None
        v79: None
        v1_1(None)
        v79 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        _v358: FSharpRef[US3 | None] = FSharpRef(None)
        v363: None
        def v360(v: US3 | None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> FSharpRef[US3 | None]:
            return closure8(_v358, v)

        closure9(pattern_input_2[5], v360, None)
        v363 = None
        v378: US3 = default_arg(_v358.contents, US3(1))
        def _arrow227(__unit: None=None, unit_var: Any=unit_var, unit_var_1: Any=unit_var_1) -> Any:
            v392: Any = create(op_subtraction(ticks_1(now()), v378.fields[0]))
            return create_1(1, 1, 1, hours(v392), minutes(v392), seconds(v392), milliseconds(v392))

        v423: str = to_string(_arrow227() if (v378.tag == 0) else now(), method6())
        v624: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method7()
        v635: int64 = pattern_input_2[0].l0
        v637: Mut3 = Mut3(method8())
        v677: str = trim_end(trim_start(((((((((("" + v423) + " ") + v624) + " #") + str(v635)) + " ") + "runtime.current_process_kill / exiting... 1") + " / ") + v637.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v677)
        pattern_input[1].l0(v677)



def closure5(unit_var: None, unit_var_1: None) -> None:
    pass


def closure4(unit_var: None, unit_var_1: None) -> None:
    pass


def method11(v0_1: int, v1_1: Mut5) -> bool:
    return v1_1.l0 < v0_1


def closure17(v0_1: str, v1_1: UH0) -> UH0:
    return UH0(1, v0_1, v1_1)


def closure16(unit_var: None, v0_1: str) -> Callable[[UH0], UH0]:
    def _arrow228(v: UH0, unit_var: Any=unit_var, v0_1: Any=v0_1) -> UH0:
        return closure17(v0_1, v)

    return _arrow228


def method12(__unit: None=None) -> Callable[[str, UH0], UH0]:
    def _arrow229(v: str) -> Callable[[UH0], UH0]:
        return closure16(None, v)

    return _arrow229


def method13(v0_1_mut: UH0, v1_1_mut: Any, v2_1_mut: int, v3_mut: int) -> tuple[Any, int, int]:
    while True:
        (v0_1, v1_1, v2_1, v3) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut)
        if v0_1.tag == 0:
            return (v1_1, v2_1, v3)

        else: 
            v4: str = v0_1.fields[0]
            v6: bool = "\n" == v4
            pattern_input: tuple[int, int] = ((v2_1 + 1, 1)) if v6 else ((v2_1, v3 + 1))
            v0_1_mut = v0_1.fields[1]
            def _arrow230(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3) -> Any:
                v12: Any = StringBuilder__Clear(v1_1)
                return v1_1

            def _arrow231(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3) -> Any:
                v18_1: Any = StringBuilder__Append_Z721C83C5(v1_1, v4)
                return v1_1

            v1_1_mut = _arrow230() if v6 else _arrow231()
            v2_1_mut = pattern_input[0]
            v3_mut = pattern_input[1]
            continue

        break


def closure15(unit_var: None, _arg: tuple[str, Any, int, int]) -> US5:
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
            while method11(v20_1, v22):
                v24: int = v22.l0 or 0
                v25: str = v17_1[v24]
                v21[v24] = v25
                v26: int = (v24 + 1) or 0
                v22.l0 = v26 or 0
            v27: FSharpList[str] = of_array(v21)
            pattern_input: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v27, UH0(0)), v1_1, v2_1, v3)
            return US5(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v43: int = len(v0_1) or 0
            v46: int = (v0_1.find("\n") - 1) or 0
            v48: int = (v43 if (-2 == v46) else v46) or 0
            return US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\"")) + "\' / line: ") + str(v2_1)) + " / col: ") + str(v3)) + "\n") + str(v1_1)) + "") + v0_1[0:v48 + 1]) + "")) + "\n") + (replicate(v3 - 1, " ") + "^")) + "\n")




def closure18(unit_var: None, _arg: tuple[str, Any, int, int]) -> US5:
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
            while method11(v20_1, v22):
                v24: int = v22.l0 or 0
                v25: str = v17_1[v24]
                v21[v24] = v25
                v26: int = (v24 + 1) or 0
                v22.l0 = v26 or 0
            v27: FSharpList[str] = of_array(v21)
            pattern_input: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v27, UH0(0)), v1_1, v2_1, v3)
            return US5(0, v7, v15, pattern_input[0], pattern_input[1], pattern_input[2])

        else: 
            v43: int = len(v0_1) or 0
            v46: int = (v0_1.find("\n") - 1) or 0
            v48: int = (v43 if (-2 == v46) else v46) or 0
            return US5(1, ((("" + (((((((((("parsing.p_char / expected: \'" + str("\'")) + "\' / line: ") + str(v2_1)) + " / col: ") + str(v3)) + "\n") + str(v1_1)) + "") + v0_1[0:v48 + 1]) + "")) + "\n") + (replicate(v3 - 1, " ") + "^")) + "\n")




def method14(v0_1_mut: str, v1_1_mut: Any, v2_1_mut: UH1) -> US5:
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


def method15(v0_1_mut: str, v1_1_mut: int64) -> bool:
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


            def _arrow232(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v11.fields[0] if (v11.tag == 0) else _arrow232()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def method16(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US6:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v70: US5
        if "" == v1_1:
            v70 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'"])), (v2_1, v3, v4)])))

        else: 
            v19_1: str = v1_1[0]
            v21: int = len(v1_1) or 0
            v26: str = v1_1[1:v21 + 1]
            if method15(v19_1, int64(0)) == False:
                v31: str = v19_1
                v34: int = len(v31) or 0
                v35: Array[str] = fill([0] * v34, 0, v34, "")
                v36: Mut5 = Mut5(0)
                while method11(v34, v36):
                    v38: int = v36.l0 or 0
                    v39: str = v31[v38]
                    v35[v38] = v39
                    v40: int = (v38 + 1) or 0
                    v36.l0 = v40 or 0
                v41: FSharpList[str] = of_array(v35)
                pattern_input: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v41, UH0(0)), v2_1, v3, v4)
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


def method17(v0_1_mut: str, v1_1_mut: Any, v2_1_mut: int, v3_mut: int, v4_mut: UH1) -> US5:
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


def method18(v0_1_mut: str, v1_1_mut: int64) -> bool:
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



            def _arrow233(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v15.fields[0] if (v15.tag == 0) else _arrow233()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def method19(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US6:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v76: US5
        if "" == v1_1:
            v76 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\"", "\'", " "])), (v2_1, v3, v4)])))

        else: 
            v22: str = v1_1[0]
            v24: int = len(v1_1) or 0
            v29: str = v1_1[1:v24 + 1]
            if method18(v22, int64(0)) == False:
                v34: str = v22
                v37: int = len(v34) or 0
                v38: Array[str] = fill([0] * v37, 0, v37, "")
                v39: Mut5 = Mut5(0)
                while method11(v37, v39):
                    v41: int = v39.l0 or 0
                    v42: str = v34[v41]
                    v38[v41] = v42
                    v43: int = (v41 + 1) or 0
                    v39.l0 = v43 or 0
                v44: FSharpList[str] = of_array(v38)
                pattern_input: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v44, UH0(0)), v2_1, v3, v4)
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


def method20(v0_1_mut: str, v1_1_mut: int) -> int:
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


def method21(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US6:
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
            while method11(v20_1, v22):
                v24: int = v22.l0 or 0
                v25: str = v17_1[v24]
                v21[v24] = v25
                v26: int = (v24 + 1) or 0
                v22.l0 = v26 or 0
            v27: FSharpList[str] = of_array(v21)
            pattern_input: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v27, UH0(0)), v2_1, v3, v4)
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


def method10(v0_1: str) -> US4:
    _v0: (str | None) | None = None
    _v0 = some(v0_1)
    def _arrow234(__unit: None=None, v0_1: Any=v0_1) -> str | None:
        raise Exception("optionm\'.of_obj / _v0=None")

    v7: str = default_arg(_arrow234() if (_v0 is None) else value_12(_v0), "")
    v11: Any = StringBuilder__ctor_Z721C83C5("")
    def v12(_arg10: tuple[str, Any, int, int], v0_1: Any=v0_1) -> US5:
        return closure15(None, _arg10)

    def v13(_arg10_1: tuple[str, Any, int, int], v0_1: Any=v0_1) -> US5:
        return closure18(None, _arg10_1)

    v17_1: US5 = method14(v7, v11, UH1(1, v12, UH1(1, v13, UH1(0))))
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
            if method15(v37, int64(0)) == False:
                v49: str = v37
                v52: int = len(v49) or 0
                v53: Array[str] = fill([0] * v52, 0, v52, "")
                v54: Mut5 = Mut5(0)
                while method11(v52, v54):
                    v56: int = v54.l0 or 0
                    v57: str = v49[v56]
                    v53[v56] = v57
                    v58: int = (v56 + 1) or 0
                    v54.l0 = v58 or 0
                v59: FSharpList[str] = of_array(v53)
                pattern_input: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v59, UH0(0)), v20_1, v21, v22)
                v88 = US5(0, v37, v44, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v88 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v37, to_array(of_array(["\"", "\'"])), (v20_1, v21, v22)])))


        v100: US5
        if v88.tag == 0:
            v89: str = v88.fields[0]
            v100 = US5(0, "/" if ("\\" == v89) else v89, v88.fields[1], v88.fields[2], v88.fields[3], v88.fields[4])

        else: 
            v100 = US5(1, v88.fields[0])

        v114: US6 = method16(v100.fields[0], v100.fields[1], v100.fields[2], v100.fields[3], v100.fields[4]) if (v100.tag == 0) else US6(1, v100.fields[0])
        v124: US6 = US6(0, v114.fields[0], v114.fields[1], v114.fields[2], v114.fields[3], v114.fields[4]) if (v114.tag == 0) else US6(0, "", v19_1, v20_1, v21, v22)
        if v124.tag == 0:
            v129: int = v124.fields[4] or 0
            v128: int = v124.fields[3] or 0
            v127: Any = v124.fields[2]
            v126: str = v124.fields[1]
            v133: US5 = method17(v126, v127, v128, v129, UH1(1, v12, UH1(1, v13, UH1(0))))
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
            if method18(v177, int64(0)) == False:
                v189: str = v177
                v192: int = len(v189) or 0
                v193: Array[str] = fill([0] * v192, 0, v192, "")
                v194: Mut5 = Mut5(0)
                while method11(v192, v194):
                    v196: int = v194.l0 or 0
                    v197: str = v189[v196]
                    v193[v196] = v197
                    v198: int = (v196 + 1) or 0
                    v194.l0 = v198 or 0
                v199: FSharpList[str] = of_array(v193)
                pattern_input_1: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v199, UH0(0)), v11, 1, 1)
                v233 = US5(0, v177, v184, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])

            else: 
                v233 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v177, to_array(of_array(["\"", "\'", " "])), (v11, 1, 1)])))


        v245: US5
        if v233.tag == 0:
            v234: str = v233.fields[0]
            v245 = US5(0, "/" if ("\\" == v234) else v234, v233.fields[1], v233.fields[2], v233.fields[3], v233.fields[4])

        else: 
            v245 = US5(1, v233.fields[0])

        v259: US6 = method19(v245.fields[0], v245.fields[1], v245.fields[2], v245.fields[3], v245.fields[4]) if (v245.tag == 0) else US6(1, v245.fields[0])
        if v259.tag == 0:
            v303 = v259

        else: 
            v271: US8 = US8(0, v7, v11, 1, 1) if (len(v7) == 0) else US8(1, to_text(interpolate("parsing.eof / expected end of input / input: %A%P()", [v7])))
            v280: US6 = US6(0, "", v271.fields[0], v271.fields[1], v271.fields[2], v271.fields[3]) if (v271.tag == 0) else US6(1, v271.fields[0])
            if v280.tag == 0:
                v282: str = v280.fields[1]
                v287: int = method20(v282, 0) or 0
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
                while method11(v325, v327):
                    v329: int = v327.l0 or 0
                    v330: str = v322[v329]
                    v326[v329] = v330
                    v331: int = (v329 + 1) or 0
                    v327.l0 = v331 or 0
                v332: FSharpList[str] = of_array(v326)
                pattern_input_2: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v332, UH0(0)), v306, v307, v308)
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
                while method11(v405, v407):
                    v409: int = v407.l0 or 0
                    v410: str = v402[v409]
                    v406[v409] = v410
                    v411: int = (v409 + 1) or 0
                    v407.l0 = v411 or 0
                v412: FSharpList[str] = of_array(v406)
                pattern_input_3: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v412, UH0(0)), v387, v388, v389)
                v427 = US5(0, v393, v400, pattern_input_3[0], pattern_input_3[1], pattern_input_3[2])

            v445 = method21(v427.fields[0], v427.fields[1], v427.fields[2], v427.fields[3], v427.fields[4]) if (v427.tag == 0) else US6(1, v427.fields[0])

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



def closure20(v0_1: Mut3, v1_1: str, unit_var: None) -> None:
    v3: str = v0_1.l0 + v1_1
    v0_1.l0 = v3


def closure19(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None, unit_var: None) -> None:
    def v8(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4, v5: Any=v5, v6: Any=v6, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v9: None
    v8(None)
    v9 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v42: None
    v8(None)
    v42 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v74: US0 = pattern_input_1[4].l0
    class ObjectExpr235:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v74, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr235()))):
        v82: None
        closure7(pattern_input[0], None)
        v82 = None
        v86: None
        v8(None)
        v86 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        _v365: FSharpRef[US3 | None] = FSharpRef(None)
        v370: None
        def v367(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4, v5: Any=v5, v6: Any=v6, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v365, v)

        closure9(pattern_input_2[5], v367, None)
        v370 = None
        v385: US3 = default_arg(_v365.contents, US3(1))
        def _arrow236(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4, v5: Any=v5, v6: Any=v6, unit_var: Any=unit_var) -> Any:
            v399: Any = create(op_subtraction(ticks_1(now()), v385.fields[0]))
            return create_1(1, 1, 1, hours(v399), minutes(v399), seconds(v399), milliseconds(v399))

        v430: str = to_string(_arrow236() if (v385.tag == 0) else now(), method6())
        v631: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method7()
        v642: int64 = pattern_input_2[0].l0
        v644: Mut3 = Mut3(method8())
        v651: None
        closure20(v644, ("" + "{ ") + "", None)
        v651 = None
        v660: None
        closure20(v644, ("" + "options") + "", None)
        v660 = None
        v669: None
        closure20(v644, ("" + " = ") + "", None)
        v669 = None
        v677: None
        closure20(v644, ("" + "{ ") + "", None)
        v677 = None
        v686: None
        closure20(v644, ("" + "command") + "", None)
        v686 = None
        v694: None
        closure20(v644, ("" + " = ") + "", None)
        v694 = None
        v702: None
        closure20(v644, ("" + v0_1) + "", None)
        v702 = None
        v711: None
        closure20(v644, ("" + "; ") + "", None)
        v711 = None
        v720: None
        closure20(v644, ("" + "cancellation_token") + "", None)
        v720 = None
        v728: None
        closure20(v644, ("" + " = ") + "", None)
        v728 = None
        v763: None
        closure20(v644, ("" + to_text(interpolate("%A%P()", [v1_1]))) + "", None)
        v763 = None
        v771: None
        closure20(v644, ("" + "; ") + "", None)
        v771 = None
        v780: None
        closure20(v644, ("" + "environment_variables") + "", None)
        v780 = None
        v788: None
        closure20(v644, ("" + " = ") + "", None)
        v788 = None
        v799: None
        closure20(v644, ("" + to_text(interpolate("%A%P()", [v2_1]))) + "", None)
        v799 = None
        v807: None
        closure20(v644, ("" + "; ") + "", None)
        v807 = None
        v816: None
        closure20(v644, ("" + "on_line") + "", None)
        v816 = None
        v824: None
        closure20(v644, ("" + " = ") + "", None)
        v824 = None
        v859: None
        closure20(v644, ("" + to_text(interpolate("%A%P()", [v3]))) + "", None)
        v859 = None
        v867: None
        closure20(v644, ("" + "; ") + "", None)
        v867 = None
        v876: None
        closure20(v644, ("" + "stdin") + "", None)
        v876 = None
        v884: None
        closure20(v644, ("" + " = ") + "", None)
        v884 = None
        v919: None
        closure20(v644, ("" + to_text(interpolate("%A%P()", [v4]))) + "", None)
        v919 = None
        v927: None
        closure20(v644, ("" + "; ") + "", None)
        v927 = None
        v936: None
        closure20(v644, ("" + "trace") + "", None)
        v936 = None
        v944: None
        closure20(v644, ("" + " = ") + "", None)
        v944 = None
        v955: None
        closure20(v644, ("" + ("true" if v5 else "false")) + "", None)
        v955 = None
        v963: None
        closure20(v644, ("" + "; ") + "", None)
        v963 = None
        v972: None
        closure20(v644, ("" + "working_directory") + "", None)
        v972 = None
        v980: None
        closure20(v644, ("" + " = ") + "", None)
        v980 = None
        v1015: None
        closure20(v644, ("" + to_text(interpolate("%A%P()", [v6]))) + "", None)
        v1015 = None
        v1024: None
        closure20(v644, ("" + " }") + "", None)
        v1024 = None
        v1032: None
        closure20(v644, ("" + " }") + "", None)
        v1032 = None
        v1094: str = trim_end(trim_start(((((((((("" + v430) + " ") + v631) + " #") + str(v642)) + " ") + "runtime.execute_with_options_async") + " / ") + v644.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v1094)
        pattern_input[1].l0(v1094)



def closure22(v0_1: FSharpRef[US12 | None], v1_1: US12 | None=None) -> FSharpRef[US12 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure23(v0_1: Callable[[tuple[int, str, bool]], Async[None]] | None, v1_1: Callable[[US12 | None], FSharpRef[US12 | None]], unit_var: None) -> None:
    def _arrow237(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US12 | None:
        x: Callable[[tuple[int, str, bool]], Async[None]] = v0_1
        def x_1(__unit: None=None) -> US12:
            return US12(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow237()))


def closure24(v0_1: str, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v36: None
    v2_1(None)
    v36 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v68: US0 = pattern_input_1[4].l0
    class ObjectExpr238:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (0 >= find(v68, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr238()))):
        v76: None
        closure7(pattern_input[0], None)
        v76 = None
        v80: None
        v2_1(None)
        v80 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        _v359: FSharpRef[US3 | None] = FSharpRef(None)
        v364: None
        def v361(v: US3 | None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v359, v)

        closure9(pattern_input_2[5], v361, None)
        v364 = None
        v379: US3 = default_arg(_v359.contents, US3(1))
        def _arrow239(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v393: Any = create(op_subtraction(ticks_1(now()), v379.fields[0]))
            return create_1(1, 1, 1, hours(v393), minutes(v393), seconds(v393), milliseconds(v393))

        v424: str = to_string(_arrow239() if (v379.tag == 0) else now(), method6())
        v625: str = ("\u001b[90m" + pad_left("Verbose".lower(), 7, " ")) + method7()
        v636: int64 = pattern_input_2[0].l0
        v638: Mut3 = Mut3(method8())
        v697: str = "" if (v0_1 == "") else trim_end(trim_start(((((((((("" + v424) + " ") + v625) + " #") + str(v636)) + " ") + v0_1) + " / ") + v638.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v697)
        pattern_input[1].l0(v697)



def closure21(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None, v7: None, v8: Any, v9: None) -> None:
    pass


def closure25(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None, v7: None, v8: Any, v9: None) -> None:
    pass


def closure26(v0_1: FSharpRef[US13 | None], v1_1: US13 | None=None) -> FSharpRef[US13 | None]:
    v0_1.contents = v1_1
    return v0_1


def closure27(v0_1: CancellationToken | None, v1_1: Callable[[US13 | None], FSharpRef[US13 | None]], unit_var: None) -> None:
    def _arrow240(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> US13 | None:
        x: CancellationToken = v0_1
        def x_1(__unit: None=None) -> US13:
            return US13(0, x)

        return x_1(None)

    ignore(v1_1(None if (v0_1 is None) else _arrow240()))


def closure28(v0_1: None, unit_var: None) -> None:
    if None == False:
        pass



def closure29(v0_1: Any, unit_var: None) -> None:
    def v2_1(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v3: None
    v2_1(None)
    v3 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v36: None
    v2_1(None)
    v36 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v68: US0 = pattern_input_1[4].l0
    class ObjectExpr241:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (3 >= find(v68, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr241()))):
        v76: None
        closure7(pattern_input[0], None)
        v76 = None
        v80: None
        v2_1(None)
        v80 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        _v359: FSharpRef[US3 | None] = FSharpRef(None)
        v364: None
        def v361(v: US3 | None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v359, v)

        closure9(pattern_input_2[5], v361, None)
        v364 = None
        v379: US3 = default_arg(_v359.contents, US3(1))
        def _arrow242(__unit: None=None, v0_1: Any=v0_1, unit_var: Any=unit_var) -> Any:
            v393: Any = create(op_subtraction(ticks_1(now()), v379.fields[0]))
            return create_1(1, 1, 1, hours(v393), minutes(v393), seconds(v393), milliseconds(v393))

        v424: str = to_string(_arrow242() if (v379.tag == 0) else now(), method6())
        v625: str = ("\u001b[93m" + pad_left("Warning".lower(), 7, " ")) + method7()
        v636: int64 = pattern_input_2[0].l0
        v638: Mut3 = Mut3(method8())
        v645: None
        closure20(v638, ("" + "{ ") + "", None)
        v645 = None
        v654: None
        closure20(v638, ("" + "ex") + "", None)
        v654 = None
        v663: None
        closure20(v638, ("" + " = ") + "", None)
        v663 = None
        v698: None
        closure20(v638, ("" + to_text(interpolate("%A%P()", [v0_1]))) + "", None)
        v698 = None
        v707: None
        closure20(v638, ("" + " }") + "", None)
        v707 = None
        v769: str = trim_end(trim_start(((((((((("" + v424) + " ") + v625) + " #") + str(v636)) + " ") + "runtime.execute_with_options_async / WaitForExitAsync") + " / ") + v638.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v769)
        pattern_input[1].l0(v769)



def closure30(v0_1: int, v1_1: str, unit_var: None) -> None:
    def v3(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> None:
        closure0(None, None)

    v4: None
    v3(None)
    v4 = None
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v37: None
    v3(None)
    v37 = None
    pattern_input_1: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
    v69: US0 = pattern_input_1[4].l0
    class ObjectExpr243:
        @property
        def Compare(self) -> Callable[[US0, US0], int]:
            return compare

    if False if (pattern_input_1[2].l0 == False) else (1 >= find(v69, of_seq(to_enumerable([(US0(0), 0), (US0(1), 1), (US0(2), 2), (US0(3), 3), (US0(4), 4)]), ObjectExpr243()))):
        v77: None
        closure7(pattern_input[0], None)
        v77 = None
        v81: None
        v3(None)
        v81 = None
        pattern_input_2: tuple[Mut0, Mut1, Mut2, Mut3, Mut4, int64 | None] = value_12(TraceState_trace_state())
        _v360: FSharpRef[US3 | None] = FSharpRef(None)
        v365: None
        def v362(v: US3 | None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> FSharpRef[US3 | None]:
            return closure8(_v360, v)

        closure9(pattern_input_2[5], v362, None)
        v365 = None
        v380: US3 = default_arg(_v360.contents, US3(1))
        def _arrow244(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, unit_var: Any=unit_var) -> Any:
            v394: Any = create(op_subtraction(ticks_1(now()), v380.fields[0]))
            return create_1(1, 1, 1, hours(v394), minutes(v394), seconds(v394), milliseconds(v394))

        v425: str = to_string(_arrow244() if (v380.tag == 0) else now(), method6())
        v626: str = ("\u001b[94m" + pad_left("Debug".lower(), 7, " ")) + method7()
        v637: int64 = pattern_input_2[0].l0
        v638: int = len(v1_1) or 0
        v640: Mut3 = Mut3(method8())
        v647: None
        closure20(v640, ("" + "{ ") + "", None)
        v647 = None
        v656: None
        closure20(v640, ("" + "exit_code") + "", None)
        v656 = None
        v665: None
        closure20(v640, ("" + " = ") + "", None)
        v665 = None
        v673: None
        closure20(v640, ("" + str(v0_1)) + "", None)
        v673 = None
        v682: None
        closure20(v640, ("" + "; ") + "", None)
        v682 = None
        v691: None
        closure20(v640, ("" + "output_length") + "", None)
        v691 = None
        v699: None
        closure20(v640, ("" + " = ") + "", None)
        v699 = None
        v707: None
        closure20(v640, ("" + str(v638)) + "", None)
        v707 = None
        v716: None
        closure20(v640, ("" + " }") + "", None)
        v716 = None
        v778: str = trim_end(trim_start(((((((((("" + v425) + " ") + v626) + " #") + str(v637)) + " ") + "runtime.execute_with_options_async") + " / ") + v640.l0) + "", *to_array(empty())), *to_array(of_array([" ", "/"])))
        closure10(None, v778)
        pattern_input[1].l0(v778)



def method9(v0_1: str, v1_1: CancellationToken | None, v2_1: Array[tuple[str, str]], v3: Callable[[tuple[int, str, bool]], Async[None]] | None, v4: Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, v5: bool, v6: str | None=None) -> Async[tuple[int, str]]:
    return None


def closure14(unit_var: None, v0_1: str) -> Async[tuple[int, str]]:
    return method9(v0_1, None, [], None, None, True, None)


def closure31(unit_var: None, _arg: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return method9(_arg[0], _arg[1], _arg[2], _arg[3], _arg[4], _arg[5], _arg[6])


def closure32(unit_var: None, v0_1: Callable[[Heap0], Heap0]) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]:
    v8: Heap0 = v0_1(Heap0("", None, [], None, None, True, None))
    return (v8.l0, v8.l1, v8.l2, v8.l3, v8.l4, v8.l5, v8.l6)


def method24(v0_1_mut: str, v1_1_mut: int64) -> bool:
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




            def _arrow245(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v19_1.fields[0] if (v19_1.tag == 0) else _arrow245()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def method25(v0_1_mut: str, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US6:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v82: US5
        if "" == v1_1:
            v82 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3, v4)])))

        else: 
            v25: str = v1_1[0]
            v27: int = len(v1_1) or 0
            v32: str = v1_1[1:v27 + 1]
            if method24(v25, int64(0)) == False:
                v37: str = v25
                v40: int = len(v37) or 0
                v41: Array[str] = fill([0] * v40, 0, v40, "")
                v42: Mut5 = Mut5(0)
                while method11(v40, v42):
                    v44: int = v42.l0 or 0
                    v45: str = v37[v44]
                    v41[v44] = v45
                    v46: int = (v44 + 1) or 0
                    v42.l0 = v46 or 0
                v47: FSharpList[str] = of_array(v41)
                pattern_input: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v47, UH0(0)), v2_1, v3, v4)
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


def method27(v0_1_mut: str, v1_1_mut: int64) -> bool:
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



            def _arrow246(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1) -> str:
                raise Exception("Option does not have a value.")

            if v0_1 == (v15.fields[0] if (v15.tag == 0) else _arrow246()):
                return True

            else: 
                v0_1_mut = v0_1
                v1_1_mut = op_addition(v1_1, int64(1))
                continue


        break


def closure34(unit_var: None, _arg: tuple[str, Any, int, int]) -> US6:
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
            while method11(v20_1, v22):
                v24: int = v22.l0 or 0
                v25: str = v17_1[v24]
                v21[v24] = v25
                v26: int = (v24 + 1) or 0
                v22.l0 = v26 or 0
            v27: FSharpList[str] = of_array(v21)
            pattern_input: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v27, UH0(0)), v1_1, v2_1, v3)
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
            while method11(v88, v90):
                v92: int = v90.l0 or 0
                v93: str = v85[v92]
                v89[v92] = v93
                v94: int = (v92 + 1) or 0
                v90.l0 = v94 or 0
            v95: FSharpList[str] = of_array(v89)
            pattern_input_1: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v95, UH0(0)), v70, v71, v72)
            v114 = US5(0, v76, v83, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])


    else: 
        v114 = US5(1, v67.fields[0])

    if v114.tag == 0:
        return US6(0, ((("" + str("\\")) + "") + str(v114.fields[0])) + "", v114.fields[1], v114.fields[2], v114.fields[3], v114.fields[4])

    else: 
        return US6(1, v114.fields[0])



def closure35(unit_var: None, _arg: tuple[str, Any, int, int]) -> US6:
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
            while method11(v20_1, v22):
                v24: int = v22.l0 or 0
                v25: str = v17_1[v24]
                v21[v24] = v25
                v26: int = (v24 + 1) or 0
                v22.l0 = v26 or 0
            v27: FSharpList[str] = of_array(v21)
            pattern_input: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v27, UH0(0)), v1_1, v2_1, v3)
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
            while method11(v88, v90):
                v92: int = v90.l0 or 0
                v93: str = v85[v92]
                v89[v92] = v93
                v94: int = (v92 + 1) or 0
                v90.l0 = v94 or 0
            v95: FSharpList[str] = of_array(v89)
            pattern_input_1: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v95, UH0(0)), v70, v71, v72)
            v114 = US5(0, v76, v83, pattern_input_1[0], pattern_input_1[1], pattern_input_1[2])


    else: 
        v114 = US5(1, v67.fields[0])

    if v114.tag == 0:
        return US6(0, ((("" + str("`")) + "") + str(v114.fields[0])) + "", v114.fields[1], v114.fields[2], v114.fields[3], v114.fields[4])

    else: 
        return US6(1, v114.fields[0])



def method28(v0_1_mut: str, v1_1_mut: Any, v2_1_mut: int, v3_mut: int, v4_mut: UH3) -> US6:
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


def method29(v0_1_mut: UH2, v1_1_mut: UH2) -> UH2:
    while True:
        (v0_1, v1_1) = (v0_1_mut, v1_1_mut)
        if v0_1.tag == 0:
            return v1_1

        else: 
            v0_1_mut = v0_1.fields[1]
            v1_1_mut = UH2(1, v0_1.fields[0], v1_1)
            continue

        break


def method26(v0_1_mut: UH2, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US15:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v76: US5
        if "" == v1_1:
            v76 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\""])), (v2_1, v3, v4)])))

        else: 
            v22: str = v1_1[0]
            v24: int = len(v1_1) or 0
            v29: str = v1_1[1:v24 + 1]
            if method27(v22, int64(0)) == False:
                v34: str = v22
                v37: int = len(v34) or 0
                v38: Array[str] = fill([0] * v37, 0, v37, "")
                v39: Mut5 = Mut5(0)
                while method11(v37, v39):
                    v41: int = v39.l0 or 0
                    v42: str = v34[v41]
                    v38[v41] = v42
                    v43: int = (v41 + 1) or 0
                    v39.l0 = v43 or 0
                v44: FSharpList[str] = of_array(v38)
                pattern_input: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v44, UH0(0)), v2_1, v3, v4)
                v76 = US5(0, v22, v29, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v76 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v22, to_array(of_array(["\\", "`", "\""])), (v2_1, v3, v4)])))


        v90: US6 = US6(0, v76.fields[0], v76.fields[1], v76.fields[2], v76.fields[3], v76.fields[4]) if (v76.tag == 0) else US6(1, v76.fields[0])
        def v97(_arg10: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> US6:
            return closure34(None, _arg10)

        def v98(_arg10_1: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> US6:
            return closure35(None, _arg10_1)

        v104: US6 = v90 if (v90.tag == 0) else method28(v1_1, v2_1, v3, v4, UH3(1, v97, UH3(1, v98, UH3(0))))
        if v104.tag == 0:
            v0_1_mut = UH2(1, v104.fields[0], v0_1)
            v1_1_mut = v104.fields[1]
            v2_1_mut = v104.fields[2]
            v3_mut = v104.fields[3]
            v4_mut = v104.fields[4]
            continue

        else: 
            return US15(0, method29(v0_1, UH2(0)), v1_1, v2_1, v3, v4)

        break


def method30(v0_1: UH2, v1_1: FSharpList[str]) -> FSharpList[str]:
    if v0_1.tag == 0:
        return v1_1

    else: 
        return cons(v0_1.fields[0], method30(v0_1.fields[1], v1_1))



def method31(v0_1_mut: UH2, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US15:
    while True:
        (v0_1, v1_1, v2_1, v3, v4) = (v0_1_mut, v1_1_mut, v2_1_mut, v3_mut, v4_mut)
        v76: US5
        if "" == v1_1:
            v76 = US5(1, to_text(interpolate("parsing.none_of / unexpected end of input / chars: %A%P() / s: %A%P()", [to_array(of_array(["\\", "`", "\""])), (v2_1, v3, v4)])))

        else: 
            v22: str = v1_1[0]
            v24: int = len(v1_1) or 0
            v29: str = v1_1[1:v24 + 1]
            if method27(v22, int64(0)) == False:
                v34: str = v22
                v37: int = len(v34) or 0
                v38: Array[str] = fill([0] * v37, 0, v37, "")
                v39: Mut5 = Mut5(0)
                while method11(v37, v39):
                    v41: int = v39.l0 or 0
                    v42: str = v34[v41]
                    v38[v41] = v42
                    v43: int = (v41 + 1) or 0
                    v39.l0 = v43 or 0
                v44: FSharpList[str] = of_array(v38)
                pattern_input: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v44, UH0(0)), v2_1, v3, v4)
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
            return US15(0, method29(v0_1, UH2(0)), v1_1, v2_1, v3, v4)

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


def method23(v0_1_mut: UH2, v1_1_mut: str, v2_1_mut: Any, v3_mut: int, v4_mut: int) -> US15:
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
            if method24(v25, int64(0)) == False:
                v37: str = v25
                v40: int = len(v37) or 0
                v41: Array[str] = fill([0] * v40, 0, v40, "")
                v42: Mut5 = Mut5(0)
                while method11(v40, v42):
                    v44: int = v42.l0 or 0
                    v45: str = v37[v44]
                    v41[v44] = v45
                    v46: int = (v44 + 1) or 0
                    v42.l0 = v46 or 0
                v47: FSharpList[str] = of_array(v41)
                pattern_input: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v47, UH0(0)), v2_1, v3, v4)
                v82 = US5(0, v25, v32, pattern_input[0], pattern_input[1], pattern_input[2])

            else: 
                v82 = US5(1, to_text(interpolate("parsing.none_of / unexpected char: \'%P()\' / chars: %A%P() / s: %A%P()", [v25, to_array(of_array(["\\", "`", "\"", " "])), (v2_1, v3, v4)])))


        v96: US6 = method25(v82.fields[0], v82.fields[1], v82.fields[2], v82.fields[3], v82.fields[4]) if (v82.tag == 0) else US6(1, v82.fields[0])
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
                    while method11(v118, v120):
                        v122: int = v120.l0 or 0
                        v123: str = v115[v122]
                        v119[v122] = v123
                        v124: int = (v122 + 1) or 0
                        v120.l0 = v124 or 0
                    v125: FSharpList[str] = of_array(v119)
                    pattern_input_1: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v125, UH0(0)), v2_1, v3, v4)
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
                v172: US15 = method26(UH2(0), v167, v168, v169, v170)
                v193: US6
                if v172.tag == 0:
                    v179: FSharpList[str] = method30(v172.fields[0], empty())
                    def _arrow248(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> IEnumerable_1[str]:
                        def _arrow247(i: int) -> str:
                            return item(i, v179)

                        return map(_arrow247, range_big_int(0, 1, length(v179) - 1))

                    v193 = US6(0, join("", delay(_arrow248)), v172.fields[1], v172.fields[2], v172.fields[3], v172.fields[4])

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
                            while method11(v215, v217):
                                v219: int = v217.l0 or 0
                                v220: str = v212[v219]
                                v216[v219] = v220
                                v221: int = (v219 + 1) or 0
                                v217.l0 = v221 or 0
                            v222: FSharpList[str] = of_array(v216)
                            pattern_input_2: tuple[Any, int, int] = method13(fold_back(uncurry2(method12()), v222, UH0(0)), v196, v197, v198)
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
                    return closure34(None, _arg10)

                def v290(_arg10_1: tuple[str, Any, int, int], v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> US6:
                    return closure35(None, _arg10_1)

                v294: US6 = method28(v1_1, v2_1, v3, v4, UH3(1, v289, UH3(1, v290, UH3(0))))
                v305: US6 = US6(0, "", v294.fields[1], v294.fields[2], v294.fields[3], v294.fields[4]) if (v294.tag == 0) else US6(1, v294.fields[0])
                v316: US15 = method31(UH2(0), v305.fields[1], v305.fields[2], v305.fields[3], v305.fields[4]) if (v305.tag == 0) else US15(1, v305.fields[0])
                if v316.tag == 0:
                    v323: FSharpList[str] = method30(v316.fields[0], empty())
                    def _arrow250(__unit: None=None, v0_1: Any=v0_1, v1_1: Any=v1_1, v2_1: Any=v2_1, v3: Any=v3, v4: Any=v4) -> IEnumerable_1[str]:
                        def _arrow249(i_1: int) -> str:
                            return item(i_1, v323)

                        return map(_arrow249, range_big_int(0, 1, length(v323) - 1))

                    v341 = US6(0, join("", delay(_arrow250)), v316.fields[1], v316.fields[2], v316.fields[3], v316.fields[4])

                else: 
                    v341 = US6(1, v316.fields[0])



        if v341.tag == 0:
            v350: int = v341.fields[4] or 0
            v349: int = v341.fields[3] or 0
            v348: Any = v341.fields[2]
            v347: str = v341.fields[1]
            v346: str = v341.fields[0]
            v352: int = method32(v347, 0) or 0
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
                return US15(0, method29(v0_1, UH2(1, v346, UH2(0))), v347, v348, v349, v350)


        else: 
            return US15(0, method29(v0_1, UH2(0)), v1_1, v2_1, v3, v4)

        break


def method22(v0_1: str) -> US14:
    _v0: (str | None) | None = None
    _v0 = some(v0_1)
    def _arrow251(__unit: None=None, v0_1: Any=v0_1) -> str | None:
        raise Exception("optionm\'.of_obj / _v0=None")

    v15: US15 = method23(UH2(0), default_arg(_arrow251() if (_v0 is None) else value_12(_v0), ""), StringBuilder__ctor_Z721C83C5(""), 1, 1)
    if v15.tag == 0:
        return US14(0, to_array(method30(v15.fields[0], empty())))

    else: 
        return US14(1, v15.fields[0])



def closure33(unit_var: None, v0_1: str) -> FSharpResult_2[Array[str], str]:
    v1_1: US14 = method22(v0_1)
    if v1_1.tag == 0:
        return FSharpResult_2(0, v1_1.fields[0])

    else: 
        return FSharpResult_2(1, v1_1.fields[0])



v0: None = None

def _arrow252(__unit: None=None) -> None:
    closure0(None, None)


v1: Callable[[], None] = _arrow252

def _expr253():
    v1(None)
    return v0


v2: None = _expr253()

def _arrow254(__unit: None=None) -> None:
    closure4(None, None)


v16: Callable[[], None] = _arrow254

def current_process_kill(__unit: None=None) -> None:
    v16(None)


def _arrow255(v: str) -> Async[tuple[int, str]]:
    return closure14(None, v)


v17: Callable[[str], Async[tuple[int, str]]] = _arrow255

def execute_async(x: str) -> Async[tuple[int, str]]:
    return v17(x)


def _arrow256(_arg10: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return closure31(None, _arg10)


v18: Callable[[tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]], Async[tuple[int, str]]] = _arrow256

def execute_with_options_async(x: tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]) -> Async[tuple[int, str]]:
    return v18(x)


def _arrow257(v: Callable[[Heap0], Heap0]) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]:
    return closure32(None, v)


v19: Callable[[Callable[[Heap0], Heap0]], tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]] = _arrow257

def execution_options(x: Callable[[Heap0], Heap0]) -> tuple[str, CancellationToken | None, Array[tuple[str, str]], Callable[[tuple[int, str, bool]], Async[None]] | None, Callable[[std_sync_arc_1[std_sync_mutex_1[std_process_child_stdin]]], None] | None, bool, str | None]:
    return v19(x)


def _arrow258(v: str) -> FSharpResult_2[Array[str], str]:
    return closure33(None, v)


v20: Callable[[str], FSharpResult_2[Array[str], str]] = _arrow258

def split_args(x: str) -> FSharpResult_2[Array[str], str]:
    return v20(x)


