<?php
namespace Threading;

require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');
require_once(__FABLE_LIBRARY__.'/Option.php');
require_once(__FABLE_LIBRARY__.'/Util.php');

use \FSharpUnion;
use \IComparable;

#0
abstract class US0 implements FSharpUnion {
    static function allCases() {
        return [ '\\Threading\\US0_US0_0', '\\Threading\\US0_US0_1' ];
    }
}

#0
class US0_US0_0 extends US0 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US0_0';
    }
    static function get_f0_0_Type() {
        return '\\Threading\\System_CancellationToken';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__1 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__1 != 0) {
            return $_cmp__1;
        }        
        $_cmp__2 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__2 != 0) {
            return $_cmp__2;
        }        
        return 0;
    }
}

#0
class US0_US0_1 extends US0 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US0_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__3 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__3;
    }
}

#1
function US0__get_IsUS0_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#2
function US0__get_IsUS0_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#3
function closure1($unitVar, $v0_1) {
    return new US0_US0_0($v0_1);
}

#4
function method0($unitVar) {
    return function ($v) use ($closure1) {     return closure1(NULL, $v);
 };
}

#5
function closure2($v0_1, $unitVar) {
    $_v1 = NULL;
    \Util\defaultOf();
    $_v1 = NULL;
    \Option\value($_v1);
    return NULL;
}

#6
function closure0($unitVar, $v0_1) {
    $_v1 = NULL;
    $patternInput = [ \Util\defaultOf(), \Util\defaultOf() ];
    $_v1 = [ $patternInput[0], $patternInput[1] ];
    $patternInput_1 = \Option\value($_v1);
    return [ $patternInput_1[0], $patternInput_1[1] ];
}

#7
$GLOBALS['v0'] = function ($v) use ($closure0) { return closure0(NULL, $v);
 };

#8
function new_disposable_token($x) {
    return $GLOBALS['v0']($x);
}

#9

