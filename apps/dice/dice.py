from __future__ import annotations
from dataclasses import dataclass
import sys
from typing import (Any, List, Callable)
from fable_modules.fable_library.long import (op_addition, op_modulus, op_subtraction, op_multiply)
from fable_modules.fable_library.reflection import (TypeInfo, uint64_type, unit_type, lambda_type, union_type, record_type, int32_type, string_type)
from fable_modules.fable_library.types import (Array, Union, Record, uint64, int64)

def _expr1() -> TypeInfo:
    return union_type("Dice.UH0", [], UH0, lambda: [[("Item1", uint64_type), ("Item2", lambda_type(unit_type, UH0_reflection()))], []])


class UH0(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> List[str]:
        return ["UH0_0", "UH0_1"]


UH0_reflection = _expr1

def _expr2() -> TypeInfo:
    return union_type("Dice.UH1", [], UH1, lambda: [[("Item1", uint64_type), ("Item2", UH1_reflection())], []])


class UH1(Union):
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> List[str]:
        return ["UH1_0", "UH1_1"]


UH1_reflection = _expr2

def _expr3() -> TypeInfo:
    return union_type("Dice.US0", [], US0, lambda: [[("f0_0", UH0_reflection())], [("f1_0", lambda_type(unit_type, UH0_reflection()))]])


class US0(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> List[str]:
        return ["US0_0", "US0_1"]


US0_reflection = _expr3

def _expr4() -> TypeInfo:
    return record_type("Dice.Mut0", [], Mut0, lambda: [("l0", US0_reflection())])


@dataclass(eq = False, repr = False)
class Mut0(Record):
    l0: US0

Mut0_reflection = _expr4

def _expr5() -> TypeInfo:
    return record_type("Dice.Mut1", [], Mut1, lambda: [("l0", int32_type)])


@dataclass(eq = False, repr = False)
class Mut1(Record):
    l0: int

Mut1_reflection = _expr5

def _expr6() -> TypeInfo:
    return union_type("Dice.US1", [], US1, lambda: [[], [("f1_0", uint64_type)]])


class US1(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> List[str]:
        return ["US1_0", "US1_1"]


US1_reflection = _expr6

def _expr7() -> TypeInfo:
    return union_type("Dice.US2", [], US2, lambda: [[], [("f1_0", lambda_type(string_type, unit_type))]])


class US2(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> List[str]:
        return ["US2_0", "US2_1"]


US2_reflection = _expr7

def _expr8() -> TypeInfo:
    return union_type("Dice.US3", [], US3, lambda: [[], [("f1_0", uint64_type), ("f1_1", UH1_reflection())]])


class US3(Union):
    __slots__ = ["tag", "fields"]
    def __init__(self, tag: int, *fields: Any) -> None:
        super().__init__()
        self.tag: int = tag or 0
        self.fields: Array[Any] = list(fields)

    @staticmethod
    def cases() -> List[str]:
        return ["US3_0", "US3_1"]


US3_reflection = _expr8

def closure2(v0: UH0, unit_var: None) -> UH0:
    return v0


def method1(v0: uint64, v1: UH0, v2: UH0) -> UH0:
    if v1.tag == 1:
        return v2

    else: 
        v6: UH0 = method1(v0, v1.fields[1](), v2)
        def v11(__unit: None=None, v0: uint64=v0, v1: UH0=v1, v2: UH0=v2) -> UH0:
            return closure2(v6, None)

        return UH0(0, op_addition(op_modulus(op_addition(op_subtraction(v1.fields[0], uint64(1)), v0), v0), uint64(1)), v11)



def closure1(v0: uint64, v1: UH0) -> UH0:
    return method1(v0, v1, UH0(1))


def closure0(unit_var: None, v0: uint64) -> Callable[[UH0], UH0]:
    def _arrow10(v: UH0, unit_var: None=unit_var, v0: uint64=v0) -> UH0:
        return closure1(v0, v)

    return _arrow10


def method2(v0_mut: UH1, v1_mut: UH1) -> UH1:
    while True:
        (v0, v1) = (v0_mut, v1_mut)
        if v0.tag == 1:
            return v1

        else: 
            v0_mut = v0.fields[1]
            v1_mut = UH1(0, v0.fields[0], v1)
            continue

        break


def method3(v0: UH1, v1: UH1) -> UH1:
    if v0.tag == 1:
        return v1

    else: 
        return UH1(0, v0.fields[0], method3(v0.fields[1], v1))



def closure4(v0: UH0, unit_var: None) -> UH0:
    return v0


def method4(v0: UH1, v1: UH0) -> UH0:
    if v0.tag == 1:
        return v1

    else: 
        v4: UH0 = method4(v0.fields[1], v1)
        def v5(__unit: None=None, v0: UH1=v0, v1: UH0=v1) -> UH0:
            return closure4(v4, None)

        return UH0(0, v0.fields[0], v5)



def closure5(v0: UH0, unit_var: None) -> UH0:
    return v0


def closure6(v0: UH0, v1: Mut0, unit_var: None) -> UH0:
    v2: US0 = v1.l0
    if v2.tag == 1:
        v5: UH0 = v2.fields[0]()
        v12: UH0 = UH0(1) if (v5.tag == 1) else UH0(0, v5.fields[0], method5(v0, v5.fields[1]))
        v1.l0 = US0(0, v12)
        return v12

    else: 
        return v2.fields[0]



def method5(v0: UH0, v1: Callable[[], UH0]) -> Callable[[], UH0]:
    v3: Mut0 = Mut0(US0(1, v1))
    def _arrow11(__unit: None=None, v0: UH0=v0, v1: Any=v1) -> UH0:
        return closure6(v0, v3, None)

    return _arrow11


def method7(v0_mut: int, v1_mut: UH0) -> US1:
    while True:
        (v0, v1) = (v0_mut, v1_mut)
        if v1.tag == 1:
            return US1(0)

        elif v0 <= 0:
            return US1(1, v1.fields[0])

        else: 
            v0_mut = v0 - 1
            v1_mut = v1.fields[1]()
            continue

        break


def method6(v0_mut: Callable[[], UH0], v1_mut: Mut1, v2_mut: Mut1, v3_mut: Mut1) -> uint64:
    while True:
        (v0, v1, v2, v3) = (v0_mut, v1_mut, v2_mut, v3_mut)
        v4: UH0 = v0()
        v6: US1 = method7(v1.l0, v4)
        if v6.tag == 1:
            v9: int = (v1.l0 + 1) or 0
            v1.l0 = v9 or 0
            return v6.fields[0]

        else: 
            if v3.l0 == -1:
                v12: int = v1.l0 or 0
                v3.l0 = v12 or 0

            v18: int = (1 if (v2.l0 >= v3.l0) else (v2.l0 + 1)) or 0
            v2.l0 = v18 or 0
            v20: int = (v2.l0 - 1) or 0
            v1.l0 = v20 or 0
            v0_mut = v0
            v1_mut = v1
            v2_mut = v2
            v3_mut = v3
            continue

        break


def closure7(v0: Callable[[], UH0], v1: Mut1, v2: Mut1, v3: Mut1, unit_var: None) -> uint64:
    return method6(v0, v1, v2, v3)


def closure3(unit_var: None, v0: UH1) -> Callable[[], uint64]:
    v5: UH0 = method4(method3(v0, method2(v0, UH1(1))), UH0(1))
    def v6(__unit: None=None, unit_var: None=unit_var, v0: UH1=v0) -> UH0:
        return closure5(v5, None)

    v7: Callable[[], UH0] = method5(v5, v6)
    v8: Mut1 = Mut1(0)
    v9: Mut1 = Mut1(1)
    v10: Mut1 = Mut1(-1)
    def _arrow12(__unit: None=None, unit_var: None=unit_var, v0: UH1=v0) -> uint64:
        return closure7(v7, v8, v9, v10, None)

    return _arrow12


def method8(v0_mut: US2, v1_mut: uint64, v2_mut: int64, v3_mut: uint64) -> int64:
    while True:
        (v0, v1, v2, v3) = (v0_mut, v1_mut, v2_mut, v3_mut)
        if (v3 < v1) if (v3 > uint64(0)) else False:
            v0_mut = v0
            v1_mut = v1
            v2_mut = op_addition(v2, int64(1))
            v3_mut = op_multiply(v3, uint64(6))
            continue

        else: 
            if v0.tag == 1:
                v0.fields[0](((((("calculate_dice_count / max: " + str(v1)) + " / n: ") + str(v2)) + " / p: ") + str(v3)) + "")

            return v2

        break


def closure75(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure75(None, None)

    return UH0(0, uint64(0), v0)


def closure74(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure75(None, None)

    return UH0(0, uint64(9223372036854775808), v0)


def closure73(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure74(None, None)

    return UH0(0, uint64(4611686018427387904), v0)


def closure72(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure73(None, None)

    return UH0(0, uint64(6917529027641081856), v0)


def closure71(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure72(None, None)

    return UH0(0, uint64(1152921504606846976), v0)


def closure70(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure71(None, None)

    return UH0(0, uint64(15564440312192434176), v0)


def closure69(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure70(None, None)

    return UH0(0, uint64(11817445422220181504), v0)


def closure68(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure69(None, None)

    return UH0(0, uint64(5044031582654955520), v0)


def closure67(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure68(None, None)

    return UH0(0, uint64(6989586621679009792), v0)


def closure66(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure67(None, None)

    return UH0(0, uint64(16537217831704461312), v0)


def closure65(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure66(None, None)

    return UH0(0, uint64(11979575008805519360), v0)


def closure64(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure65(None, None)

    return UH0(0, uint64(14294425217273954304), v0)


def closure63(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure64(None, None)

    return UH0(0, uint64(2382404202878992384), v0)


def closure62(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure63(None, None)

    return UH0(0, uint64(6545982058383015936), v0)


def closure61(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure62(None, None)

    return UH0(0, uint64(10314369046585278464), v0)


def closure60(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure61(None, None)

    return UH0(0, uint64(4793518853382471680), v0)


def closure59(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure60(None, None)

    return UH0(0, uint64(3873377154515337216), v0)


def closure58(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure59(None, None)

    return UH0(0, uint64(645562859085889536), v0)


def closure57(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure58(None, None)

    return UH0(0, uint64(107593809847648256), v0)


def closure56(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure57(None, None)

    return UH0(0, uint64(3092389647259533312), v0)


def closure55(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure56(None, None)

    return UH0(0, uint64(9738770311398031360), v0)


def closure54(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure55(None, None)

    return UH0(0, uint64(16995415113324298240), v0)


def closure53(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure54(None, None)

    return UH0(0, uint64(8981483876790566912), v0)


def closure52(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure53(None, None)

    return UH0(0, uint64(13794743361938128896), v0)


def closure51(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure52(None, None)

    return UH0(0, uint64(2299123893656354816), v0)


def closure50(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure51(None, None)

    return UH0(0, uint64(3457644661227651072), v0)


def closure49(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure50(None, None)

    return UH0(0, uint64(576274110204608512), v0)


def closure48(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure49(None, None)

    return UH0(0, uint64(6244960376270618624), v0)


def closure47(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure48(None, None)

    return UH0(0, uint64(13338656111851470848), v0)


def closure46(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure47(None, None)

    return UH0(0, uint64(14520938734448279552), v0)


def closure45(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure46(None, None)

    return UH0(0, uint64(14717985838214414336), v0)


def closure44(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure45(None, None)

    return UH0(0, uint64(5527454985320660992), v0)


def closure43(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure44(None, None)

    return UH0(0, uint64(16293529225644736512), v0)


def closure42(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure43(None, None)

    return UH0(0, uint64(11938960241128898560), v0)


def closure41(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure42(None, None)

    return UH0(0, uint64(8138741398091333632), v0)


def closure40(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure41(None, None)

    return UH0(0, uint64(7505371590918406144), v0)


def closure39(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure40(None, None)

    return UH0(0, uint64(16623181993244360704), v0)


def closure38(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure39(None, None)

    return UH0(0, uint64(8919445023443910656), v0)


def closure37(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure38(None, None)

    return UH0(0, uint64(4561031516192243712), v0)


def closure36(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure37(None, None)

    return UH0(0, uint64(9983543956220149760), v0)


def closure35(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure36(None, None)

    return UH0(0, uint64(4738381338321616896), v0)


def closure34(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure35(None, None)

    return UH0(0, uint64(789730223053602816), v0)


def closure33(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure34(None, None)

    return UH0(0, uint64(131621703842267136), v0)


def closure32(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure33(None, None)

    return UH0(0, uint64(21936950640377856), v0)


def closure31(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure32(None, None)

    return UH0(0, uint64(3656158440062976), v0)


def closure30(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure31(None, None)

    return UH0(0, uint64(609359740010496), v0)


def closure29(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure30(None, None)

    return UH0(0, uint64(101559956668416), v0)


def closure28(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure29(None, None)

    return UH0(0, uint64(16926659444736), v0)


def closure27(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure28(None, None)

    return UH0(0, uint64(2821109907456), v0)


def closure26(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure27(None, None)

    return UH0(0, uint64(470184984576), v0)


def closure25(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure26(None, None)

    return UH0(0, uint64(78364164096), v0)


def closure24(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure25(None, None)

    return UH0(0, uint64(13060694016), v0)


def closure23(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure24(None, None)

    return UH0(0, uint64(2176782336), v0)


def closure22(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure23(None, None)

    return UH0(0, uint64(362797056), v0)


def closure21(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure22(None, None)

    return UH0(0, uint64(60466176), v0)


def closure20(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure21(None, None)

    return UH0(0, uint64(10077696), v0)


def closure19(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure20(None, None)

    return UH0(0, uint64(1679616), v0)


def closure18(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure19(None, None)

    return UH0(0, uint64(279936), v0)


def closure17(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure18(None, None)

    return UH0(0, uint64(46656), v0)


def closure16(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure17(None, None)

    return UH0(0, uint64(7776), v0)


def closure15(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure16(None, None)

    return UH0(0, uint64(1296), v0)


def closure14(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure15(None, None)

    return UH0(0, uint64(216), v0)


def closure13(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure14(None, None)

    return UH0(0, uint64(36), v0)


def closure12(unit_var: None, unit_var_1: None) -> UH0:
    def v0(__unit: None=None, unit_var: None=unit_var, unit_var_1: None=unit_var_1) -> UH0:
        return closure13(None, None)

    return UH0(0, uint64(6), v0)


def method11(v0_mut: int64, v1_mut: UH0) -> US1:
    while True:
        (v0, v1) = (v0_mut, v1_mut)
        if v1.tag == 1:
            return US1(0)

        elif v0 <= int64(0):
            return US1(1, v1.fields[0])

        else: 
            v0_mut = op_subtraction(v0, int64(1))
            v1_mut = v1.fields[1]()
            continue

        break


def method10(v0_mut: US2, v1_mut: int64, v2_mut: UH1, v3_mut: uint64) -> US3:
    while True:
        (v0, v1, v2, v3) = (v0_mut, v1_mut, v2_mut, v3_mut)
        if v1 < int64(0):
            if v0.tag == 1:
                v0.fields[0](((("accumulate_dice_rolls / power: " + str(v1)) + " / acc: ") + str(v3)) + "")

            return US3(1, op_addition(v3, uint64(1)), v2)

        elif v2.tag == 1:
            return US3(0)

        else: 
            v11: UH1 = v2.fields[1]
            v10: uint64 = v2.fields[0]
            if v10 > uint64(1):
                def v14(__unit: None=None, v0: US2=v0, v1: int64=v1, v2: UH1=v2, v3: uint64=v3) -> UH0:
                    return closure12(None, None)

                v16: US1 = method11(v1, UH0(0, uint64(1), v14))
                v20: uint64
                if v16.tag == 1:
                    v20 = v16.fields[0]

                else: 
                    raise Exception("Option does not have a value.")

                v22: uint64 = op_multiply(op_subtraction(v10, uint64(1)), v20)
                if v0.tag == 1:
                    v0.fields[0](((((((("accumulate_dice_rolls / power: " + str(v1)) + " / acc: ") + str(v3)) + " / roll: ") + str(v10)) + " / value: ") + str(v22)) + "")

                v25: uint64 = op_addition(v3, v22)
                v0_mut = v0
                v1_mut = op_subtraction(v1, int64(1))
                v2_mut = v11
                v3_mut = v25
                continue

            else: 
                if v0.tag == 1:
                    v0.fields[0](((((("accumulate_dice_rolls / power: " + str(v1)) + " / acc: ") + str(v3)) + " / roll: ") + str(v10)) + "")

                v0_mut = v0
                v1_mut = op_subtraction(v1, int64(1))
                v2_mut = v11
                v3_mut = v3
                continue


        break


def method12(v0: int64, v1: Callable[[], uint64], v2: int64) -> UH1:
    if v2 < v0:
        return UH1(0, v1(), method12(v0, v1, op_addition(v2, int64(1))))

    else: 
        return UH1(1)



def method13(v0_mut: US2, v1_mut: Callable[[], uint64], v2_mut: bool, v3_mut: uint64, v4_mut: int64, v5_mut: UH1) -> uint64:
    while True:
        (v0, v1, v2, v3, v4, v5) = (v0_mut, v1_mut, v2_mut, v3_mut, v4_mut, v5_mut)
        v6: int64 = op_addition(v4, int64(1))
        if v4 < v6:
            return method9(v0, v1, v2, v3, v4, UH1(0, v1(), v5), v6)

        else: 
            v12: US3 = method10(v0, v4, v5, uint64(0))
            if v12.tag == 1:
                v13: uint64 = v12.fields[0]
                if v13 <= v3:
                    return v13

                elif v2:
                    v0_mut = v0
                    v1_mut = v1
                    v2_mut = v2
                    v3_mut = v3
                    v4_mut = v4
                    v5_mut = method12(v4, v1, int64(0))
                    continue

                else: 
                    return method9(v0, v1, v2, v3, v4, UH1(0, v1(), v5), v6)


            elif v2:
                v0_mut = v0
                v1_mut = v1
                v2_mut = v2
                v3_mut = v3
                v4_mut = v4
                v5_mut = method12(v4, v1, int64(0))
                continue

            else: 
                return method9(v0, v1, v2, v3, v4, UH1(0, v1(), v5), v6)


        break


def method9(v0_mut: US2, v1_mut: Callable[[], uint64], v2_mut: bool, v3_mut: uint64, v4_mut: int64, v5_mut: UH1, v6_mut: int64) -> uint64:
    while True:
        (v0, v1, v2, v3, v4, v5, v6) = (v0_mut, v1_mut, v2_mut, v3_mut, v4_mut, v5_mut, v6_mut)
        if v6 < op_addition(v4, int64(1)):
            v0_mut = v0
            v1_mut = v1
            v2_mut = v2
            v3_mut = v3
            v4_mut = v4
            v5_mut = UH1(0, v1(), v5)
            v6_mut = op_addition(v6, int64(1))
            continue

        else: 
            v14: US3 = method10(v0, v4, v5, uint64(0))
            if v14.tag == 1:
                v15: uint64 = v14.fields[0]
                if v15 <= v3:
                    return v15

                elif v2:
                    return method13(v0, v1, v2, v3, v4, method12(v4, v1, int64(0)))

                else: 
                    v0_mut = v0
                    v1_mut = v1
                    v2_mut = v2
                    v3_mut = v3
                    v4_mut = v4
                    v5_mut = UH1(0, v1(), v5)
                    v6_mut = op_addition(v6, int64(1))
                    continue


            elif v2:
                return method13(v0, v1, v2, v3, v4, method12(v4, v1, int64(0)))

            else: 
                v0_mut = v0
                v1_mut = v1
                v2_mut = v2
                v3_mut = v3
                v4_mut = v4
                v5_mut = UH1(0, v1(), v5)
                v6_mut = op_addition(v6, int64(1))
                continue


        break


def closure11(v0: US2, v1: Callable[[], uint64], v2: bool, v3: uint64) -> uint64:
    return method9(v0, v1, v2, v3, op_subtraction(int64(1) if (v3 == uint64(1)) else method8(v0, v3, int64(0), uint64(1)), int64(1)), UH1(1), int64(0))


def closure10(v0: US2, v1: Callable[[], uint64], v2: bool) -> Callable[[uint64], uint64]:
    def _arrow13(v: uint64, v0: US2=v0, v1: Any=v1, v2: bool=v2) -> uint64:
        return closure11(v0, v1, v2, v)

    return _arrow13


def closure9(v0: US2, v1: Callable[[], uint64]) -> Callable[[bool, uint64], uint64]:
    def _arrow14(v: bool, v0: US2=v0, v1: Any=v1) -> Callable[[uint64], uint64]:
        return closure10(v0, v1, v)

    return _arrow14


def closure8(unit_var: None, v0: US2) -> Callable[[Callable[[], uint64], bool, uint64], uint64]:
    def _arrow15(v: Callable[[], uint64], unit_var: None=unit_var, v0: US2=v0) -> Callable[[bool, uint64], uint64]:
        return closure9(v0, v)

    return _arrow15


def method14(v0_mut: UH1, v1_mut: int64) -> int64:
    while True:
        (v0, v1) = (v0_mut, v1_mut)
        if v0.tag == 1:
            return v1

        else: 
            v0_mut = v0.fields[1]
            v1_mut = op_addition(v1, int64(1))
            continue

        break


def closure78(v0: US2, v1: uint64, v2: UH1) -> US1:
    v7: US3 = method10(v0, op_subtraction(method14(v2, int64(0)), int64(1)), v2, uint64(0))
    if v7.tag == 1:
        v8: uint64 = v7.fields[0]
        if (v8 <= v1) if (v8 >= uint64(1)) else False:
            return US1(1, v8)

        else: 
            return US1(0)


    else: 
        return US1(0)



def closure77(v0: US2, v1: uint64) -> Callable[[UH1], US1]:
    def _arrow16(v: UH1, v0: US2=v0, v1: uint64=v1) -> US1:
        return closure78(v0, v1, v)

    return _arrow16


def closure76(unit_var: None, v0: US2) -> Callable[[uint64, UH1], US1]:
    def _arrow17(v: uint64, unit_var: None=unit_var, v0: US2=v0) -> Callable[[UH1], US1]:
        return closure77(v0, v)

    return _arrow17


def method0(__unit: None=None) -> None:
    pass


method0()

def main(_args: Array[str]) -> int:
    return 0


if __name__ == "__main__":
    main(sys.argv[1:])


