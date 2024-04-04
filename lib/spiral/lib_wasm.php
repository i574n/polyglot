<?php
namespace Lib;

require_once(__ROOT__.'/../../../../../lib/spiral/file_system.fs.phpx');
require_once(__ROOT__.'/../../../../../lib/spiral/sm.fs.phpx');

#0
function SpiralSm_concat($x) {
    return \sm\concat($x);
}

#1
function SpiralSm_contains($x) {
    return \sm\contains($x);
}

#2
function SpiralSm_ellipsis($x) {
    return \sm\ellipsis($x);
}

#3
function SpiralSm_ellipsis_end($x) {
    return \sm\ellipsis_end($x);
}

#4
function SpiralSm_ends_with($x) {
    return \sm\ends_with($x);
}

#5
function SpiralSm_format_exception($x) {
    return \sm\format_exception($x);
}

#6
function SpiralSm_replace($x) {
    return \sm\replace($x);
}

#7
function SpiralSm_slice($x) {
    return \sm\slice($x);
}

#8
function SpiralSm_split($x) {
    return \sm\split($x);
}

#9
function SpiralSm_split_string($x) {
    return \sm\split_string($x);
}

#10
function SpiralSm_starts_with($x) {
    return \sm\starts_with($x);
}

#11
function SpiralSm_substring($x) {
    return \sm\substring($x);
}

#12
function SpiralSm_to_lower($x) {
    return \sm\to_lower($x);
}

#13
function SpiralSm_trim($x) {
    return \sm\trim($x);
}

#14
function SpiralSm_trim_start($x) {
    return \sm\trim_start($x);
}

#15
function SpiralSm_trim_end($x) {
    return \sm\trim_end($x);
}

#16
function SpiralFileSystem_get_source_directory($unitVar) {
    return \file_system\get_source_directory(NULL);
}

#17
function SpiralFileSystem_find_parent($x) {
    return \file_system\find_parent($x);
}

#18
function SpiralFileSystem_create_temp_directory($unitVar) {
    return \file_system\create_temp_directory(NULL);
}

#19
function SpiralFileSystem_create_temp_directory_name($unitVar) {
    return \file_system\create_temp_directory_name(NULL);
}

