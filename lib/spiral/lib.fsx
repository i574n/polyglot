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

module SpiralCrypto =
    let hash_text x =
#if !INTERACTIVE
        Crypto.hash_text x
#else
        hash_text x
#endif

    let hash_to_port x =
#if !INTERACTIVE
        Crypto.hash_to_port x
#else
        hash_to_port x
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

module SpiralPlatform =
    let get_executable_suffix () =
#if !INTERACTIVE
        Platform.get_executable_suffix ()
#else
        get_executable_suffix ()
#endif

    let is_windows () =
#if !INTERACTIVE
        Platform.is_windows ()
#else
        is_windows ()
#endif

module SpiralRuntime =
    let current_process_kill () =
#if !INTERACTIVE
        Runtime.current_process_kill ()
#else
        current_process_kill ()
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

    let execution_options x =
#if !INTERACTIVE
        Runtime.execution_options x
#else
        execution_options x
#endif

    let split_args x =
#if !INTERACTIVE
        Runtime.split_args x
#else
        split_args x
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

    let replace_regex x =
#if !INTERACTIVE
        Sm.replace_regex x
#else
        replace_regex x
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
    let get_workspace_root () =
#if !INTERACTIVE
        File_system.get_workspace_root ()
#else
        get_workspace_root ()
#endif

    let get_source_directory () =
#if !INTERACTIVE
        File_system.get_source_directory ()
#else
        get_source_directory ()
#endif

    let normalize_path x =
#if !INTERACTIVE
        File_system.normalize_path x
#else
        normalize_path x
#endif

    let new_file_uri x =
#if !INTERACTIVE
        File_system.new_file_uri x
#else
        new_file_uri x
#endif

    let create_temp_dir () =
#if !INTERACTIVE
        File_system.create_temp_dir ()
#else
        create_temp_dir ()
#endif

    let create_temp_dir' x =
#if !INTERACTIVE
        File_system.create_temp_dir' x
#else
        create_temp_dir' x
#endif

    let create_temp_path () =
#if !INTERACTIVE
        File_system.create_temp_path ()
#else
        create_temp_path ()
#endif

#if !FABLE_COMPILER && !WASM && !CONTRACT

    let delete_directory_async x =
#if !INTERACTIVE
        File_system.delete_directory_async x
#else
        delete_directory_async x
#endif

    let trace_file x =
#if !INTERACTIVE
        File_system.trace_file x
#else
        trace_file x
#endif

    let init_trace_file x =
#if !INTERACTIVE
        File_system.init_trace_file x
#else
        init_trace_file x
#endif

#if !INTERACTIVE
        let struct (_, _, _, _, trace_file, _) = File_system.TraceState.trace_state |> Option.get
        let new_trace_file = trace_file.l0

        let struct (_, _, _, _, trace_file, _) = Networking.TraceState.trace_state |> Option.get
        trace_file.l0 <-
            match new_trace_file with
            | File_system.US0_0 -> Networking.US0_0
            | File_system.US0_1 -> Networking.US0_1
            | File_system.US0_2 -> Networking.US0_2
            | File_system.US0_3 -> Networking.US0_3
            | File_system.US0_4 -> Networking.US0_4

        let struct (_, _, _, _, trace_file, _) = Runtime.TraceState.trace_state |> Option.get
        trace_file.l0 <-
            match new_trace_file with
            | File_system.US0_0 -> Runtime.US0_0
            | File_system.US0_1 -> Runtime.US0_1
            | File_system.US0_2 -> Runtime.US0_2
            | File_system.US0_3 -> Runtime.US0_3
            | File_system.US0_4 -> Runtime.US0_4

        let struct (_, _, _, _, trace_file, _) = Trace.TraceState.trace_state |> Option.get
        trace_file.l0 <-
            match new_trace_file with
            | File_system.US0_0 -> Trace.US0_0
            | File_system.US0_1 -> Trace.US0_1
            | File_system.US0_2 -> Trace.US0_2
            | File_system.US0_3 -> Trace.US0_3
            | File_system.US0_4 -> Trace.US0_4

        let struct (_, _, _, _, trace_file, _) = Common.TraceState.trace_state |> Option.get
        trace_file.l0 <-
            match new_trace_file with
            | File_system.US0_0 -> Common.US0_0
            | File_system.US0_1 -> Common.US0_1
            | File_system.US0_2 -> Common.US0_2
            | File_system.US0_3 -> Common.US0_3
            | File_system.US0_4 -> Common.US0_4
#else
        let struct (_, _, _, _, trace_file, _) = TraceState.trace_state |> Option.get
        let new_trace_file = trace_file.l0
        ()
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

    let link_directory x =
#if !INTERACTIVE
        File_system.link_directory x
#else
        link_directory x
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
    Networking.TraceState.trace_state
    |> Option.iter (fun struct (_, _, _, _, level, _) ->
        level.l0 <-
            match new_level with
            | Trace.US0_0 -> Networking.US0_0
            | Trace.US0_1 -> Networking.US0_1
            | Trace.US0_2 -> Networking.US0_2
            | Trace.US0_3 -> Networking.US0_3
            | Trace.US0_4 -> Networking.US0_4
    )

    File_system.TraceState.trace_state
    |> Option.iter (fun struct (_, _, _, _, level, _) ->
        level.l0 <-
            match new_level with
            | Trace.US0_0 -> File_system.US0_0
            | Trace.US0_1 -> File_system.US0_1
            | Trace.US0_2 -> File_system.US0_2
            | Trace.US0_3 -> File_system.US0_3
            | Trace.US0_4 -> File_system.US0_4
    )

    Runtime.TraceState.trace_state
    |> Option.iter (fun struct (_, _, _, _, level, _) ->
        level.l0 <-
            match new_level with
            | Trace.US0_0 -> Runtime.US0_0
            | Trace.US0_1 -> Runtime.US0_1
            | Trace.US0_2 -> Runtime.US0_2
            | Trace.US0_3 -> Runtime.US0_3
            | Trace.US0_4 -> Runtime.US0_4
    )

    Common.TraceState.trace_state
    |> Option.iter (fun struct (_, _, _, _, level, _) ->
        level.l0 <-
            match new_level with
            | Trace.US0_0 -> Common.US0_0
            | Trace.US0_1 -> Common.US0_1
            | Trace.US0_2 -> Common.US0_2
            | Trace.US0_3 -> Common.US0_3
            | Trace.US0_4 -> Common.US0_4
    )

    Trace.TraceState.trace_state
#else
    TraceState.trace_state
#endif
    |> Option.iter (fun (struct (_, _, _, _, level, _)) ->
        level.l0 <- new_level
    )

let get_trace_level () =
#if !INTERACTIVE
    Trace.TraceState.trace_state
#else
    TraceState.trace_state
#endif
    |> Option.map (fun struct (_, _, _, _, level, _) ->
        level.l0
    )
    |> Option.defaultWith (fun () -> failwith "lib.get_trace_level / trace_state=None")
