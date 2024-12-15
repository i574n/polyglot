kernel = r"""
"""
class static_array():
    def __init__(self, length):
        self.ptr = []
        for _ in range(length):
            self.ptr.append(None)

    def __getitem__(self, index):
        assert 0 <= index < len(self.ptr), "The get index needs to be in range."
        return self.ptr[index]
    
    def __setitem__(self, index, value):
        assert 0 <= index < len(self.ptr), "The set index needs to be in range."
        self.ptr[index] = value

class static_array_list(static_array):
    def __init__(self, length):
        super().__init__(length)
        self.length = 0

    def __getitem__(self, index):
        assert 0 <= index < self.length, "The get index needs to be in range."
        return self.ptr[index]
    
    def __setitem__(self, index, value):
        assert 0 <= index < self.length, "The set index needs to be in range."
        self.ptr[index] = value

    def push(self,value):
        assert (self.length < len(self.ptr)), "The length before pushing has to be less than the maximum length of the array."
        self.ptr[self.length] = value
        self.length += 1

    def pop(self):
        assert (0 < self.length), "The length before popping has to be greater than 0."
        self.length -= 1
        return self.ptr[self.length]

    def unsafe_set_length(self,i):
        assert 0 <= i <= len(self.ptr), "The new length has to be in range."
        self.length = i

class dynamic_array(static_array): 
    pass

class dynamic_array_list(static_array_list):
    def length_(self): return self.length

import cupy as cp
import numpy as np
from dataclasses import dataclass
from typing import NamedTuple, Union, Callable, Tuple
i8 = int; i16 = int; i32 = int; i64 = int; u8 = int; u16 = int; u32 = int; u64 = int; f32 = float; f64 = float; char = str; string = str
cuda = False

import os
import asyncio
import math
import io
class CustomStringIO(io.StringIO):
    def __init__(self, init=''):
        super().__init__()
        if init != '': self.write(init)
    def __str__(self): return self.getvalue()
    def __repr__(self): return self.getvalue()
class US0_0(NamedTuple): # (0, Some)
    v0 : string
    tag = 0
class US0_1(NamedTuple): # (1, None)
    tag = 1
US0 = Union[US0_0, US0_1]
@dataclass
class Mut0:
    v0 : f64
def Closure1(env_v0 : f64, env_v1 : f64):
    def inner() -> None:
        nonlocal env_v0, env_v1
        v0 = env_v0; v1 = env_v1
        v2 = Mut0(v0)
        del v0
        while method5(v1, v2):
            v4 = v2.v0
            yield v4 
            del v4
            v5 = v2.v0
            v6 = v5 + 0.6
            del v5
            v2.v0 = v6
            del v6
        del v1, v2
        return 
    return inner
class US1_0(NamedTuple): # (0, Some)
    v0 : i32
    v1 : f64
    v2 : char
    tag = 0
class US1_1(NamedTuple): # (1, None)
    tag = 1
US1 = Union[US1_0, US1_1]
def Closure3(env_v0 : f64, env_v1 : f64, env_v2 : f64, env_v3 : f64, env_v4 : f64, env_v5 : f64):
    def inner(v6 : f64) -> list:
        nonlocal env_v0, env_v1, env_v2, env_v3, env_v4, env_v5
        v0 = env_v0; v1 = env_v1; v2 = env_v2; v3 = env_v3; v4 = env_v4; v5 = env_v5
        v7 = -v3
        v8 = ';'
        v9 = method8(v5, v6, v7, v8, v0, v1, v2, v4)
        del v8
        v10 = '\\'
        v11 = method8(v3, v6, v5, v10, v0, v1, v2, v4)
        del v10
        v12 = -v5
        v13 = '/'
        v14 = method8(v7, v6, v12, v13, v0, v1, v2, v4)
        del v13
        v15 = '='
        v16 = method8(v12, v6, v3, v15, v0, v1, v2, v4)
        del v12, v15
        v17 = -v6
        v18 = '>'
        v19 = method8(v5, v7, v17, v18, v0, v1, v2, v4)
        del v7, v17, v18
        v20 = '<'
        v21 = method8(v5, v3, v6, v20, v0, v1, v2, v4)
        del v0, v1, v2, v3, v4, v5, v20
        v22 = []
        v22.insert(0, v21)
        del v21
        v24 = v22 
        del v22
        v24.insert(0, v19)
        del v19
        v27 = v24 
        del v24
        v27.insert(0, v16)
        del v16
        v30 = v27 
        del v27
        v30.insert(0, v14)
        del v14
        v33 = v30 
        del v30
        v33.insert(0, v11)
        del v11
        v36 = v33 
        del v33
        v36.insert(0, v9)
        del v9
        v39 = v36 
        del v36
        return v39
    return inner
