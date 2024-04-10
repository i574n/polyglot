<?php
namespace Date_time;

require_once(__FABLE_LIBRARY__.'/BigInt.php');
require_once(__FABLE_LIBRARY__.'/Date.php');
require_once(__FABLE_LIBRARY__.'/Guid.php');
require_once(__FABLE_LIBRARY__.'/Long.php');
require_once(__FABLE_LIBRARY__.'/Option.php');
require_once(__FABLE_LIBRARY__.'/String.php');
require_once(__FABLE_LIBRARY__.'/Util.php');

#0
function closure1($v0_1, $v1_1) {
    $v3_1 = $v0_1;
    $v4_1 = $v1_1->\Date\toString('yyyyMMdd-HHmm-ssff-ffff-f');
    return \Guid\parse(NULL);
}

#1
function closure0($unitVar, $v0_1) {
    return function ($v) use ($closure1, $v0_1) {     return closure1($v0_1, $v);
 };
}

#2
function closure5($v0_1, $v1_1, $v2_1) {
    return $v2_1->\String\replace($v0_1, $v1_1);
}

#3
function closure4($v0_1, $v1_1) {
    return function ($v) use ($closure5, $v0_1, $v1_1) {     return closure5($v0_1, $v1_1, $v);
 };
}

#4
function closure3($unitVar, $v0_1) {
    return function ($v) use ($closure4, $v0_1) {     return closure4($v0_1, $v);
 };
}

#5
function method0($unitVar) {
    return function ($v) use ($closure3) {     return closure3(NULL, $v);
 };
}

#6
function closure2($unitVar, $v0_1) {
    $v3_1 = method0(NULL);
    $_v4 = NULL;
    $x = \Date\minValue();
    $_v4 = $x;
    return \Option\value($_v4);
}

#7
function closure7($v0_1, $v1_1) {
    $v3_1 = $v0_1;
    $v6_1 = \Util\int64ToString($v1_1)->\String\padLeft(18, '0');
    return \Guid\parse(NULL);
}

#8
function closure6($unitVar, $v0_1) {
    return function ($v) use ($closure7, $v0_1) {     return closure7($v0_1, $v);
 };
}

#9
function closure8($unitVar, $v0_1) {
    $v2_1 = $v0_1;
    return \BigInt\toInt64(\Long\parse(NULL, 511, false, 64));
}

#10
function closure9($unitVar, $v0_1) {
    $v3_1 = \Guid\newGuid();
    $v4_1 = $v0_1->\Date\toString('yyyyMMdd-HHmm-ssff-ffff-f');
    return \Guid\parse(NULL);
}

#11
function closure10($unitVar, $v0_1) {
    $v3_1 = \Guid\newGuid();
    $v6_1 = \Util\int64ToString($v0_1)->\String\padLeft(18, '0');
    return \Guid\parse(NULL);
}

#12
function closure12($v0_1, $v1_1) {
    return $v1_1->\Date\toString($v0_1);
}

#13
function closure11($unitVar, $v0_1) {
    return function ($v) use ($closure12, $v0_1) {     return closure12($v0_1, $v);
 };
}

#14
function closure13($unitVar, $v0_1) {
    return $v0_1->\Date\toString('yyyy-MM-ddTHH-mm-ss.fff');
}

#15
$GLOBALS['v0'] = function ($v) use ($closure0) { return closure0(NULL, $v);
 };

#16
function date_time_guid_from_date_time($x) {
    return $GLOBALS['v0']($x);
}

#17
$GLOBALS['v1'] = function ($v) use ($closure2) { return closure2(NULL, $v);
 };

#18
function date_time_from_guid($x) {
    return $GLOBALS['v1']($x);
}

#19
$GLOBALS['v2'] = function ($v) use ($closure6) { return closure6(NULL, $v);
 };

#20
function timestamp_guid_from_timestamp($x) {
    return $GLOBALS['v2']($x);
}

#21
$GLOBALS['v3'] = function ($v) use ($closure8) { return closure8(NULL, $v);
 };

#22
function timestamp_from_guid($x) {
    return $GLOBALS['v3']($x);
}

#23
$GLOBALS['v4'] = function ($v) use ($closure9) { return closure9(NULL, $v);
 };

#24
function new_guid_from_date_time($x) {
    return $GLOBALS['v4']($x);
}

#25
$GLOBALS['v5'] = function ($v) use ($closure10) { return closure10(NULL, $v);
 };

#26
function new_guid_from_timestamp($x) {
    return $GLOBALS['v5']($x);
}

#27
$GLOBALS['v6'] = function ($v) use ($closure11) { return closure11(NULL, $v);
 };

#28
function format($x) {
    return $GLOBALS['v6']($x);
}

#29
$GLOBALS['v7'] = function ($v) use ($closure13) { return closure13(NULL, $v);
 };

#30
function format_iso8601($x) {
    return $GLOBALS['v7']($x);
}

#31

