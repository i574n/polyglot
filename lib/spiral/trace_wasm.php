<?php
namespace Trace;

require_once(__FABLE_LIBRARY__.'/BigInt.php');
require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');
require_once(__FABLE_LIBRARY__.'/Option.php');
require_once(__FABLE_LIBRARY__.'/String.php');
require_once(__FABLE_LIBRARY__.'/Util.php');

use \FSharpUnion;
use \IComparable;

#0
$GLOBALS['State_trace_state'] = NULL;

#1
abstract class US0 implements FSharpUnion {
    static function allCases() {
        return [ '\\Trace\\US0_US0_0', '\\Trace\\US0_US0_1', '\\Trace\\US0_US0_2', '\\Trace\\US0_US0_3', '\\Trace\\US0_US0_4' ];
    }
}

#1
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

#1
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
class US0_US0_2 extends US0 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US0_2';
    }
    function get_Tag() {
        return 2;
    }
    function CompareTo($other) {
        $_cmp__3 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__3;
    }
}

#1
class US0_US0_3 extends US0 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US0_3';
    }
    function get_Tag() {
        return 3;
    }
    function CompareTo($other) {
        $_cmp__4 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__4;
    }
}

#1
class US0_US0_4 extends US0 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US0_4';
    }
    function get_Tag() {
        return 4;
    }
    function CompareTo($other) {
        $_cmp__5 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__5;
    }
}

#2
class Mut0 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return 'Int64';
    }
    function CompareTo($other) {
        $_cmp__6 = $this->l0 > $other->l0 ? 1 : ($this->l0 < $other->l0 ? -1 : 0);
        if ($_cmp__6 != 0) {
            return $_cmp__6;
        }        
        return 0;
    }
}

#3
class Mut1 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return '??? \'Boolean\'';
    }
    function CompareTo($other) {
        $_cmp__7 = $this->l0->CompareTo($other->l0);
        if ($_cmp__7 != 0) {
            return $_cmp__7;
        }        
        return 0;
    }
}

#4
class Mut2 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return '\\Trace\\US0';
    }
    function CompareTo($other) {
        $_cmp__8 = $this->l0->CompareTo($other->l0);
        if ($_cmp__8 != 0) {
            return $_cmp__8;
        }        
        return 0;
    }
}

#5
abstract class US1 implements FSharpUnion {
    static function allCases() {
        return [ '\\Trace\\US1_US1_0', '\\Trace\\US1_US1_1' ];
    }
}

#5
class US1_US1_0 extends US1 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US1_0';
    }
    static function get_f0_0_Type() {
        return 'Int64';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__9 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__9 != 0) {
            return $_cmp__9;
        }        
        $_cmp__10 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__10 != 0) {
            return $_cmp__10;
        }        
        return 0;
    }
}

#5
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
        $_cmp__11 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__11;
    }
}

#6
abstract class US2 implements FSharpUnion {
    static function allCases() {
        return [ '\\Trace\\US2_US2_0', '\\Trace\\US2_US2_1' ];
    }
}

#6
class US2_US2_0 extends US2 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US2_0';
    }
    static function get_f0_0_Type() {
        return 'Int64';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__12 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__12 != 0) {
            return $_cmp__12;
        }        
        $_cmp__13 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__13 != 0) {
            return $_cmp__13;
        }        
        return 0;
    }
}

#6
class US2_US2_1 extends US2 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US2_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__14 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__14;
    }
}