def Closure2(env_v0 : f64, env_v1 : f64, env_v2 : f64, env_v3 : f64, env_v4 : f64):
    def inner(v5 : f64) -> Callable[[f64], list]:
        nonlocal env_v0, env_v1, env_v2, env_v3, env_v4
        v0 = env_v0; v1 = env_v1; v2 = env_v2; v3 = env_v3; v4 = env_v4
        return Closure3(v0, v1, v2, v3, v4, v5)
    return inner
def Closure4():
    def inner(v0 : US1) -> Tuple[i32, f64, char]:
        match v0:
            case US1_1(): # None
                v7 = None
                return v7
            case US1_0(v1, v2, v3): # Some
                v5 = (v1, v2, v3) # some' 
                del v1, v2, v3
                return v5
            case t:
                raise Exception(f'Pattern matching miss. Got: {t}')
    return inner
def Closure5(env_v0 : list, env_v1 : Callable[[f64], Callable[[f64], list]], env_v2 : Callable[[US1], Tuple[i32, f64, char]]):
    def inner() -> None:
        nonlocal env_v0, env_v1, env_v2
        v0 = env_v0; v1 = env_v1; v2 = env_v2
        cube_range = v0 
        del v0
        get = v1 
        del v1
        box = v2 
        del v2
        for cube_x in cube_range:
            for cube_y in cube_range:
                x = get(cube_x)(cube_y)
                for i in x:
                    i_ = box(i)
                    if i_ is not None: yield i
        return 
    return inner
def Closure0(env_v0 : f64, env_v1 : f64, env_v2 : f64):
    def inner(v3 : f64, v4 : f64) -> list:
        nonlocal env_v0, env_v1, env_v2
        v0 = env_v0; v1 = env_v1; v2 = env_v2
        v5 = -v3
        v50 = Closure1(v5, v3)
        del v5
        v51 = list(v50())
        del v50
        v53 = method6(v51)
        del v51
        v54 = method7(v0, v1, v2, v3, v4)
        del v0, v1, v2
        v55 = method9()
        v60 = Closure5(v53, v54, v55)
        del v53, v54, v55
        v61 = list(v60())
        del v60
        return v61
    return inner
class US2_0(NamedTuple): # (0, Some)
    v0 : f64
    v1 : char
    tag = 0
class US2_1(NamedTuple): # (1, None)
    tag = 1
US2 = Union[US2_0, US2_1]
def Closure7(env_v0 : (cp if cuda else np).ndarray, env_v1 : i32):
    def inner(v2 : f64, v3 : char) -> None:
        nonlocal env_v0, env_v1
        v0 = env_v0; v1 = env_v1
        v5 = v0[v1]
        match v5:
            case US2_0(v7, _): # Some
                del v5
                v9 = v7 >= v2
                del v7
                if v9:
                    del v0, v1, v9
                    return 
                else:
                    del v9
                    v11 = US2_0(v2, v3)
                    v0[v1] = v11 
                    del v0, v1, v11
                    return 
            case t:
                del v5
                v13 = US2_0(v2, v3)
                v0[v1] = v13 
                del v0, v1, v13
                return 
    return inner
def Closure6(env_v0 : (cp if cuda else np).ndarray):
    def inner(v1 : i32) -> Callable[[f64, char], None]:
        nonlocal env_v0
        v0 = env_v0
        return Closure7(v0, v1)
    return inner
