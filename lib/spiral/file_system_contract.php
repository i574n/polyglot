<?php
namespace File_system;

require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');
require_once(__FABLE_LIBRARY__.'/Option.php');
require_once(__FABLE_LIBRARY__.'/Util.php');

use \FSharpUnion;
use \IComparable;

#0
class IFsExistsSync {
}

#1
class IPathJoin {
}

#2
class IPathDirname {
}

#3
abstract class US1 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US1_US1_0', '\\File_system\\US1_US1_1', '\\File_system\\US1_US1_2' ];
    }
}

#3
class US1_US1_0 extends US1 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US1_0';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__1 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__1;
    }
}

#3
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
        $_cmp__2 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__2;
    }
}

#3
class US1_US1_2 extends US1 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US1_2';
    }
    function get_Tag() {
        return 2;
    }
    function CompareTo($other) {
        $_cmp__3 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__3;
    }
}

#4
abstract class US2 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US2_US2_0', '\\File_system\\US2_US2_1', '\\File_system\\US2_US2_2', '\\File_system\\US2_US2_3', '\\File_system\\US2_US2_4' ];
    }
}

#4
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
        $_cmp__4 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__4;
    }
}

#4
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
        $_cmp__5 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__5;
    }
}

#4
class US2_US2_2 extends US2 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US2_2';
    }
    function get_Tag() {
        return 2;
    }
    function CompareTo($other) {
        $_cmp__6 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__6;
    }
}

#4
class US2_US2_3 extends US2 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US2_3';
    }
    function get_Tag() {
        return 3;
    }
    function CompareTo($other) {
        $_cmp__7 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__7;
    }
}

#4
class US2_US2_4 extends US2 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US2_4';
    }
    function get_Tag() {
        return 4;
    }
    function CompareTo($other) {
        $_cmp__8 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__8;
    }
}

#5
abstract class US0 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US0_US0_0', '\\File_system\\US0_US0_1' ];
    }
}

#5
class US0_US0_0 extends US0 implements IComparable {
    public $f0_0;
    public $f0_1;
    function __construct($f0_0, $f0_1) {
        $this->f0_0 = $f0_0;
        $this->f0_1 = $f0_1;
    }
    static function get_FSharpCase() {
        return 'US0_0';
    }
    static function get_f0_0_Type() {
        return '\\File_system\\US1';
    }
    static function get_f0_1_Type() {
        return '\\File_system\\US2';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__9 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__9 != 0) {
            return $_cmp__9;
        }        
        $_cmp__10 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__10 != 0) {
            return $_cmp__10;
        }        
        $_cmp__11 = $this->f0_1->CompareTo($other->f0_1);
        if ($_cmp__11 != 0) {
            return $_cmp__11;
        }        
        return 0;
    }
}

#5
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
        $_cmp__12 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__12;
    }
}

#6
abstract class US3 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US3_US3_0', '\\File_system\\US3_US3_1' ];
    }
}

#6
class US3_US3_0 extends US3 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US3_0';
    }
    static function get_f0_0_Type() {
        return 'Int64';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__13 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__13 != 0) {
            return $_cmp__13;
        }        
        $_cmp__14 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__14 != 0) {
            return $_cmp__14;
        }        
        return 0;
    }
}

#6
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
        $_cmp__15 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__15;
    }
}

#7
abstract class US4 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US4_US4_0', '\\File_system\\US4_US4_1' ];
    }
}

#7
class US4_US4_0 extends US4 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US4_0';
    }
    static function get_f0_0_Type() {
        return 'Int64';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__16 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__16 != 0) {
            return $_cmp__16;
        }        
        $_cmp__17 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__17 != 0) {
            return $_cmp__17;
        }        
        return 0;
    }
}

#7
class US4_US4_1 extends US4 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US4_1';
    }
    static function get_f1_0_Type() {
        return '\\File_system\\System_Exception';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__18 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__18 != 0) {
            return $_cmp__18;
        }        
        $_cmp__19 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__19 != 0) {
            return $_cmp__19;
        }        
        return 0;
    }
}

