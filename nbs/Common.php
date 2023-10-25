<?php
namespace Polyglot\Common;

require_once(__FABLE_LIBRARY__.'/BigInt.php');
require_once(__FABLE_LIBRARY__.'/Date.php');
require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');
require_once(__FABLE_LIBRARY__.'/String.php');
require_once(__FABLE_LIBRARY__.'/TimeSpan.php');
require_once(__FABLE_LIBRARY__.'/Util.php');

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
$GLOBALS['traceEnabled'] = true;

#4
$GLOBALS['traceCount'] = 0;

#5
$GLOBALS['traceLevel'] = new TraceLevel_Verbose();

#6
$GLOBALS['traceDump'] = false;

#7
function testTraceLevel($level) {
    if ($GLOBALS['traceEnabled']) {
        return \Util\compare($level, $GLOBALS['traceLevel']) >= 0;
    } else {
        return false;
    }
}

#8
function traceRaw($level, $fn) {
    if (testTraceLevel($level)) {
        $GLOBALS['traceCount'] = $GLOBALS['traceCount'] + 1;
        $text = NULL;
        return $console->log;
    } else {
        return NULL;
    }
}

#9
function replStart($unitVar) {
    return NULL;
}

#10
function trace($level, $fn, $getLocals) {
    return traceRaw($level, function ($unitVar) use ($fn, $getLocals, $level, $replStart, $traceCount) { 
        $trimChars_2 = [ ' ', '/' ];
        return \String\trimEnd(\String\trimStart(\String\toText(\String\interpolate('%P() #%P() [%A%P()] %s%P() / %s%P()', [ (function ($matchValue) {         if (is_null($matchValue)) {
            return \Date\now();
        } else {
            $replStart_1 = $matchValue;
            $t = \TimeSpan\fromTicks(\BigInt\toInt64(\BigInt\op_Subtraction(\Date\getTicks(\Date\now()), $replStart_1)));
            return \Date\create(1, 1, 1, $t->\TimeSpan\hours(), $t->\TimeSpan\minutes(), $t->\TimeSpan\seconds(), $t->\TimeSpan\milliseconds(), $t->\TimeSpan\microseconds());
        }
 })(replStart(NULL))->\Date\toString('HH:mm:ss'), $GLOBALS['traceCount'], $level, $fn(NULL), $getLocals(NULL) ])), [  ]), $trimChars_2);
    });
}

