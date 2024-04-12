<?php
namespace Async_;

require_once(__FABLE_LIBRARY__.'/Option.php');
require_once(__FABLE_LIBRARY__.'/Util.php');

#0
function closure0($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#1
$GLOBALS['v0'] = function ($v) use ($closure0) { return closure0(NULL, $v);
 };

#2
function merge_cancellation_token_with_default_async($x) {
    return $GLOBALS['v0']($x);
}

#3

