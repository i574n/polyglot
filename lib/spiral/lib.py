from __future__ import annotations
from collections.abc import Callable
from fable_modules.fable_library.types import (int64, Array)
from fable_modules.fable_library.util import IEnumerable_1
from ......lib.spiral.file_system import (get_source_directory, find_parent, create_temp_directory, create_temp_directory_name)
from ......lib.spiral.sm import (concat, contains, ellipsis, ellipsis_end, ends_with, format_exception, replace, slice, split, split_string, starts_with, substring, to_lower, trim, trim_start, trim_end)

def SpiralSm_concat(x: str) -> Callable[[IEnumerable_1[str]], str]:
    return concat(x)


def SpiralSm_contains(x: str) -> Callable[[str], bool]:
    return contains(x)


def SpiralSm_ellipsis(x: int) -> Callable[[str], str]:
    return ellipsis(x)


def SpiralSm_ellipsis_end(x: int64) -> Callable[[str], str]:
    return ellipsis_end(x)


def SpiralSm_ends_with(x: str) -> Callable[[str], bool]:
    return ends_with(x)


def SpiralSm_format_exception(x: Exception) -> str:
    return format_exception(x)


def SpiralSm_replace(x: str) -> Callable[[str, str], str]:
    return replace(x)


def SpiralSm_slice(x: int) -> Callable[[int, str], str]:
    return slice(x)


def SpiralSm_split(x: str) -> Callable[[str], Array[str]]:
    return split(x)


def SpiralSm_split_string(x: Array[str]) -> Callable[[str], Array[str]]:
    return split_string(x)


def SpiralSm_starts_with(x: str) -> Callable[[str], bool]:
    return starts_with(x)


def SpiralSm_substring(x: int) -> Callable[[int, str], str]:
    return substring(x)


def SpiralSm_to_lower(x: str) -> str:
    return to_lower(x)


def SpiralSm_trim(x: str) -> str:
    return trim(x)


def SpiralSm_trim_start(x: Array[str]) -> Callable[[str], str]:
    return trim_start(x)


def SpiralSm_trim_end(x: Array[str]) -> Callable[[str], str]:
    return trim_end(x)


def SpiralFileSystem_get_source_directory(__unit: None=None) -> str:
    return get_source_directory()


def SpiralFileSystem_find_parent(x: str) -> Callable[[bool, str], str]:
    return find_parent(x)


def SpiralFileSystem_create_temp_directory(__unit: None=None) -> str:
    return create_temp_directory()


def SpiralFileSystem_create_temp_directory_name(__unit: None=None) -> str:
    return create_temp_directory_name()


