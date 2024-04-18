<?php
namespace File_system;

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
class IFsExistsSync {
}

#2
class IPathJoin {
}

#3
class IPathDirname {
}

#4
class Mut0 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return 'Int64';
    }
    function CompareTo($other) {
        $_cmp__1 = $this->l0 > $other->l0 ? 1 : ($this->l0 < $other->l0 ? -1 : 0);
        if ($_cmp__1 != 0) {
            return $_cmp__1;
        }        
        return 0;
    }
}

#5
class Mut1 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return '??? \'Boolean\'';
    }
    function CompareTo($other) {
        $_cmp__2 = $this->l0->CompareTo($other->l0);
        if ($_cmp__2 != 0) {
            return $_cmp__2;
        }        
        return 0;
    }
}

#6
abstract class US0 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US0_US0_0', '\\File_system\\US0_US0_1', '\\File_system\\US0_US0_2', '\\File_system\\US0_US0_3', '\\File_system\\US0_US0_4' ];
    }
}

#6
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
        $_cmp__3 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__3;
    }
}

#6
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
        $_cmp__4 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__4;
    }
}

#6
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
        $_cmp__5 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__5;
    }
}

#6
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
        $_cmp__6 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__6;
    }
}

#6
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
        $_cmp__7 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__7;
    }
}

#7
class Mut2 implements IComparable {
    public $l0;
    function __construct($l0) {
        $this->l0 = $l0;
    }
    static function get_l0_Type() {
        return '\\File_system\\US0';
    }
    function CompareTo($other) {
        $_cmp__8 = $this->l0->CompareTo($other->l0);
        if ($_cmp__8 != 0) {
            return $_cmp__8;
        }        
        return 0;
    }
}

#8
abstract class US1 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US1_US1_0', '\\File_system\\US1_US1_1' ];
    }
}

#8
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

#8
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

#9
abstract class US3 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US3_US3_0', '\\File_system\\US3_US3_1', '\\File_system\\US3_US3_2' ];
    }
}

#9
class US3_US3_0 extends US3 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US3_0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__12 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__12;
    }
}

#9
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

#9
class US3_US3_2 extends US3 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US3_2';
    }
    function get_Tag() {
        return 2;
    }
    function CompareTo($other) {
        $_cmp__14 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__14;
    }
}

#10
abstract class US4 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US4_US4_0', '\\File_system\\US4_US4_1', '\\File_system\\US4_US4_2', '\\File_system\\US4_US4_3', '\\File_system\\US4_US4_4' ];
    }
}

#10
class US4_US4_0 extends US4 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US4_0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__15 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__15;
    }
}

#10
class US4_US4_1 extends US4 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US4_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__16 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__16;
    }
}

#10
class US4_US4_2 extends US4 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US4_2';
    }
    function get_Tag() {
        return 2;
    }
    function CompareTo($other) {
        $_cmp__17 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__17;
    }
}

#10
class US4_US4_3 extends US4 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US4_3';
    }
    function get_Tag() {
        return 3;
    }
    function CompareTo($other) {
        $_cmp__18 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__18;
    }
}

#10
class US4_US4_4 extends US4 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US4_4';
    }
    function get_Tag() {
        return 4;
    }
    function CompareTo($other) {
        $_cmp__19 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__19;
    }
}

#11
abstract class US2 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US2_US2_0', '\\File_system\\US2_US2_1' ];
    }
}

#11
class US2_US2_0 extends US2 implements IComparable {
    public $f0_0;
    public $f0_1;
    function __construct($f0_0, $f0_1) {
        $this->f0_0 = $f0_0;
        $this->f0_1 = $f0_1;
    }
    static function get_FSharpCase() {
        return 'US2_0';
    }
    static function get_f0_0_Type() {
        return '\\File_system\\US3';
    }
    static function get_f0_1_Type() {
        return '\\File_system\\US4';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__20 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__20 != 0) {
            return $_cmp__20;
        }        
        $_cmp__21 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__21 != 0) {
            return $_cmp__21;
        }        
        $_cmp__22 = $this->f0_1->CompareTo($other->f0_1);
        if ($_cmp__22 != 0) {
            return $_cmp__22;
        }        
        return 0;
    }
}