#7
function US0__get_IsUS0_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#8
function US0__get_IsUS0_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#9
function US0__get_IsUS0_2($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#10
function US0__get_IsUS0_3($this_, $unitArg) {
    if ($this_->get_Tag() == 3) {
        return true;
    } else {
        return false;
    }
}

#11
function US0__get_IsUS0_4($this_, $unitArg) {
    if ($this_->get_Tag() == 4) {
        return true;
    } else {
        return false;
    }
}

#12
function US1__get_IsUS1_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#13
function US1__get_IsUS1_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#14
function US2__get_IsUS2_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#15
function US2__get_IsUS2_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#16
function method1($v0_1) {
    return $v0_1;
}

#17
function method2($v0_1) {
    return $v0_1;
}

#18
function closure3($unitVar, $unitVar_1) {
    $v0_1 = new Mut1(true);
    $v1_1 = new Mut0(NULL);
    $v3 = new Mut2(new US0_US0_0());
    $v4 = new Mut1(false);
    $_v5 = NULL;
    $x = method2(NULL);
    $_v5 = $x;
    return [ $v1_1, $v4, $v0_1, $v3, \Option\value($_v5) ];
}

#19
function closure5($unitVar, $v0_1) {
    return new US2_US2_0($v0_1);
}

#20
function method3($unitVar) {
    return function ($v) use ($closure5) {     return closure5(NULL, $v);
 };
}

#21
function method4($unitVar) {
    return '';
}

#22
function closure4($v0_1, $v1_1, $v2, $unitVar) {
    if (\Util\equals($GLOBALS['State_trace_state'], NULL)) {
        $GLOBALS['State_trace_state'] = closure3(NULL, NULL);
    } else {
    }
    $patternInput = \Option\value($GLOBALS['State_trace_state']);
    $_v9 = NULL;
    $x = \Util\defaultOf();
    $_v9 = $x;
    $v59 = \Option\value($_v9);
    $v60 = $patternInput[0]->l0;
    switch ($v0_1->get_Tag())
    {
        case 1:
            $v70 = 'Debug';
            break;
        case 2:
            $v70 = 'Info';
            break;
        case 0:
            $v70 = 'Verbose';
            break;
        case 3:
            $v70 = 'Warning';
            break;
        default:
            $v70 = 'Critical';
            break;
    }
    return \String\trimEnd(\String\trimStart(NULL, [  ]), [ ' ', '/' ]);
}

#23
function method0($v0_1, $v1_1, $v2) {
    $v3 = function ($arg10_0040) use ($closure3) {     return closure3(NULL, NULL);
 };
    if (\Util\equals($GLOBALS['State_trace_state'], NULL)) {
        $GLOBALS['State_trace_state'] = $v3(NULL);
    } else {
    }
    $v4 = \Option\value($GLOBALS['State_trace_state'])[0];
    if (\Util\equals($GLOBALS['State_trace_state'], NULL)) {
        $GLOBALS['State_trace_state'] = $v3(NULL);
    } else {
    }
    $patternInput_1 = \Option\value($GLOBALS['State_trace_state']);
    $v14 = $patternInput_1[3]->l0;
    if ($patternInput_1[2]->l0 ? \Util\compare($v0_1, $v14) >= 0 : false) {
        $v19 = \BigInt\toInt64(\BigInt\op_Addition($v4->l0, NULL));
        $v4->l0 = $v19;
        $v21 = NULL;
        $_v22 = NULL;
        $x = \Util\defaultOf();
        $_v22 = $x;
        \Option\value($_v22);
        return NULL;
    } else {
        return NULL;
    }
}

#24
function closure2($v0_1, $v1_1, $v2) {
    return method0($v0_1, $v1_1, $v2);
}

#25
function closure1($v0_1, $v1_1) {
    return function ($v) use ($closure2, $v0_1, $v1_1) {     return closure2($v0_1, $v1_1, $v);
 };
}

#26
function closure0($unitVar, $v0_1) {
    return function ($v) use ($closure1, $v0_1) {     return closure1($v0_1, $v);
 };
}

#27
function closure6($unitVar, $unitVar_1) {
    if (\Util\equals($GLOBALS['State_trace_state'], NULL)) {
        $GLOBALS['State_trace_state'] = closure3(NULL, NULL);
    } else {
    }
    $patternInput = \Option\value($GLOBALS['State_trace_state']);
    return [ $patternInput[0], $patternInput[1], $patternInput[2], $patternInput[3], $patternInput[4] ];
}

#28
$GLOBALS['v0'] = function ($v) use ($closure0) { return closure0(NULL, $v);
 };

#29
function trace($x) {
    return $GLOBALS['v0']($x);
}

#30
$GLOBALS['v1'] = function ($arg10_0040) use ($closure6) { return closure6(NULL, NULL);
 };

#31
function get_trace_state($unitVar) {
    return $GLOBALS['v1'](NULL);
}

#32

