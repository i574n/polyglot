module SpiralTrace =
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

module SpiralThreading =
    let new_disposable_token x =
#if !INTERACTIVE
        Threading.new_disposable_token x
#else
        new_disposable_token x
#endif

module SpiralNetworking =
    let test_port_open x =
#if !INTERACTIVE
        Networking.test_port_open x
#else
        test_port_open x
#endif

    let test_port_open_timeout x =
#if !INTERACTIVE
        Networking.test_port_open_timeout x
#else
        test_port_open_timeout x
#endif

    let wait_for_port_access x =
#if !INTERACTIVE
        Networking.wait_for_port_access x
#else
        wait_for_port_access x
#endif

    let get_available_port x =
#if !INTERACTIVE
        Networking.get_available_port x
#else
        get_available_port x
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
    let get_repository_root () =
#if !INTERACTIVE
        File_system.get_repository_root ()
#else
        get_repository_root ()
#endif

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

let set_trace_level new_level =
#if !INTERACTIVE

    if File_system.State.trace_state = None then printfn "@1"
    else
        let struct (_, _, _, level, _) = File_system.State.trace_state |> Option.get
        level.l0 <-
            match new_level with
            | Trace.US0_0 -> File_system.US0_0
            | Trace.US0_1 -> File_system.US0_1
            | Trace.US0_2 -> File_system.US0_2
            | Trace.US0_3 -> File_system.US0_3
            | Trace.US0_4 -> File_system.US0_4

    if Networking.State.trace_state = None then printfn "@2"
    else
        let struct (_, _, _, level, _) = Networking.State.trace_state |> Option.get
        level.l0 <-
            match new_level with
            | Trace.US0_0 -> Networking.US0_0
            | Trace.US0_1 -> Networking.US0_1
            | Trace.US0_2 -> Networking.US0_2
            | Trace.US0_3 -> Networking.US0_3
            | Trace.US0_4 -> Networking.US0_4

    if Runtime.State.trace_state = None then printfn "@3"
    else
        let struct (_, _, _, level, _) = Runtime.State.trace_state |> Option.get
        level.l0 <-
            match new_level with
            | Trace.US0_0 -> Runtime.US0_0
            | Trace.US0_1 -> Runtime.US0_1
            | Trace.US0_2 -> Runtime.US0_2
            | Trace.US0_3 -> Runtime.US0_3
            | Trace.US0_4 -> Runtime.US0_4

    if Trace.State.trace_state = None then printfn "@4"
    else
        let struct (_, _, _, level, _) = Trace.State.trace_state |> Option.get
#else
    if State.trace_state = None then printfn "@5"
    else
        let struct (_, _, _, level, _) = State.trace_state |> Option.get
#endif
        level.l0 <- new_level

let get_trace_level () =
#if !INTERACTIVE
    if Trace.State.trace_state = None then printfn "@6"; SpiralTrace.TraceLevel.US0_0
    else
        let struct (_, _, _, level, _) = Trace.State.trace_state |> Option.get
#else
    if State.trace_state = None then printfn "@7"; SpiralTrace.TraceLevel.US0_0
    else
        let struct (_, _, _, level, _) = State.trace_state |> Option.get
#endif
        level.l0
