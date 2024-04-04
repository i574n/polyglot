<?php
namespace File_system;

require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');
require_once(__FABLE_LIBRARY__.'/Option.php');
require_once(__FABLE_LIBRARY__.'/Util.php');

use \FSharpUnion;
use \IComparable;

#0
abstract class US0 implements FSharpUnion {
    static function allCases() {
        return [ '\\File_system\\US0_US0_0', '\\File_system\\US0_US0_1' ];
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
        return 'String';
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
function method0($v0_1) {
    return $v0_1;
}

#4
function closure0($unitVar, $unitVar_1) {
    $_v0 = NULL;
    $x = \Util\defaultOf();
    $_v0 = $x;
    return \Option\value($_v0);
}

#5
function closure3($unitVar, $unitVar_1) {
    return '';
}

#6
function closure2($v0_1, $v1_1, $unitVar) {
    return NULL;
}

#7
function closure1($unitVar, $unitVar_1) {
    $_v0 = NULL;
    $x = \Util\defaultOf();
    $_v0 = $x;
    return \Option\value($_v0);
}

#8
function closure4($unitVar, $unitVar_1) {
    return 'C:\\home\\git\\polyglot\\lib\\spiral';
}

#9
function closure8($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#10
function closure9($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    return \Option\value($_v1);
}

#11
function closure10($unitVar, $v0_1) {
    $_v1 = NULL;
    $x = \Util\defaultOf();
    $_v1 = $x;
    $v37 = \Option\value($_v1);
    switch ($v37->get_Tag())
    {
        case 0:
            return $v37->f0_0;
        default:
            return NULL;
    }
}

#12
function method2($unitVar) {
    return function ($v) use ($closure10) {     return closure10(NULL, $v);
 };
}

#13
function closure11($unitVar, $v0_1) {
    return new US0_US0_0($v0_1);
}

#14
function method3($unitVar) {
    return function ($v) use ($closure11) {     return closure11(NULL, $v);
 };
}

#15
function method4($v0_1, $v1_1, $v2_1, $v3_1) {
    $_v4 = NULL;
    $x = \Util\defaultOf();
    $_v4 = $x;
    if ($v1_1 ? function ($v) use ($closure8) {     return closure8(NULL, $v);
 } : function ($v_1) use ($closure9) {     return closure9(NULL, $v_1);
 }(\Option\value($_v4))) {
        return $v3_1;
    } else {
        $v34 = method2(NULL)($v3_1);
        $v37 = \Option\defaultArg(\Option\map(method3(NULL), $v34), new US0_US0_1());
        switch ($v37->get_Tag())
        {
            case 0:
                return method4($v0_1, $v1_1, $v2_1, $v37->f0_0);
            default:
                throw new \Exception(NULL);
        }
    }
}

#16
function method1($v0_1, $v1_1, $v2_1) {
    $_v3 = NULL;
    $x = \Util\defaultOf();
    $_v3 = $x;
    if ($v1_1 ? function ($v) use ($closure8) {     return closure8(NULL, $v);
 } : function ($v_1) use ($closure9) {     return closure9(NULL, $v_1);
 }(\Option\value($_v3))) {
        return $v2_1;
    } else {
        $v33 = method2(NULL)($v2_1);
        $v36 = \Option\defaultArg(\Option\map(method3(NULL), $v33), new US0_US0_1());
        switch ($v36->get_Tag())
        {
            case 0:
                return method4($v0_1, $v1_1, $v2_1, $v36->f0_0);
            default:
                throw new \Exception(NULL);
        }
    }
}

#17
function closure7($v0_1, $v1_1, $v2_1) {
    return method1($v0_1, $v1_1, $v2_1);
}

#18
function closure6($v0_1, $v1_1) {
    return function ($v) use ($closure7, $v0_1, $v1_1) {     return closure7($v0_1, $v1_1, $v);
 };
}

#19
function closure5($unitVar, $v0_1) {
    return function ($v) use ($closure6, $v0_1) {     return closure6($v0_1, $v);
 };
}

#20
function closure13($v0_1, $v1_1) {
    $_v2 = NULL;
    $x = \Util\defaultOf();
    $_v2 = $x;
    return \Option\value($_v2);
}

#21
function closure12($unitVar, $v0_1) {
    return function ($v) use ($closure13, $v0_1) {     return closure13($v0_1, $v);
 };
}

#22
$GLOBALS['v0'] = function ($arg10_0040) use ($closure0) { return closure0(NULL, NULL);
 };

#23
function create_temp_directory_name($unitVar) {
    return $GLOBALS['v0'](NULL);
}

#24
$GLOBALS['v1'] = function ($arg10_0040) use ($closure1) { return closure1(NULL, NULL);
 };

#25
function create_temp_directory($unitVar) {
    return $GLOBALS['v1'](NULL);
}

#26
$GLOBALS['v2'] = function ($arg10_0040) use ($closure4) { return closure4(NULL, NULL);
 };

#27
function get_source_directory($unitVar) {
    return $GLOBALS['v2'](NULL);
}

#28
$GLOBALS['v3'] = function ($v) use ($closure5) { return closure5(NULL, $v);
 };

#29
function find_parent($x) {
    return $GLOBALS['v3']($x);
}

#30
$GLOBALS['v4'] = function ($v) use ($closure12) { return closure12(NULL, $v);
 };

#31
function op_LessDivideGreater($x) {
    return $GLOBALS['v4']($x);
}

#32