#11
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
        $_cmp__23 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__23;
    }
}

#12
abstract class US5 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US5_US5_0', '\\File_system\\US5_US5_1' ];
    }
}

#12
class US5_US5_0 extends US5 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US5_0';
    }
    static function get_f0_0_Type() {
        return 'Int64';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__24 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__24 != 0) {
            return $_cmp__24;
        }        
        $_cmp__25 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__25 != 0) {
            return $_cmp__25;
        }        
        return 0;
    }
}

#12
class US5_US5_1 extends US5 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US5_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__26 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__26;
    }
}

#13
abstract class US6 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US6_US6_0', '\\File_system\\US6_US6_1' ];
    }
}

#13
class US6_US6_0 extends US6 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US6_0';
    }
    static function get_f0_0_Type() {
        return 'Int64';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__27 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__27 != 0) {
            return $_cmp__27;
        }        
        $_cmp__28 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__28 != 0) {
            return $_cmp__28;
        }        
        return 0;
    }
}

#13
class US6_US6_1 extends US6 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US6_1';
    }
    static function get_f1_0_Type() {
        return '\\File_system\\System_Exception';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__29 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__29 != 0) {
            return $_cmp__29;
        }        
        $_cmp__30 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__30 != 0) {
            return $_cmp__30;
        }        
        return 0;
    }
}

#14
abstract class US7 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US7_US7_0', '\\File_system\\US7_US7_1' ];
    }
}

#14
class US7_US7_0 extends US7 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US7_0';
    }
    static function get_f0_0_Type() {
        return 'Int64';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__31 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__31 != 0) {
            return $_cmp__31;
        }        
        $_cmp__32 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__32 != 0) {
            return $_cmp__32;
        }        
        return 0;
    }
}

#14
class US7_US7_1 extends US7 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US7_1';
    }
    static function get_f1_0_Type() {
        return '\\File_system\\System_Exception';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__33 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__33 != 0) {
            return $_cmp__33;
        }        
        $_cmp__34 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__34 != 0) {
            return $_cmp__34;
        }        
        return 0;
    }
}

#15
abstract class US8 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US8_US8_0', '\\File_system\\US8_US8_1' ];
    }
}

#15
class US8_US8_0 extends US8 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US8_0';
    }
    static function get_f0_0_Type() {
        return 'String';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__35 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__35 != 0) {
            return $_cmp__35;
        }        
        $_cmp__36 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__36 != 0) {
            return $_cmp__36;
        }        
        return 0;
    }
}

#15
class US8_US8_1 extends US8 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US8_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__37 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__37;
    }
}