#8
abstract class US5 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US5_US5_0', '\\File_system\\US5_US5_1' ];
    }
}

#8
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
        $_cmp__20 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__20 != 0) {
            return $_cmp__20;
        }        
        $_cmp__21 = $this->f0_0 > $other->f0_0 ? 1 : ($this->f0_0 < $other->f0_0 ? -1 : 0);
        if ($_cmp__21 != 0) {
            return $_cmp__21;
        }        
        return 0;
    }
}

#8
class US5_US5_1 extends US5 implements IComparable {
    public $f1_0;
    function __construct($f1_0) {
        $this->f1_0 = $f1_0;
    }
    static function get_FSharpCase() {
        return 'US5_1';
    }
    static function get_f1_0_Type() {
        return '\\File_system\\System_Exception';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__22 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__22 != 0) {
            return $_cmp__22;
        }        
        $_cmp__23 = $this->f1_0->CompareTo($other->f1_0);
        if ($_cmp__23 != 0) {
            return $_cmp__23;
        }        
        return 0;
    }
}

#9
abstract class US6 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US6_US6_0', '\\File_system\\US6_US6_1' ];
    }
}

#9
class US6_US6_0 extends US6 implements IComparable {
    public $f0_0;
    function __construct($f0_0) {
        $this->f0_0 = $f0_0;
    }
    static function get_FSharpCase() {
        return 'US6_0';
    }
    static function get_f0_0_Type() {
        return 'String';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__24 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        if ($_cmp__24 != 0) {
            return $_cmp__24;
        }        
        $_cmp__25 = $this->f0_0->CompareTo($other->f0_0);
        if ($_cmp__25 != 0) {
            return $_cmp__25;
        }        
        return 0;
    }
}

#9
class US6_US6_1 extends US6 implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'US6_1';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__26 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__26;
    }
}

