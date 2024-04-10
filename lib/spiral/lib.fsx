module SpiralTrace =
    let get_trace_state () =
#if !INTERACTIVE
        Trace.get_trace_state ()
#else
        get_trace_state ()
#endif
    let trace x =
#if !INTERACTIVE
        Trace.trace x
#else
        trace x
#endif

    let US0_0 =
#if !INTERACTIVE
        Trace.US0_0
#else
        US0_0
#endif

    let US0_1 =
#if !INTERACTIVE
        Trace.US0_1
#else
        US0_1
#endif

    let US0_2 =
#if !INTERACTIVE
        Trace.US0_2
#else
        US0_2
#endif

    let US0_3 =
#if !INTERACTIVE
        Trace.US0_3
#else
        US0_3
#endif

    let US0_4 =
#if !INTERACTIVE
        Trace.US0_4
#else
        US0_4
#endif


#if !FABLE_COMPILER && !WASM && !CONTRACT
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

#if !FABLE_COMPILER && !WASM && !CONTRACT

    let delete_directory_async x =
#if !INTERACTIVE
        File_system.delete_directory_async x
#else
        delete_directory_async x
#endif

    let wait_for_file_access x =
#if !INTERACTIVE
        File_system.wait_for_file_access x
#else
        wait_for_file_access x
#endif

    let wait_for_file_access_read x =
#if !INTERACTIVE
        File_system.wait_for_file_access_read x
#else
        wait_for_file_access_read x
#endif

    let read_all_text_async x =
#if !INTERACTIVE
        File_system.read_all_text_async x
#else
        read_all_text_async x
#endif

    let file_exists_content x =
#if !INTERACTIVE
        File_system.file_exists_content x
#else
        file_exists_content x
#endif

    let write_all_text_async x =
#if !INTERACTIVE
        File_system.write_all_text_async x
#else
        write_all_text_async x
#endif

    let write_all_text_exists x =
#if !INTERACTIVE
        File_system.write_all_text_exists x
#else
        write_all_text_exists x
#endif

    let delete_file_async x =
#if !INTERACTIVE
        File_system.delete_file_async x
#else
        delete_file_async x
#endif

    let move_file_async x =
#if !INTERACTIVE
        File_system.move_file_async x
#else
        move_file_async x
#endif

    let read_all_text_retry_async x =
#if !INTERACTIVE
        File_system.read_all_text_retry_async x
#else
        read_all_text_retry_async x
#endif


    module Operators =
        let (</>) x =
#if !INTERACTIVE
            File_system.(</>) x
#else
            (</>) x
#endif

#endif
