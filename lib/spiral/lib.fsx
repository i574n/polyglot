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

    type TraceLevel =
#if !INTERACTIVE
        Trace.US0
#else
        US0
#endif

#if !FABLE_COMPILER && !WASM && !CONTRACT

module SpiralAsync =
    let merge_cancellation_token_with_default_async x =
#if !INTERACTIVE
        Async_.merge_cancellation_token_with_default_async x
#else
        merge_cancellation_token_with_default_async x
#endif

module SpiralRuntime =
    let get_executable_suffix () =
#if !INTERACTIVE
        Runtime.get_executable_suffix ()
#else
        get_executable_suffix ()
#endif

    let is_windows () =
#if !INTERACTIVE
        Runtime.is_windows ()
#else
        is_windows ()
#endif
    let execute_async x =
#if !INTERACTIVE
        Runtime.execute_async x
#else
        execute_async x
#endif

    let execute_with_options_async x =
#if !INTERACTIVE
        Runtime.execute_with_options_async x
#else
        execute_with_options_async x
#endif

    type TraceLevel =
#if !INTERACTIVE
        Runtime.US0
#else
        RuntimeTraceLevel
#endif

module SpiralCrypto =
    let hash_text x =
#if !INTERACTIVE
        Crypto.hash_text x
#else
        hash_text x
#endif
module SpiralDateTime =
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

    let format x =
#if !INTERACTIVE
        Date_time.format x
#else
        format x
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
