<?php
namespace Polyglot\Common;

require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');
require_once(__ROOT__.'/../../../../../lib/spiral/lib.fs.phpx');
require_once(__ROOT__.'/../../../../../lib/spiral/trace.fs.phpx');

use \FSharpUnion;
use \IComparable;

#0
$GLOBALS['nl'] = '
';

#1
$GLOBALS['q'] = '"';

#2
abstract class TraceLevel implements FSharpUnion {
    static function allCases() {
        return [ '\\Polyglot\\Common\\TraceLevel_Verbose', '\\Polyglot\\Common\\TraceLevel_Debug', '\\Polyglot\\Common\\TraceLevel_Info', '\\Polyglot\\Common\\TraceLevel_Warning', '\\Polyglot\\Common\\TraceLevel_Critical' ];
    }
}

#2
class TraceLevel_Verbose extends TraceLevel implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'Verbose';
    }
    function get_Tag() {
        return 0;
    }
    function CompareTo($other) {
        $_cmp__1 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__1;
    }
}

#2
class TraceLevel_Debug extends TraceLevel implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'Debug';
    }
    function get_Tag() {
        return 1;
    }
    function CompareTo($other) {
        $_cmp__2 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__2;
    }
}

#2
class TraceLevel_Info extends TraceLevel implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'Info';
    }
    function get_Tag() {
        return 2;
    }
    function CompareTo($other) {
        $_cmp__3 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__3;
    }
}

#2
class TraceLevel_Warning extends TraceLevel implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'Warning';
    }
    function get_Tag() {
        return 3;
    }
    function CompareTo($other) {
        $_cmp__4 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__4;
    }
}

#2
class TraceLevel_Critical extends TraceLevel implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'Critical';
    }
    function get_Tag() {
        return 4;
    }
    function CompareTo($other) {
        $_cmp__5 = $this->get_Tag() > $other->get_Tag() ? 1 : ($this->get_Tag() < $other->get_Tag() ? -1 : 0);
        return $_cmp__5;
    }
}

#3
function TraceLevel__get_IsVerbose($this_, $unitArg) {
    if ($this_->get_Tag() == 0) {
        return true;
    } else {
        return false;
    }
}

#4
function TraceLevel__get_IsDebug($this_, $unitArg) {
    if ($this_->get_Tag() == 1) {
        return true;
    } else {
        return false;
    }
}

#5
function TraceLevel__get_IsInfo($this_, $unitArg) {
    if ($this_->get_Tag() == 2) {
        return true;
    } else {
        return false;
    }
}

#6
function TraceLevel__get_IsWarning($this_, $unitArg) {
    if ($this_->get_Tag() == 3) {
        return true;
    } else {
        return false;
    }
}

#7
function TraceLevel__get_IsCritical($this_, $unitArg) {
    if ($this_->get_Tag() == 4) {
        return true;
    } else {
        return false;
    }
}

#8
function to_trace_level($_arg) {
    switch ($_arg->get_Tag())
    {
        case 1:
            return new \Trace\US0_US0_1();
        case 2:
            return new \Trace\US0_US0_2();
        case 3:
            return new \Trace\US0_US0_3();
        case 4:
            return new \Trace\US0_US0_4();
        default:
            return new \Trace\US0_US0_0();
    }
}

#9
function trace($level, $fn, $getLocals) {
    return \lib\SpiralTrace_trace(to_trace_level($level))($fn, $getLocals);
}

