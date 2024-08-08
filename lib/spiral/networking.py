from __future__ import annotations
from abc import abstractmethod
from collections.abc import Callable
from dataclasses import dataclass
import os
from typing import (Any, Protocol)
from fable_modules.fable_library.async_builder import Async
from fable_modules.fable_library.date import (ticks, now)
from fable_modules.fable_library.option import (some, value as value_1, default_arg)
from fable_modules.fable_library.reflection import (TypeInfo, union_type, int64_type, record_type, string_type, unit_type, lambda_type, bool_type, class_type, int32_type)
from fable_modules.fable_library.types import (int64, Array, Union, Record, FSharpRef)
from fable_modules.fable_library.util import create_atom

State_trace_state: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] | None = create_atom(None)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr115() -> TypeInfo:
    return union_type("Networking.US0", [], US0, lambda: [[], [], [], [], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1", "US0_2", "US0_3", "US0_4"]


US0_reflection = _expr115

def _expr116() -> TypeInfo:
    return record_type("Networking.Mut0", [], Mut0, lambda: [("l0", int64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: int64

Mut0_reflection = _expr116

def _expr117() -> TypeInfo:
    return record_type("Networking.Mut1", [], Mut1, lambda: [("l0", lambda_type(string_type, unit_type))])


@dataclass(eq = False, repr = False, slots = True)
class Mut1(Record):
    l0: Callable[[str], None]

Mut1_reflection = _expr117

def _expr118() -> TypeInfo:
    return record_type("Networking.Mut2", [], Mut2, lambda: [("l0", bool_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut2(Record):
    l0: bool

Mut2_reflection = _expr118

def _expr119() -> TypeInfo:
    return record_type("Networking.Mut3", [], Mut3, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False, slots = True)
class Mut3(Record):
    l0: US0

Mut3_reflection = _expr119

def _expr120() -> TypeInfo:
    return union_type("Networking.US1", [], US1, lambda: [[("f0_0", string_type)], []])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr120

def _expr121() -> TypeInfo:
    return union_type("Networking.US2", [], US2, lambda: [[("f0_0", US0_reflection())], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr121

def _expr122() -> TypeInfo:
    return union_type("Networking.US3", [], US3, lambda: [[("f0_0", int64_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr122

def _expr123() -> TypeInfo:
    return record_type("Networking.Mut4", [], Mut4, lambda: [("l0", string_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut4(Record):
    l0: str

Mut4_reflection = _expr123

def _expr124() -> TypeInfo:
    return union_type("Networking.US4", [], US4, lambda: [[("f0_0", bool_type)], []])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1"]


US4_reflection = _expr124

def _expr125() -> TypeInfo:
    return union_type("Networking.US5", [], US5, lambda: [[("f0_0", bool_type)], [("f1_0", class_type("System.Exception"))]])


class US5(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US5_0", "US5_1"]


US5_reflection = _expr125

def _expr126() -> TypeInfo:
    return union_type("Networking.US6", [], US6, lambda: [[("f0_0", bool_type)], [("f1_0", class_type("System.Exception"))]])


class US6(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US6_0", "US6_1"]


US6_reflection = _expr126

def _expr127() -> TypeInfo:
    return union_type("Networking.US7", [], US7, lambda: [[("f0_0", int32_type)], []])


class US7(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US7_0", "US7_1"]


US7_reflection = _expr127

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
        v61 = value_1(_v56)

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
    def _arrow128(__unit: None=None, v0_1: Any=v0_1) -> US2:
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




    _v1: tuple[US2, US3] = (US2(0, v178.fields[0]) if (v178.tag == 0) else _arrow128(), US3(0, ticks(now())) if (method2(method4()) == "True") else US3(1))
    v295: US3 = _v1[1]
    v294: US2 = _v1[0]
    def v365(v: str, v0_1: Any=v0_1) -> None:
        closure0(None, v)

    return (Mut0(int64(0)), Mut1(v365), Mut2(True), Mut3(v294.fields[0] if (v294.tag == 0) else v0_1), v295.fields[0] if (v295.tag == 0) else None)


def method5(__unit: None=None) -> str:
    return "hh:mm:ss"


def method6(__unit: None=None) -> str:
    return "HH:mm:ss"


def method7(__unit: None=None) -> str:
    return "\u001b[0m"


def method8(__unit: None=None) -> str:
    return ""


def closure3(unit_var: None, unit_var_1: None) -> str:
    return "networking.test_port_open"


def closure2(v0_1: str, v1: int) -> Async[bool]:
    return None


def closure1(unit_var: None, v0_1: str) -> Callable[[int], Async[bool]]:
    def _arrow129(v: int, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Async[bool]:
        return closure2(v0_1, v)

    return _arrow129


def closure7(unit_var: None, v0_1: bool) -> US5:
    return US5(0, v0_1)


def closure8(unit_var: None, v0_1: Exception) -> US5:
    return US5(1, v0_1)


def closure9(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async"


def closure10(unit_var: None, unit_var_1: None) -> str:
    return "async.run_with_timeout_async**"


def closure6(v0_1: int, v1: str, v2: int) -> Async[bool]:
    return None


def closure5(v0_1: int, v1: str) -> Callable[[int], Async[bool]]:
    def _arrow130(v: int, v0_1: Any=v0_1, v1: Any=v1) -> Async[bool]:
        return closure6(v0_1, v1, v)

    return _arrow130


def closure4(unit_var: None, v0_1: int) -> Callable[[str, int], Async[bool]]:
    def _arrow131(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[bool]]:
        return closure5(v0_1, v)

    return _arrow131


def closure15(unit_var: None, unit_var_1: None) -> str:
    return "networking.wait_for_port_access"


def method9(v0_1: int | None, v1: bool, v2: str, v3: int, v4: int64) -> Async[int64]:
    return None


def closure14(v0_1: int | None, v1: bool, v2: str, v3: int) -> Async[int64]:
    return method9(v0_1, v1, v2, v3, int64(0))


def closure13(v0_1: int | None, v1: bool, v2: str) -> Callable[[int], Async[int64]]:
    def _arrow132(v: int, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2) -> Async[int64]:
        return closure14(v0_1, v1, v2, v)

    return _arrow132


def closure12(v0_1: int | None, v1: bool) -> Callable[[str, int], Async[int64]]:
    def _arrow133(v: str, v0_1: Any=v0_1, v1: Any=v1) -> Callable[[int], Async[int64]]:
        return closure13(v0_1, v1, v)

    return _arrow133


def closure11(unit_var: None, v0_1: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    def _arrow134(v: bool, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[str, int], Async[int64]]:
        return closure12(v0_1, v)

    return _arrow134


def method10(v0_1: int | None, v1: str, v2: int) -> Async[int]:
    return None


def closure18(v0_1: int | None, v1: str, v2: int) -> Async[int]:
    return method10(v0_1, v1, v2)


def closure17(v0_1: int | None, v1: str) -> Callable[[int], Async[int]]:
    def _arrow135(v: int, v0_1: Any=v0_1, v1: Any=v1) -> Async[int]:
        return closure18(v0_1, v1, v)

    return _arrow135


def closure16(unit_var: None, v0_1: int | None=None) -> Callable[[str, int], Async[int]]:
    def _arrow136(v: str, unit_var: Any=unit_var, v0_1: Any=v0_1) -> Callable[[int], Async[int]]:
        return closure17(v0_1, v)

    return _arrow136


v0: bool = State_trace_state() is None


if v0:
    pattern_input: tuple[Mut0, Mut1, Mut2, Mut3, int64 | None] = method0(US0(0))
    State_trace_state((pattern_input[0], pattern_input[1], pattern_input[2], pattern_input[3], pattern_input[4]))


def _arrow137(v: str) -> Callable[[int], Async[bool]]:
    return closure1(None, v)


v12: Callable[[str, int], Async[bool]] = _arrow137

def test_port_open(x: str) -> Callable[[int], Async[bool]]:
    return v12(x)


def _arrow138(v: int) -> Callable[[str, int], Async[bool]]:
    return closure4(None, v)


v13: Callable[[int, str, int], Async[bool]] = _arrow138

def test_port_open_timeout(x: int) -> Callable[[str, int], Async[bool]]:
    return v13(x)


def _arrow139(v: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return closure11(None, v)


v14: Callable[[int | None, bool, str, int], Async[int64]] = _arrow139

def wait_for_port_access(x: int | None=None) -> Callable[[bool, str, int], Async[int64]]:
    return v14(x)


def _arrow140(v: int | None=None) -> Callable[[str, int], Async[int]]:
    return closure16(None, v)


v15: Callable[[int | None, str, int], Async[int]] = _arrow140

def get_available_port(x: int | None=None) -> Callable[[str, int], Async[int]]:
    return v15(x)


