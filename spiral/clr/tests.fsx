namespace clr

open clr

module Tests =

    let config n = { Expecto.FsCheckConfig.defaultConfig with maxTest = n }


    let sortEvent event =
        match event with
        | FileSystem.FileSystemChange.Error _ -> 0
        | FileSystem.FileSystemChange.Created _ -> 1
        | FileSystem.FileSystemChange.Changed _ -> 2
        | FileSystem.FileSystemChange.Renamed (_oldPath, _) -> 3
        | FileSystem.FileSystemChange.Deleted _ -> 4

    let formatEvents events =
        events
        |> Seq.toList
        |> List.sortBy (snd >> sortEvent)
        |> List.choose
            (fun (ticks, event) ->
                match event with
                | FileSystem.FileSystemChange.Error _ -> None
                | FileSystem.FileSystemChange.Changed path -> Some (ticks, System.IO.Path.GetFileName path, nameof FileSystem.FileSystemChangeType.Changed)
                | FileSystem.FileSystemChange.Created path -> Some (ticks, System.IO.Path.GetFileName path, nameof FileSystem.FileSystemChangeType.Created)
                | FileSystem.FileSystemChange.Deleted path -> Some (ticks, System.IO.Path.GetFileName path, nameof FileSystem.FileSystemChangeType.Deleted)
                | FileSystem.FileSystemChange.Renamed (_oldPath, path) -> Some (ticks, System.IO.Path.GetFileName path, nameof FileSystem.FileSystemChangeType.Renamed))
        |> List.sortBy (fun (_, path, _) -> path)
        |> List.distinctBy (fun (_, path, event) -> path, event)


    let properties =
        Expecto.Tests.testList "FsCheck samples" [
            Expecto.Tests.test "TicksGuid" {
                let ticksGuid = Core.Guid.newTicksGuid ()
                let ticks = ticksGuid |> Core.Guid.ticksFromGuid
                let newTicksGuid = ticks |> Core.Guid.newGuidFromTicks
                let newTicks = newTicksGuid |> Core.Guid.ticksFromGuid
                Expecto.Expect.equal newTicks ticks ""
            }

            let testEvents write =
                let path = FileSystem.createNewGuidTempDirectory ()
                let stream, disposable = FileSystem.watch path

                let events = System.Collections.Concurrent.ConcurrentBag ()

                let watch () =
                    stream
                    |> FSharp.Control.AsyncSeq.iterAsync (fun event -> async { events.Add event })

                let run () =
                    async {
                        let! child = watch () |> Async.StartChild
                        do! Async.Sleep 150
                        do! write path |> Async.AwaitTask
                        do! child
                    }

                run () |> Async.runWithTimeout 2000

                disposable.Dispose ()
                System.IO.Directory.Delete (path, true)

                let events = formatEvents events

                let eventMap =
                    events
                    |> List.map (fun (ticks, path, event) -> path, (event, ticks))
                    |> List.groupBy fst
                    |> List.map
                        (fun (path, events) ->
                            let event, _ticks =
                                events
                                |> List.map snd
                                |> List.sortByDescending snd
                                |> List.head

                            path, event)
                    |> Map.ofList

                let eventList =
                    events
                    |> List.map (fun (_ticks, path, event) -> path, event)

                eventMap, eventList

            Expecto.Tests.test "create and delete" {
                let write path =
                    task {
                        let n = 3

                        for i = 1 to n do
                            do! System.IO.File.WriteAllTextAsync (path </> $"file{i}.txt", $"{i}")

                        for i = 1 to n do
                            System.IO.File.Delete (path </> $"file{i}.txt")
                    }

                let eventMap, eventList = testEvents write

                Expecto.Expect.sequenceEqual
                    eventList
                    [
                        "file1.txt", nameof FileSystem.FileSystemChangeType.Created
                        "file1.txt", nameof FileSystem.FileSystemChangeType.Changed
                        "file1.txt", nameof FileSystem.FileSystemChangeType.Deleted

                        "file2.txt", nameof FileSystem.FileSystemChangeType.Created
                        "file2.txt", nameof FileSystem.FileSystemChangeType.Changed
                        "file2.txt", nameof FileSystem.FileSystemChangeType.Deleted

                        "file3.txt", nameof FileSystem.FileSystemChangeType.Created
                        "file3.txt", nameof FileSystem.FileSystemChangeType.Changed
                        "file3.txt", nameof FileSystem.FileSystemChangeType.Deleted
                    ]
                    ""

                Expecto.Expect.sequenceEqual
                    eventMap
                    ([
                        "file1.txt", nameof FileSystem.FileSystemChangeType.Deleted
                        "file2.txt", nameof FileSystem.FileSystemChangeType.Deleted
                        "file3.txt", nameof FileSystem.FileSystemChangeType.Deleted
                        ]
                        |> Map.ofList)
                    ""
            }

            Expecto.Tests.test "change" {
                let write path =
                    task {
                        let n = 2

                        for i = 1 to n do
                            do! System.IO.File.WriteAllTextAsync (path </> $"file{i}.txt", $"{i}")

                        for i = 1 to n do
                            do! System.IO.File.WriteAllTextAsync (path </> $"file{i}.txt", "")

                        for i = 1 to n do
                            System.IO.File.Delete (path </> $"file{i}.txt")
                    }

                let eventMap, eventList = testEvents write

                Expecto.Expect.sequenceEqual
                    eventList
                    [
                        "file1.txt", nameof FileSystem.FileSystemChangeType.Created
                        "file1.txt", nameof FileSystem.FileSystemChangeType.Changed
                        "file1.txt", nameof FileSystem.FileSystemChangeType.Deleted

                        "file2.txt", nameof FileSystem.FileSystemChangeType.Created
                        "file2.txt", nameof FileSystem.FileSystemChangeType.Changed
                        "file2.txt", nameof FileSystem.FileSystemChangeType.Deleted
                    ]
                    ""

                Expecto.Expect.sequenceEqual
                    eventMap
                    ([
                        "file1.txt", nameof FileSystem.FileSystemChangeType.Deleted
                        "file2.txt", nameof FileSystem.FileSystemChangeType.Deleted
                        ]
                        |> Map.ofList)
                    ""
            }

            Expecto.Tests.test "rename" {
                let write path =
                    task {
                        let n = 2

                        for i = 1 to n do
                            do! System.IO.File.WriteAllTextAsync (path </> $"file{i}.txt", $"{i}")

                        for i = 1 to n do
                            System.IO.File.Move (path </> $"file{i}.txt", path </> $"file_{i}.txt")

                        for i = 1 to n do
                            System.IO.File.Delete (path </> $"file_{i}.txt")
                    }

                let eventMap, eventList = testEvents write

                Expecto.Expect.sequenceEqual
                    eventList
                    [
                        "file1.txt", nameof FileSystem.FileSystemChangeType.Created
                        "file1.txt", nameof FileSystem.FileSystemChangeType.Changed
                        "file2.txt", nameof FileSystem.FileSystemChangeType.Created
                        "file2.txt", nameof FileSystem.FileSystemChangeType.Changed

                        "file_1.txt", nameof FileSystem.FileSystemChangeType.Renamed
                        "file_1.txt", nameof FileSystem.FileSystemChangeType.Deleted

                        "file_2.txt", nameof FileSystem.FileSystemChangeType.Renamed
                        "file_2.txt", nameof FileSystem.FileSystemChangeType.Deleted
                    ]
                    ""

                Expecto.Expect.sequenceEqual
                    eventMap
                    ([
                        "file1.txt", nameof FileSystem.FileSystemChangeType.Changed
                        "file2.txt", nameof FileSystem.FileSystemChangeType.Changed
                        "file_1.txt", nameof FileSystem.FileSystemChangeType.Deleted
                        "file_2.txt", nameof FileSystem.FileSystemChangeType.Deleted
                        ]
                        |> Map.ofList)
                    ""
            }



            // runTest "Read and write consistency" 100 <|
            //     fun (FsCheck.NonEmptyString str) ->
            //         let path = System.IO.Path.GetTempFileName()
            //         try
            //             System.IO.File.WriteAllText(path, str)
            //             let str' = System.IO.File.ReadAllText(path)
            //             Expecto.Expect.equal str' str "Read and write should be consistent"
            //         finally
            //             System.IO.File.Delete(path)

            // runTest "At least one concurrent write should succeed" 100 <|
            //     fun (FsCheck.NonEmptyString str1, FsCheck.NonEmptyString str2) ->
            //         let writeToFile path content =
            //             try
            //                 System.IO.File.WriteAllText(path, content)
            //                 true
            //             with
            //             | _ -> false
            //         let path = System.IO.Path.GetTempFileName()
            //         try
            //             let task1 = System.Threading.Tasks.Task.Run(fun () -> writeToFile path str1)
            //             let task2 = System.Threading.Tasks.Task.Run(fun () -> writeToFile path str2)
            //             let results = System.Threading.Tasks.Task.WhenAll([task1; task2]).Result
            //             let successCount = results |> Array.sumBy (function true -> 1 | false -> 0)
            //             Expecto.Expect.isGreaterThan successCount 0 "At least one write should succeed"
            //         finally
            //             System.IO.File.Delete(path)
        ]

    [<EntryPoint>]
    let main _ =
        Logger.init ()

        Logger.logTrace (fun () -> "clr / tests / logTrace") getLocals
        System.Threading.Thread.Sleep 1000
        System.Console.Out.Flush ()
        printfn "clr / tests / printfn"

        Expecto.Tests.runTestsWithCLIArgs [] [||] properties
