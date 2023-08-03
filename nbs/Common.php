<?php
namespace Polyglot\Common;

require_once(__FABLE_LIBRARY__.'/FSharp.Core.php');
require_once(__FABLE_LIBRARY__.'/String.php');
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
        return [ '\\Polyglot\\Common\\TraceLevel_Verbose', '\\Polyglot\\Common\\TraceLevel_Debug', '\\Polyglot\\Common\\TraceLevel_Info', '\\Polyglot\\Common\\TraceLevel_Warn', '\\Polyglot\\Common\\TraceLevel_Error' ];
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
class TraceLevel_Warn extends TraceLevel implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'Warn';
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
class TraceLevel_Error extends TraceLevel implements IComparable {
    function __construct() {
    }
    static function get_FSharpCase() {
        return 'Error';
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
function replStart($unitVar) {
    return NULL;
}

#7
function trace($level, $fn, $getLocals) {
    if ($GLOBALS['traceEnabled'] ? \Util\compare($level, $GLOBALS['traceLevel']) >= 0 : false) {
        $GLOBALS['traceCount'] = $GLOBALS['traceCount'] + 1;
        $trimChars = [ ' ', '/' ];
        $arg = \String\trimEnd(NULL, $trimChars);
        return $console->log;
    } else {
        return NULL;
    }
}

