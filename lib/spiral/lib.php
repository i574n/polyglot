<?php
namespace Lib;

require_once(__FABLE_LIBRARY__.'/Option.php');
require_once(__FABLE_LIBRARY__.'/String.php');
require_once(__FABLE_LIBRARY__.'/Util.php');
require_once(__ROOT__.'/../../../../../lib/spiral/file_system.fs.phpx');
require_once(__ROOT__.'/../../../../../lib/spiral/networking.fs.phpx');
require_once(__ROOT__.'/../../../../../lib/spiral/runtime.fs.phpx');
require_once(__ROOT__.'/../../../../../lib/spiral/sm.fs.phpx');
require_once(__ROOT__.'/../../../../../lib/spiral/trace.fs.phpx');

#0
function SpiralTrace_trace($x) {
    return \trace\trace($x);
}

#1
function SpiralSm_concat($x) {
    return \sm\concat($x);
}

#2
function SpiralSm_contains($x) {
    return \sm\contains($x);
}

#3
function SpiralSm_ellipsis($x) {
    return \sm\ellipsis($x);
}

#4
function SpiralSm_ellipsis_end($x) {
    return \sm\ellipsis_end($x);
}

#5
function SpiralSm_ends_with($x) {
    return \sm\ends_with($x);
}

#6
function SpiralSm_format_exception($x) {
    return \sm\format_exception($x);
}

#7
function SpiralSm_replace($x) {
    return \sm\replace($x);
}

#8
function SpiralSm_slice($x) {
    return \sm\slice($x);
}

#9
function SpiralSm_split($x) {
    return \sm\split($x);
}

#10
function SpiralSm_split_string($x) {
    return \sm\split_string($x);
}

#11
function SpiralSm_starts_with($x) {
    return \sm\starts_with($x);
}

#12
function SpiralSm_substring($x) {
    return \sm\substring($x);
}

#13
function SpiralSm_to_lower($x) {
    return \sm\to_lower($x);
}

#14
function SpiralSm_trim($x) {
    return \sm\trim($x);
}

#15
function SpiralSm_trim_start($x) {
    return \sm\trim_start($x);
}

#16
function SpiralSm_trim_end($x) {
    return \sm\trim_end($x);
}

#17
function SpiralFileSystem_get_repository_root($unitVar) {
    return \file_system\get_repository_root(NULL);
}

#18
function SpiralFileSystem_get_source_directory($unitVar) {
    return \file_system\get_source_directory(NULL);
}

#19
function SpiralFileSystem_find_parent($x) {
    return \file_system\find_parent($x);
}

#20
function SpiralFileSystem_create_temp_directory($unitVar) {
    return \file_system\create_temp_directory(NULL);
}

#21
function SpiralFileSystem_create_temp_directory_name($unitVar) {
    return \file_system\create_temp_directory_name(NULL);
}

#22
function set_trace_level($new_level) {
    if (\Util\equals(\file_system\State_trace_state, NULL)) {
        \String\toConsole(\String\printf('@1'));
    } else {
        $patternInput = \Option\value(\file_system\State_trace_state);
        $patternInput[3]->l0 = $new_level->get_Tag() == 1 ? new \File_system\US0_US0_1() : ($new_level->get_Tag() == 2 ? new \File_system\US0_US0_2() : ($new_level->get_Tag() == 3 ? new \File_system\US0_US0_3() : ($new_level->get_Tag() == 4 ? new \File_system\US0_US0_4() : new \File_system\US0_US0_0())));
    }
    if (\Util\equals(\networking\State_trace_state, NULL)) {
        \String\toConsole(\String\printf('@2'));
    } else {
        $patternInput_1 = \Option\value(\networking\State_trace_state);
        $patternInput_1[3]->l0 = $new_level->get_Tag() == 1 ? new \Networking\US0_US0_1() : ($new_level->get_Tag() == 2 ? new \Networking\US0_US0_2() : ($new_level->get_Tag() == 3 ? new \Networking\US0_US0_3() : ($new_level->get_Tag() == 4 ? new \Networking\US0_US0_4() : new \Networking\US0_US0_0())));
    }
    if (\Util\equals(\runtime\State_trace_state, NULL)) {
        \String\toConsole(\String\printf('@3'));
    } else {
        $patternInput_2 = \Option\value(\runtime\State_trace_state);
        $patternInput_2[3]->l0 = $new_level->get_Tag() == 1 ? new \Runtime\US0_US0_1() : ($new_level->get_Tag() == 2 ? new \Runtime\US0_US0_2() : ($new_level->get_Tag() == 3 ? new \Runtime\US0_US0_3() : ($new_level->get_Tag() == 4 ? new \Runtime\US0_US0_4() : new \Runtime\US0_US0_0())));
    }
    if (\Util\equals(\trace\State_trace_state, NULL)) {
        return \String\toConsole(\String\printf('@4'));
    } else {
        $patternInput_3 = \Option\value(\trace\State_trace_state);
        $patternInput_3[3]->l0 = $new_level;
    }
}

#23
function get_trace_level($unitVar) {
    if (\Util\equals(\trace\State_trace_state, NULL)) {
        \String\toConsole(\String\printf('@6'));
        return new \Trace\US0_US0_0();
    } else {
        $patternInput = \Option\value(\trace\State_trace_state);
        return $patternInput[3]->l0;
    }
}

