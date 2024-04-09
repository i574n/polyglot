<?php
namespace Common;

require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');
require_once(__FABLE_LIBRARY__.'/Option.php');
require_once(__FABLE_LIBRARY__.'/Util.php');

use \FSharpUnion;
use \IComparable;

#0
abstract class US0 implements FSharpUnion {
    static function allCases() {
        return [ '\\Common\\US0_US0_0', '\\Common\\US0_US0_1' ];
    }
}

#0
class US0_US0_0 extends US0 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US0_0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__1 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__1;
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
        $_cmp__2 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__2;
    }
}

#1
abstract class US1 implements FSharpUnion {
    static function allCases() {
        return [ '\\Common\\US1_US1_0', '\\Common\\US1_US1_1' ];
    }
}

#1
class US1_US1_0 extends US1 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US1_0';
    }
    static function get_f0_0_Type() {
        return '\\Common\\US0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__3 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__3 != 0) {
            return $_cmp__3;
        }        
        $_cmp__4 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__4 != 0) {
            return $_cmp__4;
        }        
        return 0;
    }
}

#1
class US1_US1_1 extends US1 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US1_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__5 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__5;
    }
}

#2
function US0__get_IsUS0_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#3
function US0__get_IsUS0_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#4
function US1__get_IsUS1_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#5
function US1__get_IsUS1_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#6
function closure0($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#7
function closure3($v0_1, $v1_1, $v2, $unitVar) {
    if ($v2 < $v0_1) {
        $v1_1(NULL);
        return new US0_US0_0();
    } else {
        return new US0_US0_1();
    }
}

#8
function closure4($unitVar, $v0_1) {
    return new US1_US1_0($v0_1);
}

#9
function closure5($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    \Option\value($_v2);
    return new US1_US1_1();
}

#10
function method0($v0_1, $v1_1, $v2) {
    try {
        $v6 = closure4(NULL, closure3($v0_1, $v1_1, $v2, NULL));
    }
    catch (exception $
ex) {
        $v6 = closure5($v2, $ex);
    }
    switch ($v6->get_Tag())
    {
        case 0:
            return $v6->f0_0;
        default:
            return method0($v0_1, $v1_1, $v2 + 1);
    }
}

#11
function closure2($v0_1, $v1_1) {
    $v3 = method0($v0_1, $v1_1, 0);
    switch ($v3->get_Tag())
    {
        case 0:
            return NULL;
        default:
            return NULL;
    }
}

#12
function closure1($unitVar, $v0_1) {
    return function ($v) use ($closure2, $v0_1) {     return closure2($v0_1, $v);
 };
}

#13
$GLOBALS['v0'] = function ($v) use ($closure0) { return closure0(NULL, $v);
 };

#14
function new_disposable($x) {
    return $GLOBALS['v0']($x);
}

#15
$GLOBALS['v1'] = function ($v) use ($closure1) { return closure1(NULL, $v);
 };

#16
function retry_fn($x) {
    return $GLOBALS['v1']($x);
}

#17

