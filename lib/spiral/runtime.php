<?php
namespace Runtime;

require_once(__FABLE_LIBRARY__.'/Option.php');

#0
function closure0($unitVar, $unitVar_1) {
    $_v0 = NULL;
    $_v0 = false;
    return \Option\value($_v0);
}

#1
function closure1($unitVar, $unitVar_1) {
    $_v0 = NULL;
    $_v0 = false;
    if (\Option\value($_v0)) {
        return '.exe';
    } else {
        return '';
    }
}

#2
$GLOBALS['v0'] = function ($arg10_0040) use ($closure0) { return closure0(NULL, NULL);
 };

#3
function is_windows($unitVar) {
    return $GLOBALS['v0'](NULL);
}

#4
$GLOBALS['v1'] = function ($arg10_0040) use ($closure1) { return closure1(NULL, NULL);
 };

#5
function get_executable_suffix($unitVar) {
    return $GLOBALS['v1'](NULL);
}

#6

