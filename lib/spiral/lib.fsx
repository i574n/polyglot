#if !WASM && !CONTRACT && !FABLE_COMPILER
module SpiralDateTime =
    let format x =
#if !INTERACTIVE
        Date_time.format x
#else
        format x
#endif

    let format_iso8601 x =
#if !INTERACTIVE
        Date_time.format_iso8601 x
#else
        format_iso8601 x
#endif

    let new_guid_from_date_time x =
#if !INTERACTIVE
        Date_time.new_guid_from_date_time x
#else
        new_guid_from_date_time x
#endif

#endif

module SpiralSm =
    let concat x =
#if !INTERACTIVE
        Sm.concat x
#else
        concat x
#endif

    let contains x =
#if !INTERACTIVE
        Sm.contains x
#else
        contains x
#endif

    let ellipsis x =
#if !INTERACTIVE
        Sm.ellipsis x
#else
        ellipsis x
#endif

    let ellipsis_end x =
#if !INTERACTIVE
        Sm.ellipsis_end x
#else
        ellipsis_end x
#endif

    let ends_with x =
#if !INTERACTIVE
        Sm.ends_with x
#else
        ends_with x
#endif

    let format_exception x =
#if !INTERACTIVE
        Sm.format_exception x
#else
        format_exception x
#endif

    let replace x =
#if !INTERACTIVE
        Sm.replace x
#else
        replace x
#endif

    let slice x =
#if !INTERACTIVE
        Sm.slice x
#else
        slice x
#endif

    let split x =
#if !INTERACTIVE
        Sm.split x
#else
        split x
#endif

    let split_string x =
#if !INTERACTIVE
        Sm.split_string x
#else
        split_string x
#endif

    let starts_with x =
#if !INTERACTIVE
        Sm.starts_with x
#else
        starts_with x
#endif

    let substring x =
#if !INTERACTIVE
        Sm.substring x
#else
        substring x
#endif

    let to_lower x =
#if !INTERACTIVE
        Sm.to_lower x
#else
        to_lower x
#endif

    let trim x =
#if !INTERACTIVE
        Sm.trim x
#else
        trim x
#endif

    let trim_start x =
#if !INTERACTIVE
        Sm.trim_start x
#else
        trim_start x
#endif

    let trim_end x =
#if !INTERACTIVE
        Sm.trim_end x
#else
        trim_end x
#endif

module SpiralFileSystem =
    let get_source_directory () =
#if !INTERACTIVE
        File_system.get_source_directory ()
#else
        get_source_directory ()
#endif

    let find_parent x =
#if !INTERACTIVE
        File_system.find_parent x
#else
        find_parent x
#endif

    let create_temp_directory () =
#if !INTERACTIVE
        File_system.create_temp_directory ()
#else
        create_temp_directory ()
#endif

    let create_temp_directory_name () =
#if !INTERACTIVE
        File_system.create_temp_directory_name ()
#else
        create_temp_directory_name ()
#endif

#if !FABLE_COMPILER && !FABLE_COMPILER_RUST && !WASM && !CONTRACT
    module Operators =
        let (</>) x =
#if !INTERACTIVE
            File_system.(</>) x
#else
            (</>) x
#endif

#endif