def Closure9(env_v0 : (cp if cuda else np).ndarray, env_v1 : io.StringIO, env_v2 : i32):
    def inner(v3 : i32) -> None:
        nonlocal env_v0, env_v1, env_v2
        v0 = env_v0; v1 = env_v1; v2 = env_v2
        v4 = v2 * 160
        del v2
        v5 = v3 + v4
        del v4
        v7 = v0[v5]
        del v0, v5
        match v7:
            case US2_1(): # None
                v12 = '.'
            case US2_0(_, v10): # Some
                v12 = v10
            case t:
                raise Exception(f'Pattern matching miss. Got: {t}')
        del v7
        v15 = str(v12)
        del v12
        v19 = v1.write(v15)
        del v1, v15, v19
        return 
    return inner
def Closure8(env_v0 : (cp if cuda else np).ndarray, env_v1 : io.StringIO):
    def inner(v2 : i32) -> None:
        nonlocal env_v0, env_v1
        v0 = env_v0; v1 = env_v1
        v4 = Closure9(v0, v1, v2)
        del v0
        for col in range(160): v4(col)
        del v4
        v9 = "\n"
        v10 = v1.write(v9)
        del v1, v9, v10
        return 
    return inner
def method0() -> string:
    v0 = "VSCODE_PID"
    return v0
def method1(v0 : string) -> string:
    v101 = os.environ
    v105 = v101.get(v0)
    del v0, v101
    v110 = v105 
    del v105
    v114 = None
    v116 = v110 == v114 
    del v114
    if v116:
        v118 = None
        v122 = v118
    else:
        v119 = v110 
        v120 = US0_0(v119)
        del v119
        v121 = v120 
        del v120
        v122 = v121
    del v110, v116
    v126 = US0_1()
    v127 = v122 or v126 
    del v122, v126
    match v127:
        case US0_1(): # None
            del v127
            v130 = ""
            return v130
        case US0_0(v129): # Some
            del v127
            return v129
        case t:
            raise Exception(f'Pattern matching miss. Got: {t}')
def method4(v0 : f64, v1 : f64, v2 : f64) -> Tuple[f64, f64, f64]:
    return v0, v1, v2
def method5(v0 : f64, v1 : Mut0) -> bool:
    v2 = v1.v0
    del v1
    v3 = v2 < v0
    del v0, v2
    return v3
def method6(v0 : list) -> list:
    return v0
def method8(v0 : f64, v1 : f64, v2 : f64, v3 : char, v4 : f64, v5 : f64, v6 : f64, v7 : f64) -> US1:
    v8 = math.sin(v4)
    v9 = v1 * v8
    v10 = math.sin(v5)
    v11 = v9 * v10
    v12 = math.cos(v6)
    v13 = v11 * v12
    v14 = math.cos(v4)
    del v4
    v15 = v2 * v14
    v16 = v15 * v10
    v17 = v16 * v12
    v18 = v13 - v17
    del v13, v17
    v19 = v1 * v14
    del v1, v14
    v20 = math.sin(v6)
    del v6
    v21 = v19 * v20
    v22 = v18 + v21
    del v18, v21
    v23 = v2 * v8
    del v2, v8
    v24 = v23 * v20
    v25 = v22 + v24
    del v22, v24
    v26 = math.cos(v5)
    del v5
    v27 = v0 * v26
    v28 = v27 * v12
    v29 = v25 + v28
    del v25, v28
    v30 = v19 * v12
    del v19
    v31 = v23 * v12
    del v12, v23
    v32 = v30 + v31
    del v30, v31
    v33 = v11 * v20
    del v11
    v34 = v32 - v33
    del v32, v33
    v35 = v16 * v20
    del v16
    v36 = v34 + v35
    del v34, v35
    v37 = v27 * v20
    del v20, v27
    v38 = v36 - v37
    del v36, v37
    v39 = v15 * v26
    del v15
    v40 = v9 * v26
    del v9, v26
    v41 = v39 - v40
    del v39, v40
    v42 = v0 * v10
    del v0, v10
    v43 = v41 + v42
    del v41, v42
    v44 = v43 + 100.0
    del v43
    v45 = 1.0 / v44
    del v44
    v48 = 160 
    v50 = v48 / 2.0
    del v48
    v51 = v50 + v7
    del v7, v50
    v52 = 40.0 * v45
    v53 = v52 * v29
    del v29
    v54 = v53 * 2.0
    del v53
    v55 = v51 + v54
    del v51, v54
    v60 = i32(v55)
    del v55
    v65 = 44 
    v67 = v65 / 2.0
    del v65
    v68 = v52 * v38
    del v38, v52
    v69 = v67 + v68
    del v67, v68
    v74 = i32(v69)
    del v69
    v77 = v74 * 160
    del v74
    v78 = v60 + v77
    del v60, v77
    v79 = v78 >= 0
    if v79:
        v80 = v78 < 7040
        v81 = v80
    else:
        v81 = False
    del v79
    if v81:
        del v81
        return US1_0(v78, v45, v3)
    else:
        del v3, v45, v78, v81
        return US1_1()
