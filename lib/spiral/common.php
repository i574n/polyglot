<?php
namespace Common;

require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');
require_once(__FABLE_LIBRARY__.'/Option.php');

use \FSharpUnion;
use \IComparable;

#0
abstract class US0 implements FSharpUnion {
    static function allCases() {
        return [ '\\Common\\US0_US0_0', '\\Common\\US0_US0_1', '\\Common\\US0_US0_2', '\\Common\\US0_US0_3' ];
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

#0
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

#0
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
        $_cmp__5 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__5 != 0) {
            return $_cmp__5;
        }        
        $_cmp__6 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__6 != 0) {
            return $_cmp__6;
        }        
        return 0;
    }
}

#1
class US1_US1_1 extends US1 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US1_1';
    }
    static function get_f1_0_Type() {
        return '\\Common\\US0';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__7 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__7 != 0) {
            return $_cmp__7;
        }        
        $_cmp__8 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__8 != 0) {
            return $_cmp__8;
        }        
        return 0;
    }
}

#2
abstract class US2 implements FSharpUnion {
    static function allCases() {
        return [ '\\Common\\US2_US2_0', '\\Common\\US2_US2_1' ];
    }
}

#2
class US2_US2_0 extends US2 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US2_0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__9 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__9;
    }
}

#2
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
        $_cmp__10 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__10;
    }
}

#3
abstract class US3 implements FSharpUnion {
    static function allCases() {
        return [ '\\Common\\US3_US3_0', '\\Common\\US3_US3_1' ];
    }
}

#3
class US3_US3_0 extends US3 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US3_0';
    }
    static function get_f0_0_Type() {
        return '\\Common\\US2';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__11 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__11 != 0) {
            return $_cmp__11;
        }        
        $_cmp__12 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__12 != 0) {
            return $_cmp__12;
        }        
        return 0;
    }
}

#3
class US3_US3_1 extends US3 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US3_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__13 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__13;
    }
}

#4
function US0__get_IsUS0_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#5
function US0__get_IsUS0_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#6
function US0__get_IsUS0_2($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#7
function US0__get_IsUS0_3($this_, $unitArg) {
    if ($this_->get_Tag() == 3) {
        return true;
    } else {
        return false;
    }
}

#8
function US1__get_IsUS1_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#9
function US1__get_IsUS1_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#10
function US2__get_IsUS2_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#11
function US2__get_IsUS2_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#12
function US3__get_IsUS3_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#13
function US3__get_IsUS3_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#14
function closure0($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = [ 'Dispose' => function ($_, $unitVar_1) use ($v0_1) {     return $v0_1(NULL);
 } ];
    $_v1 = $x;
    return \Option\value($_v1);
}

#15
function closure3($v0_1, $v1_1, $v2, $unitVar) {
    if ($v2 < $v0_1) {
        $v1_1(NULL);
        return new US2_US2_0();
    } else {
        return new US2_US2_1();
    }
}

#16
function closure4($unitVar, $v0_1) {
    return new US3_US3_0($v0_1);
}

#17
function closure5($unitVar, $v0_1) {
    $_v1 = NULL;
    $_v1 = NULL;
    \Option\value($_v1);
    return NULL;
}

#18
function method0($v0_1, $v1_1, $v2) {
    try {
        $v7 = closure4(NULL, closure3($v0_1, $v1_1, $v2, NULL));
    }
    catch (exception $
ex) {
        closure5(NULL, $ex);
        $v7 = new US3_US3_1();
    }
    switch ($v7->get_Tag())
    {
        case 0:
            return $v7->f0_0;
        default:
            return method0($v0_1, $v1_1, $v2 + 1);
    }
}

#19
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

#20
function closure1($unitVar, $v0_1) {
    return function ($v) use ($closure2, $v0_1) {     return closure2($v0_1, $v);
 };
}

#21
$GLOBALS['v0'] = function ($v) use ($closure0) { return closure0(NULL, $v);
 };

#22
function new_disposable($x) {
    return $GLOBALS['v0']($x);
}

#23
$GLOBALS['v1'] = function ($v) use ($closure1) { return closure1(NULL, $v);
 };

#24
function retry_fn($x) {
    return $GLOBALS['v1']($x);
}

#25