#10
function US1__get_IsUS1_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#11
function US1__get_IsUS1_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#12
function US1__get_IsUS1_2($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#13
function US2__get_IsUS2_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#14
function US2__get_IsUS2_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#15
function US2__get_IsUS2_2($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#16
function US2__get_IsUS2_3($this_, $unitArg) {
    if ($this_->get_Tag() == 3) {
        return true;
    } else {
        return false;
    }
}

#17
function US2__get_IsUS2_4($this_, $unitArg) {
    if ($this_->get_Tag() == 4) {
        return true;
    } else {
        return false;
    }
}

#18
function US0__get_IsUS0_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#19
function US0__get_IsUS0_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#20
function US3__get_IsUS3_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#21
function US3__get_IsUS3_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#22
function US4__get_IsUS4_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#23
function US4__get_IsUS4_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#24
function US5__get_IsUS5_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#25
function US5__get_IsUS5_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#26
function US6__get_IsUS6_0($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#27
function US6__get_IsUS6_1($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#28
function closure2($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#29
function closure3($unitVar, $unitVar_1) {
    return '';
}

#30
function method1($v0_1, $v1) {
    return NULL;
}

#31
function closure1($v0_1, $v1, $unitVar) {
    return method1($v0_1, $v1);
}

#32
function method0($v0_1, $v1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#33
function closure0($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#34
function method3($v0_1, $v1) {
    return NULL;
}

#35
function closure6($v0_1, $v1, $unitVar) {
    return method3($v0_1, $v1);
}

#36
function method2($v0_1, $v1, $v2, $v3) {
    $_v4 = NULL;
    $x = \Util\defaultOf();
    $_v4 = $x;
    return \Option\value($_v4);
}

#37
function closure5($v0_1, $v1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#38
function closure4($unitVar, $v0_1) {
    return function ($v) use ($closure5, $v0_1) {     return closure5($v0_1, $v);
 };
}

#39
function method4($v0_1, $v1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#40
function closure7($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#41
function closure8($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#42
function method5($v0_1) {
    return $v0_1;
}

#43
function closure10($v0_1, $v1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#44
function closure9($unitVar, $v0_1) {
    return function ($v) use ($closure10, $v0_1) {     return closure10($v0_1, $v);
 };
}

#45
function closure12($v0_1, $v1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#46
function closure11($unitVar, $v0_1) {
    return function ($v) use ($closure12, $v0_1) {     return closure12($v0_1, $v);
 };
}

#47
function closure14($v0_1, $v1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#48
function closure13($unitVar, $v0_1) {
    return function ($v) use ($closure14, $v0_1) {     return closure14($v0_1, $v);
 };
}

#49
function method6($v0_1, $v1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#50
function closure15($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#51
function method8($v0_1, $v1, $v2) {
    $_v3 = NULL;
    $x = \Util\defaultOf();
    $_v3 = $x;
    $v9 = \Option\value($_v3);
    $v10 = function ($v) use ($closure2) {     return closure2(NULL, $v);
 };
    return NULL;
}

#52
function closure18($v0_1, $v1, $v2, $unitVar) {
    return method8($v0_1, $v1, $v2);
}

#53
function method7($v0_1, $v1, $v2) {
    $_v3 = NULL;
    $x = \Util\defaultOf();
    $_v3 = $x;
    return \Option\value($_v3);
}

#54
function closure17($v0_1, $v1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#55
function closure16($unitVar, $v0_1) {
    return function ($v) use ($closure17, $v0_1) {     return closure17($v0_1, $v);
 };
}

#56
function closure20($unitVar, $v0_1) {
    return new US4_US4_0($v0_1);
}

#57
function closure21($unitVar, $v0_1) {
    return new US4_US4_1($v0_1);
}

#58
function closure22($unitVar, $unitVar_1) {
    return NULL;
}

#59
function method10($v0_1, $v1) {
    return NULL;
}

#60
function closure23($v0_1, $v1, $unitVar) {
    return method10($v0_1, $v1);
}

#61
function method9($v0_1, $v1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#62
function closure19($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#63
function closure25($unitVar, $unitVar_1) {
    $_v0_1 = NULL;
    $x = \Util\defaultOf();
    $_v0_1 = $x;
    return \Option\value($_v0_1);
}

#64
function closure24($unitVar, $unitVar_1) {
    $_v0_1 = NULL;
    $x = \Util\defaultOf();
    $_v0_1 = $x;
    return \Option\value($_v0_1);
}

#65
function closure27($v0_1, $v1, $unitVar) {
    return NULL;
}

#66
function closure28($v0_1, $unitVar) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    $v8 = \Option\value($_v1);
    $_v9 = NULL;
    $x_1 = \Util\defaultOf();
    $_v9 = $x_1;
    $v16 = \Option\value($_v9);
    $_v17 = NULL;
    $x_2 = \Util\defaultOf();
    $_v17 = $x_2;
    \Option\value($_v17);
    return NULL;
}

#67
function closure26($unitVar, $unitVar_1) {
    $_v0_1 = NULL;
    $x = [ \Util\defaultOf(), \Util\defaultOf() ];
    $_v0_1 = $x;
    $patternInput = \Option\value($_v0_1);
    return [ $patternInput[0], $patternInput[1] ];
}

#68
function closure29($unitVar, $unitVar_1) {
    return 'C:\\home\\git\\polyglot\\lib\\spiral';
}

#69
function closure33($unitVar, $v0_1) {
    $_v1 = NULL;
    $_v1 = false;
    return \Option\value($_v1);
}

#70
function closure34($unitVar, $v0_1) {
    $_v1 = NULL;
    $_v1 = false;
    return \Option\value($_v1);
}

#71
function closure35($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = $US6();
    $_v1 = $x;
    $v39 = \Option\value($_v1);
    switch ($v39->get_Tag())
    {
        case 0:
            return $v39->f0_0;
        default:
            return NULL;
    }
}

#72
function method12($unitVar) {
    return function ($v) use ($closure35) {     return closure35(NULL, $v);
 };
}

#73
function closure36($unitVar, $v0_1) {
    return new US6_US6_0($v0_1);
}

#74
function method13($unitVar) {
    return function ($v) use ($closure36) {     return closure36(NULL, $v);
 };
}

#75
function method14($v0_1, $v1, $v2, $v3) {
    $_v4 = NULL;
    $x = \Util\defaultOf();
    $_v4 = $x;
    if ($v1 ? function ($v) use ($closure33) {     return closure33(NULL, $v);
 } : function ($v_1) use ($closure34) {     return closure34(NULL, $v_1);
 }(\Option\value($_v4))) {
        return $v3;
    } else {
        $v36 = method12(NULL)($v3);
        $v39 = \Option\defaultArg(\Option\map(method13(NULL), $v36), new US6_US6_1());
        switch ($v39->get_Tag())
        {
            case 0:
                return method14($v0_1, $v1, $v2, $v39->f0_0);
            default:
                throw new \Exception(NULL);
        }
    }
}

#76
function method11($v0_1, $v1, $v2) {
    $_v3 = NULL;
    $x = \Util\defaultOf();
    $_v3 = $x;
    if ($v1 ? function ($v) use ($closure33) {     return closure33(NULL, $v);
 } : function ($v_1) use ($closure34) {     return closure34(NULL, $v_1);
 }(\Option\value($_v3))) {
        return $v2;
    } else {
        $v35 = method12(NULL)($v2);
        $v38 = \Option\defaultArg(\Option\map(method13(NULL), $v35), new US6_US6_1());
        switch ($v38->get_Tag())
        {
            case 0:
                return method14($v0_1, $v1, $v2, $v38->f0_0);
            default:
                throw new \Exception(NULL);
        }
    }
}

#77
function closure32($v0_1, $v1, $v2) {
    return method11($v0_1, $v1, $v2);
}

#78
function closure31($v0_1, $v1) {
    return function ($v) use ($closure32, $v0_1, $v1) {     return closure32($v0_1, $v1, $v);
 };
}

#79
function closure30($unitVar, $v0_1) {
    return function ($v) use ($closure31, $v0_1) {     return closure31($v0_1, $v);
 };
}

#80
function closure38($v0_1, $v1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#81
function closure37($unitVar, $v0_1) {
    return function ($v) use ($closure38, $v0_1) {     return closure38($v0_1, $v);
 };
}

#82
$GLOBALS['v0'] = NULL;

#83
$GLOBALS['_v0'] = $GLOBALS['v0'];

#84
$x = \Util\defaultOf();
$GLOBALS['_v0'] = $x;

#85
\Option\value($GLOBALS['_v0']);

#86
$GLOBALS['v11'] = function ($arg10_0040) use ($closure24) { return closure24(NULL, NULL);
 };

#87
function create_temp_directory_name($unitVar) {
    return $GLOBALS['v11'](NULL);
}

#88
$GLOBALS['v12'] = function ($arg10_0040) use ($closure26) { return closure26(NULL, NULL);
 };

#89
function create_temp_directory($unitVar) {
    return $GLOBALS['v12'](NULL);
}

#90
$GLOBALS['v13'] = function ($arg10_0040) use ($closure29) { return closure29(NULL, NULL);
 };

#91
function get_source_directory($unitVar) {
    return $GLOBALS['v13'](NULL);
}

#92
$GLOBALS['v14'] = function ($v) use ($closure30) { return closure30(NULL, $v);
 };

#93
function find_parent($x) {
    return $GLOBALS['v14']($x);
}

#94
$GLOBALS['v15'] = function ($v) use ($closure37) { return closure37(NULL, $v);
 };

#95
function op_LessDivideGreater($x) {
    return $GLOBALS['v15']($x);
}

#96