#16
function US0__get_IsUS0_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#17
function US0__get_IsUS0_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#18
function US0__get_IsUS0_2($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#19
function US0__get_IsUS0_3($this_, $unitArg) {
    if ($this_->get_Tag() == 3) {
        return true;
    } else {
        return false;
    }
}

#20
function US0__get_IsUS0_4($this_, $unitArg) {
    if ($this_->get_Tag() == 4) {
        return true;
    } else {
        return false;
    }
}

#21
function US1__get_IsUS1_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#22
function US1__get_IsUS1_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#23
function US3__get_IsUS3_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#24
function US3__get_IsUS3_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#25
function US3__get_IsUS3_2($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#26
function US4__get_IsUS4_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#27
function US4__get_IsUS4_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#28
function US4__get_IsUS4_2($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#29
function US4__get_IsUS4_3($this_, $unitArg) {
    if ($this_->get_Tag() == 3) {
        return true;
    } else {
        return false;
    }
}

#30
function US4__get_IsUS4_4($this_, $unitArg) {
    if ($this_->get_Tag() == 4) {
        return true;
    } else {
        return false;
    }
}

#31
function US2__get_IsUS2_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#32
function US2__get_IsUS2_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#33
function US5__get_IsUS5_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#34
function US5__get_IsUS5_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#35
function US6__get_IsUS6_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#36
function US6__get_IsUS6_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#37
function US7__get_IsUS7_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#38
function US7__get_IsUS7_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#39
function US8__get_IsUS8_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#40
function US8__get_IsUS8_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#41
function method0($v0_1) {
    return $v0_1;
}

#42
function method1($v0_1) {
    return $v0_1;
}

#43
function closure0($unitVar, $unitVar_1) {
    $v0_1 = new Mut1(true);
    $v1_1 = new Mut0(NULL);
    $v3_1 = new Mut2(new US0_US0_0());
    $v4_1 = new Mut1(false);
    $_v5 = NULL;
    $x = method1(NULL);
    $_v5 = $x;
    return [ $v1_1, $v4_1, $v0_1, $v3_1, \Option\value($_v5) ];
}

#44
function closure3($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#45
function closure4($unitVar, $unitVar_1) {
    return '';
}

#46
function method3($v0_1, $v1_1) {
    return NULL;
}

#47
function closure2($v0_1, $v1_1, $unitVar) {
    return method3($v0_1, $v1_1);
}

#48
function method2($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#49
function closure1($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#50
function method5($v0_1, $v1_1, $v2_1) {
    return NULL;
}

#51
function closure7($v0_1, $v1_1, $v2_1, $unitVar) {
    return method5($v0_1, $v1_1, $v2_1);
}

#52
function method4($v0_1, $v1_1, $v2_1, $v3_1) {
    $_v4 = NULL;
    $x = \Util\defaultOf();
    $_v4 = $x;
    return \Option\value($_v4);
}

#53
function closure6($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#54
function closure5($unitVar, $v0_1) {
    return function ($v) use ($closure6, $v0_1) {     return closure6($v0_1, $v);
 };
}

#55
function method6($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#56
function closure8($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#57
function closure9($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#58
function method7($v0_1) {
    return $v0_1;
}

#59
function closure11($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#60
function closure10($unitVar, $v0_1) {
    return function ($v) use ($closure11, $v0_1) {     return closure11($v0_1, $v);
 };
}

#61
function closure13($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#62
function closure12($unitVar, $v0_1) {
    return function ($v) use ($closure13, $v0_1) {     return closure13($v0_1, $v);
 };
}

#63
function closure15($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#64
function closure14($unitVar, $v0_1) {
    return function ($v) use ($closure15, $v0_1) {     return closure15($v0_1, $v);
 };
}

#65
function closure17($unitVar, $unitVar_1) {
    return 'delete_file_async';
}

#66
function closure19($unitVar, $v0_1) {
    return new US5_US5_0($v0_1);
}

#67
function method10($unitVar) {
    return function ($v) use ($closure19) {     return closure19(NULL, $v);
 };
}

#68
function method11($unitVar) {
    return '';
}

#69
function closure18($v0_1, $v1_1, $v2_1, $unitVar) {
    if (\Util\equals($GLOBALS['State_trace_state'], NULL)) {
        $GLOBALS['State_trace_state'] = closure0(NULL, NULL);
    } else {
    }
    $patternInput = \Option\value($GLOBALS['State_trace_state']);
    $_v9 = NULL;
    $x = \Util\defaultOf();
    $_v9 = $x;
    $v61 = \Option\value($_v9);
    $v62 = $patternInput[0]->l0;
    switch ($v0_1->get_Tag())
    {
        case 1:
            $v72 = 'Debug';
            break;
        case 2:
            $v72 = 'Info';
            break;
        case 0:
            $v72 = 'Verbose';
            break;
        case 3:
            $v72 = 'Warning';
            break;
        default:
            $v72 = 'Critical';
            break;
    }
    $v73 = $v72->toLocaleLowerCase;
    $_v74 = NULL;
    $x_1 = \Util\defaultOf();
    $_v74 = $x_1;
    return \String\trimEnd(\String\trimStart(NULL, [  ]), [ ' ', '/' ]);
}

#70
function method9($v0_1, $v1_1, $v2_1) {
    $v3_1 = function ($arg10_0040) use ($closure0) {     return closure0(NULL, NULL);
 };
    if (\Util\equals($GLOBALS['State_trace_state'], NULL)) {
        $GLOBALS['State_trace_state'] = $v3_1(NULL);
    } else {
    }
    $v4_1 = \Option\value($GLOBALS['State_trace_state'])[0];
    if (\Util\equals($GLOBALS['State_trace_state'], NULL)) {
        $GLOBALS['State_trace_state'] = $v3_1(NULL);
    } else {
    }
    $patternInput_1 = \Option\value($GLOBALS['State_trace_state']);
    $v14_1 = $patternInput_1[3]->l0;
    if ($patternInput_1[2]->l0 ? \Util\compare($v0_1, $v14_1) >= 0 : false) {
        $v19 = \BigInt\toInt64(\BigInt\op_Addition($v4_1->l0, NULL));
        $v4_1->l0 = $v19;
        $v21 = NULL;
        $_v22 = NULL;
        \Util\defaultOf();
        $_v22 = NULL;
        \Option\value($_v22);
        return NULL;
    } else {
        return NULL;
    }
}

#71
function method8($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#72
function closure16($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#73
function closure22($unitVar, $unitVar_1) {
    return 'move_file_async';
}

#74
function method13($v0_1, $v1_1, $v2_1) {
    $_v3 = NULL;
    $x = \Util\defaultOf();
    $_v3 = $x;
    $v11_1 = \Option\value($_v3);
    $v12_1 = function ($v) use ($closure3) {     return closure3(NULL, $v);
 };
    return NULL;
}

#75
function closure23($v0_1, $v1_1, $v2_1, $unitVar) {
    return method13($v0_1, $v1_1, $v2_1);
}

#76
function method12($v0_1, $v1_1, $v2_1) {
    $_v3 = NULL;
    $x = \Util\defaultOf();
    $_v3 = $x;
    return \Option\value($_v3);
}

#77
function closure21($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#78
function closure20($unitVar, $v0_1) {
    return function ($v) use ($closure21, $v0_1) {     return closure21($v0_1, $v);
 };
}

#79
function closure25($unitVar, $v0_1) {
    return new US6_US6_0($v0_1);
}

#80
function closure26($unitVar, $v0_1) {
    return new US6_US6_1($v0_1);
}

#81
function closure27($unitVar, $unitVar_1) {
    return 'run_with_timeout_async';
}

#82
function closure28($unitVar, $unitVar_1) {
    return NULL;
}

#83
function closure29($v0_1, $unitVar) {
    return NULL;
}

#84
function closure30($unitVar, $unitVar_1) {
    return 'read_all_text_retry_async';
}

#85
function method15($v0_1, $v1_1) {
    return NULL;
}

#86
function closure31($v0_1, $v1_1, $unitVar) {
    return method15($v0_1, $v1_1);
}

#87
function method14($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#88
function closure24($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#89
function closure33($unitVar, $unitVar_1) {
    $_v0 = NULL;
    $x = \Util\defaultOf();
    $_v0 = $x;
    return \Option\value($_v0);
}

#90
function method16($v0_1) {
    return $v0_1;
}

#91
function method17($v0_1) {
    return $v0_1;
}

#92
function closure32($unitVar, $unitVar_1) {
    $_v0 = NULL;
    $x = \Util\defaultOf();
    $_v0 = $x;
    return \Option\value($_v0);
}

#93
function closure35($v0_1, $v1_1, $unitVar) {
    return NULL;
}

#94
function closure36($v0_1, $unitVar) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    $v10_1 = \Option\value($_v1);
    $_v11 = NULL;
    $x_1 = \Util\defaultOf();
    $_v11 = $x_1;
    $v20 = \Option\value($_v11);
    $_v21 = NULL;
    \Util\defaultOf();
    $_v21 = NULL;
    \Option\value($_v21);
    return NULL;
}

#95
function closure34($unitVar, $unitVar_1) {
    $_v0 = NULL;
    $patternInput = [ \Util\defaultOf(), \Util\defaultOf() ];
    $_v0 = [ $patternInput[0], $patternInput[1] ];
    $patternInput_1 = \Option\value($_v0);
    return [ $patternInput_1[0], $patternInput_1[1] ];
}

#96
function closure37($unitVar, $unitVar_1) {
    return 'C:\\home\\git\\polyglot\\lib\\spiral';
}

#97
function closure41($unitVar, $v0_1) {
    $_v1 = NULL;
    $_v1 = false;
    return \Option\value($_v1);
}

#98
function closure42($unitVar, $v0_1) {
    $_v1 = NULL;
    $_v1 = false;
    return \Option\value($_v1);
}

#99
function closure43($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = $US8();
    $_v1 = $x;
    $v43 = \Option\value($_v1);
    switch ($v43->get_Tag())
    {
        case 0:
            return $v43->f0_0;
        default:
            return NULL;
    }
}

#100
function method19($unitVar) {
    return function ($v) use ($closure43) {     return closure43(NULL, $v);
 };
}

#101
function closure44($unitVar, $v0_1) {
    return new US8_US8_0($v0_1);
}

#102
function method20($unitVar) {
    return function ($v) use ($closure44) {     return closure44(NULL, $v);
 };
}

#103
function method21($v0_1, $v1_1, $v2_1, $v3_1) {
    $_v4 = NULL;
    $x = \Util\defaultOf();
    $_v4 = $x;
    if ($v1_1 ? function ($v) use ($closure41) {     return closure41(NULL, $v);
 } : function ($v_1) use ($closure42) {     return closure42(NULL, $v_1);
 }(\Option\value($_v4))) {
        return $v3_1;
    } else {
        $v40 = method19(NULL)($v3_1);
        $v43 = \Option\defaultArg(\Option\map(method20(NULL), $v40), new US8_US8_1());
        switch ($v43->get_Tag())
        {
            case 0:
                return method21($v0_1, $v1_1, $v2_1, $v43->f0_0);
            default:
                throw new \Exception(NULL);
        }
    }
}

#104
function method18($v0_1, $v1_1, $v2_1) {
    $_v3 = NULL;
    $x = \Util\defaultOf();
    $_v3 = $x;
    if ($v1_1 ? function ($v) use ($closure41) {     return closure41(NULL, $v);
 } : function ($v_1) use ($closure42) {     return closure42(NULL, $v_1);
 }(\Option\value($_v3))) {
        return $v2_1;
    } else {
        $v39 = method19(NULL)($v2_1);
        $v42 = \Option\defaultArg(\Option\map(method20(NULL), $v39), new US8_US8_1());
        switch ($v42->get_Tag())
        {
            case 0:
                return method21($v0_1, $v1_1, $v2_1, $v42->f0_0);
            default:
                throw new \Exception(NULL);
        }
    }
}

#105
function closure40($v0_1, $v1_1, $v2_1) {
    return method18($v0_1, $v1_1, $v2_1);
}

#106
function closure39($v0_1, $v1_1) {
    return function ($v) use ($closure40, $v0_1, $v1_1) {     return closure40($v0_1, $v1_1, $v);
 };
}

#107
function closure38($unitVar, $v0_1) {
    return function ($v) use ($closure39, $v0_1) {     return closure39($v0_1, $v);
 };
}

#108
function method22($unitVar) {
    return 'polyglot';
}

#109
function method23($unitVar) {
    return '.paket';
}

#110
function method24($unitVar) {
    return 'polyglot';
}

#111
function method25($unitVar) {
    return '.paket';
}

#112
function method27($v0_1, $v1_1, $v2_1) {
    $_v3 = NULL;
    $x = \Util\defaultOf();
    $_v3 = $x;
    $v33 = \Option\value($_v3);
    $_v34 = NULL;
    $_v34 = false;
    if (\Option\value($_v34)) {
        return $v2_1;
    } else {
        $v59 = method19(NULL)($v2_1);
        $v62 = \Option\defaultArg(\Option\map(method20(NULL), $v59), new US8_US8_1());
        switch ($v62->get_Tag())
        {
            case 0:
                return method27($v0_1, $v1_1, $v62->f0_0);
            default:
                throw new \Exception(NULL);
        }
    }
}

#113
function method26($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    $v32 = \Option\value($_v2);
    $_v33 = NULL;
    $_v33 = false;
    if (\Option\value($_v33)) {
        return $v1_1;
    } else {
        $v58 = method19(NULL)($v1_1);
        $v61 = \Option\defaultArg(\Option\map(method20(NULL), $v58), new US8_US8_1());
        switch ($v61->get_Tag())
        {
            case 0:
                return method27($v0_1, $v1_1, $v61->f0_0);
            default:
                throw new \Exception(NULL);
        }
    }
}

#114
function method28($unitVar) {
    return 'polyglot';
}

#115
function closure45($unitVar, $unitVar_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    $v34 = method26(\Option\value($_v1), 'C:\\home\\git\\polyglot\\lib\\spiral');
    $_v35 = NULL;
    $x_1 = \Util\defaultOf();
    $_v35 = $x_1;
    return \Option\value($_v35);
}

#116
function closure47($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#117
function closure46($unitVar, $v0_1) {
    return function ($v) use ($closure47, $v0_1) {     return closure47($v0_1, $v);
 };
}

#118
$GLOBALS['v0'] = function ($arg10_0040) use ($closure0) { return closure0(NULL, NULL);
 };

#119
if (\Util\equals($GLOBALS['State_trace_state'], NULL)) {
    $GLOBALS['State_trace_state'] = $GLOBALS['v0'](NULL);
} else {
}

#120
$GLOBALS['v1'] = function ($v) use ($closure1) { return closure1(NULL, $v);
 };

#121
function delete_directory_async($x) {
    return $GLOBALS['v1']($x);
}

#122
$GLOBALS['v2'] = function ($v) use ($closure5) { return closure5(NULL, $v);
 };

#123
function wait_for_file_access($x) {
    return $GLOBALS['v2']($x);
}

#124
$GLOBALS['v3'] = function ($v) use ($closure8) { return closure8(NULL, $v);
 };

#125
function wait_for_file_access_read($x) {
    return $GLOBALS['v3']($x);
}

#126
$GLOBALS['v4'] = function ($v) use ($closure9) { return closure9(NULL, $v);
 };

#127
function read_all_text_async($x) {
    return $GLOBALS['v4']($x);
}

#128
$GLOBALS['v5'] = function ($v) use ($closure10) { return closure10(NULL, $v);
 };

#129
function file_exists_content($x) {
    return $GLOBALS['v5']($x);
}

#130
$GLOBALS['v6'] = function ($v) use ($closure12) { return closure12(NULL, $v);
 };

#131
function write_all_text_async($x) {
    return $GLOBALS['v6']($x);
}

#132
$GLOBALS['v7'] = function ($v) use ($closure14) { return closure14(NULL, $v);
 };

#133
function write_all_text_exists($x) {
    return $GLOBALS['v7']($x);
}

#134
$GLOBALS['v8'] = function ($v) use ($closure16) { return closure16(NULL, $v);
 };

#135
function delete_file_async($x) {
    return $GLOBALS['v8']($x);
}

#136
$GLOBALS['v9'] = function ($v) use ($closure20) { return closure20(NULL, $v);
 };

#137
function move_file_async($x) {
    return $GLOBALS['v9']($x);
}

#138
$GLOBALS['v10'] = function ($v) use ($closure24) { return closure24(NULL, $v);
 };

#139
function read_all_text_retry_async($x) {
    return $GLOBALS['v10']($x);
}

#140
$GLOBALS['v11'] = function ($arg10_0040) use ($closure32) { return closure32(NULL, NULL);
 };

#141
function create_temp_directory_name($unitVar) {
    return $GLOBALS['v11'](NULL);
}

#142
$GLOBALS['v12'] = function ($arg10_0040) use ($closure34) { return closure34(NULL, NULL);
 };

#143
function create_temp_directory($unitVar) {
    return $GLOBALS['v12'](NULL);
}

#144
$GLOBALS['v13'] = function ($arg10_0040) use ($closure37) { return closure37(NULL, NULL);
 };

#145
function get_source_directory($unitVar) {
    return $GLOBALS['v13'](NULL);
}

#146
$GLOBALS['v14'] = function ($v) use ($closure38) { return closure38(NULL, $v);
 };

#147
function find_parent($x) {
    return $GLOBALS['v14']($x);
}

#148
$GLOBALS['v15'] = function ($arg10_0040) use ($closure45) { return closure45(NULL, NULL);
 };

#149
function get_repository_root($unitVar) {
    return $GLOBALS['v15'](NULL);
}

#150
$GLOBALS['v16'] = function ($v) use ($closure46) { return closure46(NULL, $v);
 };

#151
function op_LessDivideGreater($x) {
    return $GLOBALS['v16']($x);
}

#152

