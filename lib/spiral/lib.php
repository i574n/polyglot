<?php
namespace Lib;

require_once(__FABLE_LIBRARY__.'/Option.php');
require_once(__ROOT__.'/../../../../../lib/spiral/common.fs.phpx');
require_once(__ROOT__.'/../../../../../lib/spiral/crypto.fs.phpx');
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
function SpiralCrypto_hash_text($x) {
    return \crypto\hash_text($x);
}

#2
function SpiralSm_concat($x) {
    return \sm\concat($x);
}

#3
function SpiralSm_contains($x) {
    return \sm\contains($x);
}

#4
function SpiralSm_ellipsis($x) {
    return \sm\ellipsis($x);
}

#5
function SpiralSm_ellipsis_end($x) {
    return \sm\ellipsis_end($x);
}

#6
function SpiralSm_ends_with($x) {
    return \sm\ends_with($x);
}

#7
function SpiralSm_format_exception($x) {
    return \sm\format_exception($x);
}

#8
function SpiralSm_replace($x) {
    return \sm\replace($x);
}

#9
function SpiralSm_slice($x) {
    return \sm\slice($x);
}

#10
function SpiralSm_split($x) {
    return \sm\split($x);
}

#11
function SpiralSm_split_string($x) {
    return \sm\split_string($x);
}

#12
function SpiralSm_starts_with($x) {
    return \sm\starts_with($x);
}

#13
function SpiralSm_substring($x) {
    return \sm\substring($x);
}

#14
function SpiralSm_to_lower($x) {
    return \sm\to_lower($x);
}

#15
function SpiralSm_trim($x) {
    return \sm\trim($x);
}

#16
function SpiralSm_trim_start($x) {
    return \sm\trim_start($x);
}

#17
function SpiralSm_trim_end($x) {
    return \sm\trim_end($x);
}

#18
function SpiralFileSystem_get_repository_root($unitVar) {
    return \file_system\get_repository_root(NULL);
}

#19
function SpiralFileSystem_get_source_directory($unitVar) {
    return \file_system\get_source_directory(NULL);
}

#20
function SpiralFileSystem_find_parent($x) {
    return \file_system\find_parent($x);
}

#21
function SpiralFileSystem_normalize_path($x) {
    return \file_system\normalize_path($x);
}

#22
function SpiralFileSystem_new_file_uri($x) {
    return \file_system\new_file_uri($x);
}

#23
function SpiralFileSystem_create_temp_directory($unitVar) {
    return \file_system\create_temp_directory(NULL);
}

#24
function SpiralFileSystem_create_temp_directory_name($unitVar) {
    return \file_system\create_temp_directory_name(NULL);
}

#25
function set_trace_level($new_level) {
    $patternInput = \Option\value(\file_system\State_trace_state);
    $patternInput[2]->l0 = $new_level->get_Tag() == 1 ? new \File_system\US0_US0_1() : ($new_level->get_Tag() == 2 ? new \File_system\US0_US0_2() : ($new_level->get_Tag() == 3 ? new \File_system\US0_US0_3() : ($new_level->get_Tag() == 4 ? new \File_system\US0_US0_4() : new \File_system\US0_US0_0())));
    $patternInput_1 = \Option\value(\networking\State_trace_state);
    $patternInput_1[2]->l0 = $new_level->get_Tag() == 1 ? new \Networking\US0_US0_1() : ($new_level->get_Tag() == 2 ? new \Networking\US0_US0_2() : ($new_level->get_Tag() == 3 ? new \Networking\US0_US0_3() : ($new_level->get_Tag() == 4 ? new \Networking\US0_US0_4() : new \Networking\US0_US0_0())));
    $patternInput_2 = \Option\value(\runtime\State_trace_state);
    $patternInput_2[2]->l0 = $new_level->get_Tag() == 1 ? new \Runtime\US0_US0_1() : ($new_level->get_Tag() == 2 ? new \Runtime\US0_US0_2() : ($new_level->get_Tag() == 3 ? new \Runtime\US0_US0_3() : ($new_level->get_Tag() == 4 ? new \Runtime\US0_US0_4() : new \Runtime\US0_US0_0())));
    $patternInput_3 = \Option\value(\common\State_trace_state);
    $patternInput_3[2]->l0 = $new_level->get_Tag() == 1 ? new \Common\US0_US0_1() : ($new_level->get_Tag() == 2 ? new \Common\US0_US0_2() : ($new_level->get_Tag() == 3 ? new \Common\US0_US0_3() : ($new_level->get_Tag() == 4 ? new \Common\US0_US0_4() : new \Common\US0_US0_0())));
    $patternInput_4 = \Option\value(\trace\State_trace_state);
    $patternInput_4[2]->l0 = $new_level;
}

#26
function get_trace_level($unitVar) {
    $patternInput = \Option\value(\trace\State_trace_state);
    return $patternInput[2]->l0;
}