def method7(v0 : f64, v1 : f64, v2 : f64, v3 : f64, v4 : f64) -> Callable[[f64], Callable[[f64], list]]:
    return Closure2(v0, v1, v2, v3, v4)
def method9() -> Callable[[US1], Tuple[i32, f64, char]]:
    return Closure4()
def method10() -> string:
    v0 = ""
    return v0
def method3(v0 : i32, v1 : i32, v2 : f64, v3 : f64, v4 : f64) -> None :
    v2497 = None
    def _v2497():
        v2730, v2731, v2732 = method4(v2, v3, v4)
        v2733 = []
        v2733.insert(0, (5.0, 40.0))
        v2735 = v2733 
        del v2733
        v2735.insert(0, (10.0, 10.0))
        v2738 = v2735 
        del v2735
        v2738.insert(0, (20.0, -40.0))
        v2741 = v2738 
        del v2738
        cubes = v2741 
        del v2741
        v2746 = Closure0(v2730, v2731, v2732)
        get_cube_points = v2746 
        del v2746
        v2747 = [x for cube in cubes for x in get_cube_points(*cube)]
        v2751 = US2_1()
        v2752 = [v2751 for _ in range(160 * 44)]
        del v2751
        v2756 = Closure6(v2752)
        for (idx, ooz, ch) in v2747: v2756(idx)(ooz, ch)
        del v2747, v2756
        v2757 = method10()
        v2760 = CustomStringIO(v2757)
        del v2757
        v2763 = Closure8(v2752, v2760)
        del v2752
        for row in range(44): v2763(row)
        del v2763
        v2766 = str(v2760)
        del v2760
        v2768 = v0 < 0
        del v2768
        print(v2766)
        del v2766
        v2796 = None
        asyncio.run(v2796())
        del v2796
        v2799 = v0 > 0
        if v2799:
            v2800 = v1 >= v0
            v2801 = v2800
        else:
            v2801 = False
        del v2799
        if v2801:
            del v2730, v2731, v2732, v2801
        else:
            del v2801
            v2802 = v2730 + 0.05
            del v2730
            v2803 = v2731 + 0.05
            del v2731
            v2804 = v2732 + 0.01
            del v2732
            v2805 = v1 + 1
            v2806 = method2(v0, v2805, v2802, v2803, v2804)
            del v2802, v2803, v2804, v2805
            asyncio.run(v2806())
            del v2806
    del v0, v1, v2, v3, v4
    v2807 = _v2497 
    del v2497
    return v2807
def method2(v0 : i32, v1 : i32, v2 : f64, v3 : f64, v4 : f64) -> None :
    return method3(v0, v1, v2, v3, v4)
def main_body():
    v1 = (cp if cuda else np).array([],dtype=object)
    del v1
    v58 = method0()
    v59 = method1(v58)
    del v58
    v60 = len(v59)
    del v59
    v61 = 0 == v60
    del v60
    if v61:
        v62 = "AUTOMATION"
        v63 = method1(v62)
        del v62
        v64 = len(v63)
        del v63
        v65 = 0 == v64
        del v64
        v66 = v65
    else:
        v66 = False
    del v61
    if v66:
        v75 = -1
    else:
        v75 = 50
    del v66
    v76 = 1
    v77 = 0.0
    v78 = 0.0
    v79 = 0.0
    v80 = method2(v75, v76, v77, v78, v79)
    del v75, v76, v77, v78, v79, v80
    None
    return 

def main():
    r = main_body()
    if cuda: cp.cuda.get_current_stream().synchronize() # This line is here so the `__trap()` calls on the kernel aren't missed.
    return r

if __name__ == '__main__': result = main(); None if result is None else print(result)
