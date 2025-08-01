from __future__ import annotations
import sys
import os
sys.path.insert(0, f'{os.path.dirname(__file__)}/../../../../lib/python/fable')
from abc import abstractmethod
from fable_modules.fable_library.array_ import fill
from fable_modules.fable_library.async_ import (sleep, start_immediate)
from fable_modules.fable_library.async_builder import (singleton as singleton_1, Async)
from fable_modules.fable_library.double import divide
from fable_modules.fable_library.list import (of_array, FSharpList)
from fable_modules.fable_library.option import (some, value as value_4, default_arg, map)
from fable_modules.fable_library.range import range_big_int
from fable_modules.fable_library.reflection import (TypeInfo, union_type, string_type, float64_type, record_type, int32_type, char_type)
from fable_modules.fable_library.seq import (delay, enumerate_while, append, singleton, empty, collect, choose, iterate)
from fable_modules.fable_library.system_text import (StringBuilder__Append_Z721C83C5, StringBuilder__AppendLine, StringBuilder__ctor_Z721C83C5)
from fable_modules.fable_library.thread import sleep as sleep_1
from fable_modules.fable_library.types import (Array, Union, Record, to_string)
from fable_modules.fable_library.util import (IEnumerable_1, to_enumerable)
from collections.abc import Callable
from dataclasses import dataclass
from math import (sin, cos)


from typing import (Any, Protocol)

class IOsEnviron(Protocol):
    @abstractmethod
    def environ(self) -> Any:
        ...


def _expr257() -> TypeInfo:
    return union_type("Cube.US0", [], US0, lambda: [[], [], []])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US0_0", "US0_1", "US0_2"]


US0_reflection = _expr257

def _expr259() -> TypeInfo:
    return union_type("Cube.US1", [], US1, lambda: [[("f0_0", US0_reflection())], [("f1_0", US0_reflection())], [("f2_0", US0_reflection())], [("f3_0", US0_reflection())], [("f4_0", US0_reflection())], [("f5_0", US0_reflection())], [("f6_0", US0_reflection())]])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US1_0", "US1_1", "US1_2", "US1_3", "US1_4", "US1_5", "US1_6"]


US1_reflection = _expr259

def _expr260() -> TypeInfo:
    return union_type("Cube.US2", [], US2, lambda: [[("f0_0", string_type)], []])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr260

def _expr261() -> TypeInfo:
    return record_type("Cube.Mut0", [], Mut0, lambda: [("l0", float64_type)])


@dataclass(eq = False, repr = False, slots = True)
class Mut0(Record):
    l0: float

Mut0_reflection = _expr261

def _expr262() -> TypeInfo:
    return union_type("Cube.US3", [], US3, lambda: [[("f0_0", int32_type), ("f0_1", float64_type), ("f0_2", char_type)], []])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr262

def _expr263() -> TypeInfo:
    return union_type("Cube.US4", [], US4, lambda: [[("f0_0", float64_type), ("f0_1", char_type)], []])


