<?php
namespace Lib;

require_once(__ROOT__.'/../../../../../lib/spiral/file_system.fs.phpx');
require_once(__ROOT__.'/../../../../../lib/spiral/sm.fs.phpx');
require_once(__ROOT__.'/../../../../../lib/spiral/trace.fs.phpx');

#0
function SpiralTrace_get_trace_state($unitVar) {
    return \trace\get_trace_state(NULL);
}

#1
function SpiralTrace_trace($x) {
    return \trace\trace($x);
}

#2
$GLOBALS['SpiralTrace_US0_0'] = new \Trace\US0_US0_0();

#3
$GLOBALS['SpiralTrace_US0_1'] = new \Trace\US0_US0_1();

#4
$GLOBALS['SpiralTrace_US0_2'] = new \Trace\US0_US0_2();

#5
$GLOBALS['SpiralTrace_US0_3'] = new \Trace\US0_US0_3();

#6
$GLOBALS['SpiralTrace_US0_4'] = new \Trace\US0_US0_4();

#7
function SpiralSm_concat($x) {
    return \sm\concat($x);
}

#8
function SpiralSm_contains($x) {
    return \sm\contains($x);
}

#9
function SpiralSm_ellipsis($x) {
    return \sm\ellipsis($x);
}

#10
function SpiralSm_ellipsis_end($x) {
    return \sm\ellipsis_end($x);
}

#11
function SpiralSm_ends_with($x) {
    return \sm\ends_with($x);
}

#12
function SpiralSm_format_exception($x) {
    return \sm\format_exception($x);
}

#13
function SpiralSm_replace($x) {
    return \sm\replace($x);
}

#14
function SpiralSm_slice($x) {
    return \sm\slice($x);
}

#15
function SpiralSm_split($x) {
    return \sm\split($x);
}

#16
function SpiralSm_split_string($x) {
    return \sm\split_string($x);
}

#17
function SpiralSm_starts_with($x) {
    return \sm\starts_with($x);
}

#18
function SpiralSm_substring($x) {
    return \sm\substring($x);
}

#19
function SpiralSm_to_lower($x) {
    return \sm\to_lower($x);
}

#20
function SpiralSm_trim($x) {
    return \sm\trim($x);
}

#21
function SpiralSm_trim_start($x) {
    return \sm\trim_start($x);
}

#22
function SpiralSm_trim_end($x) {
    return \sm\trim_end($x);
}

#23
function SpiralFileSystem_get_source_directory($unitVar) {
    return \file_system\get_source_directory(NULL);
}

#24
function SpiralFileSystem_find_parent($x) {
    return \file_system\find_parent($x);
}

#25
function SpiralFileSystem_create_temp_directory($unitVar) {
    return \file_system\create_temp_directory(NULL);
}

#26
function SpiralFileSystem_create_temp_directory_name($unitVar) {
    return \file_system\create_temp_directory_name(NULL);
}