class US4(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> list[str]:
        return ["US4_0", "US4_1"]


US4_reflection = _expr263

def method0(__unit: None=None) -> str:
    return "VSCODE_PID"


def method2(v0_1: str) -> str:
    return v0_1


def method3(__unit: None=None) -> str:
    return ""


def closure1(unit_var: None, v0_1: str) -> US2:
    return US2(0, v0_1)


def method4(__unit: None=None) -> Callable[[str], US2]:
    def _arrow264(v: str) -> US2:
        return closure1(None, v)

    return _arrow264


def method1(v0_1: str) -> str:
    v31: IOsEnviron = os
    v33: Any = v31.environ
    _v38: (str | None) | None = None
    x: str | None = v33.get(v0_1)
    _v38 = some(x)
    v44: str | None
    if _v38 is None:
        raise Exception("optionm\'.of_obj / _v38=None")

    else: 
        v44 = value_4(_v38)

    v71: US2 = default_arg(map(method4(), v44), US2(1))
    if v71.tag == 0:
        return v71.fields[0]

    else: 
        return ""



def method7(v0_1: float, v1: float, v2: float) -> tuple[float, float, float]:
    return (v0_1, v1, v2)


def method9(v0_1: float, v1: Mut0) -> bool:
    return v1.l0 < v0_1


def method10(v0_1: IEnumerable_1[float]) -> IEnumerable_1[float]:
    return v0_1


def method12(v0_1: float, v1: float, v2: float, v3: str, v4: float, v5: float, v6: float, v7: float) -> US3:
    v8: float = sin(v4)
    v9: float = v1 * v8
    v10: float = sin(v5)
    v11: float = v9 * v10
    v12: float = cos(v6)
    v13: float = v11 * v12
    v14: float = cos(v4)
    v15: float = v2 * v14
    v16: float = v15 * v10
    v18: float = v13 - (v16 * v12)
    v19: float = v1 * v14
    v20: float = sin(v6)
    v23: float = v2 * v8
    v25: float = (v18 + (v19 * v20)) + (v23 * v20)
    v26: float = cos(v5)
    v27: float = v0_1 * v26
    v29: float = v25 + (v27 * v12)
    v38: float = ((((v19 * v12) + (v23 * v12)) - (v11 * v20)) + (v16 * v20)) - (v27 * v20)
    v45: float = divide(1.0, (((v15 * v26) - (v9 * v26)) + (v0_1 * v10)) + 100.0)
    v53: float = 40.0 * v45
    v92: int = (int((divide(160, 2.0) + v7) + ((v53 * v29) * 2.0)) + (int(divide(44, 2.0) + (v53 * v38)) * 160)) or 0
    if (v92 < 7040) if (v92 >= 0) else False:
        return US3(0, v92, v45, v3)

    else: 
        return US3(1)



def closure4(v0_1: float, v1: float, v2: float, v3: float, v4: float, v5: float, v6: float) -> FSharpList[US3]:
    v7: float = -v3
    v12: float = -v5
    return of_array([method12(v5, v6, v7, ";", v0_1, v1, v2, v4), method12(v3, v6, v5, "\\", v0_1, v1, v2, v4), method12(v7, v6, v12, "/", v0_1, v1, v2, v4), method12(v12, v6, v3, "=", v0_1, v1, v2, v4), method12(v5, v7, -v6, ">", v0_1, v1, v2, v4), method12(v5, v3, v6, "<", v0_1, v1, v2, v4)])


def closure3(v0_1: float, v1: float, v2: float, v3: float, v4: float, v5: float) -> Callable[[float], FSharpList[US3]]:
    def _arrow265(v: float, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2, v3: Any=v3, v4: Any=v4, v5: Any=v5) -> FSharpList[US3]:
        return closure4(v0_1, v1, v2, v3, v4, v5, v)

    return _arrow265


def method11(v0_1: float, v1: float, v2: float, v3: float, v4: float) -> Callable[[float, float], FSharpList[US3]]:
    def _arrow266(v: float, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2, v3: Any=v3, v4: Any=v4) -> Callable[[float], FSharpList[US3]]:
        return closure3(v0_1, v1, v2, v3, v4, v)

    return _arrow266


def closure5(unit_var: None, v0_1: US3) -> tuple[int, float, str] | None:
    if v0_1.tag == 0:
        return (v0_1.fields[0], v0_1.fields[1], v0_1.fields[2])

    else: 
        return None



def method13(__unit: None=None) -> Callable[[US3], tuple[int, float, str] | None]:
    def _arrow267(v: US3) -> tuple[int, float, str] | None:
        return closure5(None, v)

    return _arrow267


def closure2(v0_1: float, v1: float, v2: float, _arg: tuple[float, float]) -> IEnumerable_1[tuple[int, float, str]]:
    v3: float = _arg[0]
    v5: float = -v3
    def _arrow271(__unit: None=None, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2, _arg: Any=_arg) -> IEnumerable_1[float]:
        v77: Mut0 = Mut0(v5)
        def _arrow268(__unit: None=None) -> bool:
            return method9(v3, v77)

        def _arrow270(__unit: None=None) -> IEnumerable_1[float]:
            def _arrow269(__unit: None=None) -> IEnumerable_1[float]:
                v81: float = v77.l0 + 0.6
                v77.l0 = v81
                return empty()

            return append(singleton(v77.l0), delay(_arrow269))

        return enumerate_while(_arrow268, delay(_arrow270))

    v151: IEnumerable_1[float] = method10(delay(_arrow271))
    v152: Callable[[float, float], FSharpList[US3]] = method11(v0_1, v1, v2, v3, _arg[1])
    v153: Callable[[US3], tuple[int, float, str] | None] = method13()
    def _arrow274(__unit: None=None, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2, _arg: Any=_arg) -> IEnumerable_1[tuple[int, float, str]]:
        def _arrow273(cube_x: float) -> IEnumerable_1[tuple[int, float, str]]:
            def _arrow272(cube_y: float) -> IEnumerable_1[tuple[int, float, str]]:
                return choose(v153, v152(cube_x)(cube_y))

            return collect(_arrow272, v151)

        return collect(_arrow273, v151)

    return delay(_arrow274)


def method8(v0_1: float, v1: float, v2: float) -> Callable[[tuple[float, float]], IEnumerable_1[tuple[int, float, str]]]:
    def _arrow275(_arg10: tuple[float, float], v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2) -> IEnumerable_1[tuple[int, float, str]]:
        return closure2(v0_1, v1, v2, _arg10)

    return _arrow275


def closure7(v0_1: Array[US4], v1: int, _arg: tuple[float, str]) -> None:
    v3: str = _arg[1]
    v2: float = _arg[0]
    v5: US4 = v0_1[v1]
    if v5.tag == 0:
        if v5.fields[0] >= v2:
            pass

        else: 
            v0_1[v1] = US4(0, v2, v3)


    else: 
        v0_1[v1] = US4(0, v2, v3)



def closure6(v0_1: Array[US4], v1: int) -> Callable[[tuple[float, str]], None]:
    def _arrow276(_arg10: tuple[float, str], v0_1: Any=v0_1, v1: Any=v1) -> None:
        closure7(v0_1, v1, _arg10)

    return _arrow276


def method14(__unit: None=None) -> str:
    return ""


def closure9(v0_1: Array[US4], v1: Any, v2: int, v3: int) -> None:
    v5: int = (v3 + (v2 * 160)) or 0
    v7: US4 = v0_1[v5]
    v21: Any = StringBuilder__Append_Z721C83C5(v1, v7.fields[1] if (v7.tag == 0) else ".")


def closure8(v0_1: Array[US4], v1: Any, v2: int) -> None:
    for col in range(0, (160 - 1) + 1, 1):
        closure9(v0_1, v1, v2, col)
    v11: Any = StringBuilder__AppendLine(v1)


def closure10(v0_1: str, unit_var: None) -> None:
    print(v0_1)


def method6(v0_1: int, v1: int, v2: float, v3: float, v4: float) -> Async[None]:
    def _arrow287(__unit: None=None, v0_1: Any=v0_1, v1: Any=v1, v2: Any=v2, v3: Any=v3, v4: Any=v4) -> Async[None]:
        pattern_input: tuple[float, float, float] = method7(v2, v3, v4)
        v3633: float = pattern_input[2]
        v3632: float = pattern_input[1]
        v3631: float = pattern_input[0]
        v3650: IEnumerable_1[tuple[int, float, str]] = collect(method8(v3631, v3632, v3633), to_enumerable([(20.0, -40.0), (10.0, 10.0), (5.0, 40.0)]))
        v3656: Array[US4] = fill([0] * (160 * 44), 0, 160 * 44, US4(1))
        def action(_arg: tuple[int, float, str]) -> None:
            closure6(v3656, _arg[0])((_arg[1], _arg[2]))

        iterate(action, v3650)
        v3666: Any = StringBuilder__ctor_Z721C83C5(method14())
        def _arrow277(_arg_1: int) -> Async[None]:
            closure8(v3656, v3666, _arg_1)
            return singleton_1.Zero()

        def _arrow286(__unit: None=None) -> Async[None]:
            v3673: str = to_string(v3666)
            v3676: bool = v0_1 < 0
            def _expr279():
                sys.stdout.write("\033[1;1H")
                def _expr278():
                    return singleton_1.Zero()

                return _expr278()

            def _arrow285(__unit: None=None) -> Async[None]:
                v3686: None
                closure10(v3673, None)
                v3686 = None
                v3702: Async[None] = sleep(1)
                def _arrow284(__unit: None=None) -> Async[None]:
                    v3715: bool = (v1 >= v0_1) if (v0_1 > 0) else False
                    def _expr280():
                        return singleton_1.Zero()

                    def _arrow282(__unit: None=None) -> Async[None]:
                        v3720: Async[None] = method5(v0_1, v1 + 1, v3631 + 0.05, v3632 + 0.05, v3633 + 0.01)
                        def _arrow281(__unit: None=None) -> Async[None]:
                            return singleton_1.Zero()

                        return singleton_1.Combine(singleton_1.ReturnFrom(v3720), singleton_1.Delay(_arrow281))

                    def _arrow283(__unit: None=None) -> Async[None]:
                        return singleton_1.Zero()

                    return singleton_1.Combine(_expr280() if v3715 else _arrow282(), singleton_1.Delay(_arrow283))

                return singleton_1.Bind(v3702, _arrow284)

            return singleton_1.Combine(_expr279() if v3676 else singleton_1.Zero(), singleton_1.Delay(_arrow285))

        return singleton_1.Combine(singleton_1.For(range_big_int(0, 1, 44 - 1), _arrow277), singleton_1.Delay(_arrow286))

    return singleton_1.Delay(_arrow287)


def method5(v0_1: int, v1: int, v2: float, v3: float, v4: float) -> Async[None]:
    return method6(v0_1, v1, v2, v3, v4)


def closure0(unit_var: None, v0_1: Array[str]) -> None:
    v65: bool = (0 == len(method1("AUTOMATION"))) if (0 == len(method1(method0()))) else False
    if v65:
        sys.stdout.write("\033[?25l")

    start_immediate(method5(-1 if v65 else 50, 1, 0.0, 0.0, 0.0))
    sleep_1(2000)


def _arrow288(v: Array[str]) -> None:
    closure0(None, v)


v0: Callable[[Array[str]], None] = _arrow288

main_: Callable[[Array[str]], None] = v0

main_([])

